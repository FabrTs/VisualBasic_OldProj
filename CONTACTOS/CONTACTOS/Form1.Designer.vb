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
        Me.Label1 = New System.Windows.Forms.Label
        Me.t1 = New System.Windows.Forms.TextBox
        Me.t2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.t3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.t4 = New System.Windows.Forms.TextBox
        Me.b1 = New System.Windows.Forms.Button
        Me.b2 = New System.Windows.Forms.Button
        Me.b3 = New System.Windows.Forms.Button
        Me.b4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(71, 38)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 1
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(71, 84)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(100, 20)
        Me.t2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "direccion"
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(71, 129)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(100, 20)
        Me.t3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "telefono"
        '
        't4
        '
        Me.t4.Location = New System.Drawing.Point(71, 166)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(100, 20)
        Me.t4.TabIndex = 6
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(271, 48)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 23)
        Me.b1.TabIndex = 8
        Me.b1.Text = "guardar"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(271, 80)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(75, 23)
        Me.b2.TabIndex = 9
        Me.b2.Text = "nuevo"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(271, 110)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(75, 23)
        Me.b3.TabIndex = 10
        Me.b3.Text = "salir"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(271, 140)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(75, 23)
        Me.b4.TabIndex = 11
        Me.b4.Text = "buscar"
        Me.b4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 299)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "AGENDA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents b3 As System.Windows.Forms.Button
    Friend WithEvents b4 As System.Windows.Forms.Button

End Class
