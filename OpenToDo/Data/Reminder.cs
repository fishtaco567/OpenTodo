using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenToDo.Data {
    public struct Reminder {

        public DateTime baseRemindTime;
        //TODO: Add sound notification
        public TimeSpan repeatEvery;
        public int timesToRepeat;

        public Reminder(DateTime baseRemindTime, TimeSpan repeatEvery, int timesToRepeat) {
            this.baseRemindTime = baseRemindTime;
            this.repeatEvery = repeatEvery;
            this.timesToRepeat = timesToRepeat;
        }

    }
}
