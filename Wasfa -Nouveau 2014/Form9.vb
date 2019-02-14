Imports System.Data
Imports System.Data.OleDb
Public Class frmPrint3
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from Medecin"
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Private Sub frmPrint3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub frmPrint3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If A = 1 Then PictureBox1.Hide()
        LoadMedecinInfos()
        FixElements()

    End Sub
    Sub FixElements()
        If Med2.Text = "" Then
            Pos2.Visible = False
            Qnt2.Visible = False
            Line2.Visible = False
            btn2.Visible = False
            Jours2.Visible = False
        End If

        If Med3.Text = "" Then
            Pos3.Visible = False
            Qnt3.Visible = False
            Line3.Visible = False
            Btn3.Visible = False
            Jours3.Visible = False
        End If

        If Med4.Text = "" Then
            Pos4.Visible = False
            Qnt4.Visible = False
            Line4.Visible = False
            Btn4.Visible = False
            Jours4.Visible = False
        End If

        If Med5.Text = "" Then
            Pos5.Visible = False
            Qnt5.Visible = False
            Line5.Visible = False
            Btn5.Visible = False
            Jours5.Visible = False
        End If

        If Med6.Text = "" Then
            Pos6.Visible = False
            Qnt6.Visible = False
            Line6.Visible = False
            Btn6.Visible = False
            Jours6.Visible = False
        End If

        If Med7.Text = "" Then
            Pos7.Visible = False
            Qnt7.Visible = False
            Line7.Visible = False
            Btn7.Visible = False
            Jours7.Visible = False
        End If


    End Sub
    Sub LoadMedecinInfos()
        DataAdapter1.Fill(DataSet1, "Medecin")



        txtNomAr.DataBindings.Add("Text", DataSet1, "Medecin.Nom2")
        txtNomFr.DataBindings.Add("Text", DataSet1, "Medecin.Nom1")
        txtAdresse.DataBindings.Add("Text", DataSet1, "Medecin.Adresse")


        txtPhone.DataBindings.Add("Text", DataSet1, "Medecin.Telephone")

        txtVille.DataBindings.Add("Text", DataSet1, "Medecin.ville")
        txtTypeFr.DataBindings.Add("Text", DataSet1, "Medecin.Type1")
        txtEmail.DataBindings.Add("Text", DataSet1, "Medecin.email")


        txtVille.Text = txtVille.Text & " Le : " & txtDatePrint





        TextBox11.Focus()
    End Sub

    Private Sub Med2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Med2.TextChanged

    End Sub
End Class