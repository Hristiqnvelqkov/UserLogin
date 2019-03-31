using System;
using System.Collections.Generic;
namespace UserLogin{
    class UserManager{
        private LinkedList<User> allUsers = new LinkedList<User>();
        private static UserManager instance = new UserManager();
        private UserManager(){

        }
        public void addUser(ref User user){
            allUsers.AddLast(user);
        }

        public void removeUser(ref User user){
            allUsers.Remove(user);
        }
    
        public void changeUserRole(User user){
            Console.WriteLine("Select user role one of ADMINISTRATOR, STUDENT, PROFESOR, INSPECTOR");
            string role = Console.ReadLine();
            switch(role.ToUpper().Trim()){
                case "ADMINISTRATOR":
                    user.setUserRole(UserRoles.ADMINISTRATOR);
                break;
                case "STUDENT":
                    user.setUserRole(UserRoles.STUDENT);
                break;
                case "INSPECTOR":
                    user.setUserRole(UserRoles.INSPECTOR);
                break;
                case "PROFESOR":
                    user.setUserRole(UserRoles.PROFESOR);  
                break;
                default:
                    changeUserRole(user);
                    break;
            }
        }
        
        public LinkedList<User> getAllUsers(){
            return allUsers;
        }
        public static UserManager getInstance(){
            return instance;
        }
        public User getUserByUsername(string username){
            foreach(User user in allUsers){
                if(user.getUsername().Equals(username)){
                    return user;
                }
            }
            return null;
        }
           public User findUserByUsername(){
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            foreach(User user in allUsers){
                if(user.getUsername().Equals(username)){
                    return user;
                }
            }
            return null;
        }
       
        public bool isUserExist(ref User user){
            bool status = false;
            status = allUsers.Contains(user);
            return status;
        }
    }
}