<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.LBNumero = New System.Windows.Forms.Label()
        Me.TBNumero = New System.Windows.Forms.TextBox()
        Me.TBSillones = New System.Windows.Forms.TextBox()
        Me.LBSillones = New System.Windows.Forms.Label()
        Me.GPVenta = New System.Windows.Forms.GroupBox()
        Me.GPSillones = New System.Windows.Forms.GroupBox()
        Me.RBDoble = New System.Windows.Forms.RadioButton()
        Me.RBIndividual = New System.Windows.Forms.RadioButton()
        Me.RBSofa = New System.Windows.Forms.RadioButton()
        Me.GPTelas = New System.Windows.Forms.GroupBox()
        Me.RBCuerina = New System.Windows.Forms.RadioButton()
        Me.RBCuero = New System.Windows.Forms.RadioButton()
        Me.TSOpciones = New System.Windows.Forms.ToolStrip()
        Me.TSGuardar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLimpiarEntradas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.GPVentas = New System.Windows.Forms.GroupBox()
        Me.LISTVenta = New System.Windows.Forms.ListBox()
        Me.LBVenta = New System.Windows.Forms.Label()
        Me.LISTCosto = New System.Windows.Forms.ListBox()
        Me.LBCosto = New System.Windows.Forms.Label()
        Me.LISTPrecioTela = New System.Windows.Forms.ListBox()
        Me.LBPrecioTela = New System.Windows.Forms.Label()
        Me.LISTManoObra = New System.Windows.Forms.ListBox()
        Me.LBManoObra = New System.Windows.Forms.Label()
        Me.LISTDescripcion = New System.Windows.Forms.ListBox()
        Me.LBDescripcion = New System.Windows.Forms.Label()
        Me.LISTNumeroVenta = New System.Windows.Forms.ListBox()
        Me.LBNumeroVenta = New System.Windows.Forms.Label()
        Me.GPVenta.SuspendLayout()
        Me.GPSillones.SuspendLayout()
        Me.GPTelas.SuspendLayout()
        Me.TSOpciones.SuspendLayout()
        Me.GPVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBNumero
        '
        Me.LBNumero.AutoSize = True
        Me.LBNumero.Location = New System.Drawing.Point(33, 29)
        Me.LBNumero.Name = "LBNumero"
        Me.LBNumero.Size = New System.Drawing.Size(113, 17)
        Me.LBNumero.TabIndex = 0
        Me.LBNumero.Text = "Venta Numero"
        '
        'TBNumero
        '
        Me.TBNumero.Location = New System.Drawing.Point(184, 26)
        Me.TBNumero.Name = "TBNumero"
        Me.TBNumero.Size = New System.Drawing.Size(123, 25)
        Me.TBNumero.TabIndex = 1
        Me.TBNumero.Text = "0"
        '
        'TBSillones
        '
        Me.TBSillones.Location = New System.Drawing.Point(184, 70)
        Me.TBSillones.Name = "TBSillones"
        Me.TBSillones.Size = New System.Drawing.Size(123, 25)
        Me.TBSillones.TabIndex = 3
        Me.TBSillones.Text = "0"
        '
        'LBSillones
        '
        Me.LBSillones.AutoSize = True
        Me.LBSillones.Location = New System.Drawing.Point(10, 70)
        Me.LBSillones.Name = "LBSillones"
        Me.LBSillones.Size = New System.Drawing.Size(158, 17)
        Me.LBSillones.TabIndex = 2
        Me.LBSillones.Text = "Cantidad de Sillones"
        '
        'GPVenta
        '
        Me.GPVenta.Controls.Add(Me.TBSillones)
        Me.GPVenta.Controls.Add(Me.LBSillones)
        Me.GPVenta.Controls.Add(Me.TBNumero)
        Me.GPVenta.Controls.Add(Me.LBNumero)
        Me.GPVenta.Location = New System.Drawing.Point(34, 50)
        Me.GPVenta.Name = "GPVenta"
        Me.GPVenta.Size = New System.Drawing.Size(362, 119)
        Me.GPVenta.TabIndex = 4
        Me.GPVenta.TabStop = False
        Me.GPVenta.Text = "Datos de la Venta"
        '
        'GPSillones
        '
        Me.GPSillones.Controls.Add(Me.RBDoble)
        Me.GPSillones.Controls.Add(Me.RBIndividual)
        Me.GPSillones.Controls.Add(Me.RBSofa)
        Me.GPSillones.Location = New System.Drawing.Point(418, 50)
        Me.GPSillones.Name = "GPSillones"
        Me.GPSillones.Size = New System.Drawing.Size(233, 118)
        Me.GPSillones.TabIndex = 5
        Me.GPSillones.TabStop = False
        Me.GPSillones.Text = "Tamaño de los Sillones"
        '
        'RBDoble
        '
        Me.RBDoble.AutoSize = True
        Me.RBDoble.Location = New System.Drawing.Point(63, 78)
        Me.RBDoble.Name = "RBDoble"
        Me.RBDoble.Size = New System.Drawing.Size(68, 21)
        Me.RBDoble.TabIndex = 2
        Me.RBDoble.TabStop = True
        Me.RBDoble.Text = "Doble"
        Me.RBDoble.UseVisualStyleBackColor = True
        '
        'RBIndividual
        '
        Me.RBIndividual.AutoSize = True
        Me.RBIndividual.Location = New System.Drawing.Point(63, 51)
        Me.RBIndividual.Name = "RBIndividual"
        Me.RBIndividual.Size = New System.Drawing.Size(99, 21)
        Me.RBIndividual.TabIndex = 1
        Me.RBIndividual.TabStop = True
        Me.RBIndividual.Text = "Individual"
        Me.RBIndividual.UseVisualStyleBackColor = True
        '
        'RBSofa
        '
        Me.RBSofa.AutoSize = True
        Me.RBSofa.Location = New System.Drawing.Point(63, 24)
        Me.RBSofa.Name = "RBSofa"
        Me.RBSofa.Size = New System.Drawing.Size(59, 21)
        Me.RBSofa.TabIndex = 0
        Me.RBSofa.TabStop = True
        Me.RBSofa.Text = "Sofa"
        Me.RBSofa.UseVisualStyleBackColor = True
        '
        'GPTelas
        '
        Me.GPTelas.Controls.Add(Me.RBCuerina)
        Me.GPTelas.Controls.Add(Me.RBCuero)
        Me.GPTelas.Location = New System.Drawing.Point(678, 51)
        Me.GPTelas.Name = "GPTelas"
        Me.GPTelas.Size = New System.Drawing.Size(233, 118)
        Me.GPTelas.TabIndex = 6
        Me.GPTelas.TabStop = False
        Me.GPTelas.Text = "Tipo de Tela"
        '
        'RBCuerina
        '
        Me.RBCuerina.AutoSize = True
        Me.RBCuerina.Location = New System.Drawing.Point(63, 51)
        Me.RBCuerina.Name = "RBCuerina"
        Me.RBCuerina.Size = New System.Drawing.Size(82, 21)
        Me.RBCuerina.TabIndex = 1
        Me.RBCuerina.TabStop = True
        Me.RBCuerina.Text = "Cuerina"
        Me.RBCuerina.UseVisualStyleBackColor = True
        '
        'RBCuero
        '
        Me.RBCuero.AutoSize = True
        Me.RBCuero.Location = New System.Drawing.Point(63, 24)
        Me.RBCuero.Name = "RBCuero"
        Me.RBCuero.Size = New System.Drawing.Size(68, 21)
        Me.RBCuero.TabIndex = 0
        Me.RBCuero.TabStop = True
        Me.RBCuero.Text = "Cuero"
        Me.RBCuero.UseVisualStyleBackColor = True
        '
        'TSOpciones
        '
        Me.TSOpciones.BackColor = System.Drawing.Color.DarkKhaki
        Me.TSOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSGuardar, Me.ToolStripSeparator1, Me.TSLimpiarEntradas, Me.ToolStripSeparator2, Me.ToolStripLabel3})
        Me.TSOpciones.Location = New System.Drawing.Point(0, 0)
        Me.TSOpciones.Name = "TSOpciones"
        Me.TSOpciones.Size = New System.Drawing.Size(944, 25)
        Me.TSOpciones.TabIndex = 7
        '
        'TSGuardar
        '
        Me.TSGuardar.Name = "TSGuardar"
        Me.TSGuardar.Size = New System.Drawing.Size(49, 22)
        Me.TSGuardar.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TSLimpiarEntradas
        '
        Me.TSLimpiarEntradas.Name = "TSLimpiarEntradas"
        Me.TSLimpiarEntradas.Size = New System.Drawing.Size(140, 22)
        Me.TSLimpiarEntradas.Text = "Elimiar todos lo Registros"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ActiveLinkColor = System.Drawing.Color.Brown
        Me.ToolStripLabel3.BackColor = System.Drawing.Color.Crimson
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripLabel3.Text = "Salir"
        '
        'GPVentas
        '
        Me.GPVentas.Controls.Add(Me.LISTVenta)
        Me.GPVentas.Controls.Add(Me.LBVenta)
        Me.GPVentas.Controls.Add(Me.LISTCosto)
        Me.GPVentas.Controls.Add(Me.LBCosto)
        Me.GPVentas.Controls.Add(Me.LISTPrecioTela)
        Me.GPVentas.Controls.Add(Me.LBPrecioTela)
        Me.GPVentas.Controls.Add(Me.LISTManoObra)
        Me.GPVentas.Controls.Add(Me.LBManoObra)
        Me.GPVentas.Controls.Add(Me.LISTDescripcion)
        Me.GPVentas.Controls.Add(Me.LBDescripcion)
        Me.GPVentas.Controls.Add(Me.LISTNumeroVenta)
        Me.GPVentas.Controls.Add(Me.LBNumeroVenta)
        Me.GPVentas.Location = New System.Drawing.Point(12, 207)
        Me.GPVentas.Name = "GPVentas"
        Me.GPVentas.Size = New System.Drawing.Size(920, 234)
        Me.GPVentas.TabIndex = 8
        Me.GPVentas.TabStop = False
        Me.GPVentas.Text = "Ventas"
        '
        'LISTVenta
        '
        Me.LISTVenta.Enabled = False
        Me.LISTVenta.FormattingEnabled = True
        Me.LISTVenta.ItemHeight = 17
        Me.LISTVenta.Location = New System.Drawing.Point(783, 57)
        Me.LISTVenta.Name = "LISTVenta"
        Me.LISTVenta.Size = New System.Drawing.Size(131, 157)
        Me.LISTVenta.TabIndex = 20
        '
        'LBVenta
        '
        Me.LBVenta.AutoSize = True
        Me.LBVenta.Location = New System.Drawing.Point(780, 37)
        Me.LBVenta.Name = "LBVenta"
        Me.LBVenta.Size = New System.Drawing.Size(124, 17)
        Me.LBVenta.TabIndex = 19
        Me.LBVenta.Text = "Precio de Venta"
        '
        'LISTCosto
        '
        Me.LISTCosto.Enabled = False
        Me.LISTCosto.FormattingEnabled = True
        Me.LISTCosto.ItemHeight = 17
        Me.LISTCosto.Location = New System.Drawing.Point(645, 57)
        Me.LISTCosto.Name = "LISTCosto"
        Me.LISTCosto.Size = New System.Drawing.Size(132, 157)
        Me.LISTCosto.TabIndex = 18
        '
        'LBCosto
        '
        Me.LBCosto.AutoSize = True
        Me.LBCosto.Location = New System.Drawing.Point(642, 37)
        Me.LBCosto.Name = "LBCosto"
        Me.LBCosto.Size = New System.Drawing.Size(91, 17)
        Me.LBCosto.TabIndex = 17
        Me.LBCosto.Text = "Total Costo"
        '
        'LISTPrecioTela
        '
        Me.LISTPrecioTela.Enabled = False
        Me.LISTPrecioTela.FormattingEnabled = True
        Me.LISTPrecioTela.ItemHeight = 17
        Me.LISTPrecioTela.Location = New System.Drawing.Point(501, 57)
        Me.LISTPrecioTela.Name = "LISTPrecioTela"
        Me.LISTPrecioTela.Size = New System.Drawing.Size(138, 157)
        Me.LISTPrecioTela.TabIndex = 16
        '
        'LBPrecioTela
        '
        Me.LBPrecioTela.AutoSize = True
        Me.LBPrecioTela.Location = New System.Drawing.Point(498, 37)
        Me.LBPrecioTela.Name = "LBPrecioTela"
        Me.LBPrecioTela.Size = New System.Drawing.Size(125, 17)
        Me.LBPrecioTela.TabIndex = 15
        Me.LBPrecioTela.Text = "Costo de la Tela"
        '
        'LISTManoObra
        '
        Me.LISTManoObra.Enabled = False
        Me.LISTManoObra.FormattingEnabled = True
        Me.LISTManoObra.ItemHeight = 17
        Me.LISTManoObra.Location = New System.Drawing.Point(353, 57)
        Me.LISTManoObra.Name = "LISTManoObra"
        Me.LISTManoObra.Size = New System.Drawing.Size(142, 157)
        Me.LISTManoObra.TabIndex = 14
        '
        'LBManoObra
        '
        Me.LBManoObra.AutoSize = True
        Me.LBManoObra.Location = New System.Drawing.Point(361, 37)
        Me.LBManoObra.Name = "LBManoObra"
        Me.LBManoObra.Size = New System.Drawing.Size(108, 17)
        Me.LBManoObra.TabIndex = 13
        Me.LBManoObra.Text = "Mano de Obra"
        '
        'LISTDescripcion
        '
        Me.LISTDescripcion.Enabled = False
        Me.LISTDescripcion.FormattingEnabled = True
        Me.LISTDescripcion.ItemHeight = 17
        Me.LISTDescripcion.Location = New System.Drawing.Point(113, 57)
        Me.LISTDescripcion.Name = "LISTDescripcion"
        Me.LISTDescripcion.Size = New System.Drawing.Size(234, 157)
        Me.LISTDescripcion.TabIndex = 12
        '
        'LBDescripcion
        '
        Me.LBDescripcion.AutoSize = True
        Me.LBDescripcion.Location = New System.Drawing.Point(133, 37)
        Me.LBDescripcion.Name = "LBDescripcion"
        Me.LBDescripcion.Size = New System.Drawing.Size(94, 17)
        Me.LBDescripcion.TabIndex = 11
        Me.LBDescripcion.Text = "Descripcion"
        '
        'LISTNumeroVenta
        '
        Me.LISTNumeroVenta.Enabled = False
        Me.LISTNumeroVenta.FormattingEnabled = True
        Me.LISTNumeroVenta.ItemHeight = 17
        Me.LISTNumeroVenta.Location = New System.Drawing.Point(7, 57)
        Me.LISTNumeroVenta.Name = "LISTNumeroVenta"
        Me.LISTNumeroVenta.Size = New System.Drawing.Size(101, 157)
        Me.LISTNumeroVenta.TabIndex = 10
        '
        'LBNumeroVenta
        '
        Me.LBNumeroVenta.AutoSize = True
        Me.LBNumeroVenta.Location = New System.Drawing.Point(4, 37)
        Me.LBNumeroVenta.Name = "LBNumeroVenta"
        Me.LBNumeroVenta.Size = New System.Drawing.Size(102, 17)
        Me.LBNumeroVenta.TabIndex = 9
        Me.LBNumeroVenta.Text = "No. de Venta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(944, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.GPVentas)
        Me.Controls.Add(Me.TSOpciones)
        Me.Controls.Add(Me.GPTelas)
        Me.Controls.Add(Me.GPSillones)
        Me.Controls.Add(Me.GPVenta)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SILLONES S.A."
        Me.GPVenta.ResumeLayout(False)
        Me.GPVenta.PerformLayout()
        Me.GPSillones.ResumeLayout(False)
        Me.GPSillones.PerformLayout()
        Me.GPTelas.ResumeLayout(False)
        Me.GPTelas.PerformLayout()
        Me.TSOpciones.ResumeLayout(False)
        Me.TSOpciones.PerformLayout()
        Me.GPVentas.ResumeLayout(False)
        Me.GPVentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBNumero As Label
    Friend WithEvents TBNumero As TextBox
    Friend WithEvents TBSillones As TextBox
    Friend WithEvents LBSillones As Label
    Friend WithEvents GPVenta As GroupBox
    Friend WithEvents GPSillones As GroupBox
    Friend WithEvents RBDoble As RadioButton
    Friend WithEvents RBIndividual As RadioButton
    Friend WithEvents RBSofa As RadioButton
    Friend WithEvents GPTelas As GroupBox
    Friend WithEvents RBCuerina As RadioButton
    Friend WithEvents RBCuero As RadioButton
    Friend WithEvents TSOpciones As ToolStrip
    Friend WithEvents TSGuardar As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSLimpiarEntradas As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents GPVentas As GroupBox
    Friend WithEvents LISTVenta As ListBox
    Friend WithEvents LBVenta As Label
    Friend WithEvents LISTCosto As ListBox
    Friend WithEvents LBCosto As Label
    Friend WithEvents LISTPrecioTela As ListBox
    Friend WithEvents LBPrecioTela As Label
    Friend WithEvents LISTManoObra As ListBox
    Friend WithEvents LBManoObra As Label
    Friend WithEvents LISTDescripcion As ListBox
    Friend WithEvents LBDescripcion As Label
    Friend WithEvents LISTNumeroVenta As ListBox
    Friend WithEvents LBNumeroVenta As Label
End Class
