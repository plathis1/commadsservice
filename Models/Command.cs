using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsService.Models
{
    public class Command
    {
        public int Id { get; set; }

        public string HowTO { get; set; }  

        public string CommandLine { get; set; } 

        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}