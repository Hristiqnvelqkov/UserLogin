using System;
namespace UserLogin{
    public enum UserRoles{
        ADMINISTRATOR, PROFESOR, STUDENT, INSPECTOR
    }
    public class User{
        private string username;
        private string password;
        private DateTime validDate;
        private UserRoles role;
        public User(string username, string password){
            this.username = username;
            this.password = password;
            this.validDate = new DateTime();
        }
        public void setUsername(string username){
            this.username = username;
        }

        public string getUsername(){
            return username;
        }
        public void setPassword(string password){
            this.password = password;
        }

        public string getPassword(){
            return password;
        }

        public void setUserRole(UserRoles role){
            this.role = role;
        }
        public UserRoles getUerRole(){
            return role;
        }
    }
}