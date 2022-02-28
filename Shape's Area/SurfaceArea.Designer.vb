<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurfaceArea
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
        Me.btnsurfaceareacylinder = New System.Windows.Forms.Button()
        Me.btncone = New System.Windows.Forms.Button()
        Me.btncube = New System.Windows.Forms.Button()
        Me.btnsurfaceareasphere = New System.Windows.Forms.Button()
        Me.btnsurfacearearectprism = New System.Windows.Forms.Button()
        Me.txtradiusprompt = New System.Windows.Forms.TextBox()
        Me.lblradius = New System.Windows.Forms.Label()
        Me.lblwidth = New System.Windows.Forms.Label()
        Me.lbllength = New System.Windows.Forms.Label()
        Me.txtlengthprompt = New System.Windows.Forms.TextBox()
        Me.txtwidthprompt = New System.Windows.Forms.TextBox()
        Me.txtheightprompt = New System.Windows.Forms.TextBox()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.lblbase = New System.Windows.Forms.Label()
        Me.txtbaseprompt = New System.Windows.Forms.TextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnpyramid = New System.Windows.Forms.Button()
        Me.btnformulas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsurfaceareacylinder
        '
        Me.btnsurfaceareacylinder.Location = New System.Drawing.Point(194, 707)
        Me.btnsurfaceareacylinder.Name = "btnsurfaceareacylinder"
        Me.btnsurfaceareacylinder.Size = New System.Drawing.Size(370, 58)
        Me.btnsurfaceareacylinder.TabIndex = 15
        Me.btnsurfaceareacylinder.Text = "Surface Area of a Cylinder"
        Me.btnsurfaceareacylinder.UseVisualStyleBackColor = True
        '
        'btncone
        '
        Me.btncone.Location = New System.Drawing.Point(315, 876)
        Me.btncone.Name = "btncone"
        Me.btncone.Size = New System.Drawing.Size(133, 58)
        Me.btncone.TabIndex = 22
        Me.btncone.Text = "Cone"
        Me.btncone.UseVisualStyleBackColor = True
        '
        'btncube
        '
        Me.btncube.Location = New System.Drawing.Point(145, 876)
        Me.btncube.Name = "btncube"
        Me.btncube.Size = New System.Drawing.Size(143, 58)
        Me.btncube.TabIndex = 23
        Me.btncube.Text = "Cube"
        Me.btncube.UseVisualStyleBackColor = True
        '
        'btnsurfaceareasphere
        '
        Me.btnsurfaceareasphere.Location = New System.Drawing.Point(194, 625)
        Me.btnsurfaceareasphere.Name = "btnsurfaceareasphere"
        Me.btnsurfaceareasphere.Size = New System.Drawing.Size(379, 58)
        Me.btnsurfaceareasphere.TabIndex = 24
        Me.btnsurfaceareasphere.Text = "Surface Area of a Sphere"
        Me.btnsurfaceareasphere.UseVisualStyleBackColor = True
        '
        'btnsurfacearearectprism
        '
        Me.btnsurfacearearectprism.Location = New System.Drawing.Point(145, 789)
        Me.btnsurfacearearectprism.Name = "btnsurfacearearectprism"
        Me.btnsurfacearearectprism.Size = New System.Drawing.Size(499, 58)
        Me.btnsurfacearearectprism.TabIndex = 25
        Me.btnsurfacearearectprism.Text = "Surface Area of a Rectangular Prism"
        Me.btnsurfacearearectprism.UseVisualStyleBackColor = True
        '
        'txtradiusprompt
        '
        Me.txtradiusprompt.Location = New System.Drawing.Point(213, 521)
        Me.txtradiusprompt.Name = "txtradiusprompt"
        Me.txtradiusprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtradiusprompt.TabIndex = 35
        '
        'lblradius
        '
        Me.lblradius.AutoSize = True
        Me.lblradius.Location = New System.Drawing.Point(59, 521)
        Me.lblradius.Name = "lblradius"
        Me.lblradius.Size = New System.Drawing.Size(113, 41)
        Me.lblradius.TabIndex = 34
        Me.lblradius.Text = "Radius:"
        '
        'lblwidth
        '
        Me.lblwidth.AutoSize = True
        Me.lblwidth.Location = New System.Drawing.Point(60, 241)
        Me.lblwidth.Name = "lblwidth"
        Me.lblwidth.Size = New System.Drawing.Size(105, 41)
        Me.lblwidth.TabIndex = 33
        Me.lblwidth.Text = "Width:"
        '
        'lbllength
        '
        Me.lbllength.AutoSize = True
        Me.lbllength.Location = New System.Drawing.Point(60, 144)
        Me.lbllength.Name = "lbllength"
        Me.lbllength.Size = New System.Drawing.Size(117, 41)
        Me.lbllength.TabIndex = 32
        Me.lbllength.Text = "Length:"
        '
        'txtlengthprompt
        '
        Me.txtlengthprompt.Location = New System.Drawing.Point(213, 144)
        Me.txtlengthprompt.Name = "txtlengthprompt"
        Me.txtlengthprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtlengthprompt.TabIndex = 31
        '
        'txtwidthprompt
        '
        Me.txtwidthprompt.Location = New System.Drawing.Point(213, 241)
        Me.txtwidthprompt.Name = "txtwidthprompt"
        Me.txtwidthprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtwidthprompt.TabIndex = 30
        '
        'txtheightprompt
        '
        Me.txtheightprompt.Location = New System.Drawing.Point(213, 425)
        Me.txtheightprompt.Name = "txtheightprompt"
        Me.txtheightprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtheightprompt.TabIndex = 29
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(60, 425)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(114, 41)
        Me.lblheight.TabIndex = 28
        Me.lblheight.Text = "Height:"
        '
        'lblbase
        '
        Me.lblbase.AutoSize = True
        Me.lblbase.Location = New System.Drawing.Point(59, 339)
        Me.lblbase.Name = "lblbase"
        Me.lblbase.Size = New System.Drawing.Size(86, 41)
        Me.lblbase.TabIndex = 27
        Me.lblbase.Text = "Base:"
        '
        'txtbaseprompt
        '
        Me.txtbaseprompt.Location = New System.Drawing.Point(213, 339)
        Me.txtbaseprompt.Name = "txtbaseprompt"
        Me.txtbaseprompt.Size = New System.Drawing.Size(431, 47)
        Me.txtbaseprompt.TabIndex = 26
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitle.Location = New System.Drawing.Point(252, 36)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(289, 67)
        Me.lbltitle.TabIndex = 36
        Me.lbltitle.Text = "Surface Area "
        '
        'btnpyramid
        '
        Me.btnpyramid.Location = New System.Drawing.Point(466, 876)
        Me.btnpyramid.Name = "btnpyramid"
        Me.btnpyramid.Size = New System.Drawing.Size(188, 58)
        Me.btnpyramid.TabIndex = 37
        Me.btnpyramid.Text = "Pyramid"
        Me.btnpyramid.UseVisualStyleBackColor = True
        '
        'btnformulas
        '
        Me.btnformulas.Location = New System.Drawing.Point(296, 962)
        Me.btnformulas.Name = "btnformulas"
        Me.btnformulas.Size = New System.Drawing.Size(188, 58)
        Me.btnformulas.TabIndex = 38
        Me.btnformulas.Text = "Formulas"
        Me.btnformulas.UseVisualStyleBackColor = True
        '
        'SurfaceArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 1100)
        Me.Controls.Add(Me.btnformulas)
        Me.Controls.Add(Me.btnpyramid)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtradiusprompt)
        Me.Controls.Add(Me.lblradius)
        Me.Controls.Add(Me.lblwidth)
        Me.Controls.Add(Me.lbllength)
        Me.Controls.Add(Me.txtlengthprompt)
        Me.Controls.Add(Me.txtwidthprompt)
        Me.Controls.Add(Me.txtheightprompt)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lblbase)
        Me.Controls.Add(Me.txtbaseprompt)
        Me.Controls.Add(Me.btnsurfacearearectprism)
        Me.Controls.Add(Me.btnsurfaceareasphere)
        Me.Controls.Add(Me.btncube)
        Me.Controls.Add(Me.btncone)
        Me.Controls.Add(Me.btnsurfaceareacylinder)
        Me.Name = "SurfaceArea"
        Me.Text = "Surface Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsurfaceareacylinder As Button
    Friend WithEvents btncone As Button
    Friend WithEvents btncube As Button
    Friend WithEvents btnsurfaceareasphere As Button
    Friend WithEvents btnsurfacearearectprism As Button
    Friend WithEvents txtradiusprompt As TextBox
    Friend WithEvents lblradius As Label
    Friend WithEvents lblwidth As Label
    Friend WithEvents lbllength As Label
    Friend WithEvents txtlengthprompt As TextBox
    Friend WithEvents txtwidthprompt As TextBox
    Friend WithEvents txtheightprompt As TextBox
    Friend WithEvents lblheight As Label
    Friend WithEvents lblbase As Label
    Friend WithEvents txtbaseprompt As TextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnpyramid As Button
    Friend WithEvents btnformulas As Button
End Class
