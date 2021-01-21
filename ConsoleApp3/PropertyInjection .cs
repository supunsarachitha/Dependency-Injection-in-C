using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    public interface INofificationAction
    {
        void ActOnNotification(string message);
    }
    class atul
    {
        INofificationAction task = null;
        public void notify(INofificationAction at, string messages)
        {
            this.task = at;
            task.ActOnNotification(messages);
        }
    }
    class EventLogWriter : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            // Write to event log here
        }
    }
    class PropertyInjection
    {
        static void Main(string[] args)
        {
            EventLogWriter elw = new EventLogWriter();
            atul at = new atul();
            at.notify(elw, "to logg");
            Console.ReadKey();
        }
    }
}
