using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;
using System.Windows.Forms;

namespace GestionBancariaTest
{
    [TestClass]
    public class GestionBancariaTest
    {
        [TestMethod]
        public void ValidarReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
        }

        [TestMethod]
        public void ValidarReintegro1()
        {
            // preparación del caso de prueba
            double saldoInicial = 4;
            double reintegro = -1;
            double saldoEsperado = 4;
            int error = -1;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int respuesta = miApp.RealizarReintegro(reintegro);
            miApp.RealizarReintegro(reintegro);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
            Assert.AreEqual(error, respuesta, 0.001, "Se produjo un error al definir el error" + error + "esperado.");
        }

        [TestMethod]
        public void ValidarReintegro2()
        {
            // preparación del caso de prueba
            double saldoInicial = 4;
            double reintegro = 0;
            double saldoEsperado = 4;
            int error = -1;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int respuesta = miApp.RealizarReintegro(reintegro);
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
            Assert.AreEqual(error, respuesta, 0.001, "Se produjo un error al definir el error " + error + " y el esperado " + respuesta);
        }

        [TestMethod]
        public void ValidarReintegro3()
        {
            // preparación del caso de prueba
            double saldoInicial = 5;
            double reintegro = 4;
            double saldoEsperado = 1;
            int error = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int respuesta = miApp.RealizarReintegro(reintegro);
            miApp.RealizarReintegro(reintegro);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
            Assert.AreEqual(error, respuesta, 0.001, "Se produjo un error al definir el error " + error + " y el esperado " + respuesta);
        }

        [TestMethod]
        public void ValidarReintegro4()
        {
            // preparación del caso de prueba
            double saldoInicial = 5;
            double reintegro = 5;
            double saldoEsperado = 0;
            int error = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int respuesta = miApp.RealizarReintegro(reintegro);
            miApp.RealizarReintegro(reintegro);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
            Assert.AreEqual(error, respuesta, 0.001, "Se produjo un error al definir el error " + error + " y el esperado " + respuesta);
        }

        [TestMethod]
        public void ValidarReintegro5()
        {
            // preparación del caso de prueba
            double saldoInicial = 5;
            double reintegro = 6;
            double saldoEsperado = 5;
            int error = 2;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int respuesta = miApp.RealizarReintegro(reintegro);
            miApp.RealizarReintegro(reintegro);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
            Assert.AreEqual(error, respuesta, 0.001, "Se produjo un error al definir el error " + error + " y el esperado " + respuesta);
        }

        [TestMethod]
        public void ValidarIngreso1()
        {
            // preparación del caso de prueba
            double saldoInicial = 10;
            double ingreso = -3;
            double saldoEsperado = 10;
            int output = -1;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            double respuesta = miApp.RealizarIngreso(ingreso);
            miApp.RealizarReintegro(ingreso);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + "incorrecto.");
            Assert.AreEqual(output, respuesta, 0.001, "Se produjo un error al realizar el ingreso, el esperado es  " + output + " y nos da " + respuesta);
        }

        [TestMethod]
        public void ValidarIngreso2()
        {
            // preparación del caso de prueba
            double saldoInicial = 10;
            double ingreso = 0;
            double saldoEsperado = 10;
            int output = -1;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            double respuesta = miApp.RealizarIngreso(ingreso);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + "incorrecto.");
            Assert.AreEqual(output, respuesta, 0.001, "Se produjo un error al realizar el ingreso, el esperado es  " + output + " y nos da " + respuesta);
        }

        [TestMethod]
        public void ValidarIngreso3()
        {
            // preparación del caso de prueba
            double saldoInicial = -10;
            double ingreso = 3;
            double saldoEsperado = 3;
            int output = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            double respuesta = miApp.RealizarIngreso(ingreso);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + " incorrecto.");
            Assert.AreEqual(output, respuesta, 0.001, "Se produjo un error al realizar el ingreso, el esperado es  " + output + " y nos da " + respuesta);
        }

        [TestMethod]
        public void ValidarIngreso4()
        {
            // preparación del caso de prueba
            double saldoInicial = 10;
            double ingreso = 3;
            double saldoEsperado = 13;
            int output = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            double respuesta = miApp.RealizarIngreso(ingreso);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + " incorrecto.");
            Assert.AreEqual(output, respuesta, 0.001, "Se produjo un error al realizar el ingreso, el esperado es  " + output + " y nos da " + respuesta);
        }
    }
}