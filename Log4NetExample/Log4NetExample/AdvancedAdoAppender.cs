using log4net.Appender;
using log4net.Core;

namespace Log4NetExample
{
    public class AdvancedAdoAppender:AdoNetAppender
    {
        protected override void SendBuffer(LoggingEvent[] events)
        {
            if (Connection == null)
            {
                ErrorHandler.Error("Can not open database");
            }
            else
            {
                base.SendBuffer(events);    
            }
        }
    }
}
