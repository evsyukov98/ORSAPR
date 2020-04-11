using System;
using KompasGorka.Model;
using NUnit.Framework;

namespace KompasGorka.UnitTests
{
    [TestFixture]
    public class FigureParamsTests
    {
        private FigureParams _figureParams;

        [SetUp]
        public void InitContact()
        {
             _figureParams = new FigureParams(
                 8,
                20,
                80,
                40,
                40,
                20,
                20);
        }
        [Test(Description = "Проверка высоты бордюра")]
        public void TestBorderHeightSet_CorrectValue()
        {
            var actual = 8;
            var expected = _figureParams.BorderHeightC;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка длины конца горки")]
        public void TestEndLengthSet_CorrectValue()
        {
            var actual = 20;
            var expected = _figureParams.EndLengthD;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка длины горки")]
        public void TestMainLengthSet_CorrectValue()
        {
            var actual = 80;
            var expected = _figureParams.MainLengthL;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка высоты платформы")]
        public void TestPlatformHeightSet_CorrectValue()
        {
            var actual = 40;
            var expected = _figureParams.PlatformHeightG;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка длины платформы")]
        public void TestPlatformLengthSet_CorrectValue()
        {
            var actual = 40;
            var expected = _figureParams.PlatformLengthF;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка ширины горки")]
        public void TestSlideWidthSet_CorrectValue()
        {
            var actual = 20;
            var expected = _figureParams.SlideWidthA;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка длина начала горки")]
        public void TestStartLengthSet_CorrectValue()
        {
            var actual = 20;
            var expected = _figureParams.StartLengthE;
            Assert.AreEqual(actual, expected,
                "Проверка на правильные значения");
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Высота бордюра")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Высота бордюра")]
        public void TestBorderHeightSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.BorderHeightC  = wrongParam; },
                message);
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Конец горки")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Конец горки")]
        public void TestEndLengthSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.EndLengthD = wrongParam; },
                message);
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Длина горки")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Длина горки")]
        public void TestMainLengthSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.MainLengthL = wrongParam; },
                message);
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Высота платформы")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Высота платформы")]
        public void TestPlatformHeightSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.PlatformHeightG = wrongParam; },
                message);
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Длина платформы")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Длина платформы")]
        public void TestPlatformLengthSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.PlatformLengthF = wrongParam; },
                message);
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Ширина гокри")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Ширина гокри")]
        public void TestStatLengthSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.SlideWidthA = wrongParam; },
                message);
        }

        [TestCase(1, "Исключение, если число меньше граничных значений",
            TestName = "Присвоение меньшего числа - Длина начала горки")]
        [TestCase(1000, "Исключение, если число больше граничных значений",
            TestName = "Присвоение большего числа - Длина начала горки")]
        public void TestSlideWidthSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _figureParams.StartLengthE = wrongParam; },
                message);
        }

    }
}
