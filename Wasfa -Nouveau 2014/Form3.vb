Imports System.Data
Imports System.Data.OleDb
Public Class frmMedecin
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim SQLstr As String = "select * from Medecin"
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)

    Dim DataSet2 As New DataSet
    Dim SQLstr1 As String = "select * from tblUser"
    Dim DataAdapter2 As New OleDbDataAdapter(SQLstr1, Conn)

    Private Sub frmMedecin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If B = 1 Then
            MsgBox("C'est votre première utilisation de ce programme" & vbCrLf & "Vous devez remplir les champs de cette fenête pour une seule fois" & vbCrLf & "" & vbCrLf & "Attention ! le programme dépend de ce que vous allez remplir", MsgBoxStyle.Information, "")
        End If
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If B = 1 Then
            MsgBox("C'est votre première utilisation de ce programme" & vbCrLf & "Vous devez remplir les champs de cette fenête pour une seule fois" & vbCrLf & "" & vbCrLf & "Attention ! le programme dépend de ce que vous allez remplir", MsgBoxStyle.Information, "")

        End If
        LoadMedecinInfos()
    End Sub
    Sub LoadMedecinInfos()



        DataAdapter1.Fill(DataSet1, "Medecin")


        If Me.BindingContext(DataSet1).Count = 0 Then Exit Sub
        txtNom1.DataBindings.Add("Text", DataSet1, "Medecin.Nom1")
        txtNom2.DataBindings.Add("Text", DataSet1, "Medecin.Nom2")
        txtAdresse.DataBindings.Add("Text", DataSet1, "Medecin.Adresse")
        txtEmail.DataBindings.Add("Text", DataSet1, "Medecin.Email")
        txtEmail2.DataBindings.Add("Text", DataSet1, "Medecin.Email")
        txtPhone.DataBindings.Add("Text", DataSet1, "Medecin.Telephone")
        txtPhone2.DataBindings.Add("Text", DataSet1, "Medecin.Telephone")
        txtTypeA.DataBindings.Add("Text", DataSet1, "Medecin.Type2")
        txtTypeF.DataBindings.Add("Text", DataSet1, "Medecin.Type1")
        txtSpec1F.DataBindings.Add("Text", DataSet1, "Medecin.Spec1")
        txtSpec2F.DataBindings.Add("Text", DataSet1, "Medecin.Spec2")

        txtSpec1A.DataBindings.Add("Text", DataSet1, "Medecin.Spec11")

        txtSpec2A.DataBindings.Add("Text", DataSet1, "Medecin.Spec22")
        txtVille.DataBindings.Add("Text", DataSet1, "Medecin.ville")




        DataAdapter2.Fill(DataSet2, "tblUser")
        txtUser.DataBindings.Add("Text", DataSet2, "tblUser.idUser")
        txtPassword.DataBindings.Add("Text", DataSet2, "tblUser.idPassword")
    End Sub
    Sub ConnectBaseDeDonnées()
        Conn.Open()


        Conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtSpec1A.Text = "" Then txtSpec1A.Text = "/"
        If txtSpec2A.Text = "" Then txtSpec2A.Text = "/"
        If txtSpec1F.Text = "" Then txtSpec1F.Text = "/"
        If txtSpec2F.Text = "" Then txtSpec2F.Text = "/"
        If txtEmail.Text = "" Then txtEmail.Text = "/"
        If txtPhone.Text = "" Then txtPhone.Text = "/"
        If txtAdresse.Text = "" Then txtAdresse.Text = "/"
        If txtVille.Text = "" Then txtVille.Text = "/"
        If Trim(txtNom1.Text) = "" Or Trim(txtNom2.Text) = "" Then
            MsgBox("Vous devez saisir votre nom", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Trim(txtTypeA.Text) = "" Or Trim(txtTypeF.Text) = "" Then
            MsgBox("insuffisance d'informations !", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If Trim(txtUser.Text) = "" Or Trim(txtPassword.Text) = "" Then
            MsgBox("If faut choisir un utilistateur et un mot de passe !", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim Reg As Object
        Reg = CreateObject("wscript.shell")

        Try

            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update Medecin set Nom1='" & Trim(txtNom1.Text) & "',Nom2='" & Trim(txtNom2.Text) & "',Telephone='" & Trim(txtPhone.Text) & "',Email='" & Trim(txtEmail.Text) & "',type1='" & Trim(txtTypeF.Text) & "',type2='" & Trim(txtTypeA.Text) & "',Spec1='" & Trim(txtSpec1F.Text) & "',Spec2 ='" & Trim(txtSpec2F.Text) & "',Adresse='" & Trim(txtAdresse.Text) & "',Spec11='" & Trim(txtSpec1A.Text) & "',Spec22='" & Trim(txtSpec2A.Text) & "',Ville='" & Trim(txtVille.Text) & "'"

            Conn.Open()
            SavInto.ExecuteNonQuery()




            SavInto = New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "update tblUser set iduser='" & Trim(txtUser.Text) & "',idPassword='" & Trim(txtPassword.Text) & "'"
            SavInto.ExecuteNonQuery()
            Conn.Close()
            Reg.regwrite("HKCU\Reg", "ok", "REG_SZ")
            MsgBox("Modification Réussie !", MsgBoxStyle.Information)
            MsgBox("Il est primordial de se souvenir de [Nom d'utlisateur] et [mot de passe] " & vbCrLf & "[Nom d'utilisateur] :   " & txtUser.Text & vbCrLf & "[Mot de passe] :    " & txtPassword.Text)


        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
        
        Try
            
            Reg.regread("HKCU\frmPrint")
        Catch ex As Exception
            Reg.regwrite("HKCU\frmPrint", 1, "REG_SZ")
            Reg.regwrite("HKCU\frmLogo", 1, "REG_SZ")
        End Try

        
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class