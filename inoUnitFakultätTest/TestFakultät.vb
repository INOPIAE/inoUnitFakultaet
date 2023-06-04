Imports inoUnitFakultät
Imports NUnit.Framework


Namespace inoUnitFakultätTest

    Public Class TestFakulät
        Dim CF As New ClsFunktion

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub TestFakultaet()
            Dim Eingabe As Short
            Dim Vorgabe As Long
            Dim Ergebnis

            Eingabe = 4
            Vorgabe = 10

            Ergebnis = CF.Fakultaet(Eingabe)

            Assert.AreEqual(Vorgabe, Ergebnis)

            Eingabe = 1000
            Vorgabe = 500500

            Ergebnis = CF.Fakultaet(Eingabe)

            Assert.AreEqual(Vorgabe, Ergebnis)
        End Sub

    End Class

End Namespace