Imports System.Data.OleDb

Public Class Form25
    Dim Numero, txtDate, txtNom, DateN, Jours1, Date1, Jours2, Date2, Date3 As String
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String
    Dim SQLstr1 As String = "select * from ExamenData"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter(SQLstr1, Conn)
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLstr = "select * from TableCertificat where txtNom='" & TextBox1.Text & "'"
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dt.Clear()
        SQLstr = "select * from TableCertificat "
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            Dim aa
            aa = (DataGridView1.CurrentCell.RowIndex)
            Numero = DataGridView1.Item(0, aa).Value
            txtDate = DataGridView1.Item(1, aa).Value
            txtNom = DataGridView1.Item(2, aa).Value
            DateN = DataGridView1.Item(3, aa).Value
            Jours1 = DataGridView1.Item(4, aa).Value
            Date1 = DataGridView1.Item(5, aa).Value
            Jours2 = DataGridView1.Item(6, aa).Value
            Date2 = DataGridView1.Item(7, aa).Value
            Date3 = DataGridView1.Item(8, aa).Value
            Button4.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        frmCertificat.DateTimePicker1.Value = txtDate
        frmCertificat.txtName.Text = txtNom
        frmCertificat.txtDateN.Text = DateN
        frmCertificat.txtJours1.Text = Jours1
        If Date1 = "/" Then
            frmCertificat.CheckBox1.Checked = True
        Else
            frmCertificat.DateTimePicker2.Value = Date1
        End If

        frmCertificat.txtJours2.Text = Jours2

        If Date2 = "/" Then
            frmCertificat.CheckBox3.Checked = True
        Else
            frmCertificat.DateTimePicker4.Value = Date2
        End If

        If Date3 = "/" Then
            frmCertificat.CheckBox2.Checked = True
        Else
            frmCertificat.DateTimePicker3.Value = Date3
        End If

        frmCertificat.Show()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aa
        aa = MsgBox("Voulez-vous vraiment supprimer ce document ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then


            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "delete * from TableCertificat where N°=" & Numero & ""
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            dt.Clear()
            SQLstr = "select * from TableCertificat where txtNom='" & TextBox1.Text & "'"
            DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt

            MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
        End If
    End Sub
End Class