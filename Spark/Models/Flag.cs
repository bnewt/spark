using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.Models
{
    public class Flag
    {
        public int ID { get; set; }
        public int SuggestionID { get; set; }
        public string Description { get; set; }
        public string Outcome { get; set; }
    }
}