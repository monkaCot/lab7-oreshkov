using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    /// <summary>
    /// Класс для расчёта скидок в системе заказов компании «Обувь-Маг».
    /// </summary>
    public class DiscountCalculator
    {
        /// <summary>
        /// Размер скидки для товаров без заказов в прошлом месяце (25%).
        /// </summary>
        public decimal DiscountRate => 0.25m;

        /// <summary>
        /// Рассчитывает цену со скидкой, если по товару не было заказов в прошлом месяце.
        /// </summary>
        /// <param name="basePrice">Базовая цена товара.</param>
        /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом месяце.</param>
        /// <returns>Цена со скидкой или базовая цена.</returns>
        public decimal GetDiscountedPrice(decimal basePrice, bool hasOrdersLastMonth)
        {
            if (hasOrdersLastMonth)
                return basePrice;
            return basePrice * (1 - DiscountRate);
        }

        /// <summary>
        /// Вычисляет сумму скидки для заданной базовой цены.
        /// </summary>
        /// <param name="basePrice">Базовая цена товара.</param>
        /// <returns>Сумма скидки.</returns>
        public decimal CalculateDiscountAmount(decimal basePrice)
        {
            return basePrice * DiscountRate;
        }

        /// <summary>
        /// Выводит в консоль информацию о цене и скидке.
        /// </summary>
        /// <param name="basePrice">Базовая цена.</param>
        /// <param name="discountedPrice">Цена со скидкой.</param>
        public void PrintResult(decimal basePrice, decimal discountedPrice)
        {
            Console.WriteLine($"Базовая цена: {basePrice}");
            Console.WriteLine($"Цена со скидкой: {discountedPrice}");
        }
    }

    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();
            decimal price = 1000m;
            decimal discounted = calculator.GetDiscountedPrice(price, false);
            calculator.PrintResult(price, discounted);
            Console.WriteLine("Автор: Орешков С.А., группа И-41");
            Console.ReadKey();
        }
    }
}