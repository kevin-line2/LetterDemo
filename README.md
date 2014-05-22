LetterDemo
===========

The LetterDemo can be found at https://github.com/kevin-line2/LetterDemo/.  The LetterDemo demonstrates the technology of a Lettering System. The program takes a set of inputs to generate an email. An xml data file is generated from a stored procedure that runs against a SQL table. The xml file is merged with an xsl template to generate an HTML file. The HTML file is sent as an email using SendGrid.

The LetterDemo requires the SendGridPlus NuGet package installed as part of the project. Of course, a SendGrid account is also required.

The LetterDemo requires an instance of SQL Server. A local instance of SQL Server Express works fine. In that case there should be created a Database named Core, and a table named LetterSource and a stored procedure named GetLetterSource. Scripts to create the table and stored procedure are in the Database directory. A script to create 1 record is also in that directory.

The LetterDemo requires an XSL Template containing the copy for the email. A sample is supplied in the Support directory. 
