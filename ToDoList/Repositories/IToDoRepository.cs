using ToDoList.Entities;

namespace ToDoList.Repositories
{
    public interface IToDoRepository
    {
        void Save(ToDoItem toDoItem);
    }
}