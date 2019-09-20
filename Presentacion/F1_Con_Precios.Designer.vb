<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_Con_Precios
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
        Dim cbSectorP_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Con_Precios))
        Me.gpPreciosProd = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.JGPrecios = New Janus.Windows.GridEX.GridEX()
        Me.gpSector = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbSectorP = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbSector = New DevComponents.DotNetBar.LabelX()
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
        Me.gpPreciosProd.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.JGPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpSector.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.cbSectorP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MpanelSuperior
        '
        Me.MpanelSuperior.Controls.Add(Me.gpPreciosProd)
        Me.MpanelSuperior.Controls.Add(Me.gpSector)
        Me.MpanelSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.MpanelSuperior.Size = New System.Drawing.Size(740, 505)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSuperior.Size = New System.Drawing.Size(799, 72)
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
        Me.PanelInferior.Location = New System.Drawing.Point(0, 584)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelInferior.Size = New System.Drawing.Size(799, 39)
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
        Me.MPanelUserAct.Location = New System.Drawing.Point(599, 0)
        Me.MPanelUserAct.Margin = New System.Windows.Forms.Padding(4)
        '
        'MpanelBuscador
        '
        Me.MpanelBuscador.Margin = New System.Windows.Forms.Padding(4)
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
        Me.superTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.superTabControl1.Size = New System.Drawing.Size(799, 648)
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
        'gpPreciosProd
        '
        Me.gpPreciosProd.BackColor = System.Drawing.Color.White
        Me.gpPreciosProd.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPreciosProd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPreciosProd.Controls.Add(Me.Panel5)
        Me.gpPreciosProd.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpPreciosProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpPreciosProd.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpPreciosProd.Location = New System.Drawing.Point(0, 92)
        Me.gpPreciosProd.Name = "gpPreciosProd"
        Me.gpPreciosProd.Size = New System.Drawing.Size(740, 413)
        '
        '
        '
        Me.gpPreciosProd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpPreciosProd.Style.BackColorGradientAngle = 90
        Me.gpPreciosProd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpPreciosProd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPreciosProd.Style.BorderBottomWidth = 1
        Me.gpPreciosProd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpPreciosProd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPreciosProd.Style.BorderLeftWidth = 1
        Me.gpPreciosProd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPreciosProd.Style.BorderRightWidth = 1
        Me.gpPreciosProd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPreciosProd.Style.BorderTopWidth = 1
        Me.gpPreciosProd.Style.CornerDiameter = 4
        Me.gpPreciosProd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpPreciosProd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpPreciosProd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpPreciosProd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpPreciosProd.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpPreciosProd.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpPreciosProd.TabIndex = 3
        Me.gpPreciosProd.Text = "PRECIOS PRODUCTOS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.JGPrecios)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(734, 390)
        Me.Panel5.TabIndex = 0
        '
        'JGPrecios
        '
        Me.JGPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGPrecios.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGPrecios.Location = New System.Drawing.Point(0, 0)
        Me.JGPrecios.Name = "JGPrecios"
        Me.JGPrecios.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGPrecios.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGPrecios.Size = New System.Drawing.Size(734, 390)
        Me.JGPrecios.TabIndex = 0
        Me.JGPrecios.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'gpSector
        '
        Me.gpSector.BackColor = System.Drawing.Color.White
        Me.gpSector.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpSector.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpSector.Controls.Add(Me.Panel4)
        Me.gpSector.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpSector.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpSector.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpSector.Location = New System.Drawing.Point(0, 0)
        Me.gpSector.Name = "gpSector"
        Me.gpSector.Size = New System.Drawing.Size(740, 92)
        '
        '
        '
        Me.gpSector.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpSector.Style.BackColorGradientAngle = 90
        Me.gpSector.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpSector.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSector.Style.BorderBottomWidth = 1
        Me.gpSector.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpSector.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSector.Style.BorderLeftWidth = 1
        Me.gpSector.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSector.Style.BorderRightWidth = 1
        Me.gpSector.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpSector.Style.BorderTopWidth = 1
        Me.gpSector.Style.CornerDiameter = 4
        Me.gpSector.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpSector.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpSector.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpSector.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpSector.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpSector.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpSector.TabIndex = 2
        Me.gpSector.Text = "SECTOR"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(734, 69)
        Me.Panel4.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(734, 69)
        Me.TableLayoutPanel1.TabIndex = 236
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.cbSectorP)
        Me.Panel6.Controls.Add(Me.lbSector)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(223, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.Panel6.Size = New System.Drawing.Size(287, 63)
        Me.Panel6.TabIndex = 34
        '
        'cbSectorP
        '
        Me.cbSectorP.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.cbSectorP.ControlThemedAreas = Janus.Windows.GridEX.ControlThemedAreas.Button
        cbSectorP_DesignTimeLayout.LayoutString = resources.GetString("cbSectorP_DesignTimeLayout.LayoutString")
        Me.cbSectorP.DesignTimeLayout = cbSectorP_DesignTimeLayout
        Me.cbSectorP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbSectorP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSectorP.Location = New System.Drawing.Point(47, 20)
        Me.cbSectorP.Name = "cbSectorP"
        Me.cbSectorP.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbSectorP.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbSectorP.SelectedIndex = -1
        Me.cbSectorP.SelectedItem = Nothing
        Me.cbSectorP.Size = New System.Drawing.Size(240, 21)
        Me.cbSectorP.TabIndex = 31
        Me.cbSectorP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbSector
        '
        Me.lbSector.AutoSize = True
        Me.lbSector.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbSector.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSector.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbSector.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbSector.Location = New System.Drawing.Point(0, 20)
        Me.lbSector.Name = "lbSector"
        Me.lbSector.PaddingTop = 4
        Me.lbSector.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbSector.Size = New System.Drawing.Size(47, 20)
        Me.lbSector.TabIndex = 32
        Me.lbSector.Text = "Sector:"
        '
        'F1_Con_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 648)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "F1_Con_Precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRECIOS PRODUCTOS"
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
        Me.gpPreciosProd.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.JGPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpSector.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.cbSectorP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpPreciosProd As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents JGPrecios As Janus.Windows.GridEX.GridEX
    Friend WithEvents gpSector As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbSectorP As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbSector As DevComponents.DotNetBar.LabelX
End Class
