Namespace My
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.textBox3 = New System.Windows.Forms.TextBox()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.btnAlumno = New System.Windows.Forms.Button()
            Me.btnEmpleado = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(43, 35)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(59, 15)
            Me.label1.TabIndex = 0
            Me.label1.Text = "NOMBRE:"
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(43, 64)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(138, 15)
            Me.label2.TabIndex = 1
            Me.label2.Text = "FECHA DE NACIMIENTO:"
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(43, 95)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(67, 15)
            Me.label3.TabIndex = 2
            Me.label3.Text = "TELEFONO:"
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(43, 127)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(56, 15)
            Me.label4.TabIndex = 3
            Me.label4.Text = "CORREO:"
            Me.textBox1.Location = New System.Drawing.Point(108, 32)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(333, 23)
            Me.textBox1.TabIndex = 4
            Me.dateTimePicker1.Location = New System.Drawing.Point(187, 61)
            Me.dateTimePicker1.Name = "dateTimePicker1"
            Me.dateTimePicker1.Size = New System.Drawing.Size(200, 23)
            Me.dateTimePicker1.TabIndex = 5
            Me.textBox2.Location = New System.Drawing.Point(116, 92)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(236, 23)
            Me.textBox2.TabIndex = 6
            Me.textBox3.Location = New System.Drawing.Point(105, 124)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(247, 23)
            Me.textBox3.TabIndex = 7
            Me.btnGuardar.Location = New System.Drawing.Point(609, 35)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(118, 23)
            Me.btnGuardar.TabIndex = 8
            Me.btnGuardar.Text = "GUARDAR"
            Me.btnGuardar.UseVisualStyleBackColor = True
            AddHandler Me.btnGuardar.Click, AddressOf Me.button1_Click
            Me.listView1.Location = New System.Drawing.Point(27, 200)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(761, 214)
            Me.listView1.TabIndex = 9
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.btnAlumno.Location = New System.Drawing.Point(609, 64)
            Me.btnAlumno.Name = "btnAlumno"
            Me.btnAlumno.Size = New System.Drawing.Size(155, 23)
            Me.btnAlumno.TabIndex = 10
            Me.btnAlumno.Text = "GUARDAR ALUMNO"
            Me.btnAlumno.UseVisualStyleBackColor = True
            AddHandler Me.btnAlumno.Click, AddressOf Me.btnAlumno_Click
            Me.btnEmpleado.Location = New System.Drawing.Point(609, 93)
            Me.btnEmpleado.Name = "btnEmpleado"
            Me.btnEmpleado.Size = New System.Drawing.Size(155, 23)
            Me.btnEmpleado.TabIndex = 11
            Me.btnEmpleado.Text = "GUARDAR EMPLEADO"
            Me.btnEmpleado.UseVisualStyleBackColor = True
            AddHandler Me.btnAlumno.Click, AddressOf Me.btnEmpleado_Click
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.btnEmpleado)
            Me.Controls.Add(Me.btnAlumno)
            Me.Controls.Add(Me.listView1)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.textBox3)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.dateTimePicker1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private label1 As Label
        Private label2 As Label
        Private label3 As Label
        Private label4 As Label
        Private textBox1 As TextBox
        Private dateTimePicker1 As DateTimePicker
        Private textBox2 As TextBox
        Private textBox3 As TextBox
        Private btnGuardar As Button
        Private listView1 As ListView
        Private btnAlumno As Button
        Private btnEmpleado As Button
    End Class

End Namespace
