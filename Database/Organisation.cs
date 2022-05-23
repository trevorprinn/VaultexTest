using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultexTest.Database {

    [Table("Organisation")]
    public class Organisation {


        public string? OrganisationName { get; set; }

        public string? OrganisationNumber { get; set; }

        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }

        public string? Town { get; set; }

        public string? PostCode { get; set; }

        public string GetAddress() =>
            string.Join(Environment.NewLine, new string[] { AddressLine1!, AddressLine2!, AddressLine3!, AddressLine4!, Town!, PostCode! }.Where(l => !string.IsNullOrWhiteSpace(l)));
    }
}
