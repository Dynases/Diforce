Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports System.Drawing.Printing
Imports Entidades
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style


Public Class Dashboard
    Dim _inter As Integer
    Private _Rand As New Random()

#Region "Atributos"
    Dim _overlay1 As GMapOverlay
    Dim _overlay2 As GMapOverlay
    Dim _overlay3 As GMapOverlay
    Dim _soloRepartidor As Integer = 1
    'Dim _colCkeck = 23 '21 '19
    Dim _colCkeck = 26
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()


        cbProducto1.Text = "PRODUCTO MAS VENDIDO (" + gs_Mon + ")"
        cbVendedorMas.Text = "VENDEDOR QUE GENERA MAS VENTAS (" + gs_Mon + ")"
        Me.Text = "K P I"
        'Me.WindowState = FormWindowState.Maximized
        SuperTabControl1.SelectedTabIndex = 1
        SuperTabItem1.Visible = False

        'cargar mapas

        tbFechaF2.Value = Date.Now
        tbFechaI2.Value = Date.Now
        tbFechaFin.Value = Date.Now
        tbFechaIni.Value = Date.Now
        tbFechaF3.Value = Date.Now
        tbFechaI3.Value = Date.Now
        tbFechaF.Value = Date.Now
        tbFechaI.Value = Date.Now

        cbConci.Checked = True
        '_PCargarGridRegistrosPedidos()

        'cargar zonas
        CargarComboMes(cbMes)
        'CargarVendedores()


        _pCambiarFuente()
        _PAsignarPermisos()

        'OCULTAR EL TAB DE ENTREGADOS
        'SuperTabItem4.Visible = False
    End Sub

    'Private Sub CargarVendedores()
    '    Dim dt As DataTable = L_prVentasGraficaListarRepartidores()

    '    grVendedor.BoundMode = Janus.Data.BoundMode.Bound
    '    grVendedor.DataSource = dt
    '    grVendedor.RetrieveStructure()

    '    'dar formato a las columnas
    '    With grVendedor.RootTable.Columns("estado")
    '        .Caption = "Check"
    '        .Width = 50
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .Visible = False
    '    End With
    '    With grVendedor.RootTable.Columns("cbnumi")
    '        .Caption = "Check"
    '        .Width = 50
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .Visible = False
    '    End With
    '    With grVendedor.RootTable.Columns("ydcod")
    '        .Caption = "Check"
    '        .Width = 50
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .Visible = False
    '    End With
    '    With grVendedor.RootTable.Columns("vendedor")
    '        .Caption = "VENDEDOR"
    '        .Width = 50

    '        .Visible = True
    '    End With

    '    'Habilitar Filtradores
    '    With grVendedor
    '        .GroupByBoxVisible = False
    '        .ColumnAutoResize = True
    '        '.FilterRowFormatStyle.BackColor = Color.Blue
    '        .DefaultFilterRowComparison = FilterConditionOperator.Contains
    '        '.FilterMode = FilterMode.Automatic
    '        .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
    '        'Diseño de la tabla
    '        .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
    '        .SelectionMode = SelectionMode.MultipleSelection
    '        .AlternatingColors = True
    '    End With
    'End Sub
    Private Sub CargarComboMes(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = TListarMeses()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cenum").Width = 60
            .DropDownList.Columns("cenum").Caption = "COD"
            .DropDownList.Columns.Add("cedesc").Width = 200
            .DropDownList.Columns("cedesc").Caption = "MES"
            .ValueMember = "cenum"
            .DisplayMember = "cedesc"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub InitializeGrid()
        Dim panel As GridPanel = grPresupuesto.PrimaryGrid

        InitPanel(panel)
    End Sub

    Private Sub InitializeGrid2()
        Dim panel As GridPanel = grKPI2.PrimaryGrid

        InitPanel2(panel)
    End Sub

    Private Sub InitPanel2(ByVal panel As GridPanel)
        panel.CheckBoxes = True
        panel.ShowCheckBox = False
        panel.ShowTreeButtons = True
        panel.ShowTreeLines = True
        panel.ShowRowGridIndex = True

        panel.RowHeaderWidth = 40
        panel.DefaultRowHeight = 0
        panel.ColumnHeader.RowHeight = 30

        panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter
        panel.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleCenter

        Dim dt As DataTable
        If cbConci.Checked = True Then
            dt = TraerKPI2()
        Else
            dt = TraerKPI21(tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"))
        End If
        panel.DataSource = dt
        'AplicarFiltroColor2()

    End Sub

    Private Sub InitPanel(ByVal panel As GridPanel)
        panel.CheckBoxes = True
        panel.ShowCheckBox = False
        panel.ShowTreeButtons = True
        panel.ShowTreeLines = True
        panel.ShowRowGridIndex = True

        panel.RowHeaderWidth = 40
        panel.DefaultRowHeight = 0
        panel.ColumnHeader.RowHeight = 30

        panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter
        panel.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleCenter

        AddPanelData(panel)

    End Sub

    Private Sub AddPanelData(ByVal panel As GridPanel)
        'Dim l As Integer = _Rand.Next(5, 8)

        'For i As Integer = 0 To l - 1
        '    Dim col As New GridColumn("Column " & (i + 1))

        '    col.Width = 130
        '    col.InfoImageAlignment = Alignment.MiddleLeft
        '    col.EditorType = GetType(GridDoubleInputEditControl)

        '    panel.Columns.Add(col)
        'Next i

        'Dim m As Integer = _Rand.Next(3, 20)

        'For i As Integer = 0 To m - 1
        '    Dim row As New GridRow()

        '    If i Mod 5 = 0 Then
        '        row.CellStyles.Default.BorderThickness = New Thickness(1)
        '        row.CellStyles.Default.Margin = New DevComponents.DotNetBar.SuperGrid.Style.Padding(4)
        '    End If

        '    Dim t As Integer = 100
        '    Dim n As Integer = _Rand.Next(2, l)

        '    For j As Integer = 0 To n - 1
        '        Dim k As Integer = IIf(j = n - 1, t, _Rand.Next(0, t))

        '        row.Cells.Add(New GridCell(CDbl(k)))

        '        t -= k
        '    Next j

        '    panel.Rows.Add(row)

        'Next i

        Dim dt As DataTable = TraerKPI1(cbMes.Value, CInt(tbAño.Text))

        panel.DataSource = dt
        AplicarFiltroColor2()
    End Sub
    Private Sub _PAsignarPermisos()
        'Dim idRolUsu As String = L_Usuario_General(-1, " AND yduser='" + gs_user + "' ").Tables(0).Rows(0).Item("ybnumi")
        'Dim dtRolUsu As DataTable = L_RolDetalle_General2(-1, idRolUsu, "ycyanumi=9")
        'Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        'Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        'Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        'Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        ''If add = False Then
        ''    'BBtn_Nuevo.Visible = False
        ''    btNuevo.Visible = False
        ''End If
        ''If modif = False Then
        ''    'BBtn_Modificar.Visible = False
        ''    btModificar.Visible = False
        ''End If
        'If del = False Then
        '    btBorrarPedInvalidos.Visible = False
        '    ANULARPEDIDOToolStripMenuItem.Visible = False
        '    ANULARPEDIDOToolStripMenuItem1.Visible = False
        'End If

    End Sub

    Private Sub _pCambiarFuente()

        'For Each xCtrl In PanelEx12.Controls
        '    Try
        '        xCtrl.Font = fuente
        '    Catch ex As Exception
        '    End Try
        'Next



    End Sub


    Private Sub _PCargarGridRegistrosPedidos(ByRef objGrid As Janus.Windows.GridEX.GridEX, estado As String, Optional ByVal codZona As String = "", Optional ByVal codRep As String = "-1")
        Dim dtReg As DataTable
        If codZona = "" Then
            If codRep = "-1" Then
                dtReg = L_PedidoCabecera_General(-1, " AND (oaest=" + estado + " ) ")
            Else
                If estado = "1" Then
                    dtReg = L_PedidoCabecera_GeneralSoloRepartidor(-1, " AND (oaest=" + estado + " )" + " AND tl0012.lccbnumi=" + codRep)
                Else
                    dtReg = L_PedidoCabecera_GeneralSoloRepartidor(-1, " AND (oaest=" + estado + " )" + " AND tl0012.lccbnumi=" + codRep)
                End If
            End If
        Else
            If codRep = "-1" Then
                dtReg = L_PedidoCabecera_General(-1, " AND (oaest=" + estado + ") AND oazona= " + codZona + " ")
            Else
                dtReg = L_PedidoCabecera_General(-1, " AND (oaest=" + estado + " ) AND oazona= " + codZona + " AND oarepa=" + codRep + " ")
            End If

        End If


        'añadir columna de check box
        dtReg.Columns.Add("Check", Type.GetType("System.Boolean"))
        Dim i As Integer
        For i = 0 To dtReg.Rows.Count - 1
            dtReg.Rows(i).Item("Check") = False
        Next


        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dtReg
        objGrid.RetrieveStructure()
        With objGrid.RootTable.Columns("monto")
            .Width = 70
            .Visible = True
            .Caption = "Total"
            .FormatString = "0.00"
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .AggregateFunction = AggregateFunction.Sum
        End With
        'dar formato a las columnas
        With objGrid.RootTable.Columns(0)
            .Caption = "Cod.Ped"
            .Key = "CodPedido"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With objGrid.RootTable.Columns(1)
            .Caption = "Fecha"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(2)
            .Key = "hora"
            .Caption = "Hora"
            .Width = 55
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(3)
            .Visible = False
            .Key = "codCliente"
            .Caption = "Cod. Cliente"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With objGrid.RootTable.Columns(4)
            .Caption = "Nombre"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(5)
            .Caption = "Direccion"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(6)
            .Caption = "Telefono"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(7)
            .Visible = False
        End With

        With objGrid.RootTable.Columns(8)
            .Key = "zona"
            .Visible = False
        End With

        With objGrid.RootTable.Columns(9)
            .Caption = "Zona"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(10)
            .Visible = False
            .Key = "ObsPedido"
        End With

        With objGrid.RootTable.Columns(11)
            .Visible = False
            .Key = "ObsPedido2"
        End With

        With objGrid.RootTable.Columns(12) 'estado
            .Visible = False
        End With

        'latitud y longitud
        With objGrid.RootTable.Columns(13)
            .Key = "Latitud"
            .Visible = False
        End With

        With objGrid.RootTable.Columns(14)
            .Key = "Longitud"
            .Visible = False
        End With

        With objGrid.RootTable.Columns("oaap")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("reclamo")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("oapg")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("ccultvent")
            .Caption = "Ult. Venta"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns("tipoRecCliente")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("tipoRecRepartidor")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("ccnumi")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("cceven")
            .Visible = False
        End With
        With objGrid.RootTable.Columns("oaanumiprev")
            .Visible = False
        End With
        With objGrid.RootTable.Columns("cbdesc")
            .Caption = "Vendedor"
            .Width = 120
        End With

        'objGrid.RootTable.Columns.Add("Check")
        With objGrid.RootTable.Columns(_colCkeck)
            .Visible = True
            .key = "check"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = False
            .CheckBoxTrueValue = True
        End With

        'Habilitar Filtradores
        With objGrid
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
            .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        End With

        'poner color a la fila de acuerdo a la condicion 
        Dim fc, fc1, fc2, fc3, fc66, fcRecClient, fcRecRepart As GridEXFormatCondition
        fc = New GridEXFormatCondition(objGrid.RootTable.Columns("reclamo"), ConditionOperator.Equal, 1)
        'fc.FormatStyle.BackColor = Color.LightYellow
        fc.FormatStyle.ForeColor = Color.Red

        fc1 = New GridEXFormatCondition(objGrid.RootTable.Columns("oapg"), ConditionOperator.Equal, 1)
        fc1.FormatStyle.BackColor = Color.LightGreen

        'pedido generado desde el celular
        fc66 = New GridEXFormatCondition(objGrid.RootTable.Columns("oapg"), ConditionOperator.Equal, 11)
        fc66.FormatStyle.BackColor = Color.LightCyan

        'formato para decir si es un pedido esta entregado y con nota
        fc2 = New GridEXFormatCondition(objGrid.RootTable.Columns("oaest"), ConditionOperator.Equal, 4)
        fc2.FormatStyle.BackColor = Color.LightGray

        'formato para decir si es un pedido fue regerado a partir de otro pedido
        fc3 = New GridEXFormatCondition(objGrid.RootTable.Columns("oapg"), ConditionOperator.Equal, 2)
        fc3.FormatStyle.BackColor = Color.Yellow

        'formato para decir si es un pedido tiene reclamo de un repartidor
        fcRecRepart = New GridEXFormatCondition(objGrid.RootTable.Columns("tipoRecRepartidor"), ConditionOperator.Equal, 1)
        fcRecRepart.FormatStyle.BackColor = Color.LightYellow

        'formato para decir si es un pedido tiene reclamo de un cliente
        fcRecClient = New GridEXFormatCondition(objGrid.RootTable.Columns("tipoRecCliente"), ConditionOperator.Equal, 1)
        fcRecClient.FormatStyle.BackColor = Color.LightGreen

        objGrid.RootTable.FormatConditions.Add(fc)
        objGrid.RootTable.FormatConditions.Add(fc1)
        objGrid.RootTable.FormatConditions.Add(fc2)
        objGrid.RootTable.FormatConditions.Add(fc3)
        objGrid.RootTable.FormatConditions.Add(fc66)

        objGrid.RootTable.FormatConditions.Add(fcRecRepart)
        objGrid.RootTable.FormatConditions.Add(fcRecClient)

        If estado = "3" Then
            objGrid.RootTable.Columns("Check").Visible = False 'oculto el check
        Else
            objGrid.RootTable.Columns("Check").Visible = True 'oculto el check
        End If
    End Sub

    Private Sub _PCargarGridRegistrosPedidosInvalidos(ByRef objGrid As Janus.Windows.GridEX.GridEX, estado As String, Optional ByVal codZona As String = "", Optional ByVal codRep As String = "-1")
        Dim dtReg As DataTable
        If codZona = "" Then
            If codRep = "-1" Then
                dtReg = L_PedidoCabecera_General(-1, " AND (oaest=" + estado + " ) AND oaap=1 and ccultvent>=oafdoc ")
            Else
                dtReg = L_PedidoCabecera_GeneralSoloRepartidor(-1, " AND (oaest=" + estado + " ) AND oaap=1" + " AND tl0012.lccbnumi=" + codRep + " and ccultvent>=oafdoc")
            End If
        Else
            If codRep = "-1" Then
                dtReg = L_PedidoCabecera_General(-1, " AND (oaest=" + estado + ") AND oazona= " + codZona + " AND oaap=1 and ccultvent>=oafdoc")
            Else
                dtReg = L_PedidoCabecera_General(-1, " AND (oaest=" + estado + " ) AND oazona= " + codZona + " AND oarepa=" + codRep + " AND oaap=1 and ccultvent>=oafdoc")
            End If

        End If


        'añadir columna de check box
        dtReg.Columns.Add("Check", Type.GetType("System.Boolean"))
        Dim i As Integer
        For i = 0 To dtReg.Rows.Count - 1
            dtReg.Rows(i).Item("Check") = False
        Next


        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dtReg
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns(0)
            .Caption = "Cod."
            .Key = "CodPedido"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With
        With objGrid.RootTable.Columns(1)
            .Caption = "Fecha"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(2)
            .Caption = "Hora"
            .Width = 55
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(3)
            .Visible = False
            .Caption = "Cod. Cliente"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(4)
            .Caption = "Nombre"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(5)
            .Caption = "Direccion"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(6)
            .Caption = "Telefono"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(7)
            .Visible = False
        End With

        With objGrid.RootTable.Columns(8)
            .Visible = False
        End With

        With objGrid.RootTable.Columns(9)
            .Caption = "Zona"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(10)
            .Visible = False
            .Key = "ObsPedido"
        End With

        With objGrid.RootTable.Columns(11)
            .Visible = False
            .Key = "ObsPedido2"
        End With

        With objGrid.RootTable.Columns(12) 'estado
            .Visible = False
        End With

        'latitud y longitud
        With objGrid.RootTable.Columns(13)
            .Key = "Latitud"
            .Visible = False
        End With

        With objGrid.RootTable.Columns(14)
            .Key = "Longitud"
            .Visible = False
        End With

        With objGrid.RootTable.Columns("oaap")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("reclamo")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("oapg")
            .Visible = False
        End With

        With objGrid.RootTable.Columns("ccultvent")
            .Caption = "Ult. Pedido"
            .Width = 90
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns("ccnumi")
            .Visible = True
        End With

        With objGrid.RootTable.Columns("cceven")
            .Visible = True
        End With
        With objGrid.RootTable.Columns("oaanumiprev")
            .Visible = False
        End With
        With objGrid.RootTable.Columns("cbdesc")
            .Caption = "Vendedor"
            .Width = 120
        End With
        'objGrid.RootTable.Columns.Add("Check")
        With objGrid.RootTable.Columns(_colCkeck)
            .Visible = True
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = False
            .CheckBoxTrueValue = True
        End With

        'Habilitar Filtradores
        With objGrid
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        End With

        'poner color a la fila de acuerdo a la condicion 
        Dim fc, fc1, fc2 As GridEXFormatCondition
        fc = New GridEXFormatCondition(objGrid.RootTable.Columns("reclamo"), ConditionOperator.Equal, 1)
        'fc.FormatStyle.BackColor = Color.LightYellow
        fc.FormatStyle.ForeColor = Color.Red

        fc1 = New GridEXFormatCondition(objGrid.RootTable.Columns("oapg"), ConditionOperator.Equal, 1)
        fc1.FormatStyle.BackColor = Color.LightGreen

        fc2 = New GridEXFormatCondition(objGrid.RootTable.Columns("oapg"), ConditionOperator.Equal, 11)
        fc2.FormatStyle.BackColor = Color.LightCyan
        'fc.FormatStyle.ForeColor = Color.Red

        objGrid.RootTable.FormatConditions.Add(fc)
        objGrid.RootTable.FormatConditions.Add(fc1)
        objGrid.RootTable.FormatConditions.Add(fc2)

        If estado = "2" Then
            objGrid.RootTable.Columns("Check").Visible = False 'oculto el check
        End If
    End Sub

    Private Sub _PCargarGridDetalle(ByRef objGrid As Janus.Windows.GridEX.GridEX, idCabecera As Integer)
        Dim dtProd As New DataTable
        dtProd = L_PedidoDetalle_General(-1, idCabecera)

        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dtProd
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns(0)
            .Visible = False
        End With

        With objGrid.RootTable.Columns(1)
            .Caption = "Cod. Prod."
            .Key = "CodProd"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(2)
            .Caption = "Producto"
            .Key = "Producto"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .AllowSort = False
        End With

        With objGrid.RootTable.Columns(3)
            .Caption = "Cantidad"
            .Key = "Cantidad"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With
        With objGrid.RootTable.Columns(4)
            .Caption = "Precio"
            .Key = "Precio"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With
        With objGrid.RootTable.Columns(5)
            .Caption = "Monto Bs."
            .Key = "Monto"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
        End With
        With objGrid.RootTable.Columns(6)
            .Caption = "Descuento"
            .Key = "Descuento"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
        End With
        With objGrid.RootTable.Columns(7)
            .Caption = "Total Bs."
            .Key = "Total"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
        End With
        With objGrid.RootTable.Columns(8)
            .Caption = "Familia"
            .Key = "Familia"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
            .Visible = False
        End With

        'Habilitar Filtradores
        With objGrid
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
            'Diseño de la tabla
            .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        End With

    End Sub

    Private Sub _PCargarGridZonas(ByRef objGrid As Janus.Windows.GridEX.GridEX)
        Dim dt As New DataTable
        dt = L_ZonaCabecera_GeneralCompleto(0).Tables(0)

        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dt
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns(0)
            .Caption = "Cod."
            .Key = "CodRepartidor"
            .Width = 40
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns(1)
            .Caption = "Repartidor/Vendedor"
            .Key = "Repartidor"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns(2)
            .Caption = "Codigo"
            .Key = "Codigo"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With objGrid.RootTable.Columns(3)
            .Key = "CodCiudad"
            .Visible = False
        End With
        With objGrid.RootTable.Columns(4)
            .Caption = "Ciudad"
            .Key = "Ciudad"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(5)
            .Key = "CodProvincia"
            .Visible = False
        End With
        With objGrid.RootTable.Columns(6)
            .Caption = "Provincia"
            .Key = "Provincia"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With objGrid.RootTable.Columns(7)
            .Key = "CodZona"
            .Visible = False
        End With
        With objGrid.RootTable.Columns(8)
            .Caption = "Zona"
            .Key = "Zona"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With
        With objGrid.RootTable.Columns(9)
            .Visible = False
            .Key = "Color"
        End With


        'Habilitar Filtradores
        With objGrid
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        End With

    End Sub

    Private Sub _PCargarGridZonasSoloRepartidores(ByRef objGrid As Janus.Windows.GridEX.GridEX)
        Dim dt As New DataTable
        dt = L_Empleado_GeneralSimple(-1, "and cbcat in (1,3) and cbest=1 ").Tables(0)

        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dt
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns("cbnumi")
            .Caption = "Cod."
            .Key = "CodRepartidor"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns("cbdesc")
            .Caption = "Repartidor"
            .Key = "Repartidor"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
        End With


        'Habilitar Filtradores
        With objGrid
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        End With

    End Sub


    'Private Sub _PGrabarAsignaciones()
    '    Dim i, cant, codPedido As Integer
    '    Dim estado As Boolean
    '    cant = 0
    '    For i = 0 To JGr_Registros1.RowCount - 1
    '        JGr_Registros1.Row = i
    '        estado = JGr_Registros1.GetValue("Check")
    '        If estado = True Then
    '            codPedido = JGr_Registros1.GetValue("CodPedido")

    '            L_PedidoEstados_Grabar(codPedido, "2", Date.Now.Date.ToString("yyyy/MM/dd"), Now.Hour.ToString + ":" + Now.Minute.ToString, gs_user)
    '            L_PedidoCabacera_ModificarEstado(codPedido, "2")
    '            L_PedidoCabacera_ModificarCodRep(codPedido, Tb_CodRep1.Text)
    '            cant = cant + 1


    '            Dim objListDetalle As New List(Of RequestDetail)

    '            Dim codProd, cantidad, precio, subTotal As String
    '            For Each fil As GridEXRow In JGr_Detalles1.GetRows
    '                codProd = fil.Cells("CodProd").Value.ToString
    '                cantidad = fil.Cells("Cantidad").Value.ToString
    '                precio = fil.Cells("Precio").Value.ToString
    '                subTotal = fil.Cells("Monto").Value.ToString

    '                objListDetalle.Add(New RequestDetail(codPedido, codProd, cantidad, precio, subTotal, L_ClaseGetProducto(codProd)))
    '            Next

    '            If (gi_notiPed = 1) Then
    '                '-----------------'MANDAR LA NOTIFICACION DEL PEDIDO '-----------------------------------------------
    '                Dim objResult As New Result
    '                Dim dtRepartidor As DataTable = L_fnObtenerRepartidor(JGr_Registros1.GetValue("zona").ToString)
    '                Dim codRep As String = "-1"
    '                If dtRepartidor.Rows.Count > 0 Then
    '                    codRep = dtRepartidor.Rows(0).Item("lccbnumi").ToString
    '                End If
    '                'Dim s As String = JGr_Registros1.GetValue("codCliente").ToString
    '                Dim objPedido As New RequestHeader(codPedido, Date.Now.Date.ToString("yyyy-MM-dd"),
    '                                                   JGr_Registros1.GetValue("hora").ToString,
    '                                                   JGr_Registros1.GetValue("ccnumi").ToString,
    '                                                   JGr_Registros1.GetValue("zona"),
    '                                                   codRep, JGr_Registros1.GetValue("ObsPedido").ToString, "",
    '                                                    "1", "1", "0",
    '                                                   Date.Now.Date.ToString("yyyy-MM-dd"),
    '                                                   Now.Hour.ToString + ":" + Now.Minute.ToString, gs_user,
    '                                                   objListDetalle, L_ClaseGetCliente(L_fnObtenerTabla("oaccli", "TO001", "oanumi=" + codPedido.ToString).Rows(0).Item("oaccli").ToString))
    '                Dim dtLlave As DataTable = L_TC0022General(codRep)
    '                If dtLlave.Rows.Count > 0 Then
    '                    Dim llaveRep As String = dtLlave(0).Item("ckidfsm").ToString
    '                    objResult.fcmToken = llaveRep
    '                    objResult.mRequestHeader = objPedido
    '                    Dim respuesta As Boolean = JsonApiClient._prMandarNotificacion(objResult)
    '                    If respuesta = False Then
    '                        'ToastNotification.Show(Me, "El Pedido no se pudo enviar a la app del repartidor".ToUpper, My.Resources.WARNING, 10000, eToastGlowColor.Red, eToastPosition.TopCenter)
    '                    End If
    '                Else
    '                    'ToastNotification.Show(Me, "no se pudo enviar el pedido al repartidor!!! , ".ToUpper + "el repartidor con codigo: ".ToUpper + codRep + " no tiene grabado su llave en la tabla TC0022", My.Resources.WARNING, 10000, eToastGlowColor.Red, eToastPosition.TopCenter)
    '                End If
    '            End If


    '        End If
    '    Next

    '    ToastNotification.Show(Me, Str(cant) + " Pedidos Asignados Exitosamente", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)

    '    'actualizar registros PENDIENTE:TIENE QUE CARGAR LOS REGISTROS DE LA ZONA SELECCIONADA
    '    If _soloRepartidor = 0 Then
    '        Dim codZonaSelected As Integer = JGr_Zonas1.CurrentRow.Cells("Codigo").Value
    '        _PCargarGridRegistrosPedidos(JGr_Registros1, "1", codZonaSelected)
    '        P_prPonerCodicion()
    '        'actualizo  la tabla de registros del asignacion de pedidos y confirmacion de entregas
    '        _PCargarGridRegistrosPedidos(JGr_Registros2, "2", codZonaSelected, Tb_CodRep2.Text)
    '    Else
    '        _PCargarGridRegistrosPedidos(JGr_Registros1, "1", , Tb_CodRep1.Text)
    '        P_prPonerCodicion()
    '        'actualizo  la tabla de registros del asignacion de pedidos y confirmacion de entregas
    '        _PCargarGridRegistrosPedidos(JGr_Registros2, "2", , Tb_CodRep2.Text)
    '    End If

    'End Sub





    Private Sub _PCargarMapa(ByRef objMapa As GMapControl, ByRef objOverlay As GMapOverlay)

        objOverlay = New GMapOverlay("polygons")
        objMapa.Overlays.Add(objOverlay)

        objMapa.DragButton = MouseButtons.Left
        objMapa.CanDragMap = True
        objMapa.MapProvider = GMapProviders.GoogleMap
        objMapa.Position = New PointLatLng(-17.380941, -66.15976)
        objMapa.MinZoom = 0
        objMapa.MaxZoom = 24
        objMapa.Zoom = 13
        objMapa.AutoScroll = True
        GMapProvider.Language = LanguageType.Spanish
    End Sub
    Private Sub _PDibujarZona(idZona As Integer, ByRef objOverlay As GMapOverlay, colorZona As String)
        'cargar zona en mapa
        Dim tPuntos As DataTable = L_ZonaDetallePuntos_General(-1, idZona).Tables(0)
        Dim i As Integer
        Dim lati, longi As Double
        Dim listPuntos As New List(Of PointLatLng)
        For i = 0 To tPuntos.Rows.Count - 1
            lati = tPuntos.Rows(i).Item(1)
            longi = tPuntos.Rows(i).Item(2)
            Dim plg As PointLatLng = New PointLatLng(lati, longi)
            listPuntos.Add(plg)
        Next

        If listPuntos.Count > 0 Then
            'Dim color1 As String = JGr_Zonas1.CurrentRow.Cells(7).Value
            Dim colorFinal As Color = ColorTranslator.FromHtml(colorZona)

            Dim polygon As New GMapPolygon(listPuntos, "mypolygon")
            'agregar color
            polygon.Fill = New SolidBrush(Color.FromArgb(50, colorFinal))
            polygon.Stroke = New Pen(Color.Red, 1)
            objOverlay.Polygons.Clear()
            objOverlay.Polygons.Add(polygon)
        Else
            objOverlay.Polygons.Clear()
        End If

    End Sub

    Private Sub _PDibujarPunto(ByRef objOverlay As GMapOverlay, pointLatLng As PointLatLng, Optional etiqueta As String = "")

        'añadir puntos
        ''Dim markersOverlay As New GMapOverlay("markers")
        Dim marker As New GMarkerGoogle(pointLatLng, GMarkerGoogleType.blue)
        'añadir tooltip
        If etiqueta <> "" Then
            Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTipMode = mode
            Dim ToolTipBackColor As New SolidBrush(Color.Red)
            marker.ToolTip.Fill = ToolTipBackColor
            marker.ToolTipText = etiqueta
        End If
        objOverlay.Markers.Clear()
        objOverlay.Markers.Add(marker)
        'mapa.Overlays.Add(markersOverlay)
    End Sub



#End Region

    Private Sub P_PedidosAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub JGr_Registros_EditingCell(sender As Object, e As EditingCellEventArgs)
        If e.Column.Index <> _colCkeck Then
            e.Cancel = True
        End If
    End Sub

    Private Sub JGr_Detalles_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub



    Private Sub JGr_Zonas_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub


    'Private Sub P_prPonerCodicion()
    '    'poner color a la fila de acuerdo a la condicion 
    '    Dim fc As GridEXFormatCondition
    '    fc = New GridEXFormatCondition(JGr_Registros1.RootTable.Columns("cceven"), ConditionOperator.Equal, 1)
    '    fc.FormatStyle.BackColor = Color.Blue
    '    fc.FormatStyle.ForeColor = Color.White

    '    JGr_Registros1.RootTable.FormatConditions.Add(fc)
    'End Sub





    Private Sub JGr_Registros_SelectionChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub JGr_Registros2_SelectionChanged(sender As Object, e As EventArgs)

    End Sub






    Private Sub JGr_Zonas2_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub JGr_Detalles2_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub JGr_Registros2_EditingCell(sender As Object, e As EditingCellEventArgs)
        If e.Column.Index <> _colCkeck Then
            e.Cancel = True
        End If
    End Sub

    Private Sub JGr_Zonas3_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub JGr_Registros3_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub JGr_Detalles3_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub



















































    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        Try
            Dim iIni, iFin As Integer

            Select Case e.NewValue.ToString
                Case "PEDIDOS PENDIENTES"
                    iIni = 1
                Case "PEDIDOS DICTADOS"
                    iIni = 2
                Case "PEDIDOS ENTREGADOS"
                    iIni = 3
            End Select
            Select Case e.NewValue.ToString
                Case "PEDIDOS PENDIENTES"
                    iFin = 1
                Case "PEDIDOS DICTADOS"
                    iFin = 2
                Case "PEDIDOS ENTREGADOS"
                    iFin = 3
            End Select




        Catch ex As Exception

        End Try
    End Sub













    Private Sub P_PedidosAsignacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '_modulo.Select()
        '_tab.Close()
    End Sub

    Private Sub P_ImprimirRecibos(numi As String, printerName As String)
        Dim dt As DataTable

        dt = L_fnObtenerTabla("oanumi, oafdoc, cedesc, oarepa, cbdesc, ccnumi, cccod, ccdesc, obpcant, cadesc2, obpbase, obptot, cctelf1, ccdirec, oaobs, oaanumiprev, cbdesc2",
                              "vr_go_reciboCliente", "oanumi=" + numi)

        Dim objrep As New R_ReciboCliente
        objrep.SetDataSource(dt)
        objrep.PrintOptions.PrinterName = printerName
        objrep.PrintToPrinter(1, False, 1, 1)
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _inter = _inter + 1
        If _inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub


    Private Sub GroupPanel4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub grPresupuesto_AfterCheck(sender As Object, e As GridAfterCheckEventArgs) Handles grPresupuesto.AfterCheck
        Dim crow As GridRow = TryCast(e.Item, GridRow)

        ' If the check state is going from unchecked to
        ' checked, then add anew sub panel under the the
        ' row that was checked.

        If crow IsNot Nothing AndAlso crow.Checked = True Then
            Dim panel As New GridPanel()

            panel.CheckBoxes = False
            panel.ShowCheckBox = True
            panel.ShowTreeButtons = True
            panel.ShowTreeLines = True
            panel.ShowRowGridIndex = True

            panel.RowHeaderWidth = 40
            panel.DefaultRowHeight = 0
            panel.ColumnHeader.RowHeight = 30

            panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter
            panel.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleCenter

            Dim dt As DataTable = TraerKPI1detalle(cbMes.Value, CInt(tbAño.Text), crow.Cells(0).Value)

            panel.DataSource = dt

            crow.Rows.Add(panel)

            ' Since we are always adding the row to the end
            ' of the list, lets make sure it is visible on the screen

            panel.EnsureVisible(True)
            AplicarFiltroColor(panel)

        End If
    End Sub

    Private Sub AplicarFiltroColor(panel As GridPanel)
        grPresupuesto.Refresh()

        For Each r As GridRow In panel.Rows
            If r.Cells("PORCENTAJE").Value < 30 Then
                r.Cells("PORCENTAJE").CellStyles.Default.Background.Color2 = Color.Red

            ElseIf r.Cells("PORCENTAJE").Value < 70 Then
                r.Cells("PORCENTAJE").CellStyles.Default.Background.Color2 = Color.Yellow

            ElseIf r.Cells("PORCENTAJE").Value > 70 Then
                r.Cells("PORCENTAJE").CellStyles.Default.Background.Color2 = Color.Green
            End If

        Next
    End Sub

    Private Sub AplicarFiltroColor2()
        grPresupuesto.Refresh()

        For Each e As GridRow In grPresupuesto.PrimaryGrid.Rows
            If e.Cells("PORCENTAJE").Value < 30 Then
                e.Cells("PORCENTAJE").CellStyles.Default.Background.Color2 = Color.Red

            ElseIf e.Cells("PORCENTAJE").Value < 70 Then
                e.Cells("PORCENTAJE").CellStyles.Default.Background.Color2 = Color.Yellow

            ElseIf e.Cells("PORCENTAJE").Value > 70 Then
                e.Cells("PORCENTAJE").CellStyles.Default.Background.Color2 = Color.Green
            End If

        Next
    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        InitializeGrid()
        AplicarFiltroColor2()
    End Sub

    Private Sub btGenerar2_Click(sender As Object, e As EventArgs) Handles btGenerar2.Click
        InitializeGrid2()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub grKPI2_AfterCheck(sender As Object, e As GridAfterCheckEventArgs) Handles grKPI2.AfterCheck
        Dim crow As GridRow = TryCast(e.Item, GridRow)

        ' If the check state is going from unchecked to
        ' checked, then add anew sub panel under the the
        ' row that was checked.

        If crow IsNot Nothing AndAlso crow.Checked = True Then
            Dim panel As New GridPanel()

            panel.CheckBoxes = False
            panel.ShowCheckBox = True
            panel.ShowTreeButtons = True
            panel.ShowTreeLines = True
            panel.ShowRowGridIndex = True

            panel.RowHeaderWidth = 40
            panel.DefaultRowHeight = 0
            panel.ColumnHeader.RowHeight = 30

            panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter
            panel.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleCenter

            Dim dt As DataTable
            If cbConci.Checked = True Then
                dt = TraerKPI2detalle(crow.Cells("CONCILIACION").Value)
            Else
                dt = TraerKPI21detalle(crow.Cells("CODIGO").Value, tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"))
            End If

            panel.DataSource = dt

            crow.Rows.Add(panel)

            ' Since we are always adding the row to the end
            ' of the list, lets make sure it is visible on the screen

            panel.EnsureVisible(True)

            grKPI2.Refresh()

            For Each r As GridRow In panel.Rows
                If r.Cells("ESTADO").Value = "ENTREGADO" Then
                    r.Cells("ESTADO").CellStyles.Default.Background.Color2 = Color.Green

                ElseIf r.Cells("ESTADO").Value <> "ENTREGADO" Then
                    r.Cells("ESTADO").CellStyles.Default.Background.Color2 = Color.Red
                End If

            Next

        End If
    End Sub

    Private Sub ProductosMas_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function InterpretarDatos(orden As Integer) As DataTable
        Dim dt As DataTable
        If cbProducto1.Checked = True Then
            dt = TraerKPIProducto1(tbFechaIni.Value.ToString("dd/MM/yyyy"), tbFechaFin.Value.ToString("dd/MM/yyyy"), tbtop.Value, orden)
        ElseIf cbProducto2.Checked = True Then
            dt = TraerKPIProducto2(tbFechaIni.Value.ToString("dd/MM/yyyy"), tbFechaFin.Value.ToString("dd/MM/yyyy"), tbtop.Value, orden)
        ElseIf cbProducto3.Checked = True Then
            dt = TraerKPIProducto3(tbFechaIni.Value.ToString("dd/MM/yyyy"), tbFechaFin.Value.ToString("dd/MM/yyyy"), tbtop.Value, orden)
        End If
        Return dt
    End Function

    Private Function InterpretarDatos3() As DataTable
        Dim dt As DataTable
        If cbVendedorMas.Checked = True Then
            dt = TraerKPIVendedor1(tbFechaI3.Value.ToString("dd/MM/yyyy"), tbFechaF3.Value.ToString("dd/MM/yyyy"), tbTop3.Value)
        ElseIf cbVendedorUtilidad.Checked = True Then
            dt = TraerKPIVendedor2(tbFechaI3.Value.ToString("dd/MM/yyyy"), tbFechaF3.Value.ToString("dd/MM/yyyy"), tbTop3.Value)
        End If
        Return dt
    End Function

    Private Sub CargarReporte(orden As Integer)
        Dim _dt As New DataTable
        _dt = InterpretarDatos(orden)
        If cbProducto1.Checked = True Then

            '                                   FechaFVendedor.ToString("yyyy/MM/dd"))
            'If (_dt.Rows.Count > 0) Then
            If orden = 1 Then
                Dim objrep As New R_ProductoMayor()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                objrep.SetParameterValue(3, CInt(orden))
                ProductosMas.ReportSource = objrep
                ProductosMas.Show()
                ProductosMas.BringToFront()
            Else
                Dim objrep As New R_ProductoMenor()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                objrep.SetParameterValue(3, CInt(orden))
                ProductosMas.ReportSource = objrep
                ProductosMas.Show()
                ProductosMas.BringToFront()
            End If



        ElseIf cbProducto2.Checked = True Then

            '                                   FechaFVendedor.ToString("yyyy/MM/dd"))
            'If (_dt.Rows.Count > 0) Then
            If orden = 1 Then
                Dim objrep As New R_ProductoMayorUtilidad()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                ProductosMas.ReportSource = objrep
                ProductosMas.Show()
                ProductosMas.BringToFront()
            Else
                Dim objrep As New R_ProductoMenorUtilidad()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)

                ProductosMas.ReportSource = objrep
                ProductosMas.Show()
                ProductosMas.BringToFront()
            End If
        ElseIf cbProducto3.Checked = True Then

            '                                   FechaFVendedor.ToString("yyyy/MM/dd"))
            'If (_dt.Rows.Count > 0) Then
            If orden = 1 Then
                Dim objrep As New R_ProductoMayorVendidoUnidades()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                ProductosMas.ReportSource = objrep
                ProductosMas.Show()
                ProductosMas.BringToFront()
            Else
                Dim objrep As New R_ProductoMenorVendidoUnidades_()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                ProductosMas.ReportSource = objrep
                ProductosMas.Show()
                ProductosMas.BringToFront()
            End If

        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                    My.Resources.INFORMATION, 2000,
                                    eToastGlowColor.Blue,
                                    eToastPosition.BottomLeft)
            ProductosMas.ReportSource = Nothing
        End If

    End Sub

    Private Sub CargarReporte3()
        Dim _dt As New DataTable
        _dt = InterpretarDatos3()
        If _dt.Rows.Count > 0 Then
            If cbVendedorMas.Checked = True Then

                '                                   FechaFVendedor.ToString("yyyy/MM/dd"))
                'If (_dt.Rows.Count > 0) Then

                Dim objrep As New R_VendedorGanancia()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaI3.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaF3.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)

                CRVendedores.ReportSource = objrep
                CRVendedores.Show()
                CRVendedores.BringToFront()




            ElseIf cbVendedorUtilidad.Checked = True Then

                '                                   FechaFVendedor.ToString("yyyy/MM/dd"))
                'If (_dt.Rows.Count > 0) Then

                Dim objrep As New R_VendedorUtilidad()
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaIni.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaFin.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                CRVendedores.ReportSource = objrep
                CRVendedores.Show()
                CRVendedores.BringToFront()


            End If
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                    My.Resources.INFORMATION, 2000,
                                    eToastGlowColor.Blue,
                                    eToastPosition.BottomLeft)
            CRVendedores.ReportSource = Nothing
        End If

    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        CargarReporte(1)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Dim _dt As DataTable
        _dt = TraerKPICliente(tbFechaI2.Value.ToString("dd/MM/yyyy"), tbFechaF2.Value.ToString("dd/MM/yyyy"), tbtop2.Value)
        If _dt.Rows.Count > 0 Then

            '                                   FechaFVendedor.ToString("yyyy/MM/dd"))
            'If (_dt.Rows.Count > 0) Then

            Dim objrep1 As New R_ClienteMasVentas()
            objrep1.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI2.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF2.Value.ToString("dd/MM/yyyy")
            objrep1.SetParameterValue("usuario", L_Usuario)
            objrep1.SetParameterValue("fechaI", fechaI)
            objrep1.SetParameterValue("fechaF", fechaF)
            RClientes.ReportSource = objrep1
            'RClientes.Show()
            'RClientes.BringToFront()
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                My.Resources.INFORMATION, 2000,
                                eToastGlowColor.Blue,
                                eToastPosition.BottomLeft)
            RClientes.ReportSource = Nothing
        End If
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        CargarReporte(0)
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        CargarReporte3()
    End Sub

    Private Sub cbConci_CheckedChanged(sender As Object, e As EventArgs) Handles cbConci.CheckedChanged
        If cbConci.Checked = True Then
            Label2.Visible = False
            Label4.Visible = False
            tbFechaI.Visible = False
            tbFechaF.Visible = False
            Dim loc As Point = (New Point(126, 142))
            btGenerar2.Location = loc
        End If
    End Sub

    Private Sub cbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles cbFecha.CheckedChanged
        If cbFecha.Checked = True Then
            Label2.Visible = True
            Label4.Visible = True
            tbFechaI.Visible = True
            tbFechaF.Visible = True
            Dim loc As Point = (New Point(126, 259))
            btGenerar2.Location = loc
        End If
    End Sub
End Class
