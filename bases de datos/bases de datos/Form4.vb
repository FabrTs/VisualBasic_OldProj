Public Class Form4
    Dim conexion As New OleDb.OleDbConnection
    Dim datos As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim cd As OleDb.OleDbCommandBuilder
    ' Dim nuevo As DataRow

    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        conexion.Open()
        da.Update(datos, "tablaclientes")
        conexion.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "provider=microsoft.ace.oledb.12.0; data source=" + Application.StartupPath + "/clientes.accdb"
        Try
            conexion.Open()
            da = New OleDb.OleDbDataAdapter("select * from clientes", conexion)
            cd = New OleDb.OleDbCommandBuilder(da)
            da.Fill(datos, "tablaclientes")
            gb1.enabled = True : conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nuevo As DataRow
        ' Dim a As Integer
        nuevo = datos.Tables("tablaclientes").NewRow
        ' a = datos.Tables("tablaclientes").Rows.Count - 1
        nuevo.Item(0) = t1.Text
        nuevo.Item(1) = t2.Text
        nuevo.Item(2) = t3.Text
        nuevo.Item(3) = t4.Text
        datos.Tables("tablaclientes").Rows.Add(nuevo)
    End Sub

    Private Sub gb1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb1.Enter

    End Sub
End Class