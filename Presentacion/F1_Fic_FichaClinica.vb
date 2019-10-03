Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.Data.SqlClient
Imports System.IO

Public Class F1_Fic_FichaClinica
#Region "Variables"
    Public _IdPaciente, _Iniciar, _MPos, _faId, _fbId, _fbEstado As Integer
    Public _Paciente As String
    Private _Limpiar As Boolean
    Private _HoraInicial As String
    Public TablaImagenes As DataTable
    Dim RutaTemporal As String = "C:\Tempora"
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim _Nombre As String = ""
    Dim mstream1 = New MemoryStream()
    Dim _swCirugia As Boolean = False
    Dim L_Usuario As String = "DEFAULT"
    'faId Es el codigo de atencion
#End Region
#Region "Eventos"
    Private Sub F1_Fic_FichaClinica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        superTabControl1.SelectedTabIndex = 0
        _prIniciarTodo()
    End Sub
    Private Sub JGListaArchivos_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGListaArchivos.EditingCell
        e.Cancel = True
    End Sub
    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        Dim frm As New F1_Fic_Recibo
        frm._IdFicha = txtIdFicha.Text
        frm._IdPaciente = txtIdMascota.Text
        frm.Show()
    End Sub
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            'Dim archivo As New OpenFileDialog
            'archivo.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
            'archivo.Filter = "Todos los archivos (*.*)|*.*"
            'archivo.Multiselect = True
            'If (archivo.ShowDialog = DialogResult.OK) Then

            'End If
            _fnCopiarImagenRutaDefinida()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub JGBusqFichaClinica_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqFichaClinica.SelectionChanged
        If (JGBusqFichaClinica.RowCount >= 0 And JGBusqFichaClinica.Row >= 0) Then
            _prMostrarRegistro(JGBusqFichaClinica.Row)
        End If
    End Sub
    '********Primero
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqFichaClinica.RowCount > 0 Then
            _MPos = 0
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    '********Anterior
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqFichaClinica.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    '********Siguiente
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqFichaClinica.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    '********Ultimo
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqFichaClinica.RowCount > 0 Then
            _MPos = JGBusqFichaClinica.RowCount - 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    Private Sub btnGuardarArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarArchivo.Click
        _prPasarIamgenTabla()
    End Sub
    '********Muestra la imagen en visualizador
    Private Sub JGListaArchivos_DoubleClick(sender As Object, e As EventArgs) Handles JGListaArchivos.DoubleClick
        If JGListaArchivos.GetValue("Estado") <> 0 Then
            Dim A = RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + JGListaArchivos.GetValue("feImg")
            'Shell("rundll32.exe C:\WINDOWS\system32\shimgvw.dll,ImageView_Fullscreen " + RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + JGListaArchivos.GetValue("feImg"))
            Process.Start(A)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Para vizualizar la imagen debe guardar la ficha clinica".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If
    End Sub
    Private Sub txtIdVeterinario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdVeterinario.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarEmpleado()
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("ecId,", True, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("ecNomb", True, "Nombre", 180))
            listEstCeldas.Add(New Modelo.Celda("ec_lbIdLib", False, "ec_lbIdLib", 180))
            listEstCeldas.Add(New Modelo.Celda("lbdesc", True, "Tipo de Empleado", 180))
            listEstCeldas.Add(New Modelo.Celda("ecCi", True, "N. Documento", 130))
            listEstCeldas.Add(New Modelo.Celda("ecDir", False, "Direccion", 180))
            listEstCeldas.Add(New Modelo.Celda("ecTelf", False, "ecTelf", 180))
            listEstCeldas.Add(New Modelo.Celda("ecMail", False, "ecMail", 180))
            listEstCeldas.Add(New Modelo.Celda("ecEst", False, "ecEst".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("Estado", False, "Estado".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFNac", False, "F.de Nacimiento".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFIngr", False, "F.de Ingreso".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecImg", False, "ecImg".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFecha", False, "ecFecha".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecHora", False, "ecHora".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecUsuario", False, "ecUsuario".ToUpper, 150))
            Dim ef = New Efecto
            ef.tipo = 3
            ef.dt = dt
            ef.SeleclCol = 2
            ef.listEstCeldas = listEstCeldas
            ef.alto = 160
            ef.ancho = 310
            ef.Context = "Seleccione Empleado".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                If (IsNothing(Row)) Then
                    txtNombVeterinario.Focus()
                    Return
                End If
                txtIdVeterinario.Text = Row.Cells("ecId").Value
                txtNombVeterinario.Text = Row.Cells("ecNomb").Value
            End If
        End If
    End Sub

    Private Sub chbCirugia_CheckedChanged(sender As Object, e As EventArgs) Handles chbCirugia.CheckedChanged
        If chbCirugia.Checked Then
            'Cirugia
            txtPesoC.IsInputReadOnly = False
            txtEdadC.ReadOnly = False
            txtResponsable.ReadOnly = False
            txtTelefonoC.ReadOnly = False
            txtImportadora.ReadOnly = False
            txtClasificacion.ReadOnly = False
            txtProcedimiento.ReadOnly = False
            txtObservacionC.ReadOnly = False
        Else
            'Cirugia
            dtpFCirugía.Enabled = False
            txtPesoC.IsInputReadOnly = True
            txtEdadC.ReadOnly = True
            txtResponsable.ReadOnly = True
            txtTelefonoC.ReadOnly = True
            txtImportadora.ReadOnly = True
            txtClasificacion.ReadOnly = True
            txtProcedimiento.ReadOnly = True
            txtObservacionC.ReadOnly = True
        End If
    End Sub

    Private Sub chbExcDelgCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbExcDelgCC.CheckedChanged
        If chbExcDelgCC.Checked Then
            txtScoreCorporal.Text = "1"
        End If
    End Sub

    Private Sub chbBajoPesoCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbBajoPesoCC.CheckedChanged
        If chbBajoPesoCC.Checked Then
            txtScoreCorporal.Text = "2"
        End If
    End Sub

    Private Sub chbPesoIdealCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbPesoIdealCC.CheckedChanged
        If chbPesoIdealCC.Checked Then
            txtScoreCorporal.Text = "3"
        End If
    End Sub

    Private Sub chbSobrepesoCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbSobrepesoCC.CheckedChanged
        If chbSobrepesoCC.Checked Then
            txtScoreCorporal.Text = "4"
        End If
    End Sub

    Private Sub chbSobExtremoCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbSobExtremoCC.CheckedChanged
        If chbSobExtremoCC.Checked Then
            txtScoreCorporal.Text = "5"
        End If
    End Sub
    Private Sub JGFechasSeg_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGFechasSeg.EditingCell
        e.Cancel = True
        txtSeguimiento.Text = JGFechasSeg.GetValue("fjSeguimiento")
    End Sub
    Private Sub JGBusqFichaClinica_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqFichaClinica.EditingCell
        e.Cancel = True
    End Sub
    'Alta de ficha clinica
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If txtIdFicha.Text <> String.Empty Then
            Dim res As Boolean = L_fnModificarFichaClinicaAlta(txtIdFicha.Text)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Id de la ficha clinica ".ToUpper + txtIdFicha.Text + " dado de Alta con Exito.".ToUpper,
                                          img, 3000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
                _prInhabilitar()
                _prFiltrar(2)
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El alta de la ficha clinica no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If
        End If
    End Sub
#End Region
#Region "Metodos Privados"
    Private Sub _prIniciarTodo()
        _HoraInicial = DateTime.Now.ToShortTimeString()
        _PMAsignarPermisos()
        _prCargarFichaClinica()
        _prCrearCarpetaImagenes()
        _prCrearCarpetaTemporal()
        _prHabilitarMenu(1)
        '**Nueva Ficha, consulta o emergencia
        If _Iniciar = 1 Then
            _MNuevo = True
            _prLimpiar()
            txtIdMascota.Text = _IdPaciente
            txtMascota.Text = _Paciente
            _prMostrarPaciente()
            _prCargarFichaClinicaSeguimiento(-1)
            _prHabilitar()
        Else
            '**Modificar Ficha, reconsulta o emergencia
            If _Iniciar = 2 Then
                _MPos = -1
                _MNuevo = False
                For Each fila As GridEXRow In JGBusqFichaClinica.GetRows
                    _MPos = _MPos + 1
                    If fila.Cells("fbid").Value = _fbId Then
                        _prMostrarRegistro(_MPos)
                        _prHabilitar()
                    End If
                Next
            End If
        End If
        If _Iniciar = 3 Then
            _prInhabilitar()
        End If
    End Sub
    'prueb
    Private Sub _prMostrarPaciente()
        Dim _dtPaciente As DataTable = L_MostrarPacientes()
        Dim _FilaPaciente As DataRow()
        _FilaPaciente = _dtPaciente.Select("pbid=" + txtIdMascota.Text)
        _dtPaciente = _FilaPaciente.CopyToDataTable
        'Cirugia
        txtPropietarioC.Text = _dtPaciente.Rows(0).Item("cacliente")
        txtPacienteC.Text = _dtPaciente.Rows(0).Item("pbnomb")
        txtEspecieC.Text = _dtPaciente.Rows(0).Item("Especie")
        txtSexoC.Text = _dtPaciente.Rows(0).Item("pbsex")
        'Internacion
        txtPropietarioI.Text = _dtPaciente.Rows(0).Item("cacliente")
        txtPacienteI.Text = _dtPaciente.Rows(0).Item("pbnomb")
        txtEspecieI.Text = _dtPaciente.Rows(0).Item("Especie")
        txtSexoI.Text = _dtPaciente.Rows(0).Item("pbsex")
    End Sub
    Private Sub _prHabilitarMenu(tipo As Integer)
        If tipo = 1 Then
            If _Iniciar = 1 Or _Iniciar = 2 Then
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnGrabar.Enabled = True
                btnAlta.Enabled = True
                PanelNavegacion.Enabled = False
                superTabItem2.Enabled = False
            End If
        Else
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnAlta.Enabled = True
            btnGrabar.Enabled = False
            PanelNavegacion.Enabled = True
            superTabItem2.Enabled = True
        End If
    End Sub
    Private Sub _prObtenerDetalle(ByRef tabla As DataTable)
        'GRUPO - LINEA - VALOR1 - VALOR 2, VALOR 3, VALOR 4, VALOR 5
        tabla.Rows.Add("FIC.CLIN0022.Horarios", 1, IIf(chbNormalH.Checked, 1, 0),
                                                   IIf(chbEmergenciaH.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.CondicionCorporal", 2,
                                                   IIf(chbExcDelgCC.Checked, 1, 0),
                                                   IIf(chbBajoPesoCC.Checked, 2, 0),
                                                   IIf(chbPesoIdealCC.Checked, 3, 0),
                                                   IIf(chbSobrepesoCC.Checked, 4, 0),
                                                   IIf(chbSobExtremoCC.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.Mucosas", 3,
                                                   IIf(chbPalidasM.Checked, 1, 0),
                                                   IIf(chbNormalesM.Checked, 2, 0),
                                                   IIf(chbHiperemicasM.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Dentadura", 4,
                                                   IIf(chbNormalD.Checked, 1, 0),
                                                   IIf(chbAnormalD.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.DanoPeriontal", 5,
                                                   IIf(chbunoDP.Checked, 1, 0),
                                                   IIf(chbdosDP.Checked, 2, 0),
                                                   IIf(chbtresDP.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Encias", 6,
                                                   IIf(chbNormalE.Checked, 1, 0),
                                                   IIf(chbAnormalE.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Gingivitis", 7,
                                                   IIf(chbLeveG.Checked, 1, 0),
                                                   IIf(chbModeradaG.Checked, 2, 0),
                                                   IIf(chbSeveraG.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Sarro", 8,
                                                  IIf(chbLeveS.Checked, 1, 0),
                                                  IIf(chbModeradoS.Checked, 2, 0),
                                                  IIf(chbSeveroS.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.MasaOral", 9, IIf(chbMasaOral.Checked, 1, 0), 0, 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.PorcentajeDeshidratacion", 10,
                                                   IIf(chbPorDeshi1.Checked, 1, 0),
                                                   IIf(chbPorDeshi2.Checked, 2, 0),
                                                   IIf(chbPorDeshi3.Checked, 3, 0),
                                                   IIf(chbPorDeshi4.Checked, 4, 0),
                                                   IIf(chbPorDeshi5.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.Ojos", 11,
                                                  IIf(chbNormalO.Checked, 1, 0),
                                                  IIf(chbAnormalO.Checked, 2, 0),
                                                  IIf(chbDerechoO.Checked, 3, 0),
                                                  IIf(chbIzquierdoO.Checked, 4, 0), 0)
        tabla.Rows.Add("FIC.CLIN0022.Orejas", 12,
                                                  IIf(chbNormalOr.Checked, 1, 0),
                                                  IIf(chbAnormalOr.Checked, 2, 0),
                                                  IIf(chbDerechaOr.Checked, 3, 0),
                                                  IIf(chbIzquierdaOr.Checked, 4, 0), 0)
        tabla.Rows.Add("FIC.CLIN0022.Corazon", 13,
                                              IIf(chbNormalC.Checked, 1, 0),
                                              IIf(chbAnormalC.Checked, 2, 0),
                                              IIf(chbRuidosCardiacos.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Pulmones", 14,
                                              IIf(chbNormalP.Checked, 1, 0),
                                              IIf(chbAnormalP.Checked, 2, 0),
                                              IIf(chbRuidosRespP.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.PielPelo", 15,
                                              IIf(chbNormalPe.Checked, 1, 0),
                                              IIf(chbAnormalPe.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Linfonodulos", 16,
                                              IIf(chbNormalL.Checked, 1, 0),
                                              IIf(chbAnormalL.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaNervioso", 17,
                                              IIf(chbNormalSN.Checked, 1, 0),
                                              IIf(chbAnormalSN.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaGenitoUrinario", 18,
                                      IIf(chbNormalG.Checked, 1, 0),
                                      IIf(chbAnormalG.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaMusculoEsqueletico", 19,
                                      IIf(chbNormalSME.Checked, 1, 0),
                                      IIf(chbAnormalSME.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaMusculoEsqueletico", 20,
                                           IIf(chbmpostizq.Checked, 3, 0),
                                           IIf(chbmpostder.Checked, 4, 0),
                                           IIf(chbPelvis.Checked, 5, 0),
                                           IIf(chbAbdomen.Checked, 6, 0),
                                           IIf(chbTorax.Checked, 7, 0))
        tabla.Rows.Add("FIC.CLIN0022.SistemaMusculoEsqueletico", 21,
                                           IIf(chbmantizq.Checked, 8, 0),
                                           IIf(chbmantder.Checked, 9, 0),
                                           IIf(chbCabeza.Checked, 10, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Abdomen", 22,
                                    IIf(chbNormalA.Checked, 1, 0),
                                    IIf(chbAnormalA.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Dolor", 23,
                                          IIf(chbAgudoD.Checked, 1, 0),
                                          IIf(chbLeveD.Checked, 2, 0),
                                          IIf(chbModeradoD.Checked, 3, 0),
                                          IIf(chbSeveroD.Checked, 4, 0), 0)
        tabla.Rows.Add("FIC.CLIN0022.LocalizadoRegion", 24,
                                        IIf(chbmpostizq.Checked, 1, 0),
                                        IIf(chbmpostder.Checked, 2, 0),
                                        IIf(chbPelvis.Checked, 3, 0),
                                        IIf(chbAbdomen.Checked, 4, 0),
                                        IIf(chbTorax.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.LocalizadoRegion", 25,
                                        IIf(chbmpostizq.Checked, 6, 0),
                                        IIf(chbmpostder.Checked, 7, 0),
                                        IIf(chbPelvis.Checked, 8, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Alteraciones", 26,
                                         IIf(chbExtraño.Checked, 1, 0),
                                         IIf(chblineal.Checked, 2, 0),
                                         IIf(chbMabdominal.Checked, 3, 0),
                                         IIf(chbIntu.Checked, 4, 0),
                                         IIf(chbAscitis.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.ExamenesComplementarios", 27,
                                      IIf(chbLaboratorio.Checked, 1, 0),
                                      IIf(chbEcografia.Checked, 2, 0),
                                      IIf(chbRadiografia.Checked, 3, 0), 0, 0)
    End Sub
    Private Sub _prCargarFichaClinica()
        Dim dt As New DataTable
        dt = L_fnMostrarFichaClinica()
        JGBusqFichaClinica.DataSource = dt
        JGBusqFichaClinica.RetrieveStructure()
        JGBusqFichaClinica.AlternatingColors = True
        With JGBusqFichaClinica.RootTable.Columns("fbid")
            .Width = 100
            .Caption = "Id"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGBusqFichaClinica.RootTable.Columns("fb_ecId")
            .Width = 100
            .Caption = "IdEmpleado"
            .Visible = False

        End With
        With JGBusqFichaClinica.RootTable.Columns("fb_pbid")
            .Width = 90
            .Visible = False
            .Caption = "Id Paciente"
        End With
        With JGBusqFichaClinica.RootTable.Columns("ecNomb")
            .Width = 180
            .Caption = "Veterinario"
            .Visible = True
        End With
        With JGBusqFichaClinica.RootTable.Columns("pbnomb")
            .Width = 180
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbPeso")
            .Width = 130
            .Visible = True
            .Caption = "Peso Kg."
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbFechaAten")
            .Width = 150
            .Caption = "Fecha Atención"
            .Visible = True
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbFechaProx")
            .Width = 150
            .Caption = "Fecha Reconsulta"
            .Visible = True
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbHist")
            .Width = 90
            .Visible = False
            .Caption = "Historia"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbExam")
            .Width = 90
            .Visible = False
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Examinacion"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbTempe")
            .Width = 90
            .Caption = "Temperatura"
            .Visible = False
        End With

        '    clin.fbFreCar, clin.fbFreRes, clin.fbSCorp,
        '    clin.fbTiemCapi, clin.fbNotas, clin.fbValora,
        '    clin.fbProtMane, clin.fbSegui
        With JGBusqFichaClinica.RootTable.Columns("fbFreCar")
            .Width = 90
            .Visible = False
            .Caption = "fbFreCar"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbFreRes")
            .Width = 90
            .Visible = False
            .Caption = "fbFreRes"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbSCorp")
            .Width = 90
            .Visible = False
            .Caption = "fbSCorp"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbTiemCapi")
            .Width = 90
            .Visible = False
            .Caption = "fbTiemCapi"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbTiemRPlie")
            .Width = 90
            .Visible = False
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbNotas")
            .Width = 90
            .Visible = False
            .Caption = "fbNotas"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbValora")
            .Width = 90
            .Visible = False
            .Caption = "fbValora"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbProtMane")
            .Width = 90
            .Visible = False
            .Caption = "fbProtMane"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbAlta")
            .Width = 90
            .Visible = False
            .Caption = "fbAlta"
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbFecha")
            .Visible = False
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbHora")
            .Visible = False
        End With
        With JGBusqFichaClinica.RootTable.Columns("fbUsuario")
            .Visible = False
        End With
        With JGBusqFichaClinica
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
        'If (dt.Rows.Count <= 0) Then
        '    _prCargarDetalleVenta(-1)
        'End If
    End Sub
    Private Sub _prCargarFichaClinicaSeguimiento(_fbId As String)
        Dim dt As New DataTable
        dt = L_prMostrarFichaClinicaSeguimiento(_fbId)
        JGFechasSeg.DataSource = dt
        JGFechasSeg.RetrieveStructure()
        JGFechasSeg.AlternatingColors = True
        ''	seg.fjId,seg.fj_FbId,seg.fjEstado,seg.fjSeguimientomiento,seg.fjFecha,seg.fjHora,seg.fjUsuario
        With JGFechasSeg.RootTable.Columns("fjId")
            .Width = 100
            .Caption = "Id"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = False
        End With
        With JGFechasSeg.RootTable.Columns("fj_FbId")
            .Width = 100
            .Caption = "IdFicha"
            .Visible = False

        End With
        With JGFechasSeg.RootTable.Columns("Estado")
            .Width = 90
            .Visible = False
            .Caption = "Estado"
        End With
        With JGFechasSeg.RootTable.Columns("fjSeguimiento")
            .Width = 180
            .Caption = "Seguimiento"
            .Visible = False
        End With
        With JGFechasSeg.RootTable.Columns("fjFecha")
            .Width = 130
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGFechasSeg.RootTable.Columns("fjHora")
            .Width = 130
            .Visible = True
            .Caption = "Hora"
        End With
        With JGFechasSeg.RootTable.Columns("fjUsuario")
            .Width = 190
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGFechasSeg
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Public Sub _prMostrarRegistro(_N As Integer)
        JGBusqFichaClinica.Row = _N
        With JGBusqFichaClinica
            txtIdFicha.Text = .GetValue("fbid")
            txtIdVeterinario.Text = .GetValue("fb_ecId")
            txtNombVeterinario.Text = .GetValue("ecNomb")
            txtIdMascota.Text = .GetValue("fb_pbid")
            txtMascota.Text = .GetValue("pbnomb")
            dtpFechaFC.Value = .GetValue("fbFechaAten")
            dtpFProxVisita.Value = .GetValue("fbFechaProx")
            txtHistoria.Text = .GetValue("fbHist")
            txtExaminacion.Text = .GetValue("fbExam")
            txtTemperatura.Text = .GetValue("fbTempe")
            txtPeso.Text = .GetValue("fbPeso")
            txtFCardiaca.Text = .GetValue("fbFreCar")
            txtFRespiratoria.Text = .GetValue("fbFreRes")
            txtScoreCorporal.Text = .GetValue("fbSCorp")
            txtTLCapilar.Text = .GetValue("fbTiemCapi")
            txtTRPliegue.Text = .GetValue("fbTiemRPlie")
            txtNotas.Text = .GetValue("fbNotas")
            txtValoracion.Text = .GetValue("fbValora")
            txtProManejo.Text = .GetValue("fbProtMane")
            'txtSeguimiento.Text = .GetValue("fbSegui")
            _prCargarFichaClinicaDetalle(Convert.ToInt32(txtIdFicha.Text))
            _prCargarImagen(Convert.ToInt32(txtIdFicha.Text))
            _prCargarFichaClinicaSeguimiento(Convert.ToInt32(txtIdFicha.Text))
            'JGFechasSeg.Row = JGFechasSeg.RowCount
            txtSeguimiento.Text = JGFechasSeg.GetValue("fjSeguimiento")
            'Obtiene el paciente
            _prLimpiarCirugia()
            _prLimpiarInternacion()
            _prMostrarPaciente()
            'Habilitar ALTA 
            btnModificar.Enabled = IIf(L_fnExisteFichaClinicaAlta(txtIdFicha.Text), False, True)
            btnEliminar.Enabled = IIf(L_fnExisteFichaClinicaAlta(txtIdFicha.Text), False, True)
            btnRecibo.Enabled = IIf(L_fnExisteFichaClinicaAlta(txtIdFicha.Text), False, True)
            btnAlta.Enabled = IIf(L_fnExisteFichaClinicaAlta(txtIdFicha.Text), False, True)
            'Cirugia
            If Not L_fnExisteCirugia(txtIdFicha.Text) Then
                Dim _tabla As DataTable = L_fnMostrarCirugia()
                If _tabla.Rows.Count <> 0 Then
                    Dim _fila As DataRow()
                    _fila = _tabla.Select("cf_FbId=" + txtIdFicha.Text)
                    _tabla = _fila.CopyToDataTable
                    'Cirugia
                    chbCirugia.Checked = True
                    dtpFCirugía.Value = _tabla.Rows(0).Item("cfFechaAten")
                    txtPesoC.Text = _tabla.Rows(0).Item("cfPeso")
                    txtEdadC.Text = _tabla.Rows(0).Item("cfEdad")
                    txtResponsable.Text = _tabla.Rows(0).Item("cfRespon")
                    txtTelefonoC.Text = _tabla.Rows(0).Item("cfTelef")
                    txtImportadora.Text = _tabla.Rows(0).Item("cfImport")
                    txtClasificacion.Text = _tabla.Rows(0).Item("cfClasASA")
                    txtProcedimiento.Text = _tabla.Rows(0).Item("cfProc")
                    txtObservacionC.Text = _tabla.Rows(0).Item("cfObser")
                End If
            End If
            'Internacion
            If Not L_fnExisteInternacion(txtIdFicha.Text) Then
                Dim _tabla As DataTable = L_fnMostrarInternacion()
                If _tabla.Rows.Count <> 0 Then
                    Dim _Fila As DataRow()
                    _Fila = _tabla.Select("ig_FbId=" + txtIdFicha.Text)
                    _tabla = _Fila.CopyToDataTable
                    chbInternacion.Checked = True
                    dtpFInternacion.Value = _tabla.Rows(0).Item("igFechaIng")
                    txtEdadI.Text = _tabla.Rows(0).Item("igEdad")
                    txtTelefonoI.Text = _tabla.Rows(0).Item("igTelf")
                    txtObservacionesI.Text = _tabla.Rows(0).Item("igMotInter")
                    txtRequiere.Text = _tabla.Rows(0).Item("igRequer")
                    txtHoraInt.Text = _tabla.Rows(0).Item("igHoraInter")
                End If
            End If
            'Muestra la cantidad de registros
            LblPaginacion.Text = Str(JGBusqFichaClinica.Row + 1) + "/" + JGBusqFichaClinica.RowCount.ToString

            'Muestra el bubblebar(que usuario registró la Ficha Clínica)
            lbFecha.Text = CType(.GetValue("fbFecha"), Date).ToString("dd/MM/yyyy")
            lbHora.Text = .GetValue("fbHora").ToString
            lbUsuario.Text = .GetValue("fbUsuario").ToString
        End With
    End Sub
    Private Sub _prCargarFichaClinicaDetalle(_id As Integer)
        Dim dt As New DataTable
        dt = L_fnMostrarFichaClinicaDetalle(_id)
        For Each fila As DataRow In dt.Rows
            Select Case fila.Item("fc_fdLinea")
                Case 1
                    chbNormalH.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbEmergenciaH.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 2
                    chbExcDelgCC.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbBajoPesoCC.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbPesoIdealCC.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbSobrepesoCC.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                    chbSobExtremoCC.Checked = IIf(fila.Item("fcVal5") <> 0, True, False)
                Case 3
                    chbPalidasM.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbNormalesM.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbHiperemicasM.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 4
                    chbNormalD.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalD.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 5
                    chbunoDP.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbdosDP.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbtresDP.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 6
                    chbNormalE.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalE.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 7
                    chbLeveG.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbModeradaG.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbSeveraG.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 8
                    chbLeveS.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbModeradoS.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbSeveroS.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 9
                    chbMasaOral.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                Case 10
                    chbPorDeshi1.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbPorDeshi2.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbPorDeshi3.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbPorDeshi4.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                    chbPorDeshi5.Checked = IIf(fila.Item("fcVal5") <> 0, True, False)
                Case 11 'Ojos
                    chbNormalO.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalO.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbDerechoO.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbIzquierdoO.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                Case 12 'Orejas
                    chbNormalOr.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalOr.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbDerechaOr.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbIzquierdaOr.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                Case 13 'Corazon
                    chbNormalC.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalC.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbRuidosCardiacos.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 14 'Pulmones
                    chbNormalP.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalP.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbRuidosCardiacos.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 15 'Piel y pelo
                    chbNormalPe.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalPe.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 16 'Linfonodulos
                    chbNormalL.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalL.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 17 'Sitema nervioso
                    chbNormalSN.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalSN.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 18 'Sistema Genitourinario
                    chbNormalG.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalG.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 19 'Sistema musculo esqueletico Linea 1
                    chbNormalSME.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalSME.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 20 'Sistema musculo esqueletico Linea 2
                    chbmpostizq.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbmpostder.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbPelvis.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbAbdomen.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                    chbTorax.Checked = IIf(fila.Item("fcVal5") <> 0, True, False)
                Case 21 'Sistema musculo esqueletico Linea 3
                    chbmantizq.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbmantder.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbCabeza.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 22 'Abdomen
                    chbNormalA.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbAnormalA.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                Case 23 'Dolor
                    chbAgudoD.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbLeveD.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbModeradoD.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbSeveroD.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                Case 24 'Localizado en region linea 1
                    chbEstomago.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbHigado.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbPancreas.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbProstata.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                    chbUtero.Checked = IIf(fila.Item("fcVal5") <> 0, True, False)
                Case 25 'Localizado en region linea 2
                    chbVejiga.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbIdelgado.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbIGrueso.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                Case 26 'Alteraciones
                    chbExtraño.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chblineal.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbMabdominal.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
                    chbIntu.Checked = IIf(fila.Item("fcVal4") <> 0, True, False)
                    chbAscitis.Checked = IIf(fila.Item("fcVal5") <> 0, True, False)
                Case 26 'Examenes complementarios
                    chbLaboratorio.Checked = IIf(fila.Item("fcVal1") <> 0, True, False)
                    chbEcografia.Checked = IIf(fila.Item("fcVal2") <> 0, True, False)
                    chbRadiografia.Checked = IIf(fila.Item("fcVal3") <> 0, True, False)
            End Select

        Next
    End Sub
    Private Sub _prLimpiarCirugia()
        'Cirugia
        chbCirugia.Checked = False
        dtpFCirugía.Value = DateTime.Today()
        txtPesoC.ResetText()
        txtEdadC.Clear()
        txtResponsable.Clear()
        txtTelefonoC.Clear()
        txtImportadora.Clear()
        txtClasificacion.Clear()
        txtProcedimiento.Clear()
        txtObservacionC.Clear()
    End Sub
    Private Sub _prLimpiarInternacion()
        'Internacion
        chbInternacion.Checked = False
        dtpFInternacion.Value = DateTime.Today()
        txtEdadI.Clear()
        txtTelefonoI.Clear()
        txtObservacionesI.Clear()
        txtRequiere.Clear()
        txtHoraInt.Clear()
    End Sub
    '********Limpiar
    Private Sub _prLimpiar()
        'Imagenes
        TablaImagenes = L_prMostrarImagenesFichaClinica(-1)
        _prCargarImagen(-1)
        _prCargarFichaClinicaSeguimiento(-1)
        txtDecripcionA.Clear()
        dtpFechaAnexo.Value = DateTime.Today
        'Texbox
        txtIdFicha.Clear()
        txtIdVeterinario.Clear()
        txtIdVeterinario.Focus()
        txtExaminacion.Clear()
        txtFCardiaca.Clear()
        txtFRespiratoria.Clear()
        txtHistoria.Clear()
        txtIdFicha.Clear()
        txtIdMascota.Clear()
        txtIdVeterinario.Clear()
        txtMascota.Clear()
        txtNombVeterinario.Clear()
        txtNotas.Clear()
        txtPeso.Clear()
        txtProManejo.Clear()
        txtScoreCorporal.Clear()
        txtScoreCorporal.Clear()
        txtSeguimiento.Clear()
        txtTemperatura.Clear()
        txtTLCapilar.Text = "1"
        txtTRPliegue.Value = 1
        txtValoracion.Clear()
        'DateTime
        dtpFechaFC.Value = DateTime.Today()
        dtpFProxVisita.Value = DateTime.Today()
        'CheckBox
        chbNormalH.Checked = True
        chbEmergenciaH.Checked = False
        chbExcDelgCC.Checked = True
        chbBajoPesoCC.Checked = False
        chbPesoIdealCC.Checked = False
        chbSobrepesoCC.Checked = False
        chbSobExtremoCC.Checked = False
        chbPalidasM.Checked = True
        chbNormalesM.Checked = False
        chbHiperemicasM.Checked = False
        chbNormalD.Checked = True
        chbAnormalD.Checked = False
        chbunoDP.Checked = True
        chbdosDP.Checked = False
        chbtresDP.Checked = False
        chbNormalE.Checked = True
        chbAnormalE.Checked = False
        chbLeveG.Checked = True
        chbModeradaG.Checked = False
        chbSeveraG.Checked = False
        chbLeveS.Checked = True
        chbModeradoS.Checked = False
        chbSeveroS.Checked = False
        chbMasaOral.Checked = True
        chbPorDeshi1.Checked = True
        chbPorDeshi2.Checked = False
        chbPorDeshi3.Checked = False
        chbPorDeshi4.Checked = False
        chbPorDeshi5.Checked = False
        'Ojos
        chbNormalO.Checked = True
        chbAnormalO.Checked = False
        chbDerechoO.Checked = False
        chbIzquierdoO.Checked = False
        'Orejas
        chbNormalOr.Checked = True
        chbAnormalOr.Checked = False
        chbDerechaOr.Checked = False
        chbIzquierdaOr.Checked = False
        'Corazon
        chbNormalC.Checked = True
        chbAnormalC.Checked = False
        chbRuidosCardiacos.Checked = False
        'Pulmones
        chbNormalP.Checked = True
        chbAnormalP.Checked = False
        chbRuidosCardiacos.Checked = False
        'Piel y pelo
        chbNormalPe.Checked = True
        chbAnormalPe.Checked = False
        'Linfonodulos
        chbNormalL.Checked = True
        chbAnormalL.Checked = False
        'Sitema nervioso
        chbNormalSN.Checked = True
        chbAnormalSN.Checked = False
        'Sistema Genitourinario
        chbNormalG.Checked = True
        chbAnormalG.Checked = False
        'Sistema musculo esqueletico Linea 1
        chbNormalSME.Checked = True
        chbAnormalSME.Checked = False
        ' musculo esqueletico Linea 2
        chbmpostizq.Checked = False
        chbmpostder.Checked = False
        chbPelvis.Checked = False
        chbAbdomen.Checked = False
        chbTorax.Checked = False
        'Sistema musculo esqueletico Linea 3
        chbmantizq.Checked = False
        chbmantder.Checked = False
        chbCabeza.Checked = False
        'Abdomen
        chbNormalA.Checked = True
        chbAnormalA.Checked = False
        'Dolor
        chbAgudoD.Checked = True
        chbLeveD.Checked = False
        chbModeradoD.Checked = False
        chbSeveroD.Checked = False
        'Localizado en region linea 1
        chbEstomago.Checked = False
        chbHigado.Checked = False
        chbPancreas.Checked = False
        chbProstata.Checked = False
        chbUtero.Checked = False
        'Localizado en region linea 2
        chbVejiga.Checked = False
        chbIdelgado.Checked = False
        chbIGrueso.Checked = False
        'Alteraciones
        chbExtraño.Checked = False
        chblineal.Checked = False
        chbMabdominal.Checked = False
        chbIntu.Checked = False
        chbAscitis.Checked = False
        'Examenes complementarios
        chbLaboratorio.Checked = True
        chbEcografia.Checked = False
        chbRadiografia.Checked = False
        'Limpiar la las imagenes agregadas
        'Cirugia
        chbCirugia.Checked = False
        dtpFCirugía.Value = DateTime.Today()
        txtPesoC.ResetText()
        txtEdadC.Clear()
        txtResponsable.Clear()
        txtTelefonoC.Clear()
        txtImportadora.Clear()
        txtClasificacion.Clear()
        txtProcedimiento.Clear()
        txtObservacionC.Clear()
        'Internacion
        chbInternacion.Checked = False
        dtpFInternacion.Value = DateTime.Today()
        txtEdadI.Clear()
        txtTelefonoI.Clear()
        txtObservacionesI.Clear()
        txtRequiere.Clear()
        txtHoraInt.Clear()
        'Grilla
    End Sub
    '********Habilitar
    Private Sub _prHabilitar()
        'Imagen
        _prAddDetalleSeguimiento()
        btnAlta.Enabled = False
        btnRecibo.Enabled = False
        '        _prCargarImagen(-1)
        btnGuardarArchivo.Enabled = True
        btnExaminar.Enabled = True
        dtpFechaAnexo.Enabled = True
        txtDecripcionA.ReadOnly = False
        'Texbox
        txtIdFicha.ReadOnly = False
        txtIdVeterinario.ReadOnly = False
        txtExaminacion.ReadOnly = False
        txtFCardiaca.ReadOnly = False
        txtFRespiratoria.ReadOnly = False
        txtHistoria.ReadOnly = False
        txtIdFicha.ReadOnly = False
        txtIdMascota.ReadOnly = False
        txtIdVeterinario.ReadOnly = False
        txtMascota.ReadOnly = False
        TxtNombreUsu.ReadOnly = False
        txtNombVeterinario.ReadOnly = False
        txtNotas.ReadOnly = False
        txtPeso.ReadOnly = False
        txtProManejo.ReadOnly = False
        txtScoreCorporal.ReadOnly = False
        txtScoreCorporal.ReadOnly = False
        txtSeguimiento.ReadOnly = False
        txtTemperatura.ReadOnly = False
        txtTLCapilar.ReadOnly = False
        txtTRPliegue.IsInputReadOnly = False
        txtValoracion.ReadOnly = False
        'DateTime
        dtpFechaFC.Enabled = True
        dtpFProxVisita.Enabled = True
        'CheckBox
        chbNormalH.Enabled = True
        chbEmergenciaH.Enabled = True
        chbExcDelgCC.Enabled = True
        chbBajoPesoCC.Enabled = True
        chbPesoIdealCC.Enabled = True
        chbSobrepesoCC.Enabled = True
        chbSobExtremoCC.Enabled = True
        chbPalidasM.Enabled = True
        chbNormalesM.Enabled = True
        chbHiperemicasM.Enabled = True
        chbNormalD.Enabled = True
        chbAnormalD.Enabled = True
        chbunoDP.Enabled = True
        chbdosDP.Enabled = True
        chbtresDP.Enabled = True
        chbNormalE.Enabled = True
        chbAnormalE.Enabled = True
        chbLeveG.Enabled = True
        chbModeradaG.Enabled = True
        chbSeveraG.Enabled = True
        chbLeveS.Enabled = True
        chbModeradoS.Enabled = True
        chbSeveroS.Enabled = True
        chbMasaOral.Enabled = True
        chbPorDeshi1.Enabled = True
        chbPorDeshi2.Enabled = True
        chbPorDeshi3.Enabled = True
        chbPorDeshi4.Enabled = True
        chbPorDeshi5.Enabled = True
        'Ojos
        chbNormalO.Enabled = True
        chbAnormalO.Enabled = True
        chbDerechoO.Enabled = True
        chbIzquierdoO.Enabled = True
        'Orejas
        chbNormalOr.Enabled = True
        chbAnormalOr.Enabled = True
        chbDerechaOr.Enabled = True
        chbIzquierdaOr.Enabled = True
        'Corazon
        chbNormalC.Enabled = True
        chbAnormalC.Enabled = True
        chbRuidosCardiacos.Enabled = True
        'Pulmones
        chbNormalP.Enabled = True
        chbAnormalP.Enabled = True
        chbRuidosCardiacos.Enabled = True
        'Piel y pelo
        chbNormalPe.Enabled = True
        chbAnormalPe.Enabled = True
        'Linfonodulos
        chbNormalL.Enabled = True
        chbAnormalL.Enabled = True
        'Sitema nervioso
        chbNormalSN.Enabled = True
        chbAnormalSN.Enabled = True
        'Sistema Genitourinario
        chbNormalG.Enabled = True
        chbAnormalG.Enabled = True
        'Sistema musculo esqueletico Linea 1
        chbNormalSME.Enabled = True
        chbAnormalSME.Enabled = True
        ' musculo esqueletico Linea 2
        chbmpostizq.Enabled = True
        chbmpostder.Enabled = True
        chbPelvis.Enabled = True
        chbAbdomen.Enabled = True
        chbTorax.Enabled = True
        'Sistema musculo esqueletico Linea 3
        chbmantizq.Enabled = True
        chbmantder.Enabled = True
        chbCabeza.Enabled = True
        'Abdomen
        chbNormalA.Enabled = True
        chbAnormalA.Enabled = True
        'Dolor
        chbAgudoD.Enabled = True
        chbLeveD.Enabled = True
        chbModeradoD.Enabled = True
        chbSeveroD.Enabled = True
        'Localizado en region linea 1
        chbEstomago.Enabled = True
        chbHigado.Enabled = True
        chbPancreas.Enabled = True
        chbProstata.Enabled = True
        chbUtero.Enabled = True
        'Localizado en region linea 2
        chbVejiga.Enabled = True
        chbIdelgado.Enabled = True
        chbIGrueso.Enabled = True
        'Alteraciones
        chbExtraño.Enabled = True
        chblineal.Enabled = True
        chbMabdominal.Enabled = True
        chbIntu.Enabled = True
        chbAscitis.Enabled = True
        'Examenes complementarios
        chbLaboratorio.Enabled = True
        chbEcografia.Enabled = True
        chbRadiografia.Enabled = True
        'Limpiar la las imagenes agregadas
        _prCrearCarpetaImagenes()
        _prCrearCarpetaTemporal()
        'Cirugia
        chbCirugia.Enabled = True
        dtpFCirugía.Enabled = True
        txtPesoC.IsInputReadOnly = False
        txtEdadC.ReadOnly = False
        txtResponsable.ReadOnly = False
        txtTelefonoC.ReadOnly = False
        txtImportadora.ReadOnly = False
        txtClasificacion.ReadOnly = False
        txtProcedimiento.ReadOnly = False
        txtObservacionC.ReadOnly = False
        'Internacion
        chbInternacion.Enabled = True
        dtpFInternacion.Enabled = True
        txtEdadI.ReadOnly = False
        txtTelefonoI.ReadOnly = False
        txtObservacionesI.ReadOnly = False
        txtRequiere.ReadOnly = False
        txtHoraInt.ReadOnly = False
    End Sub
    '********InHabilitar
    Private Sub _prInhabilitar()
        btnAlta.Enabled = True
        btnRecibo.Enabled = True
        'Imagen
        btnGuardarArchivo.Enabled = False
        btnExaminar.Enabled = False
        dtpFechaAnexo.Enabled = False
        txtDecripcionA.ReadOnly = True
        'Texbox
        txtIdFicha.ReadOnly = True

        txtIdVeterinario.ReadOnly = True
        txtExaminacion.ReadOnly = True
        txtFCardiaca.ReadOnly = True
        txtFRespiratoria.ReadOnly = True
        txtHistoria.ReadOnly = True
        txtIdFicha.ReadOnly = True
        txtIdMascota.ReadOnly = True
        txtIdVeterinario.ReadOnly = True
        txtMascota.ReadOnly = True
        TxtNombreUsu.ReadOnly = True
        txtNombVeterinario.ReadOnly = True
        txtNotas.ReadOnly = True
        txtPeso.ReadOnly = True
        txtProManejo.ReadOnly = True
        txtScoreCorporal.ReadOnly = True
        txtScoreCorporal.ReadOnly = True
        txtSeguimiento.ReadOnly = True
        txtTemperatura.ReadOnly = True
        txtTLCapilar.ReadOnly = True
        txtTRPliegue.IsInputReadOnly = True
        txtValoracion.ReadOnly = True
        'DateTime
        dtpFechaFC.Enabled = False
        dtpFProxVisita.Enabled = False
        'CheckBox
        chbNormalH.Enabled = False
        chbEmergenciaH.Enabled = False
        chbExcDelgCC.Enabled = False
        chbBajoPesoCC.Enabled = False
        chbPesoIdealCC.Enabled = False
        chbSobrepesoCC.Enabled = False
        chbSobExtremoCC.Enabled = False
        chbPalidasM.Enabled = False
        chbNormalesM.Enabled = False
        chbHiperemicasM.Enabled = False
        chbNormalD.Enabled = False
        chbAnormalD.Enabled = False
        chbunoDP.Enabled = False
        chbdosDP.Enabled = False
        chbtresDP.Enabled = False
        chbNormalE.Enabled = False
        chbAnormalE.Enabled = False
        chbLeveG.Enabled = False
        chbModeradaG.Enabled = False
        chbSeveraG.Enabled = False
        chbLeveS.Enabled = False
        chbModeradoS.Enabled = False
        chbSeveroS.Enabled = False
        chbMasaOral.Enabled = False
        chbPorDeshi1.Enabled = False
        chbPorDeshi2.Enabled = False
        chbPorDeshi3.Enabled = False
        chbPorDeshi4.Enabled = False
        chbPorDeshi5.Enabled = False
        'Ojos
        chbNormalO.Enabled = False
        chbAnormalO.Enabled = False
        chbDerechoO.Enabled = False
        chbIzquierdoO.Enabled = False
        'Orejas
        chbNormalOr.Enabled = False
        chbAnormalOr.Enabled = False
        chbDerechaOr.Enabled = False
        chbIzquierdaOr.Enabled = False
        'Corazon
        chbNormalC.Enabled = False
        chbAnormalC.Enabled = False
        chbRuidosCardiacos.Enabled = False
        'Pulmones
        chbNormalP.Enabled = False
        chbAnormalP.Enabled = False
        chbRuidosCardiacos.Enabled = False
        'Piel y pelo
        chbNormalPe.Enabled = False
        chbAnormalPe.Enabled = False
        'Linfonodulos
        chbNormalL.Enabled = False
        chbAnormalL.Enabled = False
        'Sitema nervioso
        chbNormalSN.Enabled = False
        chbAnormalSN.Enabled = False
        'Sistema Genitourinario
        chbNormalG.Enabled = False
        chbAnormalG.Enabled = False
        'Sistema musculo esqueletico Linea 1
        chbNormalSME.Enabled = False
        chbAnormalSME.Enabled = False
        ' musculo esqueletico Linea 2
        chbmpostizq.Enabled = False
        chbmpostder.Enabled = False
        chbPelvis.Enabled = False
        chbAbdomen.Enabled = False
        chbTorax.Enabled = False
        'Sistema musculo esqueletico Linea 3
        chbmantizq.Enabled = False
        chbmantder.Enabled = False
        chbCabeza.Enabled = False
        'Abdomen
        chbNormalA.Enabled = False
        chbAnormalA.Enabled = False
        'Dolor
        chbAgudoD.Enabled = False
        chbLeveD.Enabled = False
        chbModeradoD.Enabled = False
        chbSeveroD.Enabled = False
        'Localizado en region linea 1
        chbEstomago.Enabled = False
        chbHigado.Enabled = False
        chbPancreas.Enabled = False
        chbProstata.Enabled = False
        chbUtero.Enabled = False
        'Localizado en region linea 2
        chbVejiga.Enabled = False
        chbIdelgado.Enabled = False
        chbIGrueso.Enabled = False
        'Alteraciones
        chbExtraño.Enabled = False
        chblineal.Enabled = False
        chbMabdominal.Enabled = False
        chbIntu.Enabled = False
        chbAscitis.Enabled = False
        'Examenes complementarios
        chbLaboratorio.Enabled = False
        chbEcografia.Enabled = False
        chbRadiografia.Enabled = False
        'Limpiar la las imagenes agregadas
        'Cirugia
        chbCirugia.Enabled = False
        dtpFCirugía.Enabled = False
        txtPesoC.IsInputReadOnly = True  'Por verificar
        txtEdadC.ReadOnly = False
        txtResponsable.ReadOnly = True
        txtTelefonoC.ReadOnly = True
        txtImportadora.ReadOnly = True
        txtClasificacion.ReadOnly = True
        txtProcedimiento.ReadOnly = True
        txtObservacionC.ReadOnly = True
        'Internacion
        chbInternacion.Enabled = False
        dtpFInternacion.Enabled = False
        txtEdadI.ReadOnly = True
        txtTelefonoI.ReadOnly = True
        txtObservacionesI.ReadOnly = True
        txtRequiere.ReadOnly = True
        txtHoraInt.ReadOnly = True

    End Sub
    '*******Filtrar
    Public Sub _prFiltrar(tipo As Integer)
        _prCargarFichaClinica()
        If JGBusqFichaClinica.RowCount > 0 Then
            _MPos = 0
            _prMostrarRegistro(IIf(tipo = 1, _MPos, JGBusqFichaClinica.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Private Function _fnCopiarImagenRutaDefinida() As String
        'copio la imagen en la carpeta del sistema
        'Dim archivo As New OpenFileDialog
        'archivo.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
        'archivo.Filter = "Todos los archivos (*.*)|*.*"
        'archivo.Multiselect = True
        'If (archivo.ShowDialog = DialogResult.OK) Then

        'End If
        Dim file As New OpenFileDialog()
        file.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
        file.Filter = "Todos los archivos (*.*)|*.*"
        file.Multiselect = True
        If file.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = file.FileName
            Dim bytes = ArchivoABytes(ruta)

            If file.CheckFileExists = True Then
                Dim img As New Bitmap(New Bitmap(ruta))
                Dim a As Object = file.GetType.ToString

                Dim da As String = Str(Now.Day).Trim + Str(Now.Month).Trim + Str(Now.Year).Trim + Str(Now.Hour) + Str(Now.Minute) + Str(Now.Second)
                _Nombre = "\Imagen_" + da + ".jpg".Trim
                If (_fnActionNuevo()) Then
                    Dim mstream = New MemoryStream()
                    'a.fe_FbId ,a.feDesc ,A.feImg,Cast(null as image) as img,1 as estado
                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    '.Rows.Add(0, txtIdFicha.Text, txtDecripcionA.Text, _Nombre, mstream.ToArray(), 0)
                    mstream1 = mstream
                    mstream.Dispose()

                Else
                    Dim mstream = New MemoryStream()
                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    'a.ienumi , a.ienumiti4, a.ieimg, Cast(null As image) As img, 1 as estado
                    'TablaImagenes.Rows.Add(0, txtIdFicha.Text, txtDecripcionA.Text, _Nombre, mstream.ToArray(), 0)
                    mstream1 = mstream
                    mstream.Dispose()

                End If
                img.Save(RutaTemporal + _Nombre, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
            Return _Nombre
        End If
        Return "default.jpg"
    End Function
    '1er
    Private Function ArchivoABytes(ByVal pth As String) As Byte()
        Try
            Dim fs As New FileStream(pth, FileMode.Open)
            fs.Position = 0
            Dim bytes(0 To fs.Length - 1) As Byte
            fs.Read(bytes, 0, fs.Length)
            fs.Close()
            '            File.Delete(pth)
            Return bytes
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function
    '2do
    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    '3er
    Sub GuardaImagenDocumento(ByVal prmparametro As SqlParameter)
        ''Dim strFecha As String = ""
        ''strFecha = "'" & String.Format("{0:yyyyMMdd}", Convert.ToDateTime(Me.DateTimePicker4.Value)) & "'"
        'Try
        '    Dim sqlCommand As New SqlCommand
        '    Dim strConsulta As String = ""
        '    With sqlCommand
        '        .Connection = gfConectar()
        '        .Connection.Open()
        '        .CommandType = CommandType.Text
        '        .CommandText = "INSERT INTO Ipo.DocumentosInv (InvestigacionID,NombreDoc,FechaDoc,CTDocumentoID,Documento" &
        '                     ",TipoArchivo,FAlta,UsrAlta,FModif,UsrModif,SitReg)VALUES("
        '        .CommandText += Me.txtFolioCE.Text & ",'" & Me.txtNomDoc.Text & "',GETDATE()," & Me.cmbTipoDoc.SelectedValue & ","
        '        .CommandText += prmparametro.ParameterName & ",'" & sExtension & "',GETDATE(),'" & frmLogin.objUsuario.pcveUsr & "',GETDATE(),'" & frmLogin.objUsuario.pcveUsr & "','A')"
        '        .Parameters.Add(prmparametro.ParameterName, prmparametro.SqlDbType)
        '        .Parameters(prmparametro.ParameterName).Value = prmparametro.Value
        '        .ExecuteNonQuery()
        '        .Connection.Close()
        '    End With
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    '4to
    Public Function ObtenCampoPorNombre(ByVal aNombreCampo As String, sqlDataRow As DataRow) As Object
        Try
            ObtenCampoPorNombre = Nothing
            If sqlDataRow Is Nothing Then
                Exit Function
            End If
            If IsDBNull(sqlDataRow.Item(aNombreCampo)) Then
                Exit Function
            End If
            ObtenCampoPorNombre = sqlDataRow.Item(aNombreCampo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    '5to
    Private Sub abrir()
        Dim bytes() As Byte
        'Dim fila As DataRow = JGListaArchivos.RootTable.Columns
        bytes = ObtenCampoPorNombre("Documento", JGListaArchivos.GetValue("image"))
        ' bytes = ObtenCampoPorNombre("Documento", fila)
        BytesAArchivo(bytes, "C:\temp.doc")
        AbrirDocumento("C:\temp.doc")
    End Sub
    '6to
    Private Sub AbrirDocumento(ByVal vFilename As String)
        Dim pr As System.Diagnostics.Process
        pr = New System.Diagnostics.Process
        Try
            pr.StartInfo.FileName = vFilename
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            pr.Start()
            'Espera el proceso para que lo termine y continuar
            pr.WaitForExit()
            'Liberar
            pr.Close()
            My.Computer.FileSystem.DeleteFile(vFilename)
        Catch ex As Exception
            MessageBox.Show(ex.Message + " No se puede abrir el documento " & vFilename, "Error")
        End Try
    End Sub

    Private Function _prPasarIamgenTabla() As String
        'copio la imagen en la carpeta del sistema
        If txtDecripcionA.Text <> String.Empty Then
            If (_fnActionNuevo()) Then
                TablaImagenes.Rows.Add(0, 0, txtDecripcionA.Text, _Nombre, mstream1.ToArray(), 0, dtpFechaAnexo.Value.ToString("yyyy/MM/dd"))
                mstream1.Dispose()
            Else
                'a.ienumi , a.ienumiti4, a.ieimg, Cast(null As image) As img, 1 as estado
                TablaImagenes.Rows.Add(0, Convert.ToInt32(txtIdFicha.Text), txtDecripcionA.Text, _Nombre, mstream1.ToArray(), 0, dtpFechaAnexo.Value.ToString("yyyy/MM/dd"))
                mstream1.Dispose()
            End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Debe agregar una descripcion".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If
        Return "default.jpg"
    End Function
    Public Function _fnActionNuevo() As Boolean
        Return txtIdFicha.Text = String.Empty
    End Function
    Public Sub _prCargarImagen(IdFicha As Integer)
        TablaImagenes = L_prMostrarImagenesFichaClinica(IdFicha)
        JGListaArchivos.DataSource = TablaImagenes
        JGListaArchivos.RetrieveStructure()
        JGListaArchivos.AlternatingColors = True
        With JGListaArchivos.RootTable.Columns("feId")
            .Width = 150
            .Caption = "Id"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = False
        End With
        With JGListaArchivos.RootTable.Columns("fe_FbId")
            .Width = 100
            .Caption = "IdFicha"
            .Visible = False

        End With
        With JGListaArchivos.RootTable.Columns("feDesc")
            .Width = 300
            .Visible = True
            .Caption = "Descripcion"
        End With
        With JGListaArchivos.RootTable.Columns("feImg")
            .Width = 500
            .Caption = "Imagen"
            .Visible = True
        End With
        With JGListaArchivos.RootTable.Columns("img")
            .Width = 130
            .Visible = False
            .Caption = "Img"
        End With
        With JGListaArchivos.RootTable.Columns("estado")
            .Width = 150
            .Caption = "Estado"
            .Visible = False
        End With
        With JGListaArchivos.RootTable.Columns("feFechaReg")
            .Width = 150
            .Caption = "Fecha"
            .Visible = True
        End With

        With JGListaArchivos
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
        'If (dt.Rows.Count <= 0) Then
        '    _prCargarDetalleVenta(-1)
        'End If
    End Sub
    Private Sub _prCrearCarpetaTemporal()

        If System.IO.Directory.Exists(RutaTemporal) = False Then
            System.IO.Directory.CreateDirectory(RutaTemporal)
        Else
            Try
                My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(RutaTemporal)
                'My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                'System.IO.Directory.CreateDirectory(RutaTemporal)

            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub _prEliminarCarpeta(Ruta As String)

        If System.IO.Directory.Exists(Ruta) = True Then
            Try
                My.Computer.FileSystem.DeleteDirectory(Ruta, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub _prCrearCarpetaImagenes()
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")

                End If
            End If
        End If
    End Sub
    Private Sub _prCrearCarpetaImagenes(carpetaFinal As String)
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal) = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\")
                Else
                    If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal) = False Then
                        System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\")
                    End If

                End If
            End If
        End If
    End Sub
    Public Sub _prGuardarImagenes(_ruta As String)
        For i As Integer = 0 To TablaImagenes.Rows.Count - 1 Step 1
            Dim estado As Integer = TablaImagenes.Rows(i).Item("estado")
            If (estado = 0) Then

                Dim bm As Bitmap = Nothing
                Dim by As Byte() = TablaImagenes.Rows(i).Item("img")
                Dim ms As New MemoryStream(by)
                bm = New Bitmap(ms)
                Try
                    bm.Save(_ruta + TablaImagenes.Rows(i).Item("feImg"), System.Drawing.Imaging.ImageFormat.Jpeg)
                Catch ex As Exception

                End Try
            End If
            If (estado = -1) Then
                Try
                    Application.DoEvents()
                    TablaImagenes.Rows(i).Item("img") = Nothing
                    If (File.Exists(_ruta + TablaImagenes.Rows(i).Item("feImg"))) Then
                        My.Computer.FileSystem.DeleteFile(_ruta + TablaImagenes.Rows(i).Item("feImg"))
                    End If
                Catch ex As Exception

                End Try
            End If
        Next
    End Sub
    Private Sub _prAddDetalleSeguimiento()
        'seg.fjId,seg.fj_FbId,seg.fjEstado,seg.fjSeguimientomiento,seg.fjFecha,seg.fjHora,seg.fjUsuario
        CType(JGFechasSeg.DataSource, DataTable).Rows.Add(0, 0, 2, "", DateTime.Now, DateTime.Now.ToShortTimeString(), TxtNombreUsu.Text)
    End Sub
    Private Sub _prEditDetalleSeguimiento()
        'seg.fjId,seg.fj_FbId,seg.fjEstado,seg.fjSeguimientomiento,seg.fjFecha,seg.fjHora,seg.fjUsuario
        JGFechasSeg.Row = IIf(JGFechasSeg.RowCount = 0, 0, JGFechasSeg.RowCount - 1)
        If JGFechasSeg.GetValue("Estado") = 2 Then
            CType(JGFechasSeg.DataSource, DataTable).Rows(JGFechasSeg.RowCount - 1).Item("fjSeguimiento") = txtSeguimiento.Text
            JGFechasSeg.SetValue("fjSeguimiento", txtSeguimiento.Text)
        End If
    End Sub

#End Region
#Region "Metodos privados overridable"
    '*******Nuevo registro
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim tFichaClinicaDetalle As DataTable = L_fnMostrarFichaClinicaVacia()
        Dim bandera As Boolean = False
        _prObtenerDetalle(tFichaClinicaDetalle)
        'Ingresa ala grilla el seguimiento
        _prEditDetalleSeguimiento()

        'Guarda la Ficha Clinica
        Dim res As Boolean = L_fnGrabarFichaClinica(txtIdFicha.Text, txtIdMascota.Text, txtIdVeterinario.Text, dtpFechaFC.Value.ToString("yyyy/MM/dd"),
                                                    dtpFProxVisita.Value.ToString("yyyy/MM/dd"), _HoraInicial, DateTime.Now.ToShortTimeString(), txtHistoria.Text, txtExaminacion.Text,
                                                    txtTemperatura.Text, txtPeso.Text, txtFCardiaca.Text, txtFRespiratoria.Text, txtScoreCorporal.Text,
                                                    txtTLCapilar.Text, txtTRPliegue.Text, txtNotas.Text, txtValoracion.Text, txtProManejo.Text, tFichaClinicaDetalle, _faId, TablaImagenes, CType(JGFechasSeg.DataSource, DataTable))
        If res Then
            'Guarda la Cirugia
            If chbCirugia.Checked Then
                Dim idCirugia As Integer
                Dim res2 As Boolean = L_fnGrabarCirugia(idCirugia, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), txtPesoC.Text, txtEdadC.Text, txtResponsable.Text,
                                                        txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
            End If
            'Guarda la internacion
            If chbInternacion.Checked Then
                Dim idInternacion As Integer
                Dim res2 As Boolean = L_fnGrabarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                                                            txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
            End If
            _prCrearCarpetaImagenes("FichaClinica_" + txtIdFicha.Text.Trim)
            _prGuardarImagenes(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + "\")
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id de la ficha clinica ".ToUpper + txtIdFicha.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prHabilitarMenu(2)
            _prInhabilitar()
            _prFiltrar(2)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha clinica no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If
        Return res
    End Function
    '*******Modificar registro
    Public Overrides Function _PMOModificarRegistro() As Boolean

        Dim tFichaClinicaDetalle As DataTable = L_fnMostrarFichaClinicaVacia()
        Dim bandera As Boolean = False
        _prObtenerDetalle(tFichaClinicaDetalle)
        'Ingresa ala grilla el seguimiento
        _prEditDetalleSeguimiento()
        Dim res As Boolean = L_fnModificarFichaClinica(txtIdFicha.Text, txtIdMascota.Text, txtIdVeterinario.Text, dtpFechaFC.Value.ToString("yyyy/MM/dd"),
                                                    dtpFProxVisita.Value.ToString("yyyy/MM/dd"), _HoraInicial, DateTime.Now.TimeOfDay.ToString(), txtHistoria.Text, txtExaminacion.Text,
                                                    txtTemperatura.Text, txtPeso.Text, txtFCardiaca.Text, txtFRespiratoria.Text, txtScoreCorporal.Text,
                                                    txtTLCapilar.Text, txtTRPliegue.Text, txtNotas.Text, txtValoracion.Text, txtProManejo.Text, tFichaClinicaDetalle, _faId, TablaImagenes, CType(JGFechasSeg.DataSource, DataTable))
        If res Then
            _prCrearCarpetaImagenes("FichaClinica_" + txtIdFicha.Text.Trim)
            _prGuardarImagenes(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + "\")
            'Cirugia
            If chbCirugia.Checked Then
                Dim idCirugia As Integer
                If L_fnExisteCirugia(txtIdFicha.Text) Then
                    'Guarda Cirugia
                    Dim res2 As Boolean = L_fnGrabarCirugia(idCirugia, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), txtPesoC.Text, txtEdadC.Text, txtResponsable.Text,
                                                            txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
                Else
                    'Modifica Cirugia
                    Dim res2 As Boolean = L_fnMoficicarCirugia(idCirugia, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), txtPesoC.Text, txtEdadC.Text, txtResponsable.Text,
                                                            txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)

                End If
            End If
            'Internacion
            If chbInternacion.Checked Then
                Dim idInternacion As Integer
                If L_fnExisteInternacion(txtIdFicha.Text) Then
                    Dim res2 As Boolean = L_fnGrabarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                                        txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
                Else
                    'Modifica Cirugia
                    Dim res2 As Boolean = L_fnModificarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                                                            txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
                End If
            End If


            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id de la ficha clinica ".ToUpper + txtIdFicha.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            'prLimpiar
            _prInhabilitar()
            _prFiltrar(2)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha clinica no pudo ser modificada".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If
        Return res
    End Function

    Private Sub txtTRPliegue_ValueChanged(sender As Object, e As EventArgs) Handles txtTRPliegue.ValueChanged
        If (txtTLCapilar.Text <= 2 And txtTRPliegue.Value <= 2) Then
            chbPorDeshi1.Checked = True
        ElseIf (txtTLCapilar.Text <= 2 And (txtTRPliegue.Value >= 3 And txtTRPliegue.Value <= 5)) Then
            chbPorDeshi2.Checked = True
        ElseIf ((txtTLCapilar.Text >= 3 And txtTLCapilar.Text <= 4) And (txtTRPliegue.Value >= 3 And txtTRPliegue.Value <= 10)) Then
            chbPorDeshi3.Checked = True
        ElseIf (txtTLCapilar.Text > 5 And txtTRPliegue.Value > 5) Then
            chbPorDeshi4.Checked = True
        ElseIf (txtTLCapilar.Text > 5 And txtTRPliegue.Value = 0) Then
            chbPorDeshi5.Checked = True
        Else
            chbPorDeshi1.Checked = False
            chbPorDeshi2.Checked = False
            chbPorDeshi3.Checked = False
            chbPorDeshi4.Checked = False
            chbPorDeshi5.Checked = False

        End If
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub txtTLCapilar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTLCapilar.KeyPress
        g_prValidarTextBox(1, e)
    End Sub


    '*******PMO NUevo
    Public Overrides Sub _PMONuevo()
        JGBusqFichaClinica.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
    End Sub
    '*******POM Modificar
    Public Overrides Sub _PMOModificar()
        JGBusqFichaClinica.Enabled = False 'Deshabilita el buscador de la Grilla
        _prHabilitar()
    End Sub
    ''*****POM Eliminar
    Public Overrides Sub _PMOEliminarRegistro()
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            'VALIDAR QUE NO ELIMINE CUANDO UNA FICHA CLINICA TENGA SEGUIMIENTO DE INTERNACION...           
            'Elimina la ficha clinica
            Dim res As Boolean = L_fnEliminarFichaClinica(txtIdFicha.Text, mensajeError)
            'Elimina Cirugia
            L_fnEliminarCirugia(txtIdFicha.Text, mensajeError)
            'Elimina internacion
            L_fnEliminarInternacion(txtIdFicha.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de la ficha clinica ".ToUpper + txtIdFicha.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)
                _prFiltrar(1)
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If
        End If
    End Sub
    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If txtIdVeterinario.Text = String.Empty Then
            txtIdVeterinario.BackColor = Color.Red
            MEP.SetError(txtIdVeterinario, "ingrese un veterinario!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Seleccione un veterinario para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        Else
            txtIdVeterinario.BackColor = Color.White
            MEP.SetError(txtIdVeterinario, "")
        End If
        If dtpFechaFC.Value > dtpFProxVisita.Value Then
            MEP.SetError(txtHistoria, "Ingrese una fecha de proxima consulta!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una fecha de próxima consulta clinica para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If
        If txtHistoria.Text = String.Empty Then
            txtHistoria.BackColor = Color.Red
            MEP.SetError(txtHistoria, "Ingrese una historia!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una historia clinica para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        Else
            txtHistoria.BackColor = Color.White
            MEP.SetError(txtHistoria, "")
        End If
        If txtExaminacion.Text = String.Empty Then
            txtExaminacion.BackColor = Color.Red
            MEP.SetError(txtExaminacion, "Ingrese una examinación!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una examinación clinica para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        Else
            txtExaminacion.BackColor = Color.White
            MEP.SetError(txtExaminacion, "")
        End If

        If txtPeso.Text = String.Empty Then
            txtPeso.BackColor = Color.Red
            MEP.SetError(txtPeso, "Ingrese un peso!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un peso de la mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        Else
            txtPeso.BackColor = Color.White
            MEP.SetError(txtPeso, "")
        End If
        If txtSeguimiento.Text = String.Empty Then
            txtSeguimiento.BackColor = Color.Red
            MEP.SetError(txtSeguimiento, "Ingrese un seguimiento!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un seguimiento clinico para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        Else
            txtSeguimiento.BackColor = Color.White
            MEP.SetError(txtSeguimiento, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    '*******PMO Salir
    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class