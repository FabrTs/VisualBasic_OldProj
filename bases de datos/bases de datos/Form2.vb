Public Class Form2
    Dim conexion As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim datos As New DataSet
    Dim n, r As Integer
    Private Sub conectar()
        Dim proveedor, origen As String
        proveedor = "provider=microsoft.ace.oledb.12.0;"
        origen = "data source=" + Application.StartupPath + "\clientes.accdb"
        conexion.ConnectionString = proveedor + origen
        Try
            conexion.Open()
            da = New OleDb.OleDbDataAdapter("select * from clientes", conexion)
            da.Fill(datos, "tablaclientes")
            n = datos.Tables("tablaclientes").Rows.Count
            '    dvg1.datasource = datos
            '   dvg1.datamember = "tablaclientes"
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarregistros()
        t1.Text = datos.Tables("tablaclientes").Rows(0).Item(0)
        t2.Text = datos.Tables("tablaclientes").Rows(0).Item(1)
        t3.Text = datos.Tables("tablaclientes").Rows(0).Item(2)
        t4.Text = datos.Tables("tablaclientes").Rows(0).Item(3)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar()
        'cargarregistros()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If r < n - 1 Then
            r += 1
            t1.Text = datos.Tables("tablaclientes").Rows(r).Item(0)
            t2.Text = datos.Tables("tablaclientes").Rows(r).Item(1)
            t3.Text = datos.Tables("tablaclientes").Rows(r).Item(2)
            t4.Text = datos.Tables("tablaclientes").Rows(r).Item(3)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If r > 0 Then
            r -= 1
            t1.Text = datos.Tables("tablaclientes").Rows(r).Item(0)
            t2.Text = datos.Tables("tablaclientes").Rows(r).Item(1)
            t3.Text = datos.Tables("tablaclientes").Rows(r).Item(2)
            t4.Text = datos.Tables("tablaclientes").Rows(r).Item(3)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For j = 0 To datos.Tables("tablaclientes").Rows.Count - 1
            If t1.Text = datos.Tables("tablaclientes").Rows(j).Item(0) Or t2.Text.ToUpper = datos.Tables("tablaclientes").Rows(j).Item(1).Toupper Then
                t1.Text = datos.Tables("tablaclientes").Rows(j).Item(0)
                t2.Text = datos.Tables("tablaclientes").Rows(j).Item(1)
                t3.Text = datos.Tables("tablaclientes").Rows(j).Item(2)
                t4.Text = datos.Tables("tablaclientes").Rows(j).Item(3)
            End If
        Next
    End Sub
End Class
