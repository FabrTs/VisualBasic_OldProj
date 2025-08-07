Public Class Form1
    Dim conexion As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dal, das, dap As OleDb.OleDbDataAdapter
    Dim cb1, cb2 As OleDb.OleDbCommandBuilder
    Dim dr As DataRow
    Dim dv As New DataView
    Dim pos As Integer
    Dim valor As String

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            conexion.Open()
            dal.Update(ds, "libros")
            dap.Update(ds, "prestamos")
            conexion.Close()
        Catch ex As Exception
            MsgBox("No se pudieron actualizar los datos")
        End Try
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim provedor, ruta As String
        provedor = "provider=microsoft.ace.oledb.12.0;"
        ruta = "data source=" + Application.StartupPath + "\libros.accdb"
        conexion.ConnectionString = provedor + ruta
        Try
            conexion.Open()
            das = New OleDb.OleDbDataAdapter("select * from socios", conexion)
            dal = New OleDb.OleDbDataAdapter("select * from libros", conexion)
            cb1 = New OleDb.OleDbCommandBuilder(dal)
            dap = New OleDb.OleDbDataAdapter("select *from prestamos", conexion)
            cb2 = New OleDb.OleDbCommandBuilder(dap)
            das.Fill(ds, "socios")
            dal.Fill(ds, "libros")
            dap.Fill(ds, "prestamos")
            conexion.Close()
            dv.Table = ds.Tables("prestamos")
            dv.RowFilter = "id=''"
            dvg1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For j = 0 To ds.Tables("libros").Rows.Count - 1
            If t1.Text = ds.Tables("libros").Rows(j).Item(0) Then
                't1.Text = ds.Tables("libros").Rows(j).Item(0)
                t2.Text = ds.Tables("libros").Rows(j).Item(1)
                t3.Text = ds.Tables("libros").Rows(j).Item(2)
                valor = ds.Tables("libros").Rows(j).Item(3)
                pos = j
                Exit For
            End If
        Next
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For l = 0 To ds.Tables("socios").Rows.Count - 1
            If t4.Text = ds.Tables("socios").Rows(l).Item(0) Then
                t4.Text = ds.Tables("socios").Rows(l).Item(0)
                t5.Text = ds.Tables("socios").Rows(l).Item(1)
                dv.RowFilter = "id='" + t4.Text + "'"
                'dv.rowfilter="id='s001'"
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fi, ff As Date
        fi = Today
        ff = Today
        dr = ds.Tables("prestamos").NewRow
        dr.Item(0) = t1.Text + t4.Text + fi
        dr.Item(1) = t4.Text
        dr.Item(2) = t1.Text
        dr.Item(3) = t5.Text
        dr.Item(4) = fi
        dr.Item(5) = ff
        dr.Item(6) = valor
        dr.Item(7) = t2.Text
        ds.Tables("prestamos").Rows.Add(dr)
        ds.Tables("libros").Rows(pos).Item(3) = True

    End Sub
End Class
