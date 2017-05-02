<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" 
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
    <body>
      <h1>Catalog</h1>
      <table border="1">
        <tr bgcolor="#9acd32">
          <th>Name</th>
          <th>Artist</th>
          <th>Year</th>
          <th>Producer</th>
          <th>Price</th>
          <th>Songs</th>
          <th>Title</th>
          <th>Duration</th>
        </tr>
        <xsl:for-each select="catalog/album">
          <tr>
            <td>
              <xsl:value-of select="name"/>
            </td>
            <td>
              <xsl:value-of select="artist"/>
            </td>
            <td>
              <xsl:value-of select="year"/>
            </td>
            <td>
              <xsl:value-of select="producer"/>
            </td>
            <td>
              <xsl:value-of select="price"/>
            </td>
            <td></td>
            <td>
              <xsl:value-of select="songs/title"/>
            </td>
            <td>
              <xsl:value-of select="songs/duration"/>
            </td>
          </tr>
        </xsl:for-each>
      </table>
    </body>
  </html>
</xsl:template>
</xsl:stylesheet>
