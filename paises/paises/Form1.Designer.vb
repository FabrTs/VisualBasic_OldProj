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
        Me.Label1 = New System.Windows.Forms.Label
        Me.t1 = New System.Windows.Forms.TextBox
        Me.l1 = New System.Windows.Forms.ListBox
        Me.b1 = New System.Windows.Forms.Button
        Me.l3 = New System.Windows.Forms.Label
        Me.t2 = New System.Windows.Forms.TextBox
        Me.l4 = New System.Windows.Forms.Label
        Me.t3 = New System.Windows.Forms.TextBox
        Me.li2 = New System.Windows.Forms.ListBox
        Me.mapa = New System.Windows.Forms.PictureBox
        Me.turquia = New System.Windows.Forms.PictureBox
        Me.costarica = New System.Windows.Forms.PictureBox
        Me.belgica = New System.Windows.Forms.PictureBox
        Me.italia = New System.Windows.Forms.PictureBox
        Me.paraguay = New System.Windows.Forms.PictureBox
        Me.francia = New System.Windows.Forms.PictureBox
        Me.japon = New System.Windows.Forms.PictureBox
        Me.gb1 = New System.Windows.Forms.GroupBox
        CType(Me.mapa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.turquia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costarica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.belgica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.italia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paraguay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.francia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.japon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pais?"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(15, 60)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 1
        '
        'l1
        '
        Me.l1.FormattingEnabled = True
        Me.l1.Items.AddRange(New Object() {"Japon", "Turquia", "Belgica", "Francia", "Paraguay", "Costa rica", "Italia"})
        Me.l1.Location = New System.Drawing.Point(12, 98)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(158, 186)
        Me.l1.TabIndex = 2
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(121, 57)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 23)
        Me.b1.TabIndex = 3
        Me.b1.Text = "buscar"
        Me.b1.UseVisualStyleBackColor = True
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Location = New System.Drawing.Point(227, 107)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(27, 13)
        Me.l3.TabIndex = 4
        Me.l3.Text = "Pais"
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(200, 123)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(100, 20)
        Me.t2.TabIndex = 5
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Location = New System.Drawing.Point(227, 178)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(39, 13)
        Me.l4.TabIndex = 6
        Me.l4.Text = "Capital"
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(200, 194)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(100, 20)
        Me.t3.TabIndex = 7
        '
        'li2
        '
        Me.li2.FormattingEnabled = True
        Me.li2.Items.AddRange(New Object() {"Tokio", "Akara", "Bruselas", "Paris", "Asuncion", "San jose", "Roma"})
        Me.li2.Location = New System.Drawing.Point(214, 262)
        Me.li2.Name = "li2"
        Me.li2.Size = New System.Drawing.Size(158, 186)
        Me.li2.TabIndex = 8
        Me.li2.Visible = False
        '
        'mapa
        '
        Me.mapa.Image = CType(resources.GetObject("mapa.Image"), System.Drawing.Image)
        Me.mapa.Location = New System.Drawing.Point(15, 19)
        Me.mapa.Name = "mapa"
        Me.mapa.Size = New System.Drawing.Size(625, 314)
        Me.mapa.TabIndex = 9
        Me.mapa.TabStop = False
        '
        'turquia
        '
        Me.turquia.Image = CType(resources.GetObject("turquia.Image"), System.Drawing.Image)
        Me.turquia.Location = New System.Drawing.Point(370, 112)
        Me.turquia.Name = "turquia"
        Me.turquia.Size = New System.Drawing.Size(10, 10)
        Me.turquia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.turquia.TabIndex = 10
        Me.turquia.TabStop = False
        Me.turquia.Visible = False
        '
        'costarica
        '
        Me.costarica.Image = CType(resources.GetObject("costarica.Image"), System.Drawing.Image)
        Me.costarica.Location = New System.Drawing.Point(184, 165)
        Me.costarica.Name = "costarica"
        Me.costarica.Size = New System.Drawing.Size(10, 10)
        Me.costarica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.costarica.TabIndex = 11
        Me.costarica.TabStop = False
        Me.costarica.Visible = False
        '
        'belgica
        '
        Me.belgica.Image = CType(resources.GetObject("belgica.Image"), System.Drawing.Image)
        Me.belgica.Location = New System.Drawing.Point(323, 102)
        Me.belgica.Name = "belgica"
        Me.belgica.Size = New System.Drawing.Size(10, 10)
        Me.belgica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.belgica.TabIndex = 12
        Me.belgica.TabStop = False
        Me.belgica.Visible = False
        '
        'italia
        '
        Me.italia.Image = CType(resources.GetObject("italia.Image"), System.Drawing.Image)
        Me.italia.Location = New System.Drawing.Point(339, 106)
        Me.italia.Name = "italia"
        Me.italia.Size = New System.Drawing.Size(10, 10)
        Me.italia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.italia.TabIndex = 13
        Me.italia.TabStop = False
        Me.italia.Visible = False
        '
        'paraguay
        '
        Me.paraguay.Image = CType(resources.GetObject("paraguay.Image"), System.Drawing.Image)
        Me.paraguay.Location = New System.Drawing.Point(177, 156)
        Me.paraguay.Name = "paraguay"
        Me.paraguay.Size = New System.Drawing.Size(10, 10)
        Me.paraguay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.paraguay.TabIndex = 14
        Me.paraguay.TabStop = False
        Me.paraguay.Visible = False
        '
        'francia
        '
        Me.francia.Image = CType(resources.GetObject("francia.Image"), System.Drawing.Image)
        Me.francia.Location = New System.Drawing.Point(331, 89)
        Me.francia.Name = "francia"
        Me.francia.Size = New System.Drawing.Size(10, 10)
        Me.francia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.francia.TabIndex = 15
        Me.francia.TabStop = False
        Me.francia.Visible = False
        '
        'japon
        '
        Me.japon.Image = CType(resources.GetObject("japon.Image"), System.Drawing.Image)
        Me.japon.Location = New System.Drawing.Point(530, 117)
        Me.japon.Name = "japon"
        Me.japon.Size = New System.Drawing.Size(10, 10)
        Me.japon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.japon.TabIndex = 16
        Me.japon.TabStop = False
        Me.japon.Visible = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.francia)
        Me.gb1.Controls.Add(Me.japon)
        Me.gb1.Controls.Add(Me.paraguay)
        Me.gb1.Controls.Add(Me.italia)
        Me.gb1.Controls.Add(Me.belgica)
        Me.gb1.Controls.Add(Me.costarica)
        Me.gb1.Controls.Add(Me.turquia)
        Me.gb1.Controls.Add(Me.mapa)
        Me.gb1.Location = New System.Drawing.Point(400, 43)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(655, 324)
        Me.gb1.TabIndex = 17
        Me.gb1.TabStop = False
        Me.gb1.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 379)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.li2)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.mapa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.turquia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costarica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.belgica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.italia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paraguay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.francia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.japon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents l1 As System.Windows.Forms.ListBox
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents li2 As System.Windows.Forms.ListBox
    Friend WithEvents mapa As System.Windows.Forms.PictureBox
    Friend WithEvents turquia As System.Windows.Forms.PictureBox
    Friend WithEvents costarica As System.Windows.Forms.PictureBox
    Friend WithEvents belgica As System.Windows.Forms.PictureBox
    Friend WithEvents italia As System.Windows.Forms.PictureBox
    Friend WithEvents paraguay As System.Windows.Forms.PictureBox
    Friend WithEvents francia As System.Windows.Forms.PictureBox
    Friend WithEvents japon As System.Windows.Forms.PictureBox
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox

End Class
