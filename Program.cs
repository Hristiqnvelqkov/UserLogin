using System;

namespace UserLogin
{

    class Program
    {
        private const String CONTINUE_LOOP = "YES";
        private const int EXIT = 1;
        private const int CHANGE_USER_ROLE = 2;
        private const int CHANGE_USER_ACTIVITY = 3;
        private const int GET_ALL_USERS = 4;
        private const int LOG_ACTIVITY = 5;
        private const int CURRENT_ACTIVITY = 6;
        static void Main(string[] args){
            LoginValidtion.ActionOnError listner = new LoginValidtion.ActionOnError(errorMessage);
            Console.WriteLine("Pedal");
                 
        }
   
        public static void errorMessage(String error){
            Console.WriteLine(error);     
        }

        private void login(String username, string password){
          
        }

        private static void adminMenu(){
            String input = CONTINUE_LOOP;
            Console.WriteLine("You are logged as administrator please select one of the following");
            int selector;
            while (input.Equals(CONTINUE_LOOP)){
                Console.WriteLine("Press 1 for exit");
                Console.WriteLine("Press 2 for change userRole");
                Console.WriteLine("Press 3 for change userActivity");
                Console.WriteLine("Press 4 for get all user");
                Console.WriteLine("Press 5 for log activity");
                Console.WriteLine("Press 6 for get current Activity");
                try{
                    selector = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e){
                    Console.WriteLine(e);
                    continue;
                }
                switch(selector){
                    case EXIT:
                    return;
                    case CHANGE_USER_ROLE:
                       UserManager.getInstance().changeUserRole(UserManager.getInstance().findUserByUsername());
                       break;
                    case CHANGE_USER_ACTIVITY:
                        Console.WriteLine("Enter username");
                        String username = Console.ReadLine();
                        User user = UserManager.getInstance().getUserByUsername(username);
                        Console.WriteLine("Enter valid date");
                        string dateString = Console.ReadLine();
                        DateTime time = Tools.getDateByString(dateString);
                        break;
                    case  GET_ALL_USERS:
                        foreach(User currentUser in UserManager.getInstance().getAllUsers()){
                            Console.WriteLine(currentUser.getUsername());
                        }  
                    break;
                
                }
            }
        }
       
    }
}
