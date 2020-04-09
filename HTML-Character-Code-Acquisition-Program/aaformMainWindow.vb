' HTML Character Code Acquisition Program - Developer tool to look up HTML
' character codes/HTML character entities.
' Copyright (C) 2019-2020 Drew Naylor
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

    ' The XML file we want to search.
    Private Shared xmlFileToSearch As XmlDocument = New XmlDocument()
    ' The namespace manager for handling namespaces.
    Private Shared searchNamespaceManager As New XmlNamespaceManager(xmlFileToSearch.NameTable)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Determine if the Search button should be shown or not.
        hideOrShowSearchButton()

#Region "Load in XML file."
        ' Add a namespace to the namespace manager so that XML works properly.
        searchNamespaceManager.AddNamespace("html-ccap", "https://drewnaylor.github.io/xml")
        Debug.WriteLine("XML file path:")
        Debug.WriteLine(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        ' Load in the XML file with the character codes from the current directory.
        ' This would preferably also have an option to load it from the
        ' application's Resources, but the XML file isn't close enough
        ' to completion for that to make sense.
        ' TODO: Allow the XML file to be pulled from application resources.
        xmlFileToSearch.Load(IO.Directory.GetCurrentDirectory & "\searchXml.xml")
        Debug.WriteLine("XML file contents:")
        Debug.WriteLine(xmlFileToSearch.OuterXml.ToString.Replace("_", "&"))
#End Region

        ' Display the entire XML file if the user wants
        ' to use Search as a filter.
        getCodes()
    End Sub

#Region "Show or hide Search button."
    Friend Shared Sub hideOrShowSearchButton()

        ' Show Search button if the user wants to.
        If My.Settings.showSearchButton = True Then
            aaformMainWindow.buttonSearch.Show()
            aaformMainWindow.tablelayoutpanelMainWindow.SetColumnSpan(aaformMainWindow.textboxInput, 1)
        Else
            aaformMainWindow.buttonSearch.Hide()
            aaformMainWindow.tablelayoutpanelMainWindow.SetColumnSpan(aaformMainWindow.textboxInput, 2)
        End If
    End Sub
#End Region

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        ' Get the character codes.
        getCodes()
    End Sub

    Private Sub textboxInput_TextChanged(sender As Object, e As EventArgs) Handles textboxInput.TextChanged
        ' After a key is pressed, search the XML file if the user has
        ' Search when Typing enabled.
        If My.Settings.searchWhenTyping = True Then
            getCodes()
        End If
    End Sub

    Private Sub getCodes()
        ' First we look at each XmlNode within the character code section node
        ' after clearing the textbox.

        ' Also make sure the input textbox isn't empty.
        If Not textboxInput.Text = "" Then
            textboxOutput.Clear()

            ' Based on this SO answer:
            ' https://stackoverflow.com/a/17708002
            For Each characterCodeNode As XmlNode In xmlFileToSearch.SelectSingleNode("/root/characterCodeSection")
                ' Look inside the nodes within the character code section.
                ' These would be the <characterCode> nodes.

                For Each currentNode As XmlNode In characterCodeNode
                    ' Look inside each node inside the <characterCode> nodes.
                    ' These are the <Alias> nodes.

                    If currentNode.InnerText.ToLowerInvariant.Contains(textboxInput.Text.ToLowerInvariant) Then
                        ' If the inner text of the alias node, when set to lowercase,
                        ' contains what the user typed into the search bar,
                        ' we need to grab the attributes of the parent node.

                        Dim codeOutput As String = currentNode.ParentNode.Attributes("name").Value.ToString & ": " & currentNode.ParentNode.Attributes("code").Value.Replace("_", "&") & vbCrLf
                        If textboxOutput.Text.Contains(codeOutput) Then
                            ' If the output textbox contains what we want to output,
                            ' replace what's already in the output textbox with
                            ' an empty string.
                            textboxOutput.Text.Replace(codeOutput, String.Empty)
                        Else
                            ' Otherwise, if it's not in the textbox yet,
                            ' put it in there.
                            textboxOutput.AppendText(codeOutput)
                        End If
                    End If

                    ' Check the next <Alias> node. 
                    currentNode = currentNode.NextSibling
                Next

                ' Check the next <characterCode> node.
                characterCodeNode = characterCodeNode.NextSibling
            Next

            ' Now trim the end.
            textboxOutput.Text = textboxOutput.Text.TrimEnd

        Else
            ' If the textbox is empty, then clear the output textbox.
            textboxOutput.Clear()
            ' Now we can have it display everything if the user wants
            ' to have the search function as a filter.
            If My.Settings.searchIsFilter = True Then
                For Each characterNode As XmlNode In xmlFileToSearch.SelectSingleNode("/root/characterCodeSection")
                    ' Underscores are replaced with and symbols so that they match how HTML expects
                    ' character codes to look. The underscores are necessary for now as XML complains
                    ' when they're in the file, so this is a workaround.
                    textboxOutput.AppendText(characterNode.Attributes("name").Value.ToString & ": " & characterNode.Attributes("code").Value.Replace("_", "&") & vbCrLf)
                Next
                ' Now trim the end.
                textboxOutput.Text = textboxOutput.Text.TrimEnd
            End If
        End If
    End Sub

    Private Sub textboxInput_KeyDown(sender As Object, e As KeyEventArgs) Handles textboxInput.KeyDown
        ' When pressing Enter in the textbox, get the codes.
        If My.Settings.searchWhenTyping = False AndAlso e.KeyCode = Keys.Enter Then
            getCodes()
        End If
    End Sub

    Private Sub menubarToolsMenuOptionsButton_Click(sender As Object, e As EventArgs) Handles menubarToolsMenuOptionsButton.Click
        ' Show the Options window.
        aaformOptionsWindow.ShowDialog(Me)
    End Sub
End Class
