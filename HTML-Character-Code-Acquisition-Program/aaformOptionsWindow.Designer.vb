<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformOptionsWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tablelayoutpanelOptionsWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonRestoreDefaults = New System.Windows.Forms.Button()
        Me.groupboxWhenToSearch = New System.Windows.Forms.GroupBox()
        Me.groupboxXmlUpdates = New System.Windows.Forms.GroupBox()
        Me.groupboxView = New System.Windows.Forms.GroupBox()
        Me.radiobuttonSearchOnEnter = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSearchWhenTyping = New System.Windows.Forms.RadioButton()
        Me.labelSearchAlwaysAvailableIfButtonShown = New System.Windows.Forms.Label()
        Me.labelCurrentXmlVersion = New System.Windows.Forms.Label()
        Me.buttonCheckForXmlUpdates = New System.Windows.Forms.Button()
        Me.linklabelXmlVersionAvailable = New System.Windows.Forms.LinkLabel()
        Me.checkboxShowSearchButton = New System.Windows.Forms.CheckBox()
        Me.checkboxAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.checkboxSaveWindowSizeAndPosition = New System.Windows.Forms.CheckBox()
        Me.buttonResetMainWindowSizeAndPosition = New System.Windows.Forms.Button()
        Me.tablelayoutpanelOptionsWindow.SuspendLayout()
        Me.groupboxWhenToSearch.SuspendLayout()
        Me.groupboxXmlUpdates.SuspendLayout()
        Me.groupboxView.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablelayoutpanelOptionsWindow
        '
        Me.tablelayoutpanelOptionsWindow.ColumnCount = 4
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tablelayoutpanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxView, 0, 2)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxXmlUpdates, 0, 1)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.buttonSave, 3, 3)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.buttonCancel, 2, 3)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.buttonRestoreDefaults, 0, 3)
        Me.tablelayoutpanelOptionsWindow.Controls.Add(Me.groupboxWhenToSearch, 0, 0)
        Me.tablelayoutpanelOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelOptionsWindow.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelOptionsWindow.Name = "tablelayoutpanelOptionsWindow"
        Me.tablelayoutpanelOptionsWindow.RowCount = 4
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tablelayoutpanelOptionsWindow.Size = New System.Drawing.Size(315, 344)
        Me.tablelayoutpanelOptionsWindow.TabIndex = 0
        '
        'buttonSave
        '
        Me.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonSave.Location = New System.Drawing.Point(245, 315)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(67, 26)
        Me.buttonSave.TabIndex = 0
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(172, 315)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(67, 26)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonRestoreDefaults
        '
        Me.buttonRestoreDefaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonRestoreDefaults.Location = New System.Drawing.Point(3, 315)
        Me.buttonRestoreDefaults.Name = "buttonRestoreDefaults"
        Me.buttonRestoreDefaults.Size = New System.Drawing.Size(67, 26)
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
        Me.groupboxWhenToSearch.Location = New System.Drawing.Point(3, 3)
        Me.groupboxWhenToSearch.Name = "groupboxWhenToSearch"
        Me.groupboxWhenToSearch.Size = New System.Drawing.Size(309, 83)
        Me.groupboxWhenToSearch.TabIndex = 3
        Me.groupboxWhenToSearch.TabStop = False
        Me.groupboxWhenToSearch.Text = "When to search"
        '
        'groupboxXmlUpdates
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxXmlUpdates, 4)
        Me.groupboxXmlUpdates.Controls.Add(Me.linklabelXmlVersionAvailable)
        Me.groupboxXmlUpdates.Controls.Add(Me.buttonCheckForXmlUpdates)
        Me.groupboxXmlUpdates.Controls.Add(Me.labelCurrentXmlVersion)
        Me.groupboxXmlUpdates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxXmlUpdates.Location = New System.Drawing.Point(3, 92)
        Me.groupboxXmlUpdates.Name = "groupboxXmlUpdates"
        Me.groupboxXmlUpdates.Size = New System.Drawing.Size(309, 85)
        Me.groupboxXmlUpdates.TabIndex = 4
        Me.groupboxXmlUpdates.TabStop = False
        Me.groupboxXmlUpdates.Text = "XML file updates"
        '
        'groupboxView
        '
        Me.tablelayoutpanelOptionsWindow.SetColumnSpan(Me.groupboxView, 4)
        Me.groupboxView.Controls.Add(Me.buttonResetMainWindowSizeAndPosition)
        Me.groupboxView.Controls.Add(Me.checkboxSaveWindowSizeAndPosition)
        Me.groupboxView.Controls.Add(Me.checkboxAlwaysOnTop)
        Me.groupboxView.Controls.Add(Me.checkboxShowSearchButton)
        Me.groupboxView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxView.Location = New System.Drawing.Point(3, 183)
        Me.groupboxView.Name = "groupboxView"
        Me.groupboxView.Size = New System.Drawing.Size(309, 126)
        Me.groupboxView.TabIndex = 5
        Me.groupboxView.TabStop = False
        Me.groupboxView.Text = "View"
        '
        'radiobuttonSearchOnEnter
        '
        Me.radiobuttonSearchOnEnter.AutoSize = True
        Me.radiobuttonSearchOnEnter.Location = New System.Drawing.Point(7, 20)
        Me.radiobuttonSearchOnEnter.Name = "radiobuttonSearchOnEnter"
        Me.radiobuttonSearchOnEnter.Size = New System.Drawing.Size(102, 17)
        Me.radiobuttonSearchOnEnter.TabIndex = 0
        Me.radiobuttonSearchOnEnter.TabStop = True
        Me.radiobuttonSearchOnEnter.Text = "Search on Enter"
        Me.radiobuttonSearchOnEnter.UseVisualStyleBackColor = True
        '
        'radiobuttonSearchWhenTyping
        '
        Me.radiobuttonSearchWhenTyping.AutoSize = True
        Me.radiobuttonSearchWhenTyping.Location = New System.Drawing.Point(6, 43)
        Me.radiobuttonSearchWhenTyping.Name = "radiobuttonSearchWhenTyping"
        Me.radiobuttonSearchWhenTyping.Size = New System.Drawing.Size(119, 17)
        Me.radiobuttonSearchWhenTyping.TabIndex = 1
        Me.radiobuttonSearchWhenTyping.TabStop = True
        Me.radiobuttonSearchWhenTyping.Text = "Search when typing"
        Me.radiobuttonSearchWhenTyping.UseVisualStyleBackColor = True
        '
        'labelSearchAlwaysAvailableIfButtonShown
        '
        Me.labelSearchAlwaysAvailableIfButtonShown.AutoSize = True
        Me.labelSearchAlwaysAvailableIfButtonShown.Location = New System.Drawing.Point(4, 63)
        Me.labelSearchAlwaysAvailableIfButtonShown.Name = "labelSearchAlwaysAvailableIfButtonShown"
        Me.labelSearchAlwaysAvailableIfButtonShown.Size = New System.Drawing.Size(252, 13)
        Me.labelSearchAlwaysAvailableIfButtonShown.TabIndex = 2
        Me.labelSearchAlwaysAvailableIfButtonShown.Text = "You can always search by clicking Search if shown."
        '
        'labelCurrentXmlVersion
        '
        Me.labelCurrentXmlVersion.AutoSize = True
        Me.labelCurrentXmlVersion.Location = New System.Drawing.Point(4, 16)
        Me.labelCurrentXmlVersion.Name = "labelCurrentXmlVersion"
        Me.labelCurrentXmlVersion.Size = New System.Drawing.Size(190, 13)
        Me.labelCurrentXmlVersion.TabIndex = 0
        Me.labelCurrentXmlVersion.Text = "Current XML file version: (number here)"
        '
        'buttonCheckForXmlUpdates
        '
        Me.buttonCheckForXmlUpdates.Location = New System.Drawing.Point(7, 50)
        Me.buttonCheckForXmlUpdates.Name = "buttonCheckForXmlUpdates"
        Me.buttonCheckForXmlUpdates.Size = New System.Drawing.Size(116, 23)
        Me.buttonCheckForXmlUpdates.TabIndex = 1
        Me.buttonCheckForXmlUpdates.Text = "Check for updates"
        Me.buttonCheckForXmlUpdates.UseVisualStyleBackColor = True
        '
        'linklabelXmlVersionAvailable
        '
        Me.linklabelXmlVersionAvailable.AutoSize = True
        Me.linklabelXmlVersionAvailable.Location = New System.Drawing.Point(4, 34)
        Me.linklabelXmlVersionAvailable.Name = "linklabelXmlVersionAvailable"
        Me.linklabelXmlVersionAvailable.Size = New System.Drawing.Size(220, 13)
        Me.linklabelXmlVersionAvailable.TabIndex = 2
        Me.linklabelXmlVersionAvailable.TabStop = True
        Me.linklabelXmlVersionAvailable.Text = "Version available online: (newer version here)"
        '
        'checkboxShowSearchButton
        '
        Me.checkboxShowSearchButton.AutoSize = True
        Me.checkboxShowSearchButton.Location = New System.Drawing.Point(6, 21)
        Me.checkboxShowSearchButton.Name = "checkboxShowSearchButton"
        Me.checkboxShowSearchButton.Size = New System.Drawing.Size(123, 17)
        Me.checkboxShowSearchButton.TabIndex = 0
        Me.checkboxShowSearchButton.Text = "Show Search button"
        Me.checkboxShowSearchButton.UseVisualStyleBackColor = True
        '
        'checkboxAlwaysOnTop
        '
        Me.checkboxAlwaysOnTop.AutoSize = True
        Me.checkboxAlwaysOnTop.Location = New System.Drawing.Point(6, 44)
        Me.checkboxAlwaysOnTop.Name = "checkboxAlwaysOnTop"
        Me.checkboxAlwaysOnTop.Size = New System.Drawing.Size(185, 17)
        Me.checkboxAlwaysOnTop.TabIndex = 1
        Me.checkboxAlwaysOnTop.Text = "Make main window always on top"
        Me.checkboxAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'checkboxSaveWindowSizeAndPosition
        '
        Me.checkboxSaveWindowSizeAndPosition.AutoSize = True
        Me.checkboxSaveWindowSizeAndPosition.Location = New System.Drawing.Point(6, 68)
        Me.checkboxSaveWindowSizeAndPosition.Name = "checkboxSaveWindowSizeAndPosition"
        Me.checkboxSaveWindowSizeAndPosition.Size = New System.Drawing.Size(230, 17)
        Me.checkboxSaveWindowSizeAndPosition.TabIndex = 2
        Me.checkboxSaveWindowSizeAndPosition.Text = "Save main window size and position on exit"
        Me.checkboxSaveWindowSizeAndPosition.UseVisualStyleBackColor = True
        '
        'buttonResetMainWindowSizeAndPosition
        '
        Me.buttonResetMainWindowSizeAndPosition.Location = New System.Drawing.Point(21, 91)
        Me.buttonResetMainWindowSizeAndPosition.Name = "buttonResetMainWindowSizeAndPosition"
        Me.buttonResetMainWindowSizeAndPosition.Size = New System.Drawing.Size(215, 23)
        Me.buttonResetMainWindowSizeAndPosition.TabIndex = 3
        Me.buttonResetMainWindowSizeAndPosition.Text = "Reset main window size and position"
        Me.buttonResetMainWindowSizeAndPosition.UseVisualStyleBackColor = True
        '
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(315, 344)
        Me.Controls.Add(Me.tablelayoutpanelOptionsWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformOptionsWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Options"
        Me.tablelayoutpanelOptionsWindow.ResumeLayout(False)
        Me.groupboxWhenToSearch.ResumeLayout(False)
        Me.groupboxWhenToSearch.PerformLayout()
        Me.groupboxXmlUpdates.ResumeLayout(False)
        Me.groupboxXmlUpdates.PerformLayout()
        Me.groupboxView.ResumeLayout(False)
        Me.groupboxView.PerformLayout()
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
End Class
