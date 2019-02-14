Imports System.Data.OleDb

Public Class frmCompteRendu
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String = "select * from TableOtoen"
    Dim SQLstr1 As String = "select * from TableOtoen"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter(SQLstr1, Conn)
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub TextBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        On Error Resume Next
        Dim a
        a = InputBox("Donner la taille de police : ")
        If Not a = "" Then
            TextBox1.Font = New Font(TextBox1.Font.Size, a)
        End If


        a = InputBox("Voulez-vous souligner le texte:  OUI   /   NON")
        If Not a = "" Then
            If a = "OUI" Or a = "oui" Then
                TextBox1.Font = New Font(TextBox1.Font, FontStyle.Underline)
            Else
                TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
            End If
        End If




        a = InputBox("Voulez-vous mettre le texte en gras  :  OUI   /  NON")
        If Not a = "" Then
            If a = "OUI" Or a = "oui" Then
                TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
            Else
                TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        On Error Resume Next
        Dim a
        a = InputBox("Donner la taille de police : ")
        If Not a = "" Then
            TextBox2.Font = New Font(TextBox2.Font.Size, a)
        End If


        a = InputBox("Voulez-vous souligner le texte:  OUI   /   NON")
        If Not a = "" Then
            If a = "OUI" Or a = "oui" Then
                TextBox2.Font = New Font(TextBox2.Font, FontStyle.Underline)
            Else
                TextBox2.Font = New Font(TextBox2.Font, FontStyle.Regular)
            End If
        End If




        a = InputBox("Voulez-vous mettre le texte en gras  :  OUI   /  NON")
        If Not a = "" Then
            If a = "OUI" Or a = "oui" Then
                TextBox2.Font = New Font(TextBox2.Font, FontStyle.Bold)
            Else
                TextBox2.Font = New Font(TextBox2.Font, FontStyle.Regular)
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseDoubleClick

        Try


            Dim a
            a = InputBox("Donner la taille de police : ")
            If Not a = "" Then
                TextBox3.Font = New Font(TextBox3.Font.Size, a)
            End If


            a = InputBox("Voulez-vous souligner le texte:  OUI   /   NON")
            If Not a = "" Then
                If a = "OUI" Or a = "oui" Then
                    TextBox3.Font = New Font(TextBox3.Font, FontStyle.Underline)
                Else
                    TextBox3.Font = New Font(TextBox3.Font, FontStyle.Regular)
                End If
            End If




            a = InputBox("Voulez-vous mettre le texte en gras  :  OUI   /  NON")
            If Not a = "" Then
                If a = "OUI" Or a = "oui" Then
                    TextBox3.Font = New Font(TextBox3.Font, FontStyle.Bold)
                Else
                    TextBox3.Font = New Font(TextBox3.Font, FontStyle.Regular)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        On Error Resume Next
        Dim a
        a = InputBox("Donner la taille de police : ")
        If Not a = "" Then
            txtNom.Font = New Font(txtNom.Font.Size, a)
        End If


        a = InputBox("Voulez-vous souligner le texte:  OUI   /   NON")
        If Not a = "" Then
            If a = "OUI" Or a = "oui" Then
                txtNom.Font = New Font(txtNom.Font, FontStyle.Underline)
            Else
                txtNom.Font = New Font(txtNom.Font, FontStyle.Regular)
            End If
        End If




        a = InputBox("Voulez-vous mettre le texte en gras  :  OUI   /  NON")
        If Not a = "" Then
            If a = "OUI" Or a = "oui" Then
                txtNom.Font = New Font(txtNom.Font, FontStyle.Bold)
            Else
                txtNom.Font = New Font(txtNom.Font, FontStyle.Regular)
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Hide()
        Timer1.Start()
        Button2.Visible = False
        TextBox5.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 50, 0)
        PrintForm1.Print()
        Timer1.Stop()
    End Sub

    Private Sub frmCompteRendu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SavInto As New OleDb.OleDbCommand
        SavInto.Connection = Conn
        SavInto.CommandType = CommandType.Text

        SavInto.CommandText = "insert into TableCompte(dateIns,txtNom,txtPrenom,txtAge,txt)" & _
        " values('" & Now.Date & "','" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtAge.Text & "','" & Trim(TextBox3.Text) & "')"
        Conn.Open()
        SavInto.ExecuteNonQuery()
        Conn.Close()

        MsgBox(" (1) Un Patient a été bien ajouté", MsgBoxStyle.Information)
    End Sub
End Class