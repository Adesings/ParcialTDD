using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace ParcialTDDTest
{
    [TestClass]
    public class CalcudoraTest
    {
        //Ejercicio 1
        [TestMethod]
        public void SumaNumerica()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.Suma(1, 1);

            Assert.AreEqual(2, resultado);
        }
        //Ejercicio 2
        [TestMethod]
        public void SumaDosDigitosTipoCaracter()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.SumaChar("4", "2");

            Assert.AreEqual(6, resultado);
        }
        //Ejercicio 3
        [TestMethod]
        public void SumarDosDigitosTipoCaracterCero()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.SumaChar2(" ", " ");

            Assert.AreEqual(0, resultado);
        }
        //Ejercicio 4
        [TestMethod]
        public void RestarDosNumeros()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.Resta(3, 1);

            Assert.AreEqual(2, resultado);
        }
        //Ejercicio 5
        [TestMethod]
        public void MultiplicarDosNumeros()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.Multiplicacion(3, 3);

            Assert.AreEqual(9, resultado);
        }
        //Ejercicio 6
        [TestMethod]
        public void MultiplicarDosNumeros2()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.Multiplicacion2(5, 0);

            Assert.AreEqual(0, resultado);
        }
        //Ejercicio 7
        [TestMethod]
        public void RaizCuadradaDeDosNumeros()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            double resultado = cal.RaizCuadrada(49);

            Assert.AreEqual(7, resultado);

        }
        //Ejercicio 8
        [TestMethod]
        public void ResultadoDeUnaPotencia()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            double resultado = cal.Potencia(8, 2);

            Assert.AreEqual(64, resultado);
        }
        //Ejercicio 9
        [TestMethod]
        public void DividirDosNumeros()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            int resultado = cal.Division(9, 3);

            Assert.AreEqual(3, resultado);
        }
        //Ejercicio 10
        [TestMethod]
        public void RedondearDecimal()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            double resultado = cal.Redondear(7, 2);

            Assert.AreEqual(Math.Round(3.5), resultado);     
        }
        //Ejercicio 11
        [TestMethod]
        public void ResiduoDivision()
        {
            CalculadoraSimple cal = new CalculadoraSimple();

            double resultado = cal.Residuo(7, 3);

            Assert.AreEqual(1, resultado);
        }


    }
}
