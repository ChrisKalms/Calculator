using System;

namespace Algebraic
{
    /// @Author Chris Kalms
    /// @Created 09/05/19
    /// @Version 2.0
    /// <summary>
    /// Class <c> Algebra</c> holds Algebraic functions
    /// that perform calculations on inputted data.
    /// </summary>
    public class Algebra
    {
        /// <summary>
        /// Performs Square Root on the inputted value.
        /// </summary>
        /// <param name="valueToSquareRoot">The value to perform the square
        ///    root equation on.</param>
        /// <param name="output">The outputted value from the square root.</param>
        /// <returns>False if the square root is not valid. Otherwise True.</returns>
    	public static bool SquareRoot(double valueToSquareRoot, out double output){
            bool valid = true;
    		output = Math.Sqrt(valueToSquareRoot);
            if (double.IsNaN(output) || double.IsInfinity(output))
                valid = false;
            return valid;
    	}

        /// <summary>
        /// Performs a cube root on the input value.
        /// </summary>
        /// <param name="valueToCubeRoot">The value to perform the cube root
        ///    equation on.</param>
        /// <returns>The cube rooted value.</returns>
    	public static double CubeRoot(double valueToCubeRoot){
            double output;
            if(valueToCubeRoot < 0)
            {
                output = valueToCubeRoot * -1;
                output = Math.Pow(output, 1 / 3.0);
                output = output * -1;
            }
            else
    		    output = Math.Pow(valueToCubeRoot, 1/3.0);
            return output;
    	}

        /// <summary>
        /// Inverts the input value.
        /// </summary>
        /// <param name="valueToBeInverted">The inputted value to be inverted</param>
        /// <param name="output">The output value after inversion.</param>
        /// <returns>False if inversion is not valid. Otherwise True.</returns>
    	public static bool Inverse(double valueToBeInverted, out double output){
            bool valid = true;
    		output = 1 / valueToBeInverted;
            if (double.IsInfinity(output) || double.IsNaN(output))            
                valid = false; 
            return valid;
    	}
    }
}
