﻿' HTML Character Code Acquisition Program - Developer tool to look up HTML
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



Public Class aaformOptionsWindow
    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        ' Cancel out of the Options window and reload the user's settings
        My.Settings.Reload()
        Me.Close()
    End Sub

    Private Sub aaformOptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load in the user's settings.
#Region "Search when typing/on Enter"
        If My.Settings.searchWhenTyping = True Then
            radiobuttonSearchWhenTyping.Checked = True
        Else
            radiobuttonSearchOnEnter.Checked = True
        End If
#End Region

#Region "Show Search button"
        checkboxShowSearchButton.Checked = My.Settings.showSearchButton
#End Region
    End Sub

#Region "Save button."
    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        ' This is what happens when saving settings.

        ' First, if the radio button to search on Enter is checked,
        ' set the option to search when typing to False.
        If radiobuttonSearchOnEnter.Checked = True Then
            My.Settings.searchWhenTyping = False
        Else
            ' Otherwise, set it to True.
            My.Settings.searchWhenTyping = True
        End If

        ' Next, configure the Search button visibility.
        My.Settings.showSearchButton = checkboxShowSearchButton.Checked


        ' Now save the settings and reload them before closing the window.
        My.Settings.Save()
        My.Settings.Reload()

        ' If we need to show or hide the search button, do that.
        aaformMainWindow.hideOrShowSearchButton()

        Me.Close()
    End Sub
#End Region
End Class