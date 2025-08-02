Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls


Public Class F02_ComisionesCategoria
    Dim _inter As Integer = 0
#Region "Variables Globales"

    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Dim _Dsencabezado As DataSet

    Dim _BindingSource As BindingSource
    Dim _Modificar As Boolean

    Dim modif As Boolean = True

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Dim dtComisiones As New DataTable

#End Region

#Region "Metodos"
    Private Sub _PIniciarTodo()
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If
        P_prArmarComboCategoria()
        '_PCargarGridCategoriasComisiones(-1)
        _Filtrar()
        _PCargarDetalle(JCb_CatProducto.Value)
        'MBtNuevo.Visible = False
        'MBtModificar.Visible = True
        'MBtEliminar.Visible = False
        _Inhabilitar()


        Me.Text = "C O M I S I O N E S "
        'Me.WindowState = FormWindowState.Maximized

        'btNuevoP.Image = My.Resources.ADICIONAR

        MBtPrimero.PerformClick()

        'activar los permisos del rol
        _PAsignarPermisos()

        'Asignar el menustrip quitar al grid JGr_Descuentos

    End Sub

    Private Sub _PAsignarPermisos()
        Dim dtRolUsu() As DataRow = L_prRolDetalleGeneral(gi_userRol).Select("yaprog='" + _nameButton + "'")

        Dim show As Boolean = False
        Dim add As Boolean = False
        Dim modif As Boolean = False
        Dim del As Boolean = False

        If (dtRolUsu.Count = 1) Then
            show = dtRolUsu(0).Item("ycshow")
            add = dtRolUsu(0).Item("ycadd")
            modif = dtRolUsu(0).Item("ycmod")
            del = dtRolUsu(0).Item("ycdel")
        End If

        If add = False Then
            'MBtNuevo.Visible = False
        End If
        If modif = False Then
            'MBtModificar.Visible = False
        End If
        If del = False Then
            'MBtEliminar.Visible = False
        End If
    End Sub


    Private Sub _PSalirRegistro()
        If MBtModificar.Enabled = False Then
            _Inhabilitar()
        Else
            Me.Close()
            _modulo.Select()
        End If

        '_tab.Close()
    End Sub

    Private Sub P_prArmarComboCategoria()
        Dim Dt As DataTable
        Dt = L_fnObtenerCategoria()
        ''   Dt = L_fnObtenerLibreria("5", IIf(TipoForm = 1, "cenum>0", "cenum<0"))
        g_prArmarCombo(JCb_CatProducto, Dt, 60, 200, "Código", "Categoría")
    End Sub

    Private Sub _PCargarDetalle(idTipoProd As String)
        Dim dt As DataTable = TraerCategoriaComisiones()

        JGr_Detalle.BoundMode = BoundMode.Bound
        JGr_Detalle.DataSource = dt
        JGr_Detalle.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Detalle.RootTable.Columns(0)
            .Caption = "Cod. Categoria"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With JGr_Detalle.RootTable.Columns(1)
            .Caption = "Categoria"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .CellStyle.BackColor = Color.AliceBlue
        End With

        ''JGr_Detalle.RootTable.Columns.Add()
        With JGr_Detalle.RootTable.Columns(2)
            .Caption = "Comisión Vendedor"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Detalle.RootTable.Columns("repartidor")
            .Caption = "Comisión Repartidor"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        'Habilitar Filtradores
        With JGr_Detalle
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With


    End Sub




    Private Sub _Filtrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_General_LibreriaDetalle(-1, 5)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _MostrarRegistro(_Pos)
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                MBtPrimero.Visible = True
                MBtAnterior.Visible = True
                MBtSiguiente.Visible = True
                MBtUltimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _MostrarRegistro(_N As Integer)
        JCb_CatProducto.SelectedIndex = _N
    End Sub
    Private Sub _PrimerRegistro()
        _Pos = 0
        _MostrarRegistro(_Pos)
        MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
    Private Sub _AnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _MostrarRegistro(_Pos)
            MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _SiguienteRegistro()
        If _Pos < _Dsencabezado.Tables(0).Rows.Count - 1 Then
            _Pos = _Pos + 1
            _MostrarRegistro(_Pos)
            MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _UltimoRegistro()
        _Pos = _Dsencabezado.Tables(0).Rows.Count - 1
        _MostrarRegistro(_Pos)
        MLbPaginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
#End Region

    Private Sub P_PrecioProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub JCb_CatProducto_ValueChanged(sender As Object, e As EventArgs) Handles JCb_CatProducto.ValueChanged
        If JCb_CatProducto.SelectedIndex >= 0 Then
            _PCargarDetalle(JCb_CatProducto.Value)
        End If
    End Sub

    Private Sub MBtPrimero_Click(sender As Object, e As EventArgs) Handles MBtPrimero.Click
        _PrimerRegistro()
    End Sub

    Private Sub MBtAnterior_Click(sender As Object, e As EventArgs) Handles MBtAnterior.Click
        _AnteriorRegistro()
    End Sub

    Private Sub MBtSiguiente_Click(sender As Object, e As EventArgs) Handles MBtSiguiente.Click
        _SiguienteRegistro()
    End Sub

    Private Sub MBtUltimo_Click(sender As Object, e As EventArgs) Handles MBtUltimo.Click
        _UltimoRegistro()
    End Sub

    Private Sub JGr_Detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Detalle.EditingCell
        If e.Column.Index = 2 Or e.Column.Index = 3 Then
            e.Cancel = False
        End If

        If MBtModificar.Enabled = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        _PSalirRegistro()
    End Sub


    Private Sub JGr_Detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGr_Detalle.CellEdited
        'Try
        '    If (Not IsNumeric(JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value)) Then
        '        JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value = 0
        '    End If

        '    Dim listPrecio = JGr_Detalle.CurrentRow.Cells("listPrecio").Value.ToString.Split("|")
        '    Dim valorActual = Convert.ToDecimal(JGr_Detalle.CurrentRow.Cells(e.Column.Index).Value)
        '    Dim valorInicial As Decimal = 0
        '    Try
        '        valorInicial = Convert.ToDecimal(listPrecio(e.Column.Index - 3))
        '    Catch
        '    End Try

        '    If (valorActual <> valorInicial) Then
        '        JGr_Detalle.CurrentRow.Cells("huboCambio").Value = True
        '    Else
        '        JGr_Detalle.CurrentRow.Cells("huboCambio").Value = False
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub



    Private Sub _Inhabilitar()
        MBtModificar.Enabled = True
        MBtGrabar.Enabled = False
    End Sub
    Private Sub _Habilitar()
        MBtModificar.Enabled = False
        MBtGrabar.Enabled = True
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

    Private Sub MBtModificar_Click(sender As Object, e As EventArgs) Handles MBtModificar.Click
        _Habilitar()

    End Sub

    Private Sub MBtGrabar_Click(sender As Object, e As EventArgs) Handles MBtGrabar.Click
        Try
            L_fnGrabarComisionesCategoria(CType(JGr_Detalle.DataSource, DataTable))
            ToastNotification.Show(Me,
                                   "Comisiones actualizadas correctamente".ToUpper,
                                   My.Resources.OK,
                                   5000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
            _PCargarDetalle(0)
            _Inhabilitar()
        Catch ex As Exception
            ToastNotification.Show(Me,
                                   ex.Message.ToUpper,
                                   My.Resources.WARNING,
                                   5000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End Try

    End Sub
End Class