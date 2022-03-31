using System;
using Xunit;
using WebApplication2;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSomaDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Soma(5, 3);
            int esperado = 8;

            // Assert
            Assert.Equal(esperado, result);
        }
        [Fact]
        public void TestSomaDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Soma(5.854, 3.369);
            double esperado = 9.223;

            // Assert
            Assert.Equal(esperado, result);
        }
        [Fact]
        public void TestSomaUmNegativo()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Soma(5.854, -3.369);
            double esperado = 2.485;

            // Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void TestDivisaoDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Divisao(5.854, 3.369);
            double esperado = 1.738;

            // Assert
            Assert.Equal(esperado, result, 3);
        }
        [Fact]
        public void TestDivisaoPorNegativo()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Divisao(5.854, -3.369);
            double esperado = -1.738;

            // Assert
            Assert.Equal(esperado, result, 3);
        }
        [Fact]
        public void TestDivisaoPorZero()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Divisao(5.854, 0);
            string esperado = "500";

            // Assert
            Assert.Throws<Exception>(result);
        }
		
		[Fact]
        public void TestSubDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Subtracao(5, 3);
            int esperado = 2;

            // Assert
            Assert.Equal(esperado, result);
        }
		
		[Fact]
        public void TestSubDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Subtracao(5.25, 3.42);
            int esperado = 1.86;

            // Assert
            Assert.Equal(esperado, result);
        }
		
		[Fact]
        public void TestMultDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Multiplicacao(5, 3);
            int esperado = 15;

            // Assert
            Assert.Equal(esperado, result);
        }
		
		[Fact]
        public void TestMultDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Multiplicacao(5.25, 3.42);
            int esperado = 18.06;

            // Assert
            Assert.Equal(esperado, result,2);
        }
		
		[Fact]
        public void TestPoenticaDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Potencia(5, 4);
            int esperado = 625;

            // Assert
            Assert.Equal(esperado, result);
        }
		
		[Fact]
        public void TestRaizQDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.RaizQ(9);
            int esperado = 3;

            // Assert
            Assert.Equal(esperado, result);
        }
		
		[Fact]
        public void TestRaizQDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.RaizQ(9.5);
            int esperado = 3.09;

            // Assert
            Assert.Equal(esperado, result,2);
        }
		
		[Fact]
        public void TestRaizCubDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.RaizCub(8);
            int esperado = 2;

            // Assert
            Assert.Equal(esperado, result);
        }
		
		[Fact]
        public void TestRaizCubDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.RaizCub(8.5);
            int esperado = 2.04;

            // Assert
            Assert.Equal(esperado, result,2);
        }
    }
}
