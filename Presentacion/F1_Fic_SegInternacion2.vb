Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Fic_SegInternacion2
#Region "VARIABLES"
    Public _IdCliente, _Iniciar, _MPos, _MPos2, _IdPaciente As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
    Dim NuevoSeg As Boolean = False
    Dim ModificarEF As Boolean = False

#End Region
#Region "Eventos"
    Private Sub F1_FIC_SegInternacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub txtIdFicClinica_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdFicClinica.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarInternacion()
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("igId,", False, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("ig_fbId", True, "Id Ficha", 90))
            listEstCeldas.Add(New Modelo.Celda("igEst", False, "Estado", 180))
            listEstCeldas.Add(New Modelo.Celda("cacliente", True, "Propietario", 210))
            listEstCeldas.Add(New Modelo.Celda("pbId", False, "IdPaciente", 150))
            listEstCeldas.Add(New Modelo.Celda("pbnomb", True, "Paciente", 150))
            listEstCeldas.Add(New Modelo.Celda("Especie", True, "Especie", 120))
            listEstCeldas.Add(New Modelo.Celda("pbsex", True, "Sexo", 120))
            listEstCeldas.Add(New Modelo.Celda("igFechaIng", True, "Fecha Int.", 90))
            listEstCeldas.Add(New Modelo.Celda("igEdad", True, "Edad", 100))
            listEstCeldas.Add(New Modelo.Celda("igTelf", False, "Telefono", 130))
            listEstCeldas.Add(New Modelo.Celda("igMotInter", False, "igMotInter", 180))
            listEstCeldas.Add(New Modelo.Celda("igRequer", False, "igRequer", 180))
            listEstCeldas.Add(New Modelo.Celda("igHoraInter", True, "Hora Int.".ToUpper, 100))
            Dim ef = New Efecto
            ef.tipo = 3
            ef.dt = dt
            ef.SeleclCol = 2
            ef.listEstCeldas = listEstCeldas
            ef.alto = 80
            ef.ancho = 190
            ef.Context = "Seleccione una Internación".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                txtIdFicClinica.Text = Row.Cells("ig_fbId").Value
                txtPropietarioI.Text = Row.Cells("cacliente").Value
                txtTelefonoI.Text = Row.Cells("igTelf").Value
                txtPacienteI.Text = Row.Cells("pbnomb").Value
                _IdPaciente = Row.Cells("pbId").Value
                txtEdadI.Text = Row.Cells("igEdad").Value
                txtSexoI.Text = Row.Cells("pbsex").Value
                txtEspecieI.Text = Row.Cells("Especie").Value
                txtMotivoI.Text = Row.Cells("igMotInter").Value
            End If
        End If
    End Sub
    Private Sub JGBusqSeguimiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqSeguimiento.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGSeguimiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGSeguimiento.EditingCell
        e.Cancel = True
    End Sub

    Private Sub cbTurno_ValueChanged(sender As Object, e As EventArgs)
        If cbTurno.SelectedIndex < 0 And cbTurno.Text <> String.Empty Then
            'btnTurno.Visible = True
        Else
            'btnTurno.Visible = False
        End If
    End Sub

    Private Sub btnTurno_Click(sender As Object, e As EventArgs)
        Dim _Id As String = ""
        ''If L_fnExisteLibreria("2", "1", cbEspecie.Text) Then
        If L_fnGrabarLibreria(_Id, "5", "1", cbTurno.Text) Then
            _prCargarComboLibreria(cbTurno, "5", "1")
            cbTurno.SelectedIndex = CType(cbTurno.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqSeguimiento.RowCount > 0 Then
            _MPos = 0
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqSeguimiento.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqSeguimiento.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqSeguimiento.RowCount > 0 Then
            _MPos = JGBusqSeguimiento.RowCount - 1
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub JGBusqSeguimiento_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqSeguimiento.SelectionChanged
        If JGBusqSeguimiento.Row >= 0 And JGBusqSeguimiento.RowCount > 0 Then
            _MPos = JGBusqSeguimiento.Row
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub JGSeguimiento_SelectionChanged(sender As Object, e As EventArgs)
        If JGSeguimiento.Row >= 0 And JGSeguimiento.RowCount > 0 Then
            _MPos2 = JGSeguimiento.Row 'Count - 1
            _prMostrarInternacionSegDet(_MPos2)
        End If
    End Sub
    Private Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        _prHabilitar()
        _prHabilitarMenu(1)
        _LimpiarDet()
        NuevoSeg = True
        JGSeguimiento.Enabled = False
        _MNuevo = False 'Manda a Formulario 1, Modificar

        'Deshabilito el Id Ficha Clinica
        txtIdFicClinica.ReadOnly = True
        txtIdFicClinica.Enabled = False
    End Sub
#End Region
#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        'Carga eL Combobox
        _prCargarComboTurno(cbTurno)
        _prCargarComboTurno(cbTurnoEF)
        _prCargarComboTurno(cbTurnoF)
        _prInhabilitar()
        _PMAsignarPermisos()
        _prCargarInternacionSeg()
        _prMostrarInternacionSeg(0)
    End Sub
    Private Sub _prHabilitarMenu(tipo As Integer)
        If tipo = 1 Then
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True
            superTabItem2.Enabled = False
            PanelNavegacion.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
            superTabItem2.Enabled = True
            PanelNavegacion.Enabled = True
        End If

    End Sub
    Private Sub _prMostrarInternacionSeg(_POS As Integer)
        If JGBusqSeguimiento.RowCount <> 0 Then
            JGBusqSeguimiento.Row = _POS
            With JGBusqSeguimiento
                txtId.Text = .GetValue("ihId")
                txtIdFicClinica.Text = .GetValue("ih_fbId")
                txtPropietarioI.Text = .GetValue("cliente")
                txtTelefonoI.Text = .GetValue("igTelf")
                txtPacienteI.Text = .GetValue("pbnomb")
                txtEdadI.Text = .GetValue("igEdad")
                txtSexoI.Text = .GetValue("pbsex")
                txtEspecieI.Text = .GetValue("Especie")
                dtpFechaSeg.Value = .GetValue("ihFechaIng")
                txtMotivoI.Text = .GetValue("igMotInter")
                cbTurno.Value = .GetValue("ihTurno")

                'Mostrar Detalles
                _prDetalleExamenFisico(.GetValue("ihId"))
                '_prCargarInternacionSegDet(.GetValue("ihId"))

                'Muestra la cantidad DE FILAS en la Grilla
                LblPaginacion.Text = Str(JGBusqSeguimiento.Row + 1) + "/" + JGBusqSeguimiento.RowCount.ToString

                'Muestra el bubblebar(que usuario registró el Seguimiento de la internación)
                lbFecha.Text = CType(.GetValue("ihFecha"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("ihHora").ToString
                lbUsuario.Text = .GetValue("ihUsuario").ToString
            End With
        End If
    End Sub

    Private Sub _prMostrarExamenFisico(_POS As Integer)
        Dim muc, desh, dol, grado As String
        If JGExamenFisico.RowCount <> 0 Then
            JGExamenFisico.Row = _POS
            With JGExamenFisico
                cbTurnoEF.Value = .GetValue("iiTurnoEF")
                txtHoraEF.Text = .GetValue("iiHoraEF")
                dtpFechaEF.Value = .GetValue("iiFechaEF")

                muc = .GetValue("iiMucosas")
                _prMostrarMucosas(muc)
                desh = .GetValue("iiDeshidratacion")
                _prMostrarDeshidratacion(desh)
                dol = .GetValue("iiDolor")
                _prMostrarDolor(dol)
                grado = .GetValue("iiGradoConciencia")
                _prMostrarGradoConciencia(grado)

            End With
        End If
    End Sub
    Private Sub _prMostrarMucosas(ByRef mucosas As String)
        If mucosas = chbRosadas.Text Then
            chbRosadas.Checked = True
        ElseIf mucosas = chbPalidas.Text Then
            chbPalidas.Checked = True
        ElseIf mucosas = chbIctericas.Text Then
            chbIctericas.Checked = True
        ElseIf mucosas = chbCianoticas.Text Then
            chbCianoticas.Checked = True
        End If
    End Sub
    Private Sub _prMostrarDeshidratacion(ByRef deshidratacion As String)
        If deshidratacion = chb0_5.Text Then
            chb0_5.Checked = True
        ElseIf deshidratacion = chb5_7.Text Then
            chb5_7.Checked = True
        ElseIf deshidratacion = chb8_10.Text Then
            chb8_10.Checked = True
        End If
    End Sub
    Private Sub _prMostrarDolor(ByRef dolor As String)
        If dolor = chbLeve.Text Then
            chbLeve.Checked = True
        ElseIf dolor = chbModerado.Text Then
            chbModerado.Checked = True
        ElseIf dolor = chbSevero.Text Then
            chbSevero.Checked = True
        End If
    End Sub
    Private Sub _prMostrarGradoConciencia(ByRef gradoconc As String)
        If gradoconc = chbEstable.Text Then
            chbEstable.Checked = True
        ElseIf gradoconc = chbSemicomatoso.Text Then
            chbSemicomatoso.Checked = True
        ElseIf gradoconc = chbComa.Text Then
            chbComa.Checked = True
        End If
    End Sub
    Private Sub _prMostrarInternacionSegDet(_POS As Integer)
        If JGSeguimiento.RowCount <> 0 Then
            JGSeguimiento.Row = _POS
            With JGSeguimiento
                ''iiId, ii_ihId, iiHoraTurn, iiObser, iiFrec, iiMedPro, iiAlim
                'txtObsRequerimientos.Text = .GetValue("iiObser")
                'txtFrecuencias.Text = .GetValue("iiFrec")
                'txtOtros.Text = .GetValue("iiOtros")
                'txtMedProtocolo.Text = .GetValue("iiMedPro")
                'txtAlimentacion.Text = .GetValue("iiAlim")
                'txtPasoTurno.Text = .GetValue("iiPasoTur")
                cbTurno.Value = .GetValue("iiTurno")
                'Falta Mostrar el iiFechaReg
            End With
        End If
    End Sub
    Private Sub _prCargarInternacionSeg()
        Dim _tabla As DataTable = L_fnMostrarInternacionSeg()
        JGBusqSeguimiento.DataSource = _tabla
        JGBusqSeguimiento.RetrieveStructure()
        JGBusqSeguimiento.AlternatingColors = True
        'ihId, ih_fbId, ihFechaIng,pac.pbnomb, ihTurno, ihDiag, ihResp, ihPasoTur
        With JGBusqSeguimiento.RootTable.Columns("ihId")
            .Width = 65
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ih_fbId")
            .Width = 150
            .Caption = "IdFicha"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ih_pbId")
            .Width = 150
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("cliente")
            .Width = 170
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("igTelf")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbid")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbnomb")
            .Width = 160
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("igEdad")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbsex")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("Especie")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("igMotInter")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihFechaIng")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihTurno")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("haTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With

        With JGBusqSeguimiento.RootTable.Columns("ihFecha")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihHora")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihUsuario")
            .Width = 100
            .Caption = "Usuario"
            .Visible = True
        End With

        With JGBusqSeguimiento
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prDetalleExamenFisico(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarInternacionSegDet(idInternacion)
        JGExamenFisico.DataSource = _tabla
        JGExamenFisico.RetrieveStructure()
        JGExamenFisico.AlternatingColors = True

        With JGExamenFisico.RootTable.Columns("iiId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("ii_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiEst")
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiFechaEF")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiHoraEF")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiTurnoEF")
            .Width = 100
            .Caption = "IdTurno"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("haTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiMucosas")
            .Width = 100
            .Caption = "Mucosas"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiDeshidratacion")
            .Width = 100
            .Caption = "Deshidratación"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiDolor")
            .Width = 100
            .Caption = "Dolor"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiGradoConciencia")
            .Width = 150
            .Caption = "Grado de Conciencia"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiusuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGExamenFisico
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prDetalleSignosVitales(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarSignosVitales(idInternacion)
        JGExamenFisico.DataSource = _tabla
        JGExamenFisico.RetrieveStructure()
        JGExamenFisico.AlternatingColors = True

        With JGExamenFisico.RootTable.Columns("iiId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("ii_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiEst")
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiFechaEF")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiHoraEF")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiTurnoEF")
            .Width = 100
            .Caption = "IdTurno"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("haTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiMucosas")
            .Width = 100
            .Caption = "Mucosas"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiDeshidratacion")
            .Width = 100
            .Caption = "Deshidratación"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiDolor")
            .Width = 100
            .Caption = "Dolor"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiGradoConciencia")
            .Width = 150
            .Caption = "Grado de Conciencia"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiusuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGExamenFisico
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prCargarInternacionSegDet(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarInternacionSegDet(idInternacion)
        JGSeguimiento.DataSource = _tabla
        JGSeguimiento.RetrieveStructure()
        JGSeguimiento.AlternatingColors = True
        'iiId, ii_ihId, iiHoraTurn, iiObser, iiFrec, iiMedPro, iiAlim
        With JGSeguimiento.RootTable.Columns("iiId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGSeguimiento.RootTable.Columns("ii_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGSeguimiento.RootTable.Columns("iiTurnoEF")
            .Width = 100
            .Caption = "Turno"
            .Visible = False
        End With
        With JGSeguimiento.RootTable.Columns("iiFechaIng")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("lbdesc")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiHoraTurn")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiObser")
            .Width = 200
            .Caption = "Observación"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiFrec")
            .Width = 200
            .Caption = "Frecuencia"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiMedPro")
            .Width = 200
            .Caption = "Medicación"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiAlim")
            .Width = 200
            .Caption = "Alimentación"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiPasoTur")
            .Width = 180
            .Caption = "Paso de Turno"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiOtros")
            .Width = 200
            .Caption = "Otros"
            .Visible = True
        End With

        With JGSeguimiento
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInhabilitar()
        JGSeguimiento.Enabled = True
        txtIdFicClinica.ReadOnly = True
        txtIdFicClinica.Enabled = False
        'txtPacienteI.ReadOnly = True
        dtpFechaSeg.Enabled = False
        cbTurno.Enabled = False

        ''Detalle Examen Físico
        cbTurnoEF.Enabled = False
        PanelMucosas.Enabled = False
        PanelDeshidratacion.Enabled = False
        PanelDolor.Enabled = False
        PanelGradoConciencia.Enabled = False
        btnAgregarEF.Enabled = False

        ''Detalle Signos Vitales
        txtVomitos.ReadOnly = True
        txtDiarreas.ReadOnly = True
        txtConvulsiones.ReadOnly = True
        txtInfartos.ReadOnly = True
        txtMiccion.ReadOnly = True
        txtDefecacion.ReadOnly = True
        txtOtrosSV.ReadOnly = True
        btnAgregarSV.Enabled = False

        ''Detalle Monitoreo
        txtT.ReadOnly = True
        txtFC.ReadOnly = True
        txtFR.ReadOnly = True
        txtPeso.ReadOnly = True
        txtSPO2.ReadOnly = True
        txtPSys.ReadOnly = True
        txtPDys.ReadOnly = True
        txtMED.ReadOnly = True
        txtTRC.ReadOnly = True
        btnAgregarM.Enabled = False

        ''Detalle Alimentacion
        txtRequerimiento.ReadOnly = True
        txtPVM.ReadOnly = True
        txtRecovery.ReadOnly = True
        txtPolloLic.ReadOnly = True
        txtPolloDesm.ReadOnly = True
        txtNPO.ReadOnly = True
        txtAgua.ReadOnly = True
        btnAgregarA.Enabled = False

        ''Detalle Fluidoterapia
        cbTurnoF.Enabled = False
        txtFluidos.ReadOnly = True
        txtHoraInicio.ReadOnly = True
        txtHoraTermino.ReadOnly = True
        txtCantidad.ReadOnly = True
        btnAgregarF.Enabled = False

        ''Detalle Estudios Complementarios
        txtEstudiosComplem.ReadOnly = True
        btnAgregarEC.Enabled = False

        ''Detalle Tratamiento
        txtTratamiento.ReadOnly = True
        btnAgregarT.Enabled = False

        _Limpiar = False
    End Sub
    Private Sub _prHabilitar()
        JGSeguimiento.Enabled = True
        'txtPacienteI.ReadOnly = False
        txtIdFicClinica.ReadOnly = False
        txtIdFicClinica.Enabled = True
        dtpFechaSeg.Enabled = True
        cbTurno.Enabled = True

        ''Detalle Examen Físico
        cbTurnoEF.Enabled = True
        PanelMucosas.Enabled = True
        PanelDeshidratacion.Enabled = True
        PanelDolor.Enabled = True
        PanelGradoConciencia.Enabled = True
        btnAgregarEF.Enabled = True

        ''Detalle Signos Vitales
        txtVomitos.ReadOnly = False
        txtDiarreas.ReadOnly = False
        txtConvulsiones.ReadOnly = False
        txtInfartos.ReadOnly = False
        txtMiccion.ReadOnly = False
        txtDefecacion.ReadOnly = False
        txtOtrosSV.ReadOnly = False
        btnAgregarSV.Enabled = True

        ''Detalle Monitoreo
        txtT.ReadOnly = False
        txtFC.ReadOnly = False
        txtFR.ReadOnly = False
        txtPeso.ReadOnly = False
        txtSPO2.ReadOnly = False
        txtPSys.ReadOnly = False
        txtPDys.ReadOnly = False
        txtMED.ReadOnly = False
        txtTRC.ReadOnly = False
        btnAgregarM.Enabled = True

        ''Detalle Alimentacion
        txtRequerimiento.ReadOnly = False
        txtPVM.ReadOnly = False
        txtRecovery.ReadOnly = False
        txtPolloLic.ReadOnly = False
        txtPolloDesm.ReadOnly = False
        txtNPO.ReadOnly = False
        txtAgua.ReadOnly = False
        btnAgregarA.Enabled = True

        ''Detalle Fluidoterapia
        cbTurnoF.Enabled = True
        txtFluidos.ReadOnly = False
        txtHoraInicio.ReadOnly = False
        txtHoraTermino.ReadOnly = False
        txtCantidad.ReadOnly = False
        btnAgregarF.Enabled = True

        ''Detalle Estudios Complementarios
        txtEstudiosComplem.ReadOnly = False
        btnAgregarEC.Enabled = True

        ''Detalle Tratamiento
        txtTratamiento.ReadOnly = False
        btnAgregarT.Enabled = True
    End Sub

    Private Sub _LimpiarDet()

        'Limpio Examen Físico
        cbTurno.Value = 1
        chbRosadas.Checked = True
        chb0_5.Checked = True
        chbLeve.Checked = True
        chbEstable.Checked = True
        txtHoraEF.Clear()
        dtpFechaEF.Value = Date.Now

        'Limpio Signos Vitales
        txtVomitos.Clear()
        txtDiarreas.Clear()
        txtConvulsiones.Clear()
        txtInfartos.Clear()
        txtMiccion.Clear()
        txtDefecacion.Clear()
        txtOtrosSV.Clear()
        txtHoraSV.Clear()
        dtpFechaSV.Value = Date.Now

        ''Limpio Monitoreo
        txtT.Clear()
        txtFC.Clear()
        txtFR.Clear()
        txtPeso.Clear()
        txtSPO2.Clear()
        txtPSys.Clear()
        txtPDys.Clear()
        txtMED.Clear()
        txtTRC.Clear()
        txtHoraM.Clear()
        dtpFechaM.Value = Date.Now

        ''Limpio Alimentacion
        txtRequerimiento.Clear()
        txtPVM.Clear()
        txtRecovery.Clear()
        txtPolloLic.Clear()
        txtPolloDesm.Clear()
        txtNPO.Clear()
        txtAgua.Clear()
        txtHoraA.Clear()
        dtpFechaA.Value = Date.Now

        ''Detalle Fluidoterapia
        cbTurnoF.Value = 1
        txtFluidos.Clear()
        txtHoraInicio.Clear()
        txtHoraTermino.Clear()
        txtCantidad.Clear()
        txtHoraA.Clear()
        dtpFechaF.Value = Date.Now

        ''Detalle Estudios Complementarios
        txtEstudiosComplem.Clear()
        txtHoraEC.Clear()
        dtpFechaEC.Value = Date.Now

        ''Detalle Tratamiento
        txtTratamiento.Clear()
        txtHoraT.Clear()
        dtpFechaT.Value = Date.Now

    End Sub
    Private Sub _prLimpiar()
        JGSeguimiento.Enabled = True
        txtId.Clear()
        txtIdFicClinica.Clear()
        txtIdFicClinica.Focus()
        txtPropietarioI.Clear()
        txtTelefonoI.Clear()
        txtPacienteI.Clear()
        txtEdadI.Clear()
        txtSexoI.Clear()
        txtEspecieI.Clear()
        dtpFechaSeg.Value = DateTime.Now
        txtMotivoI.Clear()

        If (_Limpiar = False) Then
            _prSeleccionarCombo(cbTurno)
        End If

        _LimpiarDet()

        _prDetalleExamenFisico(-1)


    End Sub
    Public Sub _prFiltrar(tipo As Integer)
        'cargo el buscador
        _prCargarInternacionSeg()
        If JGBusqSeguimiento.RowCount > 0 Then
            _MPos = 0
            _prMostrarInternacionSeg(IIf(tipo = 1, _MPos, JGBusqSeguimiento.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _prSeleccionarCombo(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        If (CType(mCombo.DataSource, DataTable).Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        Else
            mCombo.SelectedIndex = -1
        End If
    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_fnMostrarLibreria(cod1, cod2)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("lbidlib").Width = 70
            .DropDownList.Columns("lbidlib").Caption = "COD"
            .DropDownList.Columns.Add("lbdesc").Width = 200
            .DropDownList.Columns("lbdesc").Caption = "DESCRIPCION"
            .ValueMember = "lbidlib"
            .DisplayMember = "lbdesc"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _prCargarComboTurno(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_DeterminarTurno()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("haIdTurno").Width = 70
            .DropDownList.Columns("haIdTurno").Caption = "COD"
            .DropDownList.Columns.Add("haTurno").Width = 200
            .DropDownList.Columns("haTurno").Caption = "TURNO"
            .ValueMember = "haIdTurno"
            .DisplayMember = "haTurno"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _prGuardarSeguimiento()
        'Dim ihId As Integer
        'Dim res As Boolean = L_fnModificarInternacionSeg(JGBusqSeguimiento.GetValue("ihId"), txtIdFicClinica.Text, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
        '                                              txtDiagnostico.Text, txtResponsable.Text,
        '                                              1, 0, DateTime.Now.Date.ToString("yyyy/MM/dd"), cbTurno.Value, DateTime.Now.ToShortTimeString(),
        '                                              txtObsRequerimientos.Text, txtFrecuencias.Text, txtOtros.Text, txtMedProtocolo.Text, txtAlimentacion.Text, txtPasoTurno.Text)
        'If res Then
        '    Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        '    ToastNotification.Show(Me, "Id del Seguimiento de internacion fue ".ToUpper + ihId.ToString() + " Grabado con Exito.".ToUpper,
        '                              img, 3000,
        '                              eToastGlowColor.Green,
        '                              eToastPosition.TopCenter
        '                              )
        '    _prInhabilitar()
        '    _prFiltrar(2)
        '    _Limpiar = True
        '    NuevoSeg = False

        'Else
        '    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        '    ToastNotification.Show(Me, "El seguimiento no pudo ser Grabado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)

        'End If
    End Sub
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(JGExamenFisico.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGExamenFisico.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGExamenFisico.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Private Sub _prAddDetalleExamenFisico()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Mucosas As String = ""
        Dim Deshidratacion As String = ""
        Dim Dolor As String = ""
        Dim GradoConciencia As String = ""
        _prObtenerMucosas(Mucosas)
        _prObtenerDeshidratacion(Deshidratacion)
        _prObtenerDolor(Dolor)
        _prObtenerGradoConciencia(GradoConciencia)
        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        '_prDetalleExamenFisico(-1)
        If ModificarEF = False Then
            CType(JGExamenFisico.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 1, Date.Now, Hora, cbTurnoEF.Value, cbTurnoEF.Text, Mucosas, Deshidratacion, Dolor, GradoConciencia, Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGExamenFisico.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 1, dtpFechaEF.Value, txtHoraEF.Text, cbTurnoEF.Value, cbTurnoEF.Text, Mucosas, Deshidratacion, Dolor, GradoConciencia, Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
    Private Sub _prObtenerMucosas(ByRef mucosas As String)
        If chbRosadas.Checked = True Then
            mucosas = chbRosadas.Text
        ElseIf chbPalidas.Checked = True Then
            mucosas = chbPalidas.Text
        ElseIf chbIctericas.Checked = True Then
            mucosas = chbIctericas.Text
        ElseIf chbCianoticas.Checked = True Then
            mucosas = chbCianoticas.Text
        End If
    End Sub
    Private Sub _prObtenerDeshidratacion(ByRef deshidratacion As String)
        If chb0_5.Checked = True Then
            deshidratacion = chb0_5.Text
        ElseIf chb5_7.Checked = True Then
            deshidratacion = chb5_7.Text
        ElseIf chb8_10.Checked = True Then
            deshidratacion = chb8_10.Text
        End If
    End Sub
    Private Sub _prObtenerDolor(ByRef dolor As String)
        If chbLeve.Checked = True Then
            dolor = chbLeve.Text
        ElseIf chbModerado.Checked = True Then
            dolor = chbModerado.Text
        ElseIf chbSevero.Checked = True Then
            dolor = chbSevero.Text
        End If
    End Sub
    Private Sub _prObtenerGradoConciencia(ByRef gradoconc As String)
        If chbEstable.Checked = True Then
            gradoconc = chbEstable.Text
        ElseIf chbSemicomatoso.Checked = True Then
            gradoconc = chbSemicomatoso.Text
        ElseIf chbComa.Checked = True Then
            gradoconc = chbComa.Text
        End If
    End Sub
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(JGExamenFisico.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("iiId=MAX(iiId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("iiId")
        End If
        Return 1
    End Function
#End Region
#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim ihId As Integer

        Dim res As Boolean = L_fnGrabarInternacionSeg(ihId, txtIdFicClinica.Text, _IdPaciente, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
                                                      cbTurno.Value, 1, CType(JGExamenFisico.DataSource, DataTable))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Seguimiento de internacion ".ToUpper + ihId.ToString() + " Grabado con Exito.".ToUpper,
                                          img, 3000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
            _Limpiar = True
            NuevoSeg = False
            _prHabilitarMenu(2)
            _prInhabilitar()
            _prFiltrar(2)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El seguimiento no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        Return res

    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim ihId As Integer
        Dim res As Boolean

        res = L_fnModificarInternacionSeg(txtId.Text, txtIdFicClinica.Text, _IdPaciente, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
                                                      cbTurno.Value, 2, CType(JGExamenFisico.DataSource, DataTable))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Seguimiento de internacion fue ".ToUpper + ihId.ToString() + " Modificado con Exito.".ToUpper,
                                          img, 3000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
            _prInhabilitar()
            _prFiltrar(2)
            _Limpiar = True
            NuevoSeg = False
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El seguimiento no pudo ser Modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If

        Return res
    End Function
    ''*****ELIMINAR EL REGISTRO*****''
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
            Dim res As Boolean = L_fnEliminarInternacionSeg(JGBusqSeguimiento.GetValue("ihId"), mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del Seguimiento ".ToUpper + JGBusqSeguimiento.GetValue("ihId").ToString() + " eliminado con Exito.".ToUpper,
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
        If txtIdFicClinica.Text = String.Empty Then
            txtIdFicClinica.BackColor = Color.Red
            MEP.SetError(txtIdFicClinica, "Seleccione una ficha!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Seleccione una ficha para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        Else
            txtIdFicClinica.BackColor = Color.White
            MEP.SetError(txtIdFicClinica, "")
        End If
        'If txtFrecuencias.Text = String.Empty Then
        '    txtFrecuencias.BackColor = Color.Red
        '    MEP.SetError(txtFrecuencias, "Ingrese una frecuencia!".ToUpper)
        '    _ok = False
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "Ingrese una frecuencia para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        'Else
        '    txtFrecuencias.BackColor = Color.White
        '    MEP.SetError(txtFrecuencias, "")
        'End If
        'If txtMedProtocolo.Text = String.Empty Then
        '    txtMedProtocolo.BackColor = Color.Red
        '    MEP.SetError(txtMedProtocolo, "Ingrese una medicación!".ToUpper)
        '    _ok = False
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "Ingrese una medicación para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        'Else
        '    txtMedProtocolo.BackColor = Color.White
        '    MEP.SetError(txtMedProtocolo, "")
        'End If
        If cbTurno.SelectedIndex < 0 Then
            cbTurno.BackColor = Color.Red
            MEP.SetError(cbTurno, "Seleccione un turno!".ToUpper)
            _ok = False
        Else
            cbTurno.BackColor = Color.White
            MEP.SetError(cbTurno, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMOLimpiarErrores()
        MEP.Clear()
        txtIdFicClinica.BackColor = Color.White
        cbTurno.BackColor = Color.White
        ' txtFrecuencias.BackColor = Color.White
        'txtMedProtocolo.BackColor = Color.White
    End Sub

    Private Sub btnFClinica_Click(sender As Object, e As EventArgs) Handles btnFClinica.Click
        Modelo.MGlobal._nameButton = Principal.btnFichaClinica.Name
        If JGBusqSeguimiento.RowCount > 0 Then
            Dim frm As New F1_Fic_FichaClinica
            Dim _fbId As Integer
            'Verificamos si el paciente tiene alguna Ficha CLinica y obtiene su codigo si tiene
            If L_fnMostrarIdFichaClinica(_fbId, JGBusqSeguimiento.GetValue("pbId")) Then
                frm._fbId = _fbId
                frm._Iniciar = 2
            Else
                'Nueva Ficha
                frm._IdPaciente = JGBusqSeguimiento.GetValue("pbId")
                frm._Paciente = JGBusqSeguimiento.GetValue("pbnomb")
                frm._Iniciar = 1
            End If
            frm.Show()
            Me.Refresh()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha de seguimiento se encuentra vacía".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
        End If


    End Sub

    Private Sub btnAgregarEF_Click(sender As Object, e As EventArgs) Handles btnAgregarEF.Click
        If cbTurnoEF.SelectedIndex < 0 Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Debe Seleccionar un turno!".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Exit Sub
        End If
        _prAddDetalleExamenFisico()
    End Sub


    Private Sub JGExamenFisico_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGExamenFisico.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGExamenFisico_SelectionChanged(sender As Object, e As EventArgs) Handles JGExamenFisico.SelectionChanged
        If JGExamenFisico.Row >= 0 And JGExamenFisico.RowCount > 0 Then
            _MPos2 = JGExamenFisico.Row 'Count - 1
            _prMostrarExamenFisico(_MPos2)
        End If
    End Sub

    Private Sub JGExamenFisico_MouseClick(sender As Object, e As MouseEventArgs) Handles JGExamenFisico.MouseClick
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGExamenFisico.RowCount >= 2) Then
            If (JGExamenFisico.CurrentColumn.Index = JGExamenFisico.RootTable.Columns("img").Index) Then
                _prEliminarFilaEF()
            End If
        End If
    End Sub
    Public Function _fnAccesible()
        Return dtpFechaSeg.Enabled = True
    End Function
    Public Sub _prEliminarFilaEF()
        If (JGExamenFisico.Row >= 0) Then
            If (JGExamenFisico.RowCount >= 2) Then
                Dim estado As Integer = JGExamenFisico.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGExamenFisico.GetValue("iiId")
                _fnObtenerFilaDetalle(pos, lin)
                If (estado = 0) Then
                    CType(JGExamenFisico.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGExamenFisico.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGExamenFisico.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGExamenFisico.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGExamenFisico.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGExamenFisico.DataSource, DataTable).Rows(i).Item("iiId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Private Sub txtPVM_TextChanged(sender As Object, e As EventArgs) Handles txtPVM.TextChanged

    End Sub

    Private Sub btnReciboI_Click(sender As Object, e As EventArgs) Handles btnReciboI.Click
        Dim frm As New F1_Fic_ReciboInt
        frm._IdPaciente = JGBusqSeguimiento.GetValue("pbId")
        frm._IdInternacion = JGBusqSeguimiento.GetValue("ihId") 'Id INTERNACION 
        frm.Show()
    End Sub

    Public Overrides Sub _PMONuevo()
        'JGBusqEmpleados.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
    End Sub
    Public Overrides Sub _PMOModificar()
        'JGBusqEmpleados.Enabled = False 'Deshabilita el buscador de la Grilla
        _prHabilitar()

        ModificarEF = True
        _prCargarIconELiminar()

    End Sub

    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class