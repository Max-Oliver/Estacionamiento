Module Metodos
    Function validacionCi(ByVal doc As Integer, ByVal cedula As String, ByVal accion As String)
        Dim correcta As String = "True"
        If doc = 0 Then
            If cedula.Length = 8 Then
                Dim verif As String = "2987634"
                Dim h As Integer = 0
                For i As Integer = 0 To 6
                    h = h + Val(cedula.Chars(i)) * Val(verif.Chars(i))
                Next
                h = h Mod 10
                h = (10 - h) Mod 10
                If cedula.Chars(7) <> h.ToString Then
                    frmPrincipal.lbEDocumentoReserva.Text = "La C.i no es válida"
                    frmPrincipal.lbEDocumentoReserva.Visible = True
                    frmPrincipal.txtTelfReserva.BackColor = Color.FromArgb(255, 192, 192)
                    correcta = "False"
                End If
            Else
                frmPrincipal.lbEDocumentoReserva.Text = "La C.i debe contener 8 digitos"
                frmPrincipal.lbEDocumentoReserva.Visible = True
                frmPrincipal.txtTelfReserva.BackColor = Color.FromArgb(255, 192, 192)
                correcta = "False"
            End If
        ElseIf doc = -1 Then
            correcta = "False"
            frmPrincipal.lbEDocumentoReserva.Text = "Antes seleccione un Tipo"
            frmPrincipal.txtTelfReserva.BackColor = Color.FromArgb(255, 192, 192)
            frmPrincipal.lbEDocumentoReserva.Visible = True
        End If
        'If accion = "Alta de Cliente" Then
        '    If contiene("select nombre from Cliente where tipoDoc=" & doc & " and documento='" & cedula & "'") = True Then
        '        correcta = "Existe"
        '        frmPrincipal.lbEDocumento.Text = "El Documento ya Existe"
        '        frmPrincipal.lbEDocumento.Visible = True
        '        frmPrincipal.txtDocumento.BackColor = Color.FromArgb(255, 192, 192)
        '    End If
        'End If
        Return correcta
    End Function

    Public Sub AceptaNumeros(ByVal e, ByVal val1, ByVal val2, ByVal val3, ByVal val4)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = val1 ' numeros
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = val2 ' controles
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = val3 'separador
        Else
            e.Handled = val4 'ninguno de los anteriores
        End If
    End Sub

    Public Sub limpieza(ByVal box As Panel)
        'opciones particulares de ci y telefono
        '----------------------------------------------------------
        'My.Forms.frmPrincipal.txtDocumento.BackColor = Color.White
        'My.Forms.frmPrincipal.txtDocumento.Text = ""
        'My.Forms.frmPrincipal.listTelCliente.Items.Clear()
        'My.Forms.frmPrincipal.txtTelfCliente.Text = ""
        '----------------------------------------------------------

        For Each ctl As Control In box.Controls
            Select Case ctl.GetType.Name.ToString
                Case "ListBox"
                    Dim list As ListBox = ctl
                    list.Items.Clear()
                Case "Label"
                    If ctl.Name.IndexOf("lbE") <> -1 Then
                        ctl.Visible = False
                    End If
                Case "TextBox"
                    ctl.Text = ""
                    ctl.BackColor = Color.White
                Case "MenuStrip"
                    Dim ms As MenuStrip = ctl
                    ms.Items.Item(0).Tag = -1
                    ms.Items.Item(0).BackColor = Color.FromArgb(224, 224, 224)
                    If box.Name = "pnCliente" Then

                        If ms.Items.Item(0).Name = "tsmTipoDoc" Then
                            ms.Items.Item(0).Text = "Seleccione Tipo"
                            'ElseIf ms.Items.Item(0).Name = "tsmSexo" Then
                            '    ms.Items.Item(0).Text = "Seleccione Sexo"
                        End If

                    End If
            End Select
        Next
    End Sub

    Function validator(ByVal box As Panel) 'Metodo de control de TextBox y ComboBox vacíos
        Dim pass As Boolean = True
        For Each ctl As Control In box.Controls 'Oculta los labels error
            If ctl.Name.IndexOf("lbE") <> -1 Then
                ctl.Visible = False
            ElseIf TypeOf ctl Is TextBox Then
                ctl.BackColor = Color.White
            End If
        Next

        'If validacionCi(frmVentas.tsmTipoDoc.Tag, frmVentas.txtDocumento.Text) = False Then
        ' pass = False
        ' End If

        For Each ctl As Control In box.Controls
            Select Case ctl.GetType.Name
                Case "TextBox"
                    If ctl.Text.Replace(" ", "").Length = 0 Then
                        ctl.BackColor = Color.FromArgb(255, 192, 192)
                        pass = False
                        box.Controls.Item(box.Controls.IndexOfKey("lbE" & ctl.Name.Replace("txt", "").ToString)).Visible = True
                    End If
                Case "MenuStrip"
                    Dim ms As MenuStrip = ctl
                    If ms.Items.Item(0).Tag = -1 Then
                        ms.Items.Item(0).BackColor = Color.FromArgb(255, 192, 192)
                        pass = False
                        box.Controls.Item(box.Controls.IndexOfKey("lbE" & ctl.Name.Replace("ms", "").ToString)).Visible = True
                    End If
            End Select
        Next
        Return pass
    End Function

    'Function convierteFecha(ByVal fecha) 'convierte al tipo de dato que soporta el atributo de sql
    '    Return Format(Date.Parse(fecha), "yyyy-MM-dd")
    'End Function

    'Public Sub seleccionBtn(ByVal sender As Button, ByVal barra As Panel)
    '    For Each ctl In barra.Controls
    '        If ctl.text <> sender.Text Then
    '            ctl.BackColor = Color.FromArgb(224, 224, 224)
    '        Else
    '            ctl.BackColor = System.Drawing.Color.FromArgb(10, 192, 133)
    '        End If
    '    Next
    'End Sub

    'Public mensajeOpc As Integer = -1

    'Public Sub infoBar(ByVal message)
    '    frmVentas.lbInforme.Visible = True
    '    frmVentas.lbInforme.Text = message
    '    frmVentas.lbInforme.BackColor = System.Drawing.Color.FromArgb(10, 192, 133)
    '    For Each ctl In frmVentas.pnControl.Controls
    '        If TypeOf ctl Is Button Then
    '            ctl.backColor = System.Drawing.Color.FromArgb(10, 192, 133)
    '        End If
    '    Next
    'End Sub
    'Public Sub infoBarError(ByVal message)
    '    'Ventas.lbInforme.Visible = True
    '    'Ventas.lbInforme.Text = message '255; 128; 128
    '    'Ventas.lbInforme.BackColor = System.Drawing.Color.FromArgb(255, 128, 128)
    '    'For Each ctl In Ventas.Splitter1.Controls
    '    '    If TypeOf ctl Is Button Then
    '    '        ctl.backColor = System.Drawing.Color.FromArgb(10, 192, 133)
    '    '    End If
    '    'Next
    'End Sub

    'Function mensaje(ByVal msg, ByVal opcion) As Boolean
    '    frmVentas.btnAceptar.Text = opcion
    '    frmVentas.lbConsulta.Text = msg
    '    frmVentas.pnMensaje.Visible = True
    'End Function

End Module
