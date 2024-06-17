namespace TestProject
{
    public class UnitTests
    {
        // Площадь круга
        // Тест 1. Проверка отрицательного числа
        [Fact]
        public void Test1()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(-1.5);

            // Assert
            Assert.Equal(-1, result);
        }

        // Тест 2. Проверка нуля
        [Fact]
        public void Test2()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(0);

            // Assert
            Assert.Equal(-1, result);
        }

        // Тест 3. Проверка целого положительного числа
        [Fact]
        public void Test3()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = Math.Round(figure.Square(1), 2);

            // Assert
            Assert.Equal(3.14, result);
        }

        // Тест 4. Проверка целого вещественного числа
        [Fact]
        public void Test4()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = Math.Round(figure.Square(2.5), 2);

            // Assert
            Assert.Equal(19.63, result);
        }

        // ==============================================
        // Площадь треугольника.
        // Тест 5. Есть сторона равная нулю
        [Fact]
        public void Test5()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(0, 4, 5);

            // Assert
            Assert.Equal(-1, result);
        }

        // Тест 6. Есть отрицательная сторона
        [Fact]
        public void Test6()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(3, -4, 6);

            // Assert
            Assert.Equal(-1, result);
        }

        // Тест 7. Невыполняется неравенство треугольника
        [Fact]
        public void Test7()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(4, 1, 3);

            // Assert
            Assert.Equal(-1, result);
        }

        // Тест 8. Прямоугольный треугольник
        [Fact]
        public void Test8()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(3, 4, 5);

            // Assert
            Assert.Equal(6, result);
        }

        // Тест 9. Прямоугольный треугольник
        [Fact]
        public void Test9()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(10, 8, 6);

            // Assert
            Assert.Equal(24, result);
        }

        // Тест 10. Равнобедренный треугольник
        [Fact]
        public void Test10()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = Math.Round(figure.Square(5.2, 5.2, 7.1), 2);

            // Assert
            Assert.Equal(13.49, result);
        }

        // Тест 11. Равносторонний треугольник
        [Fact]
        public void Test11()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = Math.Round(figure.Square(4.1, 4.1, 4.1), 2);

            // Assert
            Assert.Equal(7.28, result);
        }

        // Тест 12. Произвольный остроугольный треугольник
        [Fact]
        public void Test12()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = Math.Round(figure.Square(4, 3, 4.4), 2);

            // Assert
            Assert.Equal(5.83, result);
        }

        // Тест 13. Произвольный тупоугольный треугольник
        [Fact]
        public void Test13()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = Math.Round(figure.Square(4, 6.77, 3), 2);

            // Assert
            Assert.Equal(2.98, result);
        }

        // Тест 14. Площадь прямоугольника
        [Fact]
        public void Test14()
        {
            // Arrange
            Figure figure = new Figure();

            // Act
            double result = figure.Square(5, 10);

            // Assert
            Assert.Equal(50, result);
        }
    }
}