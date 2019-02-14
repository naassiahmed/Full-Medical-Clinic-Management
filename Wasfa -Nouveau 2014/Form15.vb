Imports System.Data
Imports System.Data.OleDb
Public Class Form15
    Dim ConStr1 As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\data\Info.db;Jet OLEDB:Database Password=123"
    Dim Conn1 As New OleDbConnection(ConStr1)
    Dim DataSet4 As New DataSet
    Dim SQLstr1 As String = "select * from Activation"
    Dim dtt As New DataTable
    Dim DataAdapter3 As New OleDbDataAdapter(SQLstr1, Conn1)
    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        DataAdapter3.Fill(DataSet4, "Activation")

        TextBox1.DataBindings.Add("Text", DataSet4, "Activation.code")
        '        If Trim(TextBox1.Text) = ReturnKey(GetSerialBIOS()).Substring(0, 14) Then
        If Trim(TextBox1.Text) = ReturnKey(GetVolumeSerialNumber("c")).Substring(0, 14) Then
            A = 1
            '    MDIParent1.Show()
            'frmActivation.Show()
            LoginForm1.Show()
            Me.Visible = False
            Exit Sub
        Else
            frmActivation.Show()
        End If
    End Sub
End Class