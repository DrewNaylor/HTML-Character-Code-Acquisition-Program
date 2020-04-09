<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformMainWindow
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
        Me.statusbarMainWindow = New System.Windows.Forms.StatusStrip()
        Me.statuslabelFilePath = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menubarMainWindow = New System.Windows.Forms.MenuStrip()
        Me.menubarFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarFileMenuExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarToolsMenuOptionsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenuAboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.textboxInput = New System.Windows.Forms.TextBox()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.tablelayoutpanelMainWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.textboxOutput = New System.Windows.Forms.TextBox()
        Me.ReloadXMLFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenXMLFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.statusbarMainWindow.SuspendLayout()
        Me.menubarMainWindow.SuspendLayout()
        Me.tablelayoutpanelMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusbarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelFilePath})
        Me.statusbarMainWindow.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 383)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.statusbarMainWindow.Size = New System.Drawing.Size(500, 25)
        Me.statusbarMainWindow.TabIndex = 0
        '
        'statuslabelFilePath
        '
        Me.statuslabelFilePath.Name = "statuslabelFilePath"
        Me.statuslabelFilePath.Size = New System.Drawing.Size(131, 20)
        Me.statuslabelFilePath.Spring = True
        Me.statuslabelFilePath.Text = "statuslabelFilePath"
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenu, Me.menubarToolsMenu, Me.menubarHelpMenu})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menubarMainWindow.Size = New System.Drawing.Size(500, 28)
        Me.menubarMainWindow.TabIndex = 1
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenXMLFileToolStripMenuItem, Me.ReloadXMLFileToolStripMenuItem, Me.ToolStripSeparator1, Me.menubarFileMenuExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(44, 24)
        Me.menubarFileMenu.Text = "&File"
        '
        'menubarFileMenuExitButton
        '
        Me.menubarFileMenuExitButton.Name = "menubarFileMenuExitButton"
        Me.menubarFileMenuExitButton.Size = New System.Drawing.Size(108, 26)
        Me.menubarFileMenuExitButton.Text = "&Exit"
        '
        'menubarToolsMenu
        '
        Me.menubarToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarToolsMenuOptionsButton})
        Me.menubarToolsMenu.Name = "menubarToolsMenu"
        Me.menubarToolsMenu.Size = New System.Drawing.Size(56, 24)
        Me.menubarToolsMenu.Text = "&Tools"
        '
        'menubarToolsMenuOptionsButton
        '
        Me.menubarToolsMenuOptionsButton.Name = "menubarToolsMenuOptionsButton"
        Me.menubarToolsMenuOptionsButton.Size = New System.Drawing.Size(145, 26)
        Me.menubarToolsMenuOptionsButton.Text = "&Options..."
        '
        'menubarHelpMenu
        '
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarHelpMenuAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(53, 24)
        Me.menubarHelpMenu.Text = "&Help"
        '
        'menubarHelpMenuAboutButton
        '
        Me.menubarHelpMenuAboutButton.Name = "menubarHelpMenuAboutButton"
        Me.menubarHelpMenuAboutButton.Size = New System.Drawing.Size(134, 26)
        Me.menubarHelpMenuAboutButton.Text = "&About..."
        '
        'textboxInput
        '
        Me.textboxInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxInput.Location = New System.Drawing.Point(4, 4)
        Me.textboxInput.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxInput.Name = "textboxInput"
        Me.textboxInput.Size = New System.Drawing.Size(403, 22)
        Me.textboxInput.TabIndex = 0
        '
        'buttonSearch
        '
        Me.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonSearch.Location = New System.Drawing.Point(415, 4)
        Me.buttonSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(81, 27)
        Me.buttonSearch.TabIndex = 1
        Me.buttonSearch.Text = "Search"
        Me.buttonSearch.UseVisualStyleBackColor = True
        '
        'tablelayoutpanelMainWindow
        '
        Me.tablelayoutpanelMainWindow.ColumnCount = 2
        Me.tablelayoutpanelMainWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelMainWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.tablelayoutpanelMainWindow.Controls.Add(Me.buttonSearch, 1, 0)
        Me.tablelayoutpanelMainWindow.Controls.Add(Me.textboxInput, 0, 0)
        Me.tablelayoutpanelMainWindow.Controls.Add(Me.textboxOutput, 0, 1)
        Me.tablelayoutpanelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelMainWindow.Location = New System.Drawing.Point(0, 28)
        Me.tablelayoutpanelMainWindow.Margin = New System.Windows.Forms.Padding(4)
        Me.tablelayoutpanelMainWindow.Name = "tablelayoutpanelMainWindow"
        Me.tablelayoutpanelMainWindow.RowCount = 2
        Me.tablelayoutpanelMainWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tablelayoutpanelMainWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelMainWindow.Size = New System.Drawing.Size(500, 355)
        Me.tablelayoutpanelMainWindow.TabIndex = 3
        '
        'textboxOutput
        '
        Me.tablelayoutpanelMainWindow.SetColumnSpan(Me.textboxOutput, 2)
        Me.textboxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxOutput.Location = New System.Drawing.Point(4, 39)
        Me.textboxOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxOutput.Multiline = True
        Me.textboxOutput.Name = "textboxOutput"
        Me.textboxOutput.ReadOnly = True
        Me.textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxOutput.Size = New System.Drawing.Size(492, 312)
        Me.textboxOutput.TabIndex = 2
        '
        'ReloadXMLFileToolStripMenuItem
        '
        Me.ReloadXMLFileToolStripMenuItem.Name = "ReloadXMLFileToolStripMenuItem"
        Me.ReloadXMLFileToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ReloadXMLFileToolStripMenuItem.Text = "&Reload XML file"
        '
        'OpenXMLFileToolStripMenuItem
        '
        Me.OpenXMLFileToolStripMenuItem.Name = "OpenXMLFileToolStripMenuItem"
        Me.OpenXMLFileToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.OpenXMLFileToolStripMenuItem.Text = "&Open XML file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(500, 408)
        Me.Controls.Add(Me.tablelayoutpanelMainWindow)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "aaformMainWindow"
        Me.Text = "HTML Character Code Acquisition Program"
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
        Me.tablelayoutpanelMainWindow.ResumeLayout(False)
        Me.tablelayoutpanelMainWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents statusbarMainWindow As StatusStrip
    Friend WithEvents menubarMainWindow As MenuStrip
    Friend WithEvents menubarFileMenu As ToolStripMenuItem
    Friend WithEvents menubarFileMenuExitButton As ToolStripMenuItem
    Friend WithEvents menubarToolsMenu As ToolStripMenuItem
    Friend WithEvents menubarToolsMenuOptionsButton As ToolStripMenuItem
    Friend WithEvents menubarHelpMenu As ToolStripMenuItem
    Friend WithEvents menubarHelpMenuAboutButton As ToolStripMenuItem
    Friend WithEvents textboxInput As TextBox
    Friend WithEvents buttonSearch As Button
    Friend WithEvents tablelayoutpanelMainWindow As TableLayoutPanel
    Friend WithEvents textboxOutput As TextBox
    Friend WithEvents statuslabelFilePath As ToolStripStatusLabel
    Friend WithEvents ReloadXMLFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenXMLFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
