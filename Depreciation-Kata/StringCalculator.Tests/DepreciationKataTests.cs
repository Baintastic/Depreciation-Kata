using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class DepreciationKataTests
    {
        [TestCase(100,100, 0, 1)]
        [TestCase(18, 100, 10, 5)]
        [TestCase(1000, 2500, 500, 2)]
        public void Calculate_GivenValidAssetCostWithSalvageValueAndAssetOwnedForEntireYear_ShouldReturnDepreciationAmount(double expected, double assetCost, int salvageValue, int usefulLife) {
            //Arrange
            var acquiredDate = new DateTime(2017, 01, 01);
            var financialYearEndDate = new DateTime(2017, 12, 31);
            var sut = new DepreciationKata();
         
            //Act
            var actual = sut.CalculationDepreciationAmount(assetCost ,salvageValue, usefulLife, acquiredDate, financialYearEndDate);
            //Assert

            Assert.AreEqual(expected,actual);
        }


        //[TestCase(50, 100, 0, 1)]
        //public void Calculate_GivenValidAssetCostWithSalvageValueAndAssetOwnedForHalfAYear_ShouldReturnDepreciationAmount(double expected, double assetCost, int salvageValue, int usefulLife)
        //{
        //    //Arrange
        //    var acquiredDate = new DateTime(2016, 07, 01);
        //    var financialYearEndDate = new DateTime(2017, 06, 30);
        //    var sut = new DepreciationKata();

        //    //Act
        //    var actual = sut.CalculationDepreciationAmount(assetCost, salvageValue, usefulLife, acquiredDate, financialYearEndDate);
        //    //Assert

        //    Assert.AreEqual(expected, actual);
        //}
    }
}

