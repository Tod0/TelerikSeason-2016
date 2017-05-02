<?xml version="1.0" encoding="windows-1251"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/"> 
    <html>
        <body>
            <h1>Students</h1>
            <table border="1">
                <tr bgcolor="#9acd32">
                    <th>Name</th>
                    <th>Sex</th>
                    <th>Birthdate</th>
                    <th>Phone</th>
                    <th>Email</th>
                    <th>Course</th>
                    <th>Specialty</th>
                    <th>Faculty Number</th>
                    <th>Exams</th>
                    <th>Name</th>
                    <th>Tutor</th>
                    <th>Score</th>
                    <th>Enrollment</th>
                    <th>Date</th>
                    <th>Score</th>
                    <th>Endorsement</th>
                </tr>
                <xsl:for-each select="students/student">
                <tr>
                    <td><xsl:value-of select="name"/></td>
                    <td><xsl:value-of select="sex"/></td>
                    <td><xsl:value-of select="birthDate"/></td>
                    <td><xsl:value-of select="phone"/></td>
                    <td><xsl:value-of select="email"/></td>
                    <td><xsl:value-of select="course"/></td>
                    <td><xsl:value-of select="specialty"/></td>
                    <td><xsl:value-of select="facultyNumber"/></td>
                    <td></td>
                    <td><xsl:value-of select="exams/exam/name"/></td>
                    <td><xsl:value-of select="exams/exam/tutor"/></td>
                    <td><xsl:value-of select="exams/exam/score"/></td>
                    <td></td>
                    <td><xsl:value-of select="enrollment/date"/></td>
                    <td><xsl:value-of select="enrollment/score"/></td>
                    <td><xsl:value-of select="enrollment/endorsements"/></td>
                </tr>
                </xsl:for-each>
            </table>
        </body>
    </html>
</xsl:template>
</xsl:stylesheet> 