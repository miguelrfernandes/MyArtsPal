
Public Class Cidade
    Private Sub sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sair.Click, ToolStripMenuItem1.Click
        Inicio.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, MuseuToolStripMenuItem.Click
        Me.Hide()
        Museu.Show()
    End Sub

    Private Sub RoletaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoletaToolStripMenuItem.Click, Button1.Click
        Me.Hide()
        Roleta.Show()
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()

        Crono.Show()

    End Sub
End Class

