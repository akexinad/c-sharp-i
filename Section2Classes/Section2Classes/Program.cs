namespace Section2Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            

            var person = new Person()
            {
                Name = "Benigni"
            };

            person.Introduce("Fellini");

            var p = Person.Parse("Pasolini");
            p.Introduce("Luca");


            var customer = new Customer();

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}
