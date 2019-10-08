<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Cre_PagosCliente
    Inherits Modelo.Modelo1

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Cre_PagosCliente))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.txtIdCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbFechaPago = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNombreCli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.gpBusqRecibos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelBusqRecibos = New System.Windows.Forms.Panel()
        Me.JGVentasCredito = New Janus.Windows.GridEX.GridEX()
        Me.JGDetalleVenta = New Janus.Windows.GridEX.GridEX()
        Me.lbCobrado = New System.Windows.Forms.Label()
        Me.lbSaldo = New System.Windows.Forms.Label()
        Me.tbSaldo = New DevComponents.Editors.DoubleInput()
        Me.tbTotalCobrado = New DevComponents.Editors.DoubleInput()
        Me.tbTotalCobrar = New DevComponents.Editors.DoubleInput()
        Me.lbCobrar = New System.Windows.Forms.Label()
        Me.gpDetalleVenta = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tbFechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBusqRecibos.SuspendLayout()
        Me.panelBusqRecibos.SuspendLayout()
        CType(Me.JGVentasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotalCobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotalCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDetalleVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpBusqRecibos)
        Me.MpanelSuperior.Controls.Add(Me.Panel2)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(940, 486)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(940, 72)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 558)
        Me.PanelInferior.Size = New System.Drawing.Size(940, 39)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(740, 0)
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Location = New System.Drawing.Point(670, 124)
        '
        'superTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.superTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.superTabControl1.ControlBox.MenuBox.Name = ""
        Me.superTabControl1.ControlBox.Name = ""
        Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
        Me.superTabControl1.SelectedTabIndex = 1
        Me.superTabControl1.Size = New System.Drawing.Size(940, 622)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnGenerar)
        Me.Panel2.Controls.Add(Me.txtIdCliente)
        Me.Panel2.Controls.Add(Me.tbFechaPago)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Controls.Add(Me.tbCodigo)
        Me.Panel2.Controls.Add(Me.txtNombreCli)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(934, 166)
        Me.Panel2.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerar.BackColor = System.Drawing.Color.White
        Me.btnGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnGenerar.FadeEffect = False
        Me.btnGenerar.FocusCuesEnabled = False
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnGenerar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGenerar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnGenerar.Location = New System.Drawing.Point(209, 102)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnGenerar.Size = New System.Drawing.Size(164, 41)
        Me.btnGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnGenerar.TabIndex = 263
        Me.btnGenerar.Text = "GENERAR"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdCliente.Border.Class = "TextBoxBorder"
        Me.txtIdCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtIdCliente.Location = New System.Drawing.Point(124, 27)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.PreventEnterBeep = True
        Me.txtIdCliente.Size = New System.Drawing.Size(43, 22)
        Me.txtIdCliente.TabIndex = 244
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbFechaPago
        '
        '
        '
        '
        Me.tbFechaPago.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaPago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaPago.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaPago.ButtonDropDown.Visible = True
        Me.tbFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaPago.IsPopupCalendarOpen = False
        Me.tbFechaPago.Location = New System.Drawing.Point(124, 60)
        '
        '
        '
        '
        '
        '
        Me.tbFechaPago.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaPago.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaPago.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaPago.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaPago.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaPago.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaPago.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaPago.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaPago.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaPago.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaPago.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaPago.Name = "tbFechaPago"
        Me.tbFechaPago.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaPago.TabIndex = 243
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(20, 63)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX4.Size = New System.Drawing.Size(95, 16)
        Me.LabelX4.TabIndex = 241
        Me.LabelX4.Text = "Fecha de Pago:"
        '
        'tbCodigo
        '
        Me.tbCodigo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbCodigo.Border.Class = "TextBoxBorder"
        Me.tbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigo.DisabledBackColor = System.Drawing.Color.White
        Me.tbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigo.Location = New System.Drawing.Point(9, 92)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.PreventEnterBeep = True
        Me.tbCodigo.Size = New System.Drawing.Size(43, 22)
        Me.tbCodigo.TabIndex = 240
        Me.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCodigo.Visible = False
        '
        'txtNombreCli
        '
        Me.txtNombreCli.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreCli.Border.Class = "TextBoxBorder"
        Me.txtNombreCli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreCli.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombreCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNombreCli.Location = New System.Drawing.Point(173, 27)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.PreventEnterBeep = True
        Me.txtNombreCli.Size = New System.Drawing.Size(249, 22)
        Me.txtNombreCli.TabIndex = 238
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(20, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(51, 16)
        Me.LabelX2.TabIndex = 239
        Me.LabelX2.Text = "Cliente:"
        '
        'gpBusqRecibos
        '
        Me.gpBusqRecibos.BackColor = System.Drawing.Color.White
        Me.gpBusqRecibos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBusqRecibos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBusqRecibos.Controls.Add(Me.tbTotalCobrar)
        Me.gpBusqRecibos.Controls.Add(Me.tbSaldo)
        Me.gpBusqRecibos.Controls.Add(Me.lbCobrar)
        Me.gpBusqRecibos.Controls.Add(Me.tbTotalCobrado)
        Me.gpBusqRecibos.Controls.Add(Me.lbCobrado)
        Me.gpBusqRecibos.Controls.Add(Me.lbSaldo)
        Me.gpBusqRecibos.Controls.Add(Me.panelBusqRecibos)
        Me.gpBusqRecibos.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpBusqRecibos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqRecibos.Location = New System.Drawing.Point(3, 169)
        Me.gpBusqRecibos.Name = "gpBusqRecibos"
        Me.gpBusqRecibos.Size = New System.Drawing.Size(934, 314)
        '
        '
        '
        Me.gpBusqRecibos.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqRecibos.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqRecibos.Style.BackColorGradientAngle = 90
        Me.gpBusqRecibos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderBottomWidth = 1
        Me.gpBusqRecibos.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpBusqRecibos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderLeftWidth = 1
        Me.gpBusqRecibos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderRightWidth = 1
        Me.gpBusqRecibos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBusqRecibos.Style.BorderTopWidth = 1
        Me.gpBusqRecibos.Style.CornerDiameter = 4
        Me.gpBusqRecibos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBusqRecibos.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBusqRecibos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBusqRecibos.Style.TextColor = System.Drawing.Color.White
        Me.gpBusqRecibos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpBusqRecibos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpBusqRecibos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpBusqRecibos.TabIndex = 6
        Me.gpBusqRecibos.Text = "DETALLE   VENTAS   A   CRÉDITO"
        '
        'panelBusqRecibos
        '
        Me.panelBusqRecibos.BackColor = System.Drawing.Color.White
        Me.panelBusqRecibos.Controls.Add(Me.gpDetalleVenta)
        Me.panelBusqRecibos.Controls.Add(Me.JGVentasCredito)
        Me.panelBusqRecibos.Location = New System.Drawing.Point(4, -1)
        Me.panelBusqRecibos.Name = "panelBusqRecibos"
        Me.panelBusqRecibos.Size = New System.Drawing.Size(921, 209)
        Me.panelBusqRecibos.TabIndex = 0
        '
        'JGVentasCredito
        '
        Me.JGVentasCredito.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGVentasCredito.BackColor = System.Drawing.Color.GhostWhite
        Me.JGVentasCredito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGVentasCredito.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGVentasCredito.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGVentasCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGVentasCredito.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.JGVentasCredito.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGVentasCredito.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGVentasCredito.Location = New System.Drawing.Point(0, 0)
        Me.JGVentasCredito.Name = "JGVentasCredito"
        Me.JGVentasCredito.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGVentasCredito.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGVentasCredito.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGVentasCredito.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGVentasCredito.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGVentasCredito.SelectOnExpand = False
        Me.JGVentasCredito.Size = New System.Drawing.Size(921, 209)
        Me.JGVentasCredito.TabIndex = 0
        Me.JGVentasCredito.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'JGDetalleVenta
        '
        Me.JGDetalleVenta.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGDetalleVenta.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.JGDetalleVenta.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.JGDetalleVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGDetalleVenta.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.JGDetalleVenta.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGDetalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.JGDetalleVenta.Name = "JGDetalleVenta"
        Me.JGDetalleVenta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGDetalleVenta.Office2007CustomColor = System.Drawing.Color.RoyalBlue
        Me.JGDetalleVenta.SelectOnExpand = False
        Me.JGDetalleVenta.Size = New System.Drawing.Size(908, 149)
        Me.JGDetalleVenta.TabIndex = 1
        Me.JGDetalleVenta.Tag = ""
        Me.JGDetalleVenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbCobrado
        '
        Me.lbCobrado.AutoSize = True
        Me.lbCobrado.BackColor = System.Drawing.Color.Transparent
        Me.lbCobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCobrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbCobrado.Location = New System.Drawing.Point(702, 241)
        Me.lbCobrado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCobrado.Name = "lbCobrado"
        Me.lbCobrado.Size = New System.Drawing.Size(106, 13)
        Me.lbCobrado.TabIndex = 7
        Me.lbCobrado.Text = "Total a Cobrado :"
        '
        'lbSaldo
        '
        Me.lbSaldo.AutoSize = True
        Me.lbSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbSaldo.Location = New System.Drawing.Point(761, 266)
        Me.lbSaldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(47, 13)
        Me.lbSaldo.TabIndex = 8
        Me.lbSaldo.Text = "Saldo :"
        '
        'tbSaldo
        '
        '
        '
        '
        Me.tbSaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaldo.Increment = 1.0R
        Me.tbSaldo.Location = New System.Drawing.Point(812, 262)
        Me.tbSaldo.LockUpdateChecked = False
        Me.tbSaldo.MinValue = 0R
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.Size = New System.Drawing.Size(104, 21)
        Me.tbSaldo.TabIndex = 11
        Me.tbSaldo.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'tbTotalCobrado
        '
        '
        '
        '
        Me.tbTotalCobrado.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTotalCobrado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotalCobrado.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTotalCobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalCobrado.Increment = 1.0R
        Me.tbTotalCobrado.Location = New System.Drawing.Point(812, 238)
        Me.tbTotalCobrado.LockUpdateChecked = False
        Me.tbTotalCobrado.MinValue = 0R
        Me.tbTotalCobrado.Name = "tbTotalCobrado"
        Me.tbTotalCobrado.Size = New System.Drawing.Size(104, 21)
        Me.tbTotalCobrado.TabIndex = 10
        Me.tbTotalCobrado.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'tbTotalCobrar
        '
        '
        '
        '
        Me.tbTotalCobrar.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTotalCobrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotalCobrar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTotalCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalCobrar.Increment = 1.0R
        Me.tbTotalCobrar.Location = New System.Drawing.Point(812, 214)
        Me.tbTotalCobrar.LockUpdateChecked = False
        Me.tbTotalCobrar.MinValue = 0R
        Me.tbTotalCobrar.Name = "tbTotalCobrar"
        Me.tbTotalCobrar.Size = New System.Drawing.Size(104, 21)
        Me.tbTotalCobrar.TabIndex = 9
        Me.tbTotalCobrar.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'lbCobrar
        '
        Me.lbCobrar.AutoSize = True
        Me.lbCobrar.BackColor = System.Drawing.Color.Transparent
        Me.lbCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbCobrar.Location = New System.Drawing.Point(712, 217)
        Me.lbCobrar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCobrar.Name = "lbCobrar"
        Me.lbCobrar.Size = New System.Drawing.Size(96, 13)
        Me.lbCobrar.TabIndex = 6
        Me.lbCobrar.Text = "Total a Cobrar :"
        '
        'gpDetalleVenta
        '
        Me.gpDetalleVenta.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDetalleVenta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDetalleVenta.Controls.Add(Me.JGDetalleVenta)
        Me.gpDetalleVenta.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDetalleVenta.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleVenta.Location = New System.Drawing.Point(4, 34)
        Me.gpDetalleVenta.Name = "gpDetalleVenta"
        Me.gpDetalleVenta.Size = New System.Drawing.Size(914, 172)
        '
        '
        '
        Me.gpDetalleVenta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDetalleVenta.Style.BackColorGradientAngle = 90
        Me.gpDetalleVenta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDetalleVenta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderBottomWidth = 1
        Me.gpDetalleVenta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDetalleVenta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderLeftWidth = 1
        Me.gpDetalleVenta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderRightWidth = 1
        Me.gpDetalleVenta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderTopWidth = 1
        Me.gpDetalleVenta.Style.CornerDiameter = 4
        Me.gpDetalleVenta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDetalleVenta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDetalleVenta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDetalleVenta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDetalleVenta.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDetalleVenta.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDetalleVenta.TabIndex = 2
        Me.gpDetalleVenta.Text = "DETALLE DE VENTA"
        '
        'F1_Cre_PagosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 622)
        Me.MaximizeBox = False
        Me.Name = "F1_Cre_PagosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGOS  POR  CLIENTE"
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tbFechaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBusqRecibos.ResumeLayout(False)
        Me.gpBusqRecibos.PerformLayout()
        Me.panelBusqRecibos.ResumeLayout(False)
        CType(Me.JGVentasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotalCobrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotalCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDetalleVenta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtIdCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNombreCli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpBusqRecibos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelBusqRecibos As Panel
    Friend WithEvents JGVentasCredito As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbFechaPago As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents JGDetalleVenta As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbTotalCobrar As DevComponents.Editors.DoubleInput
    Friend WithEvents tbSaldo As DevComponents.Editors.DoubleInput
    Friend WithEvents lbCobrar As Label
    Friend WithEvents tbTotalCobrado As DevComponents.Editors.DoubleInput
    Friend WithEvents lbCobrado As Label
    Friend WithEvents lbSaldo As Label
    Friend WithEvents gpDetalleVenta As DevComponents.DotNetBar.Controls.GroupPanel
End Class
