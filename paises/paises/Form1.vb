Public Class Form1
    Dim a As Integer
    Private Sub metodowicho()
        For Each obj In gb1.Controls
            If obj.name <> "mapa" Then
                obj.visible = False
            End If
        Next
    End Sub

    Private Sub l1_SelectedIndexChangedy(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l1.SelectedIndexChanged
        t2.Text = l1.SelectedItem
        a = l1.SelectedIndex
        t3.Text = li2.Items(a)
        metodowicho()
        If t1.Text = "Japon" Then
            japon.Visible = True
        End If
        If t1.Text = "Turquia" Then
            turquia.Visible = True
        End If
        If t1.Text = "Belgica" Then
            belgica.Visible = True
        End If
        If t1.Text = "Francia" Then
            francia.Visible = True
        End If
        If t1.Text = "Paraguay" Then
            paraguay.Visible = True
        End If
        If t1.Text = "Costa rica" Then
            costarica.Visible = True
        End If
        If t1.Text = "Italia" Then
            italia.Visible = True
        End If
    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        a = l1.Items.IndexOf(t1.Text)

        If a > -1 Then
            l1.SelectedIndex = a
        Else
            MsgBox("pais no registrado")
        End If
    End Sub

   
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mapa.Click

    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged

    End Sub
End Class
