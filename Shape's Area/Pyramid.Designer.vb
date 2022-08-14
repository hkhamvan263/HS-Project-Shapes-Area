<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pyramid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblwidth = New System.Windows.Forms.Label()
        Me.lbllength = New System.Windows.Forms.Label()
        Me.txtlengthprompt = New System.Windows.Forms.TextBox()
        Me.txtwidthprompt = New System.Windows.Forms.TextBox()
        Me.txtheightprompt = New System.Windows.Forms.TextBox()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.lblbase = New System.Windows.Forms.Label()
        Me.txtbaseprompt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPyramidSAFormula = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitle.Location = New System.Drawing.Point(93, 60)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(625, 67)
        Me.lbltitle.TabIndex = 47
        Me.lbltitle.Text = "Surface Area of a Pyramid"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblwidth
        '
        Me.lblwidth.AutoSize = True
        Me.lblwidth.Location = New System.Drawing.Point(71, 263)
        Me.lblwidth.Name = "lblwidth"
        Me.lblwidth.Size = New System.Drawing.Size(105, 41)
        Me.lblwidth.TabIndex = 44
        Me.lblwidth.Text = "Width:"
        '
        'lbllength
        '
        Me.lbllength.AutoSize = True
        Me.lbllength.Location = New System.Drawing.Point(71, 166)
        Me.lbllength.Name = "lbllength"
        Me.lbllength.Size = New System.Drawing.Size(117, 41)
        Me.lbllength.TabIndex = 43
        Me.lbllength.Text = "Length:"
        '
        'txtlengthprompt
        '
        Me.txtlengthprompt.Location = New System.Drawing.Point(224, 166)
        Me.txtlengthprompt.Name = "txtlengthprompt"
        Me.txtlengthprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtlengthprompt.TabIndex = 42
        '
        'txtwidthprompt
        '
        Me.txtwidthprompt.Location = New System.Drawing.Point(224, 263)
        Me.txtwidthprompt.Name = "txtwidthprompt"
        Me.txtwidthprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtwidthprompt.TabIndex = 41
        '
        'txtheightprompt
        '
        Me.txtheightprompt.Location = New System.Drawing.Point(224, 447)
        Me.txtheightprompt.Name = "txtheightprompt"
        Me.txtheightprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtheightprompt.TabIndex = 40
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(71, 447)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(114, 41)
        Me.lblheight.TabIndex = 39
        Me.lblheight.Text = "Height:"
        '
        'lblbase
        '
        Me.lblbase.AutoSize = True
        Me.lblbase.Location = New System.Drawing.Point(70, 361)
        Me.lblbase.Name = "lblbase"
        Me.lblbase.Size = New System.Drawing.Size(86, 41)
        Me.lblbase.TabIndex = 38
        Me.lblbase.Text = "Base:"
        '
        'txtbaseprompt
        '
        Me.txtbaseprompt.Location = New System.Drawing.Point(224, 361)
        Me.txtbaseprompt.Name = "txtbaseprompt"
        Me.txtbaseprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtbaseprompt.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 58)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPyramidSAFormula
        '
        Me.btnPyramidSAFormula.Location = New System.Drawing.Point(364, 557)
        Me.btnPyramidSAFormula.Name = "btnPyramidSAFormula"
        Me.btnPyramidSAFormula.Size = New System.Drawing.Size(188, 58)
        Me.btnPyramidSAFormula.TabIndex = 49
        Me.btnPyramidSAFormula.Text = "Formula"
        Me.btnPyramidSAFormula.UseVisualStyleBackColor = True
        '
        'Pyramid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.btnPyramidSAFormula)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lblwidth)
        Me.Controls.Add(Me.lbllength)
        Me.Controls.Add(Me.txtlengthprompt)
        Me.Controls.Add(Me.txtwidthprompt)
        Me.Controls.Add(Me.txtheightprompt)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lblbase)
        Me.Controls.Add(Me.txtbaseprompt)
        Me.Name = "Pyramid"
        Me.Text = "Pyramid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblwidth As Label
    Friend WithEvents lbllength As Label
    Friend WithEvents txtlengthprompt As TextBox
    Friend WithEvents txtwidthprompt As TextBox
    Friend WithEvents txtheightprompt As TextBox
    Friend WithEvents lblheight As Label
    Friend WithEvents lblbase As Label
    Friend WithEvents txtbaseprompt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPyramidSAFormula As Button
End Class
