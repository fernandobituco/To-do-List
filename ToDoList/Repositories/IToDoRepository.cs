using System.Collections.Generic;
using ToDoList.Entities;

namespace ToDoList.Repositories
{
    public interface IToDoRepository
    {
        void Save(ToDoItem toDoItem);

        List<ToDoItem> retornaToDoList();
    }
}