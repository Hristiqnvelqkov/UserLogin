using System;
using System.Collections.Generic;
namespace UserLogin{
    class Logger{
        private static Logger instance = new Logger();
        private LinkedList<Activity> activities = new LinkedList<Activity>();
        private Logger(){}
        public static Logger getInstance(){
            return instance;
        }
        
        public void logActivity(string username, string log){
            User user = UserManager.getInstance().getUserByUsername(username);
            Activity activity = new Activity(user, log);
            FileUtil.writeToFile(activity.toString());
            activities.AddLast(activity);
        } 
         public void logActivity(User user, string log){
            Activity activity = new Activity(user, log);
            FileUtil.writeToFile(activity.toString());
            activities.AddLast(activity);
        } 
    }
}