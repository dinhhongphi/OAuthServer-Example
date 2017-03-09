using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuthServer_1.Models
{
    public enum OAuthGrant
    {
        Code = 1,
        Implicit = 2,
        ResourceOwner = 3,
        Client = 4
    }
}