using System;
namespace UserLogin{
    class LoginValidtion{
        private const int MINIMUM_LENGTH = 5;
        private const int MAXIMUM_LENGTH = 10;
        private ActionOnError listner;
        public static LoginValidtion newInstace(ActionOnError listner){
            LoginValidtion loginValidtion  = new LoginValidtion(listner);
            return loginValidtion;
        }
        private LoginValidtion(ActionOnError listner){
            this.listner = listner;
        }
        public  Boolean  validateUserData(String username,  String password){
            bool status = true;
            status = checkLength(username,"username");
            if(status){
                status = checkLength(password,"password");
            }
            return status;
        }
        private bool checkLength(String testString, string type){
            if(testString.Length == 0){
                listner("Empty " + type);
                return false;
            }
            if(testString.Length < MINIMUM_LENGTH){
                listner("You must enter minumum " + MINIMUM_LENGTH + "chars"); 
                return false;
            }
            if(testString.Length > MAXIMUM_LENGTH){
                listner("Maximum chars is " + MAXIMUM_LENGTH);
                return false;
            }
            return true;
        }

        public delegate void ActionOnError(String error);
    }
}