using NUnit.Framework;
using Eisenhower_Matrix.Model;
using System;

namespace TestP
{
    [TestFixture]
    public class TodoQuarterIntegrationTests
    {
        [Test]
        public void AddItem_UpdatesQuartersListCorrectly()
        {
            var quarter = new ToDoQuarter();
            var taskToAdd = new ToDoItem(1, "Test Task", DateTime.Now.AddDays(1), false);

            quarter.AddItem(taskToAdd.Id, taskToAdd.Title, taskToAdd.Deadline, taskToAdd.IsDone);

            Assert.AreEqual(1, quarter.ToDoItems.Count, "List should contain exactly one task after adding.");
            Assert.AreEqual("Test Task", quarter.ToDoItems[0].Title, "The title of the added task does not match the expected value.");
        }

        [Test]
        public void RemoveItem_UpdatesQuartersListCorrectly()
        {
            var quarter = new ToDoQuarter();
            quarter.AddItem(1, "Task 1", DateTime.Now.AddDays(1), false);
            quarter.AddItem(2, "Task 2", DateTime.Now.AddDays(2), false);

            quarter.RemoveItem(0);

            Assert.AreEqual(1, quarter.ToDoItems.Count, "List should contain exactly one task after removal.");
            Assert.AreEqual("Task 2", quarter.ToDoItems[0].Title, "The remaining task should be 'Task 2'.");
        }

        [Test]
        public void RemoveItem_WithIndexOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            var quarter = new ToDoQuarter();
            quarter.AddItem(1, "Task 1", DateTime.Now.AddDays(1), false);

            Assert.Throws<ArgumentOutOfRangeException>(() => quarter.RemoveItem(1), "Accessing an index out of range should throw ArgumentOutOfRangeException.");
        }

        [Test]
        public void GetItem_WithIndexOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            var quarter = new ToDoQuarter();
            quarter.AddItem(1, "Task 1", DateTime.Now.AddDays(1), false);

            Assert.Throws<ArgumentOutOfRangeException>(() => quarter.GetItem(1), "Accessing an index out of range should throw ArgumentOutOfRangeException.");
        }
    }
}