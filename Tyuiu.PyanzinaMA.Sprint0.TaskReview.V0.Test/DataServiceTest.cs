using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PyanzinaMA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int Num1 = 2;
            int Num2 = 4;
            int Num3 = 6;
            int res = DataService.Calc(Num1, Num2, Num3);
            Assert.AreEqual(60, res);
        }
    }
}
