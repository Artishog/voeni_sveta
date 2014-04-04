using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClientApplication.Model
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

        public bool IsAnswered { get; set; }

        public String Author { get; set; }

        public DateTime CreatedDate { get; set; }

        public String Theme { get; set; }

        public int PercentForExcelent { get; set; }

        public int PercentForSatisfactorily { get; set; }

        public int PercentForWell { get; set; }



        #region TestFlags

        public bool IsAnswerShows { get; set; }

        public bool IsTimeLimited { get; set; }


        #endregion



    }
}
