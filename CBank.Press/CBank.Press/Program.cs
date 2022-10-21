class Program
{
    //Application
    static void Main()
    {
        //display title
        System.Console.WriteLine("**********CBank***********");
        System.Console.WriteLine("::Login Page::");

        //declare  variables to store username and password;
        string userName = null, password = null;

        //read username from Keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        //read pasword from keyboard only if username is entered
        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if (userName =="system" && password =="manager")
        {
            //declare variable to menu choice
            int mainMenuChoice = -1;
            do
            {
                //show main menu
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1. Customers ");
                System.Console.WriteLine("2. Acounte ");
                System.Console.WriteLine("3. Funds Transfer ");
                System.Console.WriteLine("4. Funds Transfer Statements ");
                System.Console.WriteLine("5. Account Statements ");
                System.Console.WriteLine("0. Exit ");

                //Accept menu choice from key
                System.Console.Write("Enter choice ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1: //TO DO : Display Customers menu
                        break;
                    case 2: //TO DO : Display Acounte menu
                        break;
                    case 3: //TO DO : Display Transfer menu
                        break;
                    case 4: //TO DO : Display Transfer Statements menu
                        break;
                    case 5: //TO DO : Display Account Statements menu
                        break;
                }
            } while (mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid Username  or  password");
        }

        //about exit
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
       
    }

}