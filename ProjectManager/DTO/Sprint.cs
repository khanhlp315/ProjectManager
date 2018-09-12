using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DTO
{
    class Sprint
    {
        int projectID;
        int order;
        DateTime startDate;
        DateTime endDate;
        SprintState sprintState;
        string description;
    }
}
