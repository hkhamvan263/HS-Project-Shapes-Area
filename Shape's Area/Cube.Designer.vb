<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cube
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
        Me.txtedgeprompt = New System.Windows.Forms.TextBox()
        Me.btnsurfaceareacube = New System.Windows.Forms.Button()
        Me.lbledge = New System.Windows.Forms.Label()
        Me.lbltitlecube = New System.Windows.Forms.Label()
        Me.btnsacubeformula = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtedgeprompt
        '
        Me.txtedgeprompt.Location = New System.Drawing.Point(349, 220)
        Me.txtedgeprompt.Name = "txtedgeprompt"
        Me.txtedgeprompt.Size = New System.Drawing.Size(250, 47)
        Me.txtedgeprompt.TabIndex = 14
        '
        'btnsurfaceareacube
        '
        Me.btnsurfaceareacube.Location = New System.Drawing.Point(218, 356)
        Me.btnsurfaceareacube.Name = "btnsurfaceareacube"
        Me.btnsurfaceareacube.Size = New System.Drawing.Size(339, 58)
        Me.btnsurfaceareacube.TabIndex = 13
        Me.btnsurfaceareacube.Text = "Surface Area of a Cube"
        Me.btnsurfaceareacube.UseVisualStyleBackColor = True
        '
        'lbledge
        '
        Me.lbledge.AutoSize = True
        Me.lbledge.Location = New System.Drawing.Point(147, 226)
        Me.lbledge.Name = "lbledge"
        Me.lbledge.Size = New System.Drawing.Size(92, 41)
        Me.lbledge.TabIndex = 10
        Me.lbledge.Text = "Edge:"
        '
        'lbltitlecube
        '
        Me.lbltitlecube.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitlecube.Location = New System.Drawing.Point(147, 44)
        Me.lbltitlecube.Name = "lbltitlecube"
        Me.lbltitlecube.Size = New System.Drawing.Size(537, 77)
        Me.lbltitlecube.TabIndex = 9
        Me.lbltitlecube.Text = "Surface Area of a Cube"
        '
        'btnsacubeformula
        '
        Me.btnsacubeformula.Location = New System.Drawing.Point(218, 458)
        Me.btnsacubeformula.Name = "btnsacubeformula"
        Me.btnsacubeformula.Size = New System.Drawing.Size(339, 58)
        Me.btnsacubeformula.TabIndex = 15
        Me.btnsacubeformula.Text = "Formula"
        Me.btnsacubeformula.UseVisualStyleBackColor = True
        '
        'Cube
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 680)
        Me.Controls.Add(Me.btnsacubeformula)
        Me.Controls.Add(Me.txtedgeprompt)
        Me.Controls.Add(Me.btnsurfaceareacube)
        Me.Controls.Add(Me.lbledge)
        Me.Controls.Add(Me.lbltitlecube)
        Me.Name = "Cube"
        Me.Text = "Surface Area of a Cube"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtedgeprompt As TextBox
    Friend WithEvents btnsurfaceareacube As Button
    Friend WithEvents lbledge As Label
    Friend WithEvents lbltitlecube As Label
    Friend WithEvents btnsacubeformula As Button
End Class
