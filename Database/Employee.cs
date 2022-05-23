using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultexTest.Database {
    [Table("Employee")]
    public class Employee {

        public string? OrganisationNumber { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string Name => $"{FirstName} {LastName}".Trim();
    }
}
