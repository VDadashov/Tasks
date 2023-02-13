using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Course:ICourse
    {
        public Group[] Groups = new Group[0];

        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
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

        public Group[] GetGroupByPointRange(double minPoint, double maxPoint)
        {
            Group[] newGroups = new Group[0];

            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].AvgPoint >= minPoint && Groups[i].AvgPoint <= maxPoint)
                {
                    Array.Resize(ref newGroups, newGroups.Length + 1);
                    newGroups[Groups.Length - 1] = Groups[i];
                }
            }
            return newGroups;
        }

        public Group[] Search(string str)
        {
            Group[] newGroups = new Group[0];

            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].No.Contains(str))
                {
                    Array.Resize(ref newGroups, newGroups.Length + 1);
                    newGroups[Groups.Length - 1] = Groups[i];
                }
            }
            return newGroups;
        }
    }
}
