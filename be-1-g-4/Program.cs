using System.ComponentModel.Design;

namespace be_1_g_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("==============OPERAZIONI===============");
            Console.WriteLine("Scegli l'operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica ora e data di login");
            Console.WriteLine("4. Chiudi");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    User.Login();
                    break;
                case "2":
                    User.Logout();
                    break;
                case "3":
                    User.CheckDateLogin();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Inserisci un'opzione valida");
                    break;
            }
            Menu();
        }
    }
    

    public static class User
    {
        public static string username;
        public static string password;
        public static bool IsLogged;
        public static DateTime DateTimeLog;

        public static void Login()
        {
            Console.WriteLine("Inserisci il tuo username");
            User.username = Console.ReadLine();

            Console.WriteLine("Inserisci la tua password");
            User.password = Console.ReadLine();

            Console.WriteLine("Conferma la password");
            string conferma = Console.ReadLine();

            if ((User.password == conferma) && (User.username != ""))
            {
                IsLogged = true;
                DateTimeLog = DateTime.Now;
                Console.WriteLine($"Login effettutato alle {DateTimeLog}, benvenuto {username}!");
            }
            else
            {
                Console.WriteLine("Errore nell'autenticazione");
            }
        }
        public static void Logout()
        {
            if (IsLogged == true){
                username = "";
                password = "";
                IsLogged = false;
                Console.WriteLine("Arrivederci!");
            }
            else { 
                Console.WriteLine("Logout non disponibile, devi prima autenticarti");
            }
        }
        public static void CheckDateLogin()
        {
            if (User.IsLogged == true)
            {
                Console.WriteLine($"{username} si è autenticato alle ore {User.DateTimeLog}");
            }
            else 
            { 
                Console.WriteLine("Nessun utente risulta autenticato");
            }
        }
    }
}
