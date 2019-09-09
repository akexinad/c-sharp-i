using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Section6Interfaces;


namespace Section6Interfaces.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor();
        }
    }
}
