using System;
using System.Text;
namespace UserLogin{
    class Activity{
        private readonly User user;
        private readonly DateTime logTime;
        private readonly string activityLog;

        public Activity(User user, String log){
            this.user = user;
            logTime = new DateTime();
            activityLog = log;
        }
        public DateTime getLogTime(){
            return logTime;      
        }
        public User getUser(){
            return user;
        }
   
        public String toString(){
            StringBuilder builder = new StringBuilder();
            builder.Append("USERNAME");
            builder.Append(user.getUsername());
            builder.Append("DATETIME");
            builder.Append(logTime);
            builder.Append("ACTIVITY");
            builder.Append(activityLog);
            return builder.ToString();
        }
    }
}