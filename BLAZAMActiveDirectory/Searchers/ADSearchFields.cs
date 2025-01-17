﻿using BLAZAM.ActiveDirectory.Interfaces;

namespace BLAZAM.ActiveDirectory.Searchers
{
    public class ADSearchFields
    {
        public string? SamAccountName { get; set; }

        /// <summary>
        /// The ADS long value to search for locked out users from"
        /// </summary>
        /// <remarks>
        /// To find all locked out entries, use 1
        /// </remarks>
        public long? LockoutTime { get; set; }

        public string? SID { get; set; }

        public string? DN { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Changed { get; set; }

        public string? PasswordLastSet { get; set; }

        public string? CN { get; set; }

        public string? MemberOf { get; set; }
        public IADGroup? NestedMemberOf { get; internal set; }
        public string BitLockerRecoveryId { get; internal set; }
    }
}