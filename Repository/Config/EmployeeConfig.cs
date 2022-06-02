using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = new Guid("e0f36318-c307-4fc2-b67c-ff9642b46ae2"),
                    ProjectId = new Guid("96ec4c4a-693a-41ad-a213-c1005f130896"),
                    FirstName="Ahmet",
                    LastName="Yıldırım",
                    Age=30,
                    Position="Senior Developer"
                }
                ); ;
        }
    }
}
