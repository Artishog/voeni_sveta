using System.Collections.Generic;

namespace TetsCreatorApplication.Model
{
    public class Test
    {
        public List<Task> Tasks { get; set; }

        public int TaskCount
        {
            get
            {
                if (Tasks != null)
                {
                    return Tasks.Count;
                }
                return 0;
            }
        }

        public int ReservedTime { get; set; }

        public int MinBalllsForCompliteTest { get; set; }


        #region TestFlags

        public bool IsAnswerShows { get; set; }

        public bool IsTimeLimited { get; set; }
 

        #endregion



    }
}
