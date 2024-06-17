namespace TestProject
{
    public class Figure
    {
        // треугольник: a, b, c - стороны
        public double Square(double a, double b, double c)
        {
            // проверка исходных данных (стороны должны быть больше 0 и должно выполняться неравенство треугольника)
            if ((a <= 0) || (b <= 0) || (c <= 0) || (a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return -1;
            }
           
            // проверка: выполняется ли теорема Пифагора
            // так как неизвестно, какая из заданных сторон является гипотенузой - выполняются 3 проверки
            // площадь прямоугольного треугольника равна половине произведения катетов
            if (PythagoreanTheorem(a, b, c))
            {
                return 0.5 * a * b;
            }

            if (PythagoreanTheorem(c, b, a))
            {
                return 0.5 * c * b;
            }

            if (PythagoreanTheorem(c, a, b))
            {
                return 0.5 * a * c;
            }
            
            // поиск площади по формуле Герона, где p - полупериметр 
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // проверка выполнения теоремы Пифагора
        private bool PythagoreanTheorem(double a, double b, double c)
        {
            if (a * a + b * b == c * c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // круг: r - радиус
        public double Square(double r)
        {
            // проверка исходных данных (радиус должны быть больше 0)
            if (r <= 0)
            {
                return -1;
            }

            return Math.PI * r * r;
        }


        // можно добавить расчет площади для других фигур - например, для прямоугольника
        public double Square(double a, double b)
        {
            // проверка исходных данных 
            if ((a <= 0) || (b <= 0))
            {
                return -1;
            }
            return a * b;
        }
    }
}