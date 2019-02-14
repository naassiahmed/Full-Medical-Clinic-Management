Imports System.Data.OleDb

Public Class frmCertificatPrescp
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
    Private Sub frmCertificatPrescp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Font = New Font(CheckBox1.Font, FontStyle.Underline + FontStyle.Bold)
        CheckBox1.BackColor = Color.Gainsboro





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox1.Font = CheckBox6.Font
        CheckBox1.BackColor = CheckBox6.BackColor

        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox2.Font = CheckBox6.Font
        CheckBox2.BackColor = CheckBox6.BackColor

        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox3.Font = CheckBox6.Font
        CheckBox3.BackColor = CheckBox6.BackColor

        CheckBox4.CheckState = CheckState.Unchecked
        CheckBox4.Font = CheckBox6.Font
        CheckBox4.BackColor = CheckBox6.BackColor

        CheckBox5.CheckState = CheckState.Unchecked
        CheckBox5.Font = CheckBox6.Font
        CheckBox5.BackColor = CheckBox6.BackColor
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        CheckBox2.CheckState = CheckState.Checked
        CheckBox2.Font = New Font(CheckBox2.Font, FontStyle.Underline + FontStyle.Bold)
        CheckBox2.BackColor = Color.Gainsboro
    End Sub

    Private Sub CheckBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox4.Click
        CheckBox4.CheckState = CheckState.Checked
        CheckBox4.Font = New Font(CheckBox4.Font, FontStyle.Underline + FontStyle.Bold)
        CheckBox4.BackColor = Color.Gainsboro
    End Sub

    Private Sub CheckBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        CheckBox3.CheckState = CheckState.Checked
        CheckBox3.Font = New Font(CheckBox3.Font, FontStyle.Underline + FontStyle.Bold)
        CheckBox3.BackColor = Color.Gainsboro
    End Sub

    Private Sub CheckBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox5.Click
        CheckBox5.CheckState = CheckState.Checked
        CheckBox5.Font = New Font(CheckBox5.Font, FontStyle.Underline + FontStyle.Bold)
        CheckBox5.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox10.Focus()
        Button3.Hide()
        Button1.Visible = False
        Button2.Visible = False
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.Print()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim val1, val2, val3, val4, val5
        If CheckBox1.Checked = True Then
            val1 = "1"
        Else
            val1 = "0"
        End If

        If CheckBox2.Checked = True Then
            val2 = "1"
        Else
            val2 = "0"
        End If
        If CheckBox3.Checked = True Then
            val3 = "1"
        Else
            val3 = "0"
        End If
        If CheckBox4.Checked = True Then
            val4 = "1"
        Else
            val4 = "0"
        End If
        If CheckBox5.Checked = True Then
            val5 = "1"
        Else
            val5 = "0"
        End If

        Dim SavInto As New OleDb.OleDbCommand
        SavInto.Connection = Conn
        SavInto.CommandType = CommandType.Text

        SavInto.CommandText = "insert into TableProthese(dateIns,txtNom,txtPrenom,txtAge,val1,val2,val3,val4,val5)" & _
        " values('" & Now.Date & "','" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtAge.Text & "','" & val1 & "','" & val2 & "','" & val3 & "','" & val4 & "','" & val5 & "')"
        Conn.Open()
        SavInto.ExecuteNonQuery()
        Conn.Close()

        MsgBox(" (1) Un Patient a été bien ajouté", MsgBoxStyle.Information)
    End Sub
End Class