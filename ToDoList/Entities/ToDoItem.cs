using System;

namespace ToDoList.Entities
{
    public class ToDoItem
    {        
        private Guid Id { get; }
        private string Description { get; set; }
        private bool Done { get; set; }

        public ToDoItem(Guid id, string description, bool done)
        {
            this.Id = id;
            this.Description = description;
            this.Done = done;
        }
    }
}