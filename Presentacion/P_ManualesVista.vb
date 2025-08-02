Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO

Public Class P_ManualesVista
#Region "Variables Globales"

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim DtCabecera As DataTable 'Datatable de la cabecer
    Dim IndexReg As Integer 'Indice de navegación de registro

    'Dim RutaManuales = Application.StartupPath
    Dim RutaManuales = gs_RutaManuales

    Dim Zoom As Integer = 75
    Dim Left1 As Integer = 0
    Dim Top1 As Integer = 0
    Dim Bool As Boolean = False

#End Region

#Region "Eventos"

    Private Sub P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'Abrir la conexion de la base de datos
        'L_abrirConexion()

        'Poner visible=false, los componente que no se ocuparan
        BBtn_Error.Visible = False
        PanelEx1.Visible = False
        BBtn_Inicio.Visible = False
        BBtn_Anterior.Visible = False
        BBtn_Siguiente.Visible = False
        BBtn_Ultimo.Visible = False
        Txt_Paginacion.Visible = False
        SuperTabItem2.Visible = False

        'Poner titulo al formulario
        Me.Text = "V I S U A L I Z A C I O N   D E   M A N U A L E S"

        'Inizializar Componentes
        Me.WindowState = FormWindowState.Maximized
        SuperTabItem1.Text = "REGISTRO"

        'Deshabilitar componentes
        'Gp3PDF.Enabled = (gi_bloqueoManuales = 0)

        'Armar grillas
        P_ArmarGrillas()

        'Navegación de registro
        IndexReg = 0
        P_LlenarDatos(IndexReg)

        Bool = True

        'Txt_NombreUsu.Text = gs_Usuario
        Me.BringToFront()
    End Sub

    Private Sub P_ArmarGrillas()
        'P_ArmarGrillaBusqueda()
        'P_CopiarManuales()
    End Sub

    Private Sub P_LlenarDatos(index As Integer)
        'If (index >= 0 And Dgj1Busqueda.GetRows.Count > 0) Then
        '    'Llenar los datos a los componentes
        '    TbManual.Text = Dgj1Busqueda.GetValue("desc").ToString
        '    'P_CargarPDF(RutaManuales + "\MisManuales\" + Dgj1Busqueda.GetValue("pdf").ToString)
        'End If
    End Sub

    'Private Sub P_ArmarGrillaBusqueda()
    '    DtCabecera = New DataTable
    '    DtCabecera = L_fnManualesPorUsuario(gs_codigoUsuario)

    '    Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
    '    Dgj1Busqueda.DataSource = DtCabecera
    '    Dgj1Busqueda.RetrieveStructure()

    '    'dar formato a las columnas
    '    With Dgj1Busqueda.RootTable.Columns(0)
    '        .Caption = "Código"
    '        .Key = "numi"
    '        .Width = 60
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
    '        .Visible = True
    '    End With
    '    With Dgj1Busqueda.RootTable.Columns(1)
    '        .Caption = "Nombre"
    '        .Key = "desc"
    '        .Width = 200
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
    '        .Visible = True
    '    End With
    '    With Dgj1Busqueda.RootTable.Columns(2)
    '        .Caption = "PDF"
    '        .Key = "pdf"
    '        .Width = 100
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .Visible = False
    '    End With
    '    With Dgj1Busqueda.RootTable.Columns(3)
    '        .Caption = "copy"
    '        .Key = "copy"
    '        .Width = 0
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .Visible = False
    '    End With
    '    With Dgj1Busqueda.RootTable.Columns(4)
    '        .Caption = "lin"
    '        .Key = "lin"
    '        .Width = 0
    '        .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .CellStyle.FontSize = gi_fuenteTamano
    '        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
    '        .Visible = False
    '    End With

    '    'Habilitar Filtradores
    '    With Dgj1Busqueda
    '        .GroupByBoxVisible = False
    '        '.FilterRowFormatStyle.BackColor = Color.Blue
    '        '.DefaultFilterRowComparison = FilterConditionOperator.Contains
    '        '.FilterMode = FilterMode.Automatic
    '        '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
    '        'Diseño de la tabla
    '        .VisualStyle = VisualStyle.Office2007
    '        .SelectionMode = SelectionMode.SingleSelection
    '        .AlternatingColors = True
    '    End With

    'End Sub

    'Private Sub P_CargarPDF(ruta As String)
    '    If (Not ruta = String.Empty) Then

    '        If (Not IO.File.Exists(ruta)) Then
    '            Dim nombreArch As String = ruta.Split("\")(ruta.Split("\").Length - 1)
    '            Dim rutaDest As String = RutaManuales + "\MisManuales"

    '            'Descargar el archivo al servido ftp
    '            Try
    '                My.Computer.Network.DownloadFile("ftp://" + gs_FtpIp + "/Manuales/" + nombreArch, rutaDest + "\" + nombreArch, gs_FtpUsuario, gs_FtpPassword)
    '            Catch ex As Exception
    '                MsgBox("Error al conectarse al servidor FTP, Form Mis Manuales: " + ex.Message)
    '            End Try
    '        End If

    '        Pdf1Manual.LoadFile(ruta)
    '        'Pdf1Manual.setZoom(Zoom)
    '        Pdf1Manual.gotoFirstPage()
    '        Pdf1Manual.setZoomScroll(Zoom, 0, 0)
    '        If (gi_bloqueoManuales = 0) Then
    '            Pdf1Manual.goForwardStack()
    '            Pdf1Manual.setShowScrollbars(True)
    '            Pdf1Manual.setShowToolbar(True)
    '        ElseIf (gi_bloqueoManuales = 1) Then
    '            Pdf1Manual.goForwardStack()
    '            Pdf1Manual.setShowScrollbars(False)
    '            Pdf1Manual.setShowToolbar(False)
    '        End If
    '        Top1 = 0
    '    End If
    'End Sub

    Private Sub BtPagAnterior_Click(sender As Object, e As EventArgs)
        Pdf1Manual.gotoPreviousPage()
        Top1 = 0
    End Sub

    Private Sub BtPagSiguiente_Click(sender As Object, e As EventArgs)
        Pdf1Manual.gotoNextPage()
        Top1 = 0
    End Sub

    Private Sub BtZoomMas_Click(sender As Object, e As EventArgs)
        If (Zoom < 200) Then
            Zoom = Zoom + 5
            Pdf1Manual.setZoom(Zoom)
        Else
            Zoom = 200
        End If
    End Sub

    Private Sub BtZoomMenos_Click(sender As Object, e As EventArgs)
        If (Zoom > 0) Then
            Zoom = Zoom - 5
            Pdf1Manual.setZoom(Zoom)
        Else
            Zoom = 0
        End If
    End Sub

    Private Sub BtArriba_Click(sender As Object, e As EventArgs)
        If (Top1 > 0) Then
            Top1 = Top1 - 48
            Pdf1Manual.setZoomScroll(Zoom, Left1, Top1)
        Else
            Pdf1Manual.gotoPreviousPage()
            Top1 = 480
        End If
    End Sub

    Private Sub BtAbajo_Click(sender As Object, e As EventArgs)
        If (Top1 < 480) Then
            Top1 = Top1 + 48
            Pdf1Manual.setZoomScroll(Zoom, Left1, Top1)
        Else
            Pdf1Manual.gotoNextPage()
            Top1 = 0
        End If
    End Sub

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub Dgj1Busqueda_SelectionChanged(sender As Object, e As EventArgs)
        'If (Dgj1Busqueda.CurrentRow.RowIndex > -1 And Bool) Then
        '    P_LlenarDatos(Dgj1Busqueda.CurrentRow.RowIndex)
        'End If
    End Sub

#End Region

    'Private Sub P_CopiarManuales()
    '    If (Not Directory.Exists(RutaManuales + "\MisManuales")) Then
    '        System.IO.Directory.CreateDirectory(RutaManuales + "\MisManuales")
    '        Dim folerInfo As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(RutaManuales + "\MisManuales")
    '        folerInfo.Attributes = FileAttributes.Hidden
    '    End If

    '    Dim nombre As String = ""
    '    For Each fil As GridEXRow In Dgj1Busqueda.GetRows
    '        nombre = fil.Cells("pdf").Value.ToString
    '        If (Not fil.Cells("copy").Value Or Not IO.File.Exists(RutaManuales + "\MisManuales\" + nombre)) Then

    '            If (IO.File.Exists(RutaManuales + "\MisManuales\" + nombre)) Then
    '                My.Computer.FileSystem.DeleteFile(RutaManuales + "\MisManuales\" + nombre,
    '                                                  Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
    '                                                  Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
    '            End If

    '            'Descargar el archivo al servido ftp
    '            Try
    '                My.Computer.Network.DownloadFile("ftp://" + gs_FtpIp + "/Manuales/" + nombre, RutaManuales + "\MisManuales\" + nombre, gs_FtpUsuario, gs_FtpPassword)
    '            Catch ex As Exception
    '                MsgBox("Error al conectarse al servidor FTP, Form Mis Manuales: " + ex.Message)
    '            End Try

    '            L_fnModificarManualUsuario(fil.Cells("numi").Value.ToString, "1", fil.Cells("lin").Value.ToString)
    '        End If
    '    Next
    'End Sub

End Class