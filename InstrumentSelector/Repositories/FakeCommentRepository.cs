using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class FakeCommentRepository : ICommentRepository
    {
        private static List<Comment> comments = new List<Comment>();
        public FakeCommentRepository()
        {
        }

        public List<Comment> Comments { get { return comments; } }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }


        public Comment GetCommentByInstrument(string instrument)
        {
            throw new NotImplementedException();
        }
    }
}
