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
        Me.dgvLlegadas = New System.Windows.Forms.DataGridView()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnAgregarPS = New System.Windows.Forms.Button()
        Me.txtSupLleg = New System.Windows.Forms.TextBox()
        Me.txtInfLleg = New System.Windows.Forms.TextBox()
        Me.txtInfFin = New System.Windows.Forms.TextBox()
        Me.txtSupFin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInfRegreso = New System.Windows.Forms.TextBox()
        Me.txtSupRegreso = New System.Windows.Forms.TextBox()
        Me.txtInfSalida = New System.Windows.Forms.TextBox()
        Me.txtSupSalida = New System.Windows.Forms.TextBox()
        Me.cbClientesPrioridad = New System.Windows.Forms.CheckBox()
        Me.clmHoraActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHPFS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHPLL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHPSS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHPRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmQ1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHPLLCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLlCPInf = New System.Windows.Forms.TextBox()
        Me.txtLlCPSup = New System.Windows.Forms.TextBox()
        Me.cbSalidaServidor = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnIterar = New System.Windows.Forms.Button()
        Me.txtCantIteraciones = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgvLlegadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLlegadas
        '
        Me.dgvLlegadas.AllowUserToAddRows = False
        Me.dgvLlegadas.AllowUserToDeleteRows = False
        Me.dgvLlegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLlegadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmHoraActual, Me.clmQ, Me.clmPS, Me.clmS, Me.clmHPFS, Me.clmHPLL, Me.clmHPSS, Me.clmHPRS, Me.clmQ1, Me.clmHPLLCP})
        Me.dgvLlegadas.Location = New System.Drawing.Point(12, 12)
        Me.dgvLlegadas.Name = "dgvLlegadas"
        Me.dgvLlegadas.ReadOnly = True
        Me.dgvLlegadas.Size = New System.Drawing.Size(1048, 304)
        Me.dgvLlegadas.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(800, 360)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnAgregarPS
        '
        Me.btnAgregarPS.Location = New System.Drawing.Point(900, 360)
        Me.btnAgregarPS.Name = "btnAgregarPS"
        Me.btnAgregarPS.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarPS.TabIndex = 2
        Me.btnAgregarPS.Text = "Agregar PS"
        Me.btnAgregarPS.UseVisualStyleBackColor = True
        '
        'txtSupLleg
        '
        Me.txtSupLleg.Location = New System.Drawing.Point(65, 363)
        Me.txtSupLleg.Name = "txtSupLleg"
        Me.txtSupLleg.Size = New System.Drawing.Size(45, 20)
        Me.txtSupLleg.TabIndex = 3
        Me.txtSupLleg.Text = "60"
        '
        'txtInfLleg
        '
        Me.txtInfLleg.Location = New System.Drawing.Point(65, 402)
        Me.txtInfLleg.Name = "txtInfLleg"
        Me.txtInfLleg.Size = New System.Drawing.Size(45, 20)
        Me.txtInfLleg.TabIndex = 4
        Me.txtInfLleg.Text = "40"
        '
        'txtInfFin
        '
        Me.txtInfFin.Location = New System.Drawing.Point(204, 410)
        Me.txtInfFin.Name = "txtInfFin"
        Me.txtInfFin.Size = New System.Drawing.Size(45, 20)
        Me.txtInfFin.TabIndex = 6
        Me.txtInfFin.Text = "40"
        '
        'txtSupFin
        '
        Me.txtSupFin.Location = New System.Drawing.Point(204, 363)
        Me.txtSupFin.Name = "txtSupFin"
        Me.txtSupFin.Size = New System.Drawing.Size(45, 20)
        Me.txtSupFin.TabIndex = 5
        Me.txtSupFin.Text = "45"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Inf"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Inf"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Llegada cl"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fin de serv"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Regreso del serv"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Salida del serv"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(147, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Inf"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Inf"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(147, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Sup"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Sup"
        '
        'txtInfRegreso
        '
        Me.txtInfRegreso.Enabled = False
        Me.txtInfRegreso.Location = New System.Drawing.Point(179, 67)
        Me.txtInfRegreso.Name = "txtInfRegreso"
        Me.txtInfRegreso.Size = New System.Drawing.Size(42, 20)
        Me.txtInfRegreso.TabIndex = 16
        Me.txtInfRegreso.Text = "90"
        '
        'txtSupRegreso
        '
        Me.txtSupRegreso.Enabled = False
        Me.txtSupRegreso.Location = New System.Drawing.Point(179, 27)
        Me.txtSupRegreso.Name = "txtSupRegreso"
        Me.txtSupRegreso.Size = New System.Drawing.Size(42, 20)
        Me.txtSupRegreso.TabIndex = 15
        Me.txtSupRegreso.Text = "120"
        '
        'txtInfSalida
        '
        Me.txtInfSalida.Enabled = False
        Me.txtInfSalida.Location = New System.Drawing.Point(62, 66)
        Me.txtInfSalida.Name = "txtInfSalida"
        Me.txtInfSalida.Size = New System.Drawing.Size(45, 20)
        Me.txtInfSalida.TabIndex = 14
        Me.txtInfSalida.Text = "590"
        '
        'txtSupSalida
        '
        Me.txtSupSalida.Enabled = False
        Me.txtSupSalida.Location = New System.Drawing.Point(62, 27)
        Me.txtSupSalida.Name = "txtSupSalida"
        Me.txtSupSalida.Size = New System.Drawing.Size(45, 20)
        Me.txtSupSalida.TabIndex = 13
        Me.txtSupSalida.Text = "600"
        '
        'cbClientesPrioridad
        '
        Me.cbClientesPrioridad.AutoSize = True
        Me.cbClientesPrioridad.Location = New System.Drawing.Point(606, 329)
        Me.cbClientesPrioridad.Name = "cbClientesPrioridad"
        Me.cbClientesPrioridad.Size = New System.Drawing.Size(120, 17)
        Me.cbClientesPrioridad.TabIndex = 23
        Me.cbClientesPrioridad.Text = "Clientes c/ prioridad"
        Me.cbClientesPrioridad.UseVisualStyleBackColor = True
        '
        'clmHoraActual
        '
        Me.clmHoraActual.HeaderText = "HoraActual"
        Me.clmHoraActual.Name = "clmHoraActual"
        Me.clmHoraActual.ReadOnly = True
        '
        'clmQ
        '
        Me.clmQ.HeaderText = "Q"
        Me.clmQ.Name = "clmQ"
        Me.clmQ.ReadOnly = True
        '
        'clmPS
        '
        Me.clmPS.HeaderText = "PS"
        Me.clmPS.Name = "clmPS"
        Me.clmPS.ReadOnly = True
        '
        'clmS
        '
        Me.clmS.HeaderText = "S"
        Me.clmS.Name = "clmS"
        Me.clmS.ReadOnly = True
        '
        'clmHPFS
        '
        Me.clmHPFS.HeaderText = "HPFS"
        Me.clmHPFS.Name = "clmHPFS"
        Me.clmHPFS.ReadOnly = True
        '
        'clmHPLL
        '
        Me.clmHPLL.HeaderText = "HPLL"
        Me.clmHPLL.Name = "clmHPLL"
        Me.clmHPLL.ReadOnly = True
        '
        'clmHPSS
        '
        Me.clmHPSS.HeaderText = "HPSS"
        Me.clmHPSS.Name = "clmHPSS"
        Me.clmHPSS.ReadOnly = True
        '
        'clmHPRS
        '
        Me.clmHPRS.HeaderText = "HPRS"
        Me.clmHPRS.Name = "clmHPRS"
        Me.clmHPRS.ReadOnly = True
        '
        'clmQ1
        '
        Me.clmQ1.HeaderText = "Q1"
        Me.clmQ1.Name = "clmQ1"
        Me.clmQ1.ReadOnly = True
        '
        'clmHPLLCP
        '
        Me.clmHPLLCP.HeaderText = "HPLLCP"
        Me.clmHPLLCP.Name = "clmHPLLCP"
        Me.clmHPLLCP.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtLlCPInf)
        Me.GroupBox1.Controls.Add(Me.txtLlCPSup)
        Me.GroupBox1.Location = New System.Drawing.Point(591, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 86)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, -2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Llegada clientes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Inf"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Sup"
        '
        'txtLlCPInf
        '
        Me.txtLlCPInf.Enabled = False
        Me.txtLlCPInf.Location = New System.Drawing.Point(60, 53)
        Me.txtLlCPInf.Name = "txtLlCPInf"
        Me.txtLlCPInf.Size = New System.Drawing.Size(45, 20)
        Me.txtLlCPInf.TabIndex = 13
        Me.txtLlCPInf.Text = "160"
        '
        'txtLlCPSup
        '
        Me.txtLlCPSup.Enabled = False
        Me.txtLlCPSup.Location = New System.Drawing.Point(60, 14)
        Me.txtLlCPSup.Name = "txtLlCPSup"
        Me.txtLlCPSup.Size = New System.Drawing.Size(45, 20)
        Me.txtLlCPSup.TabIndex = 12
        Me.txtLlCPSup.Text = "180"
        '
        'cbSalidaServidor
        '
        Me.cbSalidaServidor.AutoSize = True
        Me.cbSalidaServidor.Location = New System.Drawing.Point(325, 329)
        Me.cbSalidaServidor.Name = "cbSalidaServidor"
        Me.cbSalidaServidor.Size = New System.Drawing.Size(140, 17)
        Me.cbSalidaServidor.TabIndex = 25
        Me.cbSalidaServidor.Text = "Salida/Regreso servidor"
        Me.cbSalidaServidor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSupSalida)
        Me.GroupBox2.Controls.Add(Me.txtInfSalida)
        Me.GroupBox2.Controls.Add(Me.txtSupRegreso)
        Me.GroupBox2.Controls.Add(Me.txtInfRegreso)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(292, 349)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 93)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'btnIterar
        '
        Me.btnIterar.Location = New System.Drawing.Point(800, 399)
        Me.btnIterar.Name = "btnIterar"
        Me.btnIterar.Size = New System.Drawing.Size(75, 23)
        Me.btnIterar.TabIndex = 27
        Me.btnIterar.Text = "Iterar"
        Me.btnIterar.UseVisualStyleBackColor = True
        '
        'txtCantIteraciones
        '
        Me.txtCantIteraciones.Location = New System.Drawing.Point(900, 401)
        Me.txtCantIteraciones.Name = "txtCantIteraciones"
        Me.txtCantIteraciones.Size = New System.Drawing.Size(45, 20)
        Me.txtCantIteraciones.TabIndex = 28
        Me.txtCantIteraciones.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(951, 404)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Veces"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 451)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCantIteraciones)
        Me.Controls.Add(Me.btnIterar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbSalidaServidor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbClientesPrioridad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInfFin)
        Me.Controls.Add(Me.txtSupFin)
        Me.Controls.Add(Me.txtInfLleg)
        Me.Controls.Add(Me.txtSupLleg)
        Me.Controls.Add(Me.btnAgregarPS)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgvLlegadas)
        Me.Name = "Form1"
        Me.Text = "Matriz de Simulacion, PS: "
        CType(Me.dgvLlegadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLlegadas As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPS As System.Windows.Forms.Button
    Friend WithEvents txtSupLleg As System.Windows.Forms.TextBox
    Friend WithEvents txtInfLleg As System.Windows.Forms.TextBox
    Friend WithEvents txtInfFin As System.Windows.Forms.TextBox
    Friend WithEvents txtSupFin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInfRegreso As System.Windows.Forms.TextBox
    Friend WithEvents txtSupRegreso As System.Windows.Forms.TextBox
    Friend WithEvents txtInfSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtSupSalida As System.Windows.Forms.TextBox
    Friend WithEvents cbClientesPrioridad As System.Windows.Forms.CheckBox
    Friend WithEvents clmHoraActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHPFS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHPLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHPSS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHPRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmQ1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHPLLCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLlCPInf As System.Windows.Forms.TextBox
    Friend WithEvents txtLlCPSup As System.Windows.Forms.TextBox
    Friend WithEvents cbSalidaServidor As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIterar As System.Windows.Forms.Button
    Friend WithEvents txtCantIteraciones As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
