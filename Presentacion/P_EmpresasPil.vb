Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Public Class P_EmpresasPil
    Public ok As Boolean

#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        Me.Text = "LOGIN EMPRESA"
        _prCargarGridModulos()
        GroupPanel1.Focus()
        grEmpresa.Focus()
        'grEmpresa.Row = 0
        grEmpresa.Select()
    End Sub
    Private Sub _prCargarGridModulos()
        Dim dt As New DataTable
        dt = L_prEmpresaGeneralPil()

        grEmpresa.DataSource = dt
        grEmpresa.RetrieveStructure()

        'dar formato a las columnas
        With grEmpresa.RootTable.Columns("numi")
            .Width = 70
            .Visible = False
        End With

        With grEmpresa.RootTable.Columns("descripcion")
            .Caption = "EMPRESA"
            .Width = 300

        End With

        With grEmpresa.RootTable.Columns("bd")
            .Width = 70
            .Visible = False
        End With


        With grEmpresa
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .AllowAddNew = InheritableBoolean.False
            .RowFormatStyle.BackColor = Color.AliceBlue
            .SelectionMode = SelectionMode.SingleSelection
            .ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.DiaplayedCells

            .SelectedFormatStyle.BackColor = Color.CadetBlue
            .RowFormatStyle.BackColor = Color.White
        End With

    End Sub
#End Region

    Private Sub ModeloHor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            'P_Moverenfoque()
            ButtonX1.PerformClick()
        End If
    End Sub

    Private Sub P_Moverenfoque()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub P_LoginEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        gi_empresaNumi = grEmpresa.GetValue("numi")
        gs_empresaDescSistema = grEmpresa.GetValue("descripcion").ToString
        gs_empresaDesc = grEmpresa.GetValue("descripcion").ToString
        gs_NombreBD1 = grEmpresa.GetValue("bd")
        ok = True
        Close()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        ok = False
        Close()
    End Sub

    Private Sub grEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles grEmpresa.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            ButtonX1.PerformClick()
        End If
    End Sub
End Class