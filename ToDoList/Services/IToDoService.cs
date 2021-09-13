using System;
using System.Collections.Generic;
using ToDoList.Entities;
using ToDoList.InputModels;

namespace ToDoList.Services
{
    public interface IToDoService
    {
         void AddToDoItem(ToDoItemCreateInputModel inputModel);

         List<ToDoItem> ShowToDoList();

         void AtualizarToDo(Guid id, TodoItemUpdateInputModel updateModel);
    }
}