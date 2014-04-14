<?xml version="1.0"?>
<xsl:transform xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/Details">

<xsl:text disable-output-escaping="yes">
&lt;!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"&gt;
</xsl:text>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Line2: your credit card is about to expire</title>
</head>

<body style="margin:0; padding:0;background-color:#f2f2f2; font-family:'Droid Sans',Arial,sans-serif;line-height:20px;">
  <div style="width:600px; margin:0 auto;background-color:#ffffff;border:1px solid #c2c2c2;font-family:arial;line-height:20px;"><!-- main div -->
    
    
      <div style="width:600px;float:left">
	 <a href="https://www.line2.com/" target="_blank"><img src="1header.png" alt="" /></a>
	 </div>
    
    
    <!-- content -->
    <div style="background-color:#f1f1f1;margin:0; width:570px;float:left;padding:0 15px;">
      <h1 style="font-size:14px;color:#000000;margin:15px 0 10px 0;line-height:30px;">Dear <span style="font-weight:bold;"><xsl:value-of select="firstName"/>,</span></h1>
      <p style="font-size:12px;color:#000;margin:0;padding-bottom:15px;">This is a friendly reminder that your <xsl:value-of select="cardType"/> credit card ending in <xsl:value-of select="lastFour"/> will expire on <span style="font-weight:bold;color:#000000"><xsl:value-of select="expireMonth"/>/<xsl:value-of select="expireYear"/></span>.</p> 
      
      <p style="font-size:12px;color:#000;margin:0;padding-bottom:15px;">To avoid any interruptions to your Line2 service for  <span style="font-weight:bold;color:#000000"><xsl:value-of select="account"/></span>, <a href="https://www.line2.com/e/22/updatecard/$token$" target="_blank" style="color:#0078c3; font-weight:bold;"><em>please update your credit card information</em></a>.</p> 
      
      <p style="font-size:12px;color:#000;margin:0;padding-bottom:15px;">Thank you for being a customer. If we can be of any assistance to you, please <a href="http://www.line2.com/contact.html" target="_blank" style="color:#0078c3; font-weight:bold;"><em>contact us</em></a>.</p> 
        
      
        <!-- point-content -->
         <!-- point-content -->
        
        <div style="clear:both; height:0;"></div>
        
         
        <p style="font-size:12px;color:#000;margin:0; padding-bottom:15px;">
         <span style="color:#000000;">Sincerely,</span><br/>
	<b>Line2 Customer Support</b> 
        </p>
    </div>
     <!-- content -->
    <div style="clear:both; height:0;"></div>    
    <div>
    <a href="https://www.line2.com/" target="_blank"><img src="footer.png" alt="" width="600"/></a>
    </div>
    <div style="clear:both; height:0;"></div>
  </div><!-- main div -->
</body>
</html>

</xsl:template>
</xsl:transform >