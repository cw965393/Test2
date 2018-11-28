using System;
using MathLibrary;


namespace MathOperation.Models
{

    public class MathOperation
    {

        public string Add(decimal Left, decimal Right)
        {
            MyMath routines = new MyMath();
            decimal Result = routines.Add(Left, Right);
            return $"{Left} plus {Right} is: {Result}" ;
        }

        public string Subtract(decimal Left, decimal Right)
        {
            MyMath routines = new MyMath();
            decimal Result = routines.Subtract(Left, Right);
            return $"{Left} minus {Right} is: {Result}" ;
        }
        public string Multiply(decimal Left, decimal Right)
        {
            MyMath routines = new MyMath();
            decimal Result = routines.Multiply(Left, Right);
            return $"{Left} multiplied by {Right} is: {Result}" ;
        }
        public string Divide(decimal Left, decimal Right)
        {
            MyMath routines = new MyMath();
            decimal Result = routines.Divide(Left, Right);
            return $"{Left} divided by {Right} is: {Result}" ;
        }
        


        
    }

}