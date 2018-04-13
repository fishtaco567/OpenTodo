using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenToDo.Data {
    public class Task {

        private string name;
        private string details;

        private DateTime deadline;

        private Reminder[] reminders;

        private int importance;

        private Task[] subTasks;
    }
}
