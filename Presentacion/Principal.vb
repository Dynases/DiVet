Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering

Public Class Principal
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        _prCambiarStyle()
        ' Add any initialization after the InitializeComponent() call.  
    End Sub
    Private Sub _prCambiarStyle()
        'tratar de cambiar estilo
        'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass)

        Dim table As Office2007ColorTable = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable
        Dim ct As SideNavColorTable = table.SideNav
        'ct.TitleBackColor = Color.LightSeaGreen;
        'ct.SideNavItem.Default.BackColors = New Color[] { Color.LightSeaGreen};
        'ct.ItemsBackColor=  Color.LightSeaGreen ;
        ct.SideNavItem.Selected.BackColors = New Color() {Color.SkyBlue}

    End Sub
    Private Sub _prIniciarTodo()
        'Leer Archivo de Configuración
        '_prLeerArchivoConfig()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        '_prLogin()
        Me.WindowState = FormWindowState.Maximized
        M_Configuracion.Select()
        'L_Usuario = gs_user
        'lbUsuario.Text = gs_user
        M_Informes.Visible = False
    End Sub
    Private Sub _prLeerArchivoConfig()
        Try
            Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIG.TXT")
            gs_Ip = Archivo(0).Split("=")(1).Trim
            gs_UsuarioSql = Archivo(1).Split("=")(1).Trim
            gs_ClaveSql = Archivo(2).Split("=")(1).Trim
            gs_NombreBD = Archivo(3).Split("=")(1).Trim
            gs_CarpetaRaiz = Archivo(4).Split("=")(1).Trim

        Catch ex As Exception
            MessageBox.Show("No se encontró el archivo 'CONFIG.TXT' para la conexión a la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()

        End Try

    End Sub

    Private Sub _prLogin()
        Dim ef = New Efecto
        ef.tipo = 4
        ef.ShowDialog()

        L_Usuario = gs_user
        Modelo.MGlobal.gs_usuario = gs_user

        lbUsuario.Text = gs_user
        lbUsuario.Font = New Font("Tahoma", 12, FontStyle.Bold)

        If gs_user = "DEFAULT" Then
            sideNav1.Enabled = False
        Else
            '_PCargarPrivilegios()
            '_prCargarConfiguracionSistema()
            sideNav1.Enabled = True
        End If

        'P_prCargarParametros()
        '_prValidarMayusculas()
    End Sub
    Private Sub btnCliente_Click(sender As Object, e As EventArgs)
        Dim frm As New F0_Reg_Clientes
        'frm._modulo = FP_Configuracion
        '_nameButton =
        frm.Show()

    End Sub

    Private Sub btnPrecio_Click(sender As Object, e As EventArgs)
        Dim frm As New F0_Precios
        frm.Show()
    End Sub



    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New F0_Reg_Clientes
        'frm._modulo = FP_Configuracion
        Modelo.MGlobal._nameButton = btnClientes.Name
        frm.Show()
    End Sub

    Private Sub btnFichaAtencion_Click(sender As Object, e As EventArgs)
        Dim frm As New F_Fic_FichaAtencion
        'frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '_Salir()
        'Me.Close()
        Application.Exit()
    End Sub
    Private Sub _Salir()
        ' Me.Close()
        Application.ExitThread()

    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        Dim frm As New F1_Reg_Pacientes
        frm._Iniciar = 3
        Modelo.MGlobal._nameButton = btnPacientes.Name
        'frm._modulo = FP_Configuracion
        frm.Show()
    End Sub



    Private Sub btnFichaAtencion_Click_1(sender As Object, e As EventArgs) Handles btnFichaAtencion.Click
        Dim frm As New F_Fic_FichaAtencion
        'frm._nameButton = btnFichaAtencion.Name
        frm.Show()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim frm As New F1_Ven_Venta
        Modelo.MGlobal._nameButton = btnVenta.Name
        frm.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim frm As New F1_Productos
        Modelo.MGlobal._nameButton = btnProductos.Name
        frm.Show()
    End Sub

    Private Sub MetroTileItem14_Click(sender As Object, e As EventArgs)
        Dim frm As New Form1
        frm.Show()
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Dim frm As New F1_Rol
        Modelo.MGlobal._nameButton = btnRoles.Name
        frm.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim frm As New F1_Con_Usuarios
        Modelo.MGlobal._nameButton = btnUsuarios.Name
        frm.Show()
    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        Dim frm As New F0_Movimiento
        Modelo.MGlobal._nameButton = btnMovimientos.Name
        frm.Show()
    End Sub

    Private Sub btnLibrerias_Click(sender As Object, e As EventArgs) Handles btnLibrerias.Click
        Dim frm As New F1_Con_Librerias
        Modelo.MGlobal._nameButton = btnLibrerias.Name
        frm.Show()
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        Dim frm As New F1_Almacen
        Modelo.MGlobal._nameButton = btnAlmacen.Name
        frm.Show()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim frm As New F1_Reg_Empleados
        Modelo.MGlobal._nameButton = btnEmpleados.Name
        frm.Show()
    End Sub



    Private Sub btnFichaClinica_Click(sender As Object, e As EventArgs) Handles btnFichaClinica.Click
        Dim frm As New F1_Fic_FichaClinica
        Modelo.MGlobal._nameButton = btnFichaClinica.Name
        frm._Iniciar = 3
        frm.Show()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        Dim frm As New F1_Proveedor
        Modelo.MGlobal._nameButton = btnProveedor.Name
        frm.Show()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Dim frm As New F0_MCompras
        Modelo.MGlobal._nameButton = btnCompras.Name
        frm.Show()
    End Sub

    Private Sub btnRepVetMascAten_Click(sender As Object, e As EventArgs) Handles btnRepVetMascAten.Click
        Dim frm As New Pr_MascotasAtendidas
        frm.Show()
    End Sub

    Private Sub btnSegInternacion_Click(sender As Object, e As EventArgs) Handles btnSegInternacion.Click
        Dim frm As New F1_FIC_SegInternacion
        Modelo.MGlobal._nameButton = btnSegInternacion.Name
        frm.Show()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        Dim frm As New F1_Con_Servicios
        Modelo.MGlobal._nameButton = btnServicios.Name
        frm.Show()
    End Sub

    Private Sub btProducto_Click(sender As Object, e As EventArgs)
        Dim frm As New F1_Productos
        frm.Show()
    End Sub

    Private Sub btnKardex_Click(sender As Object, e As EventArgs) Handles btnKardex.Click
        Dim frm As New F0_KardexMovimiento
        Modelo.MGlobal._nameButton = btnKardex.Name
        frm.Show()
    End Sub

    Private Sub btnSaldoProducto_Click(sender As Object, e As EventArgs) Handles btnSaldoProducto.Click
        Dim frm As New Pr_SAldosPorAlmacenLinea
        Modelo.MGlobal._nameButton = btnSaldoProducto.Name
        frm.Show()
    End Sub

    Private Sub btnKardexProducto_Click(sender As Object, e As EventArgs) Handles btnKardexProducto.Click
        Dim frm As New Pr_KardexProductos
        frm.Show()
    End Sub

    Private Sub btnSaldosValorados_Click(sender As Object, e As EventArgs) Handles btnSaldosValorados.Click
        Dim frm As New Pr_StockUtilidad
        frm.Show()
    End Sub

    Private Sub MetroTileItem3_Click(sender As Object, e As EventArgs)
        Dim frm As New Form1
        frm.Show()
    End Sub

    Private Sub M_Configuracion_Click(sender As Object, e As EventArgs) Handles M_Configuracion.Click

    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        Dim frm As New F0_Precios
        Modelo.MGlobal._nameButton = btnPrecios.Name
        frm.Show()
    End Sub

    Private Sub btnPacientesAten_Click(sender As Object, e As EventArgs) Handles btnPacientesAten.Click
        Dim frm As New Pr_PacientesPorDia
        frm.Show()
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        rmSesion.IsOpen = True
        rmSesion.MenuLocation = New Point(Me.Width / 2, Me.Height / 3)
        'SideNav_Conf.Select()
    End Sub

    Private Sub rmSesion_ItemClick(sender As Object, e As EventArgs) Handles rmSesion.ItemClick
        Dim item As RadialMenuItem = TryCast(sender, RadialMenuItem)
        If item IsNot Nothing AndAlso (Not String.IsNullOrEmpty(item.Text)) Then
            Dim sesion As New Login
            Select Case item.Name
                Case "btnCerrarSesion"
                    Me.Hide()
                    'Me.Close()
                    'Application.ExitThread()
                    'Login.Visible = True
                    M_Configuracion.Select()
                    Login.Show()
                Case "btnSalir"
                    _Salir()
                Case "btnAbout"
                    'Dim frm As New P_Acerca
                    'frm.ShowDialog()
            End Select
        End If
    End Sub


    Private Sub btnReciboCirugia_Click(sender As Object, e As EventArgs) Handles btnReciboCirugia.Click
        Dim frm As New F1_Fic_ReciboCirugia
        Modelo.MGlobal._nameButton = btnReciboCirugia.Name
        frm.Show()
    End Sub

    Private Sub btnPagosCliente_Click(sender As Object, e As EventArgs) Handles btnPagosCliente.Click
        Dim frm As New F0_Cobrar_Cliente
        Modelo.MGlobal._nameButton = btnPagosCliente.Name
        frm.Show()
    End Sub

    Private Sub btnReporteNotasPorCobrar_Click(sender As Object, e As EventArgs) Handles btnReporteNotasPorCobrar.Click
        Dim frm As New Pr_ReporteMorosidadGeneral
        Modelo.MGlobal._nameButton = btnReporteNotasPorCobrar.Name
        frm.Show()
    End Sub

    Private Sub btnReportePagos_Click(sender As Object, e As EventArgs) Handles btnReportePagos.Click
        Dim frm As New PR_ResumenCaja
        Modelo.MGlobal._nameButton = btnReportePagos.Name
        frm.Show()
    End Sub

    Private Sub btVentVenta_Click(sender As Object, e As EventArgs) Handles btnVentasAtendidas.Click
        Dim frm As New Pr_VentasAtendidas
        Modelo.MGlobal._nameButton = btnVentasAtendidas.Name
        frm.Show()
    End Sub

    Private Sub btInvSaldoLote_Click(sender As Object, e As EventArgs) Handles btnInvSaldoLote.Click
        Dim frm As New PR_StockActualProductosLotes
        Modelo.MGlobal._nameButton = btnInvSaldoLote.Name
        frm.Show()
    End Sub

    Private Sub btnCobroInt_Click(sender As Object, e As EventArgs) Handles btn1.Click

    End Sub

    Private Sub btnRealizarPAgos_Click(sender As Object, e As EventArgs) Handles btnRealizarPAgos.Click
        Dim frm As New F0_PagosCredito
        Modelo.MGlobal._nameButton = btnRealizarPAgos.Name
        frm.Show()
    End Sub

    Private Sub btnReporteKArdex_Click(sender As Object, e As EventArgs) Handles btnReporteKArdex.Click
        Dim frm As New Pr_KardexCredito

        Modelo.MGlobal._nameButton = btnReporteKArdex.Name
        frm.Show()
    End Sub

    Private Sub btComPagosCredito_Click(sender As Object, e As EventArgs) Handles btComPagosCredito.Click
        Dim frm As New F0_PagosCreditoCompraUlt
        Modelo.MGlobal._nameButton = btComPagosCredito.Name
        frm.Show()
    End Sub

    Private Sub btnConsultorios_Click(sender As Object, e As EventArgs) Handles btnConsultorios.Click
        Dim frm As New F1_Con_Consultorios
        Modelo.MGlobal._nameButton = btnConsultorios.Name
        frm.Show()
    End Sub
End Class
