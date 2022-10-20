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
            System.Console.WriteLine("TO DO: Main menu here");
        }

        //about exit
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
       
    }

}