Public Class Form1

    Public q As Integer
    Public q1 As Integer
    Public ps As Integer
    Public numAleFin As Integer
    Public numAleLlega As Integer
    Public numAleSalServ As Integer
    Public numAleRegServ As Integer
    Public numAleLlegaClPrioridad As Integer
    Public supLleg, infLleg, supFin, infFin As Integer
    Public hpfs As Integer
    Public hpll As Integer
    Public hactual As Integer
    Public hpss As Integer
    Public hprs As Integer
    Public hpac As Integer
    Public hpllCP As Integer
    Public s, c As Integer
    Public menor As Integer
    Public horaLlegadaClaCola(99) As Integer
    Public nombreForm As Integer = 1

    Public i As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
        c = 0
        'hactual = #8/13/2002 8:00:00 AM#
        hactual = 0
        s = 1
        hpss = 9999
        hprs = 9999
        hpllCP = 9999
        q1 = 0

        'q = CInt(Math.Floor((10 - 0 + 1) * Rnd())) + 0
        q = 5
        If (q > 0) Then
            ps = 1
        Else
            ps = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0
        End If
        llegadaCliente()
        finDeServicio(ps)



    End Sub


    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        supLleg = CInt(txtSupLleg.Text)
        infLleg = CInt(txtInfLleg.Text)
        supFin = CInt(txtSupFin.Text)
        supLleg = CInt(txtSupLleg.Text)

        numAleFin = CInt(Math.Floor((supFin - infFin + 1) * Rnd())) + infFin
        numAleLlega = CInt(Math.Floor((supLleg - infLleg + 1) * Rnd())) + infLleg

        If cbSalidaServidor.Checked = True Then
            numAleRegServ = CInt(Math.Floor((CInt(txtSupRegreso.Text) - CInt(txtInfRegreso.Text) + 1) * Rnd())) + CInt(txtInfRegreso.Text)
            numAleSalServ = CInt(Math.Floor((CInt(txtSupSalida.Text) - CInt(txtInfSalida.Text) + 1) * Rnd())) + CInt(txtInfSalida.Text)
        End If

        If cbClientesPrioridad.Checked = True Then
            numAleLlegaClPrioridad = CInt(Math.Floor((CInt(txtLlCPSup.Text) - CInt(txtLlCPInf.Text) + 1) * Rnd())) + CInt(txtLlCPInf.Text)
        End If

        hactual = deterMenor(hpfs, hpll, hprs, hpss, hpllCP)
        lanzarFunciones()

        If q = 0 Then
            ps = 0
        End If



        dgvLlegadas.Rows.Add()
        dgvLlegadas.Rows(i).Cells(0).Value = hactual
        dgvLlegadas.Rows(i).Cells(1).Value = q
        dgvLlegadas.Rows(i).Cells(2).Value = ps
        dgvLlegadas.Rows(i).Cells(3).Value = s



        If hpfs = 9999 Then
            dgvLlegadas.Rows(i).Cells(4).Value = "-"
        Else
            dgvLlegadas.Rows(i).Cells(4).Value = hpfs
        End If

        If hprs = 9999 Then
            dgvLlegadas.Rows(i).Cells(7).Value = "-"
        Else
            dgvLlegadas.Rows(i).Cells(7).Value = hprs
        End If
        If hpss = 9999 Then
            dgvLlegadas.Rows(i).Cells(6).Value = "-"
        Else
            dgvLlegadas.Rows(i).Cells(6).Value = hpss
        End If

        dgvLlegadas.Rows(i).Cells(5).Value = hpll
        dgvLlegadas.Rows(i).Cells(8).Value = q1

        If hpllCP = 9999 Then
            dgvLlegadas.Rows(i).Cells(9).Value = "-"
        Else
            dgvLlegadas.Rows(i).Cells(9).Value = hpllCP
        End If



        i = i + 1
    End Sub

    Private Sub llegadaCliente()
        'hpll = hactual
        'hpll.AddSeconds(numAleLlega)
        hpll = hactual + numAleLlega
        q = q + 1

        'CALCULO DE ABANDONO DE COLA
        'If q > 0 Then
        '    If ps = 1 Then
        '        horaLlegadaClaCola(c) = hpll
        '        c = c + 1
        '    End If
        'End If
    End Sub

    Private Sub llegadaClientePrioridad()
        hpllCP = hactual + numAleLlegaClPrioridad
        q1 = q1 + 1
    End Sub

    Private Sub finDeServicio(ByVal ps As Integer)
        If (ps = 1) Then
            'hpfs = hactual
            'hpfs.AddSeconds(numAleFin)
            If q1 > 0 Then
                q1 = q1 - 1
            Else
                q = q - 1
            End If
            hpfs = hactual + numAleFin
        End If
    End Sub

    Private Sub salidaServidor()
        s = 0
        hprs = hactual + numAleRegServ
        hpss = 9999
        hpfs = 9999
    End Sub

    Private Sub regresoServidor()
        s = 1
        hpss = hactual + numAleSalServ
        hprs = 9999
        hpfs = hactual + numAleFin
    End Sub

    Private Sub btnAgregarPS_Click(sender As Object, e As EventArgs) Handles btnAgregarPS.Click
        Dim f As New Form1
        f.Text = f.Text & nombreForm
        nombreForm = nombreForm + 1
        f.Show()
    End Sub

    Private Function deterMenor(ByRef hpfs, hpll, hprs, hpss, hpllCP) As Integer
        menor = 65533

        If menor > hpll Then
            menor = hpll
        End If
        If menor > hpfs Then
            menor = hpfs
        End If
        If menor > hpss Then
            menor = hpss
        End If
        If menor > hprs Then
            menor = hprs
        End If

        If cbClientesPrioridad.Checked = True Then
            If menor > hpllCP Then
                menor = hpllCP
            End If
        End If

        Return menor
    End Function

    Private Sub lanzarFunciones()
        If menor = hpfs Then
            If q > 0 Then
                If (s = 1) Then
                    ps = 1
                    finDeServicio(ps)
                End If
            End If
        End If
        If menor = hpll Then
            llegadaCliente()
        End If
        If menor = hprs Then
            regresoServidor()
        End If
        If menor = hpss Then
            salidaServidor()
        End If

        If cbClientesPrioridad.Checked = True Then
            If menor = hpllCP Then
                llegadaClientePrioridad()
            End If
        End If

    End Sub

    Private Sub cbSalidaServidor_CheckedChanged(sender As Object, e As EventArgs) Handles cbSalidaServidor.CheckedChanged
        If cbSalidaServidor.Checked = True Then
            txtSupSalida.Enabled = True
            txtInfSalida.Enabled = True
            txtSupRegreso.Enabled = True
            txtInfRegreso.Enabled = True
            hpss = 0
            hprs = 0
        Else
            txtSupSalida.Enabled = False
            txtInfSalida.Enabled = False
            txtSupRegreso.Enabled = False
            txtInfRegreso.Enabled = False
            hpss = 9999
            hprs = 9999
        End If
    End Sub

    Private Sub cbClientesPrioridad_CheckedChanged(sender As Object, e As EventArgs) Handles cbClientesPrioridad.CheckedChanged
        If cbClientesPrioridad.Checked = True Then
            txtLlCPSup.Enabled = True
            txtLlCPInf.Enabled = True
            hpllCP = 0
        Else
            txtLlCPSup.Enabled = False
            txtLlCPInf.Enabled = False
            hpllCP = 9999
        End If
    End Sub

    Private Sub btnIterar_Click(sender As Object, e As EventArgs) Handles btnIterar.Click
        Dim p As Integer
        p = CInt(txtCantIteraciones.Text)
        For x As Integer = 0 To p
            btnGenerar_Click(sender, e)
        Next
    End Sub
End Class
