Imports System.Data.OleDb

Public Class frmExamen
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String = "select * from ExamenNaso"
    Dim SQLstr1 As String = "select * from ExamenData"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter(SQLstr1, Conn)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Trim(TextBox1.Text) = "" Then
                MsgBox("Veuillez introduire une valeur !", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            DataAdapter1 = New OleDbDataAdapter("select * from ExamenNaso where txtValue='" & Trim(TextBox1.Text) & "'", Conn)
            DataAdapter1.Fill(dt2)
            '    If Me.BindingContext(dt1).Count > 0 Then
            ' MsgBox("Cet élément existe déjà !", MsgBoxStyle.Exclamation, "")
            ' Exit Sub
            ' End If

            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into ExamenNaso(txtField,txtValue)" & " values('" & ComboBox1.SelectedItem.ToString & "','" & Trim(TextBox1.Text) & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)
            LoadElements()
            TextBox1.Text = ""

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'DataAdapter2 = New OleDbDataAdapter(SQLstr1, Conn)
        'DataAdapter2.Fill(dt2)
        'DataGridView1.DataSource = dt2

        dt.Clear()
        SQLstr = "select * from ExamenData where txtNom='" & txtNom.Text & "' and txtPrenom='" & txtPrenom.Text & "'"
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        DataAdapter2 = New OleDbDataAdapter("select * from ExamenNaso where txtField='" & ComboBox1.SelectedItem.ToString & "'", Conn)
        dt2.Clear()
        DataAdapter2.Fill(dt2, "ExamenNaso")
        ComboBox2.Items.Clear()
        DataAdapter2.Fill(dt2)


        ComboBox2.DisplayMember = "txtValue"
        ComboBox2.DataSource = dt2
    End Sub
    Sub LoadElements()
        On Error Resume Next
        DataAdapter2 = New OleDbDataAdapter("select * from ExamenNaso where txtField='" & ComboBox1.SelectedItem.ToString & "'", Conn)
        dt2.Clear()
        DataAdapter2.Fill(dt2, "ExamenNaso")
        ComboBox2.Items.Clear()
        DataAdapter2.Fill(dt2)


        ComboBox2.DisplayMember = "txtValue"
        ComboBox2.DataSource = dt2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dt2.Clear()
        DataAdapter2 = New OleDbDataAdapter(SQLstr1, Conn)
        DataAdapter2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim aa
        aa = (DataGridView1.CurrentCell.RowIndex)
        frmExamenPrint1.TextBox1.Text = DataGridView1.Item(6, aa).Value
        frmExamenPrint1.TextBox2.Text = DataGridView1.Item(7, aa).Value
        frmExamenPrint1.TextBox3.Text = DataGridView1.Item(8, aa).Value
        frmExamenPrint1.TextBox4.Text = DataGridView1.Item(9, aa).Value
        frmExamenPrint1.TextBox5.Text = DataGridView1.Item(10, aa).Value
        frmExamenPrint1.TextBox6.Text = DataGridView1.Item(11, aa).Value
        frmExamenPrint1.TextBox7.Text = DataGridView1.Item(12, aa).Value
        frmExamenPrint1.TextBox8.Text = DataGridView1.Item(13, aa).Value
        frmExamenPrint1.TextBox9.Text = DataGridView1.Item(14, aa).Value
        frmExamenPrint1.TextBox10.Text = DataGridView1.Item(15, aa).Value
        frmExamenPrint1.TextBox11.Text = DataGridView1.Item(16, aa).Value
        frmExamenPrint1.TextBox12.Text = DataGridView1.Item(17, aa).Value
        frmExamenPrint1.TextBox13.Text = DataGridView1.Item(18, aa).Value
        frmExamenPrint1.TextBox14.Text = DataGridView1.Item(19, aa).Value
        frmExamenPrint1.TextBox15.Text = DataGridView1.Item(20, aa).Value
        frmExamenPrint1.TextBox16.Text = DataGridView1.Item(21, aa).Value
        frmExamenPrint1.TextBox17.Text = DataGridView1.Item(22, aa).Value
        frmExamenPrint1.TextBox18.Text = DataGridView1.Item(23, aa).Value
        frmExamenPrint1.TextBox19.Text = DataGridView1.Item(24, aa).Value
        frmExamenPrint1.TextBox20.Text = DataGridView1.Item(25, aa).Value
        frmExamenPrint1.Show()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim aa
        aa = (DataGridView1.CurrentCell.RowIndex)

        frmExamenPrint2.txtNom.Text = txtNom.Text
        frmExamenPrint2.txtPrenom.Text = txtPrenom.Text
        frmExamenPrint2.txtAge.Text = txtAge.Text
        frmExamenPrint2.txtAdresse.Text = txtAdresse.Text
        frmExamenPrint2.txtNDossier.Text = DataGridView1.Item(0, aa).Value
        frmExamenPrint2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next

        Dim aa
        aa = MsgBox("Voulez-vous vraiment supprimer ce document ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then


            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            Dim bb
            bb = (DataGridView1.CurrentCell.RowIndex)
            SavInto.CommandText = "delete * from ExamenData where N°='" & DataGridView1.Item(0, bb).Value & "'"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            dt.Clear()
            SQLstr = "select * from ExamenData where txtNom='" & txtNom.Text & "' and txtPrenom='" & txtPrenom.Text & "'"
            DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt



            MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class