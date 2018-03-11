Imports System
Imports System.IO
Public Class Cidade

    Private Sub sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sair.Click, ToolStripMenuItem1.Click, SairToolStripMenuItem.Click
        Inicio.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, SalaDosQuadrosToolStripMenuItem.Click
        Me.Hide()
        Museu.Show()
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

        Label1.Text = "Bem-vindo " + nomedeutilizador
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, SalaDosArtistasToolStripMenuItem.Click
        Me.Hide()

        Crono.Show()

    End Sub

    Private Sub AbrirAjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirAjudaToolStripMenuItem.Click
        Ajuda.Show()

    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, PianoToolStripMenuItem.Click
        Me.Hide()
        Piano.Show()
    End Sub
End Class

