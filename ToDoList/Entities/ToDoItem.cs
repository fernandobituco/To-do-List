using System;

namespace ToDoList.Entities
{
    public class ToDoItem
    {        
        public Guid Id { get; }
        public string Description { get; set; }
        public bool Done { get; set; }

        public ToDoItem(Guid id, string description, bool done)
        {
            this.Id = id;
            this.Description = description;
            this.Done = done;
        }
    }
}