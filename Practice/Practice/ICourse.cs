using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal interface ICourse
    {
        public void AddGroup(Group group);

        public Group GetGroupByNo(string no);

        public Group[] Search(string str);
    }
}
