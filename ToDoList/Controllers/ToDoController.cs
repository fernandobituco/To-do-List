using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.InputModels;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("/todos")]
    public class ToDoController : ControllerBase
    {
        //private readonly ILogger<ToDoController> _logger;
        private readonly IToDoService _service;

        //public ToDoController(ILogger<ToDoController> logger, IToDoService service)
        public ToDoController(IToDoService service)
        {
        //    _logger = logger;
            _service = service;
        }

        [HttpPost]
        public void CreateToDoItem([FromBody] ToDoItemInputModel inputModel)
        {
            _service.AddToDoItem(inputModel);
        }
    }
}
