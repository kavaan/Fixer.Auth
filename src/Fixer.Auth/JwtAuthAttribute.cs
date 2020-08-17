using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Auth
{
    public class JwtAuthAttribute : AuthAttribute
    {
        public const string AuthenticationScheme = "Bearer";

        public JwtAuthAttribute(string policy = "") : base(AuthenticationScheme, policy)
        {
        }
    }
}
