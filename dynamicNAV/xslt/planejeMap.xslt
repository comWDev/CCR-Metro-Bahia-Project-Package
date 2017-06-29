<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE xsl:stylesheet [ <!ENTITY nbsp "&#x00A0;"> ]>
<xsl:stylesheet
  version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msxml="urn:schemas-microsoft-com:xslt"
  xmlns:umbraco.library="urn:umbraco.library"
  xmlns:Exslt.ExsltCommon="urn:Exslt.ExsltCommon" 
  xmlns:Exslt.ExsltDatesAndTimes="urn:Exslt.ExsltDatesAndTimes" 
  xmlns:Exslt.ExsltMath="urn:Exslt.ExsltMath" 
  xmlns:Exslt.ExsltRegularExpressions="urn:Exslt.ExsltRegularExpressions" 
  xmlns:Exslt.ExsltStrings="urn:Exslt.ExsltStrings" 
  xmlns:Exslt.ExsltSets="urn:Exslt.ExsltSets" 
  xmlns:seoChecker.MetaData="urn:seoChecker.MetaData" 
  xmlns:PS.XSLTsearch="urn:PS.XSLTsearch"
  exclude-result-prefixes="msxml umbraco.library Exslt.ExsltCommon Exslt.ExsltDatesAndTimes Exslt.ExsltMath Exslt.ExsltRegularExpressions Exslt.ExsltStrings Exslt.ExsltSets seoChecker.MetaData PS.XSLTsearch ">

<xsl:output method="xml" omit-xml-declaration="yes"/>

<xsl:param name="currentPage"/>
<xsl:variable name="location" select="/macro/location"/>
<xsl:variable name="height" select="/macro/height"/>
<xsl:template match="/">
<iframe src="{$location}" height="{$height}" style="border:0; width: 100%">
    Sorry, your browser does not support IFRAMES, and the map can not be displayed.
  </iframe>
</xsl:template>
</xsl:stylesheet>