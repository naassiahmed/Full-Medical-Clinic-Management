Public Class frmSettings

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Reg As Object
        Reg = CreateObject("wscript.shell")
        Try
            Select Case Reg.regread("HKCU\frmPrint")
                Case 1
                    RadioButton1.Checked = True
                Case 2
                    RadioButton3.Checked = True
                Case 3
                    RadioButton2.Checked = True
            End Select
        Catch ex As Exception
            Reg.regwrite("HKCU\frmPrint", 1, "REG_SZ")
        End Try
        


        Try
            Select Case Reg.regread("HKCU\frmLogo")
                Case 1
                    r1.Checked = True
                Case 2
                    r2.Checked = True
                Case 3
                    r3.Checked = True
                Case 4
                    r4.Checked = True
                Case 5
                    r5.Checked = True
                Case 6
                    r6.Checked = True
            End Select
        Catch ex As Exception
            Reg.regwrite("HKCU\frmLogo", 1, "REG_SZ")
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Reg As Object
        Reg = CreateObject("wscript.shell")

        If RadioButton1.Checked = True Then
            Reg.regwrite("HKCU\frmPrint", 1, "REG_SZ")
        End If

        If RadioButton3.Checked = True Then
            Reg.regwrite("HKCU\frmPrint", 2, "REG_SZ")
        End If

        If RadioButton2.Checked = True Then
            Reg.regwrite("HKCU\frmPrint", 3, "REG_SZ")
        End If



        If r1.Checked = True Then
            Reg.regwrite("HKCU\frmLogo", 1, "REG_SZ")
        End If

        If r2.Checked = True Then
            Reg.regwrite("HKCU\frmLogo", 2, "REG_SZ")
        End If

        If r3.Checked = True Then
            Reg.regwrite("HKCU\frmLogo", 3, "REG_SZ")
        End If

        If r4.Checked = True Then
            Reg.regwrite("HKCU\frmLogo", 4, "REG_SZ")
        End If

        If r5.Checked = True Then
            Reg.regwrite("HKCU\frmLogo", 5, "REG_SZ")
        End If

        If r6.Checked = True Then
            Reg.regwrite("HKCU\frmLogo", 6, "REG_SZ")
        End If

        MsgBox("Modification réussie !", MsgBoxStyle.Information, "")
    End Sub
End Class