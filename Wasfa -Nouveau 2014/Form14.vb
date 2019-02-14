Imports System.Management
Imports System.Data
Imports System.Data.OleDb



Public Class frmActivation
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String = "select * from Patient"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter("select * from Ordonnance", Conn)


    Dim ConStr1 As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Info.db;Jet OLEDB:Database Password=123"
    Dim Conn1 As New OleDbConnection(ConStr1)
    Dim DataSet4 As New DataSet
    Dim SQLstr1 As String = "select * from Activation"
    Dim dtt As New DataTable
    Dim DataAdapter3 As New OleDbDataAdapter(SQLstr1, Conn1)

    Private Sub frmActivation_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Button4_Click(sender, e)
    End Sub
    Private Sub frmActivation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.BackColor = Color.Lavender
        'GroupBox3.BackColor = Color.Lavender
        If A = 1 Then
            LoginForm1.Show()
            Me.Close()
            Exit Sub
        End If
        RadioButton2.BackColor = Me.BackColor
        DataAdapter1.Fill(dt)
        DataAdapter2.Fill(dt1)
        ' If (BindingContext(dt).Count + BindingContext(dt1).Count) > 30 Then
        ' MsgBox("Un problème fatal s'est produit AX×00212 , veuillez contacter Naas Si Ahmed", MsgBoxStyle.Critical, "")
        ' End
        ' Exit Sub
        'End If
        ProgressBar1.Minimum = 1
        ProgressBar1.Maximum = 40
        Try
            ProgressBar1.Value = (BindingContext(dt).Count + BindingContext(dt1).Count)
        Catch ex As Exception

        End Try



        'txtID.Text = GetSerialBIOS()
        txtID.Text = GetVolumeSerialNumber("c")

        txtID.Focus()
        txtID.BackColor = Color.BurlyWood
        'txtCode.Text = ReturnKey(txtID.Text).Substring(0, 14)
        If (BindingContext(dt).Count + BindingContext(dt1).Count) > 25 Then
            MsgBox("Votre période d'évaluation est écoulée , veuillez activer le programme ", MsgBoxStyle.Exclamation, "")
            txtCode.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = False


            RadioButton2.Enabled = False
            RadioButton1.Checked = True
            Exit Sub
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Reg As Object
        Reg = CreateObject("wscript.shell")


        
        Dim zz
        Try
            zz = Reg.regread("HKCU\Reg")




        Catch ex As Exception

            B = 1
        End Try




        If RadioButton1.Checked = True Then
            If Trim(txtCode.Text) = ReturnKey(txtID.Text).Substring(0, 14) Then
                MsgBox("Félicitation ! " & vbCrLf & _
                       "" & vbCrLf & _
                       "votre clé d'activation est correcte" & vbCrLf & _
                       "vous allez bénéficier de toutes les fonctionnalités " & vbCrLf & _
                       "du programme d'une façon permanente" & vbCrLf & _
                       "veuillez SVP garder cette clé comme une preuve d'achat", , "")


                Reg.regwrite("HKCU\Software\NaasSiAhmed", Trim(txtCode.Text), "REG_SZ")
                A = 1


                '85888888888888888888888
                
                
                '////////////////////////////////////
                Try





                    Dim SavInto As New OleDb.OleDbCommand
                    SavInto.Connection = Conn1
                    SavInto.CommandType = CommandType.Text


                    SavInto.CommandText = "update Activation set Code='" & Trim(txtCode.Text) & "'"

                    Conn1.Open()
                    SavInto.ExecuteNonQuery()
                    Conn1.Close()



                Catch ex As Exception

                    MsgBox("Une erreur !", MsgBoxStyle.Critical)

                End Try


                If B = 1 Then
                    Reg.regwrite("HKCU\a1", "08", "REG_SZ")
                    Reg.regwrite("HKCU\a2", "00", "REG_SZ")
                    Reg.regwrite("HKCU\b1", "12", "REG_SZ")
                    Reg.regwrite("HKCU\b2", "00", "REG_SZ")
                    Reg.regwrite("HKCU\c1", "14", "REG_SZ")
                    Reg.regwrite("HKCU\c2", "00", "REG_SZ")
                    Reg.regwrite("HKCU\d1", "17", "REG_SZ")
                    Reg.regwrite("HKCU\d2", "00", "REG_SZ")
                    Reg.regwrite("HKCU\e", "C'est l'heure ! ", "REG_SZ")

                    Reg.regwrite("HKCU\frmPrint", 1, "REG_SZ")
                    Reg.regwrite("HKCU\frmLogo", 1, "REG_SZ")

                    MDIParent1.Show()
                Else
                    LoginForm1.Show()
                End If



                Me.Close()
            Else
                MsgBox("Erreur ! , la clé d'activation n'est pas valide" & vbCrLf & _
                       "" & vbCrLf & _
                       "Si vous n'avez pas une clé d'activation " & vbCrLf & _
                       "vous pouvez demander une clé à partir d'ici" & vbCrLf & _
                       "E.Mail :  Naas.Si.Ahmed@gmail.com " & vbCrLf & _
                       "Tél : 0670.45.64.00  /  0553.30.98.13 " & vbCrLf & _
                       "" & vbCrLf & _
                       "Si vous avez déjà une clé, veuillez contacter Naas Si Ahmed immédiatement", MsgBoxStyle.Critical)
                A = 0
            End If
        End If

        If RadioButton2.Checked = True Then
            A = 0
            If B = 1 Then
                MDIParent1.Show()
            Else
                LoginForm1.Show()
            End If

            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmAbout.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Le code d'activation ne peut pas être obtenu sauf en cas d'achat" & vbCrLf & "Après celle opération vous allez recevoir une clé unique" & vbCrLf & "qui rend le programme actif à vie" & vbCrLf & "La clé d'activation n'est disponible que chez Naas Si Ahmed Company" & vbCrLf & "E.Mail : Naas.Si.Ahmed@gmail.com" & vbCrLf & "Tél : 0553.30.98.13 / 0670.45.64.00" & vbCrLf & "Naas Si Ahmed n'a aucune résponsabilité , si vous avez eu votre clé d'ailleurs", MsgBoxStyle.Information, "")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("J'ai une licence légale , et je n'arrive pas à activez le programme ?" & vbCrLf & "--------------------------------" & vbCrLf & "Prière de contacter Naas Si Ahmed en expliquant votre procedure d'achat" & vbCrLf & "votre problème sera réglé le plus tôt possible" & vbCrLf & " " & vbCrLf & "Je n'ai aucune licence ? " & vbCrLf & "--------------------------------" & vbCrLf & "Dans ce cas vous ne pouvez pas utiliser le programme" & vbCrLf & "que dans le mode d'évaluation ")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MsgBox("C'est un numéro de série unique représentant votre machine, et qui sera utilisé pour obtenir la clé d'activation")
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        RadioButton1.Checked = False
        'RadioButton2.BackColor = Color.Lavender
        'GroupBox2.BackColor = Color.Gray
        'GroupBox3.BackColor = Color.Lavender
        RadioButton2.Checked = True
        txtCode.Enabled = False
        Label1.Enabled = False
        Label2.Enabled = True
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        RadioButton2.Checked = False
        '  RadioButton2.BackColor = Color.Gray
        ' GroupBox3.BackColor = Color.Gray
        'GroupBox2.BackColor = Color.Lavender
        RadioButton1.Checked = True
        txtCode.Enabled = True
        Label1.Enabled = True
        Label2.Enabled = False
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID.Click
        
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub
End Class