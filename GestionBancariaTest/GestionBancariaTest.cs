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
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidarReintegro1()
		{
			// preparación del caso de prueba
			double saldoInicial = 4;
			double reintegro = -1;
			double saldoEsperado = 4;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar
			miApp.RealizarReintegro(reintegro);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidarReintegro2()
		{
			// preparación del caso de prueba
			double saldoInicial = 4;
			double reintegro = 0;
			double saldoEsperado = 4;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar

			miApp.RealizarReintegro(reintegro);
			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
		}

		[TestMethod]
		public void ValidarReintegro3()
		{
			// preparación del caso de prueba
			double saldoInicial = 5;
			double reintegro = 4;
			double saldoEsperado = 1;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar

			miApp.RealizarReintegro(reintegro);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
		}

		[TestMethod]
		public void ValidarReintegro4()
		{
			// preparación del caso de prueba
			double saldoInicial = 5;
			double reintegro = 5;
			double saldoEsperado = 0;
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar

			miApp.RealizarReintegro(reintegro);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidarReintegro5()
		{
			// preparación del caso de prueba
			double saldoInicial = 5;
			double reintegro = 6;
			double saldoEsperado = 5;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar
			int respuesta = miApp.RealizarReintegro(reintegro);
			miApp.RealizarReintegro(reintegro);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo" + "incorrecto.");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidarIngreso1()
		{
			// preparación del caso de prueba
			double saldoInicial = 10;
			double ingreso = -3;
			double saldoEsperado = 10;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar
			miApp.RealizarIngreso(ingreso);
			miApp.RealizarReintegro(ingreso);
			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + "incorrecto.");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ValidarIngreso2()
		{
			// preparación del caso de prueba
			double saldoInicial = 10;
			double ingreso = 0;
			double saldoEsperado = 10;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar
			miApp.RealizarIngreso(ingreso);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + "incorrecto.");
		}

		[TestMethod]
		public void ValidarIngreso3()
		{
			// preparación del caso de prueba
			double saldoInicial = -10;
			double ingreso = 3;
			double saldoEsperado = 3;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar
			miApp.RealizarIngreso(ingreso);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + " incorrecto.");
		}

		[TestMethod]
		public void ValidarIngreso4()
		{
			// preparación del caso de prueba
			double saldoInicial = 10;
			double ingreso = 3;
			double saldoEsperado = 13;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			// Método a probar
			miApp.RealizarIngreso(ingreso);

			Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el ingreso, saldo" + " incorrecto.");
		}

		[TestMethod]
		public void validarReintegroCantidadNoValida()
		{
			double saldoInicial = 1000;
			double reintegro = 1250;
			double saldoFinal = saldoInicial - reintegro;
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			try
			{
				miApp.RealizarReintegro(reintegro);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				// assert
				StringAssert.Contains(exception.Message,
			   GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
				return;
			}
			Assert.Fail("Error. Se debía haber producido una excepción.");
		}

		[TestMethod]
		public void validarReintegroCantidadNoValida1()
		{
			double saldoInicial = 1000;
			double reintegro = -250;
			double saldoFinal = saldoInicial - reintegro;
			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			try
			{
				miApp.RealizarReintegro(reintegro);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				// assert
				StringAssert.Contains(exception.Message,
			   GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
			}
			Assert.Fail("Error. Se debía haber producido una excepción.");
		}

		[TestMethod]
		public void ValidarReintegro2bis()
		{
			// preparación del caso de prueba
			double saldoInicial = 4;
			double reintegro = 0;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			try
			{
				miApp.RealizarReintegro(reintegro);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				// assert
				StringAssert.Contains(exception.Message,
			   GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
			}
			Assert.Fail("Error. Se debía haber producido una excepción.");
		}

		[TestMethod]
		public void ValidarIngreso1bis()
		{
			// preparación del caso de prueba
			double saldoInicial = 10;
			double ingreso = -3;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			try
			{
				miApp.RealizarIngreso(ingreso);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				// assert
				StringAssert.Contains(exception.Message,
			   GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
			}
			Assert.Fail("Error. Se debía haber producido una excepción.");
		}

		[TestMethod]
		public void ValidarIngreso2bis()
		{
			// preparación del caso de prueba
			double saldoInicial = 10;
			double ingreso = 0;
			double saldoEsperado = 10;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
			try
			{
				miApp.RealizarIngreso(ingreso);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				// assert
				StringAssert.Contains(exception.Message,
			   GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
				return;
			}
			Assert.Fail("Error. Se debía haber producido una excepción.");
		}

		[TestMethod]
		public void ValidarReintegro5bis()
		{
			// preparación del caso de prueba
			double saldoInicial = 5;
			double reintegro = 6;
			double saldoEsperado = 5;

			GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

			try
			{
				miApp.RealizarReintegro(reintegro);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				// assert
				StringAssert.Contains(exception.Message,
			   GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
				return;
			}
			Assert.Fail("Error. Se debía haber producido una excepción.");
		}
	}
}