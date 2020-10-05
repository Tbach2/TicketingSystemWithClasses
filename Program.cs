using System;
using NLog.Web;
using System.IO;

namespace TicketingSystem
{
    class Program
    {
        // create static instance of Logger
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {
            string ticketFilePath = Directory.GetCurrentDirectory() + "\\tickets.csv";

            logger.Info("Program started");

            TicketFile ticketFile = new TicketFile(ticketFilePath);

            string choice = "";
            do
            {
                // display choices to user
                Console.WriteLine("1) Add Ticket");
                Console.WriteLine("2) Display All Tickets");
                Console.WriteLine("Enter to quit");
                // input selection
                choice = Console.ReadLine();
                logger.Info("User choice: {Choice}", choice);
            } while (choice == "1" || choice == "2");

            logger.Info("Program ended");
        }
    }
}