<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChrono
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.A2 = New System.Windows.Forms.MaskedTextBox
        Me.A1 = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.A4 = New System.Windows.Forms.MaskedTextBox
        Me.A3 = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.A2)
        Me.GroupBox1.Controls.Add(Me.A1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Le Matin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ">>>"
        '
        'A2
        '
        Me.A2.Location = New System.Drawing.Point(166, 19)
        Me.A2.Mask = "00:00"
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(49, 20)
        Me.A2.TabIndex = 3
        Me.A2.Text = "1200"
        Me.A2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.A2.ValidatingType = GetType(Date)
        '
        'A1
        '
        Me.A1.Location = New System.Drawing.Point(30, 19)
        Me.A1.Mask = "00:00"
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(49, 20)
        Me.A1.TabIndex = 2
        Me.A1.Text = "0800"
        Me.A1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.A1.ValidatingType = GetType(Date)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.A4)
        Me.GroupBox2.Controls.Add(Me.A3)
        Me.GroupBox2.Location = New System.Drawing.Point(255, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 46)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Le Soir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ">>>"
        '
        'A4
        '
        Me.A4.Location = New System.Drawing.Point(160, 19)
        Me.A4.Mask = "00:00"
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(49, 20)
        Me.A4.TabIndex = 6
        Me.A4.Text = "1700"
        Me.A4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.A4.ValidatingType = GetType(Date)
        '
        'A3
        '
        Me.A3.Location = New System.Drawing.Point(24, 19)
        Me.A3.Mask = "00:00"
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(49, 20)
        Me.A3.TabIndex = 4
        Me.A3.Text = "1400"
        Me.A3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.A3.ValidatingType = GetType(Date)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 157)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message Affiché"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.MaxLength = 75
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(468, 132)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "C'est l'heure !"
        '
        'Button2
        '
        Me.Button2.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Log_Out_48x48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(279, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 67)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "      Fermer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Floppy
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(67, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 67)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "          Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmChrono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(502, 321)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmChrono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents A2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents A1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents A4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents A3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
