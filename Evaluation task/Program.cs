namespace Evaluation_task
{
    class Program
    {
        /// <summary>
        /// Starts console program with main menu.
        /// calls from MenuUI Class with OpenMainMenu method.
        /// Main Menu shows program switch case options.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
                       
            MenuUI mainMenu = new MenuUI();
            mainMenu.OpenMainMenu();
        }
    }
}
