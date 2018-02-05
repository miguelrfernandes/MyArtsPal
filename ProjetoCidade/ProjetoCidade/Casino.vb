Public Class Casino

    Private Sub bCasinoVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bVoltar.Click
        Me.Hide()
        Cidade.Show()
    End Sub

    Private Sub bRoleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRoleta.Click
        Me.Hide()
        Roleta.Show()
    End Sub

End Class