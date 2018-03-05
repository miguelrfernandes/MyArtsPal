Imports System
Imports System.IO
Public Class Registar
    Dim Total As Integer
    Dim utilizadores(99, 2) As String

    Private Sub registar()
        Dim utilizador As String = tbUser.Text
        Dim password As String = tbPassword.Text
        Dim avatar As Integer = ComboBox1.SelectedIndex
        If utilizador <> "" And password <> "" And ComboBox1.SelectedIndex <> -1 Then
            Dim path As String = Directory.GetCurrentDirectory()

            'ler ficheiro
            FileOpen(1, path & "\utilizadores.txt", OpenMode.Input)
            Input(1, Total)
            For i = 1 To Total
                Input(1, utilizadores(i, 0))
                Input(1, utilizadores(i, 1))
                Input(1, utilizadores(i, 2))
            Next i
            FileClose(1)

            'escrever ficheiro
            FileOpen(1, path & "\utilizadores.txt", OpenMode.Output)
            Total += 1
            utilizadores(Total, 0) = utilizador : utilizadores(Total, 1) = password : utilizadores(Total, 2) = avatar
            WriteLine(1, Total)
            For i = 1 To Total
                WriteLine(1, utilizadores(i, 0), utilizadores(i, 1), utilizadores(i, 2))
            Next i
            FileClose(1)

            MsgBox("Utilizador registado")
        Else
            MsgBox("Erro")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, RegistarToolStripMenuItem.Click
        registar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, FecharToolStripMenuItem.Click, ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AbrirAjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ajuda.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Sobre.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim avatar As Integer = ComboBox1.SelectedIndex
        Dim path As String = Directory.GetCurrentDirectory()
        PictureBox1.Image = Image.FromFile(path & "\avatar\" & avatar & ".jpg")
    End Sub
End Class