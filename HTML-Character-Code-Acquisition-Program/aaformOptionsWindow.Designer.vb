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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonRestoreDefaults = New System.Windows.Forms.Button()
        Me.groupboxWhenToSearch = New System.Windows.Forms.GroupBox()
        Me.groupboxXmlUpdates = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.labelSearchAlwaysAvailableIfButtonShown = New System.Windows.Forms.Label()
        Me.labelCurrentXmlVersion = New System.Windows.Forms.Label()
        Me.buttonCheckForXmlUpdates = New System.Windows.Forms.Button()
        Me.linklabelXmlVersionAvailable = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupboxWhenToSearch.SuspendLayout()
        Me.groupboxXmlUpdates.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxXmlUpdates, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonSave, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonCancel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonRestoreDefaults, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.groupboxWhenToSearch, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 344)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.TableLayoutPanel1.SetColumnSpan(Me.groupboxWhenToSearch, 4)
        Me.groupboxWhenToSearch.Controls.Add(Me.labelSearchAlwaysAvailableIfButtonShown)
        Me.groupboxWhenToSearch.Controls.Add(Me.RadioButton2)
        Me.groupboxWhenToSearch.Controls.Add(Me.RadioButton1)
        Me.groupboxWhenToSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxWhenToSearch.Location = New System.Drawing.Point(3, 3)
        Me.groupboxWhenToSearch.Name = "groupboxWhenToSearch"
        Me.groupboxWhenToSearch.Size = New System.Drawing.Size(309, 90)
        Me.groupboxWhenToSearch.TabIndex = 3
        Me.groupboxWhenToSearch.TabStop = False
        Me.groupboxWhenToSearch.Text = "When to search"
        '
        'groupboxXmlUpdates
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.groupboxXmlUpdates, 4)
        Me.groupboxXmlUpdates.Controls.Add(Me.linklabelXmlVersionAvailable)
        Me.groupboxXmlUpdates.Controls.Add(Me.buttonCheckForXmlUpdates)
        Me.groupboxXmlUpdates.Controls.Add(Me.labelCurrentXmlVersion)
        Me.groupboxXmlUpdates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupboxXmlUpdates.Location = New System.Drawing.Point(3, 99)
        Me.groupboxXmlUpdates.Name = "groupboxXmlUpdates"
        Me.groupboxXmlUpdates.Size = New System.Drawing.Size(309, 99)
        Me.groupboxXmlUpdates.TabIndex = 4
        Me.groupboxXmlUpdates.TabStop = False
        Me.groupboxXmlUpdates.Text = "XML file updates"
        '
        'GroupBox3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox3, 4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 105)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Search on Enter"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Search when typing"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'labelSearchAlwaysAvailableIfButtonShown
        '
        Me.labelSearchAlwaysAvailableIfButtonShown.AutoSize = True
        Me.labelSearchAlwaysAvailableIfButtonShown.Location = New System.Drawing.Point(4, 63)
        Me.labelSearchAlwaysAvailableIfButtonShown.Name = "labelSearchAlwaysAvailableIfButtonShown"
        Me.labelSearchAlwaysAvailableIfButtonShown.Size = New System.Drawing.Size(262, 13)
        Me.labelSearchAlwaysAvailableIfButtonShown.TabIndex = 2
        Me.labelSearchAlwaysAvailableIfButtonShown.Text = "You can always search by clicking ""Search"" if shown."
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
        Me.buttonCheckForXmlUpdates.Location = New System.Drawing.Point(6, 50)
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
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(315, 344)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformOptionsWindow"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "aaformOptionsWindow"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.groupboxWhenToSearch.ResumeLayout(False)
        Me.groupboxWhenToSearch.PerformLayout()
        Me.groupboxXmlUpdates.ResumeLayout(False)
        Me.groupboxXmlUpdates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents buttonSave As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonRestoreDefaults As Button
    Friend WithEvents groupboxWhenToSearch As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents groupboxXmlUpdates As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents labelSearchAlwaysAvailableIfButtonShown As Label
    Friend WithEvents labelCurrentXmlVersion As Label
    Friend WithEvents linklabelXmlVersionAvailable As LinkLabel
    Friend WithEvents buttonCheckForXmlUpdates As Button
End Class
