Imports System.Data.OleDb

Public Class frmPrintOtoen
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
    Private Sub frmPrintOtoen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Oreille droite")
        ComboBox1.Items.Add("Oreille gauche")
        ComboBox1.Items.Add("-----")
        ComboBox1.Items.Add("CAE")
        ComboBox1.Items.Add("Tympan")
        ComboBox1.Items.Add("Chaîne ossiculaire")
        ComboBox1.Items.Add("FDC")

        'DataAdapter2 = New OleDbDataAdapter("select * from TableOtoen where txtField='" & ComboBox1.SelectedItem.ToString & "'", Conn)
        'dt.Clear()
        'DataAdapter2.Fill(dt, "TableOtoen")
        'ComboBox2.Items.Clear()
        'DataAdapter2.Fill(dt)


        'ComboBox2.DisplayMember = "txtValue"
        'ComboBox2.DataSource = dt
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        DataAdapter2 = New OleDbDataAdapter("select * from TableOtoen where txtField='" & ComboBox1.SelectedItem.ToString & "'", Conn)
        dt.Clear()
        DataAdapter2.Fill(dt, "TableOtoen")
        ComboBox2.Items.Clear()
        DataAdapter2.Fill(dt)


        ComboBox2.DisplayMember = "txtValue"
        ComboBox2.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If ComboBox1.SelectedIndex = 0 Then
                If txtD.Text = "" Then
                    txtD.Text = ComboBox2.Text
                Else
                    txtD.Text = txtD.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 3 Then
                If txt1.Text = "" Then
                    txt1.Text = ComboBox2.Text
                Else
                    txt1.Text = txt1.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 4 Then
                If txt2.Text = "" Then
                    txt2.Text = ComboBox2.Text
                Else
                    txt2.Text = txt2.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 5 Then
                If txt3.Text = "" Then
                    txt3.Text = ComboBox2.Text
                Else
                    txt3.Text = txt3.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 6 Then
                If txt4.Text = "" Then
                    txt4.Text = ComboBox2.Text
                Else
                    txt4.Text = txt4.Text + ", " + ComboBox2.Text
                End If
            End If

        End If

        If RadioButton2.Checked = True Then
            If ComboBox1.SelectedIndex = 1 Then
                If txtG.Text = "" Then
                    txtG.Text = ComboBox2.Text
                Else
                    txtG.Text = txtG.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 3 Then
                If txt5.Text = "" Then
                    txt5.Text = ComboBox2.Text
                Else
                    txt5.Text = txt5.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 4 Then
                If txt6.Text = "" Then
                    txt6.Text = ComboBox2.Text
                Else
                    txt6.Text = txt6.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 5 Then
                If txt7.Text = "" Then
                    txt7.Text = ComboBox2.Text
                Else
                    txt7.Text = txt7.Text + ", " + ComboBox2.Text
                End If
            End If
            If ComboBox1.SelectedIndex = 6 Then
                If txt8.Text = "" Then
                    txt8.Text = ComboBox2.Text
                Else
                    txt8.Text = txt8.Text + ", " + ComboBox2.Text
                End If
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button3.Hide()
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        PrintForm1.Print()
    End Sub

    Private Sub txt8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt8.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

        
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "insert into TableOtoenData(DateIns,txtNom,txtPrenom,txtAge,CAE1,Tymp1,Ch1,FDC1,CAE2,Tymp2,Ch2,FDC2,Droite,Gauche)" & _
            " values('" & Now.Date & "','" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtAge.Text & "','" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "','" & txt5.Text & "','" & txt6.Text & "','" & txt7.Text & "','" & txt8.Text & "','" & txtD.Text & "','" & txtG.Text & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox(" (1) Un Patient a été bien ajouté", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub
End Class