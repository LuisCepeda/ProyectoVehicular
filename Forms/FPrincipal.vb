Public Class FPrincipal
    Private Sub FPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If p1 = True Then
            Button1.Enabled = True
        End If
        If p2 = True Then Button2.Enabled = True
        If p3 = True Then Button3.Enabled = True
        If p4 = True Then Button4.Enabled = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FConfiguracion.MdiParent = Me
        FConfiguracion.Show()
    End Sub
End Class