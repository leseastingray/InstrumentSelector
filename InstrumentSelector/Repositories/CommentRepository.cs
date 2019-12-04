using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        public List<Comment> Comments => throw new NotImplementedException();

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentByInstrument(string instrument)
        {
            throw new NotImplementedException();
        }
    }
}
