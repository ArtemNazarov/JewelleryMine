using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryMine.Model.Entities
{
    public class Log
    {
        public Guid Id { get; set; }

        public string LogMessage { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
