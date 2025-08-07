<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.t4 = New System.Windows.Forms.TextBox
        Me.t3 = New System.Windows.Forms.TextBox
        Me.t2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.t1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "nombre"
        '
        't4
        '
        Me.t4.Location = New System.Drawing.Point(109, 111)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(120, 20)
        Me.t4.TabIndex = 22
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(109, 85)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(120, 20)
        Me.t3.TabIndex = 21
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(109, 59)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(120, 20)
        Me.t2.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "id"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(109, 33)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(120, 20)
        Me.t1.TabIndex = 18
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(109, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 22)
        Me.Button4.TabIndex = 26
        Me.Button4.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.Button4)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.t4)
        Me.gb1.Controls.Add(Me.t3)
        Me.gb1.Controls.Add(Me.t2)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.t1)
        Me.gb1.Location = New System.Drawing.Point(12, 27)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(266, 198)
        Me.gb1.TabIndex = 27
        Me.gb1.TabStop = False
        Me.gb1.Text = "GroupBox1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 233)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
End Class
