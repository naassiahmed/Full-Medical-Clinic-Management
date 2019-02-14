Imports System.Data.OleDb

Public Class Form27
    Dim Numero, txtNom, txtPrenom, txtAge, val1, val2, val3, val4, val5 As String
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLstr = "select * from TableProthese where txtNom='" & TextBox1.Text & "' and txtPrenom='" & TextBox2.Text & "'"
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dt.Clear()
        SQLstr = "select * from TableProthese "
        DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try

       
            Dim aa
            aa = (DataGridView1.CurrentCell.RowIndex)
            Numero = DataGridView1.Item(0, aa).Value
            txtNom = DataGridView1.Item(2, aa).Value
            txtPrenom = DataGridView1.Item(3, aa).Value
            txtAge = DataGridView1.Item(4, aa).Value
            val1 = DataGridView1.Item(5, aa).Value
            val2 = DataGridView1.Item(6, aa).Value
            val3 = DataGridView1.Item(7, aa).Value
            val4 = DataGridView1.Item(8, aa).Value
            val5 = DataGridView1.Item(9, aa).Value
            Button4.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCertificatPrescp.txtNom.Text = txtNom
        frmCertificatPrescp.txtPrenom.Text = txtPrenom
        frmCertificatPrescp.txtAge.Text = txtAge

        If val1 = "1" Then
            frmCertificatPrescp.CheckBox1.CheckState = CheckState.Checked
            frmCertificatPrescp.CheckBox1.Font = New Font(frmCertificatPrescp.CheckBox1.Font, FontStyle.Underline + FontStyle.Bold)
            frmCertificatPrescp.CheckBox1.BackColor = Color.Gainsboro
        End If

      
        If val2 = "1" Then
            frmCertificatPrescp.CheckBox2.CheckState = CheckState.Checked
            frmCertificatPrescp.CheckBox2.Font = New Font(frmCertificatPrescp.CheckBox2.Font, FontStyle.Underline + FontStyle.Bold)
            frmCertificatPrescp.CheckBox2.BackColor = Color.Gainsboro
        End If

        If val3 = "1" Then
            frmCertificatPrescp.CheckBox4.CheckState = CheckState.Checked
            frmCertificatPrescp.CheckBox4.Font = New Font(frmCertificatPrescp.CheckBox4.Font, FontStyle.Underline + FontStyle.Bold)
            frmCertificatPrescp.CheckBox4.BackColor = Color.Gainsboro
        End If

        If val4 = "1" Then

            frmCertificatPrescp.CheckBox3.CheckState = CheckState.Checked
            frmCertificatPrescp.CheckBox3.Font = New Font(frmCertificatPrescp.CheckBox3.Font, FontStyle.Underline + FontStyle.Bold)
            frmCertificatPrescp.CheckBox3.BackColor = Color.Gainsboro
        End If

        If val5 = "1" Then
            frmCertificatPrescp.CheckBox5.CheckState = CheckState.Checked
            frmCertificatPrescp.CheckBox5.Font = New Font(frmCertificatPrescp.CheckBox5.Font, FontStyle.Underline + FontStyle.Bold)
            frmCertificatPrescp.CheckBox5.BackColor = Color.Gainsboro
        End If
        
        frmCertificatPrescp.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim aa
        aa = MsgBox("Voulez-vous vraiment supprimer ce document ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then


            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "delete * from TableProthese where N°=" & Numero & ""
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            dt.Clear()
            SQLstr = "select * from TableProthese where txtNom='" & TextBox1.Text & "' and txtPrenom='" & TextBox2.Text & "'"
            DataAdapter1 = New OleDbDataAdapter(SQLstr, Conn)
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt

            MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
        End If
    End Sub
End Class