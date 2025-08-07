Public Class Form1
    Dim a As Double
    Dim i As Integer
    Dim b As Double


    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click, b2.Click, b3.Click, b4.Click, b5.Click, b6.Click, b7.Click, b8.Click, b9.Click, b10.Click, b11.Click, b12.Click, b13.Click, b14.Click, b15.Click, b16.Click
        t1.Text = sender.text
        t2.Text = sender.tag
        t3.Focus()
    End Sub

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        a = CDbl(t2.Text) * CDbl(t3.Text)
        t4.Text = a + CDbl(t4.Text)
        li1.Items.Add(t3.Text + t1.Text + CStr(a))
        t3.Text = ""
        li2.Items.Add(CStr(a))
    End Sub
    Private Sub resta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.Click
        i = li1.SelectedIndex
        b = li2.Items(i)
        li1.Items.RemoveAt(i)
        li2.Items.RemoveAt(i)
        t4.Text = CDbl(t4.Text) - b
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 0
        i = 0
        b = 0
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = 0
        li1.Items.Clear()
        li2.Items.Clear()
    End Sub

    Private Sub li1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles li1.SelectedIndexChanged

    End Sub

    Private Sub t3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
