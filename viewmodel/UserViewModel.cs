using System;
namespace UserLogin{
    class UserViewModel{
        public User login(string username,string password,LoginValidtion loginValidtion){
            if(loginValidtion.validateUserData(username,password)){
                return UserManager.getInstance().getUserByUsername(username);
            }
            return null;
        }

        public void register(string username, string password, UserRoles role,LoginValidtion loginValidation){
            if(loginValidation.validateUserData(username, password)){
                User user = new User(username,password);
                user.setUserRole(role);
                UserManager.getInstance().addUser(ref user);
            }
        }
    }
}