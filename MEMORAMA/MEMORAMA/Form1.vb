Public Class Form1
    Dim ob1, ob2 As System.Object
    Dim c As Boolean = True
    Dim w As Integer = 0
    Dim w1 As Integer = 0
    Dim p As Integer
    Dim a As Integer = 0
    Dim azar As New Random()
    Public Sub accion()
        Dim vt(24) As Integer
        Dim i, p As Integer
        For i = 1 To 12
            p = azar.Next(24)
            Do While vt(p) <> 0
                p = azar.Next(24)
            Loop
            vt(p) = i
            p = azar.Next(24)
            Do While vt(p) <> 0
                p = azar.Next(24)
            Loop
            vt(p) = i
        Next
        i = 0
        For Each obj In gb1.controls
            obj.tag = vt(i)
            i += 1
        Next
    End Sub
    Private Sub v(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pi1.Click, pi2.Click, pi3.Click, pi4.Click, pi5.Click, pi6.Click, pi7.Click, pi8.Click, pi9.Click, pi10.Click, pi11.Click, pi12.Click, pi13.Click, pi14.Click, pi15.Click, pi16.Click, pi17.Click, pi18.Click, pi19.Click, pi20.Click, pi21.Click, pi23.Click, pi24.Click
        sender.image = ima.Images(CInt(sender.tag))

        If c = True Then
            ob1 = sender
            c = False
        ElseIf ob1.tag = sender.tag Then
            w = w + 1
            t1.Text = w
            ob2 = sender
            c = True
            tiempo.Enabled = False
        Else
            ob2 = sender
            w1 = w1 + 1
            t2.Text = w1
            tiempo.Enabled = True
        End If
        a = CInt(t1.Text)
        If a = 12 Then
            p = CInt(t2.Text)
            Select Case p
                Case 1 To 5
                    MsgBox("exelente")
                Case 6 To 8
                    MsgBox("moderado")
                Case Else
                    MsgBox("muy mal sigue practicando")
            End Select

        End If
    End Sub


    Private Sub tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo.Tick

        ob1.image = ima.Images(0)
        ob2.image = ima.Images(0)
        c = True
        tiempo.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        accion()
        For Each ob In gb1.Controls
            ob.image = ima.Images(0)
        Next
        c = True
        w = 0
        w1 = 0
        t1.Text = 0
        t2.Text = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  My.Computer.Audio.Play(My.Resources.magic, AudioPlayMode.BackgroundLoop)
        accion()
        For Each ob In gb1.Controls
            ob.image = ima.Images(0)
        Next
    End Sub

    Private Sub aciertos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aciertos.Click

    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim RUTA As String
        OFD1.ShowDialog()
        RUTA = OFD1.FileName
        MsgBox(RUTA)
        MP.URL = RUTA
        MP.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MP.Ctlcontrols.pause()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MP.Ctlcontrols.play()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MP.Ctlcontrols.stop()
    End Sub

    Private Sub OFD1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFD1.FileOk

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub pi6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pi6.Click

    End Sub

    Private Sub gb1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb1.Enter

    End Sub

    Private Sub pi1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pi1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MP_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP.Enter

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MP.settings.volume += 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MP.settings.volume -= 1
    End Sub
End Class
