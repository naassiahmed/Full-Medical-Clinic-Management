Imports System.Data
Imports System.Data.OleDb
Public Class frmMed
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Med.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from Med"
    Dim dt As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectionBaseDeDonnées()
        RefreshDataGrid()

    End Sub
    Public Sub ConnectionBaseDeDonnées()
        Conn.Open()
        Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(DataSet1, "Med")
        Conn.Close()
    End Sub
    Sub RefreshDataGrid()
        Conn.Open()

        dt.Clear()
        DataAdapter1 = New OleDbDataAdapter("select * from Med ", Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Conn.Close()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Label2.Text = "Vous avez : " + DataGridView1.RowCount.ToString + "  Médicaments "

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox1.Focus()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        RefreshDataGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        On Error Resume Next
        Dim aa
        aa = (DataGridView1.CurrentCell.RowIndex)
        TextBox1.Text = DataGridView1.Item(1, aa).Value
        Numero.Text = DataGridView1.Item(0, aa).Value
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Trim(TextBox1.Text) = "" Then
                MsgBox("Veuillez tapez une valeur !", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into Med(Med)" & " values('" & TextBox1.Text & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            RefreshDataGrid()
            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)
            Button6_Click(sender, e)
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim aa
            aa = MsgBox("Voulez-vous vraiment supprimer ce médicament ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete * from med where N°=" & Val(Numero.Text) & ""
                Conn.Open()
                SavInto.ExecuteNonQuery()
                Conn.Close()
                Call RefreshDataGrid()
                Button6_Click(sender, e)
                MsgBox("Suppression Réussie !", MsgBoxStyle.Information)

            End If
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try





            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update Med set Med='" & Trim(TextBox1.Text) & "' where N°=" & Val(Numero.Text) & ""

            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            Call RefreshDataGrid()
            MsgBox("Modification Réussie !", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim bb

        bb = InputBox("Donnez un médicament : ")
        DataAdapter1 = New OleDbDataAdapter("select * from Med where Med like '%" & bb & "%'", Conn)
        dt.Clear()
        DataAdapter1.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub
End Class