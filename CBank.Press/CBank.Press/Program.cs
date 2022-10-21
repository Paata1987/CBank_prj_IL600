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
                    case 1: CustomersMenu();break;
                    case 2: AccountsMenu();break;
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


    //customers menu

    static void CustomersMenu()
    {
        //variable to store customers menu choice 
        int customersMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print customers menu 
            System.Console.WriteLine("\n:::Customers menu:::");
            System.Console.WriteLine("1. Add Customer ");
            System.Console.WriteLine("1. Delete Customer ");
            System.Console.WriteLine("1. Update Customer ");
            System.Console.WriteLine("1. View Customer ");
            System.Console.WriteLine("0. Back to main menu  ");

            //accept menu choice from keyboard
            System.Console.WriteLine("Enter choice: ");
            customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (customersMenuChoice !=0);
    }


    //acounts menu

    static void AccountsMenu()
    {
        //variable to store accounts menu choice 
        int accountsMenuChoice = -1;


        //do-while loop starts
        do
        {
            //print accounts menu 
            System.Console.WriteLine("\n:::Accounts menu:::");
            System.Console.WriteLine("1. Add Account ");
            System.Console.WriteLine("1. Delete Account ");
            System.Console.WriteLine("1. Update Account ");
            System.Console.WriteLine("1. View Account ");
            System.Console.WriteLine("0. Back to main menu  ");

            //accept menu choice from keyboard
            System.Console.WriteLine("Enter choice: ");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (accountsMenuChoice != 0);
    }

}