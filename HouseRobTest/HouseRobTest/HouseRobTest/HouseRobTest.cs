using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HouseRob;

namespace HouseRobTest
{
    [TestClass]
    public class HouseRobTestClass
    {
        [TestMethod]
        public void FindMaxAmount_ReturnNegativeWhenNoHouses()
        {
            HouseRobClass houseRobObject = new HouseRobClass();
            int[] Houses= { };
            int result = houseRobObject.FindMaxAmount(Houses);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]

        public void FindMaxAmount_WithHouses()
        {
            HouseRobClass houseRobObject = new HouseRobClass();
            int[] Houses = {6,7,1,3,8,2,4};
            int result = houseRobObject.FindMaxAmount(Houses);
            Assert.AreNotEqual(18, result);
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void FindMaxAmount_WithNegativeAmount()
        {
            HouseRobClass houseRobObject = new HouseRobClass();
            int[] Houses = { 1, 3, 5,-9, 15, 10 };
            var ex=Assert.ThrowsException<NegativeAmountException>(()=>houseRobObject.FindMaxAmount(Houses));
            Assert.AreEqual(ex.GetErrorMessage(), "Amount cannot be negative");
        }
    }
}
