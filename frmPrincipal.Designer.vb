<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.pnListaClientes = New System.Windows.Forms.Panel
        Me.lbListaCliBuscar = New System.Windows.Forms.Label
        Me.lbTituloListaCli = New System.Windows.Forms.Label
        Me.txtBuscaCli = New System.Windows.Forms.TextBox
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.cbBuscaCli = New System.Windows.Forms.ComboBox
        Me.tcPrincipal = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.dgvCierreCaja = New System.Windows.Forms.DataGridView
        Me.checkMarcaPago = New System.Windows.Forms.CheckBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbTipoVehiculo0 = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.pnReservaHora = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtMatricula = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbEMatricula = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbTipoVehiculo = New System.Windows.Forms.ComboBox
        Me.pnReservaMes = New System.Windows.Forms.Panel
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtMatricula2 = New System.Windows.Forms.TextBox
        Me.txtNombre2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lbENombre2 = New System.Windows.Forms.Label
        Me.checkMarcaPago2 = New System.Windows.Forms.CheckBox
        Me.lbEMatricula2 = New System.Windows.Forms.Label
        Me.txtTelfReserva = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cbTipoVehiculo2 = New System.Windows.Forms.ComboBox
        Me.lbEDocumentoReserva = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbNocturno = New System.Windows.Forms.RadioButton
        Me.rbDiurno = New System.Windows.Forms.RadioButton
        Me.btnSoloLavado = New System.Windows.Forms.Button
        Me.btnReservarMes = New System.Windows.Forms.Button
        Me.btnReservarHora = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.tcReservas = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.dgvReservasHora = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvReservasMes = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lbMontoValor = New System.Windows.Forms.Label
        Me.lbMonto = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvDetalles = New System.Windows.Forms.DataGridView
        Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmConsultar = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmBaja = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmMarcarPago = New System.Windows.Forms.ToolStripMenuItem
        Me.odfAbrirArchivo = New System.Windows.Forms.OpenFileDialog
        Me.btnCancelarRserva = New System.Windows.Forms.Button
        Me.btnFinalizarReserva = New System.Windows.Forms.Button
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument
        Me.btnMarcarPago = New System.Windows.Forms.Button
        Me.msOpciones = New System.Windows.Forms.MenuStrip
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmCierreCaja = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDetalles = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintDocument4 = New System.Drawing.Printing.PrintDocument
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.pnListaClientes.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvCierreCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnReservaHora.SuspendLayout()
        Me.pnReservaMes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tcReservas.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvReservasHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvReservasMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOpciones.SuspendLayout()
        Me.msOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnListaClientes
        '
        Me.pnListaClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnListaClientes.BackColor = System.Drawing.Color.White
        Me.pnListaClientes.Controls.Add(Me.lbListaCliBuscar)
        Me.pnListaClientes.Controls.Add(Me.lbTituloListaCli)
        Me.pnListaClientes.Controls.Add(Me.txtBuscaCli)
        Me.pnListaClientes.Controls.Add(Me.dgvClientes)
        Me.pnListaClientes.Controls.Add(Me.cbBuscaCli)
        Me.pnListaClientes.Location = New System.Drawing.Point(0, 641)
        Me.pnListaClientes.Name = "pnListaClientes"
        Me.pnListaClientes.Size = New System.Drawing.Size(176, 31)
        Me.pnListaClientes.TabIndex = 447
        Me.pnListaClientes.Visible = False
        '
        'lbListaCliBuscar
        '
        Me.lbListaCliBuscar.Location = New System.Drawing.Point(2, 27)
        Me.lbListaCliBuscar.Name = "lbListaCliBuscar"
        Me.lbListaCliBuscar.Size = New System.Drawing.Size(61, 20)
        Me.lbListaCliBuscar.TabIndex = 404
        Me.lbListaCliBuscar.Text = "Buscar por"
        Me.lbListaCliBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lbTituloListaCli
        '
        Me.lbTituloListaCli.AutoSize = True
        Me.lbTituloListaCli.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloListaCli.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbTituloListaCli.Location = New System.Drawing.Point(2, 0)
        Me.lbTituloListaCli.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTituloListaCli.Name = "lbTituloListaCli"
        Me.lbTituloListaCli.Size = New System.Drawing.Size(148, 20)
        Me.lbTituloListaCli.TabIndex = 286
        Me.lbTituloListaCli.Text = "Lista de Clientes"
        '
        'txtBuscaCli
        '
        Me.txtBuscaCli.Location = New System.Drawing.Point(2, 72)
        Me.txtBuscaCli.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscaCli.Name = "txtBuscaCli"
        Me.txtBuscaCli.Size = New System.Drawing.Size(171, 20)
        Me.txtBuscaCli.TabIndex = 388
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeColumns = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.Location = New System.Drawing.Point(2, 97)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(172, 1)
        Me.dgvClientes.TabIndex = 387
        '
        'cbBuscaCli
        '
        Me.cbBuscaCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbBuscaCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscaCli.DropDownWidth = 100
        Me.cbBuscaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBuscaCli.FormattingEnabled = True
        Me.cbBuscaCli.Items.AddRange(New Object() {"C.I.", "pasaporte", "otro "})
        Me.cbBuscaCli.Location = New System.Drawing.Point(3, 49)
        Me.cbBuscaCli.Margin = New System.Windows.Forms.Padding(2)
        Me.cbBuscaCli.Name = "cbBuscaCli"
        Me.cbBuscaCli.Size = New System.Drawing.Size(171, 21)
        Me.cbBuscaCli.TabIndex = 390
        '
        'tcPrincipal
        '
        Me.tcPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPrincipal.Controls.Add(Me.TabPage1)
        Me.tcPrincipal.Controls.Add(Me.TabPage2)
        Me.tcPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcPrincipal.Location = New System.Drawing.Point(1, 34)
        Me.tcPrincipal.Name = "tcPrincipal"
        Me.tcPrincipal.SelectedIndex = 0
        Me.tcPrincipal.Size = New System.Drawing.Size(792, 588)
        Me.tcPrincipal.TabIndex = 448
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Controls.Add(Me.dgvCierreCaja)
        Me.TabPage1.Controls.Add(Me.checkMarcaPago)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.pnReservaHora)
        Me.TabPage1.Controls.Add(Me.pnReservaMes)
        Me.TabPage1.Controls.Add(Me.btnSoloLavado)
        Me.TabPage1.Controls.Add(Me.btnReservarMes)
        Me.TabPage1.Controls.Add(Me.btnReservarHora)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(784, 560)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NUEVA RESERVA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(543, 531)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 543
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 245)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(172, 38)
        Me.RichTextBox1.TabIndex = 542
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'dgvCierreCaja
        '
        Me.dgvCierreCaja.AllowUserToAddRows = False
        Me.dgvCierreCaja.AllowUserToDeleteRows = False
        Me.dgvCierreCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCierreCaja.Location = New System.Drawing.Point(3, 455)
        Me.dgvCierreCaja.Name = "dgvCierreCaja"
        Me.dgvCierreCaja.Size = New System.Drawing.Size(534, 99)
        Me.dgvCierreCaja.TabIndex = 541
        Me.dgvCierreCaja.Visible = False
        '
        'checkMarcaPago
        '
        Me.checkMarcaPago.AutoSize = True
        Me.checkMarcaPago.Location = New System.Drawing.Point(194, 270)
        Me.checkMarcaPago.Name = "checkMarcaPago"
        Me.checkMarcaPago.Size = New System.Drawing.Size(110, 19)
        Me.checkMarcaPago.TabIndex = 536
        Me.checkMarcaPago.Text = "Marca de Pago"
        Me.checkMarcaPago.UseVisualStyleBackColor = True
        Me.checkMarcaPago.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.cbTipoVehiculo0)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Location = New System.Drawing.Point(3, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 85)
        Me.Panel3.TabIndex = 540
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.Label25.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label25.Location = New System.Drawing.Point(22, 2)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 20)
        Me.Label25.TabIndex = 542
        Me.Label25.Text = "Solo Lavado"
        '
        'cbTipoVehiculo0
        '
        Me.cbTipoVehiculo0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbTipoVehiculo0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoVehiculo0.DropDownWidth = 100
        Me.cbTipoVehiculo0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoVehiculo0.FormattingEnabled = True
        Me.cbTipoVehiculo0.Items.AddRange(New Object() {"Camioneta", "Auto", "Moto"})
        Me.cbTipoVehiculo0.Location = New System.Drawing.Point(13, 54)
        Me.cbTipoVehiculo0.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTipoVehiculo0.Name = "cbTipoVehiculo0"
        Me.cbTipoVehiculo0.Size = New System.Drawing.Size(184, 23)
        Me.cbTipoVehiculo0.TabIndex = 540
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label28.Location = New System.Drawing.Point(23, 37)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(174, 15)
        Me.Label28.TabIndex = 541
        Me.Label28.Text = "Seleccione el tipo de vehiculo"
        '
        'pnReservaHora
        '
        Me.pnReservaHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnReservaHora.Controls.Add(Me.Label20)
        Me.pnReservaHora.Controls.Add(Me.txtMatricula)
        Me.pnReservaHora.Controls.Add(Me.Label6)
        Me.pnReservaHora.Controls.Add(Me.lbEMatricula)
        Me.pnReservaHora.Controls.Add(Me.Label24)
        Me.pnReservaHora.Controls.Add(Me.cbTipoVehiculo)
        Me.pnReservaHora.Location = New System.Drawing.Point(214, 117)
        Me.pnReservaHora.Name = "pnReservaHora"
        Me.pnReservaHora.Size = New System.Drawing.Size(281, 143)
        Me.pnReservaHora.TabIndex = 539
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.Label20.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label20.Location = New System.Drawing.Point(94, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(159, 20)
        Me.Label20.TabIndex = 536
        Me.Label20.Text = "Reserva por HORA"
        '
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.White
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(94, 86)
        Me.txtMatricula.MaxLength = 20
        Me.txtMatricula.Multiline = True
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(183, 25)
        Me.txtMatricula.TabIndex = 531
        Me.txtMatricula.Tag = "lbEDocumento"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 40)
        Me.Label6.TabIndex = 530
        Me.Label6.Text = "Matricula :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbEMatricula
        '
        Me.lbEMatricula.BackColor = System.Drawing.Color.White
        Me.lbEMatricula.ForeColor = System.Drawing.Color.Black
        Me.lbEMatricula.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbEMatricula.Location = New System.Drawing.Point(91, 113)
        Me.lbEMatricula.Name = "lbEMatricula"
        Me.lbEMatricula.Size = New System.Drawing.Size(187, 18)
        Me.lbEMatricula.TabIndex = 532
        Me.lbEMatricula.Text = "Error en la matricula ingresada"
        Me.lbEMatricula.Visible = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label24.Location = New System.Drawing.Point(91, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(174, 15)
        Me.Label24.TabIndex = 533
        Me.Label24.Text = "Seleccione el tipo de vehiculo"
        '
        'cbTipoVehiculo
        '
        Me.cbTipoVehiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoVehiculo.DropDownWidth = 100
        Me.cbTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoVehiculo.FormattingEnabled = True
        Me.cbTipoVehiculo.Items.AddRange(New Object() {"Camioneta", "Auto", "Moto"})
        Me.cbTipoVehiculo.Location = New System.Drawing.Point(94, 55)
        Me.cbTipoVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTipoVehiculo.Name = "cbTipoVehiculo"
        Me.cbTipoVehiculo.Size = New System.Drawing.Size(184, 23)
        Me.cbTipoVehiculo.TabIndex = 529
        '
        'pnReservaMes
        '
        Me.pnReservaMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnReservaMes.Controls.Add(Me.Label29)
        Me.pnReservaMes.Controls.Add(Me.Label27)
        Me.pnReservaMes.Controls.Add(Me.txtMatricula2)
        Me.pnReservaMes.Controls.Add(Me.txtNombre2)
        Me.pnReservaMes.Controls.Add(Me.Label18)
        Me.pnReservaMes.Controls.Add(Me.Label4)
        Me.pnReservaMes.Controls.Add(Me.Label21)
        Me.pnReservaMes.Controls.Add(Me.lbENombre2)
        Me.pnReservaMes.Controls.Add(Me.checkMarcaPago2)
        Me.pnReservaMes.Controls.Add(Me.lbEMatricula2)
        Me.pnReservaMes.Controls.Add(Me.txtTelfReserva)
        Me.pnReservaMes.Controls.Add(Me.Label26)
        Me.pnReservaMes.Controls.Add(Me.cbTipoVehiculo2)
        Me.pnReservaMes.Controls.Add(Me.lbEDocumentoReserva)
        Me.pnReservaMes.Controls.Add(Me.Panel2)
        Me.pnReservaMes.Location = New System.Drawing.Point(499, 117)
        Me.pnReservaMes.Name = "pnReservaMes"
        Me.pnReservaMes.Size = New System.Drawing.Size(279, 333)
        Me.pnReservaMes.TabIndex = 538
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(1, 275)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 40)
        Me.Label29.TabIndex = 549
        Me.Label29.Text = "Horario:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(2, 139)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 40)
        Me.Label27.TabIndex = 546
        Me.Label27.Text = "Nombre:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMatricula2
        '
        Me.txtMatricula2.BackColor = System.Drawing.Color.White
        Me.txtMatricula2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMatricula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula2.Location = New System.Drawing.Point(90, 87)
        Me.txtMatricula2.MaxLength = 20
        Me.txtMatricula2.Multiline = True
        Me.txtMatricula2.Name = "txtMatricula2"
        Me.txtMatricula2.Size = New System.Drawing.Size(183, 25)
        Me.txtMatricula2.TabIndex = 542
        Me.txtMatricula2.Tag = "lbEDocumento"
        '
        'txtNombre2
        '
        Me.txtNombre2.BackColor = System.Drawing.Color.White
        Me.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(91, 139)
        Me.txtNombre2.MaxLength = 90
        Me.txtNombre2.Multiline = True
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(184, 25)
        Me.txtNombre2.TabIndex = 547
        Me.txtNombre2.Tag = "lbEDocumento"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.Label18.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label18.Location = New System.Drawing.Point(87, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 20)
        Me.Label18.TabIndex = 535
        Me.Label18.Text = "Reserva por MES"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 40)
        Me.Label4.TabIndex = 526
        Me.Label4.Text = "Telefono:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(20, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 40)
        Me.Label21.TabIndex = 541
        Me.Label21.Text = "Matricula :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbENombre2
        '
        Me.lbENombre2.BackColor = System.Drawing.Color.White
        Me.lbENombre2.ForeColor = System.Drawing.Color.Black
        Me.lbENombre2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbENombre2.Location = New System.Drawing.Point(92, 167)
        Me.lbENombre2.Name = "lbENombre2"
        Me.lbENombre2.Size = New System.Drawing.Size(183, 15)
        Me.lbENombre2.TabIndex = 548
        Me.lbENombre2.Text = "No puede dejar vacio el cuadro"
        Me.lbENombre2.Visible = False
        '
        'checkMarcaPago2
        '
        Me.checkMarcaPago2.AutoSize = True
        Me.checkMarcaPago2.Location = New System.Drawing.Point(85, 247)
        Me.checkMarcaPago2.Name = "checkMarcaPago2"
        Me.checkMarcaPago2.Size = New System.Drawing.Size(110, 19)
        Me.checkMarcaPago2.TabIndex = 545
        Me.checkMarcaPago2.Text = "Marca de Pago"
        Me.checkMarcaPago2.UseVisualStyleBackColor = True
        '
        'lbEMatricula2
        '
        Me.lbEMatricula2.BackColor = System.Drawing.Color.White
        Me.lbEMatricula2.ForeColor = System.Drawing.Color.Black
        Me.lbEMatricula2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbEMatricula2.Location = New System.Drawing.Point(87, 114)
        Me.lbEMatricula2.Name = "lbEMatricula2"
        Me.lbEMatricula2.Size = New System.Drawing.Size(187, 18)
        Me.lbEMatricula2.TabIndex = 543
        Me.lbEMatricula2.Text = "Error en la matricula ingresada"
        Me.lbEMatricula2.Visible = False
        '
        'txtTelfReserva
        '
        Me.txtTelfReserva.BackColor = System.Drawing.Color.White
        Me.txtTelfReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelfReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelfReserva.Location = New System.Drawing.Point(91, 193)
        Me.txtTelfReserva.MaxLength = 90
        Me.txtTelfReserva.Multiline = True
        Me.txtTelfReserva.Name = "txtTelfReserva"
        Me.txtTelfReserva.Size = New System.Drawing.Size(184, 25)
        Me.txtTelfReserva.TabIndex = 527
        Me.txtTelfReserva.Tag = "lbEDocumento"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label26.Location = New System.Drawing.Point(87, 39)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(174, 15)
        Me.Label26.TabIndex = 544
        Me.Label26.Text = "Seleccione el tipo de vehiculo"
        '
        'cbTipoVehiculo2
        '
        Me.cbTipoVehiculo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbTipoVehiculo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoVehiculo2.DropDownWidth = 100
        Me.cbTipoVehiculo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoVehiculo2.FormattingEnabled = True
        Me.cbTipoVehiculo2.Items.AddRange(New Object() {"Camioneta", "Auto", "Moto"})
        Me.cbTipoVehiculo2.Location = New System.Drawing.Point(90, 56)
        Me.cbTipoVehiculo2.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTipoVehiculo2.Name = "cbTipoVehiculo2"
        Me.cbTipoVehiculo2.Size = New System.Drawing.Size(184, 23)
        Me.cbTipoVehiculo2.TabIndex = 540
        '
        'lbEDocumentoReserva
        '
        Me.lbEDocumentoReserva.BackColor = System.Drawing.Color.White
        Me.lbEDocumentoReserva.ForeColor = System.Drawing.Color.Black
        Me.lbEDocumentoReserva.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbEDocumentoReserva.Location = New System.Drawing.Point(92, 221)
        Me.lbEDocumentoReserva.Name = "lbEDocumentoReserva"
        Me.lbEDocumentoReserva.Size = New System.Drawing.Size(183, 15)
        Me.lbEDocumentoReserva.TabIndex = 528
        Me.lbEDocumentoReserva.Text = "No puede dejar vacio el cuadro"
        Me.lbEDocumentoReserva.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbNocturno)
        Me.Panel2.Controls.Add(Me.rbDiurno)
        Me.Panel2.Location = New System.Drawing.Point(85, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 44)
        Me.Panel2.TabIndex = 534
        '
        'rbNocturno
        '
        Me.rbNocturno.AutoSize = True
        Me.rbNocturno.Location = New System.Drawing.Point(4, 25)
        Me.rbNocturno.Name = "rbNocturno"
        Me.rbNocturno.Size = New System.Drawing.Size(75, 19)
        Me.rbNocturno.TabIndex = 1
        Me.rbNocturno.TabStop = True
        Me.rbNocturno.Text = "Nocturno"
        Me.rbNocturno.UseVisualStyleBackColor = True
        '
        'rbDiurno
        '
        Me.rbDiurno.AutoSize = True
        Me.rbDiurno.Location = New System.Drawing.Point(3, 3)
        Me.rbDiurno.Name = "rbDiurno"
        Me.rbDiurno.Size = New System.Drawing.Size(62, 19)
        Me.rbDiurno.TabIndex = 0
        Me.rbDiurno.TabStop = True
        Me.rbDiurno.Text = "Diurno"
        Me.rbDiurno.UseVisualStyleBackColor = True
        '
        'btnSoloLavado
        '
        Me.btnSoloLavado.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSoloLavado.FlatAppearance.BorderSize = 0
        Me.btnSoloLavado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnSoloLavado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSoloLavado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSoloLavado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoloLavado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSoloLavado.Location = New System.Drawing.Point(32, 208)
        Me.btnSoloLavado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSoloLavado.Name = "btnSoloLavado"
        Me.btnSoloLavado.Size = New System.Drawing.Size(140, 26)
        Me.btnSoloLavado.TabIndex = 535
        Me.btnSoloLavado.Text = "Realizar solo LAVADO"
        Me.btnSoloLavado.UseVisualStyleBackColor = False
        '
        'btnReservarMes
        '
        Me.btnReservarMes.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReservarMes.FlatAppearance.BorderSize = 0
        Me.btnReservarMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnReservarMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnReservarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservarMes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReservarMes.Location = New System.Drawing.Point(585, 455)
        Me.btnReservarMes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservarMes.Name = "btnReservarMes"
        Me.btnReservarMes.Size = New System.Drawing.Size(142, 26)
        Me.btnReservarMes.TabIndex = 524
        Me.btnReservarMes.Text = "Reservar Por un Mes"
        Me.btnReservarMes.UseVisualStyleBackColor = False
        '
        'btnReservarHora
        '
        Me.btnReservarHora.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReservarHora.FlatAppearance.BorderSize = 0
        Me.btnReservarHora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnReservarHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnReservarHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservarHora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReservarHora.Location = New System.Drawing.Point(309, 265)
        Me.btnReservarHora.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservarHora.Name = "btnReservarHora"
        Me.btnReservarHora.Size = New System.Drawing.Size(142, 26)
        Me.btnReservarHora.TabIndex = 525
        Me.btnReservarHora.Text = "Reservar Por una Hora"
        Me.btnReservarHora.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(26, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 20)
        Me.Label10.TabIndex = 405
        Me.Label10.Text = "Creación de Reserva"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.tcReservas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(784, 560)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reservas y Historial"
        '
        'tcReservas
        '
        Me.tcReservas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcReservas.Controls.Add(Me.TabPage4)
        Me.tcReservas.Controls.Add(Me.TabPage5)
        Me.tcReservas.Controls.Add(Me.TabPage3)
        Me.tcReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcReservas.Location = New System.Drawing.Point(3, 3)
        Me.tcReservas.Name = "tcReservas"
        Me.tcReservas.SelectedIndex = 0
        Me.tcReservas.Size = New System.Drawing.Size(773, 574)
        Me.tcReservas.TabIndex = 486
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.dgvReservasHora)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(765, 546)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "RESERVAS POR HORA"
        '
        'dgvReservasHora
        '
        Me.dgvReservasHora.AllowUserToAddRows = False
        Me.dgvReservasHora.AllowUserToDeleteRows = False
        Me.dgvReservasHora.AllowUserToResizeColumns = False
        Me.dgvReservasHora.AllowUserToResizeRows = False
        Me.dgvReservasHora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReservasHora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservasHora.BackgroundColor = System.Drawing.Color.White
        Me.dgvReservasHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReservasHora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReservasHora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvReservasHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservasHora.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReservasHora.Location = New System.Drawing.Point(5, 43)
        Me.dgvReservasHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReservasHora.MultiSelect = False
        Me.dgvReservasHora.Name = "dgvReservasHora"
        Me.dgvReservasHora.ReadOnly = True
        Me.dgvReservasHora.RowHeadersVisible = False
        Me.dgvReservasHora.RowTemplate.Height = 24
        Me.dgvReservasHora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservasHora.Size = New System.Drawing.Size(754, 444)
        Me.dgvReservasHora.TabIndex = 546
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(2, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 20)
        Me.Label8.TabIndex = 407
        Me.Label8.Text = "Reserva por Hora"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.dgvReservasMes)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(765, 546)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "RESERVAS POR MES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(2, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 20)
        Me.Label2.TabIndex = 409
        Me.Label2.Text = "Reservas Mensuales"
        '
        'dgvReservasMes
        '
        Me.dgvReservasMes.AllowUserToAddRows = False
        Me.dgvReservasMes.AllowUserToDeleteRows = False
        Me.dgvReservasMes.AllowUserToResizeColumns = False
        Me.dgvReservasMes.AllowUserToResizeRows = False
        Me.dgvReservasMes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReservasMes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservasMes.BackgroundColor = System.Drawing.Color.White
        Me.dgvReservasMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReservasMes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReservasMes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvReservasMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservasMes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReservasMes.Location = New System.Drawing.Point(5, 43)
        Me.dgvReservasMes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReservasMes.MultiSelect = False
        Me.dgvReservasMes.Name = "dgvReservasMes"
        Me.dgvReservasMes.ReadOnly = True
        Me.dgvReservasMes.RowHeadersVisible = False
        Me.dgvReservasMes.RowTemplate.Height = 24
        Me.dgvReservasMes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservasMes.Size = New System.Drawing.Size(754, 444)
        Me.dgvReservasMes.TabIndex = 408
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.lbMontoValor)
        Me.TabPage3.Controls.Add(Me.lbMonto)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.dgvDetalles)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(765, 546)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DETALLES"
        '
        'lbMontoValor
        '
        Me.lbMontoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMontoValor.AutoSize = True
        Me.lbMontoValor.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoValor.ForeColor = System.Drawing.Color.Black
        Me.lbMontoValor.Location = New System.Drawing.Point(592, 472)
        Me.lbMontoValor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMontoValor.Name = "lbMontoValor"
        Me.lbMontoValor.Size = New System.Drawing.Size(26, 26)
        Me.lbMontoValor.TabIndex = 411
        Me.lbMontoValor.Text = "0"
        Me.lbMontoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMonto
        '
        Me.lbMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMonto.AutoSize = True
        Me.lbMonto.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMonto.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbMonto.Location = New System.Drawing.Point(405, 478)
        Me.lbMonto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMonto.Name = "lbMonto"
        Me.lbMonto.Size = New System.Drawing.Size(183, 20)
        Me.lbMonto.TabIndex = 410
        Me.lbMonto.Text = "Monto Recaudado : $"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Detalles"
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.AllowUserToResizeColumns = False
        Me.dgvDetalles.AllowUserToResizeRows = False
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalles.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalles.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDetalles.Location = New System.Drawing.Point(5, 43)
        Me.dgvDetalles.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDetalles.MultiSelect = False
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.RowHeadersVisible = False
        Me.dgvDetalles.RowTemplate.Height = 24
        Me.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalles.Size = New System.Drawing.Size(754, 412)
        Me.dgvDetalles.TabIndex = 408
        '
        'cmsOpciones
        '
        Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmConsultar, Me.tsmBaja, Me.tsmMarcarPago})
        Me.cmsOpciones.Name = "cmsOpciones"
        Me.cmsOpciones.Size = New System.Drawing.Size(163, 70)
        '
        'tsmConsultar
        '
        Me.tsmConsultar.Name = "tsmConsultar"
        Me.tsmConsultar.Size = New System.Drawing.Size(162, 22)
        Me.tsmConsultar.Text = "Consultar"
        Me.tsmConsultar.Visible = False
        '
        'tsmBaja
        '
        Me.tsmBaja.Name = "tsmBaja"
        Me.tsmBaja.Size = New System.Drawing.Size(162, 22)
        Me.tsmBaja.Text = "Dar de Baja"
        Me.tsmBaja.Visible = False
        '
        'tsmMarcarPago
        '
        Me.tsmMarcarPago.Name = "tsmMarcarPago"
        Me.tsmMarcarPago.Size = New System.Drawing.Size(162, 22)
        Me.tsmMarcarPago.Text = "Marcar como Pago"
        '
        'odfAbrirArchivo
        '
        Me.odfAbrirArchivo.FileName = "OpenFileDialog1"
        '
        'btnCancelarRserva
        '
        Me.btnCancelarRserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarRserva.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCancelarRserva.FlatAppearance.BorderSize = 0
        Me.btnCancelarRserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnCancelarRserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnCancelarRserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarRserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarRserva.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelarRserva.Location = New System.Drawing.Point(663, 627)
        Me.btnCancelarRserva.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarRserva.Name = "btnCancelarRserva"
        Me.btnCancelarRserva.Size = New System.Drawing.Size(119, 26)
        Me.btnCancelarRserva.TabIndex = 526
        Me.btnCancelarRserva.Text = "Cancelar Reserva"
        Me.btnCancelarRserva.UseVisualStyleBackColor = False
        Me.btnCancelarRserva.Visible = False
        '
        'btnFinalizarReserva
        '
        Me.btnFinalizarReserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizarReserva.BackColor = System.Drawing.Color.SeaGreen
        Me.btnFinalizarReserva.FlatAppearance.BorderSize = 0
        Me.btnFinalizarReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnFinalizarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnFinalizarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFinalizarReserva.Location = New System.Drawing.Point(519, 627)
        Me.btnFinalizarReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinalizarReserva.Name = "btnFinalizarReserva"
        Me.btnFinalizarReserva.Size = New System.Drawing.Size(119, 26)
        Me.btnFinalizarReserva.TabIndex = 527
        Me.btnFinalizarReserva.Text = "Finalizar Reserva"
        Me.btnFinalizarReserva.UseVisualStyleBackColor = False
        Me.btnFinalizarReserva.Visible = False
        '
        'PrintDocument3
        '
        '
        'btnMarcarPago
        '
        Me.btnMarcarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarcarPago.BackColor = System.Drawing.Color.SeaGreen
        Me.btnMarcarPago.FlatAppearance.BorderSize = 0
        Me.btnMarcarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnMarcarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMarcarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcarPago.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMarcarPago.Location = New System.Drawing.Point(346, 627)
        Me.btnMarcarPago.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMarcarPago.Name = "btnMarcarPago"
        Me.btnMarcarPago.Size = New System.Drawing.Size(142, 26)
        Me.btnMarcarPago.TabIndex = 528
        Me.btnMarcarPago.Text = "Marcar como Pago"
        Me.btnMarcarPago.UseVisualStyleBackColor = False
        Me.btnMarcarPago.Visible = False
        '
        'msOpciones
        '
        Me.msOpciones.BackColor = System.Drawing.Color.White
        Me.msOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.msOpciones.Location = New System.Drawing.Point(0, 0)
        Me.msOpciones.Name = "msOpciones"
        Me.msOpciones.Size = New System.Drawing.Size(793, 24)
        Me.msOpciones.TabIndex = 542
        Me.msOpciones.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCierreCaja, Me.tsmDetalles})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'tsmCierreCaja
        '
        Me.tsmCierreCaja.Name = "tsmCierreCaja"
        Me.tsmCierreCaja.Size = New System.Drawing.Size(143, 22)
        Me.tsmCierreCaja.Text = "Cierre de Caja"
        '
        'tsmDetalles
        '
        Me.tsmDetalles.Name = "tsmDetalles"
        Me.tsmDetalles.Size = New System.Drawing.Size(143, 22)
        Me.tsmDetalles.Text = "Detalles"
        '
        'PrintDocument4
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument3
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(793, 655)
        Me.Controls.Add(Me.msOpciones)
        Me.Controls.Add(Me.btnMarcarPago)
        Me.Controls.Add(Me.btnFinalizarReserva)
        Me.Controls.Add(Me.btnCancelarRserva)
        Me.Controls.Add(Me.pnListaClientes)
        Me.Controls.Add(Me.tcPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msOpciones
        Me.Name = "frmPrincipal"
        Me.Text = "Gestion de Estacionamiento"
        Me.pnListaClientes.ResumeLayout(False)
        Me.pnListaClientes.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvCierreCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnReservaHora.ResumeLayout(False)
        Me.pnReservaHora.PerformLayout()
        Me.pnReservaMes.ResumeLayout(False)
        Me.pnReservaMes.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.tcReservas.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvReservasHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvReservasMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOpciones.ResumeLayout(False)
        Me.msOpciones.ResumeLayout(False)
        Me.msOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnListaClientes As System.Windows.Forms.Panel
    Friend WithEvents lbListaCliBuscar As System.Windows.Forms.Label
    Friend WithEvents lbTituloListaCli As System.Windows.Forms.Label
    Friend WithEvents txtBuscaCli As System.Windows.Forms.TextBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents cbBuscaCli As System.Windows.Forms.ComboBox
    Friend WithEvents tcPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmsOpciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmBaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcReservas As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvReservasMes As System.Windows.Forms.DataGridView
    Friend WithEvents lbEDocumentoReserva As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelfReserva As System.Windows.Forms.TextBox
    Friend WithEvents btnReservarHora As System.Windows.Forms.Button
    Friend WithEvents btnReservarMes As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbTipoVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents lbEMatricula As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbNocturno As System.Windows.Forms.RadioButton
    Friend WithEvents rbDiurno As System.Windows.Forms.RadioButton
    Friend WithEvents btnSoloLavado As System.Windows.Forms.Button
    Friend WithEvents checkMarcaPago As System.Windows.Forms.CheckBox
    Friend WithEvents pnReservaMes As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents pnReservaHora As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula2 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents checkMarcaPago2 As System.Windows.Forms.CheckBox
    Friend WithEvents lbEMatricula2 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbTipoVehiculo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents lbENombre2 As System.Windows.Forms.Label
    Friend WithEvents odfAbrirArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbTipoVehiculo0 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelarRserva As System.Windows.Forms.Button
    Friend WithEvents btnFinalizarReserva As System.Windows.Forms.Button
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnMarcarPago As System.Windows.Forms.Button
    Friend WithEvents tsmMarcarPago As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msOpciones As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCierreCaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDetalles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument4 As System.Drawing.Printing.PrintDocument
    Friend WithEvents dgvCierreCaja As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents lbMontoValor As System.Windows.Forms.Label
    Friend WithEvents lbMonto As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvReservasHora As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
