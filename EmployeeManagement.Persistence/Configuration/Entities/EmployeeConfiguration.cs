using EmployeeManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Persistence.Configuration.Entities
{
	public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.HasData(
			new Employee
			{
				Id = 1,
				EmployeeName = "Ikani Stephen",
				EmployeeAge = "29",
				EmployeeState = "Delta",
				EmployeePosition="Software Engineer"

			}

		);
		}
	}
}
