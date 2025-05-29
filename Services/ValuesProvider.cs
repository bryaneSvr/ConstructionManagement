// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using ConstructionManagement.Interfaces;

namespace ConstructionManagement.Services;

public class ValuesProvider : IValuesProvider
{
    public IEnumerable<string> GetValues()
    {
        return new[] { "value1", "value2" };
    }
}
