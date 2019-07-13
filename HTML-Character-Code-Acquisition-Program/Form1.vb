Imports System.Xml

Public Class Form1

    Private Shared fileToSearchFrom As XmlDocument = New XmlDocument()
    Private Shared searchNamespaceManager As New XmlNamespaceManager(fileToSearchFrom.NameTable)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchNamespaceManager.AddNamespace("hccap", "https://drewnaylor.github.io/xml")
        Debug.WriteLine(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        fileToSearchFrom.Load(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        Debug.WriteLine(fileToSearchFrom.OuterXml.ToString.Replace("_", "&"))
    End Sub

    Private Sub getCodes()
        For Each node As XmlNode In fileToSearchFrom.SelectSingleNode("/root/characterCodeSection")
            Debug.WriteLine("node.InnerText: " & node.InnerText)
            If node.InnerText.ToLowerInvariant.Contains(TextBox1.Text.ToLowerInvariant) Then
                TextBox2.AppendText(node.InnerText.Replace("_", "&") & vbCrLf)
            End If
        Next
    End Sub
End Class
