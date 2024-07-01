using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using company.enummodel;

namespace company.model
{
    public class Member
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public Role Role { get; set; }

        public IList<Group> Groups { get; set; } = new List<Group>();
    }
}