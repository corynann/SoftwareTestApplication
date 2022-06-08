using NUnit.Framework;
using SoftwareTestApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SoftwareTestApplication.UnitTests
{
    [TestFixture]
    public class UnitTest_Basic
    {
        int listLength = 10;


        [SetUp]
        public void Setup()
        {
        }
        #region Ints
        [Test]
        public void FindMaxValueBy_ListOfInts_ReturnsTrue()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<int> values = Utilities.RandomInts(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.LargestValue.Execute(null);

            //Assert
            string maxVal = values.Max().ToString();

            Assert.That(maxVal == mainVM.OutputValues);
        }

        [Test]
        public void FindSumOfEvenValuesBy_ListOfInts_ReturnsTrue()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<int> values = Utilities.RandomInts(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.SumEvenValues.Execute(null);

            //Assert
            string evenSum = values.Where(x => x % 2 == 0).Sum().ToString();

            Assert.That(evenSum == mainVM.OutputValues);
        }
        [Test]
        public void FindSumOfOddValuesBy_ListOfInts_ReturnsTrue()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<int> values = Utilities.RandomInts(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.SumOddValues.Execute(null);

            //Assert
            string oddSum = values.Where(x => (x % 2 != 0 && x % 1 == 0)).Sum().ToString();

            Assert.That(oddSum == mainVM.OutputValues);
        }
        #endregion
        #region Doubles
        [Test]
        public void FindMaxValueBy_ListOfDouble_ReturnsTrue()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<double> values = Utilities.RandomDoubles(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.LargestValue.Execute(null);

            //Assert
            string maxVal = values.Max().ToString();

            Assert.That(maxVal == mainVM.OutputValues);
        }
        [Test]
        public void FindSumOfEvenValuesBy_ListOfDouble_ReturnsTrue()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<double> values = Utilities.RandomDoubles(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.SumEvenValues.Execute(null);

            //Assert
            string evenSum = values.Where(x => x % 2 == 0).Sum().ToString();

            Assert.That(evenSum == mainVM.OutputValues);
        }
        [Test]
        public void FindSumOfOddValuesBy_ListOfDouble_ReturnsTrue()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<double> values = Utilities.RandomDoubles(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.SumOddValues.Execute(null);

            //Assert
            string oddSum = values.Where(x => (x % 2 != 0 && x % 1 == 0)).Sum().ToString();

            Assert.That(oddSum == mainVM.OutputValues);
        }
        #endregion
    }
}