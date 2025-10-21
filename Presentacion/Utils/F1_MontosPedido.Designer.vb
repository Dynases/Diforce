<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_MontosPedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnAgregar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbPedido = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.tbContado = New DevComponents.Editors.DoubleInput()
        Me.tbCredito = New DevComponents.Editors.DoubleInput()
        Me.tbTransferencia = New DevComponents.Editors.DoubleInput()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.tbContado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.ReflectionLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 55)
        Me.Panel1.TabIndex = 10
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.White
        Me.ReflectionLabel1.Location = New System.Drawing.Point(9, 10)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(294, 43)
        Me.ReflectionLabel1.TabIndex = 5
        Me.ReflectionLabel1.Text = "DETALLE DE PAGO DEL PEDIDO"
        '
        'btnAgregar
        '
        Me.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnAgregar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAgregar.Location = New System.Drawing.Point(338, 277)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 42)
        Me.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnAgregar.TabIndex = 373
        Me.btnAgregar.Text = "Confirmar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.Presentacion.My.Resources.Resources.cancel
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.ButtonX1.Location = New System.Drawing.Point(207, 277)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(96, 42)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.TabIndex = 374
        Me.ButtonX1.Text = "Salir"
        '
        'lbProducto
        '
        Me.lbProducto.Font = New System.Drawing.Font("Calibri", 14.2!, System.Drawing.FontStyle.Bold)
        Me.lbProducto.ForeColor = System.Drawing.Color.Navy
        Me.lbProducto.Location = New System.Drawing.Point(5, 57)
        Me.lbProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(115, 37)
        Me.lbProducto.TabIndex = 4
        Me.lbProducto.Text = "Pedido:"
        Me.lbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(97, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 37)
        Me.Label1.TabIndex = 375
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPedido
        '
        Me.lbPedido.Font = New System.Drawing.Font("Calibri", 14.2!, System.Drawing.FontStyle.Bold)
        Me.lbPedido.ForeColor = System.Drawing.Color.Black
        Me.lbPedido.Location = New System.Drawing.Point(5, 94)
        Me.lbPedido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPedido.Name = "lbPedido"
        Me.lbPedido.Size = New System.Drawing.Size(77, 37)
        Me.lbPedido.TabIndex = 376
        Me.lbPedido.Text = "0"
        Me.lbPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCliente
        '
        Me.lbCliente.Font = New System.Drawing.Font("Calibri", 14.2!, System.Drawing.FontStyle.Bold)
        Me.lbCliente.ForeColor = System.Drawing.Color.Black
        Me.lbCliente.Location = New System.Drawing.Point(99, 94)
        Me.lbCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(543, 37)
        Me.lbCliente.TabIndex = 377
        Me.lbCliente.Text = "Sin Nombre"
        Me.lbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbContado
        '
        '
        '
        '
        Me.tbContado.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbContado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbContado.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbContado.Increment = 1.0R
        Me.tbContado.Location = New System.Drawing.Point(31, 184)
        Me.tbContado.Name = "tbContado"
        Me.tbContado.Size = New System.Drawing.Size(158, 20)
        Me.tbContado.TabIndex = 378
        '
        'tbCredito
        '
        '
        '
        '
        Me.tbCredito.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCredito.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbCredito.Increment = 1.0R
        Me.tbCredito.Location = New System.Drawing.Point(254, 184)
        Me.tbCredito.Name = "tbCredito"
        Me.tbCredito.Size = New System.Drawing.Size(159, 20)
        Me.tbCredito.TabIndex = 379
        '
        'tbTransferencia
        '
        '
        '
        '
        Me.tbTransferencia.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTransferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTransferencia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTransferencia.Increment = 1.0R
        Me.tbTransferencia.Location = New System.Drawing.Point(471, 184)
        Me.tbTransferencia.Name = "tbTransferencia"
        Me.tbTransferencia.Size = New System.Drawing.Size(171, 20)
        Me.tbTransferencia.TabIndex = 380
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(27, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 37)
        Me.Label4.TabIndex = 381
        Me.Label4.Text = "Contado:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(250, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 37)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "Crédito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(467, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 37)
        Me.Label6.TabIndex = 383
        Me.Label6.Text = "Transferencia"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(287, 222)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 37)
        Me.Label7.TabIndex = 384
        Me.Label7.Text = "Total Pedido:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotal
        '
        Me.lbTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbTotal.ForeColor = System.Drawing.Color.Black
        Me.lbTotal.Location = New System.Drawing.Point(406, 222)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(145, 37)
        Me.lbTotal.TabIndex = 385
        Me.lbTotal.Text = "0.00"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F1_MontosPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 339)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTransferencia)
        Me.Controls.Add(Me.tbCredito)
        Me.Controls.Add(Me.tbContado)
        Me.Controls.Add(Me.lbCliente)
        Me.Controls.Add(Me.lbPedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F1_MontosPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F1_Cantidad"
        Me.Panel1.ResumeLayout(False)
        CType(Me.tbContado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnAgregar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbProducto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbPedido As Label
    Friend WithEvents lbCliente As Label
    Friend WithEvents tbContado As DevComponents.Editors.DoubleInput
    Friend WithEvents tbCredito As DevComponents.Editors.DoubleInput
    Friend WithEvents tbTransferencia As DevComponents.Editors.DoubleInput
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbTotal As Label
End Class
