
namespace Interview1.Models
{
    using System.Collections.Generic;

    public partial class Developer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Age { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
