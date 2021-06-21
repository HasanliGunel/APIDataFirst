using System;

namespace ApiGetMethod.Controllers
{
    internal class SchoolDBEntities : IDisposable
    {
        public object Students { get; internal set; }
    }
}