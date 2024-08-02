Public Class Form1

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim clave As String

        clave = tbx_clave.Text

        If (clave = "mekuto") Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("Clave incorrecta", MsgBoxStyle.Critical, "")

        End If
    End Sub
End Class
