Public Class frmSplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value = 100 Then
            Form15.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class