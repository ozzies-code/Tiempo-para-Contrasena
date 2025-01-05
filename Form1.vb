Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MsgBox("Lo siento, se acabó su tiempo.")
        End
    End Sub

    Private Sub btnContra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContra.Click
        If txtContra.Text = "secreta" Then
            Timer1.Enabled = False
            MsgBox("¡Bienvenido al sistema!")
            End
        Else
            MsgBox("Lo siento, amigo. No sé quién es usted.")
        End If
    End Sub
End Class
