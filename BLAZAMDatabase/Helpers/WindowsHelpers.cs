﻿using BLAZAM.Common.Data;
using BLAZAM.Database.Models;


namespace BLAZAM.Helpers
{
    public static class WindowsHelpers
    {
        public static WindowsImpersonation CreateWindowsImpersonator(this ADSettings settings)
        {
            return new(new()
            {
                FQDN = settings.FQDN,
                Username = settings.Username,
                Password = Encryption.Instance.DecryptObject<string>(settings.Password).ToSecureString()
            });
        }
        public static WindowsImpersonation CreateWindowsImpersonator(this AppSettings settings)
        {
            return new(new()
            {
                FQDN = settings.UpdateDomain,
                Username = settings.UpdateUsername,
                Password = Encryption.Instance.DecryptObject<string>(settings.UpdatePassword).ToSecureString()
            });
        }
    }
}