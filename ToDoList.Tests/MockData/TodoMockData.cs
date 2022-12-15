using ToDoList.Models;
namespace ToDoList.Tests;

public class TodoMockData 
{
    public static List<TodoItem> GetToDoItems()
    {
        return new List<TodoItem> {
            new TodoItem {
                Id = 1,
                Name = "Walk with dog",
                IsComplete = true
            },
            new TodoItem {
                Id = 2,
                Name = "Cocking breakfast",
                IsComplete = false
            },
            new TodoItem {
                Id = 3,
                Name = "Go to the shop",
                IsComplete = true
            }
        };
    }
}