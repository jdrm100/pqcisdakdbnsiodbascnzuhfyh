<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcesoCXC
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.vcurso_chx = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cxc_ges_rdb = New System.Windows.Forms.RadioButton()
        Me.cxc_rdb = New System.Windows.Forms.RadioButton()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.vcurso_chx)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cxc_ges_rdb)
        Me.GroupBox1.Controls.Add(Me.cxc_rdb)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(699, 199)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'vcurso_chx
        '
        Me.vcurso_chx.AutoSize = True
        Me.vcurso_chx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcurso_chx.Location = New System.Drawing.Point(331, 148)
        Me.vcurso_chx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vcurso_chx.Name = "vcurso_chx"
        Me.vcurso_chx.Size = New System.Drawing.Size(166, 21)
        Me.vcurso_chx.TabIndex = 8
        Me.vcurso_chx.Text = "VENTA EN CURSO"
        Me.vcurso_chx.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(539, 134)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 57)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cxc_ges_rdb
        '
        Me.cxc_ges_rdb.AutoSize = True
        Me.cxc_ges_rdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxc_ges_rdb.Location = New System.Drawing.Point(19, 148)
        Me.cxc_ges_rdb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cxc_ges_rdb.Name = "cxc_ges_rdb"
        Me.cxc_ges_rdb.Size = New System.Drawing.Size(167, 21)
        Me.cxc_ges_rdb.TabIndex = 6
        Me.cxc_ges_rdb.TabStop = True
        Me.cxc_ges_rdb.Text = "CXC POR GESTOR"
        Me.cxc_ges_rdb.UseVisualStyleBackColor = True
        '
        'cxc_rdb
        '
        Me.cxc_rdb.AutoSize = True
        Me.cxc_rdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxc_rdb.Location = New System.Drawing.Point(228, 148)
        Me.cxc_rdb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cxc_rdb.Name = "cxc_rdb"
        Me.cxc_rdb.Size = New System.Drawing.Size(59, 21)
        Me.cxc_rdb.TabIndex = 5
        Me.cxc_rdb.TabStop = True
        Me.cxc_rdb.Text = "CXC"
        Me.cxc_rdb.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(331, 15)
        Me.btn_Aceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(228, 57)
        Me.btn_Aceptar.TabIndex = 4
        Me.btn_Aceptar.Text = "Actualizar venta en curso"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'dtp_FechaFinal
        '
        Me.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinal.Location = New System.Drawing.Point(155, 55)
        Me.dtp_FechaFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_FechaFinal.Name = "dtp_FechaFinal"
        Me.dtp_FechaFinal.Size = New System.Drawing.Size(137, 22)
        Me.dtp_FechaFinal.TabIndex = 3
        '
        'dtp_FechaInicial
        '
        Me.dtp_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicial.Location = New System.Drawing.Point(155, 15)
        Me.dtp_FechaInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_FechaInicial.Name = "dtp_FechaInicial"
        Me.dtp_FechaInicial.Size = New System.Drawing.Size(137, 22)
        Me.dtp_FechaInicial.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial:"
        '
        'BackgroundWorker1
        '
        '
        'ProcesoCXC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 199)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProcesoCXC"
        Me.Text = "ProcesoCXC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cxc_ges_rdb As System.Windows.Forms.RadioButton
    Friend WithEvents cxc_rdb As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents vcurso_chx As System.Windows.Forms.CheckBox
End Class
