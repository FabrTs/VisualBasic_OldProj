Public Class Form1
    Private Sub money(ByVal sender, ByVal e) Handles ra1.CheckedChanged, ra2.CheckedChanged, ra3.CheckedChanged, ra4.CheckedChanged, ra5.CheckedChanged
        caj.Text = CDbl(sender.tag)
    End Sub
    Private Sub calcular(ByVal sender, ByVal e) Handles b1.Click
        t2.Text = CDbl(t1.Text) * CDbl(caj.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub calcular(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click

    End Sub
End Class
