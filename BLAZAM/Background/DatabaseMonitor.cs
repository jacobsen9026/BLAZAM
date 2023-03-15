﻿

using BLAZAM.Common.Data;
using BLAZAM.Common.Data.Database;
using BLAZAM.Server.Pages.Error;

namespace BLAZAM.Server.Background
{
    public class DatabaseMonitor : ConnectionMonitor
    {
        private  IDatabaseContext _context;


        public DatabaseMonitor(IDatabaseContext context)
        {
            Interval = 10000;
            _context = context;
            Task.Delay(1000).ContinueWith((oob) => { Tick(null); });
            Monitor();
        }

        protected override void Tick(object? state)
        {

            Status = _context.Status;
            
        }
       
    }
}