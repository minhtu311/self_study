using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace company.model
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }

        IList<Member> Members { get; set; } = new List<Member>();
    }
}