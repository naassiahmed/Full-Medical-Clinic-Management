Imports System.Data
Imports System.Data.OleDb
Public Class frmOrdonnance
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from Ordonnance"

    Dim ConStr2 As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Med.db;Jet OLEDB:Database Password=123"
    Dim Conn2 As New OleDbConnection(ConStr2)
    Dim DataSet2 As New DataSet
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim SQLstr2 As String = "select * from Med order by med asc"
    Dim aa As New DataTable

    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter(SQLstr, Conn)
    Dim Dataset3 As New DataSet
    Dim NbrOrd As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtDate.Text = Date.Now.Date
        txtHeure.Text = Date.Now.TimeOfDay.ToString
        txtHeure.Text = (Mid(txtHeure.Text, 1, 8))
        If Trim(txtNom.Text) = "" And Trim(txtPrenom.Text) = "" Then
            dt1.Clear()
            DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance", Conn)
            DataAdapter1.Fill(dt1)
            DataGridView1.DataSource = dt1
            Count.Text = "Vous avez  :  " & BindingContext(dt1).Count
            Exit Sub
        End If
        ConnectionBaseDeDonnées()
        ConnectionMedEtDose()
        RefreshDataGrid()
        Button5_Click(sender, e)
        txtCode.Text = DataGridView1.RowCount
        
    End Sub


    Public Sub ConnectionBaseDeDonnées()
        Conn.Open()
        Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(DataSet1, "Ordonnace")
        Conn.Close()
    End Sub
    Public Sub ConnectionMedEtDose()
        Conn2.Open()
        Dim DataAdapter2 As New OleDbDataAdapter(SQLstr2, Conn2)

        DataAdapter2.Fill(DataSet2, "Med")

        DataAdapter2.Fill(aa)
        M1.DisplayMember = "MED"
        M1.DataSource = aa

        aa = New DataTable
        DataAdapter2.Fill(aa)
        M2.DisplayMember = "MED"
        M2.DataSource = aa

        aa = New DataTable
        DataAdapter2.Fill(aa)
        M3.DisplayMember = "MED"
        M3.DataSource = aa

        aa = New DataTable
        DataAdapter2.Fill(aa)
        M4.DisplayMember = "MED"
        M4.DataSource = aa

        aa = New DataTable
        DataAdapter2.Fill(aa)
        M5.DisplayMember = "MED"
        M5.DataSource = aa

        aa = New DataTable
        DataAdapter2.Fill(aa)
        M6.DisplayMember = "MED"
        M6.DataSource = aa

        aa = New DataTable
        DataAdapter2.Fill(aa)
        M7.DisplayMember = "MED"
        M7.DataSource = aa
        aa = New DataTable
        '///////////////////////
        SQLstr2 = "select * from Dose order by dose asc"
        Dim DataAdapter3 As New OleDbDataAdapter(SQLstr2, Conn2)
        DataAdapter3.Fill(DataSet2, "dose")
        DataAdapter3.Fill(aa)

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P1.DisplayMember = "dose"
        P1.DataSource = aa

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P2.DisplayMember = "dose"
        P2.DataSource = aa

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P3.DisplayMember = "dose"
        P3.DataSource = aa

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P4.DisplayMember = "dose"
        P4.DataSource = aa

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P5.DisplayMember = "dose"
        P5.DataSource = aa

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P6.DisplayMember = "dose"
        P6.DataSource = aa

        aa = New DataTable
        DataAdapter3.Fill(aa)
        P7.DisplayMember = "dose"
        P7.DataSource = aa


        '/////////////////////////
        Conn2.Close()
    End Sub
    Sub RefreshDataGrid()
        Conn.Open()

        dt.Clear()
        DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance where codepatient=" & Val(txtNPatient.Text) & "", Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "Vous avez  :  " & BindingContext(dt).Count
        txtCode.Text = DataGridView1.RowCount
        Conn.Close()
    End Sub
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub M1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Trim(M1.Text) = "" Then
                MsgBox("vous devez au moins choisir un médicament", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into Ordonnance(DateInscription,HeureInscription,Code,M1,m2,m3,m4,m5,m6,m7,p1,p2,p3,p4,p5,p6,p7,q1,q2,q3,q4,q5,q6,q7,codepatient,infos,Numero)" & _
            " values('" & txtDate.Text & "','" & txtHeure.Text & "','" & txtCode.Text & "','" & M1.Text & "','" & M2.Text & "','" & M3.Text & "','" & M4.Text & "','" & M5.Text & "','" & M6.Text & "','" & M7.Text & _
             "','" & P1.Text & "','" & P2.Text & "','" & P3.Text & "','" & P4.Text & "','" & P5.Text & "','" & P6.Text & "','" & P7.Text & _
             "','" & Q1.Text & "','" & Q2.Text & "','" & Q3.Text & "','" & Q4.Text & "','" & Q5.Text & "','" & Q6.Text & "','" & Q7.Text & "','" & Val(txtNPatient.Text) & "','" & Trim(txtInfo.Text) & "'," & Val(txtCode.Text) & " )"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            RefreshDataGrid()
            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)
            NbrOrd = NbrOrd + 1
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

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
                aa = MsgBox("Voulez-vous vraiment supprimer cette ordonnance ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
                If aa = vbYes Then


                    Dim SavInto As New OleDb.OleDbCommand
                    SavInto.Connection = Conn
                    SavInto.CommandType = CommandType.Text

                    SavInto.CommandText = "delete * from Ordonnance where N°=" & Val(Numero.Text) & ""
                    Conn.Open()
                    SavInto.ExecuteNonQuery()
                    Conn.Close()
                    Call RefreshDataGrid()
                    Button5_Click(sender, e)
                    MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
                End If
            Catch ex As Exception

                MsgBox("Une erreur !", MsgBoxStyle.Critical)

            End Try
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        
            End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            Dim aa
            aa = (DataGridView1.CurrentCell.RowIndex)
            Numero.Text = DataGridView1.Item(27, aa).Value
            txtDate.Text = DataGridView1.Item(1, aa).Value
            txtHeure.Text = DataGridView1.Item(2, aa).Value
            txtCode.Text = DataGridView1.Item(3, aa).Value
            M1.Text = DataGridView1.Item(4, aa).Value
            M2.Text = DataGridView1.Item(5, aa).Value
            M3.Text = DataGridView1.Item(6, aa).Value
            M4.Text = DataGridView1.Item(7, aa).Value
            M5.Text = DataGridView1.Item(8, aa).Value
            M6.Text = DataGridView1.Item(9, aa).Value
            M7.Text = DataGridView1.Item(10, aa).Value

            Q1.Text = DataGridView1.Item(11, aa).Value
            Q2.Text = DataGridView1.Item(12, aa).Value
            Q3.Text = DataGridView1.Item(13, aa).Value
            Q4.Text = DataGridView1.Item(14, aa).Value
            Q5.Text = DataGridView1.Item(15, aa).Value
            Q6.Text = DataGridView1.Item(16, aa).Value
            Q7.Text = DataGridView1.Item(17, aa).Value

            P1.Text = DataGridView1.Item(18, aa).Value
            P2.Text = DataGridView1.Item(19, aa).Value
            P3.Text = DataGridView1.Item(20, aa).Value
            P4.Text = DataGridView1.Item(21, aa).Value
            P5.Text = DataGridView1.Item(22, aa).Value
            P6.Text = DataGridView1.Item(23, aa).Value
            P7.Text = DataGridView1.Item(24, aa).Value
            txtInfo.Text = DataGridView1.Item(26, aa).Value
            txtCode.Text = DataGridView1.Item(0, aa).Value

            Conn.Open()
            txtNPatient.Text = DataGridView1.Item(25, aa).Value
            Dataset3.Clear()
            DataAdapter2.Dispose()
            txtNom.DataBindings.Clear()
            txtPrenom.DataBindings.Clear()
            txtAge.DataBindings.Clear()
            comboTranche.DataBindings.Clear()
            DataAdapter2 = New OleDbDataAdapter("select * from Patient where numero =" & Val(txtNPatient.Text) & "", Conn)
            DataAdapter2.Fill(Dataset3, "patient")
            txtNom.DataBindings.Add("Text", Dataset3, "patient.nom")
            txtPrenom.DataBindings.Add("Text", Dataset3, "patient.prenom")
            txtAge.DataBindings.Add("Text", Dataset3, "patient.age")
            comboTranche.DataBindings.Add("Text", Dataset3, "patient.tranche")

            Conn.Close()

            Button1.Enabled = False
            Button3.Enabled = True
            Button4.Enabled = True
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dt1.Clear()
        Conn.Open()
        If TextBox1.Text = "" Then
            MsgBox("Tapez une valeur !", MsgBoxStyle.Exclamation, "")
            TextBox1.Focus()
            Conn.Close()
            Exit Sub
        End If
        If rechCurrent.Checked = True Then
            If rechDate.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where dateInscription ='" & TextBox1.Text & "' and codePatient=" & Val(txtNPatient.Text) & "", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If

            If RechHeure.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where HeureInscription ='" & TextBox1.Text & "' and codePatient=" & Val(txtNPatient.Text) & "", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If

            If RechNumero.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where Numero =" & TextBox1.Text & " and codePatient=" & Val(txtNPatient.Text) & "", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If

            If RechCode.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where dateInscription ='" & TextBox1.Text & "' and codePatient=" & Val(txtNPatient.Text) & "", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If
        End If

        If rechAll.Checked = True Then
            If rechDate.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where dateInscription ='" & TextBox1.Text & "'", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If

            If RechHeure.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where HeureInscription ='" & TextBox1.Text & "'", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If

            If RechNumero.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where dateInscription ='" & TextBox1.Text & "'", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If

            If RechCode.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance  where code ='" & TextBox1.Text & "'", Conn)
                DataAdapter1.Fill(dt1)
                DataGridView1.DataSource = dt1
            End If
        End If

        Count.Text = "Vous avez : " & BindingContext(dt1).Count
        Conn.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        For Each a As Control In GroupBox3.Controls
            If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                a.Text = ""
            End If
        Next
        txtInfo.Text = ""
        Button1.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False

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





                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "update Ordonnance set M1='" & M1.Text & "',M2='" & M2.Text & "',M3='" & M3.Text & "',M4='" & M4.Text & "',M5='" & M5.Text & "',M6='" & M6.Text & "',M7='" & M7.Text _
                & "',p2='" & P2.Text & "',p3='" & P3.Text & "',p4='" & P4.Text & "',p5='" & P5.Text & "',p6='" & P6.Text & "',p7='" & P7.Text & "',p1='" & P1.Text _
                & "',q2=" & Val(Q2.Text) & ",q3=" & Val(Q3.Text) & ",q4=" & Val(Q4.Text) & ",q5=" & Val(Q5.Text) & ",q6=" & Val(Q6.Text) & ",q7=" & Val(Q7.Text) & ",q1=" & Val(Q1.Text) _
                & ",infos='" & txtInfo.Text & "' where N°=" & Val(Numero.Text) & ""

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

    Private Sub txtInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInfo.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtDatePrint = txtDate.Text
        Dim Reg As Object
        Dim aa
        'Reg = CreateObject("wscript.shell")

        '        Select Case Reg.regread("HKCU\frmPrint")
        '            Case 1
        frmPrint1.txtNom.Text = Me.txtNom.Text
        frmPrint1.txtPrenom.Text = Me.txtPrenom.Text
        frmPrint1.txtAge.Text = Me.txtAge.Text
        frmPrint1.txtTranche.Text = Me.comboTranche.Text
        frmPrint1.Med1.Text = "1/ " + Me.M1.Text
        frmPrint1.Med2.Text = "2/ " + Me.M2.Text
        frmPrint1.Med3.Text = "3/ " + Me.M3.Text
        frmPrint1.Med4.Text = "4/ " + Me.M4.Text
        frmPrint1.Med5.Text = "5/ " + Me.M5.Text
        frmPrint1.Med6.Text = "6/ " + Me.M6.Text
        frmPrint1.Med7.Text = "7/ " + Me.M7.Text

        frmPrint1.Pos1.Text = Me.P1.Text
        frmPrint1.Pos2.Text = Me.P2.Text
        frmPrint1.Pos3.Text = Me.P3.Text
        frmPrint1.Pos4.Text = Me.P4.Text
        frmPrint1.Pos5.Text = Me.P5.Text
        frmPrint1.Pos6.Text = Me.P6.Text
        frmPrint1.Pos7.Text = Me.P7.Text

        frmPrint1.Qnt1.Text = Me.Q1.Text
        frmPrint1.Qnt2.Text = Me.Q2.Text
        frmPrint1.Qnt3.Text = Me.Q3.Text
        frmPrint1.Qnt4.Text = Me.Q4.Text
        frmPrint1.Qnt5.Text = Me.Q5.Text
        frmPrint1.Qnt6.Text = Me.Q6.Text
        frmPrint1.Qnt7.Text = Me.Q7.Text

        frmPrint1.Show()

        aa = MsgBox("Voulez-vous imprimer maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then
            frmPrint1.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            frmPrint1.PrintForm1.Print()
        End If
        '          Case 2
        '       frmPrint2.txtNom.Text = Me.txtNom.Text
        '     frmPrint2.txtPrenom.Text = Me.txtPrenom.Text
        '    frmPrint2.txtAge.Text = Me.txtAge.Text
        '   frmPrint2.txtTranche.Text = Me.comboTranche.Text
        '  frmPrint2.Med1.Text = Me.M1.Text
        ' frmPrint2.Med2.Text = Me.M2.Text
        'frmPrint2.Med3.Text = Me.M3.Text
        'frmPrint2.Med4.Text = Me.M4.Text
        'frmPrint2.Med5.Text = Me.M5.Text
        'frmPrint2.Med6.Text = Me.M6.Text
        'frmPrint2.Med7.Text = Me.M7.Text

        'frmPrint2.Pos1.Text = Me.P1.Text
        'frmPrint2.Pos2.Text = Me.P2.Text
        'frmPrint2.Pos3.Text = Me.P3.Text
        'frmPrint2.Pos4.Text = Me.P4.Text
        'frmPrint2.Pos5.Text = Me.P5.Text
        'frmPrint2.Pos6.Text = Me.P6.Text
        'frmPrint2.Pos7.Text = Me.P7.Text

        '        frmPrint2.Qnt1.Text = Me.Q1.Text
        '       frmPrint2.Qnt2.Text = Me.Q2.Text
        '      frmPrint2.Qnt3.Text = Me.Q3.Text
        '     frmPrint2.Qnt4.Text = Me.Q4.Text
        '    frmPrint2.Qnt5.Text = Me.Q5.Text
        '   frmPrint2.Qnt6.Text = Me.Q6.Text
        '  frmPrint2.Qnt7.Text = Me.Q7.Text
        '
        'frmPrint2.Show()

        '        aa = MsgBox("Voulez-vous imprimer maintenant ?" & vbCrLf & "[OUI] imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        '        If aa = vbYes Then
        ' frmPrint2.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        ' frmPrint2.PrintForm1.Print()
        ' End If
        '     Case 3
        '
        'frmPrint3.txtNom.Text = Me.txtNom.Text
        'frmPrint3.txtPrenom.Text = Me.txtPrenom.Text
        ' frmPrint3.txtAge.Text = Me.txtAge.Text
        ' frmPrint3.txtTranche.Text = Me.comboTranche.Text
        ' frmPrint3.Med1.Text = Me.M1.Text
        ' frmPrint3.Med2.Text = Me.M2.Text
        ' frmPrint3.Med3.Text = Me.M3.Text
        ' frmPrint3.Med4.Text = Me.M4.Text
        ' frmPrint3.Med5.Text = Me.M5.Text
        ' frmPrint3.Med6.Text = Me.M6.Text
        ' frmPrint3.Med7.Text = Me.M7.Text
        '
        ' frmPrint3.Pos1.Text = Me.P1.Text
        ' frmPrint3.Pos2.Text = Me.P2.Text
        ' frmPrint3.Pos3.Text = Me.P3.Text
        ' frmPrint3.Pos4.Text = Me.P4.Text
        ' frmPrint3.Pos5.Text = Me.P5.Text
        ' frmPrint3.Pos6.Text = Me.P6.Text
        ' frmPrint3.Pos7.Text = Me.P7.Text
        '
        'frmPrint3.Qnt1.Text = Me.Q1.Text
        'frmPrint3.Qnt2.Text = Me.Q2.Text
        'frmPrint3.Qnt3.Text = Me.Q3.Text
        'frmPrint3.Qnt4.Text = Me.Q4.Text
        'frmPrint3.Qnt5.Text = Me.Q5.Text
        'frmPrint3.Qnt6.Text = Me.Q6.Text
        'frmPrint3.Qnt7.Text = Me.Q7.Text
        '
        'frmPrint3.Show()
        '
        'aa = MsgBox("Voulez-vous imprimer maintenant ?" & vbCrLf & "[OUI] Imprimer" & vbCrLf & "[NON] Apercevoir", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        'If aa = vbYes Then
        'frmPrint3.PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        'frmPrint3.PrintForm1.Print()
        'End If
        'End Select
        '
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrint2.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrint3.Show()
    End Sub

    Private Sub Q3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q3.TextChanged

    End Sub

    Private Sub Q2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q2.TextChanged

    End Sub

    Private Sub Q1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q1.TextChanged

    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        dt1.Clear()
        DataAdapter1 = New OleDbDataAdapter("select * from Ordonnance", Conn)
        DataAdapter1.Fill(dt1)
        DataGridView1.DataSource = dt1
        Count.Text = "Vous avez  :  " & BindingContext(dt1).Count
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
