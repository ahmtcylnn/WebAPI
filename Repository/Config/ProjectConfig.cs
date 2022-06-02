using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project
                {
                    Id = new Guid("96ec4c4a-693a-41ad-a213-c1005f130896"),
                    Name= "ASP.NET Core Web API Project",
                    Description ="Web Application Programming Interface",
                    Field ="Computer Science"
                }
                );
        }
    }
}
