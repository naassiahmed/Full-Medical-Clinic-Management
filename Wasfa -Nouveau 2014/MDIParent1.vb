Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class MDIParent1
    Dim TimerStop As Integer = 0
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Info.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet

    Dim SQLstr As String = "select * from RendezVous"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter()

    Dim ConStr1 As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn1 As New OleDbConnection(ConStr1)
    Dim dataSet3 As New DataSet

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles Ordonnance.Click, NewWindowToolStripMenuItem.Click
        frmPatient.Show()
        frmPatient.TextBox1.Focus()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles Patient.Click
        frmPatient.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim A
        A = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If A = vbYes Then End


    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        frmChrono.Show()
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        frmMemo.Show()
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        frmSettings.Show()
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub



    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If GetVolumeSerialNumber("c") <> "8C9A9B86" Then
        ' Dim cc
        ' cc = InputBox("Donner une clé :")
        ' If (cc <> "dryousfi") Then
        'MsgBox("Erreur, votre système est infecté", MsgBoxStyle.Critical)
        'End
        'End If
        'End If

        ' If GetVolumeSerialNumber("c") <> "4ABCA11E0" Then
        'MsgBox(" Erreur")
        'End If

        Randomize()

        Dim aa
        DataAdapter1 = New OleDbDataAdapter("select * from RendezVous where DateR ='" & DateAdd(DateInterval.Day, 1, Date.Now.Date) & "' and Priorite = 10", Conn)
        DataAdapter1.Fill(dt)


        If BindingContext(dt).Count <> 0 Then
            TextBox1.Text = TextBox1.Text & vbCrLf & "#  Vous avez des rendez-vous demain"
            aa = MsgBox("Vous avez      " & BindingContext(dt).Count.ToString & "       rendez-vous demain , voulez-vous le(s) consulter  maintenat ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then
                frmRendezVous.Show()
                frmRendezVous.Focus()
            End If


        End If

        dt.Clear()
        DataAdapter1 = New OleDbDataAdapter("select * from RendezVous where DateR ='" & Date.Now.Date & "'", Conn)
        DataAdapter1.Fill(dt)
        If BindingContext(dt).Count <> 0 Then
            TextBox1.Text = TextBox1.Text & vbCrLf & "#  Vous avez des rendez-vous aujourd'hui"
            aa = MsgBox("Vous avez       " & BindingContext(dt).Count.ToString & "     rendez-vous aujourd'hui , voulez-vous le(s) consulter maintenant ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then
                frmRendezVous.Show()
                frmRendezVous.Focus()
            End If


        End If

        dt.Clear()
        Dim b As String
        b = (Date.Now.TimeOfDay.Hours & ":" & Date.Now.TimeOfDay.Minutes)

        DataAdapter1 = New OleDbDataAdapter("select * from Memos where MDate ='" & Date.Now.Date & "' and Heure like '%" & b & "%'", Conn)
        DataAdapter1.Fill(dt)

        If BindingContext(dt).Count <> 0 Then

            aa = MsgBox("Vous avez     " & BindingContext(dt).Count.ToString & "      mémos , voulez vous le(s) voir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            TextBox1.Text = TextBox1.Text & vbCrLf & "#  Vous avez des mémos"
            If aa = vbYes Then
                frmMemo.Show()
            End If
        End If
        ShowTimeUp()

        Dim Reg As Object
        Reg = CreateObject("wscript.shell")
        Dim zz
        Try
            zz = Reg.regread("HKCU\Reg")




        Catch ex As Exception

            frmMedecin.Show()
            frmMedecin.Focus()
        End Try
    End Sub
    Sub ShowTimeUp()
        On Error Resume Next
        Dim Reg As Object
        Reg = CreateObject("wscript.shell")
        Dim h1, h2, h3, h4 As String

        h1 = Reg.regread("HKCU\a1") & ":" & Reg.regread("HKCU\a2")
        h2 = Reg.regread("HKCU\b1") & ":" & Reg.regread("HKCU\b2")
        h3 = Reg.regread("HKCU\c1") & ":" & Reg.regread("HKCU\c2")
        h4 = Reg.regread("HKCU\d1") & ":" & Reg.regread("HKCU\d2")

        txtHeureSortieR1 = h2
        txtHeureSortieR2 = h4
        
        Dim A1, A2, A3, A4 As Integer
        Dim K1, K2, K3, K4 As Integer
        Dim a, b, c, d As String
        Dim Message As String
        A1 = Reg.regread("HKCU\b1")
        A2 = Reg.regread("HKCU\b2")
        A3 = Reg.regread("HKCU\d1")

        A4 = Reg.regread("HKCU\d2")

        If A2 < 10 Then
            K1 = A1 - 1
            If K1 < 10 Then
                a = "0" & Convert.ToString(K1).ToString

            Else
                a = K1

            End If
            K2 = 60 - (10 - A2)
            b = K2
        Else

            K1 = A1
            a = K1
            K2 = A2 - 10
            If a < 10 Then a = "0" & a
            If K2 < 10 Then

                b = "0" & Convert.ToString(K2).ToString

            Else
                b = K2
            End If
        End If



        If A4 < 10 Then
            K3 = A3 - 1
            If K3 < 10 Then
                c = "0" & Convert.ToString(K3).ToString
            Else
                c = K3
            End If
            K4 = 60 - (10 - A4)
            d = K4
        Else


            K3 = A3
            c = K3
            K4 = A4 - 10
            If c < 10 Then c = "0" & c
            If K4 < 10 Then
                d = "0" & Convert.ToString(K4).ToString
            Else
                d = K4
            End If
        End If
        Message = Reg.regread("HKCU\e")
        Dim txtHeure As String

        txtHeure = Date.Now.TimeOfDay.ToString
        txtHeure = (Mid(txtHeure, 1, 5))



        txtHeureSortie1 = a & ":" & b
        txtHeureSortie2 = c & ":" & d
        '        MsgBox(txtHeureSortie1 & vbCrLf & txtHeureSortie2 & vbCrLf & txtHeure)
        '       If Trim(txtHeure) = Trim(txtHeureSortie1) Or Trim(txtHeure) = Trim(txtHeureSortie2) Then
        'MsgBox(Message)
        'End If
    End Sub
    Private Sub ToolStripSeparator10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator10.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Med.Click
        frmMed.Show()
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dose.Click
        frmDose.Show()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RendezVous.Click
        frmRendezVous.Show()
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Memo.Click
        frmMemo.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Medecin.Click
        frmMedecin.Show()
    End Sub

    Private Sub Sortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sortir.Click
        frmActivation.Close()
        End

    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        frmAbout.Show()
    End Sub

    Private Sub Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settings.Click
        frmSettings.Show()
    End Sub

    Private Sub Horloge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horloge.Click
        frmChrono.Show()
    End Sub


    Private Sub Activation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Activation.Click
        If A <> 1 Then
            frmActivation.Show()
            Me.Hide()
        Else
            MsgBox("ID : " & GetVolumeSerialNumber("c") & vbCrLf & "Clé : " & ReturnKey(GetSerialBIOS()).Substring(0, 14))
        End If
    End Sub

    Private Sub Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find.Click
        ShowTimeUp()

    End Sub

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub NouveauPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauPatientToolStripMenuItem.Click
        frmPatient.Show()
    End Sub

    Private Sub NouvelleOrdonnanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleOrdonnanceToolStripMenuItem.Click
        frmOrdonnance.Show()
    End Sub

    Private Sub GestionDesRendezvousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesRendezvousToolStripMenuItem.Click
        frmRendezVous.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmMed.Show()
    End Sub

    Private Sub GestionDesPosologiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesPosologiesToolStripMenuItem.Click
        frmDose.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim a As New Random()
        Dim b(30) As Color

        b(0) = Color.DodgerBlue

        b(1) = Color.Crimson
        b(2) = Color.DarkOliveGreen
        b(3) = Color.BlueViolet
        b(4) = Color.DarkOrange
        b(5) = Color.DarkOrchid
        b(6) = Color.DarkMagenta
        b(7) = Color.DarkSeaGreen
        b(8) = Color.DarkSalmon
        b(9) = Color.DarkSlateGray
        b(10) = Color.DarkGreen
        b(11) = Color.ForestGreen
        b(12) = Color.GhostWhite
        b(13) = Color.Ivory
        b(14) = Color.Honeydew
        b(15) = Color.MediumSeaGreen
        b(16) = Color.Green
        b(17) = Color.PaleGreen
        b(18) = Color.LightGray
        b(19) = Color.Linen
        b(20) = Color.DarkTurquoise
        b(21) = Color.Gold
        b(22) = Color.DarkSalmon
        b(23) = Color.Chartreuse
        b(24) = Color.GhostWhite
        b(25) = Color.MediumTurquoise
        b(26) = Color.Khaki
        b(27) = Color.LightCoral
        b(28) = Color.Indigo
        b(29) = Color.SteelBlue
        b(30) = Color.Azure

        If TextBox1.Text <> "Informations :" Then
            Button1.Show()
            TextBox1.BackColor = b(a.Next(30))
        Else
            Button1.Hide()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(TextBox1.Text)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim txtHeure, Message As String
        Dim Reg As Object

        Reg = CreateObject("wscript.shell")
        txtHeure = Date.Now.TimeOfDay.ToString
        txtHeure = (Mid(txtHeure, 1, 5))
        Message = Reg.regread("HKCU\e")

        If TimerStop = 0 Then


            If Trim(txtHeure) = Trim(txtHeureSortie1) Or Trim(txtHeure) = Trim(txtHeureSortie2) Then
                txtHeure = "aa"
                Timer2.Interval = 6000000
                MsgBox("Il vous reste 10 minutes :  " & vbCrLf & "" & vbCrLf & Message)
                TextBox1.Text = TextBox1.Text & vbCrLf & "Il vous reste 10 minutes pour partir !"
                Button1.Show()

                TimerStop = 1


            End If
        Else
            Timer2.Stop()
        End If


        If Trim(txtHeure) = Trim(txtHeureSortieR1) Or Trim(txtHeure) = Trim(txtHeureSortieR2) Then
            txtHeure = "aa"
            Timer2.Interval = 6000000
            MsgBox(Message)
            TextBox1.Text = TextBox1.Text & vbCrLf & "C'est l'heure !"
            Button1.Show()

            TimerStop = 1


        End If
        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        On Error Resume Next
        If B = 1 Then
            frmMedecin.Focus()

            '    Timer3.Interval = 90000000
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SaveFileDialog1.FileName = "Arch " + Now.Date + ".db"



        If Not SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            FileCopy(Application.StartupPath & "\data\Data.db", SaveFileDialog1.FileName.ToString & "1")
            FileCopy(Application.StartupPath & "\data\Info.db", SaveFileDialog1.FileName.ToString & "2")
            FileCopy(Application.StartupPath & "\data\Med.db", SaveFileDialog1.FileName.ToString & "3")

        End If


    End Sub

    Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class
