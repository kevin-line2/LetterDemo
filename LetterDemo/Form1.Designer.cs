namespace LetterDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtXslFile = new System.Windows.Forms.TextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.txtDbProc = new System.Windows.Forms.TextBox();
            this.txtEmailAddr = new System.Windows.Forms.TextBox();
            this.txtDbKey = new System.Windows.Forms.TextBox();
            this.dlgFileTemplate = new System.Windows.Forms.OpenFileDialog();
            this.btnGenXml = new System.Windows.Forms.Button();
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.btnSetXml = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dlgFolderDefault = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 179);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 334);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(394, 113);
            this.txtStatus.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(74, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "sendgrid@line2.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credentials";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(194, 6);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '$';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 4;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 150);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Gen Email";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtXslFile
            // 
            this.txtXslFile.Location = new System.Drawing.Point(93, 152);
            this.txtXslFile.Name = "txtXslFile";
            this.txtXslFile.Size = new System.Drawing.Size(201, 20);
            this.txtXslFile.TabIndex = 6;
            this.txtXslFile.Text = "CCardExpire.xsl";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(12, 92);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 8;
            this.btnData.Text = "Load Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // txtDbProc
            // 
            this.txtDbProc.Location = new System.Drawing.Point(93, 94);
            this.txtDbProc.Name = "txtDbProc";
            this.txtDbProc.Size = new System.Drawing.Size(201, 20);
            this.txtDbProc.TabIndex = 9;
            this.txtDbProc.Text = "GetLetterSource";
            // 
            // txtEmailAddr
            // 
            this.txtEmailAddr.Location = new System.Drawing.Point(93, 181);
            this.txtEmailAddr.Name = "txtEmailAddr";
            this.txtEmailAddr.Size = new System.Drawing.Size(313, 20);
            this.txtEmailAddr.TabIndex = 11;
            this.txtEmailAddr.Text = "krogers@toktumi.com";
            // 
            // txtDbKey
            // 
            this.txtDbKey.Location = new System.Drawing.Point(314, 94);
            this.txtDbKey.Name = "txtDbKey";
            this.txtDbKey.Size = new System.Drawing.Size(92, 20);
            this.txtDbKey.TabIndex = 12;
            this.txtDbKey.Text = "1";
            // 
            // dlgFileTemplate
            // 
            this.dlgFileTemplate.FileName = "*.xsl";
            this.dlgFileTemplate.Filter = "XSLT files|*.xsl|All files|*.*";
            // 
            // btnGenXml
            // 
            this.btnGenXml.Location = new System.Drawing.Point(12, 121);
            this.btnGenXml.Name = "btnGenXml";
            this.btnGenXml.Size = new System.Drawing.Size(75, 23);
            this.btnGenXml.TabIndex = 13;
            this.btnGenXml.Text = "Gen XML";
            this.btnGenXml.UseVisualStyleBackColor = true;
            this.btnGenXml.Click += new System.EventHandler(this.btnGenXml_Click);
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Location = new System.Drawing.Point(93, 121);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(201, 20);
            this.txtXmlFile.TabIndex = 14;
            this.txtXmlFile.Text = "Details.xml";
            // 
            // btnSetXml
            // 
            this.btnSetXml.Location = new System.Drawing.Point(12, 63);
            this.btnSetXml.Name = "btnSetXml";
            this.btnSetXml.Size = new System.Drawing.Size(75, 23);
            this.btnSetXml.TabIndex = 15;
            this.btnSetXml.Text = "Get Path";
            this.btnSetXml.UseVisualStyleBackColor = true;
            this.btnSetXml.Click += new System.EventHandler(this.btnSetXml_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(93, 65);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(313, 20);
            this.txtPath.TabIndex = 16;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(93, 207);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(313, 20);
            this.txtSubject.TabIndex = 17;
            this.txtSubject.Text = "[LETTER DEMO] - Email Subject Line";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 233);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(150, 20);
            this.txtFileName.TabIndex = 20;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(170, 231);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 21;
            this.btnAddFile.Text = "Add File ->";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.Location = new System.Drawing.Point(251, 233);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(155, 95);
            this.lstAttachments.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Attachement Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSetXml);
            this.Controls.Add(this.txtXmlFile);
            this.Controls.Add(this.btnGenXml);
            this.Controls.Add(this.txtDbKey);
            this.Controls.Add(this.txtEmailAddr);
            this.Controls.Add(this.txtDbProc);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.txtXslFile);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox txtXslFile;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox txtDbProc;
        private System.Windows.Forms.TextBox txtEmailAddr;
        private System.Windows.Forms.TextBox txtDbKey;
        private System.Windows.Forms.OpenFileDialog dlgFileTemplate;
        private System.Windows.Forms.Button btnGenXml;
        private System.Windows.Forms.TextBox txtXmlFile;
        private System.Windows.Forms.Button btnSetXml;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderDefault;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Label label2;
    }
}

