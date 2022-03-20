Public Class Form1

    'aqui va la programacion del boton para guardar las entradas
    Private Sub TSGuardar_Click(sender As Object, e As EventArgs) Handles TSGuardar.Click
        'validamos que se ingrese el numero de transaccion
        If TBNumero.Text = 0 Then
            MsgBox("Usted no a Ingresado el Numero de Transaccion", MsgBoxStyle.Information, "Advertencia")
            TBNumero.Focus()
        Else
            'validamos que se ingrese el numero de sillones a fabricar
            If TBSillones.Text = 0 Then
                MsgBox("Usted no a Ingresado el Numero de Sillones a Fabricar", MsgBoxStyle.Information, "Advertencia")
                TBSillones.Focus()
            Else
                'validamos que se selecciones uno de los tamaños disponibles
                If ((RBSofa.Checked = True) Or (RBIndividual.Checked = True) Or (RBDoble.Checked = True)) Then
                    'validamos que se seleccione el material con el que se fabricaran los sillones
                    If ((RBCuero.Checked = True) Or (RBCuerina.Checked = True)) Then
                        'llamamos a nuestro metodo
                        Guardar()
                    Else
                        MsgBox("Usted no a Seleccionado el tipo de Tela", MsgBoxStyle.Information, "Advertencia")
                    End If
                Else
                    MsgBox("Usted no a Seleccionado el tipo de Sillones a Fabricar", MsgBoxStyle.Information, "Advertencia")
                End If

            End If
        End If
    End Sub

    'validamos que solo se ingresen valores numericos para el textbox de numero
    Private Sub TBNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNumero.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'validamos que solo se ingresen valores numericos para el textbox de sillones
    Private Sub TBSillones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSillones.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TSLimpiarEntradas_Click(sender As Object, e As EventArgs) Handles TSLimpiarEntradas.Click
        If MsgBox("¿Desea Eliminar Todos los Registros?", vbQuestion + vbYesNo, "Eliminar") = vbYes Then
            Limpieza()
        Else
            TBNumero.Focus()
        End If
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else
            TBNumero.Focus()
        End If
    End Sub
End Class
