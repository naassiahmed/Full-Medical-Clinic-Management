<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompteRendu
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompteRendu))
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.txtTypeAr = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtTypeFr = New System.Windows.Forms.TextBox
        Me.txtSpec1Fr = New System.Windows.Forms.TextBox
        Me.txtSpec2Fr = New System.Windows.Forms.TextBox
        Me.txtSpec2Ar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSpec1Ar = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtPrenom = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.txt5 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 332)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(523, 327)
        Me.TextBox3.TabIndex = 2
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Peru
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(406, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 31)
        Me.Button2.TabIndex = 214
        Me.Button2.Text = "Imprimer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(566, 157)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 0
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(561, 154)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox9.Size = New System.Drawing.Size(172, 20)
        Me.TextBox9.TabIndex = 215
        Me.TextBox9.Text = "a"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(12, 117)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(268, 22)
        Me.TextBox6.TabIndex = 228
        Me.TextBox6.Text = "Impédancémétrie-Tests d'allergie"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(32, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(228, 22)
        Me.TextBox1.TabIndex = 227
        Me.TextBox1.Text = "Chirurgie Endoscopique -"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(52, 163)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(176, 22)
        Me.TextBox2.TabIndex = 226
        Me.TextBox2.Text = "Radiofréquence"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(359, 101)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox7.Size = New System.Drawing.Size(172, 20)
        Me.TextBox7.TabIndex = 225
        Me.TextBox7.Text = "التشخيص والجراحة بالمنظار"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTypeAr
        '
        Me.txtTypeAr.BackColor = System.Drawing.Color.White
        Me.txtTypeAr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTypeAr.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtTypeAr.Location = New System.Drawing.Point(339, 34)
        Me.txtTypeAr.Name = "txtTypeAr"
        Me.txtTypeAr.ReadOnly = True
        Me.txtTypeAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTypeAr.Size = New System.Drawing.Size(206, 20)
        Me.txtTypeAr.TabIndex = 220
        Me.txtTypeAr.Text = "أخصائي في أمراض وجراحة الأنف"
        Me.txtTypeAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(10, 94)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(255, 22)
        Me.txtPhone.TabIndex = 224
        Me.txtPhone.Text = "Oreilles Endoscopie-Audiométrie-"
        '
        'txtTypeFr
        '
        Me.txtTypeFr.BackColor = System.Drawing.Color.White
        Me.txtTypeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTypeFr.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeFr.Location = New System.Drawing.Point(14, 29)
        Me.txtTypeFr.Name = "txtTypeFr"
        Me.txtTypeFr.ReadOnly = True
        Me.txtTypeFr.Size = New System.Drawing.Size(225, 28)
        Me.txtTypeFr.TabIndex = 223
        Me.txtTypeFr.Text = "Spécialiste en O.R.L,"
        '
        'txtSpec1Fr
        '
        Me.txtSpec1Fr.BackColor = System.Drawing.Color.White
        Me.txtSpec1Fr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpec1Fr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpec1Fr.Location = New System.Drawing.Point(23, 53)
        Me.txtSpec1Fr.Name = "txtSpec1Fr"
        Me.txtSpec1Fr.ReadOnly = True
        Me.txtSpec1Fr.Size = New System.Drawing.Size(237, 22)
        Me.txtSpec1Fr.TabIndex = 222
        Me.txtSpec1Fr.Text = "et Chirurgie Cervico-Faciale."
        '
        'txtSpec2Fr
        '
        Me.txtSpec2Fr.BackColor = System.Drawing.Color.White
        Me.txtSpec2Fr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpec2Fr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpec2Fr.Location = New System.Drawing.Point(10, 73)
        Me.txtSpec2Fr.Name = "txtSpec2Fr"
        Me.txtSpec2Fr.ReadOnly = True
        Me.txtSpec2Fr.Size = New System.Drawing.Size(258, 22)
        Me.txtSpec2Fr.TabIndex = 221
        Me.txtSpec2Fr.Text = "Maladies et chirurgie Nez-Gorge-"
        '
        'txtSpec2Ar
        '
        Me.txtSpec2Ar.BackColor = System.Drawing.Color.White
        Me.txtSpec2Ar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpec2Ar.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSpec2Ar.Location = New System.Drawing.Point(353, 82)
        Me.txtSpec2Ar.Name = "txtSpec2Ar"
        Me.txtSpec2Ar.ReadOnly = True
        Me.txtSpec2Ar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSpec2Ar.Size = New System.Drawing.Size(192, 20)
        Me.txtSpec2Ar.TabIndex = 218
        Me.txtSpec2Ar.Text = "الحساسية التنفسية-قياس السمع"
        Me.txtSpec2Ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 23)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Dr.YOUSFI. MOHAMED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 35)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "الدكتور: يوسفي محمد"
        '
        'txtSpec1Ar
        '
        Me.txtSpec1Ar.BackColor = System.Drawing.Color.White
        Me.txtSpec1Ar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpec1Ar.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtSpec1Ar.Location = New System.Drawing.Point(356, 59)
        Me.txtSpec1Ar.Name = "txtSpec1Ar"
        Me.txtSpec1Ar.ReadOnly = True
        Me.txtSpec1Ar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSpec1Ar.Size = New System.Drawing.Size(177, 20)
        Me.txtSpec1Ar.TabIndex = 219
        Me.txtSpec1Ar.Text = "الأذن-الحنجرة-الرقبة والرأس"
        Me.txtSpec1Ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Age :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 25)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "Prénoms :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "Nom :"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNom.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(85, 234)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(414, 23)
        Me.txtNom.TabIndex = 233
        Me.txtNom.Text = "fdfdf"
        '
        'txtPrenom
        '
        Me.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrenom.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(118, 270)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(414, 23)
        Me.txtPrenom.TabIndex = 234
        Me.txtPrenom.Text = "fdfdf"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(78, 303)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(414, 23)
        Me.txtAge.TabIndex = 235
        Me.txtAge.Text = "fdfdf"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(19, 680)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox11.Size = New System.Drawing.Size(512, 19)
        Me.TextBox11.TabIndex = 237
        Me.TextBox11.Text = "شارع سيدي نايل (بجوار محلات كوندور) - النقال : 16 16 00 0783 -  النقال : 73 58 33" & _
            " 0553"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 35.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 621)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(535, 57)
        Me.LinkLabel1.TabIndex = 236
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "                                  "
        '
        'txt5
        '
        Me.txt5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.Location = New System.Drawing.Point(19, 193)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(523, 28)
        Me.txt5.TabIndex = 238
        Me.txt5.Text = "COMPTE-RENDU"
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.LOGO1
        Me.PictureBox1.Location = New System.Drawing.Point(236, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 239
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(406, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 31)
        Me.Button1.TabIndex = 240
        Me.Button1.Text = "Sauvegarder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmCompteRendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 724)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txtTypeAr)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtTypeFr)
        Me.Controls.Add(Me.txtSpec1Fr)
        Me.Controls.Add(Me.txtSpec2Fr)
        Me.Controls.Add(Me.txtSpec2Ar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSpec1Ar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCompteRendu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compte Rendu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeAr As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeFr As System.Windows.Forms.TextBox
    Friend WithEvents txtSpec1Fr As System.Windows.Forms.TextBox
    Friend WithEvents txtSpec2Fr As System.Windows.Forms.TextBox
    Friend WithEvents txtSpec2Ar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSpec1Ar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
