using System;

namespace is_authorized
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("För att logga in behöver du ange tre olika lösenord, ett åt gången.");

            bool isAuthorized= false;

            //metodanrop, värdet på isAuthorized är samma som värdet på Authorized. Eftersom båda är bools så fungerar det.
            isAuthorized=Authorized();

            if(isAuthorized==true)
            {
                System.Console.WriteLine("Welcome Doctor!");    
            }
            else
            {
                System.Console.WriteLine("You will be Exterminated!!! \nProgrammet avslutas...");
                Console.ReadKey();
            }


        }
        static bool Authorized()
        {
            bool passWord1= false;
            bool passWord2= false;
            bool passWord3= false;
            int logCount= 1;
            bool isauthorized= false;

            //loop för att man ska få fortsätta ange lösenord tills man antingen fått alla rätt eller har förbrukat alla försök.
            while(isauthorized != true && logCount !=5)
            {
            System.Console.WriteLine("Ange Lösenord:");
            string input= Console.ReadLine();

            //För att kolla om input och något av lösenorden matchade.
            switch(input)
            {
                case "the":
                {
                    System.Console.WriteLine("Rätt lösenord.\n");
                    passWord1=true;
                }break;

                case "doc":
                {
                 System.Console.WriteLine("Rätt lösenord.\n");
                passWord2=true;
                }break;

                case "tor":
                {
                    System.Console.WriteLine("Rätt lösenord.\n");
                    passWord3=true;
                }break;
                default:
                {
                //System.Console.WriteLine($"{passWord1}{passWord2}{passWord3}{logCount}");  //Liten kontroll för mig själv för att se så att det fungerade.
                System.Console.WriteLine("Du har angett fel lösenord.\n");
                logCount++;

                }break;
            }
            // om alla lösenord är rätt så bryts loopen och man är välkommen in.
            if( passWord1 == true && passWord2 == true && passWord3 == true)
            {
                isauthorized = true;
            }
        }
            return isauthorized;
    }
}
}
