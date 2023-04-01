﻿using System.DirectoryServices;

namespace BLAZAM.Common.Data.ActiveDirectory.Interfaces
{
    public interface IADGroup : IGroupableDirectoryAdapter, IComparable
    {
        string GroupName { get; set; }
        bool HasMembers { get; }
        List<IADUser> UserMembers { get; }
        List<IADGroup> GroupMembers { get; }
        List<IGroupableDirectoryAdapter> Members { get;}
        List<string> MembersAsStrings { get; }

        void AssignMember(IGroupableDirectoryAdapter member);
        void UnassignMember(IGroupableDirectoryAdapter member);
    }
}