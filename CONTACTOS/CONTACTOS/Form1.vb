Public Structure cliente
    Public id As Integer
    Public nombre As String
    Public dir As String
    Public tel As String
End Structure
Public Class Form1
    Dim datos(1000) As cliente
    Dim tap As Integer = 0
    Public Sub guardar(ByVal sender, ByVal e) Handles b1.Click
        If tap < 1000 Then
            datos(tap).id = tap + 1
            datos(tap).nombre = t2.Text
            datos(tap).dir = t3.Text
            datos(tap).tel = t4.Text
            tap += 1
        Else
            MsgBox("limite de contactos")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t1.Text = "1"
    End Sub
    Public Sub buscar()
        Dim ban As Boolean = False
        For i = 0 To tap - 1
            If t2.Text.ToUpper() = datos(i).nombre.ToUpper() Then
                t1.Text = datos(i).id
                t2.Text = datos(i).nombre
                t3.Text = datos(i).dir
                t4.Text = datos(i).tel
                ban = True
            End If
        Next
        If ban = False Then
            MsgBox("no se ha encontrado")
        End If
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        Me.Close()
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        t1.Text = t1.Text + 1
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        buscar()
    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged

    End Sub
End Class
