Public Class Form3
    Dim conexion As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim datos As New DataSet
    Dim dv1 As New DataView
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
            dv1.Table = datos.Tables("tablaclientes")
            dvg1.DataSource = dv1

            'si se busca por cadena hay que ponerle ''
            'tambien se puede buscar por el campo like '%=* '"
            'dvg1.DataMember = "tablaclientes"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged
        Dim t As String
        t = "nombre like '%" + t1.Text + "%'"
        dv1.RowFilter = t
        dvg1.DataSource = dv1
    End Sub
End Class
