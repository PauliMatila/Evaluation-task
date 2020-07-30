using System;

namespace Evaluation_task
{
    /// <summary>
    /// Class that handles the picking some values for car object from predeterminated array of values.
    /// </summary>
    public class TestDataGenerator
    {
        /// <summary>
        /// Gets a random string from the lenght of an array.
        /// </summary>
        /// <param name="names"></param>
        /// <returns>Returns one random index from array.</returns>
        public static string GetRandomStringFromArray(string[] names)
        {
            Random rand = new Random();
            int index = rand.Next(names.Length);
            return names[index];
        }
        /// <summary>
        /// Gets a random int from the length of an array.
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns one random index from array.</returns>
        public static int GetRandomIntFromArray(int[] values)
        {
            Random rand = new Random();
            int index = rand.Next(values.Length);
            return values[index];
        }
        /// <summary>
        /// Uses the two methods above to generate random values for a car object.
        /// </summary>
        /// <returns>Returns car object with values.</returns>
        public static Car GenerateRandomCar()
        {
            Car car = new Car();
            car.brand = GetRandomStringFromArray(Car.carBrands);
            car.maxSpeed = GetRandomIntFromArray(Car.speed);
            car.trottle = GetRandomIntFromArray(Car.trottleSpeed);
            car.breaking = GetRandomIntFromArray(Car.breakingSpeed);
            car.turnRate = GetRandomIntFromArray(Car.turningSpeed);
            return car;
        }
    }
}
