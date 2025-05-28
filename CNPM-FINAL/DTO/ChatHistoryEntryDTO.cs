using System;

namespace CNPM_FINAL.DTO
{
    public class ChatHistoryEntryDTO
    {
        public DateTime timestamp { get; set; }
        public string userInput { get; set; }
        public string chatbotResponse { get; set; }
    }
}
