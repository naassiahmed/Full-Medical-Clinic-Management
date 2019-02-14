Imports System.Data
Imports System.Data.OleDb
Public Class frmRendezVous
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from RendezVous"
    Dim dt As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)

    Dim ConStr1 As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn1 As New OleDbConnection(ConStr1)
    Dim dataSet3 As New DataSet

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(TrackBar1.Value)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        DateTimePicker1.Visible = False
        Label3.Text = "Jours : "
        NumericUpDown1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        NumericUpDown1.Visible = False
        DateTimePicker1.Visible = True
        Label3.Text = "Date : "
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try





            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update RendezVous set DateInscription='" & Trim(txtDate.Text) & "',DateR='" & Trim(DateTimePicker1.Value.Date) & "',Priorite=" & Val(TrackBar1.Value) & ",infos='" & Trim(TextBox1.Text) & "' where N°=" & Val(Numero2.Text) & ""

            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            Call RefreshDataGrid()
            MsgBox("Modification Réussie !", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Trim(txtNom.Text) = "" Or Trim(txtPrenom.Text) = "" Then
                MsgBox("veillez choisir un patient !", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            If RadioButton1.Checked = True Then
                DateTimePicker1.Value = DateAdd(DateInterval.Day, NumericUpDown1.Value, Date.Now.Date)

            End If
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into RendezVous (Numero,DateInscription,DateR,Priorite,infos) values(" & Val(Numero.Text) & ",'" & txtDate.Text & "' ,'" & DateTimePicker1.Value.Date & "'," & NumericUpDown1.Value & ",'" & TextBox1.Text & "'  )"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            RefreshDataGrid()
            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectBaseDeDonnées()
        RefreshDataGrid()
    End Sub
    Sub ConnectBaseDeDonnées()
        Conn.Open()
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(DataSet1, "RendezVous")
        Conn.Close()
    End Sub
    Sub RefreshDataGrid()

        Conn.Open()
        dt.Clear()
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Conn.Close()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        On Error Resume Next
        Dim aa
        Button1.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = False
        aa = (DataGridView1.CurrentCell.RowIndex)
        Numero2.Text = DataGridView1.Item(0, aa).Value
        Numero.Text = DataGridView1.Item(1, aa).Value
        txtDate.Text = DataGridView1.Item(2, aa).Value
        DateTimePicker1.Value = DataGridView1.Item(3, aa).Value
        TrackBar1.Value = DataGridView1.Item(4, aa).Value
        TextBox1.Text = DataGridView1.Item(5, aa).Value
        DataAdapter1 = New OleDbDataAdapter("select * from Patient where numero =" & Val(Numero.Text) & "", Conn1)
        txtNom.DataBindings.Clear()
        txtPrenom.DataBindings.Clear()
        dataSet3.Clear()
        DataAdapter1.Fill(dataSet3, "Patient")
        txtNom.DataBindings.Add("Text", dataSet3, "patient.nom")
        txtPrenom.DataBindings.Add("Text", Dataset3, "patient.prenom")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        dt.Clear()

        DataAdapter1 = New OleDbDataAdapter("select * from RendezVous", Conn)

        DataAdapter1.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim aa
            aa = MsgBox("Voulez-vous vraiment supprimer ce rendez-vous ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete * from RendezVous where N°=" & Val(Numero2.Text) & ""
                Conn.Open()
                SavInto.ExecuteNonQuery()
                Conn.Close()
                Call RefreshDataGrid()
                MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        dt.Clear()
        If rechDate.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from RendezVous where DateR like '%" & Trim(TextBox2.Text) & "%'", Conn)
        End If
        DataAdapter1.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub
End Class