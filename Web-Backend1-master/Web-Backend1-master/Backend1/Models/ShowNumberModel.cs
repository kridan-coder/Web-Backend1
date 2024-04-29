using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Models
{
    public class ShowNumberModel
    {

        public string Title { get; set; }
        public int GeneratedNumber1 { get; set; }
        public int GeneratedNumber2 { get; set; }

        public int AdditionResult { get; set; }
        public int SubstractionResult { get; set; }
        public int MultiplicationResult { get; set; }
        public int? DivisionResult { get; set; }

    }
}
