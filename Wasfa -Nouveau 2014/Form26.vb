Imports System.Data.OleDb

Public Class Form26
    Dim Numero, Droite, Gauche, txtNom, txtPrenom, txtAge, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8 As String
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
    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLstr = "select * from TableOtoenData where txtNom='" & TextBox1.Text & "' and txtPrenom='" & TextBox2.Text & "'"
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dt.Clear()
        SQLstr = "select * from TableOtoenData "
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            Dim aa
            aa = (DataGridView1.CurrentCell.RowIndex)
            Numero = DataGridView1.Item(0, aa).Value
            txtNom = DataGridView1.Item(2, aa).Value
            txtPrenom = DataGridView1.Item(3, aa).Value
            txtAge = DataGridView1.Item(4, aa).Value
            txt1 = DataGridView1.Item(5, aa).Value
            txt2 = DataGridView1.Item(6, aa).Value
            txt3 = DataGridView1.Item(7, aa).Value
            txt4 = DataGridView1.Item(8, aa).Value
            txt5 = DataGridView1.Item(9, aa).Value
            txt6 = DataGridView1.Item(10, aa).Value
            txt7 = DataGridView1.Item(11, aa).Value
            txt8 = DataGridView1.Item(12, aa).Value
            Droite = DataGridView1.Item(13, aa).Value
            Gauche = DataGridView1.Item(14, aa).Value
            Button4.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmPrintOtoen.txtNom.Text = txtNom
        frmPrintOtoen.txtPrenom.Text = txtPrenom
        frmPrintOtoen.txtAge.Text = txtAge
        frmPrintOtoen.txt1.Text = txt1
        frmPrintOtoen.txt2.Text = txt2
        frmPrintOtoen.txt3.Text = txt3
        frmPrintOtoen.txt4.Text = txt4
        frmPrintOtoen.txt5.Text = txt5
        frmPrintOtoen.txt6.Text = txt6
        frmPrintOtoen.txt7.Text = txt7
        frmPrintOtoen.txt8.Text = txt8
        frmPrintOtoen.txtD.Text = Droite
        frmPrintOtoen.txtG.Text = Gauche
        frmPrintOtoen.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aa
        aa = MsgBox("Voulez-vous vraiment supprimer ce document ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then


            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "delete * from TableOtoenData where N°=" & Numero & ""
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            dt.Clear()
            SQLstr = "select * from TableOtoenData where txtNom='" & TextBox1.Text & "' and txtPrenom='" & TextBox2.Text & "'"
            DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt

            MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
        End If
    End Sub
End Class