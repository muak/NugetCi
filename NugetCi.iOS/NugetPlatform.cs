using System;
using System.Globalization;
namespace NugetCi.iOS
{
    public class NugetPlatform
    {
        Nuget _nuget;
        public NugetPlatform()
        {
            _nuget = new Nuget() { Name = "iOS", Version = 1 };
        }

        public string GetName()
        {
            return _nuget.Name;
        }
    }
}
