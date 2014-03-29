using System;

namespace TetsCreatorApplication.Model
{
    public class Task
    {
        public TaskType Type { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        
        public String ClientAnswer { get; set; }


        public bool IsAnswered { get; set; }

        public bool IsClientAnswerTrue { get; set; }




    }
}
