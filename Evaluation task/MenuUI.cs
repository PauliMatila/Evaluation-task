using System;

namespace Evaluation_task
{
    class MenuUI
    {
        Car car = new Car();
        
        /// <summary>
        /// OpenMainManu method opens main menu structure.
        /// User can choose between options 1-7 or Exit (0).
        /// </summary>
        public void OpenMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        /// <summary>
        /// ShowMainMenu method uses switch case structure.
        /// Cases call diffrent methods from Car class.
        /// </summary>
        /// <returns> returns boolean, false = close menu </returns>
        public bool ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("1) Generate new car.");
            Console.WriteLine("2) Turn the engine on.");
            Console.WriteLine("3) Turn the engine off.");
            Console.WriteLine("4) Trottle.");
            Console.WriteLine("5) Break.");
            Console.WriteLine("6) Turn left.");
            Console.WriteLine("7) Turn right.");
            Console.WriteLine("0) Exit\n");
            Console.ResetColor();
            // If car is not generated, there wont be any information to show.
            if (car.CarExists())
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Your car brand is {car.brand}. Max speed is {car.maxSpeed} km/h. Turn rate is {car.turnRate}°\n");
                Console.WriteLine("Car engine is {0}\n", car.isEngineOn ? "On" : "Off");
                Console.WriteLine($"Car is going {car.velocity} km/h\n");
                Console.WriteLine($"Car orientation is {car.degree}°\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;               
                Console.WriteLine("You dont have car yet. Press (1) to generate car.\n");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Choose an option (1 - 7 or Exit): ");
            Console.ResetColor();

            // Checks if the user has given the correct input between 0 - 7.
            // First checks if the input is numberic with TryParse(Int) method.
            // If it is number, check if the number is between 0 - 7.
            int selected = 0;
            bool inputIsCorrect = false;
            while (!inputIsCorrect)
            {
                bool parseIsCorrect = int.TryParse(Console.ReadLine(), out selected);
                // Check if selected is number. If not show message.
                if (!parseIsCorrect)
                {
                    
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("\nInput number between 1 - 7 or exit (0).");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nChoose an option: ");
                    Console.ResetColor();
                }
                else
                {
                    // If selected was number, check if number is between 0 - 7. If selected was number but not between 0 - 7, show message
                    if (selected < 0 || selected > 7)
                    {                       
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("\nInput number between 1 - 7 or exit (0).");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nChoose an option: ");
                        Console.ResetColor();
                    }
                    // If selected number was between 0 - 7, end while loop.
                    else
                    {
                        inputIsCorrect = true;
                    }
                }
            }
            
            Console.Clear();
            switch (selected)
            {
                // Generates car object with random generated values and shows them to user.
                case 1:                   
                    car = TestDataGenerator.GenerateRandomCar();
                    break;
                // Checks if there is a car object. If there is one, turns the engine on.
                case 2:
                    if (car.CarExists())
                    {
                        car.StartEngine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Generate car first.\n");
                        Console.ResetColor();
                    }
                    break;
                // Checks if there is a car object. If there is one, turns the engine off.
                case 3:
                    if (car.CarExists())
                    {
                        car.TurnOffEngine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Generate car first.\n");
                        Console.ResetColor();
                    }                   
                    break;
                // If car engine is on, increases cars velocity by predetermined amount.
                case 4:
                    car.Trottle();
                    break;
                // If car engine is on and car has more than 10 velocity, decreases cars velocity by predetermined amount.
                case 5:
                    car.Break();
                    break;
                // If car engine is on and car has more than 10 velocity, turn car by predeterminad amount to left.
                case 6:
                    car.TurnLeft();
                    break;
                // If car engine is on and car has more than 10 velocity, turn car by predeterminad amount to right.
                case 7:
                    car.TurnRight();
                    break;
                // Returns false to ShowMainMenu and while loop ends, then closes the application.
                case 0:
                    return false;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press any key");
            Console.ReadLine();
            Console.ResetColor();
            return true;
        }
    }
}
