Imports System
Imports System.IO


Public Class Piano
    Dim path As String = Directory.GetCurrentDirectory()

    Private Sub piano(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Z Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c1" & ".wav")
            C1.Show()
            C1.Image = Image.FromFile(path & "\piano\" & "c1.gif")
        End If
        If e.KeyValue = Keys.S Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c1s" & ".wav")
            CS1.Show()
            CS1.Image = Image.FromFile(path & "\piano\" & "cs1.gif")
        End If
        If e.KeyValue = Keys.X Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1" & ".wav")
            D1.Show()
            D1.Image = Image.FromFile(path & "\piano\" & "d1.gif")
        End If
        If e.KeyValue = Keys.D Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "d1s" & ".wav")
            DS1.Show()
            DS1.Image = Image.FromFile(path & "\piano\" & "ds1.gif")
        End If
        If e.KeyValue = Keys.C Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "e1" & ".wav")
            E1.Show()
            E1.Image = Image.FromFile(path & "\piano\" & "e1.gif")
        End If
        If e.KeyValue = Keys.V Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1" & ".wav")
            F1.Show()
            F1.Image = Image.FromFile(path & "\piano\" & "f1.gif")
        End If
        If e.KeyValue = Keys.G Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "f1s" & ".wav")
            FS1.Show()
            FS1.Image = Image.FromFile(path & "\piano\" & "fs1.gif")
        End If
        If e.KeyValue = Keys.B Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1" & ".wav")
            G1.Show()
            G1.Image = Image.FromFile(path & "\piano\" & "g1.gif")
        End If
        If e.KeyValue = Keys.H Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "g1s" & ".wav")
            GS1.Show()
            GS1.Image = Image.FromFile(path & "\piano\" & "gs1.gif")
        End If
        If e.KeyValue = Keys.N Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1" & ".wav")
            A1.Show()
            A1.Image = Image.FromFile(path & "\piano\" & "a1.gif")
        End If
        If e.KeyValue = Keys.J Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "a1s" & ".wav")
            AS1.Show()
            AS1.Image = Image.FromFile(path & "\piano\" & "as1.gif")
        End If
        If e.KeyValue = Keys.M Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "b1" & ".wav")
            B1.Show()
            B1.Image = Image.FromFile(path & "\piano\" & "b1.gif")
        End If
        If e.KeyValue = Keys.Oemcomma Then
            My.Computer.Audio.Play(path & "\piano\piano\" & "c2" & ".wav")
            C2.Show()
            C2.Image = Image.FromFile(path & "\piano\" & "c2.gif")
        End If
    End Sub

    Private Sub movestart(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Z Then
            C1.Hide()
        End If
        If e.KeyValue = Keys.S Then
            CS1.Hide()
        End If
        If e.KeyValue = Keys.X Then
            D1.Hide()
        End If
        If e.KeyValue = Keys.D Then
            DS1.Hide()
        End If
        If e.KeyValue = Keys.C Then
            E1.Hide()
        End If
        If e.KeyValue = Keys.V Then
            F1.Hide()
        End If
        If e.KeyValue = Keys.G Then
            FS1.Hide()
        End If
        If e.KeyValue = Keys.B Then
            G1.Hide()
        End If
        If e.KeyValue = Keys.H Then
            GS1.Hide()
        End If
        If e.KeyValue = Keys.N Then
            A1.Hide()
        End If
        If e.KeyValue = Keys.J Then
            AS1.Hide()
        End If
        If e.KeyValue = Keys.M Then
            B1.Hide()
        End If
        If e.KeyValue = Keys.Oemcomma Then
            C2.Hide()
        End If
    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click, SairToolStripMenuItem.Click
        Me.Close()
        Cidade.Show()
    End Sub


End Class