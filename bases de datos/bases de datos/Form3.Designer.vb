<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dvg1 = New System.Windows.Forms.DataGridView
        Me.t1 = New System.Windows.Forms.TextBox
        CType(Me.dvg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvg1
        '
        Me.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg1.Location = New System.Drawing.Point(24, 100)
        Me.dvg1.Name = "dvg1"
        Me.dvg1.Size = New System.Drawing.Size(386, 148)
        Me.dvg1.TabIndex = 0
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(88, 40)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 1
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 260)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.dvg1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dvg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dvg1 As System.Windows.Forms.DataGridView
    Friend WithEvents t1 As System.Windows.Forms.TextBox
End Class
