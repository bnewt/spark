using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Spark.Models
{
    public class SparkEntities : DbContext
    {
        public DbSet<Spark> Sparks { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<Flag> Flags { get; set; }
        public DbSet<SparkSuggestion> SparkSuggestions { get; set; }
    }
}