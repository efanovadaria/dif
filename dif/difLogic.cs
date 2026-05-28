using System;

namespace dif
{
    public static class difLogic
    {
        public static double CalculateTotal(double billAmount, int guests, int tipPercent)
        {
            if (billAmount <= 0)
                throw new ArgumentException("Сумма счета должна быть больше 0.");

            if (guests <= 0)
                throw new ArgumentException("Количество гостей должно быть больше 0.");

            if (tipPercent < 0)
                throw new ArgumentException("Процент чаевых не может быть отрицательным.");

            double total =
                billAmount + (billAmount * tipPercent / 100.0);

            return total / guests;
        }
    }
}