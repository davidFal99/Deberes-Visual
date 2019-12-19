Public Class Form1
    Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\dicci.txt"
    Dim img As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If palabraTXT.Text = "" And defiTXT.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, definicion, dic As String
        palabra = palabraTXT.Text
        definicion = defiTXT.Text
        dic = palabra + ":" + definicion
        Dim item1 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        item1.SubItems.Add(definicion)
        Form2.ListView1.Items.Add(item1)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Palabras:   " & palabraTXT.Text & "Definicion:   " & defiTXT.Text & vbCrLf, True)
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\erick"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            img = OpenFileDialog1.FileName
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub
End Class
