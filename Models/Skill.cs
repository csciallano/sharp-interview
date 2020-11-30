using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace Interview1.Models
{
    public partial class Skill
    {
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public DeveloperType Type { get; set; }

        public long Level { get; set; }
    }
}
