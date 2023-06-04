Imports inoUnitFakultät
Imports NUnit.Framework


Namespace inoUnitFakultätTest

    Public Class TestFakultät
        Dim CF As New ClsFunktion

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub TestFakultaet()
            Dim Eingabe As Long
            Dim Vorgabe As Long
            Dim Ergebnis

            Eingabe = 4
            Vorgabe = 10

            Ergebnis = CF.Fakultaet(Eingabe)

            Assert.AreEqual(Vorgabe, Ergebnis)

            Eingabe = 4294967295
            Vorgabe = 9223372034707292160


            Ergebnis = CF.Fakultaet(Eingabe)

            Assert.AreEqual(Vorgabe, Ergebnis)

            'Eingabe 0
            Eingabe = 0
            Vorgabe = 0

            Ergebnis = CF.Fakultaet(Eingabe)

            Assert.AreEqual(Vorgabe, Ergebnis)


        End Sub

        <Test>
        Public Sub TestFakultaetFehler()
            Dim Eingabe As Long

            'Eingabe zu groß
            Eingabe = 4294967296
            Dim ex = Assert.Throws(Of OverflowException)(Function() CF.Fakultaet(Eingabe))
            Assert.AreEqual("Die Eingabe ist größer als 4294967296 und kann nicht verarbeitet werden.", ex.Message)

        End Sub

    End Class

End Namespace