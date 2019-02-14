Public Class frmChrono

    Private Sub frmChrono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Reg As Object
        Reg = CreateObject("wscript.shell")
        Try
            A1.Text = Reg.regread("HKCU\a1") & ":" & Reg.regread("HKCU\a2")
            A2.Text = Reg.regread("HKCU\b1") & ":" & Reg.regread("HKCU\b2")
            A3.Text = Reg.regread("HKCU\c1") & ":" & Reg.regread("HKCU\c2")
            A4.Text = Reg.regread("HKCU\d1") & ":" & Reg.regread("HKCU\d2")
            TextBox1.Text = Reg.regread("HKCU\e")
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles A1.MaskInputRejected

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Reg As Object
        Reg = CreateObject("wscript.shell")
        Dim aa1, aa2, bb1, bb2, cc1, cc2, dd1, dd2 As String
        aa1 = A1.Text.Substring(0, 2)
        aa2 = A1.Text.Substring(3)
        bb1 = A2.Text.Substring(0, 2)
        bb2 = A2.Text.Substring(3)
        cc1 = A3.Text.Substring(0, 2)
        cc2 = A3.Text.Substring(3)
        dd1 = A4.Text.Substring(0, 2)
        dd2 = A4.Text.Substring(3)

        Reg.regwrite("HKCU\a1", aa1, "REG_SZ")
        Reg.regwrite("HKCU\a2", aa2, "REG_SZ")
        Reg.regwrite("HKCU\b1", bb1, "REG_SZ")
        Reg.regwrite("HKCU\b2", bb2, "REG_SZ")
        Reg.regwrite("HKCU\c1", cc1, "REG_SZ")
        Reg.regwrite("HKCU\c2", cc2, "REG_SZ")
        Reg.regwrite("HKCU\d1", dd1, "REG_SZ")
        Reg.regwrite("HKCU\d2", dd2, "REG_SZ")
        Reg.regwrite("HKCU\e", Trim(TextBox1.Text), "REG_SZ")
        MsgBox("Informations enregistrées", MsgBoxStyle.Information, "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class