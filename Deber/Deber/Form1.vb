Public Class Form1
    Dim l As New List(Of String)
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        l.Add("provinci: " & TextBox1.Text)
        l.Add("ciudad: " & TextBox2.Text)
        l.Add("poblacion: " & TextBox3.Text)
        TextBox4.Text = TextBox1.Text
        TextBox7.Text = TextBox1.Text
        TextBox5.Text = TextBox2.Text
        TextBox8.Text = TextBox2.Text
        TextBox6.Text = TextBox3.Text
        TextBox9.Text = TextBox3.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        For Each item As String In l
            Me.ListBox1.Items.Add(item)
        Next item
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim nuevo As Integer = Int(TextBox3.Text)
        Dim menor As Integer = Int(TextBox6.Text)
        Dim mayor As Integer = Int(TextBox9.Text)
        Dim Calc As Class1 = New Class1
        Dim I As Integer = Calc.Calculadora(nuevo, menor, mayor)

        l.Add("provincia: " & TextBox1.Text)
        l.Add("ciudad: " & TextBox2.Text)
        l.Add("poblacion: " & TextBox3.Text)
        If I = 1 Then
            TextBox4.Text = TextBox1.Text
            TextBox5.Text = TextBox2.Text
            TextBox6.Text = TextBox3.Text
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf I = 2 Then
            TextBox7.Text = TextBox1.Text
            TextBox8.Text = TextBox2.Text
            TextBox9.Text = TextBox3.Text
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf I = 3 Then
            TextBox4.Text = TextBox4.Text & ", " & TextBox1.Text
            TextBox5.Text = TextBox5.Text & ", " & TextBox2.Text
            TextBox6.Text = TextBox3.Text
        ElseIf I = 4 Then
            TextBox7.Text = TextBox7.Text & ", " & TextBox1.Text
            TextBox8.Text = TextBox8.Text & ", " & TextBox2.Text
            TextBox9.Text = TextBox3.Text
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub
End Class
