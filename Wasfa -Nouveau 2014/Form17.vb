Imports System.Data.OleDb

Public Class frmCertificat
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Data.db;Jet OLEDB:Database Password=123"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim DataSet3 As New DataSet
    Dim SQLstr As String = "select * from TableCertificat"
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter()
    Private Sub Logo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Logo6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Logo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Logo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Logo5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Logo4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub txtNomFr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtSpec2Ar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtSpec1Ar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtTypeAr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtSpec2Fr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtSpec1Fr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtTypeFr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtPhone1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtNomAr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Hide()
        Button1.Visible = False

        txtDateJours1.Text = DateTimePicker2.Value.Date
        txtDateJours2.Text = DateTimePicker4.Value.Date

        txtReprendre.Text = DateTimePicker3.Value.Date

        If CheckBox1.Checked = True Then txtDateJours1.Hide()
        If CheckBox2.Checked = True Then txtReprendre.Hide()
        If CheckBox3.Checked = True Then txtDateJours2.Hide()
        dDate.Text = "Djelfa le : " + DateTimePicker3.Value.Date
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        DateTimePicker3.Visible = False
        DateTimePicker4.Hide()
        CheckBox1.Hide()
        CheckBox2.Hide()
        CheckBox3.Hide()
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.Print()
        Timer1.Stop()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim Date1, Date2, Date3 As String

            If CheckBox1.Checked = True Then
                Date1 = "/"
            Else
                Date1 = DateTimePicker2.Value.Date
            End If

            If CheckBox3.Checked = True Then
                Date2 = "/"
            Else
                Date2 = DateTimePicker4.Value.Date
            End If

            If CheckBox2.Checked = True Then
                Date3 = "/"
            Else
                Date3 = DateTimePicker3.Value.Date
            End If

            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "insert into TableCertificat(txtDate,txtNom,txtDateN,Jours1,Date1,Jours2,Date2,Date3)" & _
            " values('" & DateTimePicker1.Value.Date & "','" & txtName.Text & "','" & txtDateN.Text & "','" & txtJours1.Text & "','" & Date1 & "','" & txtJours2.Text & "','" & Date2 & "','" & Date3 & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox(" (1) Un Patient a été bien ajouté", MsgBoxStyle.Information)

        Catch ex As Exception

            '    MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
    End Sub
End Class