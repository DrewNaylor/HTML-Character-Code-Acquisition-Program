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
        Me.menubarMainWindow = New System.Windows.Forms.MenuStrip()
        Me.menubarFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarFileMenuExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarToolsMenuOptionsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenuAboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 304)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Size = New System.Drawing.Size(409, 22)
        Me.statusbarMainWindow.TabIndex = 0
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenu, Me.menubarToolsMenu, Me.menubarHelpMenu})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Size = New System.Drawing.Size(409, 24)
        Me.menubarMainWindow.TabIndex = 1
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenuExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(37, 20)
        Me.menubarFileMenu.Text = "&File"
        '
        'menubarFileMenuExitButton
        '
        Me.menubarFileMenuExitButton.Name = "menubarFileMenuExitButton"
        Me.menubarFileMenuExitButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarFileMenuExitButton.Text = "&Exit"
        '
        'menubarToolsMenu
        '
        Me.menubarToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarToolsMenuOptionsButton})
        Me.menubarToolsMenu.Name = "menubarToolsMenu"
        Me.menubarToolsMenu.Size = New System.Drawing.Size(47, 20)
        Me.menubarToolsMenu.Text = "&Tools"
        '
        'menubarToolsMenuOptionsButton
        '
        Me.menubarToolsMenuOptionsButton.Name = "menubarToolsMenuOptionsButton"
        Me.menubarToolsMenuOptionsButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarToolsMenuOptionsButton.Text = "&Options"
        '
        'menubarHelpMenu
        '
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarHelpMenuAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.menubarHelpMenu.Text = "&Help"
        '
        'menubarHelpMenuAboutButton
        '
        Me.menubarHelpMenuAboutButton.Name = "menubarHelpMenuAboutButton"
        Me.menubarHelpMenuAboutButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarHelpMenuAboutButton.Text = "&About"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(409, 326)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Name = "aaformMainWindow"
        Me.Text = "HTML Character Code Acquisition Program"
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
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
End Class
