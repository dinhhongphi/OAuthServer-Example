using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OAuthServer_1.Models
{
    public class OAuthDbContext : IdentityDbContext 
    {
        public OAuthDbContext() : base("Defautl")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}