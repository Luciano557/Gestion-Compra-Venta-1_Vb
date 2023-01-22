Public Class Inicio

    Private Sub iniciarPrograma_Click(sender As Object, e As EventArgs) Handles iniciarPrograma.Click
        Dim usuario As Form
        usuario = Login
        usuario.Show()
        Dim formlogin As Form
        formlogin = Login
        formlogin.Visible = True
        Me.Visible = False
    End Sub

End Class