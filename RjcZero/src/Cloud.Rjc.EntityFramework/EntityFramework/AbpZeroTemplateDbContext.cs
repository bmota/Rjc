﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Cloud.Rjc.Authorization.Roles;
using Cloud.Rjc.Authorization.Users;
using Cloud.Rjc.Chat;
using Cloud.Rjc.Friendships;
using Cloud.Rjc.MultiTenancy;
using Cloud.Rjc.Storage;

namespace Cloud.Rjc.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class AbpZeroTemplateDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public AbpZeroTemplateDbContext()
            : base("Default")
        {
            
        }

        public AbpZeroTemplateDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public AbpZeroTemplateDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public AbpZeroTemplateDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
