<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemo
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
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHeure = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTitre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtMemo = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.rechInfo = New System.Windows.Forms.RadioButton
        Me.rechTitre = New System.Windows.Forms.RadioButton
        Me.rechDate = New System.Windows.Forms.RadioButton
        Me.rechHeure = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Count = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(91, 29)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 20)
        Me.txtDate.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHeure)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Détails"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date :"
        '
        'txtHeure
        '
        Me.txtHeure.Location = New System.Drawing.Point(360, 29)
        Me.txtHeure.Mask = "00:00"
        Me.txtHeure.Name = "txtHeure"
        Me.txtHeure.Size = New System.Drawing.Size(100, 20)
        Me.txtHeure.TabIndex = 3
        Me.txtHeure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHeure.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Heure :"
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(106, 88)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.ReadOnly = True
        Me.txtTitre.Size = New System.Drawing.Size(258, 20)
        Me.txtTitre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patient :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMemo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 173)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Observation"
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(6, 19)
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(454, 140)
        Me.txtMemo.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 286)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(474, 170)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(493, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 453)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.New_32x32
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(23, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(190, 51)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Nouveau"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Folder
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(7, 399)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 48)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Affcher Tous"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.rechInfo)
        Me.GroupBox5.Controls.Add(Me.rechTitre)
        Me.GroupBox5.Controls.Add(Me.rechDate)
        Me.GroupBox5.Controls.Add(Me.rechHeure)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 243)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(222, 150)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Recherche"
        '
        'Button4
        '
        Me.Button4.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Search
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(35, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 48)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "chercher"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(28, 76)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(158, 20)
        Me.TextBox3.TabIndex = 4
        '
        'rechInfo
        '
        Me.rechInfo.AutoSize = True
        Me.rechInfo.Location = New System.Drawing.Point(112, 53)
        Me.rechInfo.Name = "rechInfo"
        Me.rechInfo.Size = New System.Drawing.Size(103, 17)
        Me.rechInfo.TabIndex = 3
        Me.rechInfo.TabStop = True
        Me.rechInfo.Text = "Par Observation"
        Me.rechInfo.UseVisualStyleBackColor = True
        '
        'rechTitre
        '
        Me.rechTitre.AutoSize = True
        Me.rechTitre.Location = New System.Drawing.Point(10, 53)
        Me.rechTitre.Name = "rechTitre"
        Me.rechTitre.Size = New System.Drawing.Size(78, 17)
        Me.rechTitre.TabIndex = 2
        Me.rechTitre.TabStop = True
        Me.rechTitre.Text = "Par Patient"
        Me.rechTitre.UseVisualStyleBackColor = True
        '
        'rechDate
        '
        Me.rechDate.AutoSize = True
        Me.rechDate.Location = New System.Drawing.Point(10, 17)
        Me.rechDate.Name = "rechDate"
        Me.rechDate.Size = New System.Drawing.Size(67, 17)
        Me.rechDate.TabIndex = 1
        Me.rechDate.TabStop = True
        Me.rechDate.Text = "Par Date"
        Me.rechDate.UseVisualStyleBackColor = True
        '
        'rechHeure
        '
        Me.rechHeure.AutoSize = True
        Me.rechHeure.Location = New System.Drawing.Point(112, 19)
        Me.rechHeure.Name = "rechHeure"
        Me.rechHeure.Size = New System.Drawing.Size(73, 17)
        Me.rechHeure.TabIndex = 0
        Me.rechHeure.TabStop = True
        Me.rechHeure.Text = "Par Heure"
        Me.rechHeure.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Close
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(23, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 54)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Floppy1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(23, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.Edit
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(23, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 54)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(381, 91)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(100, 20)
        Me.Numero.TabIndex = 13
        Me.Numero.Visible = False
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(383, 459)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(0, 16)
        Me.Count.TabIndex = 14
        '
        'frmMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(737, 477)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHeure As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMemo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents rechInfo As System.Windows.Forms.RadioButton
    Friend WithEvents rechTitre As System.Windows.Forms.RadioButton
    Friend WithEvents rechDate As System.Windows.Forms.RadioButton
    Friend WithEvents rechHeure As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Count As System.Windows.Forms.Label
End Class
