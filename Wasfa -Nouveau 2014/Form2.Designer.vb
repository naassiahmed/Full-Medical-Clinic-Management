<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdonnance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdonnance))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNPatient = New System.Windows.Forms.TextBox
        Me.txtHeure = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.comboTranche = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtPrenom = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Q7 = New System.Windows.Forms.TextBox
        Me.P7 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.M7 = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Q6 = New System.Windows.Forms.TextBox
        Me.P6 = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.M6 = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Q5 = New System.Windows.Forms.TextBox
        Me.P5 = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.M5 = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Q4 = New System.Windows.Forms.TextBox
        Me.P4 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.M4 = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Q3 = New System.Windows.Forms.TextBox
        Me.P3 = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.M3 = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Q2 = New System.Windows.Forms.TextBox
        Me.P2 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.M2 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Q1 = New System.Windows.Forms.TextBox
        Me.P1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.M1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.codePatient = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RechCode = New System.Windows.Forms.RadioButton
        Me.RechNumero = New System.Windows.Forms.RadioButton
        Me.RechHeure = New System.Windows.Forms.RadioButton
        Me.rechDate = New System.Windows.Forms.RadioButton
        Me.rechCurrent = New System.Windows.Forms.RadioButton
        Me.rechAll = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Count = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNPatient)
        Me.GroupBox1.Controls.Add(Me.txtHeure)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(215, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "      N°  :"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(291, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(105, 23)
        Me.txtCode.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "N° de Patient"
        '
        'txtNPatient
        '
        Me.txtNPatient.Location = New System.Drawing.Point(480, 13)
        Me.txtNPatient.Name = "txtNPatient"
        Me.txtNPatient.ReadOnly = True
        Me.txtNPatient.Size = New System.Drawing.Size(105, 20)
        Me.txtNPatient.TabIndex = 3
        '
        'txtHeure
        '
        Me.txtHeure.Location = New System.Drawing.Point(143, 12)
        Me.txtHeure.MaxLength = 6
        Me.txtHeure.Name = "txtHeure"
        Me.txtHeure.ReadOnly = True
        Me.txtHeure.Size = New System.Drawing.Size(67, 20)
        Me.txtHeure.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(39, 12)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.comboTranche)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtAge)
        Me.GroupBox2.Controls.Add(Me.txtPrenom)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNom)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 50)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'comboTranche
        '
        Me.comboTranche.FormattingEnabled = True
        Me.comboTranche.Items.AddRange(New Object() {"Jours", "Mois", "Ans"})
        Me.comboTranche.Location = New System.Drawing.Point(516, 17)
        Me.comboTranche.Name = "comboTranche"
        Me.comboTranche.Size = New System.Drawing.Size(65, 21)
        Me.comboTranche.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Prénoms :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Age :"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(445, 18)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(52, 20)
        Me.txtAge.TabIndex = 3
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(224, 18)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.ReadOnly = True
        Me.txtPrenom.Size = New System.Drawing.Size(127, 20)
        Me.txtPrenom.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nom :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(53, 17)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Q7)
        Me.GroupBox3.Controls.Add(Me.P7)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.M7)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Q6)
        Me.GroupBox3.Controls.Add(Me.P6)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.M6)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Q5)
        Me.GroupBox3.Controls.Add(Me.P5)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.M5)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Q4)
        Me.GroupBox3.Controls.Add(Me.P4)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.M4)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Q3)
        Me.GroupBox3.Controls.Add(Me.P3)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.M3)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Q2)
        Me.GroupBox3.Controls.Add(Me.P2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.M2)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Q1)
        Me.GroupBox3.Controls.Add(Me.P1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.M1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Controls.Add(Me.Panel7)
        Me.GroupBox3.Controls.Add(Me.Panel8)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(614, 390)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information de l'ordonnace"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtInfo)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 309)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(593, 76)
        Me.GroupBox7.TabIndex = 50
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Diagnostic"
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(9, 16)
        Me.txtInfo.MaxLength = 255
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(568, 51)
        Me.txtInfo.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(482, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Quantité :"
        '
        'Q7
        '
        Me.Q7.Location = New System.Drawing.Point(544, 276)
        Me.Q7.Name = "Q7"
        Me.Q7.Size = New System.Drawing.Size(40, 20)
        Me.Q7.TabIndex = 41
        Me.Q7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P7
        '
        Me.P7.FormattingEnabled = True
        Me.P7.Location = New System.Drawing.Point(332, 275)
        Me.P7.Name = "P7"
        Me.P7.Size = New System.Drawing.Size(143, 21)
        Me.P7.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(267, 278)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Posologie :"
        '
        'M7
        '
        Me.M7.FormattingEnabled = True
        Me.M7.Location = New System.Drawing.Point(93, 275)
        Me.M7.Name = "M7"
        Me.M7.Size = New System.Drawing.Size(167, 21)
        Me.M7.TabIndex = 38
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 278)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Médicament 7 :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(482, 240)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Quantité :"
        '
        'Q6
        '
        Me.Q6.Location = New System.Drawing.Point(544, 238)
        Me.Q6.Name = "Q6"
        Me.Q6.Size = New System.Drawing.Size(40, 20)
        Me.Q6.TabIndex = 35
        Me.Q6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P6
        '
        Me.P6.FormattingEnabled = True
        Me.P6.Location = New System.Drawing.Point(332, 237)
        Me.P6.Name = "P6"
        Me.P6.Size = New System.Drawing.Size(143, 21)
        Me.P6.TabIndex = 34
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(267, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Posologie :"
        '
        'M6
        '
        Me.M6.FormattingEnabled = True
        Me.M6.Location = New System.Drawing.Point(93, 237)
        Me.M6.Name = "M6"
        Me.M6.Size = New System.Drawing.Size(167, 21)
        Me.M6.TabIndex = 32
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 240)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Médicament 6 :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(482, 199)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 13)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Quantité :"
        '
        'Q5
        '
        Me.Q5.Location = New System.Drawing.Point(544, 197)
        Me.Q5.Name = "Q5"
        Me.Q5.Size = New System.Drawing.Size(40, 20)
        Me.Q5.TabIndex = 29
        Me.Q5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P5
        '
        Me.P5.FormattingEnabled = True
        Me.P5.Location = New System.Drawing.Point(332, 196)
        Me.P5.Name = "P5"
        Me.P5.Size = New System.Drawing.Size(143, 21)
        Me.P5.TabIndex = 28
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(267, 199)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 13)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Posologie :"
        '
        'M5
        '
        Me.M5.FormattingEnabled = True
        Me.M5.Location = New System.Drawing.Point(93, 196)
        Me.M5.Name = "M5"
        Me.M5.Size = New System.Drawing.Size(167, 21)
        Me.M5.TabIndex = 26
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 199)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 13)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Médicament 5 :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(482, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Quantité :"
        '
        'Q4
        '
        Me.Q4.Location = New System.Drawing.Point(544, 156)
        Me.Q4.Name = "Q4"
        Me.Q4.Size = New System.Drawing.Size(40, 20)
        Me.Q4.TabIndex = 23
        Me.Q4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P4
        '
        Me.P4.FormattingEnabled = True
        Me.P4.Location = New System.Drawing.Point(332, 155)
        Me.P4.Name = "P4"
        Me.P4.Size = New System.Drawing.Size(143, 21)
        Me.P4.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(267, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Posologie :"
        '
        'M4
        '
        Me.M4.FormattingEnabled = True
        Me.M4.Location = New System.Drawing.Point(93, 155)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(167, 21)
        Me.M4.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Médicament 4 :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(482, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Quantité :"
        '
        'Q3
        '
        Me.Q3.Location = New System.Drawing.Point(544, 117)
        Me.Q3.Name = "Q3"
        Me.Q3.Size = New System.Drawing.Size(40, 20)
        Me.Q3.TabIndex = 17
        Me.Q3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P3
        '
        Me.P3.FormattingEnabled = True
        Me.P3.Location = New System.Drawing.Point(332, 116)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(143, 21)
        Me.P3.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(267, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Posologie :"
        '
        'M3
        '
        Me.M3.FormattingEnabled = True
        Me.M3.Location = New System.Drawing.Point(93, 116)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(167, 21)
        Me.M3.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Médicament 3 :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(482, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Quantité :"
        '
        'Q2
        '
        Me.Q2.Location = New System.Drawing.Point(544, 75)
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(40, 20)
        Me.Q2.TabIndex = 11
        Me.Q2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P2
        '
        Me.P2.FormattingEnabled = True
        Me.P2.Location = New System.Drawing.Point(332, 74)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(143, 21)
        Me.P2.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(267, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Posologie :"
        '
        'M2
        '
        Me.M2.FormattingEnabled = True
        Me.M2.Location = New System.Drawing.Point(93, 74)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(167, 21)
        Me.M2.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Médicament 2 :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(482, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Quantité :"
        '
        'Q1
        '
        Me.Q1.Location = New System.Drawing.Point(544, 32)
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(40, 20)
        Me.Q1.TabIndex = 5
        Me.Q1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'P1
        '
        Me.P1.FormattingEnabled = True
        Me.P1.Location = New System.Drawing.Point(332, 31)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(143, 21)
        Me.P1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Posologie :"
        '
        'M1
        '
        Me.M1.FormattingEnabled = True
        Me.M1.Location = New System.Drawing.Point(93, 31)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(167, 21)
        Me.M1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Médicament 1 :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(8, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 43)
        Me.Panel1.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(8, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 43)
        Me.Panel2.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(8, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 43)
        Me.Panel3.TabIndex = 45
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(8, 143)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(593, 43)
        Me.Panel4.TabIndex = 46
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(7, 184)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(593, 43)
        Me.Panel6.TabIndex = 47
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(7, 225)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(593, 43)
        Me.Panel7.TabIndex = 48
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Location = New System.Drawing.Point(6, 265)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(593, 43)
        Me.Panel8.TabIndex = 49
        '
        'codePatient
        '
        Me.codePatient.Location = New System.Drawing.Point(268, 564)
        Me.codePatient.Name = "codePatient"
        Me.codePatient.Size = New System.Drawing.Size(100, 20)
        Me.codePatient.TabIndex = 11
        Me.codePatient.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(13, 300)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(593, 43)
        Me.Panel5.TabIndex = 45
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 502)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(688, 166)
        Me.DataGridView1.TabIndex = 46
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox4.Controls.Add(Me.Numero)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.RechCode)
        Me.GroupBox4.Controls.Add(Me.RechNumero)
        Me.GroupBox4.Controls.Add(Me.RechHeure)
        Me.GroupBox4.Controls.Add(Me.rechDate)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(329, 202)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Critère de Recherche"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(6, 156)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(76, 20)
        Me.Numero.TabIndex = 48
        Me.Numero.Visible = False
        '
        'Button6
        '
        Me.Button6.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Search_48x48
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(92, 124)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 66)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Chercher        "
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 76)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(292, 40)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Valeur de Recherche"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 7
        '
        'RechCode
        '
        Me.RechCode.AutoSize = True
        Me.RechCode.Location = New System.Drawing.Point(188, 50)
        Me.RechCode.Name = "RechCode"
        Me.RechCode.Size = New System.Drawing.Size(69, 17)
        Me.RechCode.TabIndex = 52
        Me.RechCode.Text = "Par Code"
        Me.RechCode.UseVisualStyleBackColor = True
        '
        'RechNumero
        '
        Me.RechNumero.AutoSize = True
        Me.RechNumero.Location = New System.Drawing.Point(45, 50)
        Me.RechNumero.Name = "RechNumero"
        Me.RechNumero.Size = New System.Drawing.Size(81, 17)
        Me.RechNumero.TabIndex = 51
        Me.RechNumero.Text = "Par Numéro"
        Me.RechNumero.UseVisualStyleBackColor = True
        '
        'RechHeure
        '
        Me.RechHeure.AutoSize = True
        Me.RechHeure.Location = New System.Drawing.Point(188, 19)
        Me.RechHeure.Name = "RechHeure"
        Me.RechHeure.Size = New System.Drawing.Size(73, 17)
        Me.RechHeure.TabIndex = 50
        Me.RechHeure.Text = "Par Heure"
        Me.RechHeure.UseVisualStyleBackColor = True
        '
        'rechDate
        '
        Me.rechDate.AutoSize = True
        Me.rechDate.Checked = True
        Me.rechDate.Location = New System.Drawing.Point(45, 19)
        Me.rechDate.Name = "rechDate"
        Me.rechDate.Size = New System.Drawing.Size(67, 17)
        Me.rechDate.TabIndex = 49
        Me.rechDate.TabStop = True
        Me.rechDate.Text = "Par Date"
        Me.rechDate.UseVisualStyleBackColor = True
        '
        'rechCurrent
        '
        Me.rechCurrent.AutoSize = True
        Me.rechCurrent.Checked = True
        Me.rechCurrent.Location = New System.Drawing.Point(44, 203)
        Me.rechCurrent.Name = "rechCurrent"
        Me.rechCurrent.Size = New System.Drawing.Size(100, 17)
        Me.rechCurrent.TabIndex = 0
        Me.rechCurrent.TabStop = True
        Me.rechCurrent.Text = "Pour Ce Patient"
        Me.rechCurrent.UseVisualStyleBackColor = True
        '
        'rechAll
        '
        Me.rechAll.AutoSize = True
        Me.rechAll.Location = New System.Drawing.Point(182, 203)
        Me.rechAll.Name = "rechAll"
        Me.rechAll.Size = New System.Drawing.Size(129, 17)
        Me.rechAll.TabIndex = 1
        Me.rechAll.Text = "Pour tous les Patients"
        Me.rechAll.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button8)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.rechCurrent)
        Me.GroupBox6.Controls.Add(Me.rechAll)
        Me.GroupBox6.Location = New System.Drawing.Point(612, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(358, 496)
        Me.GroupBox6.TabIndex = 51
        Me.GroupBox6.TabStop = False
        '
        'Button8
        '
        Me.Button8.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Folder
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(44, 431)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(272, 59)
        Me.Button8.TabIndex = 49
        Me.Button8.Text = "Affcher Toutes les ordonnances"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(16, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 85)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Nouvelle Ordonnance"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(182, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 85)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Supprimer l'ordonnace"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(16, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 85)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Modifier cette ordonnace"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(182, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 85)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Ajouter l'ordonnance"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Log_Out_48x48
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(712, 579)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(256, 64)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "Fermer"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Print_48x48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(713, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 68)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Imprimer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(730, 648)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(0, 16)
        Me.Count.TabIndex = 53
        '
        'frmOrdonnance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(980, 671)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.codePatient)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOrdonnance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouvelle Ordonnance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNPatient As System.Windows.Forms.TextBox
    Friend WithEvents txtHeure As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Q1 As System.Windows.Forms.TextBox
    Friend WithEvents P1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents M1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Q7 As System.Windows.Forms.TextBox
    Friend WithEvents P7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents M7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Q6 As System.Windows.Forms.TextBox
    Friend WithEvents P6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents M6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Q5 As System.Windows.Forms.TextBox
    Friend WithEvents P5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents M5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Q4 As System.Windows.Forms.TextBox
    Friend WithEvents P4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents M4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Q3 As System.Windows.Forms.TextBox
    Friend WithEvents P3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents M3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Q2 As System.Windows.Forms.TextBox
    Friend WithEvents P2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents M2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents comboTranche As System.Windows.Forms.ComboBox
    Friend WithEvents codePatient As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rechAll As System.Windows.Forms.RadioButton
    Friend WithEvents rechCurrent As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RechCode As System.Windows.Forms.RadioButton
    Friend WithEvents RechNumero As System.Windows.Forms.RadioButton
    Friend WithEvents RechHeure As System.Windows.Forms.RadioButton
    Friend WithEvents rechDate As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
