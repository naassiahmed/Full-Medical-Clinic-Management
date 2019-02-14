<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatient
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNOrdonnnace = New System.Windows.Forms.TextBox
        Me.txtTranche = New System.Windows.Forms.ComboBox
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Sexe2 = New System.Windows.Forms.RadioButton
        Me.Sexe1 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAdresse = New System.Windows.Forms.TextBox
        Me.txtDateNaissance = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtPrenom = New System.Windows.Forms.TextBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.rechInfo = New System.Windows.Forms.RadioButton
        Me.rechPhone = New System.Windows.Forms.RadioButton
        Me.rechAdresse = New System.Windows.Forms.RadioButton
        Me.rechNomPrenom = New System.Windows.Forms.RadioButton
        Me.rechPrenom = New System.Windows.Forms.RadioButton
        Me.rechNom = New System.Windows.Forms.RadioButton
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Count = New System.Windows.Forms.Label
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtNOrdonnnace)
        Me.GroupBox1.Controls.Add(Me.txtTranche)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtInfo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Sexe2)
        Me.GroupBox1.Controls.Add(Me.Sexe1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.txtDateNaissance)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtPrenom)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 429)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations de Patient"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(328, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Nombre d'Ordonnances :"
        '
        'txtNOrdonnnace
        '
        Me.txtNOrdonnnace.BackColor = System.Drawing.Color.Goldenrod
        Me.txtNOrdonnnace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOrdonnnace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNOrdonnnace.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOrdonnnace.Location = New System.Drawing.Point(459, 22)
        Me.txtNOrdonnnace.Name = "txtNOrdonnnace"
        Me.txtNOrdonnnace.ReadOnly = True
        Me.txtNOrdonnnace.Size = New System.Drawing.Size(39, 26)
        Me.txtNOrdonnnace.TabIndex = 29
        Me.txtNOrdonnnace.Text = "0"
        Me.txtNOrdonnnace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTranche
        '
        Me.txtTranche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTranche.FormattingEnabled = True
        Me.txtTranche.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.txtTranche.Items.AddRange(New Object() {"Jours", "Mois", "Ans"})
        Me.txtTranche.Location = New System.Drawing.Point(336, 152)
        Me.txtTranche.Name = "txtTranche"
        Me.txtTranche.Size = New System.Drawing.Size(127, 21)
        Me.txtTranche.TabIndex = 4
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(104, 22)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(218, 20)
        Me.txtDate.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Date d'inscription :"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(104, 298)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(258, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(106, 261)
        Me.txtPhone.Mask = "0000000000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(225, 20)
        Me.txtPhone.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Email :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Téléphone :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Informations " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "supplémentaires :"
        '
        'txtInfo
        '
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.Location = New System.Drawing.Point(104, 335)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(386, 58)
        Me.txtInfo.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Sexe :"
        '
        'Sexe2
        '
        Me.Sexe2.AutoSize = True
        Me.Sexe2.Location = New System.Drawing.Point(311, 234)
        Me.Sexe2.Name = "Sexe2"
        Me.Sexe2.Size = New System.Drawing.Size(61, 17)
        Me.Sexe2.TabIndex = 7
        Me.Sexe2.Text = "Féminin"
        Me.Sexe2.UseVisualStyleBackColor = True
        '
        'Sexe1
        '
        Me.Sexe1.AutoSize = True
        Me.Sexe1.Checked = True
        Me.Sexe1.Location = New System.Drawing.Point(144, 234)
        Me.Sexe1.Name = "Sexe1"
        Me.Sexe1.Size = New System.Drawing.Size(65, 17)
        Me.Sexe1.TabIndex = 6
        Me.Sexe1.TabStop = True
        Me.Sexe1.Text = "Masculin"
        Me.Sexe1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Adresse :"
        '
        'txtAdresse
        '
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdresse.Location = New System.Drawing.Point(104, 181)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(386, 40)
        Me.txtAdresse.TabIndex = 5
        '
        'txtDateNaissance
        '
        Me.txtDateNaissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateNaissance.Location = New System.Drawing.Point(104, 124)
        Me.txtDateNaissance.Mask = "00/00/0000"
        Me.txtDateNaissance.Name = "txtDateNaissance"
        Me.txtDateNaissance.Size = New System.Drawing.Size(239, 20)
        Me.txtDateNaissance.TabIndex = 2
        Me.txtDateNaissance.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date de Naissance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Age  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prénoms  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nom  :"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Location = New System.Drawing.Point(104, 153)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(161, 20)
        Me.txtAge.TabIndex = 3
        '
        'txtPrenom
        '
        Me.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenom.Location = New System.Drawing.Point(106, 92)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(256, 20)
        Me.txtPrenom.TabIndex = 1
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Location = New System.Drawing.Point(107, 56)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(239, 20)
        Me.txtNom.TabIndex = 0
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 439)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(749, 223)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.Button19)
        Me.GroupBox2.Controls.Add(Me.Button18)
        Me.GroupBox2.Controls.Add(Me.Button17)
        Me.GroupBox2.Controls.Add(Me.Button16)
        Me.GroupBox2.Controls.Add(Me.Button15)
        Me.GroupBox2.Controls.Add(Me.Button14)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(536, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 429)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(420, 389)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(34, 23)
        Me.Button19.TabIndex = 21
        Me.Button19.Text = "..."
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(420, 335)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(34, 23)
        Me.Button18.TabIndex = 20
        Me.Button18.Text = "..."
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(420, 295)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(34, 23)
        Me.Button17.TabIndex = 19
        Me.Button17.Text = "..."
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(197, 389)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(34, 23)
        Me.Button16.TabIndex = 18
        Me.Button16.Text = "..."
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(197, 340)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(34, 23)
        Me.Button15.TabIndex = 17
        Me.Button15.Text = "..."
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(197, 295)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(34, 23)
        Me.Button14.TabIndex = 16
        Me.Button14.Text = "..."
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.LightBlue
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Edit
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(237, 330)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(180, 43)
        Me.Button13.TabIndex = 15
        Me.Button13.Text = "Prescription d'une prothèse"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.LightBlue
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Edit
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(237, 379)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(180, 43)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "Otoendoscopie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightBlue
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Edit
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(16, 379)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(180, 43)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Examen Nasofibroscopique"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightBlue
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Write
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(16, 330)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(180, 43)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Ajouter  un Certificat Médical"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Clock
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(16, 288)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(180, 36)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Fixer un Rendez-vous    "
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.rechInfo)
        Me.GroupBox3.Controls.Add(Me.rechPhone)
        Me.GroupBox3.Controls.Add(Me.rechAdresse)
        Me.GroupBox3.Controls.Add(Me.rechNomPrenom)
        Me.GroupBox3.Controls.Add(Me.rechPrenom)
        Me.GroupBox3.Controls.Add(Me.rechNom)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(51, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 146)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Critère de Recherche"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(346, 44)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valeur de Recherche"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 20)
        Me.TextBox1.TabIndex = 0
        '
        'rechInfo
        '
        Me.rechInfo.AutoSize = True
        Me.rechInfo.Location = New System.Drawing.Point(249, 39)
        Me.rechInfo.Name = "rechInfo"
        Me.rechInfo.Size = New System.Drawing.Size(92, 17)
        Me.rechInfo.TabIndex = 11
        Me.rechInfo.Text = "Par Info.Supp"
        Me.rechInfo.UseVisualStyleBackColor = True
        '
        'rechPhone
        '
        Me.rechPhone.AutoSize = True
        Me.rechPhone.Location = New System.Drawing.Point(127, 39)
        Me.rechPhone.Name = "rechPhone"
        Me.rechPhone.Size = New System.Drawing.Size(94, 17)
        Me.rechPhone.TabIndex = 10
        Me.rechPhone.Text = "Par Téléphone"
        Me.rechPhone.UseVisualStyleBackColor = True
        '
        'rechAdresse
        '
        Me.rechAdresse.AutoSize = True
        Me.rechAdresse.Location = New System.Drawing.Point(6, 39)
        Me.rechAdresse.Name = "rechAdresse"
        Me.rechAdresse.Size = New System.Drawing.Size(83, 17)
        Me.rechAdresse.TabIndex = 9
        Me.rechAdresse.Text = "Par Adresse"
        Me.rechAdresse.UseVisualStyleBackColor = True
        '
        'rechNomPrenom
        '
        Me.rechNomPrenom.AutoSize = True
        Me.rechNomPrenom.Location = New System.Drawing.Point(249, 19)
        Me.rechNomPrenom.Name = "rechNomPrenom"
        Me.rechNomPrenom.Size = New System.Drawing.Size(117, 17)
        Me.rechNomPrenom.TabIndex = 8
        Me.rechNomPrenom.Text = "Par Nom et Prénom"
        Me.rechNomPrenom.UseVisualStyleBackColor = True
        '
        'rechPrenom
        '
        Me.rechPrenom.AutoSize = True
        Me.rechPrenom.Location = New System.Drawing.Point(127, 19)
        Me.rechPrenom.Name = "rechPrenom"
        Me.rechPrenom.Size = New System.Drawing.Size(80, 17)
        Me.rechPrenom.TabIndex = 7
        Me.rechPrenom.Text = "Par Prénom"
        Me.rechPrenom.UseVisualStyleBackColor = True
        '
        'rechNom
        '
        Me.rechNom.AutoSize = True
        Me.rechNom.Checked = True
        Me.rechNom.Location = New System.Drawing.Point(6, 19)
        Me.rechNom.Name = "rechNom"
        Me.rechNom.Size = New System.Drawing.Size(65, 17)
        Me.rechNom.TabIndex = 6
        Me.rechNom.TabStop = True
        Me.rechNom.Text = "Par Nom"
        Me.rechNom.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Search
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(91, 103)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 37)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Chercher ..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightBlue
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Write
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(237, 288)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(180, 36)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Ajouter une ordonnance    "
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Close
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(20, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(240, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(214, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Floppy1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(240, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 49)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "&Ajouter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.New_32x32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(20, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(414, 446)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(71, 20)
        Me.Numero.TabIndex = 3
        Me.Numero.Visible = False
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(761, 668)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(0, 16)
        Me.Count.TabIndex = 22
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(963, 543)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(34, 23)
        Me.Button20.TabIndex = 22
        Me.Button20.Text = "..."
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Paste
        Me.Button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button21.Location = New System.Drawing.Point(773, 446)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(186, 68)
        Me.Button21.TabIndex = 23
        Me.Button21.Text = "Ajouter une Consultation"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Edit
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(774, 520)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(186, 68)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "            Ajouter Un Compte-Rendu"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Log_Out_48x48
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(773, 594)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(186, 68)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Sortir                   "
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'frmPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(998, 695)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau Patient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateNaissance As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Sexe2 As System.Windows.Forms.RadioButton
    Friend WithEvents Sexe1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTranche As System.Windows.Forms.ComboBox
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rechNomPrenom As System.Windows.Forms.RadioButton
    Friend WithEvents rechPrenom As System.Windows.Forms.RadioButton
    Friend WithEvents rechNom As System.Windows.Forms.RadioButton
    Friend WithEvents rechInfo As System.Windows.Forms.RadioButton
    Friend WithEvents rechPhone As System.Windows.Forms.RadioButton
    Friend WithEvents rechAdresse As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtNOrdonnnace As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button

End Class
