<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cone
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
        Me.txtradiusprompt = New System.Windows.Forms.TextBox()
        Me.lblradius = New System.Windows.Forms.Label()
        Me.txtheightprompt = New System.Windows.Forms.TextBox()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnlateral = New System.Windows.Forms.Button()
        Me.btnformulas = New System.Windows.Forms.Button()
        Me.btntotalsurfacearea = New System.Windows.Forms.Button()
        Me.btnbasesurfacearea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtradiusprompt
        '
        Me.txtradiusprompt.Location = New System.Drawing.Point(317, 268)
        Me.txtradiusprompt.Name = "txtradiusprompt"
        Me.txtradiusprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtradiusprompt.TabIndex = 27
        '
        'lblradius
        '
        Me.lblradius.AutoSize = True
        Me.lblradius.Location = New System.Drawing.Point(82, 268)
        Me.lblradius.Name = "lblradius"
        Me.lblradius.Size = New System.Drawing.Size(113, 41)
        Me.lblradius.TabIndex = 26
        Me.lblradius.Text = "Radius:"
        '
        'txtheightprompt
        '
        Me.txtheightprompt.Location = New System.Drawing.Point(317, 187)
        Me.txtheightprompt.Name = "txtheightprompt"
        Me.txtheightprompt.Size = New System.Drawing.Size(306, 47)
        Me.txtheightprompt.TabIndex = 21
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(83, 187)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(114, 41)
        Me.lblheight.TabIndex = 20
        Me.lblheight.Text = "Height:"
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitle.Location = New System.Drawing.Point(101, 43)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(513, 67)
        Me.lbltitle.TabIndex = 17
        Me.lbltitle.Text = "Surface Area of a Cone"
        '
        'btnlateral
        '
        Me.btnlateral.Location = New System.Drawing.Point(65, 390)
        Me.btnlateral.Name = "btnlateral"
        Me.btnlateral.Size = New System.Drawing.Size(286, 58)
        Me.btnlateral.TabIndex = 28
        Me.btnlateral.Text = "Lateral Surface Area"
        Me.btnlateral.UseVisualStyleBackColor = True
        '
        'btnformulas
        '
        Me.btnformulas.Location = New System.Drawing.Point(374, 487)
        Me.btnformulas.Name = "btnformulas"
        Me.btnformulas.Size = New System.Drawing.Size(265, 58)
        Me.btnformulas.TabIndex = 30
        Me.btnformulas.Text = "Formulas"
        Me.btnformulas.UseVisualStyleBackColor = True
        '
        'btntotalsurfacearea
        '
        Me.btntotalsurfacearea.Location = New System.Drawing.Point(65, 487)
        Me.btntotalsurfacearea.Name = "btntotalsurfacearea"
        Me.btntotalsurfacearea.Size = New System.Drawing.Size(286, 58)
        Me.btntotalsurfacearea.TabIndex = 29
        Me.btntotalsurfacearea.Text = "Total Surface Area"
        Me.btntotalsurfacearea.UseVisualStyleBackColor = True
        '
        'btnbasesurfacearea
        '
        Me.btnbasesurfacearea.Location = New System.Drawing.Point(374, 390)
        Me.btnbasesurfacearea.Name = "btnbasesurfacearea"
        Me.btnbasesurfacearea.Size = New System.Drawing.Size(265, 58)
        Me.btnbasesurfacearea.TabIndex = 31
        Me.btnbasesurfacearea.Text = "Base Surface Area"
        Me.btnbasesurfacearea.UseVisualStyleBackColor = True
        '
        'Cone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 680)
        Me.Controls.Add(Me.btnbasesurfacearea)
        Me.Controls.Add(Me.btnformulas)
        Me.Controls.Add(Me.btntotalsurfacearea)
        Me.Controls.Add(Me.btnlateral)
        Me.Controls.Add(Me.txtradiusprompt)
        Me.Controls.Add(Me.lblradius)
        Me.Controls.Add(Me.txtheightprompt)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "Cone"
        Me.Text = "Cone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtradiusprompt As TextBox
    Friend WithEvents lblradius As Label
    Friend WithEvents txtheightprompt As TextBox
    Friend WithEvents lblheight As Label
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnlateral As Button
    Friend WithEvents btnformulas As Button
    Friend WithEvents btntotalsurfacearea As Button
    Friend WithEvents btnbasesurfacearea As Button
End Class
