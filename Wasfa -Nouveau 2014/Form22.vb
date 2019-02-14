Imports System.Data.OleDb

Public Class frmOtoenConfig
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
    Private Sub frmOtoenConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        
            ComboBox1.Items.Add("Oreille droite")
            ComboBox1.Items.Add("Oreille gauche")
            ComboBox1.Items.Add("-----")
            ComboBox1.Items.Add("CAE")
            ComboBox1.Items.Add("Tympan")
            ComboBox1.Items.Add("Chaîne ossiculaire")
            ComboBox1.Items.Add("FDC")

            DataAdapter2 = New OleDbDataAdapter("select * from TableOtoen where txtField='" & ComboBox1.SelectedItem.ToString & "'", Conn)
            dt.Clear()
            DataAdapter2.Fill(dt, "TableOtoen")
            ComboBox2.Items.Clear()
            DataAdapter2.Fill(dt)


            ComboBox2.DisplayMember = "txtValue"
            ComboBox2.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub
    Sub LoadElements()
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
        Try
            If Trim(TextBox1.Text) = "" Then
                MsgBox("Veuillez introduire une valeur !", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            DataAdapter1 = New OleDbDataAdapter("select * from TableOtoen where txtValue='" & Trim(TextBox1.Text) & "'", Conn)
            DataAdapter1.Fill(dt1)
            '    If Me.BindingContext(dt1).Count > 0 Then
            'MsgBox("Cet élément existe déjà !", MsgBoxStyle.Exclamation, "")
            'Exit Sub
            'End If

            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into TableOtoen(txtField,txtValue)" & " values('" & ComboBox1.SelectedItem.ToString & "','" & Trim(TextBox1.Text) & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Ajout Réussi !", MsgBoxStyle.Information)
            LoadElements()
            TextBox1.Text = ""

        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class