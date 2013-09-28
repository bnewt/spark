using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.Models
{
    public class Suggestion
    {
        public int ID { get; set; }
        public int SparkID { get; set; }
        public int ParentSuggestionID { get; set; }
        public int UpvoteCount { get; set; }
        public bool Active { get; set; }
    }
}