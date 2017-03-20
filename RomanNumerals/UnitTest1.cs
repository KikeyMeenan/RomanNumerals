using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.Models;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumerals
    {
        private Converter converter = new Converter();

        [TestMethod]
        public void HandlesI()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(1), "I");
            Assert.AreEqual(converter.ConvertNumberToNumerals(2), "II");
            Assert.AreEqual(converter.ConvertNumberToNumerals(3), "III");
        }

        [TestMethod]
        public void HandlesIV()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(4), "IV");
        }

        [TestMethod]
        public void HandlesV()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(5), "V");
        }

        [TestMethod]
        public void SumsVandI()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(6), "VI");
            Assert.AreEqual(converter.ConvertNumberToNumerals(7), "VII");
            Assert.AreEqual(converter.ConvertNumberToNumerals(8), "VIII");
        }

        [TestMethod]
        public void HandlesX()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(10), "X");
            Assert.AreEqual(converter.ConvertNumberToNumerals(20), "XX");
            Assert.AreEqual(converter.ConvertNumberToNumerals(30), "XXX");
        }

        [TestMethod]
        public void HandlesIX()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(9), "IX");
        }

        [TestMethod]
        public void HandlesL()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(50), "L");
        }

        [TestMethod]
        public void HandlesXL()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(40), "XL");
        }

        [TestMethod]
        public void HandlesC()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(100), "C");
        }

        [TestMethod]
        public void SumsLXVandI()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(77), "LXXVII");
        }

        [TestMethod]
        public void SumsHardCases()
        {
            Assert.AreEqual(converter.ConvertNumberToNumerals(14), "XIV");
            Assert.AreEqual(converter.ConvertNumberToNumerals(16), "XVI");
            Assert.AreEqual(converter.ConvertNumberToNumerals(19), "XIX");
            Assert.AreEqual(converter.ConvertNumberToNumerals(140), "CXL");
            Assert.AreEqual(converter.ConvertNumberToNumerals(44), "XLIV");
        }
    }
}
