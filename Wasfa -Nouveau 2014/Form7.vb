Imports System.Data
Imports System.Data.OleDb
Public Class frmPrint1
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from Medecin"
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)

    Private Sub frmPrint1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        
    End Sub

    Private Sub frmPrint1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        
    End Sub

    Private Sub frmPrint1_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ClientSizeChanged

    End Sub

    Private Sub frmPrint1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        
        

    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If A = 1 Then PictureBox2.Hide()
        LoadMedecinInfos()
        FixElements()
        
        txtDate.Text = txtDatePrint

        Dim Reg As Object
        Reg = CreateObject("wscript.shell")
        ' Try
        '          Select Case Reg.regread("HKCU\frmLogo")
        '               Case 1
        '          Logo1.Show()
        '             Case 2
        '        Logo2.Show()
        '           Case 3
        '      Logo3.Show()
        '         Case 4
        '    Logo4.Show()
        ''       Case 5
        ' Logo5.Show()
        '     Case 6
        ' Logo6.Show()
        ' End Select
        '  Catch ex As Exception
        '      Reg.regwrite("HKCU\frmPrint", 1, "REG_SZ")
        '  End Try
    End Sub
    Sub FixElements()
        If Med2.Text = "2/ " Then
            Med2.Hide()
            Pos2.Visible = False
            Qnt2.Visible = False
            Line2.Visible = False
            btn2.Visible = False
            Jours2.Visible = False
        End If

        If Med3.Text = "3/ " Then
            Med3.Hide()
            Pos3.Visible = False
            Qnt3.Visible = False
            Line3.Visible = False
            Btn3.Visible = False
            Jours3.Visible = False
        End If

        If Med4.Text = "4/ " Then
            Med4.Hide()
            Pos4.Visible = False
            Qnt4.Visible = False
            Line4.Visible = False
            Btn4.Visible = False
            Jours4.Visible = False
        End If

        If Med5.Text = "5/ " Then
            Med5.Hide()
            Pos5.Visible = False
            Qnt5.Visible = False
            Line5.Visible = False
            Btn5.Visible = False
            Jours5.Visible = False
        End If

        If Med6.Text = "6/ " Then
            Med6.Hide()
            Pos6.Visible = False
            Qnt6.Visible = False
            Line6.Visible = False
            Btn6.Visible = False
            Jours6.Visible = False
        End If

        If Med7.Text = "7/ " Then
            Med7.Hide()
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
        txtPhone1.DataBindings.Add("Text", DataSet1, "Medecin.Telephone")
        txtTypeAr.DataBindings.Add("Text", DataSet1, "Medecin.Type2")
        txtTypeFr.DataBindings.Add("Text", DataSet1, "Medecin.Type1")
        txtSpec1Fr.DataBindings.Add("Text", DataSet1, "Medecin.Spec1")
        txtSpec2Fr.DataBindings.Add("Text", DataSet1, "Medecin.Spec2")

        txtSpec1Ar.DataBindings.Add("Text", DataSet1, "Medecin.Spec11")

        txtSpec2Ar.DataBindings.Add("Text", DataSet1, "Medecin.Spec22")




    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub frmPrint1_PaddingChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PaddingChanged

    End Sub

    Private Sub txtPrenom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrenom.TextChanged

    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged

    End Sub
End Class