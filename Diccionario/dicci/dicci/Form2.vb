Public Class Form2
    Dim listDiccionario As ListView
    Dim palabra, definicion As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listDiccionario = ListView1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If listDiccionario.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = listDiccionario.SelectedItems(0)
            Dim palabra As String = item.SubItems(1).Text
            Dim definicion As String = item.SubItems(2).Text
            Form3.lblPalabra.Text = palabra
            Form3.txtDefinicion.Text = definicion
            Form3.Show()
            Me.Hide()
        End If
    End Sub


End Class