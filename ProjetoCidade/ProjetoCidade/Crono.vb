Imports System
Imports System.IO

Public Class Crono
    Dim path As String = Directory.GetCurrentDirectory()

    Dim selecionado As Integer = -1
    Dim numartista1 As Integer = 0
    Dim numartista2 As Integer = 1
    Dim numartista3 As Integer = 2
    Dim numartista4 As Integer = 3

    Dim correto() As Integer = {0, 0, 0, 0}

    Dim contadordeartistas As Integer = 0

    Dim registo(11) As Integer

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click, FecharToolStripMenuItem.Click
        Me.Hide()
        Cidade.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        cores(1)
        selecionado = numartista1
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        cores(2)
        selecionado = numartista2
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        cores(3)
        selecionado = numartista3
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        cores(4)
        selecionado = numartista4
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Oh não!" + vbNewLine + "O Francisco riscou a data de todos os quadros. Consegues associar corretamente a data a cada obra?")



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

        Label1.Show()
        Label2.Show()


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
                PictureBox1.BackColor = Color.Green
                correto(0) = 1
                contadordeartistas += 1
                Button2.Hide()
                If (contadordeartistas = 4) Then
                    contadordeartistas = 0
                    mudarquadro(1)
                    mudarquadro(2)
                    mudarquadro(3)
                    mudarquadro(4)
                End If
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (selecionado = -1) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista2) Then
                MsgBox("Correto")
                PictureBox2.BackColor = Color.Green
                correto(1) = 1
                contadordeartistas += 1
                Button3.Hide()
                If (contadordeartistas = 4) Then
                    contadordeartistas = 0
                    mudarquadro(1)
                    mudarquadro(2)
                    mudarquadro(3)
                    mudarquadro(4)
                End If
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (selecionado = -1) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista3) Then
                MsgBox("Correto")
                PictureBox3.BackColor = Color.Green
                correto(2) = 1
                contadordeartistas += 1
                Button4.Hide()
                If (contadordeartistas = 4) Then
                    contadordeartistas = 0
                    mudarquadro(1)
                    mudarquadro(2)
                    mudarquadro(3)
                    mudarquadro(4)
                End If
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (selecionado = -1) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista4) Then
                MsgBox("Correto")
                PictureBox4.BackColor = Color.Green
                correto(3) = 1
                contadordeartistas += 1
                Button5.Hide()
                If (contadordeartistas = 4) Then
                    contadordeartistas = 0
                    mudarquadro(1)
                    mudarquadro(2)
                    mudarquadro(3)
                    mudarquadro(4)
                End If
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

  
    Private Sub cores(ByVal quadroselecionado As Integer)
        If (correto(0) = 0) Then
            PictureBox1.BackColor = Color.Gray
        Else
            PictureBox1.BackColor = Color.Green
        End If
        If (correto(1) = 0) Then
            PictureBox2.BackColor = Color.Gray
        Else
            PictureBox2.BackColor = Color.Green
        End If
        If (correto(2) = 0) Then
            PictureBox3.BackColor = Color.Gray
        Else
            PictureBox3.BackColor = Color.Green
        End If
        If (correto(3) = 0) Then
            PictureBox4.BackColor = Color.Gray
        Else
            PictureBox4.BackColor = Color.Green
        End If


        Select Case quadroselecionado
            Case 1
                PictureBox1.BackColor = Color.White
            Case 2
                PictureBox2.BackColor = Color.White
            Case 3
                PictureBox3.BackColor = Color.White
            Case 4
                PictureBox4.BackColor = Color.White
        End Select

    End Sub


    Private Sub mudarquadro(ByVal quadro As Integer)

        For i As Integer = 0 To 3
            correto(i) = 0
        Next

        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray


        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()


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
        Dim posartista As Integer = (((Data - 1000) * 917) / 1000) + 21
        FileClose(1)



        Select Case quadro
            Case 1
                PictureBox1.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button2.Text = data
                Button2.Location = New Point(posartista, 655)
                If (Button2.Bounds.IntersectsWith(Button3.Bounds) Or Button2.Bounds.IntersectsWith(Button4.Bounds) Or Button2.Bounds.IntersectsWith(Button5.Bounds)) Then
                    Button2.Location = New Point(posartista, 685)
                    If (Button2.Bounds.IntersectsWith(Button3.Bounds) Or Button2.Bounds.IntersectsWith(Button4.Bounds) Or Button2.Bounds.IntersectsWith(Button5.Bounds)) Then
                        Button2.Location = New Point(posartista, 715)
                    End If
                End If
                numartista1 = numartista
            Case 2
                PictureBox2.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button3.Text = data
                Button3.Location = New Point(posartista, 655)
                If (Button3.Bounds.IntersectsWith(Button2.Bounds) Or Button3.Bounds.IntersectsWith(Button4.Bounds) Or Button3.Bounds.IntersectsWith(Button5.Bounds)) Then
                    Button3.Location = New Point(posartista, 685)
                    If (Button3.Bounds.IntersectsWith(Button2.Bounds) Or Button3.Bounds.IntersectsWith(Button4.Bounds) Or Button3.Bounds.IntersectsWith(Button5.Bounds)) Then
                        Button3.Location = New Point(posartista, 715)
                    End If
                End If
                numartista2 = numartista
            Case 3
                PictureBox3.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button4.Text = data
                Button4.Location = New Point(posartista, 655)
                If (Button4.Bounds.IntersectsWith(Button3.Bounds) Or Button4.Bounds.IntersectsWith(Button2.Bounds) Or Button4.Bounds.IntersectsWith(Button5.Bounds)) Then
                    Button4.Location = New Point(posartista, 685)
                    If (Button4.Bounds.IntersectsWith(Button3.Bounds) Or Button4.Bounds.IntersectsWith(Button2.Bounds) Or Button4.Bounds.IntersectsWith(Button5.Bounds)) Then
                        Button4.Location = New Point(posartista, 715)
                    End If
                End If
                numartista3 = numartista
            Case 4
                PictureBox4.Image = Image.FromFile(path & "\artistas\" & numartista & ".jpg")
                Button5.Text = data
                Button5.Location = New Point(posartista, 655)
                If (Button5.Bounds.IntersectsWith(Button3.Bounds) Or Button5.Bounds.IntersectsWith(Button4.Bounds) Or Button5.Bounds.IntersectsWith(Button2.Bounds)) Then
                    Button5.Location = New Point(posartista, 685)
                    If (Button5.Bounds.IntersectsWith(Button3.Bounds) Or Button5.Bounds.IntersectsWith(Button4.Bounds) Or Button5.Bounds.IntersectsWith(Button2.Bounds)) Then
                        Button5.Location = New Point(posartista, 715)
                    End If
                End If
                numartista4 = numartista
        End Select
    End Sub
End Class