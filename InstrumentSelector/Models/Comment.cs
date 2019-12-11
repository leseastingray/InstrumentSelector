using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstrumentSelector.Models
{
    public class Comment
    {
        // Primary Key ID
        public int CommentID { get; set; }

        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }
        public String UserName { get; set; }
        public String Instrument { get; set; }
    }
}
