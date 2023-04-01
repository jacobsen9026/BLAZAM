﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLAZAM.Common.Data.Database
{
    public class SqlDatabaseContext:DatabaseContextBase
    {
        /// <inheritdoc/>

        public SqlDatabaseContext():base()
        {
        }

        public SqlDatabaseContext(DatabaseConnectionString databaseConnectionString) : base(databaseConnectionString)
        {
        }

        public SqlDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (ConnectionString == null)
            {
                ConnectionString = new DatabaseConnectionString("test");

            }
            optionsBuilder.UseSqlServer(
                       ConnectionString.Value,
                            sqlServerOptionsAction: sqlOptions =>
                            {
                                sqlOptions.EnableRetryOnFailure();

                            }
                                ).EnableSensitiveDataLogging()
                                .LogTo(Loggers.DatabaseLogger.Information);
        }

        
    }
}