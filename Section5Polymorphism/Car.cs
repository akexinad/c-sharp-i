using System;

namespace Section5Polymorphism
{
    namespace AbstractClasses
    {
        public abstract class Automobile
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            // With abstract methods, the engineer is forced to implement all methods within the abstract class.
            public void Start()
            {
                Console.WriteLine("BROOM");
            }

            public abstract void HasEngine();

            public abstract void HasFourWheels();

            public virtual void HasDiffLock()
            {
                Console.WriteLine("Only 4wd's have diff locks");
            }
        }


        public class FourWD : Automobile
        {
            public override void HasDiffLock() { }
            public override void HasEngine()
            {
                throw new NotImplementedException();
            }

            public override void HasFourWheels()
            {
                throw new NotImplementedException();
            }
        }


        public class Sedan : Automobile
        {
            public override void HasEngine()
            {
                throw new NotImplementedException();
            }

            public override void HasFourWheels()
            {
                throw new NotImplementedException();
            }
        }
    }
}
