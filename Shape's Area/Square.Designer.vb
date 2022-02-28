<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Square
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
        Me.btnformula = New System.Windows.Forms.Button()
        Me.txtsideprompt = New System.Windows.Forms.TextBox()
        Me.btnsquarearea = New System.Windows.Forms.Button()
        Me.lblside = New System.Windows.Forms.Label()
        Me.lbltitlesquare = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnformula
        '
        Me.btnformula.Location = New System.Drawing.Point(261, 404)
        Me.btnformula.Name = "btnformula"
        Me.btnformula.Size = New System.Drawing.Size(188, 58)
        Me.btnformula.TabIndex = 18
        Me.btnformula.Text = "Formula"
        Me.btnformula.UseVisualStyleBackColor = True
        '
        'txtsideprompt
        '
        Me.txtsideprompt.Location = New System.Drawing.Point(362, 198)
        Me.txtsideprompt.Name = "txtsideprompt"
        Me.txtsideprompt.Size = New System.Drawing.Size(250, 47)
        Me.txtsideprompt.TabIndex = 15
        '
        'btnsquarearea
        '
        Me.btnsquarearea.Location = New System.Drawing.Point(204, 320)
        Me.btnsquarearea.Name = "btnsquarearea"
        Me.btnsquarearea.Size = New System.Drawing.Size(303, 58)
        Me.btnsquarearea.TabIndex = 14
        Me.btnsquarearea.Text = "Area of a Square"
        Me.btnsquarearea.UseVisualStyleBackColor = True
        '
        'lblside
        '
        Me.lblside.AutoSize = True
        Me.lblside.Location = New System.Drawing.Point(116, 198)
        Me.lblside.Name = "lblside"
        Me.lblside.Size = New System.Drawing.Size(82, 41)
        Me.lblside.TabIndex = 11
        Me.lblside.Text = "Side:"
        '
        'lbltitlesquare
        '
        Me.lbltitlesquare.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltitlesquare.Location = New System.Drawing.Point(147, 73)
        Me.lbltitlesquare.Name = "lbltitlesquare"
        Me.lbltitlesquare.Size = New System.Drawing.Size(537, 77)
        Me.lbltitlesquare.TabIndex = 10
        Me.lbltitlesquare.Text = "Area of a Square"
        '
        'Square
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 754)
        Me.Controls.Add(Me.btnformula)
        Me.Controls.Add(Me.txtsideprompt)
        Me.Controls.Add(Me.btnsquarearea)
        Me.Controls.Add(Me.lblside)
        Me.Controls.Add(Me.lbltitlesquare)
        Me.Name = "Square"
        Me.Text = "Square"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnformula As Button
    Friend WithEvents txtsideprompt As TextBox
    Friend WithEvents btnsquarearea As Button
    Friend WithEvents lblside As Label
    Friend WithEvents lbltitlesquare As Label
End Class
