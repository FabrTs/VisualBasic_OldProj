<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.t1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.t2 = New System.Windows.Forms.TextBox
        Me.t3 = New System.Windows.Forms.TextBox
        Me.t4 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(169, 60)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(120, 20)
        Me.t1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(169, 86)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(120, 20)
        Me.t2.TabIndex = 2
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(169, 112)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(120, 20)
        Me.t3.TabIndex = 3
        '
        't4
        '
        Me.t4.Location = New System.Drawing.Point(169, 138)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(120, 20)
        Me.t4.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 22)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 326)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
