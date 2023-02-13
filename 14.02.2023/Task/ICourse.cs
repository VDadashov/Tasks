using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal interface ICourse
    {
        Group[] AddGroup(Group group);
        Group GetGroupByNo(string no);
        Group[] GetGroupsByPointRange(int minPoint,int maxPoint);
        Group[] Search(string str);

    }
}
