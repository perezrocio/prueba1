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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tsb = New System.Windows.Forms.TextBox()
        Me.thrse = New System.Windows.Forms.TextBox()
        Me.tpxh = New System.Windows.Forms.TextBox()
        Me.tpe = New System.Windows.Forms.TextBox()
        Me.ttp = New System.Windows.Forms.TextBox()
        Me.cbturno = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "sueldo base"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "horas extras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "turnoo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "pago por hora extra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "pago extra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "total pagar"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(142, 13)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(100, 20)
        Me.tnombre.TabIndex = 7
        '
        'tsb
        '
        Me.tsb.Location = New System.Drawing.Point(142, 39)
        Me.tsb.Name = "tsb"
        Me.tsb.Size = New System.Drawing.Size(100, 20)
        Me.tsb.TabIndex = 8
        '
        'thrse
        '
        Me.thrse.Location = New System.Drawing.Point(142, 65)
        Me.thrse.Name = "thrse"
        Me.thrse.Size = New System.Drawing.Size(100, 20)
        Me.thrse.TabIndex = 9
        '
        'tpxh
        '
        Me.tpxh.Location = New System.Drawing.Point(142, 124)
        Me.tpxh.Name = "tpxh"
        Me.tpxh.Size = New System.Drawing.Size(100, 20)
        Me.tpxh.TabIndex = 10
        '
        'tpe
        '
        Me.tpe.Location = New System.Drawing.Point(142, 150)
        Me.tpe.Name = "tpe"
        Me.tpe.Size = New System.Drawing.Size(100, 20)
        Me.tpe.TabIndex = 11
        '
        'ttp
        '
        Me.ttp.Location = New System.Drawing.Point(142, 176)
        Me.ttp.Name = "ttp"
        Me.ttp.Size = New System.Drawing.Size(100, 20)
        Me.ttp.TabIndex = 12
        '
        'cbturno
        '
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.Items.AddRange(New Object() {"turno1", "turno2", "turno3"})
        Me.cbturno.Location = New System.Drawing.Point(142, 91)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(121, 21)
        Me.cbturno.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.ttp)
        Me.Controls.Add(Me.tpe)
        Me.Controls.Add(Me.tpxh)
        Me.Controls.Add(Me.thrse)
        Me.Controls.Add(Me.tsb)
        Me.Controls.Add(Me.tnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents tsb As System.Windows.Forms.TextBox
    Friend WithEvents thrse As System.Windows.Forms.TextBox
    Friend WithEvents tpxh As System.Windows.Forms.TextBox
    Friend WithEvents tpe As System.Windows.Forms.TextBox
    Friend WithEvents ttp As System.Windows.Forms.TextBox
    Friend WithEvents cbturno As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
