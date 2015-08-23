using System;


namespace Log4NetExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            log4net.GlobalContext.Properties["Tier"] = "API";

            var log = log4net.LogManager.GetLogger(typeof(Program));
            log.Error(DateTime.Now.ToString(), new NullReferenceException());
            var a = new DateTime();
            Console.WriteLine(a.AddDays(1).AddTicks(-1));
            Console.WriteLine(a.AddDays(1));
            
        }
    }
}
