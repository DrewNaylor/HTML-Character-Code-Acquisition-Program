Imports System.Xml

Public Class aaformMainWindow
    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        textboxOutput.Clear()
        getCodes()
    End Sub

    Private Shared xmlFileToSearch As XmlDocument = New XmlDocument()
    Private Shared searchNamespaceManager As New XmlNamespaceManager(xmlFileToSearch.NameTable)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchNamespaceManager.AddNamespace("html-ccap", "https://drewnaylor.github.io/xml")
        Debug.WriteLine(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        xmlFileToSearch.Load(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        Debug.WriteLine(xmlFileToSearch.OuterXml.ToString.Replace("_", "&"))
    End Sub

    Private Sub getCodes()
        For Each node As XmlNode In xmlFileToSearch.SelectSingleNode("/root/characterCodeSection")
            Debug.WriteLine("node.InnerText: " & node.InnerText)
            If node.InnerText.ToLowerInvariant.Contains(textboxInput.Text.ToLowerInvariant) Then
                textboxOutput.AppendText(node.InnerText.Replace("_", "&") & vbCrLf)
            End If
        Next
        ' Now trim the end.
        textboxOutput.Text = textboxOutput.Text.TrimEnd
    End Sub
End Class
