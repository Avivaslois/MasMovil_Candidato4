using Catalog.Infrastructure.Models.Catalog.Infrastructure.Models;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.Factories
{
    public class PhoneContextFactory : IDesignTimeDbContextFactory<PhoneContext>
    {
        public PhoneContext CreateDbContext(string[] args)
        {
            PhoneContext context = new PhoneContext();
            return context;
        }
    }
}
