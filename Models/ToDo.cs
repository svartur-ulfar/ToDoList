using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {

        public int Id { get; set; }
        public string Description { get; set; }  // description of the task
        public bool IsDone { get; set; }        // it was or it was not accomplished
        public virtual ApplicationUser User { get; set; } // we need a reference to the user
                                                          // that is how we link a to do item to a particular user
    // this class defines a particular user
    }
}

/* after we finnished this class, wesave it and build the solution, 
 we build the solution BEFORE so that the entity frame will be able to
work and build the databases*/