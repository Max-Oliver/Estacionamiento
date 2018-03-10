Public Class frmPrincipal

    Dim comando As String
    Dim numTik As Integer
    Dim matricula As String
    Dim tipo As String
    Dim tiporeserva As String
    Dim costo As Integer

    Dim horSalida As String
    Dim horaEntrada As DateTime
    Dim fehaInicio As DateTime

    Dim momentoFinal As DateTime
    Dim momentoInicial As DateTime
    Dim diferencia As DateTime

    Dim mediasHoras As Integer

    Dim hora As Integer
    Dim horaMinimo As Integer
    Dim horaLimite As Integer

    Dim opc As Integer

    Dim imprimir As Boolean = True

    Dim difIni As Func(Of TimeSpan, TimeSpan) = Function(s) New TimeSpan(20, 0, 0).Subtract(s)
    Dim difFin As Func(Of TimeSpan, TimeSpan) = Function(s) s.Subtract(New TimeSpan(8, 0, 0))
    Dim mediasH As Func(Of TimeSpan, Integer) = Function(s) (Int((Int(s.Hours) * 60) / 30)) + Int(Int(s.Minutes + 10) / 30)

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvDetalles.SelectionMode = Nothing
        cbBuscaCli.SelectedIndex = 0
        cbTipoVehiculo0.SelectedIndex = 0
        cbTipoVehiculo.SelectedIndex = 0
        cbTipoVehiculo2.SelectedIndex = 0
        rbDiurno.Checked = True
        '////////////////////
        cargarDgv(dgvReservasHora, 1)
        cargarDgv(dgvReservasMes, 1)
    End Sub

    'Cargar DGV: todas las sentencias a usar
    Public Sub cargarDgv(ByVal dgv As DataGridView, ByVal index As Integer)
        dgv.Columns.Clear()
        Select Case dgv.Name
            Case "dgvReservasHora"
                comando = "select r.id, v.tipovehiculo, r.matricula, r.horainicio, r.fechainicio from reserva r, tipovehiculo v where r.tiporeserva=1 and r.estado=True and matricula<>'NO' and r.tipovehiculo=v.id"
            Case "dgvReservasMes"
                comando = "select r.id, v.tipovehiculo, r.matricula, r.horainicio, r.fechainicio, r.horario, r.telefono, r.marcadepago from reserva r, tipovehiculo v where tiporeserva=2 and estado=True and r.tipovehiculo=v.id"
        End Select
        consulta(dgv, comando)

        verificaVacio(dgv)
    End Sub

    Private Sub PrintDocument3_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim prFont As New Font("Arial", 15, FontStyle.Bold)
        Select Case opc
            Case 1
                'Inicio de Redaccion de la Factura
                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("   Estacionamiento 'El Angelito'", prFont, Brushes.Black, 15, 20)
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("         Documento para calculo de horario", prFont, Brushes.Black, 10, 40)
                'imprimimos DATOS
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("       TREINTA Y TRES 1535    TEL: 2916-58-03", prFont, Brushes.Black, 10, 55)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 70)
                'prFont = New Font("Arial", 12, FontStyle.Bold)
                'e.Graphics.DrawString("Tiket N° " & numTik, prFont, Brushes.Black, 15, 85)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 120)

                'imprimimos entrada y salida
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString(" Inicio: " & fehaInicio & " " & horaEntrada.TimeOfDay.ToString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 140)
                e.Graphics.DrawString(" Final : " & Today & " " & TimeString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 160)

                '------------------------------------------------------------

                'Tipo y costo
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString("        " & tipo, prFont, Brushes.Black, 15, 200)
                '------------------------

                'imprimimos la matricula
                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("        Reserva :     " & tiporeserva, prFont, Brushes.Black, 20, 100)
                e.Graphics.DrawString(" MATRICULA :  " & matricula, prFont, Brushes.Black, 15, 220)
                prFont = New Font("Arial", 20, FontStyle.Bold)
                e.Graphics.DrawString("     Costo: $ " & costo, prFont, Brushes.Black, 15, 240)

                'mensaje de gracias
                prFont = New Font("Arial", 15, FontStyle.Regular)
                e.Graphics.DrawString("   ---< ¡Muchas Gracias! >---", prFont, Brushes.Black, 15, 285)

                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
            Case 2
                'Try
                prFont = New Font("Arial", 15, FontStyle.Bold)

                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("   Estacionamiento 'El Angelito'", prFont, Brushes.Black, 15, 20)
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("         Documento para calculo de horario", prFont, Brushes.Black, 10, 40)
                'imprimimos DATOS
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("       TREINTA Y TRES 1535    TEL: 2916-58-03", prFont, Brushes.Black, 10, 55)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 70)
                ' prFont = New Font("Arial", 12, FontStyle.Bold)
                ' e.Graphics.DrawString("Tiket N° " & numTik, prFont, Brushes.Black, 10, 85)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 120)

                'imprimimos entrada y salida
                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString(" Inicio: " & Today & " " & TimeString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 140)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 165)
                'Tipo y costo
                prFont = New Font("Arial", 20, FontStyle.Bold)
                e.Graphics.DrawString("      " & tipo, prFont, Brushes.Black, 15, 190)
                '------------------------
                If (matricula = "NO") Then
                    prFont = New Font("Arial", 20, FontStyle.Bold)
                    e.Graphics.DrawString("          LAVADO ", prFont, Brushes.Black, 20, 90)
                    prFont = New Font("Arial", 20, FontStyle.Bold)
                    e.Graphics.DrawString("        Costo: $   " & costo, prFont, Brushes.Black, 20, 220)

                Else
                    e.HasMorePages = False
                    'imprimimos la matricula
                    prFont = New Font("Arial", 10, FontStyle.Bold)
                    e.Graphics.DrawString(" Reserva   :   " & tiporeserva, prFont, Brushes.Black, 15, 95)
                    e.Graphics.DrawString(" MATRICULA :  " & matricula, prFont, Brushes.Black, 15, 220)
                    prFont = New Font("Arial", 15, FontStyle.Bold)
                End If

                'mensaje de gracias
                prFont = New Font("Arial", 15, FontStyle.Regular)
                e.Graphics.DrawString("   ---< ¡Muchas Gracias! >---", prFont, Brushes.Black, 15, 250)

                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
            Case 3
                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

                'Inicio de Redaccion de la Factura
                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("   Estacionamiento 'El Angelito'", prFont, Brushes.Black, 15, 20)
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("         Documento para calculo de horario", prFont, Brushes.Black, 10, 40)
                'imprimimos DATOS
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("       TREINTA Y TRES 1535    TEL: 2916-58-03", prFont, Brushes.Black, 10, 55)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 70)
                ' prFont = New Font("Arial", 12, FontStyle.Bold)
                'e.Graphics.DrawString("Tiket N° " & numTik, prFont, Brushes.Black, 15, 85)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 120)

                'imprimimos entrada y salida
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString(" Inicio: " & fehaInicio & " " & horaEntrada.TimeOfDay.ToString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 140)
                e.Graphics.DrawString(" Final : " & Today & " " & TimeString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 160)

                '------------------------------------------------------------

                'Tipo y costo
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString("      " & tipo, prFont, Brushes.Black, 15, 190)
                '------------------------

                'imprimimos la matricula
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString("        Reserva :   " & tiporeserva, prFont, Brushes.Black, 20, 95)
                e.Graphics.DrawString("     MATRICULA :  " & matricula, prFont, Brushes.Black, 15, 220)
                prFont = New Font("Arial", 20, FontStyle.Bold)
                e.Graphics.DrawString("         Costo: $ " & costo, prFont, Brushes.Black, 15, 240)

                'mensaje de gracias
                prFont = New Font("Arial", 12, FontStyle.Regular)
                e.Graphics.DrawString("   ---< ¡Muchas Gracias! >---", prFont, Brushes.Black, 15, 285)

                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
            Case 4
                Dim varOpc As Object
                Dim coo As Point = New Point(15, 85)
                Dim total As Integer = 0

                'imprimimos el nombre de la empresa
                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("   Estacionamiento 'El Angelito'", prFont, Brushes.Black, 15, 20)
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("         Documento para calculo de horario", prFont, Brushes.Black, 10, 40)
                'imprimimos DATOS
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("       TREINTA Y TRES 1535    TEL: 2916-58-03", prFont, Brushes.Black, 10, 55)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 70)

                coo.Y = coo.Y + 15
                escribir(e, "Fecha :" & Today.Date, 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                coo.Y = coo.Y + 15
                escribir(e, "______________________________________________", 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                coo.Y = coo.Y + 15
                For i As Integer = 0 To dgvCierreCaja.RowCount - 1
                    'MessageBox.Show("Inica For")
                    numTik = dgvCierreCaja.Rows(i).Cells(0).Value

                    tipo = retornoCelda("select v.tipovehiculo from tipovehiculo v, reserva r where r.id=" & numTik & " and v.id=r.tipovehiculo", "tipovehiculo")
                    'Dim tipo1 As String = dgvCierreCaja.Rows(i).Cells(2).Value.ToString

                    matricula = dgvCierreCaja.Rows(i).Cells(4).Value.ToString

                    horaEntrada = dgvCierreCaja.Rows(i).Cells(5).Value
                    horSalida = dgvCierreCaja.Rows(i).Cells(6).Value

                    costo = dgvCierreCaja.Rows(i).Cells(9).Value

                    If (dgvCierreCaja.Rows(i).Cells(7).Value.ToString = Format(Now, "dd/MM/yyyy").ToString) Or (dgvCierreCaja.Rows(i).Cells(8).Value.ToString = Format(Now, "dd/MM/yyyy").ToString And dgvCierreCaja.Rows(i).Cells(11).Value = False) Then
                        total = total + costo
                    End If

                    ' Try

                    If horSalida = "NO" Then
                        varOpc = New String("NO")
                        If matricula = "NO" Then
                            coo.Y = coo.Y + 15
                            escribir(e, "Lavado " & tipo & " : $" & costo, 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                            coo.Y = coo.Y + 10
                            escribir(e, "______________________________________________", 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                            coo.Y = coo.Y + 15

                        ElseIf dgvCierreCaja.Rows(i).Cells(1).Value = 2 Then

                            If dgvCierreCaja.Rows(i).Cells(11).Value = True And (dgvCierreCaja.Rows(i).Cells(7).Value = Today.Date) Then
                                coo.Y = coo.Y + 15
                                escribir(e, "Reserva Mes " & tipo & " : $" & costo, 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                                coo.Y = coo.Y + 10
                                escribir(e, "______________________________________________", 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                                coo.Y = coo.Y + 15
                            End If

                        End If
                    Else
                        'MessageBox.Show(horSalida.ToString)
                        horSalida = horSalida.Remove(5)

                        Dim horaFin As DateTime = horSalida
                        'Dim horaEntrada1 As DateTime = horaEntrada

                        Dim horaEntradacial As New TimeSpan(horaEntrada.Hour, horaEntrada.Minute, horaEntrada.Second)
                        Dim horaFinal As New TimeSpan(horaFin.Hour, horaFin.Minute, horaFin.Second)

                        Dim diferencia As TimeSpan = horaFinal.Subtract(horaEntradacial)

                        varOpc = New String(diferencia.ToString().Remove(5))

                        'escribir(e, "Tiket Nro:" & numTik, 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                        coo.Y = coo.Y + 15
                        escribir(e, "Tipo|Matricula|H.Entrada|H.Salida|Dif|Costo", 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                        coo.Y = coo.Y + 15
                        escribir(e, tipo & "|" & matricula & "|" & horaEntrada & "|" & horSalida & "|" & varOpc.ToString & "|$" & costo, 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                        coo.Y = coo.Y + 10
                        escribir(e, "______________________________________________", 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                        coo.Y = coo.Y + 15
                        '//////////////

                    End If
                Next
                '/////////////////////
                'Tipo y costo
                prFont = New Font("Arial", 20, FontStyle.Bold)
                coo.X = 15
                e.Graphics.DrawString("Total: $ " & total, prFont, Brushes.Black, coo.X, coo.Y)
                coo.Y = coo.Y + 35
                escribir(e, "______________________________________________", 8, FontStyle.Bold, New Point(coo.X, coo.Y))
                'mensaje de gracias
            Case 5
                'Inicio de Redaccion de la Factura
                prFont = New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("   Estacionamiento 'El Angelito'", prFont, Brushes.Black, 15, 20)
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("         Documento para calculo de horario", prFont, Brushes.Black, 10, 40)
                'imprimimos DATOS
                prFont = New Font("Arial", 8, FontStyle.Bold)
                e.Graphics.DrawString("       TREINTA Y TRES 1535    TEL: 2916-58-03", prFont, Brushes.Black, 10, 55)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 70)
                'prFont = New Font("Arial", 12, FontStyle.Bold)
                'e.Graphics.DrawString("Tiket N° " & numTik, prFont, Brushes.Black, 15, 85)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 120)

                'imprimimos entrada y salida
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString(" Inicio: " & fehaInicio & " " & horaEntrada.TimeOfDay.ToString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 140)
                e.Graphics.DrawString(" Final : " & Today & " " & TimeString.Remove(5) & " hrs", prFont, Brushes.Black, 15, 160)

                'DIVISIONES
                prFont = New Font("Arial", 15, FontStyle.Bold)
                e.Graphics.DrawString("***************************************", prFont, Brushes.Black, 10, 180)
                '------------------------------------------------------------

                'Tipo y costo
                prFont = New Font("Arial", 13, FontStyle.Bold)
                e.Graphics.DrawString(" Tipo : " & tipo, prFont, Brushes.Black, 15, 200)
                '------------------------

                'imprimimos la matricula
                prFont = New Font("Arial", 10, FontStyle.Bold)
                e.Graphics.DrawString(" Reserva   : " & tiporeserva, prFont, Brushes.Black, 15, 100)
                e.Graphics.DrawString("  MATRICULA : " & matricula, prFont, Brushes.Black, 15, 220)
                prFont = New Font("Arial", 20, FontStyle.Bold)
                e.Graphics.DrawString(" Costo: $ " & costo, prFont, Brushes.Black, 15, 240)

                'mensaje de gracias
                prFont = New Font("Arial", 15, FontStyle.Regular)
                e.Graphics.DrawString("   ---< ¡Muchas Gracias! >---", prFont, Brushes.Black, 15, 285)
        End Select
        e.HasMorePages = False

    End Sub

    Private Sub PrintDocument4_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument4.PrintPage

    End Sub

    Public Sub verificaVacio(ByVal dgv As DataGridView) 'Añade una fila que indica la aucencia de contenido
        If dgv.Rows.Count = 0 Then
            dgv.DataSource = Nothing 'Quita el enlace a datos
            dgv.Columns.Add("Column1", "")
            dgv.Rows.Add("No hay " & dgv.Name.Replace("dgv", ""))
        End If
    End Sub

    Private Sub txtDocumentoReserva_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTelfReserva.KeyPress
        'If tsmTipoDoc.Tag = 0 Then
        'txtTelfReserva.MaxLength = 10
        Metodos.AceptaNumeros(e, 0, 0, 1, 1)
    End Sub

    '------------------------
    ' muestra o oculta los mensajes de error
    '------------------------
    Private Sub textBoxsError(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre2.Click, txtTelfReserva.Click, txtMatricula2.Click
        If TypeOf sender Is ToolStripMenuItem Then
            sender.backcolor = Color.FromArgb(224, 224, 224)
        Else
            sender.BackColor = Color.White
        End If
    End Sub

    Private Sub txtMatricula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatricula.KeyPress, txtMatricula2.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = e.KeyChar.ToString.ToUpper()
        End If

        'If sender.Text.Length < 3 Then
        '    AceptaNumeros(e, 1, 0, 0, 0)
        'Else
        '    AceptaNumeros(e, 0, 0, 1, 1)
        'End If
    End Sub

    Private Sub btnReservarHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservarHora.Click
        If Metodos.validator(pnReservaHora) Then
            Dim momento As String = Format(Now, "HH:mm:ss")
            '! verificar opciones seleccionadas
            tipo = retornoCelda("select id from tipovehiculo where tipovehiculo='" & cbTipoVehiculo.Text & "'", "id")

            comando = "insert into reserva(horafin,costo,tiporeserva,tipovehiculo,matricula,marcadepago,horainicio,fechainicio,estado,documento,fechafin) values("
            comando += "'NO',0,1,'" & tipo & "','" & txtMatricula.Text & "'," & checkMarcaPago.Checked & ",'" & Format(Now, "HH:mm:ss") & "','" & Format(Now, "dd/MM/yyyy") & "',True,'NO','NO')"

            ejecutarSql(comando)

            costo = retornoCelda("Select p.lavado from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & cbTipoVehiculo0.Text & "'", "lavado")

            MessageBox.Show("Reserva creada con Éxito")
            cargarDgv(dgvReservasHora, 1)
            matricula = txtMatricula.Text

            'actualizacion de variables Publicas
            actualizarValores(0, momento)

            'calculo de costo
            'calcularCosto(numTik)
            'Tikets
            opc = 2
            If imprimir = True Then
                If MessageBox.Show("Quiere Tiket?", "Opciones de Tiket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    PrintDocument3.Print()
                    PrintDocument3.Print()
                End If
                '
            End If
            'Limpieza del panel
            txtMatricula.Text = ""
            cbTipoVehiculo.SelectedIndex = 0
            checkMarcaPago.Checked = False
        End If
    End Sub

    Private Sub btnReservarMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservarMes.Click
        lbEMatricula2.Visible = False
        If txtMatricula2.Text.Length > 4 Then
            Dim momento As String = Format(Now, "HH:mm:ss")
            tipo = retornoCelda("select id from tipovehiculo t where t.tipovehiculo='" & cbTipoVehiculo2.Text & "'", "id")
            'txtDocumentoReserva
            matricula = txtMatricula2.Text

            Dim horario As String

            If rbDiurno.Checked = True Then
                horario = "dia"
            Else
                horario = "noche"
            End If

            Dim telf As String = ""

            If txtTelfReserva.Text.Replace(" ", "").Length = 0 Then
                telf = "NO"
            Else
                telf = txtTelfReserva.Text
            End If

            comando = "insert into reserva(documento,telefono,tiporeserva,tipovehiculo,nombre,matricula,marcadepago,horainicio,fechainicio,horario,estado,costo,horafin, fechafin) values('NO','" & telf & "',"
            comando += "2," & tipo & ",'" & txtNombre2.Text & "','" & matricula & "'," & checkMarcaPago2.Checked & ",'" & Format(Now, "HH:mm:ss") & "','" & Format(Now, "dd/MM/yyyy") & "','" & horario & "',True,0,'NO','NO')"

            ejecutarSql(comando)
            MessageBox.Show("Reserva creada con Éxito")
            cargarDgv(dgvReservasMes, 1)

            'actualizacion de variables Publicas
            actualizarValores(0, momento)

            'calculo de costo
            If checkMarcaPago2.Checked = True Then
                costo = retornoCelda("select p.mes" & horario & " from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & tipo & "'", "mes" & horario)
                comando = "update reserva set costo=" & costo & " where id=" & numTik
                ejecutarSql(comando)
            End If

            'Tikets
            opc = 2
            If imprimir = True Then
                If MessageBox.Show("Quiere Tiket?", "Opciones de Tiket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    PrintDocument3.Print()
                End If
                'PrintDocument3.Print()
            End If
            'Limpieza del panel
            cbTipoVehiculo2.SelectedIndex = 0
            limpieza(pnReservaMes)
            checkMarcaPago2.Checked = False
            rbDiurno.Checked = True
        Else
            lbEMatricula2.Visible = True
        End If
    End Sub

    Private Sub btnSoloLavado_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSoloLavado.Click
        costo = retornoCelda("Select p.lavado from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & cbTipoVehiculo0.Text & "'", "lavado")
        Dim momento As String = Format(Now, "HH:mm:ss")

        comando = "insert into reserva(horafin,matricula,tiporeserva,tipovehiculo,costo,horainicio,fechainicio,estado,documento,marcadepago,fechafin) values("
        comando += "'NO','NO',3,'" & cbTipoVehiculo0.SelectedIndex + 1 & "'," & costo & ",'" & momento & "','" & Format(Now, "dd/MM/yyyy") & "', False,'NO',True,'" & Today.Date & "')"
        ejecutarSql(comando)


        actualizarValores(0, momento)


        comando = "update reserva set costo=" & costo & " where id=" & numTik
        ejecutarSql(comando)
        'numTik = retornoCelda("select id from reserva where fechainicio='" & Today.Date & "' and horainicio='" & momento & "'", "id")
        MessageBox.Show("Registro creada con Éxito")
        'Tikets
        opc = 2
        If imprimir = True Then
            If MessageBox.Show("Quiere Tiket?", "Opciones de Tiket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                PrintDocument3.Print()
            End If

            'PrintDocument3.Print()
        End If
        'Limpieza del panel
        cbTipoVehiculo0.SelectedIndex = 0
    End Sub

    Private Sub btnFinalizarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizarReserva.Click

        'selecciono tipo: res hora o res mes
        Dim momento As String = Format(Now, "HH:mm:ss")

        If tcReservas.SelectedIndex = 0 Then
            If dgvReservasHora.Rows(0).Cells(0).Value.ToString <> "No hay ReservasHora" Then
                comando = "update reserva set estado=False,horafin='" & momento & "', fechafin='" & DateTime.Today & "' where horainicio='" & dgvReservasHora.CurrentRow.Cells(3).Value & "' and fechainicio='" & dgvReservasHora.CurrentRow.Cells(4).Value & "' and tiporeserva=1"

                ejecutarSql(comando)
                'MessageBox.Show("paso")
                actualizarValores(1, momento)
                'Tikets
                opc = 5
                If imprimir = True Then
                    If MessageBox.Show("Quiere Tiket?", "Opciones de Tiket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        PrintDocument3.Print()
                    End If
                    'PrintDocument1.Print()
                End If
            End If
        Else

            If dgvReservasMes.Rows(0).Cells(0).Value.ToString <> "No hay ReservasMes" Then
                comando = "update reserva set estado=False, horafin='" & momento & "', fechafin='" & DateTime.Today & "' where horainicio='" & dgvReservasMes.CurrentRow.Cells(3).Value & "' and fechainicio='" & dgvReservasMes.CurrentRow.Cells(4).Value & "' and matricula='" & dgvReservasMes.CurrentRow.Cells(2).Value & "' and tiporeserva=2"
                ejecutarSql(comando)

                actualizarValores(2, momento)
                'Tikets
                opc = 5
                If imprimir = True Then
                    If MessageBox.Show("Quiere Tiket?", "Opciones de Tiket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        PrintDocument3.Print()
                    End If
                    'PrintDocument1.Print()
                End If
            End If
        End If
    End Sub

    Private Sub tcPrincipal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcPrincipal.SelectedIndexChanged

        If tcPrincipal.SelectedIndex = 1 Then
            If tcReservas.SelectedIndex = 2 Then
                btnFinalizarReserva.Visible = False
                btnCancelarRserva.Visible = False
                verDetalles()
            Else
                btnFinalizarReserva.Visible = True
                btnCancelarRserva.Visible = True

            End If
        Else
            btnFinalizarReserva.Visible = False
            btnCancelarRserva.Visible = False
            btnMarcarPago.Visible = False
        End If
    End Sub

    Private Sub btnCancelarRserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarRserva.Click

        If tcReservas.SelectedIndex = 0 Then
            If dgvReservasHora.Rows(0).Cells(0).Value.ToString <> "No hay ReservasHora" Then
                If MessageBox.Show("Seguro de que desea dar de baja la reserva N°ro ID " & dgvReservasHora.CurrentRow.Cells(0).Value, "Baja de Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    comando = "delete from reserva where id=" & dgvReservasHora.CurrentRow.Cells(0).Value
                    ejecutarSql(comando)
                    cargarDgv(dgvReservasHora, 1)
                End If
            End If
        Else
            If dgvReservasMes.Rows(0).Cells(0).Value.ToString <> "No hay ReservasMes" Then

                If MessageBox.Show("Seguro de que desea dar de baja la reserva N° " & dgvReservasMes.CurrentRow.Cells(0).Value, "Baja de Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    comando = "delete from reserva where id=" & dgvReservasMes.CurrentRow.Cells(0).Value
                    ejecutarSql(comando)
                    cargarDgv(dgvReservasMes, 1)
                End If
            End If
        End If
    End Sub

    Private Sub btnMarcarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarPago.Click
        If dgvReservasMes.Rows(0).Cells(0).Value.ToString <> "No hay ReservasMes" Then
            Dim valor As Boolean = Not (dgvReservasMes.CurrentRow.Cells(7).Value)
            comando = "update reserva set marcadepago=" & valor & " where id=" & dgvReservasMes.CurrentRow.Cells(0).Value.ToString
            ejecutarSql(comando)
            If valor = True Then
                calcularCosto(dgvReservasMes.CurrentRow.Cells(0).Value)
            Else
                comando = "update reserva set costo=0 where id=" & dgvReservasMes.CurrentRow.Cells(0).Value
                ejecutarSql(comando)
            End If
            cargarDgv(dgvReservasMes, 1)
        End If
    End Sub

    Private Sub tcReservas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcReservas.SelectedIndexChanged
        If tcReservas.SelectedIndex = 1 And dgvReservasMes.Rows.Count <> 0 Then
            btnMarcarPago.Visible = True
        Else
            btnMarcarPago.Visible = False
        End If

        If tcReservas.SelectedIndex = 2 Then
            verDetalles()
            btnFinalizarReserva.Visible = False
            btnCancelarRserva.Visible = False
        Else
            btnFinalizarReserva.Visible = True
            btnCancelarRserva.Visible = True
        End If
    End Sub

    Private Sub tsmCierreCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCierreCaja.Click
        Dim total As Integer = 0

        comando = "select * from reserva where ((fechainicio='" & DateTime.Today & "') or (fechafin='" & DateTime.Today & "' and marcadepago=False))"
        consulta(dgvCierreCaja, comando)

        Dim fd = SaveFileDialog1
        Dim obj_FSO As Object
        Dim Archivo As Object
        verDetalles()
        fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If fd.ShowDialog() = DialogResult.OK Then
            obj_FSO = CreateObject("Scripting.FileSystemObject")
            Archivo = obj_FSO.CreateTextFile(fd.FileName(), True)
            Archivo.WriteLine("Registro de Actividades del dia " & Now.Date)
            Archivo.WriteLine("_____________________________________________")
            'Archivo.WriteLine("Fecha :" & DateTime.Today)
            'Archivo.WriteLine("Tipo|Matricula|H.Entrada|H.Salida|Dif|Costo")
            'Archivo.WriteLine("")

            For i As Integer = 0 To dgvCierreCaja.Rows.Count - 1

                'If (dgvCierreCaja.Rows(i).Cells(7).Value.ToString = Format(Now, "dd/MM/yyyy").ToString) Or (dgvCierreCaja.Rows(i).Cells(8).Value.ToString = Format(Now, "dd/MM/yyyy").ToString And dgvCierreCaja.Rows(i).Cells(11).Value = False) Then
                total = total + dgvCierreCaja.Rows(i).Cells(9).Value

                Archivo.WriteLine("Tiket nro:" & dgvCierreCaja.Rows(i).Cells(0).Value.ToString)
                Archivo.WriteLine("Tipo de reserva:" & retornoCelda("select t.tipo from tiporeserva t, reserva r where r.tiporeserva=t.id and r.id=" & dgvCierreCaja.Rows(i).Cells(0).Value, "tipo"))
                Archivo.WriteLine("Vehiculo:" & retornoCelda("select v.tipovehiculo from tipovehiculo v, reserva r where r.tipovehiculo=v.id and r.id=" & dgvCierreCaja.Rows(i).Cells(0).Value, "tipovehiculo"))
                Archivo.WriteLine("Matricula:" & dgvCierreCaja.Rows(i).Cells(4).Value.ToString)

                Archivo.WriteLine("Fecha Inicio:" & dgvCierreCaja.Rows(i).Cells(7).Value.ToString)
                Archivo.WriteLine("Fecha Fin   :" & dgvCierreCaja.Rows(i).Cells(8).Value.ToString)

                Archivo.WriteLine("Hora Inicio:" & dgvCierreCaja.Rows(i).Cells(5).Value.ToString)
                Archivo.WriteLine("Hora Fin   :" & dgvCierreCaja.Rows(i).Cells(6).Value.ToString)
                Archivo.WriteLine("Documento :" & retornoCelda("select documento from reserva where id=" & dgvCierreCaja.Rows(i).Cells(0).Value & "and documento is not null", "documento"))
                Archivo.WriteLine("Costo  :" & dgvCierreCaja.Rows(i).Cells(9).Value.ToString)
                Archivo.WriteLine("_____________________________________________")
                ' End If
            Next
            Archivo.WriteLine("Total del dia :" & total)
            Archivo.WriteLine("_____________________________________________")
            Archivo.Close()
        End If

        'Tiket
        opc = 4
        If imprimir = True Then
            PrintDocument3.Print()
        End If
    End Sub

    Function espacions(ByVal num As Integer, ByVal texto As String)
        Dim largo As Integer = texto.Length
        Dim espacios As Integer = (num - largo) - 3
        MessageBox.Show(espacios)
        For i As Integer = 0 To espacios - 1
            texto = "  " + texto + " "
        Next
        Return texto
    End Function

    '////////////////////////////////////////////////////
    Dim prFont As Font

    Public Sub escribir(ByVal e As Object, ByVal texto As String, ByVal tipo As Integer, ByVal estilo As FontStyle, ByVal posicion As Point)
        prFont = New Font("Arial", tipo, estilo)
        e.Graphics.DrawString(texto, prFont, Brushes.Black, posicion.X, posicion.Y)
    End Sub

    Private Sub tsmDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDetalles.Click
        verDetalles()
    End Sub

    ' VER DETALLES
    Public Sub verDetalles()
        Dim total As Integer = 0
        tcPrincipal.SelectedIndex = 1
        tcReservas.SelectedIndex = 2
        'respaldo de condicion
        'comando = "select r.id,r.horainicio, t.tipo, v.tipovehiculo, r.matricula, r.horafin, r.horario, r.costo from reserva r, tiporeserva t, tipovehiculo v where fechainicio='" & DateTime.Today & "' and r.tipovehiculo=v.id and r.tiporeserva=t.id"

        comando = "select r.id, r.horainicio, t.tipo, v.tipovehiculo, r.matricula, "
        comando += "r.horafin, r.horario, r.costo from reserva r, tiporeserva t, "
        comando += "tipovehiculo v where r.tipovehiculo=v.id and r.tiporeserva=t.id "

        'comando += "and ((estado=True) or ((fechainicio='" & DateTime.Today & "' or "
        'comando += "fechafin='" & DateTime.Today & "' and r.marcadepago=False) and estado = False))"

        comando += "and ((fechainicio='" & DateTime.Today & "') or (fechafin='" & DateTime.Today & "' and marcadepago=False))"

        consulta(dgvDetalles, comando)

        'comando = "select * from reserva where (fechainicio='" & DateTime.Today & "') or (fechafin='" & DateTime.Today & "' and marcadepago=False)"
        'consulta(dgvCierreCaja, comando)

        Dim cell As DataGridViewCellStyle = New DataGridViewCellStyle
        cell.BackColor = Color.LightBlue

        For i As Integer = 0 To dgvDetalles.Rows.Count - 1
            'MessageBox.Show((dgvCierreCaja.Rows(i).Cells(7).Value.ToString & " = " & Today.Date.ToString) & "-" & (dgvCierreCaja.Rows(i).Cells(8).Value.ToString = Today.Date.ToString))

            'If (dgvCierreCaja.Rows(i).Cells(7).Value.ToString = Format(Now, "dd/MM/yyyy").ToString) Or (dgvCierreCaja.Rows(i).Cells(8).Value.ToString = Format(Now, "dd/MM/yyyy").ToString And dgvCierreCaja.Rows(i).Cells(11).Value = False) Then
            total = total + dgvDetalles.Rows(i).Cells(7).Value
            'End If

            Select Case dgvDetalles.Rows(i).Cells(2).Value
                Case "Por Hora"
                    dgvDetalles.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
                Case "Por Mes"
                    dgvDetalles.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Case "Lavado"
                    dgvDetalles.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End Select

        Next
        lbMontoValor.Text = total.ToString
    End Sub

    Public Sub actualizarValores(ByVal accion As Integer, ByVal momento As String)
        'Accion: 0 alta | 1 Finalizacion x hora | 2 Finalizacion x mes

        Select Case accion
            Case 0
                'Variables para Tikets de Altas de Reservas y Lavado
                numTik = retornoCelda("select id from reserva where fechainicio='" & Today.Date & "' and horainicio='" & momento & "'", "id")

                matricula = retornoCelda("select matricula from reserva where id=" & numTik, "matricula")

                costo = retornoCelda("select costo from reserva where id=" & numTik, "costo")

                tipo = retornoCelda("select v.tipovehiculo from tipovehiculo v, reserva r where r.id=" & numTik & " and v.id=r.tipovehiculo", "tipovehiculo")

                tiporeserva = retornoCelda("select t.tipo from tiporeserva t, reserva r where r.id=" & numTik & " and t.id=r.tiporeserva", "tipo")
            Case 1

                'Variables para Tikets de Finalizacion de Reserva x Hora
                numTik = dgvReservasHora.CurrentRow.Cells(0).Value
                tipo = dgvReservasHora.CurrentRow.Cells(1).Value
                matricula = dgvReservasHora.CurrentRow.Cells(2).Value
                horaEntrada = dgvReservasHora.CurrentRow.Cells(3).Value
                fehaInicio = retornoCelda("select fechainicio from reserva where id=" & numTik, "fechainicio")
                calcularCosto(numTik)
                cargarDgv(dgvReservasHora, 1)
                tiporeserva = retornoCelda("select t.tipo from tiporeserva t, reserva r where r.id=" & numTik & " and t.id=r.tiporeserva", "tipo")
            Case 2
                'Variables para Tikets de Finalizacion de Reserva x Mes
                numTik = dgvReservasMes.CurrentRow.Cells(0).Value
                tipo = dgvReservasMes.CurrentRow.Cells(1).Value
                matricula = dgvReservasMes.CurrentRow.Cells(2).Value
                horaEntrada = dgvReservasMes.CurrentRow.Cells(3).Value
                fehaInicio = retornoCelda("select fechainicio from reserva where id=" & numTik, "fechainicio")
                calcularCosto(numTik)
                cargarDgv(dgvReservasMes, 1)
                tiporeserva = retornoCelda("select t.tipo from tiporeserva t, reserva r where r.id=" & numTik & " and t.id=r.tiporeserva", "tipo")

        End Select
    End Sub

    Public Sub calcularCosto(ByVal numTik As Integer)
        If retornoCelda("select tiporeserva from reserva where id=" & numTik, "tiporeserva") <> 2 Then
            momentoInicial = fehaInicio
            momentoFinal = Now.Date

            hora = retornoCelda("Select p.hora from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & dgvReservasHora.CurrentRow.Cells(1).Value & "'", "hora")
            horaMinimo = Int(retornoCelda("Select p.horaminimo from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & dgvReservasHora.CurrentRow.Cells(1).Value & "'", "horaminimo"))
            horaLimite = Int(retornoCelda("Select p.horalimite from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & dgvReservasHora.CurrentRow.Cells(1).Value & "'", "horalimite"))

            If DateDiff(DateInterval.Day, momentoInicial, momentoFinal) = 0 Then
                'metodo de calculo basico
                costo = calculoBasico(New TimeSpan(Now.Hour, Now.Minute, Now.Second).Subtract(New TimeSpan(horaEntrada.Hour, horaEntrada.Minute, horaEntrada.Second)))
            Else
                'calculo avanzado
                costo = calculoBasico(difIni(New TimeSpan(horaEntrada.Hour, horaEntrada.Minute, horaEntrada.Second)))
                costo += calculoBasico(difFin(New TimeSpan(Now.Hour, Now.Minute, Now.Second)))
                'dias
                costo += (DateDiff(DateInterval.Day, momentoInicial, momentoFinal) - 1) * horaLimite
                'noches
                costo += DateDiff(DateInterval.Day, momentoInicial, momentoFinal) * (horaLimite / 2)

            End If

        Else
            'X MES
            costo = retornoCelda("select p.mes" & dgvReservasMes.CurrentRow.Cells(5).Value & " from precios p, tipovehiculo t where p.tipovehiculo=t.id and t.tipovehiculo='" & dgvReservasMes.CurrentRow.Cells(1).Value & "'", "mes" & dgvReservasMes.CurrentRow.Cells(5).Value)
        End If
        comando = "update reserva set costo=" & costo & " where id=" & numTik
        ejecutarSql(comando)
    End Sub

    Function calculoBasico(ByVal dif As TimeSpan)
        Dim costoDia As Integer
        MessageBox.Show(dif.ToString)
        If tipo = "Moto" Then
            costoDia = (dif.Hours * hora) + (Int(dif.Minutes / 30) * hora)
        Else
            mediasHoras = mediasH(dif)
            costoDia = mediasHoras * (hora / 2)
        End If
        'costoDia > limiteDia
        If costoDia > horaLimite Then
            costoDia = horaLimite
        ElseIf mediasHoras < 2 Then
            'MessageBox.Show("Es menor :" & mediasHoras & "- minimo:" & horaMinimo)
            'mediasHoras < 1
            costoDia = horaMinimo
        End If
        Return costoDia
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
       
    End Sub


End Class