namespace Arithmetic
{
    /// @Author Chris Kalms
    /// @Created 09/05/19
    /// @Version 2.0
    /// <summary>
    /// Class <c>BasicMath</c> holds basic Math functions
    /// that perform calculations on inputted data.
    /// </summary>
    public class BasicMath
    {
        /// <summary>
        /// Performs the addition calculation on the two
        /// inputted paramaters.
        /// </summary>
        /// <param name="addTo">The value to add to.</param>
        /// <param name="additionAmount">The value to add to input</param>
        /// <returns>The Value of the 2 inputs added together.</returns>
    	public static double Addition(double addTo, double additionAmount){
    		return addTo + additionAmount;
    	}

        /// <summary>
        /// Subtracts the second input from the first input.
        /// </summary>
        /// <param name="subtractFrom">The value to be subracted from.</param>
        /// <param name="subtractAmount">The value to subtract.</param>
        /// <returns>The value of the calculation.</returns>
    	public static double Subtraction(double subtractFrom, double subtractAmount){
    		return subtractFrom - subtractAmount;
    	}

        /// <summary>
        /// Divides the first input by the second input.
        /// </summary>
        /// <param name="divideFrom">Value to be divided.</param>
        /// <param name="divisionAmount">Value to divide by.</param>
        /// <param name="result">The out parameter from division.</param>
        /// <returns>True if division was able, False
        ///    if divisionAmount is 0 --DivideByZeroException.</returns>
    	public static bool Division(double divideFrom, double divisionAmount, out double result){
            result = divideFrom / divisionAmount;
            if (divisionAmount == 0)
                return false;
            else
                return true;
    	}

        /// <summary>
        /// Multiplies the first input by the second input. 
        /// </summary>
        /// <param name="toBeMultiplied">The input to be multiplied</param>
        /// <param name="multiplyAmount">The amount to multiply by</param>
        /// <returns>The value of the muliplication calculation</returns>
    	public static double Multiplication(double toBeMultiplied, double multiplyAmount){
    		return toBeMultiplied * multiplyAmount;
    	}
    }
}
