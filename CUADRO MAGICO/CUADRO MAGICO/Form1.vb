Public Class Form1
    Dim a, b, c, d, e, f, g, h As Integer
    Dim n As Integer = 0
    Dim nums(10) As System.Object
    Dim i As Integer = 1
    Private Sub gb1a(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e1.Click, e2.Click, e3.Click, e4.Click, e5.Click, e6.Click, e7.Click, e8.Click, e9.Click
        If sender.text = "" And n > 0 Then
            sender.text = n
            nums(CInt(sender.text)).enabled = False

        End If
        If sender.text <> "" And n = 0 Then
            nums(CInt(sender.text)).enabled = True
            sender.text = ""
        End If
        If sender.text <> "" And n > 0 Then
            nums(CInt(sender.text)).enabled = True
            sender.text = n
            nums(CInt(sender.text)).enabled = True
            sender.text = n
            nums(CInt(sender.text)).enabled = False
        End If
        n = 0
        For Each obj In gb2.Controls
            comprobar()
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 1
        For Each obj In gb2.Controls
            i = CInt(obj.text)
            nums(i) = obj

        Next
    End Sub

    Private Sub gb2_Enter_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l1.Click, l2.Click, l3.Click, l4.Click, l5.Click, l6.Click, l7.Click, l8.Click, l9.Click
        n = sender.text
    End Sub
    Public Sub comprobar()
        a = CInt("e1.Text + e2.Text + e3.Text")
        b = CInt("e4.Text + e5.Text + e6.Text")
        c = CInt("e7.Text + e8.Text + e9.Text")
        d = CInt("e1.Text + e4.Text + e7.Text")
        e = CInt("e2.Text + e5.Text + e8.Text")
        f = CInt("e3.Text + e6.Text + e9.Text")
        g = CInt("e1.Text + e5.Text + e9.Text")
        h = CInt("e3.Text + e5.Text + e7.Text")
        If a = b And a = c And a = d And a = e And a = f And a = g And a = h Then
            MsgBox("win")
        Else
            MsgBox("vuelvelo a intentar")
        End If
    End Sub

    Private Sub gb2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb2.Enter

    End Sub

    Private Sub e7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e7.Click

    End Sub

    Private Sub e1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e1.Click

    End Sub

    Private Sub gb1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb1.Enter

    End Sub

    Private Sub l4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l4.Click

    End Sub

    Private Sub e2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e2.Click

    End Sub
End Class
