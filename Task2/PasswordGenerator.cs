using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Клас для генерації пароля
    /// </summary>
    internal class PasswordGenerator
    {
        // Об'єкт класу Random для генерації випадкових чисел
        private static Random random = new Random();

        /// <summary>
        /// Метод, який генерує пароль
        /// </summary>
        /// <param name="length"></param>
        /// <param name="uppercasePercent"></param>
        /// <param name="lowercasePercent"></param>
        /// <param name="numberPercentage"></param>
        /// <param name="specialCharsPercent"></param>
        /// <returns>Пароль у вигляді рядка string</returns>
        /// <exception cref="ArgumentException">Якщо передані некоректні відсотки</exception>
        public static string GeneratePassword(int length, double uppercasePercent, double lowercasePercent, double numberPercentage, double specialCharsPercent)
        {
            if (!CheckPercentage(uppercasePercent, lowercasePercent, numberPercentage, specialCharsPercent))
            {
                throw new ArgumentException("Invalid percentage");
            }
            
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "_-,.@!#";

            StringBuilder password = new StringBuilder(length);

            int numUppercase = (int)Math.Round(length * uppercasePercent / 100);
            int numLowercase = (int)Math.Round(length * lowercasePercent / 100);
            int numDigits = (int)Math.Round(length * numberPercentage / 100);
            int numSpecialChars = (int)Math.Round(length * specialCharsPercent / 100);

            AddRandomChars(password, uppercaseChars, numUppercase);
            AddRandomChars(password, lowercaseChars, numLowercase);
            AddRandomChars(password, digits, numDigits);
            AddRandomChars(password, specialChars, numSpecialChars);

            Shuffle(password);

            return password.ToString();
        }

        /// <summary>
        /// Булевий метод, який перевіряє коректність переданих відсотків
        /// </summary>
        /// <param name="uppercasePercent">Відсоток великих літер</param>
        /// <param name="lowercasePercent">Відсоток маленьких літер</param>
        /// <param name="digitsPercent">Відсоток чисел</param>
        /// <param name="specialCharsPercent">Відсоток спеціальних символів</param>
        /// <returns>true, якщо передані відсоткі коректні (сума = 100)</returns>
        private static bool CheckPercentage(double uppercasePercent, double lowercasePercent, double digitsPercent, double specialCharsPercent)
        {
            return uppercasePercent + lowercasePercent + digitsPercent + specialCharsPercent == 100;
        }

        /// <summary>
        /// Метод, який додає випадкові символи до паролю
        /// </summary>
        /// <param name="password">Рядок-пароль</param>
        /// <param name="chars">Символи, які треба додати до паролю</param>
        /// <param name="count">Кількість символів, які треба додати</param>
        private static void AddRandomChars(StringBuilder password, string chars, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(chars.Length);
                password.Append(chars[index]);
            }
        }

        /// <summary>
        /// Метод, який перемішує пароль для поліпшення випадковості
        /// </summary>
        /// <param name="password">Пароль, який треба перемішати</param>
        private static void Shuffle(StringBuilder password)
        {
            int n = password.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                char value = password[k];
                password[k] = password[n];
                password[n] = value;
            }
        }
    }
}
