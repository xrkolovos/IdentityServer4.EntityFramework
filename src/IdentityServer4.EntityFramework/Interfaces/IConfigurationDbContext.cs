﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer4.EntityFramework.Interfaces
{
    public interface IConfigurationDbContext : IConfigurationDbContext<Client>
    {

    }

    public interface IConfigurationDbContext<TClient> : IDisposable
        where TClient : class, IClient
    {
        DbSet<TClient> Clients { get; set; }
        DbSet<IdentityResource> IdentityResources { get; set; }
        DbSet<ApiResource> ApiResources { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}