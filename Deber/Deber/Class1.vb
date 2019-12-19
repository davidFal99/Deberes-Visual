Public Class Class1
    Dim nuevo As Integer
    Dim menor As Integer
    Dim mayor As Integer
    Public Function Calculadora(nuevo, menor, mayor)
        Dim i As Integer = 0
        If nuevo < menor Then
            i = 1
            Return i
        ElseIf nuevo > mayor Then
            i = 2
            Return i
        ElseIf nuevo = menor Then
            i = 3
            Return i
        ElseIf nuevo = mayor Then
            i = 4
            Return i
        Else
            Return i
        End If
    End Function
End Class
