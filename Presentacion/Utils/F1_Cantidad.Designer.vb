<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Cantidad
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
        Dim CbTipoDoc_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Cantidad))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnAgregar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbTipoDoc = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1.SuspendLayout()
        CType(Me.CbTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(502, 55)
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
        Me.ReflectionLabel1.Size = New System.Drawing.Size(278, 43)
        Me.ReflectionLabel1.TabIndex = 5
        Me.ReflectionLabel1.Text = "DETALLES DE LA FACTURA"
        '
        'btnAgregar
        '
        Me.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnAgregar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAgregar.Location = New System.Drawing.Point(261, 218)
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
        Me.ButtonX1.Location = New System.Drawing.Point(130, 218)
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
        Me.lbProducto.Location = New System.Drawing.Point(26, 75)
        Me.lbProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(375, 37)
        Me.lbProducto.TabIndex = 4
        Me.lbProducto.Text = "Tipo Factura:"
        Me.lbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(26, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 37)
        Me.Label1.TabIndex = 375
        Me.Label1.Text = "Cuit:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'CbTipoDoc
        '
        CbTipoDoc_DesignTimeLayout.LayoutString = resources.GetString("CbTipoDoc_DesignTimeLayout.LayoutString")
        Me.CbTipoDoc.DesignTimeLayout = CbTipoDoc_DesignTimeLayout
        Me.CbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoDoc.Location = New System.Drawing.Point(30, 114)
        Me.CbTipoDoc.Name = "CbTipoDoc"
        Me.CbTipoDoc.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.CbTipoDoc.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.CbTipoDoc.SelectedIndex = -1
        Me.CbTipoDoc.SelectedItem = Nothing
        Me.CbTipoDoc.Size = New System.Drawing.Size(444, 22)
        Me.CbTipoDoc.TabIndex = 376
        Me.CbTipoDoc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'tbNit
        '
        '
        '
        '
        Me.tbNit.Border.Class = "TextBoxBorder"
        Me.tbNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNit.Location = New System.Drawing.Point(30, 179)
        Me.tbNit.Name = "tbNit"
        Me.tbNit.PreventEnterBeep = True
        Me.tbNit.Size = New System.Drawing.Size(166, 20)
        Me.tbNit.TabIndex = 381
        Me.tbNit.Visible = False
        '
        'F1_Cantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 271)
        Me.Controls.Add(Me.tbNit)
        Me.Controls.Add(Me.CbTipoDoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F1_Cantidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F1_Cantidad"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CbTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnAgregar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbProducto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbTipoDoc As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbNit As DevComponents.DotNetBar.Controls.TextBoxX
End Class
