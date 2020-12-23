using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// подключение NUnit
using NUnit.Framework;

namespace NUnit_Lab
{
    // атрибут, указывающий на то, что это класс содержит тесты
    [TestFixture]
    class ClassTest
    {
        [TestCase]
        public void InchToCm()
        {
            Functions f = new Functions();
            Assert.AreEqual(7.62, f.InchToCm(3));

            var ex = Assert.Throws<ArgumentException>(() => f.InchToCm(-3));
            Assert.That(ex.Message, Is.EqualTo("Входящее значение не может быть меньше, либо равным нулю"));
        }

        [TestCase]
        public void IsEvenNumber()
        {
            Functions f = new Functions();
            Assert.AreEqual(true, f.IsEvenNumber(4));
            Assert.AreEqual(false, f.IsEvenNumber(9));
            Assert.AreEqual(true, f.IsEvenNumber(-8));
            Assert.AreEqual(false, f.IsEvenNumber(-7));
        }

        [TestCase]
        public void MaxElementOnArray()
        {
            int[] arr = new int[] { };
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { -1, -2, -3, -4, -5 };

            Functions f = new Functions();
            Assert.AreEqual(5, f.MaxElementOnArray(arr1));
            Assert.AreEqual(-1, f.MaxElementOnArray(arr2));
            var ex = Assert.Throws<Exception>(() => f.MaxElementOnArray(arr));
            Assert.That(ex.Message, Is.EqualTo("Пустой массив"));
        }

        [TestCase]
        public void RemainerOfDivision()
        {
            Functions f = new Functions();
            Assert.AreEqual(0, f.RemainerOfDivision(-2, 2));
            Assert.AreEqual(1, f.RemainerOfDivision(5, 2));
            Assert.AreEqual(2, f.RemainerOfDivision(5, 3));
            // получение исключения
            var exception = Assert.Throws <Exception> (() => f.RemainerOfDivision(2, 0));
            // сравнение полученного сообщения с ожидаемым
            Assert.That(exception.Message, Is.EqualTo("Делитель не должен быть равен нулю"));
            // проверка выполняется успешно, если исключение не было сгенерировано
            Assert.DoesNotThrow(() => f.RemainerOfDivision(2, 1));

        }
    }
}
