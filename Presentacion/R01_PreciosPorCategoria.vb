Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_PreciosPorCategoria
    Dim _inter As Integer = 0
#Region "Variables Globales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Eventos"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()

        '_tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()

        Me.Text = "PRECIOS POR CATEGORIA".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _prCargarComboLibreriaDeposito(cbCategoria)
    End Sub
    Private Sub _prCargarComboLibreriaDeposito(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_CategoriaPrecioGeneral()
        'dt.Rows.Add(-1, "Todos")
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cicod").Width = 60
            .DropDownList.Columns("cicod").Caption = "COD"
            .DropDownList.Columns.Add("cidesc").Width = 200
            .DropDownList.Columns("cidesc").Caption = "CATEGORIA"
            .ValueMember = "cinumi"
            .DisplayMember = "cidesc"
            .DataSource = dt
            .Refresh()
        End With

        mCombo.Value = 2
    End Sub

    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        _dt = L_fnReportePrecios(cbCategoria.Value)

        Dim objrep As New R_ReportePrecios

        objrep.SetDataSource(_dt)
        objrep.SetParameterValue("usuario", L_Usuario)
        objrep.SetParameterValue("categoria", cbCategoria.Text)
        MCrReporte.ReportSource = objrep

    End Sub

#End Region
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
End Class