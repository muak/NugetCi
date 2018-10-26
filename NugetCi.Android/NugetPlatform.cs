using System;
namespace NugetCi.Android
{
    public class NugetPlatform
    {
        Nuget _nuget;
        public NugetPlatform()
        {
            _nuget = new Nuget { Name = "Android", Version = 1 };
        }
    }
}
