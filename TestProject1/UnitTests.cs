namespace TestProject
{
    public class UnitTests
    {
        // ������� �����
        // ���� 1. �������� �������������� �����
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

        // ���� 2. �������� ����
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

        // ���� 3. �������� ������ �������������� �����
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

        // ���� 4. �������� ������ ������������� �����
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
        // ������� ������������.
        // ���� 5. ���� ������� ������ ����
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

        // ���� 6. ���� ������������� �������
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

        // ���� 7. ������������� ����������� ������������
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

        // ���� 8. ������������� �����������
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

        // ���� 9. ������������� �����������
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

        // ���� 10. �������������� �����������
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

        // ���� 11. �������������� �����������
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

        // ���� 12. ������������ ������������� �����������
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

        // ���� 13. ������������ ������������ �����������
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

        // ���� 14. ������� ��������������
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