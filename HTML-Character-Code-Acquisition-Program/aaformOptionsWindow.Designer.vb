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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.buttonSave, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonCancel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonRestoreDefaults, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 344)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'buttonSave
        '
        Me.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonSave.Location = New System.Drawing.Point(247, 315)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(65, 26)
        Me.buttonSave.TabIndex = 0
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(174, 315)
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
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(315, 344)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "aaformOptionsWindow"
        Me.Text = "aaformOptionsWindow"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents buttonSave As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonRestoreDefaults As Button
End Class
