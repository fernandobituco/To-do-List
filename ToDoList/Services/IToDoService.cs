using ToDoList.InputModels;

namespace ToDoList.Services
{
    public interface IToDoService
    {
         void AddToDoItem(ToDoItemInputModel inputModel);
    }
}