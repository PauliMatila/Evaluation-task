using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_task
{
    /// <summary>
    /// Car class contains variables for makeing car object and methods for doing stuff with it.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Boolean variable for engine check.
        /// </summary>
        public bool isEngineOn = false;

        /// <summary>
        /// Integer variable for car speed.
        /// </summary>
        public int velocity;

        /// <summary>
        /// Integer variable for saveing generated trottle value for car.
        /// </summary>
        public int trottle;

        /// <summary>
        /// Integer variable for saveing generated breaking value for car.
        /// </summary>
        public int breaking;

        /// <summary>
        /// Integer variable for cars orientation angle.
        /// </summary>
        public int degree;

        /// <summary>
        /// String variable for saveing generated brand name value for car.
        /// </summary>
        public string brand;

        /// <summary>
        /// Integer variable for saveing generated max speed value for car.
        /// </summary>
        public int maxSpeed;

        /// <summary>
        /// Integer variable for saveing generated turn rate value for car.
        /// </summary>
        public int turnRate;

        /// <summary>
        /// Method checks if car object exist to make sure you can't turn the engine on if there isn't one generated already.
        /// </summary>
        /// <returns>This could use any of the randomly generated values as boolean check.</returns>
        public bool CarExists()
        {
            return brand != null;
        }

        /// <summary>
        /// Array of brand names where one gets picked with TestDataGenerator.
        /// </summary>
        public static string[] carBrands =
        {
            "Honda",
            "Toyota",
            "Nissan",
            "BMW",
            "Fiat",
            "Ford",
            "Jaguar",
            "Ferrari"
        };

        /// <summary>
        /// Array of cars max speed where one gets picked with TestDataGenerator.
        /// </summary>
        public static int[] speed =
        {
            200,
            160,
            140,
            120,
            100,
            90,
            80
        };

        /// <summary>
        /// Array of cars trottle rate where one gets picked with TestDataGenerator.
        /// </summary>
        public static int[] trottleSpeed =
        {
            40,
            35,
            30,
            25,
            20,
        };

        /// <summary>
        /// Array of cars breaking rate where one gets picked with TestDataGenerator.
        /// </summary>
        public static int[] breakingSpeed =
        {
            30,
            25,
            20,
            15,
            10
        };

        /// <summary>
        /// Array of turning rate where one gets picked with TestDataGenerator.
        /// </summary>
        public static int[] turningSpeed =
        {
            50,
            45,
            40,
            35,
            30,
            20
        };

        /// <summary>
        /// Variable isEngineOn is false by default. This method turns that to true.
        /// </summary>
        public void StartEngine()
        {
            isEngineOn = true;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Starting engine.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// This method turns the engine off by changeing isEngineOn variable to false.
        /// </summary>
        public void TurnOffEngine()
        {
            isEngineOn = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Turning engine off.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Method uses if-loop that checks if engine is on and if max speed is reached conditions.
        /// Increaces the cars velocity if engine is on and max speed is not reached by randomly generated value.
        /// </summary>
        public void Trottle()
        {          
            if (isEngineOn && velocity <= maxSpeed)
            {
                velocity += trottle;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Increasing speed by {trottle} km/h.\n");
                Console.ResetColor();
            }
            if (isEngineOn && velocity >= maxSpeed)
            {
                velocity = maxSpeed;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Max speed reached. Can't go any faster.\n");
                Console.ResetColor();
            }
            else if (isEngineOn == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Engine is off.\n");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Method uses if-loop that checks if engine is on and if there is any velocity.
        /// Decreases the cars velocity if engine is on and if there is velocity.
        /// </summary>
        public void Break()
        {
            if (isEngineOn && velocity > 0)
            {
                velocity -= breaking;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Decreasing speed by {breaking} km/h.\n");
                Console.ResetColor();
            }
            if (isEngineOn && velocity <= 0)
            {
                velocity = 0;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Car not moveing.\n");
                Console.ResetColor();
            }
            else if (isEngineOn == false || velocity <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Engine must be on and velocity must be higher than zero.\n");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Method uses if-loop that checks if engine is on and there is atleast 10 velocity.
        /// Changes cars orientation angle based on generated turn rate.
        /// This method decreaces the angle. When angle goes below 0 condition is met and angle goes back up to 360 degree.
        /// </summary>
        public void TurnLeft()
        {
            if (isEngineOn && velocity >= 10)
            {
                degree -= turnRate;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Turning left {turnRate}°.\n");
                Console.ResetColor();
            }
            
            if (degree < 0)
            {
                degree += 360;
            }
            
            else if (isEngineOn == false || velocity <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Engine must be on and velocity must be higher or equal 10.\n");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Method uses if-loop that checks if engine is on and there is atleast 10 velocity.
        /// Changes cars orientation angle based on generated turn rate.
        /// This method increases the angle. When angle goes above 360 condition is met and angle goes back up to 0 degree.
        /// </summary>
        public void TurnRight()
        {
            if (isEngineOn && velocity >= 10)
            {
                degree += turnRate;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Turning right {turnRate} °.\n");
                Console.ResetColor();
            }
            
            if (degree > 359)
            {               
                degree -= 360;
            }
            
            else if (isEngineOn == false || velocity <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Engine must be on and velocity must be higher or equal 10.\n");
                Console.ResetColor();
            }
        }
    }
}
