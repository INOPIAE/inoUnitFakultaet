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

            Eingabe = 10000000000
            Vorgabe = 9223372034707292160

            Ergebnis = CF.Fakultaet(Eingabe)

            Assert.AreEqual(Vorgabe, Ergebnis)

        End Sub

    End Class

End Namespace