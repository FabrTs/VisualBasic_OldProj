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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ra1 = New System.Windows.Forms.RadioButton
        Me.ra2 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.caj = New System.Windows.Forms.TextBox
        Me.ra5 = New System.Windows.Forms.RadioButton
        Me.ra4 = New System.Windows.Forms.RadioButton
        Me.ra3 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.t1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.t2 = New System.Windows.Forms.TextBox
        Me.b1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ra1
        '
        Me.ra1.AutoSize = True
        Me.ra1.Location = New System.Drawing.Point(28, 21)
        Me.ra1.Name = "ra1"
        Me.ra1.Size = New System.Drawing.Size(77, 17)
        Me.ra1.TabIndex = 1
        Me.ra1.TabStop = True
        Me.ra1.Tag = "13.7"
        Me.ra1.Text = "Dollar USA"
        Me.ra1.UseVisualStyleBackColor = True
        '
        'ra2
        '
        Me.ra2.AutoSize = True
        Me.ra2.Location = New System.Drawing.Point(28, 40)
        Me.ra2.Name = "ra2"
        Me.ra2.Size = New System.Drawing.Size(77, 17)
        Me.ra2.TabIndex = 2
        Me.ra2.TabStop = True
        Me.ra2.Tag = "12.50"
        Me.ra2.Text = "Dollar CAN"
        Me.ra2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.caj)
        Me.GroupBox1.Controls.Add(Me.ra5)
        Me.GroupBox1.Controls.Add(Me.ra4)
        Me.GroupBox1.Controls.Add(Me.ra3)
        Me.GroupBox1.Controls.Add(Me.ra1)
        Me.GroupBox1.Controls.Add(Me.ra2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 173)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MONEDA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "VALOR:"
        '
        'caj
        '
        Me.caj.Location = New System.Drawing.Point(33, 140)
        Me.caj.Name = "caj"
        Me.caj.ReadOnly = True
        Me.caj.Size = New System.Drawing.Size(115, 20)
        Me.caj.TabIndex = 6
        '
        'ra5
        '
        Me.ra5.AutoSize = True
        Me.ra5.Location = New System.Drawing.Point(29, 98)
        Me.ra5.Name = "ra5"
        Me.ra5.Size = New System.Drawing.Size(80, 17)
        Me.ra5.TabIndex = 5
        Me.ra5.TabStop = True
        Me.ra5.Tag = "6.6"
        Me.ra5.Text = "Libra turcas"
        Me.ra5.UseVisualStyleBackColor = True
        '
        'ra4
        '
        Me.ra4.AutoSize = True
        Me.ra4.Location = New System.Drawing.Point(28, 78)
        Me.ra4.Name = "ra4"
        Me.ra4.Size = New System.Drawing.Size(48, 17)
        Me.ra4.TabIndex = 4
        Me.ra4.TabStop = True
        Me.ra4.Tag = "20"
        Me.ra4.Text = "Libra"
        Me.ra4.UseVisualStyleBackColor = True
        '
        'ra3
        '
        Me.ra3.AutoSize = True
        Me.ra3.Location = New System.Drawing.Point(28, 59)
        Me.ra3.Name = "ra3"
        Me.ra3.Size = New System.Drawing.Size(47, 17)
        Me.ra3.TabIndex = 3
        Me.ra3.TabStop = True
        Me.ra3.Tag = "17.60"
        Me.ra3.Text = "Euro"
        Me.ra3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(273, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CANTIDAD:"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(261, 68)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RESULTADO"
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(260, 137)
        Me.t2.Name = "t2"
        Me.t2.ReadOnly = True
        Me.t2.Size = New System.Drawing.Size(100, 20)
        Me.t2.TabIndex = 7
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(342, 192)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 23)
        Me.b1.TabIndex = 8
        Me.b1.Text = "Calcular"
        Me.b1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(476, 248)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Name = "Form1"
        Me.Text = "CONVERTIDOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ra1 As System.Windows.Forms.RadioButton
    Friend WithEvents ra2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ra3 As System.Windows.Forms.RadioButton
    Friend WithEvents ra5 As System.Windows.Forms.RadioButton
    Friend WithEvents ra4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents caj As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
