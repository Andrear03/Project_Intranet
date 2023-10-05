using System;

namespace RabbitMQToElasticsearch.Models
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string? Level { get; set; }
        public string? Message { get; set; }
    }
}
