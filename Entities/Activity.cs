using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Example.Api.Entities
{
    public class Activity : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string DateStart { get; private set; }
        public string DateFinished { get; private set; }
        public string Status { get; private set; }

        public Activity() { }
        public Activity(long id, string name, string descr, string datastart, string datafinished, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Description = descr;
            this.DateStart = datastart;
            this.DateFinished = datafinished;
            this.Status = status;
        }
    }
    
}
