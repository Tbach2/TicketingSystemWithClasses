using System;
using NLog.Web;
using System.IO;

namespace TicketingSystem
{
    class Program
    {
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {
            string ticketFilePath = Directory.GetCurrentDirectory() + "\\tickets.csv";

            logger.Info("Program started");

            TicketFile ticketFile = new TicketFile(ticketFilePath);

            logger.Info("Program ended");
        }
    }
}