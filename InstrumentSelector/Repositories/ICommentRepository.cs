using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> Comments { get; }
        void AddComment(Comment comment);
        Comment GetCommentByInstrument(string instrument);
    }
}
