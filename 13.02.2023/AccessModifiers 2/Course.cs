using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers_2
{
    internal class Course
    {
        public Group[] Groups = new Group[0];

        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length+1);
            Groups[Groups.Length-1] = group;
        }

        public Group GetGroupByNo(string no)
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].No == no)
                {
                    return Groups[i];
                }
            }
            return null;
        }

        public Group[] GetGroupsByPointRange(int min, int max)
        {
            Group[] arr = new Group[0];

            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].AvgPoint >= min && Groups[i].AvgPoint <= max)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length-1] = Groups[i];
                }
            }
            return arr;
        }
        
        public Group[] Search(string str)
        {
            Group[] arr = new Group[0];

            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].No.Contains(str))
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = Groups[i];
                }
            }
            return arr;
        }

    }
}
