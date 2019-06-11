using System;

namespace Trigonometric
{
    /// @Author Chris Kalms
    /// @Created 09/05/19
    /// @Version 2.0 
    /// <summary>
    /// Class <c>Trigonometry</c> holds Trigonometry functions
    /// that perform calculations on inputted data.
    /// </summary>
    public class Trigonometry
    {
        /// <summary>
        /// Performs calculation on degrees to find the tangent.
        /// </summary>
        /// <param name="degrees">The degrees value to find 
        ///    tangent from. </param>
        /// <param name="tan">The value of tan to be output after 
        ///    calculation.</param>
        /// <returns>False if tan(90) is invalid. Otherwise True.</returns>
        public static bool DegreesTan(double degrees, out double tan)
        {            
            double checkForInvalidInput = degrees / 90;
            bool valid = true;
                        
            if (degrees % 90 == 0 && checkForInvalidInput % 2 != 0)
            {
                tan = 0;
                valid = false;
            }            
            else if (degrees % 90 == 0 && checkForInvalidInput % 2 == 0)
                tan = 0;            
            else            
                tan = Math.Tan(ConvertToRadians(degrees));
            
            return valid;
        }

        /// <summary>
        /// Performs calculation on degrees to find the sine.
        /// </summary>
        /// <param name="degrees">The degree value to find 
        ///    sine from.</param>
        /// <returns>The sine of degrees.</returns>
        public static double DegreesSin(double degrees)
        {   
            double check = degrees / 90;
            double returnValue;
            if (degrees == 0)            
                returnValue = 0;
            if (degrees % 90 == 0 && check % 2 == 0)            
                returnValue = 0;            
            else if (degrees % 90 == 0 && (check - 1) % 4 == 0)            
                returnValue = 1;
            else if (degrees % 90 == 0)
                returnValue = -1;
            else
                returnValue = Math.Sin(ConvertToRadians(degrees));

            return returnValue;
        }

        /// <summary>
        /// Performs calculation on degrees to find the cosine.
        /// </summary>
        /// <param name="degrees">The Degree value to find cosine from.</param>
        /// <returns>The cosine of degrees</returns>
        public static double DegreesCos(double degrees)
        {
            double returnValue;
            if (degrees == 0)            
                returnValue = 1;            
            
            double check = degrees / 90;            

            if (degrees % 90 == 0 && check % 2 == 0)
                if ((degrees / 180) % 2 == 0)
                    returnValue = 1;
                else
                    returnValue = -1;
            
            else if (degrees % 90 == 0)
                returnValue = 0;
            else
                returnValue = Math.Cos(ConvertToRadians(degrees));
            
            return returnValue;
        }

        /// <summary>
        /// Convert degrees to radians
        /// </summary>
        /// <param name="degrees">The value to be converted</param>
        /// <returns>The Radian equivalent to the degrees inputted.</returns>
        private static double ConvertToRadians(double degrees)
        {            
            return degrees * Math.PI / 180;
        }
    }
}
