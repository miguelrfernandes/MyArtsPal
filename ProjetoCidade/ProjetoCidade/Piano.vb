Imports System
Imports System.IO


Public Class Piano
    Dim path As String = Directory.GetCurrentDirectory()

    Private Sub piano(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Z Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c1" & ".wav")
            C1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.S Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c1s" & ".wav")
            CS1.Image = Image.FromFile(path & "\piano\" & "pretapremida.png")
        End If
        If e.KeyValue = Keys.X Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1" & ".wav")
            D1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.D Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1s" & ".wav")
            DS1.Image = Image.FromFile(path & "\piano\" & "pretapremida.png")
        End If
        If e.KeyValue = Keys.C Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "e1" & ".wav")
            E1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.V Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1" & ".wav")
            F1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.G Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1s" & ".wav")
            FS1.Image = Image.FromFile(path & "\piano\" & "pretapremida.png")
        End If
        If e.KeyValue = Keys.B Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1" & ".wav")
            G1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.H Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1s" & ".wav")
            GS1.Image = Image.FromFile(path & "\piano\" & "pretapremida.png")
        End If
        If e.KeyValue = Keys.N Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1" & ".wav")
            A1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.J Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1s" & ".wav")
            AS1.Image = Image.FromFile(path & "\piano\" & "pretapremida.png")
        End If
        If e.KeyValue = Keys.M Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "b1" & ".wav")
            B1.Image = Image.FromFile(path & "\piano\" & "brancapremida.gif")
        End If
        If e.KeyValue = Keys.K Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c2" & ".wav")
            CS2.Image = Image.FromFile(path & "\piano\" & "pretapremida.gif")
        End If
    End Sub

    Private Sub movestart(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Z Then
            C1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.S Then
            CS1.Image = Image.FromFile(path & "\piano\" & "preta.gif")
        End If
        If e.KeyValue = Keys.X Then
            D1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.D Then
            DS1.Image = Image.FromFile(path & "\piano\" & "preta.gif")
        End If
        If e.KeyValue = Keys.C Then
            E1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.V Then
            F1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.G Then
            FS1.Image = Image.FromFile(path & "\piano\" & "preta.gif")
        End If
        If e.KeyValue = Keys.B Then
            G1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.H Then
            GS1.Image = Image.FromFile(path & "\piano\" & "preta.gif")
        End If
        If e.KeyValue = Keys.N Then
            A1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.J Then
            AS1.Image = Image.FromFile(path & "\piano\" & "preta.gif")
        End If
        If e.KeyValue = Keys.M Then
            B1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.K Then

        End If
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        My.Computer.Audio.Play(path & "\piano\piano\" & "c1" & ".wav")
    End Sub

    Private Sub CS3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CS1.Click
        My.Computer.Audio.Play(path & "\piano\piano\" & "c1s" & ".wav")
    End Sub


    Private Sub D3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1.Click

    End Sub
End Class