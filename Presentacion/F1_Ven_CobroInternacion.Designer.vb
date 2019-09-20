<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Ven_CobroInternacion
    Inherits Modelo.Modelo1

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Ven_CobroInternacion))
        Me.PanelContentSup = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFCredito = New System.Windows.Forms.DateTimePicker()
        Me.dtpFVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtIdReciboV = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbIdRecibo = New DevComponents.DotNetBar.LabelX()
        Me.swTipoVenta = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.txtIdVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdVenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbVencCredito = New DevComponents.DotNetBar.LabelX()
        Me.lbTipoVenta = New DevComponents.DotNetBar.LabelX()
        Me.lbFVenta = New DevComponents.DotNetBar.LabelX()
        Me.lbIdVenta = New DevComponents.DotNetBar.LabelX()
        Me.txtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbVendedor = New DevComponents.DotNetBar.LabelX()
        Me.lbObservacion = New DevComponents.DotNetBar.LabelX()
        Me.txtCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbCliente = New DevComponents.DotNetBar.LabelX()
        Me.txtIdPaciente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPaciente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lbCtrlEnter = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelDetalle = New System.Windows.Forms.Panel()
        Me.gpDetalleVenta = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.JGdetalleVenta = New Janus.Windows.GridEX.GridEX()
        Me.panelResultados = New System.Windows.Forms.Panel()
        Me.txtMontoPagado = New DevComponents.Editors.DoubleInput()
        Me.txtSubTotal = New DevComponents.Editors.DoubleInput()
        Me.lbCambio = New DevComponents.DotNetBar.LabelX()
        Me.lbMontoPagado = New DevComponents.DotNetBar.LabelX()
        Me.lbSubTotal = New DevComponents.DotNetBar.LabelX()
        Me.txtCambio = New DevComponents.Editors.DoubleInput()
        Me.lbMdesc = New DevComponents.DotNetBar.LabelX()
        Me.lbTotalNeto = New DevComponents.DotNetBar.LabelX()
        Me.lbAcuenta = New DevComponents.DotNetBar.LabelX()
        Me.lbSaldo = New DevComponents.DotNetBar.LabelX()
        Me.txtMdesc = New DevComponents.Editors.DoubleInput()
        Me.txtTotalNeto = New DevComponents.Editors.DoubleInput()
        Me.txtAcuenta = New DevComponents.Editors.DoubleInput()
        Me.txtSaldo = New DevComponents.Editors.DoubleInput()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelContentSup.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelDetalle.SuspendLayout()
        Me.gpDetalleVenta.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.JGdetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelResultados.SuspendLayout()
        CType(Me.txtMontoPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.PanelDetalle)
        Me.MpanelSuperior.Controls.Add(Me.PanelContentSup)
        Me.MpanelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MpanelSuperior.Location = New System.Drawing.Point(0, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(993, 534)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(993, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 606)
        Me.PanelInferior.Size = New System.Drawing.Size(993, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(793, 0)
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.Size = New System.Drawing.Size(993, 574)
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Text = "DEFAULT"
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
        Me.superTabControl1.Size = New System.Drawing.Size(993, 670)
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
        Me.PanelUsuario.Location = New System.Drawing.Point(759, 109)
        '
        'PanelContentSup
        '
        Me.PanelContentSup.BackColor = System.Drawing.Color.White
        Me.PanelContentSup.Controls.Add(Me.GroupPanel1)
        Me.PanelContentSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelContentSup.Location = New System.Drawing.Point(0, 0)
        Me.PanelContentSup.Name = "PanelContentSup"
        Me.PanelContentSup.Size = New System.Drawing.Size(993, 197)
        Me.PanelContentSup.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(993, 197)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 228
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.lbCtrlEnter)
        Me.Panel2.Controls.Add(Me.txtIdPaciente)
        Me.Panel2.Controls.Add(Me.txtPaciente)
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Controls.Add(Me.dtpFCredito)
        Me.Panel2.Controls.Add(Me.dtpFVenta)
        Me.Panel2.Controls.Add(Me.txtIdReciboV)
        Me.Panel2.Controls.Add(Me.lbIdRecibo)
        Me.Panel2.Controls.Add(Me.swTipoVenta)
        Me.Panel2.Controls.Add(Me.txtIdVendedor)
        Me.Panel2.Controls.Add(Me.txtIdCliente)
        Me.Panel2.Controls.Add(Me.txtVendedor)
        Me.Panel2.Controls.Add(Me.txtIdVenta)
        Me.Panel2.Controls.Add(Me.lbVencCredito)
        Me.Panel2.Controls.Add(Me.lbTipoVenta)
        Me.Panel2.Controls.Add(Me.lbFVenta)
        Me.Panel2.Controls.Add(Me.lbIdVenta)
        Me.Panel2.Controls.Add(Me.txtObservacion)
        Me.Panel2.Controls.Add(Me.lbVendedor)
        Me.Panel2.Controls.Add(Me.lbObservacion)
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.lbCliente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 174)
        Me.Panel2.TabIndex = 234
        '
        'dtpFCredito
        '
        Me.dtpFCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFCredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFCredito.Location = New System.Drawing.Point(603, 66)
        Me.dtpFCredito.Name = "dtpFCredito"
        Me.dtpFCredito.Size = New System.Drawing.Size(122, 22)
        Me.dtpFCredito.TabIndex = 262
        Me.dtpFCredito.TabStop = False
        Me.dtpFCredito.Visible = False
        '
        'dtpFVenta
        '
        Me.dtpFVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFVenta.Location = New System.Drawing.Point(603, 9)
        Me.dtpFVenta.Name = "dtpFVenta"
        Me.dtpFVenta.Size = New System.Drawing.Size(122, 22)
        Me.dtpFVenta.TabIndex = 261
        Me.dtpFVenta.TabStop = False
        '
        'txtIdReciboV
        '
        Me.txtIdReciboV.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdReciboV.Border.Class = "TextBoxBorder"
        Me.txtIdReciboV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdReciboV.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdReciboV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReciboV.ForeColor = System.Drawing.Color.Black
        Me.txtIdReciboV.Location = New System.Drawing.Point(108, 38)
        Me.txtIdReciboV.Name = "txtIdReciboV"
        Me.txtIdReciboV.PreventEnterBeep = True
        Me.txtIdReciboV.Size = New System.Drawing.Size(58, 22)
        Me.txtIdReciboV.TabIndex = 20
        Me.txtIdReciboV.TabStop = False
        Me.txtIdReciboV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbIdRecibo
        '
        Me.lbIdRecibo.AutoSize = True
        Me.lbIdRecibo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdRecibo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdRecibo.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdRecibo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdRecibo.Location = New System.Drawing.Point(13, 42)
        Me.lbIdRecibo.Name = "lbIdRecibo"
        Me.lbIdRecibo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdRecibo.Size = New System.Drawing.Size(66, 16)
        Me.lbIdRecibo.TabIndex = 247
        Me.lbIdRecibo.Text = "Id Recibo:"
        '
        'swTipoVenta
        '
        '
        '
        '
        Me.swTipoVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swTipoVenta.Location = New System.Drawing.Point(603, 37)
        Me.swTipoVenta.Name = "swTipoVenta"
        Me.swTipoVenta.OffBackColor = System.Drawing.Color.Gold
        Me.swTipoVenta.OffText = "CREDITO"
        Me.swTipoVenta.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swTipoVenta.OnText = "CONTADO"
        Me.swTipoVenta.OnTextColor = System.Drawing.Color.Black
        Me.swTipoVenta.Size = New System.Drawing.Size(122, 22)
        Me.swTipoVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swTipoVenta.SwitchBackColor = System.Drawing.Color.Gray
        Me.swTipoVenta.TabIndex = 246
        Me.swTipoVenta.Value = True
        Me.swTipoVenta.ValueObject = "Y"
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdVendedor.Border.Class = "TextBoxBorder"
        Me.txtIdVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdVendedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVendedor.ForeColor = System.Drawing.Color.Black
        Me.txtIdVendedor.Location = New System.Drawing.Point(108, 133)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.PreventEnterBeep = True
        Me.txtIdVendedor.Size = New System.Drawing.Size(58, 22)
        Me.txtIdVendedor.TabIndex = 21
        Me.txtIdVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtIdCliente.ForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.Location = New System.Drawing.Point(108, 66)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.PreventEnterBeep = True
        Me.txtIdCliente.Size = New System.Drawing.Size(58, 22)
        Me.txtIdCliente.TabIndex = 1
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtVendedor.Border.Class = "TextBoxBorder"
        Me.txtVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVendedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.ForeColor = System.Drawing.Color.Black
        Me.txtVendedor.Location = New System.Drawing.Point(172, 133)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.PreventEnterBeep = True
        Me.txtVendedor.Size = New System.Drawing.Size(235, 22)
        Me.txtVendedor.TabIndex = 243
        '
        'txtIdVenta
        '
        Me.txtIdVenta.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtIdVenta.Border.Class = "TextBoxBorder"
        Me.txtIdVenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVenta.ForeColor = System.Drawing.Color.Black
        Me.txtIdVenta.Location = New System.Drawing.Point(108, 10)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.PreventEnterBeep = True
        Me.txtIdVenta.Size = New System.Drawing.Size(58, 22)
        Me.txtIdVenta.TabIndex = 242
        Me.txtIdVenta.TabStop = False
        '
        'lbVencCredito
        '
        Me.lbVencCredito.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbVencCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbVencCredito.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVencCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbVencCredito.Location = New System.Drawing.Point(488, 66)
        Me.lbVencCredito.Name = "lbVencCredito"
        Me.lbVencCredito.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbVencCredito.Size = New System.Drawing.Size(109, 23)
        Me.lbVencCredito.TabIndex = 233
        Me.lbVencCredito.Text = "Venc. de Crédito:"
        Me.lbVencCredito.Visible = False
        '
        'lbTipoVenta
        '
        Me.lbTipoVenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTipoVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTipoVenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTipoVenta.Location = New System.Drawing.Point(488, 37)
        Me.lbTipoVenta.Name = "lbTipoVenta"
        Me.lbTipoVenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTipoVenta.Size = New System.Drawing.Size(85, 23)
        Me.lbTipoVenta.TabIndex = 232
        Me.lbTipoVenta.Text = "Tipo Venta:"
        '
        'lbFVenta
        '
        Me.lbFVenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFVenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFVenta.Location = New System.Drawing.Point(488, 9)
        Me.lbFVenta.Name = "lbFVenta"
        Me.lbFVenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFVenta.Size = New System.Drawing.Size(88, 23)
        Me.lbFVenta.TabIndex = 231
        Me.lbFVenta.Text = "Fecha Venta:"
        '
        'lbIdVenta
        '
        Me.lbIdVenta.AutoSize = True
        Me.lbIdVenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdVenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdVenta.Location = New System.Drawing.Point(13, 13)
        Me.lbIdVenta.Name = "lbIdVenta"
        Me.lbIdVenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdVenta.Size = New System.Drawing.Size(61, 16)
        Me.lbIdVenta.TabIndex = 224
        Me.lbIdVenta.Text = "Id Cobro:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtObservacion.Border.Class = "TextBoxBorder"
        Me.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtObservacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.Black
        Me.txtObservacion.Location = New System.Drawing.Point(603, 97)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PreventEnterBeep = True
        Me.txtObservacion.Size = New System.Drawing.Size(292, 47)
        Me.txtObservacion.TabIndex = 22
        '
        'lbVendedor
        '
        Me.lbVendedor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbVendedor.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVendedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbVendedor.Location = New System.Drawing.Point(13, 133)
        Me.lbVendedor.Name = "lbVendedor"
        Me.lbVendedor.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbVendedor.Size = New System.Drawing.Size(70, 23)
        Me.lbVendedor.TabIndex = 227
        Me.lbVendedor.Text = "Vendedor:"
        '
        'lbObservacion
        '
        Me.lbObservacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbObservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbObservacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbObservacion.Location = New System.Drawing.Point(488, 92)
        Me.lbObservacion.Name = "lbObservacion"
        Me.lbObservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbObservacion.Size = New System.Drawing.Size(92, 23)
        Me.lbObservacion.TabIndex = 226
        Me.lbObservacion.Text = "Observacion:"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCliente.Border.Class = "TextBoxBorder"
        Me.txtCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Black
        Me.txtCliente.Location = New System.Drawing.Point(172, 66)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PreventEnterBeep = True
        Me.txtCliente.Size = New System.Drawing.Size(235, 22)
        Me.txtCliente.TabIndex = 1
        '
        'lbCliente
        '
        Me.lbCliente.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCliente.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCliente.Location = New System.Drawing.Point(12, 65)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCliente.Size = New System.Drawing.Size(67, 23)
        Me.lbCliente.TabIndex = 225
        Me.lbCliente.Text = "Cliente:"
        '
        'txtIdPaciente
        '
        Me.txtIdPaciente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdPaciente.Border.Class = "TextBoxBorder"
        Me.txtIdPaciente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdPaciente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPaciente.ForeColor = System.Drawing.Color.Black
        Me.txtIdPaciente.Location = New System.Drawing.Point(108, 93)
        Me.txtIdPaciente.Name = "txtIdPaciente"
        Me.txtIdPaciente.PreventEnterBeep = True
        Me.txtIdPaciente.Size = New System.Drawing.Size(58, 22)
        Me.txtIdPaciente.TabIndex = 263
        Me.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaciente
        '
        Me.txtPaciente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPaciente.Border.Class = "TextBoxBorder"
        Me.txtPaciente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPaciente.DisabledBackColor = System.Drawing.Color.White
        Me.txtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaciente.ForeColor = System.Drawing.Color.Black
        Me.txtPaciente.Location = New System.Drawing.Point(172, 93)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.PreventEnterBeep = True
        Me.txtPaciente.Size = New System.Drawing.Size(235, 22)
        Me.txtPaciente.TabIndex = 264
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(12, 92)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(67, 23)
        Me.LabelX1.TabIndex = 265
        Me.LabelX1.Text = "Paciente:"
        '
        'lbCtrlEnter
        '
        Me.lbCtrlEnter.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCtrlEnter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCtrlEnter.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCtrlEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCtrlEnter.Location = New System.Drawing.Point(172, 43)
        Me.lbCtrlEnter.Name = "lbCtrlEnter"
        Me.lbCtrlEnter.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCtrlEnter.Size = New System.Drawing.Size(68, 15)
        Me.lbCtrlEnter.TabIndex = 353
        Me.lbCtrlEnter.Text = "Ctrl+Enter"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(108, 118)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(70, 11)
        Me.LabelX2.TabIndex = 354
        Me.LabelX2.Text = "Ctrl+Enter"
        '
        'PanelDetalle
        '
        Me.PanelDetalle.BackColor = System.Drawing.Color.White
        Me.PanelDetalle.Controls.Add(Me.gpDetalleVenta)
        Me.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetalle.Location = New System.Drawing.Point(0, 197)
        Me.PanelDetalle.Name = "PanelDetalle"
        Me.PanelDetalle.Size = New System.Drawing.Size(993, 337)
        Me.PanelDetalle.TabIndex = 3
        '
        'gpDetalleVenta
        '
        Me.gpDetalleVenta.BackColor = System.Drawing.Color.White
        Me.gpDetalleVenta.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDetalleVenta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDetalleVenta.Controls.Add(Me.Panel5)
        Me.gpDetalleVenta.Controls.Add(Me.panelResultados)
        Me.gpDetalleVenta.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDetalleVenta.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.gpDetalleVenta.Name = "gpDetalleVenta"
        Me.gpDetalleVenta.Size = New System.Drawing.Size(993, 337)
        '
        '
        '
        Me.gpDetalleVenta.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleVenta.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleVenta.Style.BackColorGradientAngle = 90
        Me.gpDetalleVenta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderBottomWidth = 1
        Me.gpDetalleVenta.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpDetalleVenta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderLeftWidth = 1
        Me.gpDetalleVenta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderRightWidth = 1
        Me.gpDetalleVenta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDetalleVenta.Style.BorderTopWidth = 1
        Me.gpDetalleVenta.Style.CornerDiameter = 4
        Me.gpDetalleVenta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDetalleVenta.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDetalleVenta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDetalleVenta.Style.TextColor = System.Drawing.Color.White
        Me.gpDetalleVenta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDetalleVenta.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDetalleVenta.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDetalleVenta.TabIndex = 1
        Me.gpDetalleVenta.Text = "DETALLE DE LA VENTA"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.JGdetalleVenta)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(755, 314)
        Me.Panel5.TabIndex = 0
        '
        'JGdetalleVenta
        '
        Me.JGdetalleVenta.BackColor = System.Drawing.Color.GhostWhite
        Me.JGdetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGdetalleVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.JGdetalleVenta.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.JGdetalleVenta.Location = New System.Drawing.Point(0, 0)
        Me.JGdetalleVenta.Name = "JGdetalleVenta"
        Me.JGdetalleVenta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGdetalleVenta.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGdetalleVenta.Size = New System.Drawing.Size(755, 314)
        Me.JGdetalleVenta.TabIndex = 0
        Me.JGdetalleVenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'panelResultados
        '
        Me.panelResultados.BackColor = System.Drawing.Color.Transparent
        Me.panelResultados.Controls.Add(Me.txtCambio)
        Me.panelResultados.Controls.Add(Me.txtMontoPagado)
        Me.panelResultados.Controls.Add(Me.txtSaldo)
        Me.panelResultados.Controls.Add(Me.txtAcuenta)
        Me.panelResultados.Controls.Add(Me.txtTotalNeto)
        Me.panelResultados.Controls.Add(Me.txtMdesc)
        Me.panelResultados.Controls.Add(Me.txtSubTotal)
        Me.panelResultados.Controls.Add(Me.lbCambio)
        Me.panelResultados.Controls.Add(Me.lbMontoPagado)
        Me.panelResultados.Controls.Add(Me.lbSaldo)
        Me.panelResultados.Controls.Add(Me.lbAcuenta)
        Me.panelResultados.Controls.Add(Me.lbSubTotal)
        Me.panelResultados.Controls.Add(Me.lbTotalNeto)
        Me.panelResultados.Controls.Add(Me.lbMdesc)
        Me.panelResultados.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelResultados.Location = New System.Drawing.Point(755, 0)
        Me.panelResultados.Name = "panelResultados"
        Me.panelResultados.Size = New System.Drawing.Size(232, 314)
        Me.panelResultados.TabIndex = 39
        '
        'txtMontoPagado
        '
        '
        '
        '
        Me.txtMontoPagado.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtMontoPagado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMontoPagado.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtMontoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagado.Increment = 1.0R
        Me.txtMontoPagado.Location = New System.Drawing.Point(127, 223)
        Me.txtMontoPagado.LockUpdateChecked = False
        Me.txtMontoPagado.MinValue = 0R
        Me.txtMontoPagado.Name = "txtMontoPagado"
        Me.txtMontoPagado.Size = New System.Drawing.Size(89, 21)
        Me.txtMontoPagado.TabIndex = 56
        Me.txtMontoPagado.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtSubTotal
        '
        '
        '
        '
        Me.txtSubTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSubTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSubTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Increment = 1.0R
        Me.txtSubTotal.Location = New System.Drawing.Point(127, 13)
        Me.txtSubTotal.LockUpdateChecked = False
        Me.txtSubTotal.MinValue = 0R
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(89, 21)
        Me.txtSubTotal.TabIndex = 51
        Me.txtSubTotal.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'lbCambio
        '
        Me.lbCambio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCambio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCambio.ForeColor = System.Drawing.Color.White
        Me.lbCambio.Location = New System.Drawing.Point(20, 251)
        Me.lbCambio.Name = "lbCambio"
        Me.lbCambio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCambio.Size = New System.Drawing.Size(65, 18)
        Me.lbCambio.TabIndex = 50
        Me.lbCambio.Text = "Cambio:"
        '
        'lbMontoPagado
        '
        Me.lbMontoPagado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMontoPagado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMontoPagado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoPagado.ForeColor = System.Drawing.Color.White
        Me.lbMontoPagado.Location = New System.Drawing.Point(20, 227)
        Me.lbMontoPagado.Name = "lbMontoPagado"
        Me.lbMontoPagado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMontoPagado.Size = New System.Drawing.Size(101, 18)
        Me.lbMontoPagado.TabIndex = 48
        Me.lbMontoPagado.Text = "Monto Pagado:"
        '
        'lbSubTotal
        '
        Me.lbSubTotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSubTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSubTotal.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubTotal.ForeColor = System.Drawing.Color.White
        Me.lbSubTotal.Location = New System.Drawing.Point(20, 18)
        Me.lbSubTotal.Name = "lbSubTotal"
        Me.lbSubTotal.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSubTotal.Size = New System.Drawing.Size(86, 18)
        Me.lbSubTotal.TabIndex = 42
        Me.lbSubTotal.Text = "Sub Total:"
        '
        'txtCambio
        '
        '
        '
        '
        Me.txtCambio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCambio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio.Increment = 1.0R
        Me.txtCambio.Location = New System.Drawing.Point(127, 251)
        Me.txtCambio.LockUpdateChecked = False
        Me.txtCambio.MinValue = 0R
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(89, 21)
        Me.txtCambio.TabIndex = 57
        Me.txtCambio.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'lbMdesc
        '
        Me.lbMdesc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMdesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMdesc.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMdesc.ForeColor = System.Drawing.Color.White
        Me.lbMdesc.Location = New System.Drawing.Point(21, 48)
        Me.lbMdesc.Name = "lbMdesc"
        Me.lbMdesc.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMdesc.Size = New System.Drawing.Size(101, 18)
        Me.lbMdesc.TabIndex = 36
        Me.lbMdesc.Text = "M. Descuento:"
        '
        'lbTotalNeto
        '
        Me.lbTotalNeto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTotalNeto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTotalNeto.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalNeto.ForeColor = System.Drawing.Color.White
        Me.lbTotalNeto.Location = New System.Drawing.Point(21, 75)
        Me.lbTotalNeto.Name = "lbTotalNeto"
        Me.lbTotalNeto.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTotalNeto.Size = New System.Drawing.Size(75, 18)
        Me.lbTotalNeto.TabIndex = 38
        Me.lbTotalNeto.Text = "Total Neto:"
        '
        'lbAcuenta
        '
        Me.lbAcuenta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbAcuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbAcuenta.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAcuenta.ForeColor = System.Drawing.Color.White
        Me.lbAcuenta.Location = New System.Drawing.Point(21, 106)
        Me.lbAcuenta.Name = "lbAcuenta"
        Me.lbAcuenta.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbAcuenta.Size = New System.Drawing.Size(75, 18)
        Me.lbAcuenta.TabIndex = 44
        Me.lbAcuenta.Text = "A cuenta:"
        '
        'lbSaldo
        '
        Me.lbSaldo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSaldo.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldo.ForeColor = System.Drawing.Color.White
        Me.lbSaldo.Location = New System.Drawing.Point(21, 134)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSaldo.Size = New System.Drawing.Size(75, 18)
        Me.lbSaldo.TabIndex = 46
        Me.lbSaldo.Text = "Saldo:"
        '
        'txtMdesc
        '
        '
        '
        '
        Me.txtMdesc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtMdesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMdesc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtMdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdesc.Increment = 1.0R
        Me.txtMdesc.Location = New System.Drawing.Point(127, 44)
        Me.txtMdesc.LockUpdateChecked = False
        Me.txtMdesc.MinValue = 0R
        Me.txtMdesc.Name = "txtMdesc"
        Me.txtMdesc.Size = New System.Drawing.Size(89, 21)
        Me.txtMdesc.TabIndex = 52
        Me.txtMdesc.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtTotalNeto
        '
        '
        '
        '
        Me.txtTotalNeto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTotalNeto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalNeto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTotalNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNeto.Increment = 1.0R
        Me.txtTotalNeto.Location = New System.Drawing.Point(127, 72)
        Me.txtTotalNeto.LockUpdateChecked = False
        Me.txtTotalNeto.MinValue = 0R
        Me.txtTotalNeto.Name = "txtTotalNeto"
        Me.txtTotalNeto.Size = New System.Drawing.Size(89, 21)
        Me.txtTotalNeto.TabIndex = 53
        Me.txtTotalNeto.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtAcuenta
        '
        '
        '
        '
        Me.txtAcuenta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAcuenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAcuenta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcuenta.Increment = 1.0R
        Me.txtAcuenta.Location = New System.Drawing.Point(127, 102)
        Me.txtAcuenta.LockUpdateChecked = False
        Me.txtAcuenta.MinValue = 0R
        Me.txtAcuenta.Name = "txtAcuenta"
        Me.txtAcuenta.Size = New System.Drawing.Size(89, 21)
        Me.txtAcuenta.TabIndex = 54
        Me.txtAcuenta.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'txtSaldo
        '
        '
        '
        '
        Me.txtSaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Increment = 1.0R
        Me.txtSaldo.Location = New System.Drawing.Point(127, 132)
        Me.txtSaldo.LockUpdateChecked = False
        Me.txtSaldo.MinValue = 0R
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(89, 21)
        Me.txtSaldo.TabIndex = 55
        Me.txtSaldo.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'F1_Ven_CobroInternacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 670)
        Me.Name = "F1_Ven_CobroInternacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COBRO INTERNACIÓN"
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelContentSup.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelDetalle.ResumeLayout(False)
        Me.gpDetalleVenta.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.JGdetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelResultados.ResumeLayout(False)
        CType(Me.txtMontoPagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContentSup As Panel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFCredito As DateTimePicker
    Friend WithEvents dtpFVenta As DateTimePicker
    Friend WithEvents txtIdReciboV As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbIdRecibo As DevComponents.DotNetBar.LabelX
    Friend WithEvents swTipoVenta As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents txtIdVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdVenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbVencCredito As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbTipoVenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbFVenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbIdVenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbVendedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbCliente As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdPaciente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPaciente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCtrlEnter As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelDetalle As Panel
    Friend WithEvents gpDetalleVenta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents JGdetalleVenta As Janus.Windows.GridEX.GridEX
    Friend WithEvents panelResultados As Panel
    Friend WithEvents txtMontoPagado As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSubTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents lbCambio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMontoPagado As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbSubTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCambio As DevComponents.Editors.DoubleInput
    Friend WithEvents txtSaldo As DevComponents.Editors.DoubleInput
    Friend WithEvents txtAcuenta As DevComponents.Editors.DoubleInput
    Friend WithEvents txtTotalNeto As DevComponents.Editors.DoubleInput
    Friend WithEvents txtMdesc As DevComponents.Editors.DoubleInput
    Friend WithEvents lbSaldo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbAcuenta As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbTotalNeto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMdesc As DevComponents.DotNetBar.LabelX
End Class
