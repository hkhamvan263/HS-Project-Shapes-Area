<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btntrianglearea = New System.Windows.Forms.Button()
        Me.btnrectanglearea = New System.Windows.Forms.Button()
        Me.btncirclearea = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtbaseprompt = New System.Windows.Forms.TextBox()
        Me.lblbase = New System.Windows.Forms.Label()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.txtheightprompt = New System.Windows.Forms.TextBox()
        Me.txtwidthprompt = New System.Windows.Forms.TextBox()
        Me.txtlengthprompt = New System.Windows.Forms.TextBox()
        Me.lbllength = New System.Windows.Forms.Label()
        Me.lblwidth = New System.Windows.Forms.Label()
        Me.lblradius = New System.Windows.Forms.Label()
        Me.txtradiusprompt = New System.Windows.Forms.TextBox()
        Me.btninfo = New System.Windows.Forms.Button()
        Me.btnsurfacearea = New System.Windows.Forms.Button()
        Me.btnformulas = New System.Windows.Forms.Button()
        Me.btnothershapes = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SurfaceAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherShapesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btntrianglearea
        '
        Me.btntrianglearea.Location = New System.Drawing.Point(67, 621)
        Me.btntrianglearea.Name = "btntrianglearea"
        Me.btntrianglearea.Size = New System.Drawing.Size(289, 58)
        Me.btntrianglearea.TabIndex = 0
        Me.btntrianglearea.Text = "Area of a Triangle"
        Me.btntrianglearea.UseVisualStyleBackColor = True
        '
        'btnrectanglearea
        '
        Me.btnrectanglearea.Location = New System.Drawing.Point(67, 703)
        Me.btnrectanglearea.Name = "btnrectanglearea"
        Me.btnrectanglearea.Size = New System.Drawing.Size(288, 58)
        Me.btnrectanglearea.TabIndex = 1
        Me.btnrectanglearea.Text = "Area of a Rectangle"
        Me.btnrectanglearea.UseVisualStyleBackColor = True
        '
        'btncirclearea
        '
        Me.btncirclearea.Location = New System.Drawing.Point(376, 621)
        Me.btncirclearea.Name = "btncirclearea"
        Me.btncirclearea.Size = New System.Drawing.Size(267, 58)
        Me.btncirclearea.TabIndex = 3
        Me.btncirclearea.Text = "Area of a Circle"
        Me.btncirclearea.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitle.Location = New System.Drawing.Point(157, 143)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(442, 67)
        Me.lbltitle.TabIndex = 5
        Me.lbltitle.Text = "Area of Each Shape"
        '
        'txtbaseprompt
        '
        Me.txtbaseprompt.Location = New System.Drawing.Point(316, 377)
        Me.txtbaseprompt.Name = "txtbaseprompt"
        Me.txtbaseprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtbaseprompt.TabIndex = 6
        '
        'lblbase
        '
        Me.lblbase.AutoSize = True
        Me.lblbase.Location = New System.Drawing.Point(102, 377)
        Me.lblbase.Name = "lblbase"
        Me.lblbase.Size = New System.Drawing.Size(86, 41)
        Me.lblbase.TabIndex = 7
        Me.lblbase.Text = "Base:"
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(103, 440)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(114, 41)
        Me.lblheight.TabIndex = 8
        Me.lblheight.Text = "Height:"
        '
        'txtheightprompt
        '
        Me.txtheightprompt.Location = New System.Drawing.Point(316, 440)
        Me.txtheightprompt.Name = "txtheightprompt"
        Me.txtheightprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtheightprompt.TabIndex = 9
        '
        'txtwidthprompt
        '
        Me.txtwidthprompt.Location = New System.Drawing.Point(316, 308)
        Me.txtwidthprompt.Name = "txtwidthprompt"
        Me.txtwidthprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtwidthprompt.TabIndex = 10
        '
        'txtlengthprompt
        '
        Me.txtlengthprompt.Location = New System.Drawing.Point(316, 240)
        Me.txtlengthprompt.Name = "txtlengthprompt"
        Me.txtlengthprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtlengthprompt.TabIndex = 11
        '
        'lbllength
        '
        Me.lbllength.AutoSize = True
        Me.lbllength.Location = New System.Drawing.Point(103, 240)
        Me.lbllength.Name = "lbllength"
        Me.lbllength.Size = New System.Drawing.Size(117, 41)
        Me.lbllength.TabIndex = 12
        Me.lbllength.Text = "Length:"
        '
        'lblwidth
        '
        Me.lblwidth.AutoSize = True
        Me.lblwidth.Location = New System.Drawing.Point(103, 308)
        Me.lblwidth.Name = "lblwidth"
        Me.lblwidth.Size = New System.Drawing.Size(105, 41)
        Me.lblwidth.TabIndex = 13
        Me.lblwidth.Text = "Width:"
        '
        'lblradius
        '
        Me.lblradius.AutoSize = True
        Me.lblradius.Location = New System.Drawing.Point(102, 506)
        Me.lblradius.Name = "lblradius"
        Me.lblradius.Size = New System.Drawing.Size(113, 41)
        Me.lblradius.TabIndex = 15
        Me.lblradius.Text = "Radius:"
        '
        'txtradiusprompt
        '
        Me.txtradiusprompt.Location = New System.Drawing.Point(316, 506)
        Me.txtradiusprompt.Name = "txtradiusprompt"
        Me.txtradiusprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtradiusprompt.TabIndex = 16
        '
        'btninfo
        '
        Me.btninfo.Location = New System.Drawing.Point(376, 779)
        Me.btninfo.Name = "btninfo"
        Me.btninfo.Size = New System.Drawing.Size(267, 58)
        Me.btninfo.TabIndex = 20
        Me.btninfo.Text = "Information"
        Me.btninfo.UseVisualStyleBackColor = True
        '
        'btnsurfacearea
        '
        Me.btnsurfacearea.Location = New System.Drawing.Point(376, 703)
        Me.btnsurfacearea.Name = "btnsurfacearea"
        Me.btnsurfacearea.Size = New System.Drawing.Size(267, 58)
        Me.btnsurfacearea.TabIndex = 23
        Me.btnsurfacearea.Text = "Surface Area"
        Me.btnsurfacearea.UseVisualStyleBackColor = True
        '
        'btnformulas
        '
        Me.btnformulas.Location = New System.Drawing.Point(213, 866)
        Me.btnformulas.Name = "btnformulas"
        Me.btnformulas.Size = New System.Drawing.Size(288, 58)
        Me.btnformulas.TabIndex = 24
        Me.btnformulas.Text = "Formulas"
        Me.btnformulas.UseVisualStyleBackColor = True
        '
        'btnothershapes
        '
        Me.btnothershapes.Location = New System.Drawing.Point(67, 779)
        Me.btnothershapes.Name = "btnothershapes"
        Me.btnothershapes.Size = New System.Drawing.Size(288, 58)
        Me.btnothershapes.TabIndex = 25
        Me.btnothershapes.Text = "Other Shapes"
        Me.btnothershapes.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SurfaceAreaToolStripMenuItem, Me.OtherShapesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(739, 52)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SurfaceAreaToolStripMenuItem
        '
        Me.SurfaceAreaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CubeToolStripMenuItem, Me.ConeToolStripMenuItem})
        Me.SurfaceAreaToolStripMenuItem.Name = "SurfaceAreaToolStripMenuItem"
        Me.SurfaceAreaToolStripMenuItem.Size = New System.Drawing.Size(207, 48)
        Me.SurfaceAreaToolStripMenuItem.Text = "Surface Area"
        '
        'CubeToolStripMenuItem
        '
        Me.CubeToolStripMenuItem.Name = "CubeToolStripMenuItem"
        Me.CubeToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.CubeToolStripMenuItem.Text = "Cube"
        '
        'ConeToolStripMenuItem
        '
        Me.ConeToolStripMenuItem.Name = "ConeToolStripMenuItem"
        Me.ConeToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ConeToolStripMenuItem.Text = "Cone"
        '
        'OtherShapesToolStripMenuItem
        '
        Me.OtherShapesToolStripMenuItem.Name = "OtherShapesToolStripMenuItem"
        Me.OtherShapesToolStripMenuItem.Size = New System.Drawing.Size(221, 48)
        Me.OtherShapesToolStripMenuItem.Text = "Other Shapes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 1054)
        Me.Controls.Add(Me.btnothershapes)
        Me.Controls.Add(Me.btnformulas)
        Me.Controls.Add(Me.btnsurfacearea)
        Me.Controls.Add(Me.btninfo)
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
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btncirclearea)
        Me.Controls.Add(Me.btnrectanglearea)
        Me.Controls.Add(Me.btntrianglearea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Area of Each Shape"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntrianglearea As Button
    Friend WithEvents btnrectanglearea As Button
    Friend WithEvents btncirclearea As Button
    Friend WithEvents lbltitle As Label
    Friend WithEvents txtbaseprompt As TextBox
    Friend WithEvents lblbase As Label
    Friend WithEvents lblheight As Label
    Friend WithEvents txtheightprompt As TextBox
    Friend WithEvents txtwidthprompt As TextBox
    Friend WithEvents txtlengthprompt As TextBox
    Friend WithEvents lbllength As Label
    Friend WithEvents lblwidth As Label
    Friend WithEvents lblradius As Label
    Friend WithEvents txtradiusprompt As TextBox
    Friend WithEvents btninfo As Button
    Friend WithEvents btnsurfacearea As Button
    Friend WithEvents btnformulas As Button
    Friend WithEvents btnothershapes As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OtherShapesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SurfaceAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConeToolStripMenuItem As ToolStripMenuItem
End Class
