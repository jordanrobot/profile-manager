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
        Me.SuspendLayout
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(164, 22)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Profile"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnDuplicate
        '
        Me.btnDuplicate.Location = New System.Drawing.Point(164, 74)
        Me.btnDuplicate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(94, 23)
        Me.btnDuplicate.TabIndex = 1
        Me.btnDuplicate.Text = "Duplicate Profile"
        Me.btnDuplicate.UseVisualStyleBackColor = true
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(164, 100)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Profile"
        Me.btnDelete.UseVisualStyleBackColor = true
        '
        'btnExport
        '
        Me.btnExport.Enabled = false
        Me.btnExport.Location = New System.Drawing.Point(164, 126)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(94, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export Profile"
        Me.btnExport.UseVisualStyleBackColor = true
        '
        'btnImport
        '
        Me.btnImport.Enabled = false
        Me.btnImport.Location = New System.Drawing.Point(164, 152)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(94, 23)
        Me.btnImport.TabIndex = 4
        Me.btnImport.Text = "Import Profile"
        Me.btnImport.UseVisualStyleBackColor = true
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(164, 48)
        Me.btnActivate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(94, 23)
        Me.btnActivate.TabIndex = 5
        Me.btnActivate.Text = "Activate Profile"
        Me.btnActivate.UseVisualStyleBackColor = true
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(164, 223)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Profiles"
        '
        'lboxProfiles
        '
        Me.lboxProfiles.FormattingEnabled = true
        Me.lboxProfiles.Items.AddRange(New Object() {"<<default>>"})
        Me.lboxProfiles.Location = New System.Drawing.Point(10, 22)
        Me.lboxProfiles.Margin = New System.Windows.Forms.Padding(2)
        Me.lboxProfiles.Name = "lboxProfiles"
        Me.lboxProfiles.Size = New System.Drawing.Size(145, 225)
        Me.lboxProfiles.TabIndex = 9
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(211, 195)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(48, 24)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = true
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 256)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formMain"
        Me.Text = "Inventor Profile Manager"
        Me.ResumeLayout(false)
        Me.PerformLayout

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
