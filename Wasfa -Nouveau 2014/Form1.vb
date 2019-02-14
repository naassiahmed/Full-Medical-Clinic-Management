Imports System.Data
Imports System.Data.OleDb

Public Class frmPatient
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String = "select * from Patient"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter()
    Private Sub MaskedTextBox3_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click



        Me.Close()



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        If TextBox1.Text = "" Then
            MsgBox("Tapez une valeur !", MsgBoxStyle.Exclamation, "")
            TextBox1.Focus()

            Exit Sub
        End If
        dt.Clear()
        If rechNom.Checked = False And rechPrenom.Checked = False And rechPhone.Checked = False And rechPhone.Checked = False And rechAdresse.Checked = False And rechInfo.Checked = False And rechNomPrenom.Checked = False Then
            MsgBox("If faut choisir le critère de recherche !", MsgBoxStyle.Exclamation, "")
            Conn.Close()
            Exit Sub
        End If

        If rechNom.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Patient where Nom like '%" & TextBox1.Text & "%'", Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
        End If


        If rechPrenom.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Patient where Prenom like '%" & TextBox1.Text & "%'", Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
        End If


        If rechPhone.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Patient where Phone like '%" & TextBox1.Text & "%'", Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
        End If


        If rechAdresse.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Patient where Adresse like '%" & TextBox1.Text & "%'", Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
        End If


        If rechInfo.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Patient where Infos like '%" & TextBox1.Text & "%'", Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
        End If


        If rechNomPrenom.Checked = True Then
            Dim a, b
            a = InputBox("Donnez le Nom de patient :")
            b = InputBox("Donnez le Prénom de patient :")
            DataAdapter1 = New OleDbDataAdapter("select * from Patient where Nom like '%" & a & "%' and Prenom like '%" & b & "%'", Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
        End If













        Count.Text = "Vous avez  :  " & BindingContext(dt1).Count

        If Me.BindingContext(dt).Count = 0 Then
            MsgBox("Aucun Patient trouvé ", MsgBoxStyle.Critical, "")
        Else
            LoadTextBox()
        End If



    End Sub
    Sub LoadTextBox()
        Dim aa
        aa = 0
        Numero.Text = DataGridView1.Item(3, aa).Value
        txtNom.Text = DataGridView1.Item(4, aa).Value
        txtPrenom.Text = DataGridView1.Item(5, aa).Value
        txtDateNaissance.Text = DataGridView1.Item(6, aa).Value
        txtAge.Text = DataGridView1.Item(7, aa).Value
        txtAdresse.Text = DataGridView1.Item(8, aa).Value
        If DataGridView1.Item(9, aa).Value = "Masculin" Then
            Sexe1.Checked = True
        Else
            Sexe2.Checked = True
        End If
        txtPhone.Text = DataGridView1.Item(10, aa).Value
        txtEmail.Text = DataGridView1.Item(11, aa).Value
        txtInfo.Text = DataGridView1.Item(12, aa).Value
        txtDate.Text = DataGridView1.Item(13, aa).Value
        txtTranche.Text = DataGridView1.Item(14, aa).Value
        Button4.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each k As Control In GroupBox1.Controls
            If TypeOf k Is TextBox Or TypeOf k Is MaskedTextBox Then
                k.Text = ""
            End If
        Next
        Button4.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = True
        Button8.Enabled = False
        txtTranche.Text = "Ans"
        RefreshDataGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTranche.Text = "Ans"
        ConnectBaseDeDonnées()
        RefreshDataGrid()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If A = 0 Then
            Dim cc
            cc = MsgBox("Vous utilisez une version d'évaluation !" & vbCrLf & "Cette opération ne peut pas être effectuée" & vbCrLf & "dans la version d'évaluation" & vbCrLf & "pour bénéficier de toutes les fonctionnalités de ce logiciel" & vbCrLf & "veuillez demander votre clé d'activation" & vbCrLf & "" & vbCrLf & "voulez-vous activer le programme maintenant ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "")
            If cc = vbYes Then
                frmActivation.Show()
                Me.Close()
            End If
        Else

            Try


                Dim Sexe As String
                If Sexe1.Checked = True Then
                    Sexe = "Masculin"
                Else
                    Sexe = "Féminin"
                End If



                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "update patient set Nom='" & Trim(txtNom.Text) & "',Prenom='" & Trim(txtPrenom.Text) & "',Age=" & Val(txtAge.Text) & ",DateNaissance='" & txtDateNaissance.Text & "',tranche='" & Trim(txtTranche.Text) & "',DateInscription='" & txtDate.Value.Date & "',Telephone='" & txtPhone.Text & "',Email ='" & Trim(txtEmail.Text) & "',Adresse='" & Trim(txtAdresse.Text) & "',Infos='" & Trim(txtInfo.Text) & "',Sexe='" & Sexe & "' where Numero=" & Val(Numero.Text) & ""

                Conn.Open()
                SavInto.ExecuteNonQuery()
                Conn.Close()
                Call RefreshDataGrid()
                MsgBox("Modification Réussie !", MsgBoxStyle.Information)

            Catch ex As Exception

                MsgBox("Une erreur !", MsgBoxStyle.Critical)

            End Try

        End If
    End Sub
    Sub ConnectBaseDeDonnées()
        Conn.Open()
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(DataSet1, "Patient")
        Conn.Close()

    End Sub
    Sub RefreshDataGrid()

        Conn.Open()
        dt.Clear()
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Conn.Close()
        DataGridView1.Columns.Item(0).Visible = False
        DataGridView1.Columns.Item(1).Visible = False
        DataGridView1.Columns.Item(2).Visible = False
        Count.Text = "Vous avez : " & BindingContext(dt).Count
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try



            If txtNom.Text = "" Or txtPrenom.Text = "" Then
                MsgBox("Erreur ! veuillez remplir toutes les informations", MsgBoxStyle.Critical, "Erreur")
                Exit Sub
            End If
            If (Not IsDate(txtDateNaissance.Text)) And txtAge.Text = "" Then
                MsgBox("Vous devez au moins donner L'age ou la date de Naissance", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            'Dim Tranche As String
            'Tranche = txtTranche.Text
            'Dim Diff As Integer
            'If txtTranche.Text = "" Then
            ' If txtAge.Text = "" Then
            'Diff = DateDiff(DateInterval.Day, Date.Now.Date, txtDateNaissance)
            'Select Case Diff
            '    Case Is < 31
            'Tranche = "Jours"
            '    Case Is > 31, Is < 372
            'Tranche = "Mois"
            '    Case Else
            'Tranche = "Ans"
            'End Select
            'End If
            'End If

            Dim Sexe As String
            If Sexe1.Checked = True Then
                Sexe = "Masculin"
            Else
                Sexe = "Féminin"
            End If
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "insert into Patient(Nom,Prenom,DateNaissance,Age,Adresse,Sexe,Telephone,Email,Infos,DateInscription,Tranche)" & _
            " values('" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtDateNaissance.Text & "','" & Val(txtAge.Text) & "','" & txtAdresse.Text & "','" & Sexe & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtInfo.Text & "','" & txtDate.Value.Date & _
             "','" & txtTranche.Text & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            Call RefreshDataGrid()
            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)
            Button1_Click(sender, e)
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            Dim aa
            aa = (DataGridView1.CurrentCell.RowIndex)
            Numero.Text = DataGridView1.Item(3, aa).Value
            txtNom.Text = DataGridView1.Item(4, aa).Value
            txtPrenom.Text = DataGridView1.Item(5, aa).Value
            txtDateNaissance.Text = DataGridView1.Item(6, aa).Value
            txtAge.Text = DataGridView1.Item(7, aa).Value
            txtAdresse.Text = DataGridView1.Item(8, aa).Value
            If DataGridView1.Item(9, aa).Value = "Masculin" Then
                Sexe1.Checked = True
            Else
                Sexe2.Checked = True
            End If
            txtPhone.Text = DataGridView1.Item(10, aa).Value
            txtEmail.Text = DataGridView1.Item(11, aa).Value
            txtInfo.Text = DataGridView1.Item(12, aa).Value
            txtDate.Text = DataGridView1.Item(13, aa).Value
            txtTranche.Text = DataGridView1.Item(14, aa).Value
            Button4.Enabled = True
            Button3.Enabled = True
            Button8.Enabled = True
            Button2.Enabled = False
            dt1.Clear()
            DataAdapter2 = New OleDbDataAdapter("select * from Ordonnance where CodePatient =" & Val(Numero.Text) & "", Conn)
            DataAdapter2.Fill(dt1)
            txtNOrdonnnace.Text = Me.BindingContext(dt1).Count
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If A = 0 Then
            Dim cc
            cc = MsgBox("Vous utilisez une version d'évaluation !" & vbCrLf & "Cette opération ne peut pas être effectuée" & vbCrLf & "dans la version d'évaluation" & vbCrLf & "pour bénéficier de toutes les fonctionnalités de ce logiciel" & vbCrLf & "veuillez demander votre clé d'activation" & vbCrLf & "" & vbCrLf & "voulez-vous activer le programme maintenant ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "")
            If cc = vbYes Then
                frmActivation.Show()
                Me.Close()
            End If
        Else

            Try

                Dim aa
                aa = MsgBox("Voulez-vous vraiment supprimer ce patient ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
                If aa = vbYes Then


                    Dim SavInto As New OleDb.OleDbCommand
                    SavInto.Connection = Conn
                    SavInto.CommandType = CommandType.Text

                    SavInto.CommandText = "delete * from patient where Numero=" & Val(Numero.Text) & ""
                    Conn.Open()
                    SavInto.ExecuteNonQuery()
                    Conn.Close()
                    Button1_Click(sender, e)
                    Call RefreshDataGrid()
                    MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
                End If
            Catch ex As Exception

                MsgBox("Une erreur !", MsgBoxStyle.Critical)

            End Try
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If txtNom.Text = "" Or txtPrenom.Text = "" Then
            MsgBox("Vous devez sélectionner un patient !", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        frmOrdonnance.txtAge.Text = txtAge.Text
        frmOrdonnance.txtNom.Text = txtNom.Text
        frmOrdonnance.txtPrenom.Text = txtPrenom.Text
        frmOrdonnance.txtNPatient.Text = Numero.Text
        frmOrdonnance.comboTranche.Text = txtTranche.Text
        frmOrdonnance.Show()
        'Me.Close()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

   

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtPrenom.Focus()
        End If

    End Sub

    Private Sub txtNom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtNom.MouseMove

    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        TextBox1.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmCompteRendu.txtNom.Text = txtNom.Text
        frmCompteRendu.txtPrenom.Text = txtPrenom.Text
        frmCompteRendu.txtAge.Text = txtAge.Text + "  " + txtTranche.Text
        frmCompteRendu.Show()

    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmRendezVous.txtNom.Text = txtNom.Text
        frmRendezVous.txtPrenom.Text = txtPrenom.Text
        frmRendezVous.txtDate.Text = Date.Now.Date
        frmRendezVous.Show()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(DateAdd(DateInterval.Day, -2, Date.Now.Date))
    End Sub

    Private Sub txtPrenom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrenom.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtDateNaissance.Focus()
        End If
    End Sub

    Private Sub txtPrenom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrenom.TextChanged

    End Sub

    Private Sub txtDateNaissance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDateNaissance.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtAge.Focus()
        End If
    End Sub

    Private Sub txtDateNaissance_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtDateNaissance.MaskInputRejected

    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtTranche.Focus()
        End If
    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub txtTranche_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTranche.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtAdresse.Focus()
        End If
    End Sub

    Private Sub txtTranche_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTranche.SelectedIndexChanged

    End Sub

    Private Sub txtAdresse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdresse.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Sexe1.Focus()
        End If
    End Sub

    Private Sub txtAdresse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdresse.TextChanged

    End Sub

    Private Sub Sexe1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sexe1.CheckedChanged

    End Sub

    Private Sub Sexe1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Sexe1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Sexe2.Focus()
        End If
    End Sub

    Private Sub Sexe2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sexe2.CheckedChanged

    End Sub

    Private Sub Sexe2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Sexe2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtPhone_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtPhone.MaskInputRejected

    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            txtInfo.Focus()
        End If
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInfo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Button2.Focus()
        End If
    End Sub

    Private Sub txtInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInfo.TextChanged

    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim txtNecessite, txtJours1, txtDateJours1, txtJours2, txtDateJours2, txtRependre
        'txtNecessite = InputBox("Ce patient necessite : ")
        txtJours1 = InputBox("Un traitement d'arrêt travail de combiens de jours ?")
        'txtDateJours1 = InputBox("A compter du :")
        txtJours2 = InputBox("Une prolongation d'arrêt travail de combiens de jours?")
        'txtDateJours2 = InputBox("Sauf Complication : ")
        'txtRependre = InputBox("Lui permettre de reprendre son travail le : ")
        frmCertificat.txtName.Text = txtNom.Text + " " + txtPrenom.Text
        frmCertificat.txtDateN.Text = txtAge.Text + "  " + txtTranche.Text
        'frmCertificat.txtNecessite.Text = txtNecessite
        frmCertificat.txtJours1.Text = txtJours1
        'frmCertificat.txtDateJours1.Text = txtDateJours1
        frmCertificat.txtJours2.Text = txtJours2
        'frmCertificat.txtDateJours2.Text = txtDateJours2
        'frmCertificat.txtReprendre.Text = txtRependre
        'frmCertificat.dDate.Text = "Djelfa le : " + InputBox("Djelfa le :")
        frmCertificat.Show()
        Dim aa
        aa = MsgBox("Voulez-vous imprimer maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then
            frmCertificat.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            frmCertificat.PrintForm1.Print()
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim msg
        msg = MsgBox("Voulez-vous ajouter des données ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "")
        If msg = vbYes Then
            frmExamen.txtNom.Text = txtNom.Text
            frmExamen.txtPrenom.Text = txtPrenom.Text
            frmExamen.txtAge.Text = txtAge.Text + " " + txtTranche.Text
            frmExamen.txtAdresse.Text = txtAdresse.Text
            frmExamen.Show()
        Else
            frmExamenPrint1.txtNom.Text = txtNom.Text
            frmExamenPrint1.txtPrenom.Text = txtPrenom.Text
            frmExamenPrint1.txtAge.Text = txtAge.Text + " " + txtTranche.Text
            frmExamenPrint1.txtAdresse.Text = txtAdresse.Text
            frmExamenPrint1.Show()
            Dim aa
            aa = MsgBox("Voulez-vous imprimer la page 1 maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then

                frmExamenPrint1.ComboBox1.Visible = False
                frmExamenPrint1.ComboBox2.Visible = False
                frmExamenPrint1.Button1.Visible = False
                frmExamenPrint1.Button2.Visible = False
                frmExamenPrint1.txtNDossier.Visible = False
                frmExamenPrint1.GroupBox1.Visible = False
                frmExamenPrint1.ProgressBar1.Visible = False

                frmExamenPrint1.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                frmExamenPrint1.PrintForm1.Print()
            End If

            frmExamenPrint2.txtNom.Text = txtNom.Text
            frmExamenPrint2.txtPrenom.Text = txtPrenom.Text
            frmExamenPrint2.txtAge.Text = txtAge.Text + " " + txtTranche.Text
            frmExamenPrint2.txtAdresse.Text = txtAdresse.Text
            frmExamenPrint2.Show()

            aa = MsgBox("Voulez-vous imprimer la page 2 maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then

              
                frmExamenPrint2.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                frmExamenPrint2.PrintForm1.Print()
            End If
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim msg
        msg = MsgBox("Voulez-vous ajouter des données ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "")
        If msg = vbNo Then
            frmPrintOtoen.txtNom.Text = txtNom.Text
            frmPrintOtoen.txtPrenom.Text = txtPrenom.Text
            frmPrintOtoen.txtAge.Text = txtAge.Text + " " + txtTranche.Text
            frmPrintOtoen.Show()
            Dim aa
            aa = MsgBox("Voulez-vous imprimer maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then
                frmPrintOtoen.ComboBox1.Visible = False
                frmPrintOtoen.ComboBox2.Visible = False
                frmPrintOtoen.Button1.Visible = False
                frmPrintOtoen.Button2.Visible = False
                frmPrintOtoen.RadioButton1.Visible = False
                frmPrintOtoen.RadioButton2.Visible = False
                frmPrintOtoen.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                frmPrintOtoen.PrintForm1.Print()
            End If
        Else
           

            frmOtoenConfig.Show()
            
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        frmCertificatPrescp.txtNom.Text = txtNom.Text
        frmCertificatPrescp.txtPrenom.Text = txtPrenom.Text
        frmCertificatPrescp.txtAge.Text = txtAge.Text + " " + txtTranche.Text
        frmCertificatPrescp.Show()
        Dim aa
        aa = MsgBox("Voulez-vous imprimer maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then
            frmCertificatPrescp.Button1.Visible = False
            frmCertificatPrescp.Button2.Visible = False
            frmCertificatPrescp.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            frmCertificatPrescp.PrintForm1.Print()
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Form25.TextBox1.Text = txtNom.Text + " " + txtPrenom.Text
        Form25.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form26.TextBox1.Text = txtNom.Text
        Form26.TextBox2.Text = txtPrenom.Text
        Form26.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Form27.TextBox1.Text = txtNom.Text
        Form27.TextBox2.Text = txtPrenom.Text
        Form27.Show()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form28.TextBox1.Text = txtNom.Text
        Form28.TextBox2.Text = txtPrenom.Text
        Form28.Show()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        frmMemo.txtTitre.Text = txtNom.Text + " " + txtPrenom.Text
        frmMemo.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        frmExamen.txtNom.Text = txtNom.Text
        frmExamen.txtPrenom.Text = txtPrenom.Text
        frmExamen.txtAge.Text = txtAge.Text + " " + txtTranche.Text
        frmExamen.txtAdresse.Text = txtAdresse.Text
        frmExamen.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        frmOrdonnance.Show()
    End Sub
End Class

