using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Utilites.Enums
{
    public enum SortingUserOrder
    {
        None = 0,
        OrderByUsernameAlpabetically = 1, // asc
        OrderByEmailAlphabetically = 2, // asc
        OrderByPosts = 3, // asc
        OrderByJoinedGroups = 4, // asc
        OrderByCommentsCount = 5, //asc
   

    }
}
