using System;
namespace UserLogin{
    class LoginResp{
        readonly bool isSuccesfull;
        readonly string message;
        public LoginResp(bool isSuccesfull = true, string message = "success"){
            this.isSuccesfull = isSuccesfull;
            this.message = message;
        }
        public bool isLoginSucessfull(){
            return isSuccesfull;
        }

        public string getMessage(){
            return message;
        }

    }
}