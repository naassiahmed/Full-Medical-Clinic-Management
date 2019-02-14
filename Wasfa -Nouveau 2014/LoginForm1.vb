Imports System.Data
Imports System.Data.OleDb
Public Class LoginForm1

    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from tblUser"
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Trim(UsernameTextBox.Text) <> a.Text Or Trim(PasswordTextBox.Text) <> bb.Text Then
            MsgBox("Erreur ! Nom de l'utilisateur or le mot de passe non valide", MsgBoxStyle.Critical, "")
        Else
            MDIParent1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If B = 1 Then
        'MDIParent1.Show()
        'Me.Close()
        'Exit Sub

        ' End If
        Conn.Open()
        Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
        DataAdapter1.Fill(DataSet1, "tblUser")



        a.DataBindings.Add("Text", DataSet1, "tblUser.IDUser")

        bb.DataBindings.Add("Text", DataSet1, "tblUser.IDPassword")

        Conn.Close()
    End Sub
End Class
