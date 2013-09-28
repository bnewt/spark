using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.Models
{
    public class Spark
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set; }
        public DateTime Created { get; set; }
    }
}