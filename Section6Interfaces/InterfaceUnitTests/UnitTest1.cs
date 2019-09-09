using System;
using Testability;
using Xunit;

namespace InterfaceUnitTests
{
    public class UnitTest1
    {
        // Naming test functions:
        // METHODNAME_CONDITION_EXPECTATION
        [Fact]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                // creating a shipment object will mean that the isShipped property will be set to true;
                Shipment = new Shipment()
            };

            Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
        }

        [Fact]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.True(order.IsShipped);
            Assert.Equal(1, order.Shipment.Cost);
            Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    // We need to create a fake shipping calculator in order to:
        // 1. Pass into the orderProcessor variable test above,
        // 2. Isolate the tests from the actual classes being implemented.
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
