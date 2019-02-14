Imports System.Data.OleDb

Public Class frmExamenPrint1
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String = "select * from ExamenNaso"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter()
    Dim Tbl(20) As String
    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Le motif")
        ComboBox1.Items.Add("Fosses nasales")
        ComboBox1.Items.Add("Cloison nasale")
        ComboBox1.Items.Add("Filières")
        ComboBox1.Items.Add("Cornets")
        ComboBox1.Items.Add("Méats")
        ComboBox1.Items.Add("-------")
        ComboBox1.Items.Add("Cavum : (nasopharynx)")
        ComboBox1.Items.Add("Cavité")
        ComboBox1.Items.Add("Parois")
        ComboBox1.Items.Add("Focettes de ROSENMULLER")
        ComboBox1.Items.Add("-------")
        ComboBox1.Items.Add("Oropharynx")
        ComboBox1.Items.Add("Paroi post")
        ComboBox1.Items.Add("Les amygdales")
        ComboBox1.Items.Add("Base de langue")
        ComboBox1.Items.Add("-------")
        ComboBox1.Items.Add("Hypopharynx")

        ComboBox1.Items.Add("-------")
        ComboBox1.Items.Add("Larynx")

        ComboBox1.Items.Add("LX sus-glottique")
        ComboBox1.Items.Add("La glotte")
        ComboBox1.Items.Add("LX sous glottique")
        Tbl(0) = "Le motif"
        Tbl(1) = "Fosses nasales"
        Tbl(2) = "Cloison nasale"
        Tbl(3) = "Filières"
        Tbl(4) = "Cornets"
        Tbl(5) = "Méats"
        Tbl(6) = "Cavum : (nasopharynx)"
        Tbl(7) = "Cavité"
        Tbl(8) = "Parois"
        Tbl(9) = "Focettes de ROSENMULLER"
        Tbl(10) = "Oropharynx"
        Tbl(11) = "Paroi post"
        Tbl(12) = "Les amygdales"
        Tbl(13) = "Base de langue"
        Tbl(14) = "Hypopharynx"
        Tbl(15) = "Larynx"
        Tbl(16) = "LX sus-glottique"
        Tbl(17) = "La glotte"
        Tbl(18) = "LX sous glottique"


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        DataAdapter2 = New OleDbDataAdapter("select * from ExamenNaso where txtField='" & ComboBox1.SelectedItem.ToString & "'", Conn)
        dt.Clear()
        DataAdapter2.Fill(dt, "ExamenNaso")
        ComboBox2.Items.Clear()
        DataAdapter2.Fill(dt)


        ComboBox2.DisplayMember = "txtValue"
        ComboBox2.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex = 0 Then
            If Trim(TextBox1.Text) = "" Then
                TextBox1.Text = ComboBox2.Text
            Else
                TextBox1.Text = TextBox1.Text + ", " + ComboBox2.Text
            End If

        End If


        If ComboBox1.SelectedIndex = 1 Then
            If Trim(TextBox2.Text) = "" Then
                TextBox2.Text = ComboBox2.Text
            Else
                TextBox2.Text = TextBox2.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 2 Then
            If Trim(TextBox3.Text) = "" Then
                TextBox3.Text = ComboBox2.Text
            Else
                TextBox3.Text = TextBox3.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 3 Then
            If Trim(TextBox4.Text) = "" Then
                TextBox4.Text = ComboBox2.Text
            Else
                TextBox4.Text = TextBox4.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 4 Then
            If Trim(TextBox5.Text) = "" Then
                TextBox5.Text = ComboBox2.Text
            Else
                TextBox5.Text = TextBox5.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 5 Then
            If Trim(TextBox6.Text) = "" Then
                TextBox6.Text = ComboBox2.Text
            Else
                TextBox6.Text = TextBox6.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 7 Then
            If Trim(TextBox7.Text) = "" Then
                TextBox7.Text = ComboBox2.Text
            Else
                TextBox7.Text = TextBox7.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 8 Then
            If Trim(TextBox8.Text) = "" Then
                TextBox8.Text = ComboBox2.Text
            Else
                TextBox8.Text = TextBox8.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 9 Then
            If Trim(TextBox9.Text) = "" Then
                TextBox9.Text = ComboBox2.Text
            Else
                TextBox9.Text = TextBox9.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 10 Then
            If Trim(TextBox10.Text) = "" Then
                TextBox10.Text = ComboBox2.Text
            Else
                TextBox10.Text = TextBox10.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 12 Then
            If Trim(TextBox11.Text) = "" Then
                TextBox11.Text = ComboBox2.Text
            Else
                TextBox11.Text = TextBox11.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 13 Then
            If Trim(TextBox12.Text) = "" Then
                TextBox12.Text = ComboBox2.Text
            Else
                TextBox12.Text = TextBox12.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 14 Then
            If Trim(TextBox13.Text) = "" Then
                TextBox13.Text = ComboBox2.Text
            Else
                TextBox13.Text = TextBox13.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 15 Then
            If Trim(TextBox14.Text) = "" Then
                TextBox14.Text = ComboBox2.Text
            Else
                TextBox14.Text = TextBox14.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 17 Then
            If Trim(TextBox15.Text) = "" Then
                TextBox15.Text = ComboBox2.Text
            Else
                TextBox15.Text = TextBox15.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 19 Then
            If Trim(TextBox16.Text) = "" Then
                TextBox16.Text = ComboBox2.Text
            Else
                TextBox16.Text = TextBox16.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 20 Then
            If Trim(TextBox17.Text) = "" Then
                TextBox17.Text = ComboBox2.Text
            Else
                TextBox17.Text = TextBox17.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 21 Then
            If Trim(TextBox18.Text) = "" Then
                TextBox18.Text = ComboBox2.Text
            Else
                TextBox18.Text = TextBox18.Text + ", " + ComboBox2.Text
            End If
        End If


        If ComboBox1.SelectedIndex = 22 Then
            If Trim(TextBox19.Text) = "" Then
                TextBox19.Text = ComboBox2.Text
            Else
                TextBox19.Text = TextBox19.Text + ", " + ComboBox2.Text
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ComboBox1.Visible = False
        ComboBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        txtNDossier.Visible = False
        GroupBox1.Visible = False
        ProgressBar1.Visible = False
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 50, 0)
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()

    End Sub

    Private Sub TextBox20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.Click

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "insert into ExamenData(DateIns,txtNom,txtPrenom,txtAge,txtAdresse,N°,motif,fo,cn,fi,co,me,cav,ca,pa,fr,oro,pap,amy,bl,hyp,lar,lxs,gl,lxso,conc)" & _
            " values('" & Now.Date & "','" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtAge.Text & "','" & txtAdresse.Text & "','" & Trim(txtNDossier.Text) & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & _
             "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "','" & TextBox20.Text & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub
End Class