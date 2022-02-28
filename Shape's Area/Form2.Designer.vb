<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbltitletrapezoid = New System.Windows.Forms.Label()
        Me.lblbasea = New System.Windows.Forms.Label()
        Me.lblbaseb = New System.Windows.Forms.Label()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.btntrapezoidarea = New System.Windows.Forms.Button()
        Me.txtbaseaprompt = New System.Windows.Forms.TextBox()
        Me.txtbasebprompt = New System.Windows.Forms.TextBox()
        Me.txtheightprompt = New System.Windows.Forms.TextBox()
        Me.btnformula = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltitletrapezoid
        '
        Me.lbltitletrapezoid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitletrapezoid.Location = New System.Drawing.Point(134, 35)
        Me.lbltitletrapezoid.Name = "lbltitletrapezoid"
        Me.lbltitletrapezoid.Size = New System.Drawing.Size(537, 77)
        Me.lbltitletrapezoid.TabIndex = 0
        Me.lbltitletrapezoid.Text = "Area of a Trapezoid"
        '
        'lblbasea
        '
        Me.lblbasea.AutoSize = True
        Me.lblbasea.Location = New System.Drawing.Point(103, 150)
        Me.lblbasea.Name = "lblbasea"
        Me.lblbasea.Size = New System.Drawing.Size(113, 41)
        Me.lblbasea.TabIndex = 1
        Me.lblbasea.Text = "Base A:"
        '
        'lblbaseb
        '
        Me.lblbaseb.AutoSize = True
        Me.lblbaseb.Location = New System.Drawing.Point(103, 276)
        Me.lblbaseb.Name = "lblbaseb"
        Me.lblbaseb.Size = New System.Drawing.Size(111, 41)
        Me.lblbaseb.TabIndex = 2
        Me.lblbaseb.Text = "Base B:"
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(103, 415)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(114, 41)
        Me.lblheight.TabIndex = 3
        Me.lblheight.Text = "Height:"
        '
        'btntrapezoidarea
        '
        Me.btntrapezoidarea.Location = New System.Drawing.Point(220, 530)
        Me.btntrapezoidarea.Name = "btntrapezoidarea"
        Me.btntrapezoidarea.Size = New System.Drawing.Size(303, 58)
        Me.btntrapezoidarea.TabIndex = 4
        Me.btntrapezoidarea.Text = "Area of a Trapezoid"
        Me.btntrapezoidarea.UseVisualStyleBackColor = True
        '
        'txtbaseaprompt
        '
        Me.txtbaseaprompt.Location = New System.Drawing.Point(349, 150)
        Me.txtbaseaprompt.Name = "txtbaseaprompt"
        Me.txtbaseaprompt.Size = New System.Drawing.Size(250, 47)
        Me.txtbaseaprompt.TabIndex = 6
        '
        'txtbasebprompt
        '
        Me.txtbasebprompt.Location = New System.Drawing.Point(349, 276)
        Me.txtbasebprompt.Name = "txtbasebprompt"
        Me.txtbasebprompt.Size = New System.Drawing.Size(250, 47)
        Me.txtbasebprompt.TabIndex = 7
        '
        'txtheightprompt
        '
        Me.txtheightprompt.Location = New System.Drawing.Point(349, 409)
        Me.txtheightprompt.Name = "txtheightprompt"
        Me.txtheightprompt.Size = New System.Drawing.Size(250, 47)
        Me.txtheightprompt.TabIndex = 8
        '
        'btnformula
        '
        Me.btnformula.Location = New System.Drawing.Point(274, 621)
        Me.btnformula.Name = "btnformula"
        Me.btnformula.Size = New System.Drawing.Size(188, 58)
        Me.btnformula.TabIndex = 9
        Me.btnformula.Text = "Formula"
        Me.btnformula.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 766)
        Me.Controls.Add(Me.btnformula)
        Me.Controls.Add(Me.txtheightprompt)
        Me.Controls.Add(Me.txtbasebprompt)
        Me.Controls.Add(Me.txtbaseaprompt)
        Me.Controls.Add(Me.btntrapezoidarea)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lblbaseb)
        Me.Controls.Add(Me.lblbasea)
        Me.Controls.Add(Me.lbltitletrapezoid)
        Me.Name = "Form2"
        Me.Text = "Area of a Trapezoid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitletrapezoid As Label
    Friend WithEvents lblbasea As Label
    Friend WithEvents lblbaseb As Label
    Friend WithEvents lblheight As Label
    Friend WithEvents btntrapezoidarea As Button
    Friend WithEvents txtbaseaprompt As TextBox
    Friend WithEvents txtbasebprompt As TextBox
    Friend WithEvents txtheightprompt As TextBox
    Friend WithEvents btnformula As Button
End Class
