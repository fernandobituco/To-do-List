using System;
using ToDoList.Repositories;
using ToDoList.InputModels;
using ToDoList.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _repository;

        public ToDoService(IToDoRepository repository)
        {
            _repository = repository;
        }

        public void AddToDoItem(ToDoItemCreateInputModel inputModel)
        {
            Guid uuid = Guid.NewGuid();
            Console.WriteLine(uuid);
            
            var toDoItem = new ToDoItem(
                id: uuid,
                description: inputModel.Description,
                done: false
            );
            _repository.Save(toDoItem);
        }

        public List<ToDoItem> ShowToDoList()
        {
            return _repository.retornaToDoList();
        }

        public void AtualizarToDo(Guid id, TodoItemUpdateInputModel updateModel)
        {
            var item = _repository.retornaToDoList().Where(item => item.Id == id).First();
            item.Description = updateModel.Description;
            item.Done = updateModel.Done;
        }
    }
}