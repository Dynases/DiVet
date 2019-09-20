<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Con_Roles
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Con_Roles))
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.lbIdRol = New DevComponents.DotNetBar.LabelX()
        Me.lbRol = New DevComponents.DotNetBar.LabelX()
        Me.tbNumi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbRol = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panelModuloPrivilegios = New System.Windows.Forms.Panel()
        Me.gpPrivilegios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGPrivilegios = New Janus.Windows.GridEX.GridEX()
        Me.gpModulos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGModulos = New Janus.Windows.GridEX.GridEX()
        Me.msModulos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELECCIONARTODOSSHOWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECCIONARTODOSADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECCIONARTODOSEDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECCIONARTODOSDELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MpanelSuperior.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatos.SuspendLayout()
        Me.panelModuloPrivilegios.SuspendLayout()
        Me.gpPrivilegios.SuspendLayout()
        CType(Me.JGPrivilegios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpModulos.SuspendLayout()
        CType(Me.JGModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msModulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.panelModuloPrivilegios)
        Me.MpanelSuperior.Controls.Add(Me.panelDatos)
        '
        'PanelSuperior
        '
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 437)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'LblPaginacion
        '
        Me.LblPaginacion.Location = New System.Drawing.Point(172, 0)
        Me.LblPaginacion.Size = New System.Drawing.Size(116, 39)
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.Size = New System.Drawing.Size(930, 476)
        Me.MpanelBuscador.Visible = False
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
        Me.superTabControl1.Size = New System.Drawing.Size(930, 501)
        '
        'superTabItem2
        '
        Me.superTabItem2.Visible = False
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
        'panelDatos
        '
        Me.panelDatos.Controls.Add(Me.lbIdRol)
        Me.panelDatos.Controls.Add(Me.lbRol)
        Me.panelDatos.Controls.Add(Me.tbNumi)
        Me.panelDatos.Controls.Add(Me.tbRol)
        Me.panelDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelDatos.Location = New System.Drawing.Point(0, 0)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(924, 103)
        Me.panelDatos.TabIndex = 27
        '
        'lbIdRol
        '
        Me.lbIdRol.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbIdRol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIdRol.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbIdRol.Location = New System.Drawing.Point(12, 24)
        Me.lbIdRol.Name = "lbIdRol"
        Me.lbIdRol.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbIdRol.Size = New System.Drawing.Size(51, 23)
        Me.lbIdRol.TabIndex = 25
        Me.lbIdRol.Text = "Id Rol:"
        '
        'lbRol
        '
        Me.lbRol.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbRol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbRol.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbRol.Location = New System.Drawing.Point(13, 52)
        Me.lbRol.Name = "lbRol"
        Me.lbRol.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbRol.Size = New System.Drawing.Size(50, 23)
        Me.lbRol.TabIndex = 24
        Me.lbRol.Text = "Rol:"
        '
        'tbNumi
        '
        Me.tbNumi.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.tbNumi.Border.Class = "TextBoxBorder"
        Me.tbNumi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNumi.DisabledBackColor = System.Drawing.Color.White
        Me.tbNumi.Enabled = False
        Me.tbNumi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumi.ForeColor = System.Drawing.Color.Black
        Me.tbNumi.Location = New System.Drawing.Point(97, 23)
        Me.tbNumi.Name = "tbNumi"
        Me.tbNumi.PreventEnterBeep = True
        Me.tbNumi.Size = New System.Drawing.Size(100, 21)
        Me.tbNumi.TabIndex = 20
        '
        'tbRol
        '
        Me.tbRol.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbRol.Border.Class = "TextBoxBorder"
        Me.tbRol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbRol.DisabledBackColor = System.Drawing.Color.White
        Me.tbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRol.ForeColor = System.Drawing.Color.Black
        Me.tbRol.Location = New System.Drawing.Point(97, 53)
        Me.tbRol.Name = "tbRol"
        Me.tbRol.PreventEnterBeep = True
        Me.tbRol.Size = New System.Drawing.Size(212, 21)
        Me.tbRol.TabIndex = 23
        '
        'panelModuloPrivilegios
        '
        Me.panelModuloPrivilegios.Controls.Add(Me.gpPrivilegios)
        Me.panelModuloPrivilegios.Controls.Add(Me.gpModulos)
        Me.panelModuloPrivilegios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelModuloPrivilegios.Location = New System.Drawing.Point(0, 103)
        Me.panelModuloPrivilegios.Name = "panelModuloPrivilegios"
        Me.panelModuloPrivilegios.Size = New System.Drawing.Size(924, 260)
        Me.panelModuloPrivilegios.TabIndex = 28
        '
        'gpPrivilegios
        '
        Me.gpPrivilegios.BackColor = System.Drawing.Color.White
        Me.gpPrivilegios.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPrivilegios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPrivilegios.Controls.Add(Me.JGPrivilegios)
        Me.gpPrivilegios.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpPrivilegios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpPrivilegios.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpPrivilegios.Location = New System.Drawing.Point(257, 0)
        Me.gpPrivilegios.Name = "gpPrivilegios"
        Me.gpPrivilegios.Size = New System.Drawing.Size(667, 260)
        '
        '
        '
        Me.gpPrivilegios.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.gpPrivilegios.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.gpPrivilegios.Style.BackColorGradientAngle = 90
        Me.gpPrivilegios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPrivilegios.Style.BorderBottomWidth = 1
        Me.gpPrivilegios.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.gpPrivilegios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPrivilegios.Style.BorderLeftWidth = 1
        Me.gpPrivilegios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPrivilegios.Style.BorderRightWidth = 1
        Me.gpPrivilegios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPrivilegios.Style.BorderTopWidth = 1
        Me.gpPrivilegios.Style.CornerDiameter = 4
        Me.gpPrivilegios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.gpPrivilegios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpPrivilegios.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpPrivilegios.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpPrivilegios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpPrivilegios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpPrivilegios.TabIndex = 25
        Me.gpPrivilegios.Text = "P R I V I L E G I O S"
        '
        'JGPrivilegios
        '
        Me.JGPrivilegios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JGPrivilegios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGPrivilegios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGPrivilegios.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGPrivilegios.Location = New System.Drawing.Point(0, 0)
        Me.JGPrivilegios.Name = "JGPrivilegios"
        Me.JGPrivilegios.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGPrivilegios.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGPrivilegios.Size = New System.Drawing.Size(661, 234)
        Me.JGPrivilegios.TabIndex = 0
        Me.JGPrivilegios.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'gpModulos
        '
        Me.gpModulos.BackColor = System.Drawing.Color.White
        Me.gpModulos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpModulos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpModulos.Controls.Add(Me.JGModulos)
        Me.gpModulos.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpModulos.Dock = System.Windows.Forms.DockStyle.Left
        Me.gpModulos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpModulos.Location = New System.Drawing.Point(0, 0)
        Me.gpModulos.Name = "gpModulos"
        Me.gpModulos.Size = New System.Drawing.Size(257, 260)
        '
        '
        '
        Me.gpModulos.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.gpModulos.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.gpModulos.Style.BackColorGradientAngle = 90
        Me.gpModulos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpModulos.Style.BorderBottomWidth = 1
        Me.gpModulos.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.gpModulos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpModulos.Style.BorderLeftWidth = 1
        Me.gpModulos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpModulos.Style.BorderRightWidth = 1
        Me.gpModulos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpModulos.Style.BorderTopWidth = 1
        Me.gpModulos.Style.CornerDiameter = 4
        Me.gpModulos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.gpModulos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpModulos.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpModulos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpModulos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpModulos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpModulos.TabIndex = 24
        Me.gpModulos.Text = "M Ó D U L O S"
        '
        'JGModulos
        '
        Me.JGModulos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.JGModulos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JGModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGModulos.FlatBorderColor = System.Drawing.Color.DodgerBlue
        Me.JGModulos.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.JGModulos.FocusCellFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGModulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGModulos.GridLineColor = System.Drawing.Color.DodgerBlue
        Me.JGModulos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGModulos.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGModulos.Hierarchical = True
        Me.JGModulos.Location = New System.Drawing.Point(0, 0)
        Me.JGModulos.Name = "JGModulos"
        Me.JGModulos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGModulos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGModulos.RowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGModulos.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGModulos.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGModulos.SelectedInactiveFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.JGModulos.Size = New System.Drawing.Size(251, 237)
        Me.JGModulos.TabIndex = 1
        Me.JGModulos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'msModulos
        '
        Me.msModulos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msModulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SELECCIONARTODOSSHOWToolStripMenuItem, Me.SELECCIONARTODOSADDToolStripMenuItem, Me.SELECCIONARTODOSEDITToolStripMenuItem, Me.SELECCIONARTODOSDELToolStripMenuItem})
        Me.msModulos.Name = "msModulos"
        Me.msModulos.Size = New System.Drawing.Size(248, 148)
        '
        'SELECCIONARTODOSSHOWToolStripMenuItem
        '
        Me.SELECCIONARTODOSSHOWToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.ver
        Me.SELECCIONARTODOSSHOWToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SELECCIONARTODOSSHOWToolStripMenuItem.Name = "SELECCIONARTODOSSHOWToolStripMenuItem"
        Me.SELECCIONARTODOSSHOWToolStripMenuItem.Size = New System.Drawing.Size(247, 36)
        Me.SELECCIONARTODOSSHOWToolStripMenuItem.Text = "SELECCIONAR TODOS SHOW"
        '
        'SELECCIONARTODOSADDToolStripMenuItem
        '
        Me.SELECCIONARTODOSADDToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.add2
        Me.SELECCIONARTODOSADDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SELECCIONARTODOSADDToolStripMenuItem.Name = "SELECCIONARTODOSADDToolStripMenuItem"
        Me.SELECCIONARTODOSADDToolStripMenuItem.Size = New System.Drawing.Size(247, 36)
        Me.SELECCIONARTODOSADDToolStripMenuItem.Text = "SELECCIONAR TODOS ADD"
        '
        'SELECCIONARTODOSEDITToolStripMenuItem
        '
        Me.SELECCIONARTODOSEDITToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.edit2
        Me.SELECCIONARTODOSEDITToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SELECCIONARTODOSEDITToolStripMenuItem.Name = "SELECCIONARTODOSEDITToolStripMenuItem"
        Me.SELECCIONARTODOSEDITToolStripMenuItem.Size = New System.Drawing.Size(247, 36)
        Me.SELECCIONARTODOSEDITToolStripMenuItem.Text = "SELECCIONAR TODOS EDIT"
        '
        'SELECCIONARTODOSDELToolStripMenuItem
        '
        Me.SELECCIONARTODOSDELToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.trash2
        Me.SELECCIONARTODOSDELToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SELECCIONARTODOSDELToolStripMenuItem.Name = "SELECCIONARTODOSDELToolStripMenuItem"
        Me.SELECCIONARTODOSDELToolStripMenuItem.Size = New System.Drawing.Size(247, 36)
        Me.SELECCIONARTODOSDELToolStripMenuItem.Text = "SELECCIONAR TODOS DELETE"
        '
        'F1_Con_Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(930, 501)
        Me.MaximizeBox = False
        Me.Name = "F1_Con_Roles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROLES DE USUARIO"
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
        Me.panelDatos.ResumeLayout(False)
        Me.panelModuloPrivilegios.ResumeLayout(False)
        Me.gpPrivilegios.ResumeLayout(False)
        CType(Me.JGPrivilegios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpModulos.ResumeLayout(False)
        CType(Me.JGModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msModulos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDatos As Panel
    Friend WithEvents lbIdRol As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbRol As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbNumi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbRol As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panelModuloPrivilegios As Panel
    Friend WithEvents gpPrivilegios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGPrivilegios As Janus.Windows.GridEX.GridEX
    Friend WithEvents gpModulos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGModulos As Janus.Windows.GridEX.GridEX
    Friend WithEvents msModulos As ContextMenuStrip
    Friend WithEvents SELECCIONARTODOSSHOWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECCIONARTODOSADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECCIONARTODOSEDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECCIONARTODOSDELToolStripMenuItem As ToolStripMenuItem
End Class
