Public Class ClsFunktion
    Public Function Fakultaet(Eingabe As Long) As Long
        Dim Ergebnis As Long

        For I As Long = 1 To Eingabe
            Ergebnis += I
        Next
        Return Ergebnis
    End Function
End Class
