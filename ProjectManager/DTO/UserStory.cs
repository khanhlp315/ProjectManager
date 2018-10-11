using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DTO
{
    class UserStory
    {
        //List<string> userStoryState = new List<string>();
        int id;
        string title;
        string description;
        int projectID;
        Project assigneeUser;
        UserStoryState userStoryState;
    }
}
