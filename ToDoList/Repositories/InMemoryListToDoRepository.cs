using ToDoList.Entities;
using System.Collections.Generic;

namespace ToDoList.Repositories
{
    public class InMemoryListToDoRepository : IToDoRepository
    {
        private List<ToDoItem> todoItems = new List<ToDoItem>();

        public void Save(ToDoItem toDoItem)
        {
            todoItems.Add(toDoItem);
        }
        
        public List<ToDoItem> retornaToDoList()
        {
            return todoItems;
        }
    }
}