﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformOptionsWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tablelayoutpanelOptionsWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.groupboxView = New System.Windows.Forms.GroupBox()
        Me.buttonResetMainWindowSizeAndPosition = New System.Windows.Forms.Button()
        Me.checkboxSaveWindowSizeAndPosition = New System.Windows.Forms.CheckBox()
        Me.checkboxAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.checkboxShowSearchButton = New System.Windows.Forms.CheckBox()
        Me.groupboxXmlUpdates = New System.Windows.Forms.GroupBox()
        Me.linklabelXmlVersionAvailable = New System.Windows.Forms.LinkLabel()
        Me.buttonCheckForXmlUpdates = New System.Windows.Forms.Button()
        Me.labelCurrentXmlVersion = New System.Windows.Forms.Label()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonRestoreDefaults = New System.Windows.Forms.Button()
        Me.groupboxWhenToSearch = New System.Windows.Forms.GroupBox()
        Me.labelSearchAlwaysAvailableIfButtonShown = New System.Windows.Forms.Label()
        Me.radiobuttonSearchWhenTyping = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSearchOnEnter = New System.Windows.Forms.RadioButton()
        Me.groupboxWhereToSearch = New System.Windows.Forms.GroupBox()
        Me.radiobuttonSearchAnywhereInXml = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSearchFromStart = New System.Windows.Forms.RadioButton()
        Me.groupboxSearchResultsDisplay = New System.Windows.Forms.GroupBox()
        Me.checkboxShowMatchingAlias = New System.Windows.Forms.CheckBox()
        Me.checkboxShowNumericCode = New System.Windows.Forms.CheckBox()
        Me.tablelayoutpanelOptionsWindow.SuspendLayout()
        Me.groupboxView.SuspendLayout()
        Me.groupboxXmlUpdates.SuspendLayout()
        Me.groupboxWhenToSearch.SuspendLayout()
        Me.groupboxWhereToSearch.SuspendLayout()
        Me.groupboxSearchResultsDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablelayoutpanelOptionsWindow
        '
        Me.tablelayoutpanelOptionsWindow.ColumnCount = 4
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxView, 0, 4)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxXmlUpdates, 0, 3)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.buttonSave, 3, 5)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.buttonCancel, 2, 5)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.buttonRestoreDefaults, 0, 5)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxWhenToSearch, 0, 0)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxWhereToSearch, 0, 1)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxSearchResultsDisplay, 0, 2)
        Me.tablelayoutpanelOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelOptionsWindow.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelOptionsWindow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tablelayoutpanelOptionsWindow.Name = "tablelayoutpanelOptionsWindow"
        Me.tablelayoutpanelOptionsWindow.RowCount = 6
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tablelayoutpanelOptionsWindow.Size = New System.Drawing.Size(394, 598)
        Me.tablelayoutpanelOptionsWindow.TabIndex = 0
        '
        'groupboxView
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxView, 4)
        Me.groupboxView.Controls.Add(Me.buttonResetMainWindowSizeAndPosition)
        Me.groupboxView.Controls.Add(Me.checkboxSaveWindowSizeAndPosition)
        Me.groupboxView.Controls.Add(Me.checkboxAlwaysOnTop)
        Me.groupboxView.Controls.Add(Me.checkboxShowSearchButton)
        Me.groupboxView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxView.Location = New System.Drawing.Point(4, 398)
        Me.groupboxView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxView.Name = "groupboxView"
        Me.groupboxView.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxView.Size = New System.Drawing.Size(386, 156)
        Me.groupboxView.TabIndex = 5
        Me.groupboxView.TabStop = False
        Me.groupboxView.Text = "View"
        '
        'buttonResetMainWindowSizeAndPosition
        '
        Me.buttonResetMainWindowSizeAndPosition.Location = New System.Drawing.Point(26, 114)
        Me.buttonResetMainWindowSizeAndPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonResetMainWindowSizeAndPosition.Name = "buttonResetMainWindowSizeAndPosition"
        Me.buttonResetMainWindowSizeAndPosition.Size = New System.Drawing.Size(269, 29)
        Me.buttonResetMainWindowSizeAndPosition.TabIndex = 3
        Me.buttonResetMainWindowSizeAndPosition.Text = "Reset main window size and position"
        Me.buttonResetMainWindowSizeAndPosition.UseVisualStyleBackColor = True
        '
        'checkboxSaveWindowSizeAndPosition
        '
        Me.checkboxSaveWindowSizeAndPosition.AutoSize = True
        Me.checkboxSaveWindowSizeAndPosition.Location = New System.Drawing.Point(8, 85)
        Me.checkboxSaveWindowSizeAndPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxSaveWindowSizeAndPosition.Name = "checkboxSaveWindowSizeAndPosition"
        Me.checkboxSaveWindowSizeAndPosition.Size = New System.Drawing.Size(300, 21)
        Me.checkboxSaveWindowSizeAndPosition.TabIndex = 2
        Me.checkboxSaveWindowSizeAndPosition.Text = "Save main window size and position on exit"
        Me.checkboxSaveWindowSizeAndPosition.UseVisualStyleBackColor = True
        '
        'checkboxAlwaysOnTop
        '
        Me.checkboxAlwaysOnTop.AutoSize = True
        Me.checkboxAlwaysOnTop.Location = New System.Drawing.Point(8, 55)
        Me.checkboxAlwaysOnTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxAlwaysOnTop.Name = "checkboxAlwaysOnTop"
        Me.checkboxAlwaysOnTop.Size = New System.Drawing.Size(237, 21)
        Me.checkboxAlwaysOnTop.TabIndex = 1
        Me.checkboxAlwaysOnTop.Text = "Make main window always on top"
        Me.checkboxAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'checkboxShowSearchButton
        '
        Me.checkboxShowSearchButton.AutoSize = True
        Me.checkboxShowSearchButton.Location = New System.Drawing.Point(8, 26)
        Me.checkboxShowSearchButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxShowSearchButton.Name = "checkboxShowSearchButton"
        Me.checkboxShowSearchButton.Size = New System.Drawing.Size(157, 21)
        Me.checkboxShowSearchButton.TabIndex = 0
        Me.checkboxShowSearchButton.Text = "Show Search button"
        Me.checkboxShowSearchButton.UseVisualStyleBackColor = True
        '
        'groupboxXmlUpdates
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxXmlUpdates, 4)
        Me.groupboxXmlUpdates.Controls.Add(Me.linklabelXmlVersionAvailable)
        Me.groupboxXmlUpdates.Controls.Add(Me.buttonCheckForXmlUpdates)
        Me.groupboxXmlUpdates.Controls.Add(Me.labelCurrentXmlVersion)
        Me.groupboxXmlUpdates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxXmlUpdates.Location = New System.Drawing.Point(4, 288)
        Me.groupboxXmlUpdates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxXmlUpdates.Name = "groupboxXmlUpdates"
        Me.groupboxXmlUpdates.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxXmlUpdates.Size = New System.Drawing.Size(386, 102)
        Me.groupboxXmlUpdates.TabIndex = 4
        Me.groupboxXmlUpdates.TabStop = False
        Me.groupboxXmlUpdates.Text = "XML file updates"
        '
        'linklabelXmlVersionAvailable
        '
        Me.linklabelXmlVersionAvailable.AutoSize = True
        Me.linklabelXmlVersionAvailable.Location = New System.Drawing.Point(5, 42)
        Me.linklabelXmlVersionAvailable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linklabelXmlVersionAvailable.Name = "linklabelXmlVersionAvailable"
        Me.linklabelXmlVersionAvailable.Size = New System.Drawing.Size(297, 17)
        Me.linklabelXmlVersionAvailable.TabIndex = 2
        Me.linklabelXmlVersionAvailable.TabStop = True
        Me.linklabelXmlVersionAvailable.Text = "Version available online: (newer version here)"
        '
        'buttonCheckForXmlUpdates
        '
        Me.buttonCheckForXmlUpdates.Location = New System.Drawing.Point(9, 62)
        Me.buttonCheckForXmlUpdates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonCheckForXmlUpdates.Name = "buttonCheckForXmlUpdates"
        Me.buttonCheckForXmlUpdates.Size = New System.Drawing.Size(145, 29)
        Me.buttonCheckForXmlUpdates.TabIndex = 1
        Me.buttonCheckForXmlUpdates.Text = "Check for updates"
        Me.buttonCheckForXmlUpdates.UseVisualStyleBackColor = True
        '
        'labelCurrentXmlVersion
        '
        Me.labelCurrentXmlVersion.AutoSize = True
        Me.labelCurrentXmlVersion.Location = New System.Drawing.Point(5, 20)
        Me.labelCurrentXmlVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCurrentXmlVersion.Name = "labelCurrentXmlVersion"
        Me.labelCurrentXmlVersion.Size = New System.Drawing.Size(258, 17)
        Me.labelCurrentXmlVersion.TabIndex = 0
        Me.labelCurrentXmlVersion.Text = "Current XML file version: (number here)"
        '
        'buttonSave
        '
        Me.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonSave.Location = New System.Drawing.Point(307, 562)
        Me.buttonSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(83, 32)
        Me.buttonSave.TabIndex = 0
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(216, 562)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(83, 32)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonRestoreDefaults
        '
        Me.buttonRestoreDefaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonRestoreDefaults.Location = New System.Drawing.Point(4, 562)
        Me.buttonRestoreDefaults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonRestoreDefaults.Name = "buttonRestoreDefaults"
        Me.buttonRestoreDefaults.Size = New System.Drawing.Size(83, 32)
        Me.buttonRestoreDefaults.TabIndex = 2
        Me.buttonRestoreDefaults.Text = "Defaults"
        Me.buttonRestoreDefaults.UseVisualStyleBackColor = True
        '
        'groupboxWhenToSearch
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxWhenToSearch, 4)
        Me.groupboxWhenToSearch.Controls.Add(Me.labelSearchAlwaysAvailableIfButtonShown)
        Me.groupboxWhenToSearch.Controls.Add(Me.radiobuttonSearchWhenTyping)
        Me.groupboxWhenToSearch.Controls.Add(Me.radiobuttonSearchOnEnter)
        Me.groupboxWhenToSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxWhenToSearch.Location = New System.Drawing.Point(4, 4)
        Me.groupboxWhenToSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxWhenToSearch.Name = "groupboxWhenToSearch"
        Me.groupboxWhenToSearch.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxWhenToSearch.Size = New System.Drawing.Size(386, 104)
        Me.groupboxWhenToSearch.TabIndex = 3
        Me.groupboxWhenToSearch.TabStop = False
        Me.groupboxWhenToSearch.Text = "When to search"
        '
        'labelSearchAlwaysAvailableIfButtonShown
        '
        Me.labelSearchAlwaysAvailableIfButtonShown.AutoSize = True
        Me.labelSearchAlwaysAvailableIfButtonShown.Location = New System.Drawing.Point(5, 77)
        Me.labelSearchAlwaysAvailableIfButtonShown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSearchAlwaysAvailableIfButtonShown.Name = "labelSearchAlwaysAvailableIfButtonShown"
        Me.labelSearchAlwaysAvailableIfButtonShown.Size = New System.Drawing.Size(330, 17)
        Me.labelSearchAlwaysAvailableIfButtonShown.TabIndex = 2
        Me.labelSearchAlwaysAvailableIfButtonShown.Text = "You can always search by clicking Search if shown."
        '
        'radiobuttonSearchWhenTyping
        '
        Me.radiobuttonSearchWhenTyping.AutoSize = True
        Me.radiobuttonSearchWhenTyping.Location = New System.Drawing.Point(9, 52)
        Me.radiobuttonSearchWhenTyping.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonSearchWhenTyping.Name = "radiobuttonSearchWhenTyping"
        Me.radiobuttonSearchWhenTyping.Size = New System.Drawing.Size(153, 21)
        Me.radiobuttonSearchWhenTyping.TabIndex = 1
        Me.radiobuttonSearchWhenTyping.TabStop = True
        Me.radiobuttonSearchWhenTyping.Text = "Search when typing"
        Me.radiobuttonSearchWhenTyping.UseVisualStyleBackColor = True
        '
        'radiobuttonSearchOnEnter
        '
        Me.radiobuttonSearchOnEnter.AutoSize = True
        Me.radiobuttonSearchOnEnter.Location = New System.Drawing.Point(9, 23)
        Me.radiobuttonSearchOnEnter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonSearchOnEnter.Name = "radiobuttonSearchOnEnter"
        Me.radiobuttonSearchOnEnter.Size = New System.Drawing.Size(132, 21)
        Me.radiobuttonSearchOnEnter.TabIndex = 0
        Me.radiobuttonSearchOnEnter.TabStop = True
        Me.radiobuttonSearchOnEnter.Text = "Search on Enter"
        Me.radiobuttonSearchOnEnter.UseVisualStyleBackColor = True
        '
        'groupboxWhereToSearch
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxWhereToSearch, 4)
        Me.groupboxWhereToSearch.Controls.Add(Me.radiobuttonSearchFromStart)
        Me.groupboxWhereToSearch.Controls.Add(Me.radiobuttonSearchAnywhereInXml)
        Me.groupboxWhereToSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxWhereToSearch.Location = New System.Drawing.Point(3, 115)
        Me.groupboxWhereToSearch.Name = "groupboxWhereToSearch"
        Me.groupboxWhereToSearch.Size = New System.Drawing.Size(388, 81)
        Me.groupboxWhereToSearch.TabIndex = 6
        Me.groupboxWhereToSearch.TabStop = False
        Me.groupboxWhereToSearch.Text = "Where to search"
        '
        'radiobuttonSearchAnywhereInXml
        '
        Me.radiobuttonSearchAnywhereInXml.AutoSize = True
        Me.radiobuttonSearchAnywhereInXml.Location = New System.Drawing.Point(10, 22)
        Me.radiobuttonSearchAnywhereInXml.Name = "radiobuttonSearchAnywhereInXml"
        Me.radiobuttonSearchAnywhereInXml.Size = New System.Drawing.Size(234, 21)
        Me.radiobuttonSearchAnywhereInXml.TabIndex = 0
        Me.radiobuttonSearchAnywhereInXml.TabStop = True
        Me.radiobuttonSearchAnywhereInXml.Text = "Search anywhere in alias entries"
        Me.radiobuttonSearchAnywhereInXml.UseVisualStyleBackColor = True
        '
        'radiobuttonSearchFromStart
        '
        Me.radiobuttonSearchFromStart.AutoSize = True
        Me.radiobuttonSearchFromStart.Location = New System.Drawing.Point(10, 50)
        Me.radiobuttonSearchFromStart.Name = "radiobuttonSearchFromStart"
        Me.radiobuttonSearchFromStart.Size = New System.Drawing.Size(268, 21)
        Me.radiobuttonSearchFromStart.TabIndex = 1
        Me.radiobuttonSearchFromStart.TabStop = True
        Me.radiobuttonSearchFromStart.Text = "Search from beginning of alias entries"
        Me.radiobuttonSearchFromStart.UseVisualStyleBackColor = True
        '
        'groupboxSearchResultsDisplay
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxSearchResultsDisplay, 4)
        Me.groupboxSearchResultsDisplay.Controls.Add(Me.checkboxShowNumericCode)
        Me.groupboxSearchResultsDisplay.Controls.Add(Me.checkboxShowMatchingAlias)
        Me.groupboxSearchResultsDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxSearchResultsDisplay.Location = New System.Drawing.Point(3, 202)
        Me.groupboxSearchResultsDisplay.Name = "groupboxSearchResultsDisplay"
        Me.groupboxSearchResultsDisplay.Size = New System.Drawing.Size(388, 79)
        Me.groupboxSearchResultsDisplay.TabIndex = 7
        Me.groupboxSearchResultsDisplay.TabStop = False
        Me.groupboxSearchResultsDisplay.Text = "Search results display"
        '
        'checkboxShowMatchingAlias
        '
        Me.checkboxShowMatchingAlias.AutoSize = True
        Me.checkboxShowMatchingAlias.Location = New System.Drawing.Point(10, 21)
        Me.checkboxShowMatchingAlias.Name = "checkboxShowMatchingAlias"
        Me.checkboxShowMatchingAlias.Size = New System.Drawing.Size(158, 21)
        Me.checkboxShowMatchingAlias.TabIndex = 0
        Me.checkboxShowMatchingAlias.Text = "Show matching alias"
        Me.checkboxShowMatchingAlias.UseVisualStyleBackColor = True
        '
        'checkboxShowNumericCode
        '
        Me.checkboxShowNumericCode.AutoSize = True
        Me.checkboxShowNumericCode.Location = New System.Drawing.Point(10, 48)
        Me.checkboxShowNumericCode.Name = "checkboxShowNumericCode"
        Me.checkboxShowNumericCode.Size = New System.Drawing.Size(320, 21)
        Me.checkboxShowNumericCode.TabIndex = 1
        Me.checkboxShowNumericCode.Text = "Show numeric code in addition to named code"
        Me.checkboxShowNumericCode.UseVisualStyleBackColor = True
        '
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(394, 598)
        Me.Controls.Add(Me.tablelayoutpanelOptionsWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformOptionsWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Options"
        Me.tablelayoutpanelOptionsWindow.ResumeLayout(False)
        Me.groupboxView.ResumeLayout(False)
        Me.groupboxView.PerformLayout()
        Me.groupboxXmlUpdates.ResumeLayout(False)
        Me.groupboxXmlUpdates.PerformLayout()
        Me.groupboxWhenToSearch.ResumeLayout(False)
        Me.groupboxWhenToSearch.PerformLayout()
        Me.groupboxWhereToSearch.ResumeLayout(False)
        Me.groupboxWhereToSearch.PerformLayout()
        Me.groupboxSearchResultsDisplay.ResumeLayout(False)
        Me.groupboxSearchResultsDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelOptionsWindow As TableLayoutPanel
    Friend WithEvents buttonSave As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonRestoreDefaults As Button
    Friend WithEvents groupboxWhenToSearch As GroupBox
    Friend WithEvents groupboxView As GroupBox
    Friend WithEvents groupboxXmlUpdates As GroupBox
    Friend WithEvents radiobuttonSearchWhenTyping As RadioButton
    Friend WithEvents radiobuttonSearchOnEnter As RadioButton
    Friend WithEvents labelSearchAlwaysAvailableIfButtonShown As Label
    Friend WithEvents labelCurrentXmlVersion As Label
    Friend WithEvents linklabelXmlVersionAvailable As LinkLabel
    Friend WithEvents buttonCheckForXmlUpdates As Button
    Friend WithEvents checkboxShowSearchButton As CheckBox
    Friend WithEvents checkboxAlwaysOnTop As CheckBox
    Friend WithEvents checkboxSaveWindowSizeAndPosition As CheckBox
    Friend WithEvents buttonResetMainWindowSizeAndPosition As Button
    Friend WithEvents groupboxWhereToSearch As GroupBox
    Friend WithEvents radiobuttonSearchFromStart As RadioButton
    Friend WithEvents radiobuttonSearchAnywhereInXml As RadioButton
    Friend WithEvents groupboxSearchResultsDisplay As GroupBox
    Friend WithEvents checkboxShowMatchingAlias As CheckBox
    Friend WithEvents checkboxShowNumericCode As CheckBox
End Class
