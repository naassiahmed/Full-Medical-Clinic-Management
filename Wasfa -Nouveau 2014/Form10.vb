Imports System.Data
Imports System.Data.OleDb
Public Class frmMemo
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from Memo"
    Dim dt As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)

  
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            '    If txtHeure.Text = "  :" Then
            'MsgBox("Veuillez spécifier une heure !", MsgBoxStyle.Exclamation, "")
            'txtHeure.Focus()
            'Exit Sub
            'End If
            If Trim(txtTitre.Text) = "" Then
                MsgBox("Saisir un titre", MsgBoxStyle.Exclamation, "")
                txtTitre.Focus()
                Exit Sub
            End If
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into Memos (MDate,Heure,Titre,Infos) values('" & txtDate.Value.Date & "','" & txtHeure.Text & "' ,'" & Trim(txtTitre.Text) & "','" & Trim(txtMemo.Text) & "'  )"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            RefreshDbGrid()
            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub frmMemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RefreshDbGrid()
        dt.Clear()

        DataAdapter1 = New OleDbDataAdapter("select * from Memos where Titre like '%" & Trim(txtTitre.Text) & "%'", Conn)



        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "Vous avez  :  " & BindingContext(dt).Count
    End Sub
    Sub RefreshDbGrid()
        dt.Clear()
        DataAdapter1 = New OleDbDataAdapter("select * from Memos", Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "Vous avez  :  " & BindingContext(dt).Count
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'txtTitre.Text = ""
        txtMemo.Text = ""
        txtHeure.Text = ""
        Button1.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = True
        RefreshDbGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try





            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update Memos set Heure='" & txtHeure.Text & "',MDate='" & txtDate.Value.Date & "',Titre='" & Trim(txtTitre.Text) & "',infos='" & Trim(txtMemo.Text) & "' where N°=" & Val(Numero.Text) & ""

            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()
            Call RefreshDbGrid()
            MsgBox("Modification Réussie !", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim aa
            aa = MsgBox("Voulez-vous vraiment supprimer ce mémo ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete * from Memos where N°=" & Val(Numero.Text) & ""
                Conn.Open()
                SavInto.ExecuteNonQuery()
                Conn.Close()
                Call RefreshDbGrid()
                MsgBox("Suppression Réussie !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
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
        Numero.Text = DataGridView1.Item(0, aa).Value
        txtTitre.Text = DataGridView1.Item(1, aa).Value
        txtMemo.Text = DataGridView1.Item(2, aa).Value
        txtHeure.Text = DataGridView1.Item(3, aa).Value
        txtDate.Value = DataGridView1.Item(4, aa).Value

        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dt.Clear()
        If rechDate.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Memos where MDate like '%" & Trim(TextBox3.Text) & "%'", Conn)
        End If
        If rechInfo.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Memos where Infos like '%" & Trim(TextBox3.Text) & "%'", Conn)
        End If
        If rechHeure.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Memos where Heure like '%" & Trim(TextBox3.Text) & "%'", Conn)
        End If
        If rechTitre.Checked = True Then
            DataAdapter1 = New OleDbDataAdapter("select * from Memos where Titre like '%" & Trim(TextBox3.Text) & "%'", Conn)
        End If

       
        DataAdapter1.Fill(dt)

        Count.Text = "Vous avez  :  " & BindingContext(dt).Count
        If BindingContext(dt).Count = 0 Then
            MsgBox("Aucun élément trouvé !", MsgBoxStyle.Exclamation, "")
        Else
            DataGridView1.DataSource = dt
        End If


        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        RefreshDbGrid()
    End Sub
End Class