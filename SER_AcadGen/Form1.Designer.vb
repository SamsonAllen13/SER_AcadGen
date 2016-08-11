<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.lblTemplate = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtOutfile = New System.Windows.Forms.TextBox()
        Me.lblOutfile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(163, 124)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(498, 26)
        Me.txtTemplate.TabIndex = 0
        '
        'lblTemplate
        '
        Me.lblTemplate.AutoSize = True
        Me.lblTemplate.Location = New System.Drawing.Point(82, 127)
        Me.lblTemplate.Name = "lblTemplate"
        Me.lblTemplate.Size = New System.Drawing.Size(75, 20)
        Me.lblTemplate.TabIndex = 1
        Me.lblTemplate.Text = "Template"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(337, 329)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(77, 33)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtOutfile
        '
        Me.txtOutfile.Location = New System.Drawing.Point(163, 179)
        Me.txtOutfile.Name = "txtOutfile"
        Me.txtOutfile.Size = New System.Drawing.Size(498, 26)
        Me.txtOutfile.TabIndex = 3
        '
        'lblOutfile
        '
        Me.lblOutfile.AutoSize = True
        Me.lblOutfile.Location = New System.Drawing.Point(82, 185)
        Me.lblOutfile.Name = "lblOutfile"
        Me.lblOutfile.Size = New System.Drawing.Size(55, 20)
        Me.lblOutfile.TabIndex = 4
        Me.lblOutfile.Text = "Outfile"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 399)
        Me.Controls.Add(Me.lblOutfile)
        Me.Controls.Add(Me.txtOutfile)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lblTemplate)
        Me.Controls.Add(Me.txtTemplate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTemplate As TextBox
    Friend WithEvents lblTemplate As Label
    Friend WithEvents btnRun As Button
    Friend WithEvents txtOutfile As TextBox
    Friend WithEvents lblOutfile As Label
End Class
