<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F0_Com_Proveedor
    Inherits Modelo.Modelo0

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
        Dim cbTipoDoc_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F0_Com_Proveedor))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gpDatosProveedor = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelDatosProveedor = New System.Windows.Forms.Panel()
        Me.intCelular = New DevComponents.Editors.IntegerInput()
        Me.txtTelf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbIdProveedor = New DevComponents.DotNetBar.LabelX()
        Me.lbObservacion = New DevComponents.DotNetBar.LabelX()
        Me.txtDireccionP = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbNombreP = New DevComponents.DotNetBar.LabelX()
        Me.lbDireccion = New DevComponents.DotNetBar.LabelX()
        Me.lbCelular = New DevComponents.DotNetBar.LabelX()
        Me.txtNombreP = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbTelefono = New DevComponents.DotNetBar.LabelX()
        Me.txtIdProveedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpDatosComplementarios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelDatosCompl = New System.Windows.Forms.Panel()
        Me.lbFechaIngreso = New DevComponents.DotNetBar.LabelX()
        Me.lbFechaNac = New DevComponents.DotNetBar.LabelX()
        Me.dtpFIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.swEstado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.lbEstado = New DevComponents.DotNetBar.LabelX()
        Me.txtNumDoc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbNumDoc = New DevComponents.DotNetBar.LabelX()
        Me.lbTipoDoc = New DevComponents.DotNetBar.LabelX()
        Me.btTipoDoc = New DevComponents.DotNetBar.ButtonX()
        Me.cbTipoDoc = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.GroupPanelBuscador.SuspendLayout()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControl1.SuspendLayout()
        Me.superTabControlPanel1.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gpDatosProveedor.SuspendLayout()
        Me.panelDatosProveedor.SuspendLayout()
        CType(Me.intCelular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatosComplementarios.SuspendLayout()
        Me.panelDatosCompl.SuspendLayout()
        CType(Me.cbTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.Location = New System.Drawing.Point(7, 341)
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(867, 218)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.TableLayoutPanel1)
        Me.MpanelSuperior.Location = New System.Drawing.Point(8, 72)
        Me.MpanelSuperior.Size = New System.Drawing.Size(862, 263)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(881, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 562)
        Me.PanelInferior.Size = New System.Drawing.Size(881, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(681, 0)
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(861, 195)
        '
        'SupTabItemBusqueda
        '
        Me.SupTabItemBusqueda.Visible = False
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
        Me.superTabControl1.Size = New System.Drawing.Size(881, 626)
        Me.superTabControl1.Controls.SetChildIndex(Me.superTabControlPanel1, 0)
        '
        'superTabControlPanel1
        '
        Me.superTabControlPanel1.Size = New System.Drawing.Size(881, 601)
        Me.superTabControlPanel1.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.superTabControlPanel1.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.superTabControlPanel1.Controls.SetChildIndex(Me.MpanelSuperior, 0)
        Me.superTabControlPanel1.Controls.SetChildIndex(Me.GroupPanelBuscador, 0)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.gpDatosProveedor, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gpDatosComplementarios, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 263.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(862, 263)
        Me.TableLayoutPanel1.TabIndex = 236
        '
        'gpDatosProveedor
        '
        Me.gpDatosProveedor.BackColor = System.Drawing.Color.White
        Me.gpDatosProveedor.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosProveedor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosProveedor.Controls.Add(Me.panelDatosProveedor)
        Me.gpDatosProveedor.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDatosProveedor.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gpDatosProveedor.Location = New System.Drawing.Point(3, 3)
        Me.gpDatosProveedor.Name = "gpDatosProveedor"
        Me.gpDatosProveedor.Size = New System.Drawing.Size(424, 257)
        '
        '
        '
        Me.gpDatosProveedor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.gpDatosProveedor.Style.BackColorGradientAngle = 90
        Me.gpDatosProveedor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText
        Me.gpDatosProveedor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosProveedor.Style.BorderBottomWidth = 1
        Me.gpDatosProveedor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosProveedor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosProveedor.Style.BorderLeftWidth = 1
        Me.gpDatosProveedor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosProveedor.Style.BorderRightWidth = 1
        Me.gpDatosProveedor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosProveedor.Style.BorderTopWidth = 1
        Me.gpDatosProveedor.Style.CornerDiameter = 4
        Me.gpDatosProveedor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosProveedor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosProveedor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatosProveedor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatosProveedor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatosProveedor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatosProveedor.TabIndex = 227
        Me.gpDatosProveedor.Text = "DATOS GENERALES"
        '
        'panelDatosProveedor
        '
        Me.panelDatosProveedor.AutoScroll = True
        Me.panelDatosProveedor.Controls.Add(Me.intCelular)
        Me.panelDatosProveedor.Controls.Add(Me.txtTelf)
        Me.panelDatosProveedor.Controls.Add(Me.lbIdProveedor)
        Me.panelDatosProveedor.Controls.Add(Me.lbObservacion)
        Me.panelDatosProveedor.Controls.Add(Me.txtDireccionP)
        Me.panelDatosProveedor.Controls.Add(Me.txtObservacion)
        Me.panelDatosProveedor.Controls.Add(Me.lbNombreP)
        Me.panelDatosProveedor.Controls.Add(Me.lbDireccion)
        Me.panelDatosProveedor.Controls.Add(Me.lbCelular)
        Me.panelDatosProveedor.Controls.Add(Me.txtNombreP)
        Me.panelDatosProveedor.Controls.Add(Me.lbTelefono)
        Me.panelDatosProveedor.Controls.Add(Me.txtIdProveedor)
        Me.panelDatosProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatosProveedor.Location = New System.Drawing.Point(0, 0)
        Me.panelDatosProveedor.Name = "panelDatosProveedor"
        Me.panelDatosProveedor.Size = New System.Drawing.Size(418, 234)
        Me.panelDatosProveedor.TabIndex = 234
        '
        'intCelular
        '
        '
        '
        '
        Me.intCelular.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.intCelular.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.intCelular.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.intCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intCelular.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.intCelular.Location = New System.Drawing.Point(132, 134)
        Me.intCelular.Name = "intCelular"
        Me.intCelular.Size = New System.Drawing.Size(110, 21)
        Me.intCelular.TabIndex = 234
        '
        'txtTelf
        '
        Me.txtTelf.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTelf.Border.Class = "TextBoxBorder"
        Me.txtTelf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTelf.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtTelf.Location = New System.Drawing.Point(132, 106)
        Me.txtTelf.Name = "txtTelf"
        Me.txtTelf.PreventEnterBeep = True
        Me.txtTelf.Size = New System.Drawing.Size(110, 22)
        Me.txtTelf.TabIndex = 4
        '
        'lbIdProveedor
        '
        Me.lbIdProveedor.AutoSize = True
        Me.lbIdProveedor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdProveedor.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdProveedor.Location = New System.Drawing.Point(12, 16)
        Me.lbIdProveedor.Name = "lbIdProveedor"
        Me.lbIdProveedor.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdProveedor.Size = New System.Drawing.Size(88, 16)
        Me.lbIdProveedor.TabIndex = 224
        Me.lbIdProveedor.Text = "Id Proveedor:"
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
        Me.lbObservacion.Location = New System.Drawing.Point(13, 161)
        Me.lbObservacion.Name = "lbObservacion"
        Me.lbObservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbObservacion.Size = New System.Drawing.Size(95, 23)
        Me.lbObservacion.TabIndex = 233
        Me.lbObservacion.Text = "Observacion:"
        '
        'txtDireccionP
        '
        Me.txtDireccionP.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDireccionP.Border.Class = "TextBoxBorder"
        Me.txtDireccionP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDireccionP.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccionP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtDireccionP.Location = New System.Drawing.Point(132, 74)
        Me.txtDireccionP.Multiline = True
        Me.txtDireccionP.Name = "txtDireccionP"
        Me.txtDireccionP.PreventEnterBeep = True
        Me.txtDireccionP.Size = New System.Drawing.Size(248, 22)
        Me.txtDireccionP.TabIndex = 3
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
        Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtObservacion.Location = New System.Drawing.Point(132, 162)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PreventEnterBeep = True
        Me.txtObservacion.Size = New System.Drawing.Size(248, 52)
        Me.txtObservacion.TabIndex = 6
        '
        'lbNombreP
        '
        Me.lbNombreP.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbNombreP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbNombreP.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbNombreP.Location = New System.Drawing.Point(13, 44)
        Me.lbNombreP.Name = "lbNombreP"
        Me.lbNombreP.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbNombreP.Size = New System.Drawing.Size(87, 23)
        Me.lbNombreP.TabIndex = 227
        Me.lbNombreP.Text = "Nombre:"
        '
        'lbDireccion
        '
        Me.lbDireccion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDireccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDireccion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDireccion.Location = New System.Drawing.Point(13, 72)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDireccion.Size = New System.Drawing.Size(87, 23)
        Me.lbDireccion.TabIndex = 226
        Me.lbDireccion.Text = "Direccion:"
        '
        'lbCelular
        '
        Me.lbCelular.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCelular.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCelular.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCelular.Location = New System.Drawing.Point(13, 134)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCelular.Size = New System.Drawing.Size(87, 23)
        Me.lbCelular.TabIndex = 231
        Me.lbCelular.Text = "Celular:"
        '
        'txtNombreP
        '
        Me.txtNombreP.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreP.Border.Class = "TextBoxBorder"
        Me.txtNombreP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreP.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNombreP.Location = New System.Drawing.Point(132, 43)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.PreventEnterBeep = True
        Me.txtNombreP.Size = New System.Drawing.Size(248, 22)
        Me.txtNombreP.TabIndex = 2
        '
        'lbTelefono
        '
        Me.lbTelefono.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTelefono.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTelefono.Location = New System.Drawing.Point(13, 106)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTelefono.Size = New System.Drawing.Size(87, 23)
        Me.lbTelefono.TabIndex = 229
        Me.lbTelefono.Text = "Telefono:"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdProveedor.Border.Class = "TextBoxBorder"
        Me.txtIdProveedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtIdProveedor.Location = New System.Drawing.Point(132, 13)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.PreventEnterBeep = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(63, 22)
        Me.txtIdProveedor.TabIndex = 0
        Me.txtIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gpDatosComplementarios
        '
        Me.gpDatosComplementarios.BackColor = System.Drawing.Color.White
        Me.gpDatosComplementarios.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatosComplementarios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatosComplementarios.Controls.Add(Me.panelDatosCompl)
        Me.gpDatosComplementarios.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpDatosComplementarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpDatosComplementarios.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDatosComplementarios.Location = New System.Drawing.Point(433, 3)
        Me.gpDatosComplementarios.Name = "gpDatosComplementarios"
        Me.gpDatosComplementarios.Size = New System.Drawing.Size(426, 257)
        '
        '
        '
        Me.gpDatosComplementarios.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpDatosComplementarios.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedShadow
        Me.gpDatosComplementarios.Style.BackColorGradientAngle = 90
        Me.gpDatosComplementarios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosComplementarios.Style.BorderBottomWidth = 1
        Me.gpDatosComplementarios.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatosComplementarios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosComplementarios.Style.BorderLeftWidth = 1
        Me.gpDatosComplementarios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosComplementarios.Style.BorderRightWidth = 1
        Me.gpDatosComplementarios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatosComplementarios.Style.BorderTopWidth = 1
        Me.gpDatosComplementarios.Style.CornerDiameter = 4
        Me.gpDatosComplementarios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatosComplementarios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatosComplementarios.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatosComplementarios.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpDatosComplementarios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpDatosComplementarios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpDatosComplementarios.TabIndex = 228
        Me.gpDatosComplementarios.Text = "DATOS COMPLEMENTARIOS"
        '
        'panelDatosCompl
        '
        Me.panelDatosCompl.AutoScroll = True
        Me.panelDatosCompl.BackColor = System.Drawing.Color.Transparent
        Me.panelDatosCompl.Controls.Add(Me.lbFechaIngreso)
        Me.panelDatosCompl.Controls.Add(Me.lbFechaNac)
        Me.panelDatosCompl.Controls.Add(Me.dtpFIngreso)
        Me.panelDatosCompl.Controls.Add(Me.dtpFechaNac)
        Me.panelDatosCompl.Controls.Add(Me.swEstado)
        Me.panelDatosCompl.Controls.Add(Me.lbEstado)
        Me.panelDatosCompl.Controls.Add(Me.txtNumDoc)
        Me.panelDatosCompl.Controls.Add(Me.lbNumDoc)
        Me.panelDatosCompl.Controls.Add(Me.lbTipoDoc)
        Me.panelDatosCompl.Controls.Add(Me.btTipoDoc)
        Me.panelDatosCompl.Controls.Add(Me.cbTipoDoc)
        Me.panelDatosCompl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatosCompl.Location = New System.Drawing.Point(0, 0)
        Me.panelDatosCompl.Name = "panelDatosCompl"
        Me.panelDatosCompl.Size = New System.Drawing.Size(420, 234)
        Me.panelDatosCompl.TabIndex = 216
        '
        'lbFechaIngreso
        '
        Me.lbFechaIngreso.AutoSize = True
        Me.lbFechaIngreso.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFechaIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaIngreso.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaIngreso.Location = New System.Drawing.Point(14, 123)
        Me.lbFechaIngreso.Name = "lbFechaIngreso"
        Me.lbFechaIngreso.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaIngreso.Size = New System.Drawing.Size(66, 16)
        Me.lbFechaIngreso.TabIndex = 245
        Me.lbFechaIngreso.Text = "F.Ingreso:"
        '
        'lbFechaNac
        '
        Me.lbFechaNac.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbFechaNac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbFechaNac.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbFechaNac.Location = New System.Drawing.Point(14, 13)
        Me.lbFechaNac.Name = "lbFechaNac"
        Me.lbFechaNac.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbFechaNac.Size = New System.Drawing.Size(93, 23)
        Me.lbFechaNac.TabIndex = 244
        Me.lbFechaNac.Text = "F.Nacimiento:"
        '
        'dtpFIngreso
        '
        Me.dtpFIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFIngreso.Location = New System.Drawing.Point(140, 118)
        Me.dtpFIngreso.Name = "dtpFIngreso"
        Me.dtpFIngreso.Size = New System.Drawing.Size(136, 22)
        Me.dtpFIngreso.TabIndex = 8
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(140, 13)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(136, 22)
        Me.dtpFechaNac.TabIndex = 7
        '
        'swEstado
        '
        '
        '
        '
        Me.swEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swEstado.Location = New System.Drawing.Point(140, 152)
        Me.swEstado.Name = "swEstado"
        Me.swEstado.OffBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.swEstado.OffText = "PASIVO"
        Me.swEstado.OffTextColor = System.Drawing.Color.White
        Me.swEstado.OnBackColor = System.Drawing.Color.Blue
        Me.swEstado.OnText = "ACTIVO"
        Me.swEstado.OnTextColor = System.Drawing.Color.White
        Me.swEstado.Size = New System.Drawing.Size(136, 22)
        Me.swEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swEstado.TabIndex = 6
        Me.swEstado.Value = True
        Me.swEstado.ValueObject = "Y"
        '
        'lbEstado
        '
        Me.lbEstado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbEstado.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbEstado.Location = New System.Drawing.Point(14, 152)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbEstado.Size = New System.Drawing.Size(79, 23)
        Me.lbEstado.TabIndex = 236
        Me.lbEstado.Text = "Estado:"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNumDoc.Border.Class = "TextBoxBorder"
        Me.txtNumDoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNumDoc.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNumDoc.Location = New System.Drawing.Point(140, 83)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.PreventEnterBeep = True
        Me.txtNumDoc.Size = New System.Drawing.Size(166, 22)
        Me.txtNumDoc.TabIndex = 3
        '
        'lbNumDoc
        '
        Me.lbNumDoc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbNumDoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbNumDoc.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbNumDoc.Location = New System.Drawing.Point(14, 83)
        Me.lbNumDoc.Name = "lbNumDoc"
        Me.lbNumDoc.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbNumDoc.Size = New System.Drawing.Size(113, 23)
        Me.lbNumDoc.TabIndex = 231
        Me.lbNumDoc.Text = "N. Documento:"
        '
        'lbTipoDoc
        '
        Me.lbTipoDoc.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbTipoDoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbTipoDoc.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbTipoDoc.Location = New System.Drawing.Point(14, 49)
        Me.lbTipoDoc.Name = "lbTipoDoc"
        Me.lbTipoDoc.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbTipoDoc.Size = New System.Drawing.Size(116, 23)
        Me.lbTipoDoc.TabIndex = 30
        Me.lbTipoDoc.Text = "Tipo Documento:"
        '
        'btTipoDoc
        '
        Me.btTipoDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.btTipoDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btTipoDoc.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btTipoDoc.Location = New System.Drawing.Point(290, 48)
        Me.btTipoDoc.Name = "btTipoDoc"
        Me.btTipoDoc.Size = New System.Drawing.Size(28, 23)
        Me.btTipoDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btTipoDoc.TabIndex = 210
        Me.btTipoDoc.Visible = False
        '
        'cbTipoDoc
        '
        cbTipoDoc_DesignTimeLayout.LayoutString = resources.GetString("cbTipoDoc_DesignTimeLayout.LayoutString")
        Me.cbTipoDoc.DesignTimeLayout = cbTipoDoc_DesignTimeLayout
        Me.cbTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoDoc.Location = New System.Drawing.Point(140, 50)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbTipoDoc.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbTipoDoc.SelectedIndex = -1
        Me.cbTipoDoc.SelectedItem = Nothing
        Me.cbTipoDoc.Size = New System.Drawing.Size(136, 22)
        Me.cbTipoDoc.TabIndex = 2
        Me.cbTipoDoc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F0_Com_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 626)
        Me.MaximizeBox = False
        Me.Name = "F0_Com_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO PROVEEDOR"
        Me.GroupPanelBuscador.ResumeLayout(False)
        Me.MpanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControl1.ResumeLayout(False)
        Me.superTabControlPanel1.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gpDatosProveedor.ResumeLayout(False)
        Me.panelDatosProveedor.ResumeLayout(False)
        Me.panelDatosProveedor.PerformLayout()
        CType(Me.intCelular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatosComplementarios.ResumeLayout(False)
        Me.panelDatosCompl.ResumeLayout(False)
        Me.panelDatosCompl.PerformLayout()
        CType(Me.cbTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gpDatosProveedor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelDatosProveedor As Panel
    Friend WithEvents txtTelf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbObservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDireccionP As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbNombreP As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbDireccion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCelular As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNombreP As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbTelefono As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpDatosComplementarios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelDatosCompl As Panel
    Friend WithEvents lbFechaIngreso As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbFechaNac As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFIngreso As DateTimePicker
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents swEstado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lbEstado As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNumDoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbNumDoc As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbTipoDoc As DevComponents.DotNetBar.LabelX
    Friend WithEvents btTipoDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTipoDoc As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbIdProveedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdProveedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents intCelular As DevComponents.Editors.IntegerInput
End Class
