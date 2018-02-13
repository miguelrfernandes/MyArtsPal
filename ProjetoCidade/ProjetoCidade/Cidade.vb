Imports System
Imports System.IO
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


    Dim utilizadores(99, 2) As String
    Dim Total As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = Directory.GetCurrentDirectory()
        FileOpen(1, path & "\utilizadores.txt", OpenMode.Input)
        Input(1, Total)
        For i = 1 To Total
            Input(1, utilizadores(i, 0))
            Input(1, utilizadores(i, 1))
            Input(1, utilizadores(i, 2))
        Next i
        FileClose(1)

        Dim nomedeutilizador As String = utilizadores(utilizadornumero, 0)
        Dim avatarnumero As Integer = utilizadores(utilizadornumero, 2)
        PictureBox1.Image = Image.FromFile(path & "\avatar\" & avatarnumero & ".jpg")

        Label1.Text = utilizadornumero.ToString + "Bem-vindo " + nomedeutilizador
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()

        Crono.Show()

    End Sub
End Class

