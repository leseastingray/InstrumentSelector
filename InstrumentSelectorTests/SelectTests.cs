using System;
using System.Collections.Generic;
using InstrumentSelector.Models;
using InstrumentSelector.Repositories;
using InstrumentSelector.Controllers;

using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentSelectorTests
{
    public class SelectTests
    {
        // Test 1, SelectionTest: PASSED
        [Fact]
        public void SelectionTest()
        {
            // Arrange
            var selectRepo = new FakeSelectionRepository();
            var instrumentRepo = new FakeInstrumentRepository();
            var selectController = new SelectController(selectRepo,instrumentRepo);
            var testSelect = new Selection()
            {
                PreferredSize = "2",
                PreferredRange = "3",
                PreferredTone = "3",
                PreferredTechnical = "2"
            };
            // Act
            selectController.Selection(testSelect);
            // Assert
            Assert.Equal("2", selectRepo.Selections[selectRepo.Selections.Count - 1].PreferredSize);
            Assert.Equal("3", selectRepo.Selections[selectRepo.Selections.Count - 1].PreferredTone);
        }
        // Test 2, SelectionResultTest: PASSED
        [Fact]
        public void SelectionResultTest()
        {
            // Arrange
            var selectRepo = new FakeSelectionRepository();
            var instrumentRepo = new FakeInstrumentRepository();
            AddTestSelections(selectRepo);
            var selectController = new SelectController(selectRepo, instrumentRepo);
            // Act
            var result = (ViewResult)selectController.SelectionResult();
            var instrumentResults = (List<Instrument>)result.Model;
            // Assert (description text of resulting instruments between two
            // totally different instrument selections should not be equal)
            Assert.NotEqual(instrumentResults[0].DescriptionText, instrumentResults[1].DescriptionText);
        }

        // Add test selections
        public void AddTestSelections(FakeSelectionRepository selectRepo)
        {
            // Test selection 1 [0]
            // bassoon, trombone, euphonium, tuba
            Selection selection1 = new Selection()
            {
                PreferredSize = "0",
                PreferredRange = "1",
                PreferredTone = "1",
                PreferredTechnical = "0"
            };
            selectRepo.AddSelection(selection1);

            // Test selection 2 [1]
            // flute, clarinet, trumpet
            Selection selection2 = new Selection()
            {
                PreferredSize = "4",
                PreferredRange = "4",
                PreferredTone = "4",
                PreferredTechnical = "3"
            };
            selectRepo.AddSelection(selection2);

            // Test selection 3 [2]
            // clarinet, oboe, saxophone, horn, euphonium
            Selection selection3 = new Selection()
            {
                PreferredSize = "2",
                PreferredRange = "2",
                PreferredTone = "2",
                PreferredTechnical = "2"
            };
            selectRepo.AddSelection(selection3);
        }
    }
}
