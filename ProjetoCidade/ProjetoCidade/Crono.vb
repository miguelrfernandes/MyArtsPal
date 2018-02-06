Imports System
Imports System.IO

Public Class Crono
    Dim path As String = Directory.GetCurrentDirectory()

    Dim selecionado As Integer = 0
    Dim numartista1 As Integer = 0
    Dim numartista2 As Integer = 1
    Dim numartista3 As Integer = 2
    Dim numartista4 As Integer = 3



    Dim registo(9) As Integer

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click, FecharToolStripMenuItem.Click
        Me.Hide()
        Cidade.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        'grafico1.Clear(Color.White)
        'grafico2.Clear(Color.White)
        'grafico3.Clear(Color.White)
        'grafico4.Clear(Color.White)

        'Dim caneta As New Pen(Color.Green, 2.0)
        'grafico1.DrawRectangle(caneta, New Rectangle(PictureBox1.Location, New Size(227, 450)))
        'caneta.Dispose()

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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim grafico As Graphics = Me.CreateGraphics

        Randomize()

        For i As Integer = 0 To 9
            registo(i) = 0
        Next

        numartista1 = Rnd() * 3
        registo(numartista1) = 1
        While registo(numartista2) = 1
            numartista2 = Rnd() * 9
        End While
        registo(numartista2) = 1
        While registo(numartista3) = 1
            numartista3 = Rnd() * 9
        End While
        registo(numartista3) = 1
        While registo(numartista4) = 1
            numartista4 = Rnd() * 9
        End While
        registo(numartista4) = 1

        FileOpen(1, path & "\artistas\" & numartista1 & ".txt", OpenMode.Input)
        Dim data1 As String
        Input(1, data1)
        data1 = 1500 ' apagar
        Label2.Text = data1
        Dim posartista1 As Integer = ((data1 - 1000) * 1024) / 1000
        'MsgBox(posartista1) 'apagar
        FileClose(1)

        FileOpen(1, path & "\artistas\" & numartista2 & ".txt", OpenMode.Input)
        Dim data2 As String
        Input(1, data2)
        data2 = 1700 ' apagar
        Label3.Text = data2
        Dim posartista2 As Integer = ((data2 - 1000) * 1024) / 1000
        'MsgBox(posartista2) 'apagar
        'posartista2 = 200 ' apagar
        FileClose(1)

        FileOpen(1, path & "\artistas\" & numartista3 & ".txt", OpenMode.Input)
        Dim data3 As String
        Input(1, data3)
        data3 = 1300 ' apagar
        Dim posartista3 As Integer = (data3 - 1000) * 1024 / 1000
        Label4.Text = data3
        'MsgBox(posartista3) 'apagar
        'posartista3 = 400 ' apagar
        FileClose(1)

        FileOpen(1, path & "\artistas\" & numartista4 & ".txt", OpenMode.Input)
        Dim data4 As String
        Input(1, data4)
        data4 = 1900 ' apagar
        Dim posartista4 As Integer = (data4 - 1000) * 1024 / 1000
        Label5.Text = data4
        'MsgBox(posartista4) 'apagar
        'posartista4 = 750 ' apagar
        FileClose(1)


        PictureBox1.Image = Image.FromFile(path & "\artistas\" & numartista1 & ".jpg")
        PictureBox2.Image = Image.FromFile(path & "\artistas\" & numartista2 & ".jpg")
        PictureBox3.Image = Image.FromFile(path & "\artistas\" & numartista3 & ".jpg")
        PictureBox4.Image = Image.FromFile(path & "\artistas\" & numartista4 & ".jpg")


        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()

        Button2.Text = data1
        Button2.Location = New Point(posartista1, 670)
        Button3.Text = data2
        Button3.Location = New Point(posartista2, 670)
        Button4.Text = data3
        Button4.Location = New Point(posartista3, 670)
        Button5.Text = data4
        Button5.Location = New Point(posartista4, 670)

        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Show()
        PictureBox4.Show()
        Label1.Show()


        Button1.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If (selecionado = 0) Then
            MsgBox("Seleciona um artista")
        Else
            If (selecionado = numartista1) Then
                MsgBox("Correto")
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
            Else
                MsgBox("Tenta de novo")
            End If
        End If
    End Sub

End Class