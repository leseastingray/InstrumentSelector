using System;
using System.Collections.Generic;
using InstrumentSelector.Models;
using InstrumentSelector.Repositories;
using InstrumentSelector.Controllers;

using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentSelectorTests
{
    public class HomeTests
    {
        // Test 1, CommentTest: PASSED
        [Fact]
        public void CommentTest()
        {
            // Arrange
            var repo = new FakeCommentRepository();
            var homeController = new HomeController(repo);
            var testComment = new Comment()
            {
                CommentText = "This instrument sounds cool!",
                UserName = "ElizaReeds",
                Instrument = "oboe",
                //MessageDate = new DateTime(2019, 11, 30, 10, 0, 0, 0)
            };
            // Act
            homeController.Comment(testComment);
            // Assert
            Assert.Equal("ElizaReeds", repo.Comments[repo.Comments.Count - 1].UserName);
        }
        // Test 1, GetCommentsTest: PASSED
        [Fact]
        public void GetCommentsTest()
        {
            // Arrange
            var repo = new FakeCommentRepository();
            AddTestComments(repo);
            var homeController = new HomeController(repo);
            // Act
            var result = (ViewResult)homeController.GetComments();
            var comments = (List<Comment>)result.Model;
            // Assert that the comments are in the correct order by DateTime and also
            // that there are the same amount of comments, s1 > s2 returns -1
            Assert.True(DateTime.Compare(comments[0].CommentTime, comments[1].CommentTime) < 0 &&
            DateTime.Compare(comments[1].CommentTime, comments[2].CommentTime) < 0);
        }
        // Method to add test comments
        public void AddTestComments(FakeCommentRepository repo)
        {
            // Test comment 1 [0]
            Comment comment1 = new Comment()
            {
                CommentText = "So heavy!",
                UserName = "BobbyO",
                Instrument = "tuba",
                CommentTime = DateTime.Now
            };
            // Add test message 1 to the repo
            repo.AddComment(comment1);

            // Test comment 2 [1]
            Comment comment2 = new Comment()
            {
                CommentText = "This is a weird instrument but fun so far.",
                UserName = "KellyDogLover",
                Instrument = "bassoon",
                CommentTime = DateTime.Now
            };
            // Add test message 1 to the repo
            repo.AddComment(comment2);

            // Test comment 3 [2]
            Comment comment3 = new Comment()
            {
                CommentText = "Difficult to play.",
                UserName = "Emma2",
                Instrument = "horn",
                CommentTime = DateTime.Now
            };
            // Add test message 1 to the repo
            repo.AddComment(comment3);
        }
    }
}
