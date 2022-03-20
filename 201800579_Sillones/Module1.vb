
Imports System.Math

Module Module1
    'declaramos nuestos vectores y un contador
    Dim VNumero(8) As String
    Dim VDescripcion(8) As String
    Dim VMano(8) As String
    Dim VTela(8) As String
    Dim VTotalCosto(8) As String
    Dim VVenata(8) As String
    Dim Contador = 0
    Dim Comparador = 0

    'declaramos nuestras contasntes
    Dim MSofa = 250.99
    Dim MIndividual = 150.99
    Dim MDoble = 200.99
    Dim PRCuero = 75
    Dim PRCuerina = 45.99
    Dim YARSofa = 8
    Dim YARIndividual = 3.5
    Dim YARDoble = 6

    'declaramos nuestras variables
    Dim Costos As Double
    Dim Ventas As Double
    Dim Mano As Double
    Dim Tela As Double

    'aca se encuentran alojadas todas las operaciones
    Public Sub Guardar()

        'empezamos guardando registros en cada vector conforme se vayan ingresando
        VNumero(Contador) = Form1.TBNumero.Text
        'realizamos un if para guardar datos en nuestra descrpcion 

        'sofa
        If Form1.RBSofa.Checked = True Then
            'cuero
            If Form1.RBCuero.Checked = True Then
                VDescripcion(Contador) = Form1.TBSillones.Text + " " + Form1.RBSofa.Text + " de " + Form1.RBCuero.Text
                'realizamos las operaciones 
                'masno de obra
                Mano = Form1.TBSillones.Text * MSofa
                VMano(Contador) = Round(Mano, 2)
                'tela
                Tela = Form1.TBSillones.Text * PRCuero * YARSofa
                VTela(Contador) = Round(Tela, 2)
                'Total de Costo
                Costos = Mano + Tela
                VTotalCosto(Contador) = Round(Costos, 2)
                'Venta
                Ventas = Costos + Costos * 0.65
                VVenata(Contador) = Round(Ventas, 2)
            End If
            'cuerina
            If Form1.RBCuerina.Checked = True Then
                VDescripcion(Contador) = Form1.TBSillones.Text + " " + Form1.RBSofa.Text + " de " + Form1.RBCuerina.Text
                'realizamos las operaciones 
                'masno de obra
                Mano = Form1.TBSillones.Text * MSofa
                VMano(Contador) = Round(Mano, 2)
                'tela
                Tela = Form1.TBSillones.Text * PRCuerina * YARSofa
                VTela(Contador) = Round(Tela, 2)
                'Total de Costo
                Costos = Mano + Tela
                VTotalCosto(Contador) = Round(Costos, 2)
                'Venta
                Ventas = Costos + Costos * 0.65
                VVenata(Contador) = Round(Ventas, 2)
            End If

        End If



        'Individual
        If Form1.RBIndividual.Checked = True Then
            'cuero
            If Form1.RBCuero.Checked = True Then
                VDescripcion(Contador) = Form1.TBSillones.Text + " sillon " + Form1.RBIndividual.Text + " de " + Form1.RBCuero.Text
                'realizamos las operaciones 
                'masno de obra
                Mano = Form1.TBSillones.Text * MIndividual
                VMano(Contador) = Round(Mano, 2)
                'tela
                Tela = Form1.TBSillones.Text * PRCuero * YARIndividual
                VTela(Contador) = Round(Tela, 2)
                'Total de Costo
                Costos = Mano + Tela
                VTotalCosto(Contador) = Round(Costos, 2)
                'Venta
                Ventas = Costos + Costos * 0.65
                VVenata(Contador) = Round(Ventas, 2)
            End If
            'cuerina
            If Form1.RBCuerina.Checked = True Then
                VDescripcion(Contador) = Form1.TBSillones.Text + " sillon " + Form1.RBIndividual.Text + " de " + Form1.RBCuerina.Text
                'realizamos las operaciones 
                'masno de obra
                Mano = Form1.TBSillones.Text * MIndividual
                VMano(Contador) = Round(Mano, 2)
                'tela
                Tela = Form1.TBSillones.Text * PRCuerina * YARIndividual
                VTela(Contador) = Round(Tela, 2)
                'Total de Costo
                Costos = Mano + Tela
                VTotalCosto(Contador) = Round(Costos, 2)
                'Venta
                Ventas = Costos + Costos * 0.65
                VVenata(Contador) = Round(Ventas, 2)
            End If

        End If

        'Doble
        If Form1.RBDoble.Checked = True Then
            'cuero
            If Form1.RBCuero.Checked = True Then
                VDescripcion(Contador) = Form1.TBSillones.Text + " sillon " + Form1.RBDoble.Text + " de " + Form1.RBCuero.Text
                'realizamos las operaciones 
                'masno de obra
                Mano = Form1.TBSillones.Text * MDoble
                VMano(Contador) = Round(Mano, 2)
                'tela
                Tela = Form1.TBSillones.Text * PRCuero * YARDoble
                VTela(Contador) = Round(Tela, 2)
                'Total de Costo
                Costos = Mano + Tela
                VTotalCosto(Contador) = Round(Costos, 2)
                'Venta
                Ventas = Costos + Costos * 0.65
                VVenata(Contador) = Round(Ventas, 2)
            End If
            'cuerina
            If Form1.RBCuerina.Checked = True Then
                VDescripcion(Contador) = Form1.TBSillones.Text + " sillon " + Form1.RBDoble.Text + " de " + Form1.RBCuerina.Text
                'realizamos las operaciones 
                'masno de obra
                Mano = Form1.TBSillones.Text * MDoble
                VMano(Contador) = Round(Mano, 2)
                'tela
                Tela = Form1.TBSillones.Text * PRCuerina * YARDoble
                VTela(Contador) = Round(Tela, 2)
                'Total de Costo
                Costos = Mano + Tela
                VTotalCosto(Contador) = Round(Costos, 2)
                'Venta
                Ventas = Costos + Costos * 0.65
                VVenata(Contador) = Round(Ventas, 2)
            End If

        End If

        'validamos que se sume nuestro contador
        If Contador = 8 Then
            MsgBox("Llego al limite de Cotizaciones  ", MsgBoxStyle.Information, "ADVERTENCIA")

        Else
            Contador = Contador + 1
            MsgBox("Se Registro con Exito ", MsgBoxStyle.Information, "Guardado")
            Form1.TBNumero.Text = 0
            Form1.TBSillones.Text = 0
            Form1.RBCuerina.Checked = 0
            Form1.RBCuero.Checked = 0
            Form1.RBSofa.Checked = 0
            Form1.RBIndividual.Checked = 0
            Form1.RBDoble.Checked = 0
            Form1.TBNumero.Focus()
        End If


        'con la ayuda de un ciclo while procederemos a mostras los datos del paciente, subtota, descuento, total
        While ((Comparador <= (Contador - 1)))
            Form1.LISTDescripcion.Items.Add(VDescripcion(Comparador))
            Form1.LISTNumeroVenta.Items.Add(VNumero(Comparador))
            Form1.LISTManoObra.Items.Add(VMano(Comparador))
            Form1.LISTPrecioTela.Items.Add(VTela(Comparador))
            Form1.LISTCosto.Items.Add(VTotalCosto(Comparador))
            Form1.LISTVenta.Items.Add(VVenata(Comparador))

            Comparador += 1

        End While

    End Sub


    'limpieza de los registros
    Public Sub Limpieza()
        If Contador = 0 Then
            MsgBox("No hay registros", MsgBoxStyle.Information, "Limpieza")
        Else
            For Contador = 0 To 8
                'se le asigna Nothing a cada posición del vector
                VNumero(Contador) = Nothing
                VDescripcion(Contador) = Nothing
                VMano(Contador) = Nothing
                VTela(Contador) = Nothing
                VTotalCosto(Contador) = Nothing
                VVenata(Contador) = Nothing

                Form1.TBNumero.Text = 0
                Form1.TBSillones.Text = 0
                Form1.RBCuerina.Checked = 0
                Form1.RBCuero.Checked = 0
                Form1.RBSofa.Checked = 0
                Form1.RBIndividual.Checked = 0
                Form1.RBDoble.Checked = 0

                Form1.LISTDescripcion.Items.Clear()
                Form1.LISTNumeroVenta.Items.Clear()
                Form1.LISTManoObra.Items.Clear()
                Form1.LISTPrecioTela.Items.Clear()
                Form1.LISTCosto.Items.Clear()
                Form1.LISTVenta.Items.Clear()

                Form1.TBNumero.Focus()
            Next Contador
            MsgBox("Se han Eliminado todos los Registros ", MsgBoxStyle.Information, "Limpieza")

        End If
        'reiniciamos los contadores
        Contador = 0
        Comparador = 0
    End Sub
End Module
