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
        End If
        If e.KeyValue = Keys.X Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1" & ".wav")
        End If
        If e.KeyValue = Keys.D Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1s" & ".wav")
        End If
        If e.KeyValue = Keys.C Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "e1" & ".wav")
        End If
        If e.KeyValue = Keys.V Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1" & ".wav")
        End If
        If e.KeyValue = Keys.G Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1s" & ".wav")
        End If
        If e.KeyValue = Keys.B Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1" & ".wav")
        End If
        If e.KeyValue = Keys.H Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1s" & ".wav")
        End If
        If e.KeyValue = Keys.N Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1" & ".wav")
        End If
        If e.KeyValue = Keys.J Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1s" & ".wav")
        End If
        If e.KeyValue = Keys.M Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "b1" & ".wav")
        End If
        If e.KeyValue = Keys.K Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c2" & ".wav")
        End If
    End Sub

    Private Sub movestart(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Z Then
            C1.Image = Image.FromFile(path & "\piano\" & "branca.gif")
        End If
        If e.KeyValue = Keys.S Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c1s" & ".wav")
        End If
        If e.KeyValue = Keys.X Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1" & ".wav")
        End If
        If e.KeyValue = Keys.D Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1s" & ".wav")
        End If
        If e.KeyValue = Keys.C Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "e1" & ".wav")
        End If
        If e.KeyValue = Keys.V Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1" & ".wav")
        End If
        If e.KeyValue = Keys.G Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1s" & ".wav")
        End If
        If e.KeyValue = Keys.B Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1" & ".wav")
        End If
        If e.KeyValue = Keys.H Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1s" & ".wav")
        End If
        If e.KeyValue = Keys.N Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1" & ".wav")
        End If
        If e.KeyValue = Keys.J Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1s" & ".wav")
        End If
        If e.KeyValue = Keys.M Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "b1" & ".wav")
        End If
        If e.KeyValue = Keys.K Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c2" & ".wav")
        End If
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        My.Computer.Audio.Play(path & "\piano\piano\" & "c1" & ".wav")
    End Sub

    Private Sub CS3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CS3.Click
        My.Computer.Audio.Play(path & "\piano\piano\" & "c1s" & ".wav")
    End Sub


End Class