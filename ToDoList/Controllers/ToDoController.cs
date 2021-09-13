using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.Entities;
using ToDoList.InputModels;
using ToDoList.Services;
using ToDoList.ViewModels;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("/todos")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _service;

        public ToDoController(IToDoService service)
        {
            _service = service;
        }

        [HttpPost]
        public void CreateToDoItem([FromBody] ToDoItemCreateInputModel inputModel)
        {
            _service.AddToDoItem(inputModel);
        }

        [HttpGet]
        public List<ToDoItemViewModel> ShowToDoList()
        {
            List<ToDoItemViewModel> listViewModel = new List<ToDoItemViewModel>();
            foreach (var toDoItem in _service.ShowToDoList())
            {
                listViewModel.Add(new ToDoItemViewModel(
                    id: toDoItem.Id,
                    description: toDoItem.Description,
                    done: toDoItem.Done
                ));
            }

            return listViewModel;
        }

        [HttpPut("{id:guid}")]

        public void AtualizaToDo([FromRoute] Guid id, [FromBody] TodoItemUpdateInputModel inputModel)
        {
            _service.AtualizarToDo(id, inputModel);
        }

    }
}
