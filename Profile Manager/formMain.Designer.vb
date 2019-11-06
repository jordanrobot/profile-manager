<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDuplicate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lboxProfiles = New System.Windows.Forms.ListBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(301, 41)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(173, 42)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Profile"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDuplicate
        '
        Me.btnDuplicate.Location = New System.Drawing.Point(301, 137)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(173, 42)
        Me.btnDuplicate.TabIndex = 1
        Me.btnDuplicate.Text = "Duplicate Profile"
        Me.btnDuplicate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(301, 185)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(173, 42)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(301, 233)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(173, 42)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export Profile"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.Location = New System.Drawing.Point(301, 281)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(173, 42)
        Me.btnImport.TabIndex = 4
        Me.btnImport.Text = "Import Profile"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(301, 89)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(173, 42)
        Me.btnActivate.TabIndex = 5
        Me.btnActivate.Text = "Activate Profile"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(301, 411)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(173, 42)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Profiles"
        '
        'lboxProfiles
        '
        Me.lboxProfiles.FormattingEnabled = True
        Me.lboxProfiles.ItemHeight = 24
        Me.lboxProfiles.Items.AddRange(New Object() {"<<default>>"})
        Me.lboxProfiles.Location = New System.Drawing.Point(18, 41)
        Me.lboxProfiles.Name = "lboxProfiles"
        Me.lboxProfiles.Size = New System.Drawing.Size(262, 412)
        Me.lboxProfiles.TabIndex = 9
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(386, 360)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(88, 45)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 473)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lboxProfiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDuplicate)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "formMain"
        Me.Text = "Inventor Profile Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnDuplicate As Windows.Forms.Button
    Friend WithEvents btnDelete As Windows.Forms.Button
    Friend WithEvents btnExport As Windows.Forms.Button
    Friend WithEvents btnImport As Windows.Forms.Button
    Friend WithEvents btnActivate As Windows.Forms.Button
    Friend WithEvents btnClose As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lboxProfiles As Windows.Forms.ListBox
    Friend WithEvents btnAbout As Windows.Forms.Button
End Class
