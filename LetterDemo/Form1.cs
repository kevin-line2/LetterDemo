using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using SendGrid;
using SendGrid.Transport;

namespace LetterDemo
{
    public partial class Form1 : Form
    {
        string CRLF = "\u000D\u000A";
        string xmlFile = "";        // The output file name of the generated from the mergePairs.
        string xslFile = "";        // The template used to generate the HTML.
        string htmlFile = "";       // The final email output as HTML.
        List<MergePair> mergePairs; // Holds the name-value pairs that are used to generate the xml data.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPath.Text = Application.StartupPath;
        }

        /// <summary>
        /// Set the shared path name.  This will be prefixed to all file names used.
        /// </summary>
        private void btnSetXml_Click(object sender, EventArgs e)
        {
            dlgFolderDefault.SelectedPath = txtPath.Text;
            if (dlgFolderDefault.ShowDialog().Equals(DialogResult.OK))
            {
                txtPath.Text = dlgFolderDefault.SelectedPath;
            }
        }

        /// <summary>
        /// Create the data pairs from SQL. A pair is the column name and the column data.
        /// The store procedure will return a set of column names that can be used as the 
        /// tag names when generating the xml. The xslt will reference those xml tag name 
        /// when merging the document.
        /// </summary>
        private void btnData_Click(object sender, EventArgs e)
        {
            mergePairs = new List<MergePair>();

            try
            {
                LetterHelper db = new LetterHelper();
                SqlParameter[] letterParms = {
                    new SqlParameter("@Key", txtDbKey.Text)
                    };
                DataRow merge = db.ExecuteDataRow(txtDbProc.Text, letterParms);
                if (merge == null)
                    throw new Exception();

                foreach (DataColumn column in merge.Table.Columns)  //loop through the columns. 
                {
                    MergePair pair = new MergePair();
                    pair.tag = column.ColumnName;
                    pair.value = merge[pair.tag].ToString();
                    mergePairs.Add(pair);
                }
                txtStatus.Text += "Data Pairs Loaded = " + mergePairs.Count.ToString() + CRLF;
            }
            catch (Exception ex)
            {
                mergePairs.Clear();
                MergePair filler = new MergePair();
                mergePairs.Add(filler);
                txtStatus.Text += "No Data Pairs Loaded. Error = " + ex.Message + CRLF;
            }
        }

        /// <summary>
        /// Generate the XML from the data pairs.
        /// </summary>
        private void btnGenXml_Click(object sender, EventArgs e)
        {
            // Main Document
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);
            // Processing instruction for xslt
            XmlProcessingInstruction pinst;
            String extra = "type='text/xsl' href='email.xsl'";
            pinst = doc.CreateProcessingInstruction("xml-stylesheet", extra);
            doc.AppendChild(pinst);
            // Root element
            XmlElement root = doc.CreateElement("Details");
            doc.AppendChild(root);
            // Add in the kids
            foreach (MergePair pair in mergePairs)
            {
                XmlElement e_MergeTag = doc.CreateElement(pair.tag);
                e_MergeTag.InnerText = pair.value;
                root.AppendChild(e_MergeTag);
            }
            // Save it off
            xmlFile = txtPath.Text + Path.DirectorySeparatorChar + txtXmlFile.Text;
            doc.Save(xmlFile);
            txtStatus.Text += "XML file generated and saved at " + xmlFile + CRLF;
        }

        /// <summary>
        /// Perform the transformation by conbining the xml data with the xsl template.
        /// The output is an HTML file.  Probably want to used a second template for 
        /// plain text, because the output setting is set in the template (xsl).
        /// </summary>
        private void btnGen_Click(object sender, EventArgs e)
        {
            // According to MSFT, the ".Load" is where the performance hit experienced.
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslFile = txtPath.Text + Path.DirectorySeparatorChar + txtXslFile.Text;
            xslt.Load(xslFile);

            htmlFile = Path.GetDirectoryName(xslFile) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(xslFile) + ".html"; 
            xslt.Transform(xmlFile, htmlFile);
            txtStatus.Text += "HTML file generated and saved at " + htmlFile + CRLF;
        }

        /// <summary>
        /// Send Email using SendGrid.  Just sending HTML only, but could also include
        /// a text version.  Using the WebAPI (not the windows SMTP).  This code requires
        /// the SendGridPlus NuGet package.
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            List<MailAddress> to = new List<MailAddress>();
            List<MailAddress> cc = new List<MailAddress>();
            List<MailAddress> bcc = new List<MailAddress>();
            to.Add(new MailAddress(txtEmailAddr.Text));
            MailAddress from = new MailAddress("azure.acct@toktumi.com");
            string contentHTML = "";
            string contentText = "";

            using (TextReader reader = File.OpenText(htmlFile))
            {
                contentHTML = reader.ReadToEnd();
            }

            Mail msg = SendGrid.Mail.GetInstance();
            msg.From = from;
            msg.To = to.ToArray();
            msg.Cc = cc.ToArray();
            msg.Bcc = bcc.ToArray();
            msg.Subject = txtSubject.Text;
            msg.Text = contentText;
            msg.Html = contentHTML;

            // If an image file name is refernced in the HTML, it will (for the most part) become an inline image.
            foreach (String fname in lstAttachments.Items)
            {
                msg.AddAttachment(txtPath.Text + Path.DirectorySeparatorChar + fname);
            }

            var credentials = new NetworkCredential(txtID.Text, txtPwd.Text);

            // Create an SMTP transport for sending email.
            var transportWeb = Web.GetInstance(credentials);

            // Send the email.
            transportWeb.Deliver(msg);
            txtStatus.Text += "Email sent from  " + from.Address + " to " + to[0].Address + CRLF;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            lstAttachments.Items.Add(txtFileName.Text);
        }


    }
    

}
