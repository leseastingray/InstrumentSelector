using InstrumentSelector.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace InstrumentSelector.Repositories
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            // debugging for migrations
            if (System.Diagnostics.Debugger.IsAttached == false)
            {
                System.Diagnostics.Debugger.Launch();
            }
            if (!context.Comments.Any())
            {
                Comment comment = new Comment
                {
                    CommentText = "This instrument is so heavy!",
                    UserName = "Bob",
                    Instrument = "tuba",
                    CommentTime = DateTime.Now 
                };
                context.Comments.Add(comment);

                context.SaveChanges(); // save all the data
            }
        }
    }
}
