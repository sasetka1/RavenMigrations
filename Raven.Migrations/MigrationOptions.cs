﻿using System.Collections.Generic;
using System.Reflection;

namespace Raven.Migrations
{
    public class MigrationOptions
    {
        public MigrationOptions()
            : this(new SimpleMigrationResolver())
        {
        }

        public MigrationOptions(IMigrationResolver migrationResolver)
        {
            Direction = Directions.Up;
            Assemblies = new List<Assembly>();
            Profiles = new List<string>();
            MigrationResolver = migrationResolver;
            Assemblies = new List<Assembly>();
            ToVersion = 0;
            Conventions = new MigrationConventions();
            MigrationResolver = migrationResolver;
        }

        public string Database { get; set; }
        public Directions Direction { get; set; }
        public IList<Assembly> Assemblies { get; set; }
        public IList<string> Profiles { get; set; }
        public IMigrationResolver MigrationResolver { get; set; }
        public long ToVersion { get; set; }
        public MigrationConventions Conventions { get; set; }
        public IMigrationRecordStore MigrationRecordStore { get; set; }
    }
}