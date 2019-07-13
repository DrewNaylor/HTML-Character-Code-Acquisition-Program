' HTML Character Code Acquisition Program - Developer tool to look up HTML
' character codes/HTML character entities.
' Copyright (C) 2019 Drew Naylor
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of HTML Character Code Acquisition Program
' (Program is also known as "html-ccap".)
'
' html-ccap is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' html-ccap is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with html-ccap.  If not, see <http://www.gnu.org/licenses/>.



Imports System.Xml

Public Class aaformMainWindow
    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        ' Remove all text from the output textbox so it
        ' doesn't get cluttered up, then get the character
        ' codes.
        textboxOutput.Clear()
        getCodes()
    End Sub

    ' The XML file we want to search.
    Private Shared xmlFileToSearch As XmlDocument = New XmlDocument()
    ' The namespace manager for handling namespaces.
    Private Shared searchNamespaceManager As New XmlNamespaceManager(xmlFileToSearch.NameTable)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add a namespace to the namespace manager so that XML works properly.
        searchNamespaceManager.AddNamespace("html-ccap", "https://drewnaylor.github.io/xml")
        Debug.WriteLine("XML file path:")
        Debug.WriteLine(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        ' Load in the XML file with the character codes from the current directory.
        ' This would preferably also have an option to load it from the
        ' application's Resources, but the XML file isn't close enough
        ' to completion for that to make sense.        
        xmlFileToSearch.Load(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        Debug.WriteLine("XML file contents:")
        Debug.WriteLine(xmlFileToSearch.OuterXml.ToString.Replace("_", "&"))
    End Sub

    Private Sub getCodes()
        'First we look at each XmlNode within the character code section node.

        Debug.WriteLine("Entries in XML file:")
        For Each characterNode As XmlNode In xmlFileToSearch.SelectSingleNode("/root/characterCodeSection")
            Debug.WriteLine("node.InnerText: " & characterNode.InnerText)
            ' If it's determined that the text in the node contains the text in the textbox,
            ' then that is appended to the output textbox.
            ' To compare the text, both the text in the textbox and the text in the node
            ' are made to be lowercase and culture/language-invariant.
            If characterNode.InnerText.ToLowerInvariant.Contains(textboxInput.Text.ToLowerInvariant) Then
                ' Underscores are replaced with and symbols so that they match how HTML expects
                ' character codes to look. The underscores are necessary for now as XML complains
                ' when they're in the file, so this is a workaround.
                textboxOutput.AppendText(characterNode.InnerText.Replace("_", "&") & vbCrLf)
            End If
        Next
        ' Now trim the end.
        textboxOutput.Text = textboxOutput.Text.TrimEnd
    End Sub

    Private Sub textboxInput_TextChanged(sender As Object, e As EventArgs) Handles textboxInput.TextChanged
        ' After a key is pressed, search the XML file if the user has
        ' Search when Typing enabled.
        buttonSearch.PerformClick()
    End Sub
End Class
