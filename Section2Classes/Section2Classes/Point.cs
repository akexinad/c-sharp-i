using System;

namespace Section2Classes
{
    public class Point
    {
        /*
        * 
        * OBJECT INITIALIZERS
        * ===================
        * 
        * - Object initializers can be used in order to avoid writing too many constructors.
        * 
        * 
        * 
        * 
        * METHODS
        * =======
        * 
        * - Signature Of A Method = Name and the number and type of parameters.
        * - Overloading Mthods = Having a method with the same name bbut different signatures.
        * - The Params Modifier = This allows to pass in various object paramters without having to initialize the class that creates the object.
        * 
        * The modifiers below are CODE SMELLS
        * - Ref Modifier
        * - Out Modifier
        * 
        */

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;

            // Instead of repeating the above lines in the overload, we can just call the previous Move method and pass
            //      in these arguments.

            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
                
            Move(newLocation.X, newLocation.Y);
        }

    }
}
