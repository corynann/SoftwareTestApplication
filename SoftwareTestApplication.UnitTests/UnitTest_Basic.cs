using NUnit.Framework;
using SoftwareTestApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SoftwareTestApplication.UnitTests
{
    public class Tests
    {
        int listLength = 5;


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //Scenero_ExpectedBehavior
        public void FindMaxValueBy_ListOfInts_Max()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<int> values = Utilities.RandomInts(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.LargestValue.Execute(null);

            //Assert
            string maxVal = values.Max().ToString();

            bool matchingVal = maxVal == mainVM.OutputValues;
            Assert.IsTrue(matchingVal);
        }

        [Test]
        public void FindMaxValueBy_ListOfInts_SumEvenValues()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<int> values = Utilities.RandomInts(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.SumEvenValues.Execute(null);

            //Assert
            string evenSum = values.Where(x => x % 2 == 0).Sum().ToString();

            bool matchingVal = evenSum == mainVM.OutputValues;
            Assert.IsTrue(matchingVal);
        }
        [Test]
        public void FindMaxValueBy_ListOfInts_SumOddValues()
        {
            //Arrange
            var mainVM = new MainViewModel();
            List<int> values = Utilities.RandomInts(listLength);

            //Act
            mainVM.InputValues = String.Join(",", values.Select(x => x.ToString()).ToArray());
            mainVM.SumOddValues.Execute(null);

            //Assert
            string oddSum = values.Where(x => (x % 2 != 0 && x % 1 == 0)).Sum().ToString();

            bool matchingVal = oddSum == mainVM.OutputValues;
            Assert.IsTrue(matchingVal);
        }
    }
}