Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar.SuperGrid
Imports System.IO
Imports System.Drawing.Printing
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Google.Apis.Auth.OAuth2
Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Interop
Imports Microsoft.VisualBasic
Imports System

Public Class F03_ImportarInventario
#Region "Variables Globales"
    Dim _inter As Integer = 0
    Dim DtCabfac As DataTable
    Dim DtDetfac As DataTable
    Public _modulo As SideNavItem
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public InventarioImport As New DataTable

#End Region
    Private Sub _PIniciarTodo()
        Me.Text = "I M P O R T A R   I N V E N T A R I O"

    End Sub

    Private Sub F03_Cabfac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _inter = _inter + 1
        If _inter = 1 Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub BtnSalir1_Click(sender As Object, e As EventArgs) Handles BtnSalir1.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        InventarioImport.Clear()
        MP_ImportarExcel()
        MP_PasarDatos()
    End Sub
    Private Sub MP_ImportarExcel()
        Try
            Dim folder As String = ""
            Dim doc As String = "Hoja1"
            Dim openfile1 As OpenFileDialog = New OpenFileDialog()

            If openfile1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                folder = openfile1.FileName
            End If

            If True Then
                Dim pathconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & folder & ";Extended Properties='Excel 12.0 Xml;HDR=Yes'"
                'Dim pathconn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";"
                'Dim pathconn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""Excel 8.0;HDR=YES;"""

                Dim con As OleDbConnection = New OleDbConnection(pathconn)
                Dim MyDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("Select * from [" & doc & "$]", con)
                con.Open()

                MyDataAdapter.Fill(InventarioImport)
                con.Close()

            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub MP_PasarDatos()
        Try
            Dim TablaProductos As DataTable = L_fnProductoGeneral(1)
            Dim ProdFiltrado As DataTable
            Dim Numi As String
            Dim Tablaaux As DataTable = InventarioImport.Copy

            ''Validación para comprobar que no existan dos o mas filas con el mismo codigo
            For k = 0 To InventarioImport.Rows.Count - 1
                Dim aux = Tablaaux.Select("Codigo=" + InventarioImport.Rows(k).Item("Codigo").ToString)
                If aux.Length > 1 Then
                    ToastNotification.Show(Me, "No se puede realizar la importación porque el codigo:  ".ToUpper & InventarioImport.Rows(k).Item("Codigo").ToString & " existe  ".ToUpper & aux.Length.ToString & " veces en la lista".ToUpper,
                                           My.Resources.WARNING, 5000, eToastGlowColor.Green, eToastPosition.BottomCenter)
                    Exit Sub
                End If
            Next


            If InventarioImport.Rows.Count = TablaProductos.Rows.Count Then
                ''Hago una copia para ir cambiando el codigo flex por el codigo del sistema
                Dim InvProductos As DataTable = InventarioImport.Copy
                For i = 0 To InventarioImport.Rows.Count - 1
                    ProdFiltrado = L_fnProductoPorCacod(InventarioImport.Rows(i).Item("Codigo").ToString)
                    If ProdFiltrado.Rows.Count > 0 Then
                        Numi = ProdFiltrado.Rows(0).Item("canumi").ToString
                        InvProductos.Rows(i).Item("Codigo") = Numi
                    Else
                        ToastNotification.Show(Me, "No se puede realizar la importación porque el código de producto: ".ToUpper & InventarioImport.Rows(i).Item("Codigo").ToString & " no pertenece a la lista de Productos de la base de datos".ToUpper,
                                               My.Resources.WARNING, 5000, eToastGlowColor.Green, eToastPosition.BottomCenter)
                        Exit Sub
                    End If

                Next
                Dim importar As Boolean = L_fnImportarInventario(InvProductos)
                If importar Then
                    ToastNotification.Show(Me, "IMPORTACIÓN DEL INVENTARIO EXITOSA!!! ",
                                  My.Resources.OK, 5000,
                                  eToastGlowColor.Green,
                                  eToastPosition.BottomCenter)
                Else
                    ToastNotification.Show(Me, "FALLÓ LA IMPORTACIÓN DEL INVENTARIO!!!",
                                  My.Resources.WARNING, 4000,
                                  eToastGlowColor.Red,
                                  eToastPosition.BottomCenter)
                End If
            Else
                ToastNotification.Show(Me, "No se puede realizar la importación porque la Lista del Inventario tiene que tener ".ToUpper & TablaProductos.Rows.Count & " registros".ToUpper,
                                       My.Resources.WARNING, 5000, eToastGlowColor.Green, eToastPosition.BottomCenter)
                Exit Sub
            End If


        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me, mensaje.ToUpper, My.Resources.WARNING, 5000, eToastGlowColor.Red, eToastPosition.TopCenter)
    End Sub
End Class