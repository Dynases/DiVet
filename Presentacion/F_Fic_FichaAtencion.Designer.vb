﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Fic_FichaAtencion
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.TmActualizar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbajo = New DevComponents.DotNetBar.ButtonX()
        Me.btnArriba = New DevComponents.DotNetBar.ButtonX()
        Me.btnActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAbrirFicha = New DevComponents.DotNetBar.ButtonX()
        Me.gpFichasAtencion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.JGFichasAtencion = New Janus.Windows.GridEX.GridEX()
        Me.Panel1.SuspendLayout()
        Me.gpFichasAtencion.SuspendLayout()
        CType(Me.JGFichasAtencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmActualizar
        '
        Me.TmActualizar.Enabled = True
        Me.TmActualizar.Interval = 9000
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Presentacion.My.Resources.Resources.Fondo2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.gpFichasAtencion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 651)
        Me.Panel1.TabIndex = 0
        '
        'btnAbajo
        '
        Me.btnAbajo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAbajo.BackColor = System.Drawing.Color.White
        Me.btnAbajo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAbajo.FadeEffect = False
        Me.btnAbajo.FocusCuesEnabled = False
        Me.btnAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbajo.Image = Global.Presentacion.My.Resources.Resources.abajo
        Me.btnAbajo.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAbajo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnAbajo.Location = New System.Drawing.Point(489, 572)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAbajo.Size = New System.Drawing.Size(50, 50)
        Me.btnAbajo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAbajo.TabIndex = 330
        '
        'btnArriba
        '
        Me.btnArriba.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnArriba.BackColor = System.Drawing.Color.White
        Me.btnArriba.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnArriba.FadeEffect = False
        Me.btnArriba.FocusCuesEnabled = False
        Me.btnArriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArriba.Image = Global.Presentacion.My.Resources.Resources.arriba
        Me.btnArriba.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnArriba.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnArriba.Location = New System.Drawing.Point(426, 572)
        Me.btnArriba.Name = "btnArriba"
        Me.btnArriba.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnArriba.Size = New System.Drawing.Size(50, 50)
        Me.btnArriba.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnArriba.TabIndex = 329
        '
        'btnActualizar
        '
        Me.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnActualizar.BackColor = System.Drawing.Color.White
        Me.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnActualizar.FadeEffect = False
        Me.btnActualizar.FocusCuesEnabled = False
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.Presentacion.My.Resources.Resources.reload_5
        Me.btnActualizar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnActualizar.Location = New System.Drawing.Point(646, 572)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnActualizar.Size = New System.Drawing.Size(72, 50)
        Me.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnActualizar.TabIndex = 264
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnAbrirFicha
        '
        Me.btnAbrirFicha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAbrirFicha.BackColor = System.Drawing.Color.White
        Me.btnAbrirFicha.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnAbrirFicha.FadeEffect = False
        Me.btnAbrirFicha.FocusCuesEnabled = False
        Me.btnAbrirFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirFicha.Image = Global.Presentacion.My.Resources.Resources.checked
        Me.btnAbrirFicha.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnAbrirFicha.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAbrirFicha.Location = New System.Drawing.Point(554, 572)
        Me.btnAbrirFicha.Name = "btnAbrirFicha"
        Me.btnAbrirFicha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAbrirFicha.Size = New System.Drawing.Size(72, 50)
        Me.btnAbrirFicha.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnAbrirFicha.TabIndex = 262
        Me.btnAbrirFicha.Text = "Abrir Ficha"
        '
        'gpFichasAtencion
        '
        Me.gpFichasAtencion.BackColor = System.Drawing.Color.Transparent
        Me.gpFichasAtencion.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFichasAtencion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFichasAtencion.Controls.Add(Me.btnAbrirFicha)
        Me.gpFichasAtencion.Controls.Add(Me.btnActualizar)
        Me.gpFichasAtencion.Controls.Add(Me.btnArriba)
        Me.gpFichasAtencion.Controls.Add(Me.btnAbajo)
        Me.gpFichasAtencion.Controls.Add(Me.JGFichasAtencion)
        Me.gpFichasAtencion.DisabledBackColor = System.Drawing.Color.Empty
        Me.gpFichasAtencion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpFichasAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFichasAtencion.Location = New System.Drawing.Point(0, 0)
        Me.gpFichasAtencion.Name = "gpFichasAtencion"
        Me.gpFichasAtencion.Size = New System.Drawing.Size(1134, 651)
        '
        '
        '
        Me.gpFichasAtencion.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFichasAtencion.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFichasAtencion.Style.BackColorGradientAngle = 90
        Me.gpFichasAtencion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichasAtencion.Style.BorderBottomWidth = 1
        Me.gpFichasAtencion.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.gpFichasAtencion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichasAtencion.Style.BorderLeftWidth = 1
        Me.gpFichasAtencion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichasAtencion.Style.BorderRightWidth = 1
        Me.gpFichasAtencion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFichasAtencion.Style.BorderTopWidth = 1
        Me.gpFichasAtencion.Style.CornerDiameter = 4
        Me.gpFichasAtencion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFichasAtencion.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFichasAtencion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpFichasAtencion.Style.TextColor = System.Drawing.Color.White
        Me.gpFichasAtencion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpFichasAtencion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpFichasAtencion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpFichasAtencion.TabIndex = 260
        Me.gpFichasAtencion.Text = "FICHAS PARA ATENCIÓN"
        '
        'JGFichasAtencion
        '
        Me.JGFichasAtencion.CausesValidation = False
        Me.JGFichasAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGFichasAtencion.Location = New System.Drawing.Point(3, 3)
        Me.JGFichasAtencion.Name = "JGFichasAtencion"
        Me.JGFichasAtencion.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.JGFichasAtencion.Size = New System.Drawing.Size(1186, 557)
        Me.JGFichasAtencion.TabIndex = 256
        '
        'F_Fic_FichaAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1134, 651)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "F_Fic_FichaAtencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FICHAS PARA LA ATENCIÓN"
        Me.Panel1.ResumeLayout(False)
        Me.gpFichasAtencion.ResumeLayout(False)
        CType(Me.JGFichasAtencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Protected WithEvents gpFichasAtencion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents JGFichasAtencion As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAbrirFicha As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TmActualizar As Timer
    Friend WithEvents btnAbajo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnArriba As DevComponents.DotNetBar.ButtonX
End Class
