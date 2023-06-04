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
            Dim Ergebnis
            Ergebnis = CF.Fakultaet()

            Assert.AreEqual(0, Ergebnis)
        End Sub

    End Class

End Namespace