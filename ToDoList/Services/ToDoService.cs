using System;
using ToDoList.Repositories;
using ToDoList.InputModels;
using ToDoList.Entities;

namespace ToDoList.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _repository;

        public ToDoService(IToDoRepository repository)
        {
            _repository = repository;
        }

        public void AddToDoItem(ToDoItemInputModel inputModel)
        {
            var toDoItem = new ToDoItem(
                id: System.Guid.NewGuid(),
                description: inputModel.Description,
                done: false
            );
            _repository.Save(toDoItem);
        }
    }
}