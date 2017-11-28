using CTX.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CTX.Web
{
    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<InstanceEntities>
    {
        public InstanceEntities CreateDbContext(string[] args)
        {
            return Program.BuildWebHost(args).Services.CreateScope().ServiceProvider.GetRequiredService<InstanceEntities>();
        }
    }
}
