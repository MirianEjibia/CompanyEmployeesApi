using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData(
           new Employee
           {
               Id = new Guid("b66cabbe-73f8-4c5a-8b53-9b1f578b77c8"),
               Name = "Sam Raiden",
               Age = 26,
               Position = "Software developer",
               Salary = 6000,
               CompanyId = new Guid("c9d4c053-49b6-4f3a-9be9-3e5d8c95d57e")
           },
           new Employee
           {
               Id = new Guid("c0a6a7b6-cc72-4f8e-8cdd-aa94f6e6e5e7"),
               Name = "Jana McLeaf",
               Age = 30,
               Position = "Software developer",
               Salary = 7500,
               CompanyId = new Guid("c9d4c053-49b6-4f3a-9be9-3e5d8c95d57e")
           },
           new Employee
           {
               Id = new Guid("cbb3e61f-0d8e-4f0a-ae55-83023d2db1a5"),
               Name = "Kane Miller",
               Age = 35,
               Position = "Administrator",
               Salary = 5500,
               CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
           }
        );
    }
}