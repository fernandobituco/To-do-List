using System;

namespace ToDoList.ViewModels
{
    public class ToDoItemViewModel
    {        
        public Guid Id {get; set;}
        public string Description { get; set; }
        public bool Done { get; set; }

        public ToDoItemViewModel(Guid id, string description, bool done)
        {
            this.Id = id;
            this.Description = description;
            this.Done = done;
        }
    }
}