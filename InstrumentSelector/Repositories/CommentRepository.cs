using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private AppDbContext context;
        private static List<Comment> comments = new List<Comment>();

        public List<Comment> Comments { get { return context.Comments.ToList(); } }

        public CommentRepository(AppDbContext appDBContext)
        {
            context = appDBContext;
        }

        public void AddComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
        }

        public Comment GetCommentByInstrument(string instrument)
        {
            throw new NotImplementedException();
        }
    }
}
