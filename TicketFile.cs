using System;

namespace TicketingSystem
{
    public class TicketFile
    {
        public string filePath { get; set; }
        public TicketFile(string ticketFilePath)
        {
            filePath = ticketFilePath;
        }
    }
}