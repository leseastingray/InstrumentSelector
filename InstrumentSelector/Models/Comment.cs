﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstrumentSelector.Models
{
    public class Comment
    {
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }
        public User UserName { get; set; }
        public Instrument Instrument { get; set; }
    }
}
