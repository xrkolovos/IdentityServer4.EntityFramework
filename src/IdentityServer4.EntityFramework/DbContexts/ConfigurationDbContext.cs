﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Extensions;
using IdentityServer4.EntityFramework.Interfaces;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer4.EntityFramework.DbContexts
{
    //public class ConfigurationDbContext : ConfigurationDbContext<Client>, IConfigurationDbContext, IConfigurationDbContext<Client>
    //{
    //    public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext<IClient>> options, ConfigurationStoreOptions storeOptions)
    //        : base(options, storeOptions)
    //    {
    //    }

    //    public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext<Client>> options, ConfigurationStoreOptions storeOptions) 
    //        : base(options, storeOptions)
    //    {
    //    }
    //}

    public class ConfigurationDbContext : DbContext, IConfigurationDbContext, IConfigurationDbContext<Client>
    {
        private readonly ConfigurationStoreOptions storeOptions;
        //public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext<IClient>> options, ConfigurationStoreOptions storeOptions)
        //{
        //}

        public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions)
            : base(options)
        {
            if (storeOptions == null) throw new ArgumentNullException(nameof(storeOptions));
            this.storeOptions = storeOptions;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<IdentityResource> IdentityResources { get; set; }
        public DbSet<ApiResource> ApiResources { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureClientContext(storeOptions);
            modelBuilder.ConfigureResourcesContext(storeOptions);

            base.OnModelCreating(modelBuilder);
        }
    }
}