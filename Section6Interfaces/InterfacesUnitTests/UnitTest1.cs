using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfacesUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor();
        }
    }
}
