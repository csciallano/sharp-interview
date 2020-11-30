using Interview1.Models;
using System.Collections.Generic;

namespace Interview1
{
    public interface IDeveloperRepository
    {
        IEnumerable<Developer> Get();
    }
}