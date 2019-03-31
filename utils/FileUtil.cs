using System;
using System.IO;
namespace UserLogin{
public static class FileUtil{
    private const string FILE_NAME = "/home/hristiyan/Desktop/pesho.txt";
    public static void writeToFile(string log){
        if(File.Exists(FILE_NAME)){
            File.AppendAllText(FILE_NAME,log);
        }
    }
    public static String getFileLog(){
        string log = "";
        if(File.Exists(FILE_NAME)){
            log = File.ReadAllText(FILE_NAME);
        }
        return log;
    }
}

}