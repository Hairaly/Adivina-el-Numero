Public Class Form1
    Dim numeroSecreto As Integer
    Dim intentos As Integer = 0
    Dim Rnd As New Random()

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AutoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoraToolStripMenuItem.Click
        MsgBox("Hairaly Diaz")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarJuego()
    End Sub

    Private Sub IniciarJuego()
        numeroSecreto = Rnd.Next(1, 11)
        intentos = 0
        Label2.Text = "Intentos: 0"
        TextBox1.Clear()
        TextBox2.Clear()
        Button1.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entrada As String = TextBox1.Text
        Dim numero As Integer

        If Integer.TryParse(entrada, numero) AndAlso numero >= 1 AndAlso numero <= 10 Then
            intentos += 1
            Label2.Text = "Intentos: " & intentos

            If numero < numeroSecreto Then
                MsgBox("El número es más alto.")
            ElseIf numero > numeroSecreto Then
                MsgBox("El número es más bajo.")
            Else
                TextBox2.Text = numeroSecreto.ToString()
                MsgBox("¡Felicidades! Le atinaste al número en " & intentos & " intentos.", MsgBoxStyle.Information)
                Button1.Enabled = False
                TextBox1.Enabled = False
            End If
        Else
            MsgBox("Por favor ingresa un número válido entre 1 y 10.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IniciarJuego()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
