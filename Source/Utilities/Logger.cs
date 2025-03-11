namespace AISmartCodeWithCSharp14.Utilities;
public class Logger
{
    /*Before AI Refactoring Code*/
    //public void LogMessage(string message)
    //{
    //    if (!string.IsNullOrEmpty(message))
    //    {
    //        Console.WriteLine(message);
    //    }
    //}

    /*After AI Refactoring Code*/
    public void LogMessage(string message)=>
        Console.WriteLine(message ?? "Default log message");
    

}
