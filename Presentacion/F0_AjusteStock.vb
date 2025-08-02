
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls

Public Class F0_AjusteStock
    Dim _Inter As Integer = 0

    Dim RutaGlobal As String = gs_CarpetaRaiz
#Region "Variables Globales"
    Dim precio As DataTable
    Public _nameButton As String
    Public _modulo As SideNavItem
    Public _tab As SuperTabItem
#End Region
#Region "MEtodos Privados"
    Private Sub _IniciarTodo()

        'Me.WindowState = FormWindowState.Maximized



        P_prArmarComboCategoria()

        _prAsignarPermisos()
        Me.Text = "INVENTARIO FISICO"
        Dim blah As New Bitmap(New Bitmap(My.Resources.precio), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico


    End Sub
    Private Sub P_prArmarComboCategoria()
        Dim Dt As DataTable
        Dt = L_fnObtenerCategoria()
        ''   Dt = L_fnObtenerLibreria("5", IIf(TipoForm = 1, "cenum>0", "cenum<0"))
        g_prArmarCombo(cbAlmacen, Dt, 60, 200, "Código", "Categoría")
        If (Dt.Rows.Count > 0) Then
            cbAlmacen.SelectedIndex = 0
        End If
    End Sub
    Private Sub _prAsignarPermisos()

        'Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        'Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        'Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        'Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        'Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        'If add = False Then
        '    btnNuevo.Visible = False
        'End If
        'If modif = False Then
        '    btnModificar.Visible = False
        'End If
        'If del = False Then
        '    btnEliminar.Visible = False
        'End If
    End Sub
    Public Sub _prCargarPrecios()
        precio = L_fnListarProductosConPrecios(cbAlmacen.Value)
    End Sub
    Public Sub _prCargarTablaPrecios(bandera As Boolean) ''Bandera = true si es que haiq cargar denuevo la tabla de Precio Bandera =false si solo cargar datos al Janus con el precio antepuesto
        Dim productos As DataTable = L_fnProductoCategoriaAjuste(cbAlmacen.Value)

        grprecio.BoundMode = Janus.Data.BoundMode.Bound
        grprecio.DataSource = productos
        grprecio.RetrieveStructure()


        'a.yfcprod ,a.yfnumi ,a.yfcdprod1,gr3.ycdes3 as Laboratorio,gr4.ycdes3 as Presentacion 
        With grprecio.RootTable.Columns("icid")
            .Caption = "COD"
            .Width = 60
            .Visible = False
        End With
        With grprecio.RootTable.Columns("icibid")
            .Caption = "COD PROD"
            .Width = 70
            .Visible = False
        End With
        With grprecio.RootTable.Columns("cacod")
            .Caption = "COD. INTERNO"
            .Width = 100
            .Visible = True
        End With
        With grprecio.RootTable.Columns("iccprod")
            .Caption = "COD"
            .Width = 70
            .Visible = True
        End With
        With grprecio.RootTable.Columns("iccprod")
            .Caption = "COD PROD"
            .Width = 70
            .Visible = True
        End With
        With grprecio.RootTable.Columns("ncprod")
            .Caption = "PRODUCTO"
            .Width = 460
            .Visible = True
        End With
        With grprecio.RootTable.Columns("stock")
            .Caption = "STOCK"
            .Width = 150
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
        End With
        With grprecio.RootTable.Columns("ajuste")
            .Caption = "AJUSTE"
            .Width = 150
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
        End With
        With grprecio.RootTable.Columns("iccant")
            .Caption = "CANTIDAD"
            .Width = 120
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = TextAlignment.Far
        End With
        With grprecio.RootTable.Columns("estado")
            .Caption = "STOCK"
            .Width = 120
            .Visible = False
        End With
        'Habilitar Filtradores
        With grprecio
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .FilterMode = FilterMode.Automatic
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.SingleSelection
            .AlternatingColors = True
        End With

    End Sub

    Private Sub _prInhabiliitar()


        MBtModificar.Enabled = True
        MBtGrabar.Enabled = False
        _prCargarTablaPrecios(True)


    End Sub
    Private Sub _prhabilitar()

        MBtGrabar.Enabled = True
    End Sub



    Public Function _fnAccesible()
        If MBtModificar.Enabled = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function _FSiguienteLetra(palabra As String) As String
        Dim alfabeto As New List(Of String)
        alfabeto.Add("A")
        alfabeto.Add("B")
        alfabeto.Add("C")
        alfabeto.Add("D")
        alfabeto.Add("E")
        alfabeto.Add("F")
        alfabeto.Add("G")
        alfabeto.Add("H")
        alfabeto.Add("I")
        alfabeto.Add("J")
        alfabeto.Add("K")
        alfabeto.Add("L")
        alfabeto.Add("M")
        alfabeto.Add("N")
        alfabeto.Add("O")
        alfabeto.Add("P")
        alfabeto.Add("Q")
        alfabeto.Add("R")
        alfabeto.Add("S")
        alfabeto.Add("T")
        alfabeto.Add("U")
        alfabeto.Add("V")
        alfabeto.Add("W")
        alfabeto.Add("X")
        alfabeto.Add("Y")
        alfabeto.Add("Z")
        Dim letra As String
        If palabra.Length = 1 Then
            letra = palabra(0)
            '26 letras en el alphabeto
            If alfabeto.IndexOf(letra) = 25 Then
                palabra = "AA"
            Else
                palabra = alfabeto(alfabeto.IndexOf(letra) + 1)
            End If
        Else
            letra = palabra(1)
            If alfabeto.IndexOf(letra) = 25 Then
                palabra = ""
            Else
                palabra = palabra(0) + alfabeto(alfabeto.IndexOf(letra) + 1)
            End If
        End If
        Return palabra
    End Function


    Public Sub _prLimpiar()
        tbObs.Clear()
    End Sub




    Public Sub _prCargarDatosTablaPrecios()
        Dim result() As DataRow = precio.Select("estado > 1")
        _prCargarPrecios()
        For i As Integer = 0 To result.Length - 1 Step 1
            Dim r As DataRow = result.GetValue(i)
            Dim dr() As DataRow
            dr = precio.Select("yhprod=" + Str(r.Item("yhprod")) + "and yhcatpre=" + Str(r.Item("yhcatpre")))
            If dr Is Nothing Then
                'No se encontró la fila. Crear nueva fila

            Else
                'Fila encontrada
                dr.GetValue(0).Item("yhprecio") = r.Item("yhprecio")
                dr.GetValue(0).Item("estado") = r.Item("estado")

            End If

        Next
        _prCargarTablaPrecios(False)
    End Sub




    Public Function _fnSiguienteNumero(num As Integer)
        Return num + 1
    End Function

#End Region


#Region "MEtodoso Formulario"
    Private Sub F0_Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
        _prInhabiliitar()
        MBtModificar.PerformClick()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles MBtModificar.Click
        _prhabilitar()
        MBtModificar.Enabled = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        If (_fnAccesible()) Then
            _prInhabiliitar()
        Else
            _modulo.Select()
            Me.Close()
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)



    End Sub
    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        Dim tb As TextBoxX = CType(sender, TextBoxX)
        If tb.Text = String.Empty Then

        Else
            tb.BackColor = Color.White
            MEP.SetError(tb, "")
        End If
    End Sub
    Private Sub grprecio_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grprecio.CellEdited

    End Sub

    Private Sub grprecio_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grprecio.EditingCell

        If MBtGrabar.Enabled = False Then
            e.Cancel = True
            Return
        End If
        If (_fnAccesible() And IsNothing(grprecio.DataSource) = False) Then
            'Deshabilitar la columna de Productos y solo habilitar la de los precios
            If (e.Column.Index = grprecio.RootTable.Columns("iccant").Index) Then 'Or e.Column.Index = grprecio.RootTable.Columns("73").Index
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles MBtGrabar.Click
        Dim dt1 As DataTable = CType(grprecio.DataSource, DataTable)

        Dim resultadoFilas() As DataRow = CType(grprecio.DataSource, DataTable).Select("iccprod > 0")
        Dim dt As DataTable = CType(grprecio.DataSource, DataTable).Clone()
        dt.Clear()
        For Each fila As DataRow In resultadoFilas
            dt.ImportRow(fila)
        Next

        dt.Columns.RemoveAt(6)
        dt.Columns.RemoveAt(2)
        Dim grabar As Boolean = L_fnMovimientoGrabarCategoriaAjuste("", Date.Now.ToString("dd/MM/yyyy"), dt, tbObs.Text)
        If (grabar) Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Ajuste realizado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prLimpiar()

            _prCargarTablaPrecios(True)
            _prInhabiliitar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El ajuste no pudo ser realizado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If

    End Sub

    Private Sub cbAlmacen_ValueChanged(sender As Object, e As EventArgs) Handles cbAlmacen.ValueChanged

        _prCargarTablaPrecios(True) ''Si el selecciona otra sucursal cambia sus precio por sucursales
    End Sub


#End Region

    Private Sub SELECCIONARTODOSDELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECCIONARTODOSDELToolStripMenuItem.Click

    End Sub

    Private Sub grcategoria_FormattingRow(sender As Object, e As RowLoadEventArgs)

    End Sub
    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = grprecio.GetRows.Length
                Dim _columna As Integer = grprecio.RootTable.Columns.Count
                Dim _archivo As String = _ubicacion & "\ListaDePrecios_" & Now.Date.Day &
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In grprecio.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In grprecio.GetRows
                    For Each _col As GridEXColumn In grprecio.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function
    Private Sub _prCrearCarpetaReportes()

        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte Precios\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Precios\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Precios") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Precios")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Precios") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Precios")

                End If
            End If
        End If
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles MBtImprimir.Click
        _prCrearCarpetaReportes()
        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        If (P_ExportarExcel(RutaGlobal + "\Reporte\Reporte Productos")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRODUCTOS EXITOSA..!!!",
                                       img, 2000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomCenter)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRODUCTOS..!!!",
                                       My.Resources.WARNING, 2000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub grprecio_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grprecio.CellValueChanged
        If ((e.Column.Key.Equals("iccant"))) Then
            Dim lin As Integer = grprecio.GetValue("iccprod")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)

            If (Not IsNumeric(grprecio.GetValue("iccant")) Or grprecio.GetValue("iccant").ToString = String.Empty) Then
                grprecio.SetValue("iccant", CType(grprecio.DataSource, DataTable).Rows(pos).Item("stock"))
                CType(grprecio.DataSource, DataTable).Rows(pos).Item("iccant") = CType(grprecio.DataSource, DataTable).Rows(pos).Item("stock")



            Else
                If (e.Column.Key.Equals("iccant")) Then
                    grprecio.SetValue("ajuste", grprecio.GetValue("iccant") - grprecio.GetValue("stock"))

                    CType(grprecio.DataSource, DataTable).Rows(pos).Item("ajuste") = grprecio.GetValue("ajuste")


                End If
            End If
        End If
    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(grprecio.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(grprecio.DataSource, DataTable).Rows(i).Item("iccprod")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub
End Class