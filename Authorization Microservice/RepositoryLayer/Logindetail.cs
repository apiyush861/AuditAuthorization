using System;
using System.Collections.Generic;

#nullable disable

namespace Authorization_Microservice.RepositoryLayer
{
    public partial class Logindetail
    {
        public int ProjectId { get; }
        public string UserName { get; }
        public string Passwrd { get; }
    }
}
