Imports System
Imports System.IO

Public Class Crono
    Dim path As String = Directory.GetCurrentDirectory()

    Dim selecionado As Integer = -1
    Dim numartista1 As Integer = 0
    Dim numartista2 As Integer = 1
    Dim numartista3 As Integer = 2
    Dim numartista4 As Integer = 3



    Dim registo(11) As Integer

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click, FecharToolStripMenuItem.Click
        Me.Hide()
        Cidade.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray

        PictureBox1.BackColor = Color.Green

        selecionado = numartista1
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray

        PictureBox2.BackColor = Color.Green

        selecionado = numartista2
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray

        PictureBox3.BackColor = Color.Green

        selecionado = numartista3
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray

        PictureBox4.BackColor = Color.Green

        selecionado = numartista4
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        For i As Integer = 0 To 11
            registo(i) = 0
        Next

        mudarquadro(1)
        mudarquadro(2)
        mudarquadro(3)
        mudarquadro(4)


        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()

        PictureBox5.Show()



        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Show()
        PictureBox4.Show()
        Label1.Show()

        'PictureBox6.Show()

        Button1.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If (selecionado = -1) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista1) Then
                MsgBox("Correto")
                mudarquadro(1)
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If (selecionado = 0) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista2) Then
                MsgBox("Correto")
                mudarquadro(2)
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If (selecionado = 0) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista3) Then
                MsgBox("Correto")
                mudarquadro(3)
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If (selecionado = 0) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista4) Then
                MsgBox("Correto")
                mudarquadro(4)
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

  

    Private Sub mudarquadro(ByVal quadro As Integer)

        Randomize()
        Dim numartista As Integer
        numartista = Rnd() * 10

        Dim contador As Integer = 0
        For i As Integer = 0 To 11
            If (registo(i) = 1) Then
                contador += 1
            End If
            If (contador = 9) Then
                MsgBox("Acabou o Jogo!")
                For j As Integer = 0 To 11
                    registo(i) = 0
                Next
                Me.Hide()
                Cidade.Show()
                i = 20
            End If

        Next

        While registo(numartista) = 1
            numartista = Rnd() * 10
        End While
        registo(numartista) = 1


        FileOpen(1, path & "\artistas\" & numartista & ".txt", OpenMode.Input)
        Dim data As String
        Input(1, data)
        Dim posartista As Integer = (((data - 1000) * 917) / 1000) + 21
        FileClose(1)



        Select Case quadro
            Case 1
                PictureBox1.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button2.Text = data
                Button2.Location = New Point(posartista, 523)
                numartista1 = numartista
            Case 2
                PictureBox2.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button3.Text = data
                Button3.Location = New Point(posartista, 523)
                numartista2 = numartista
            Case 3
                PictureBox3.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button4.Text = data
                Button4.Location = New Point(posartista, 523)
                numartista3 = numartista
            Case 4
                PictureBox4.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button5.Text = data
                Button5.Location = New Point(posartista, 523)
                numartista4 = numartista
        End Select
    End Sub


    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class