﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.Auth
{
    public interface IJwtOptionsBuilder
    {
        IJwtOptionsBuilder WithSecretKey(string secretKey);
        IJwtOptionsBuilder WithIssuer(string issuer);
        IJwtOptionsBuilder WithExpiryMinutes(int expiryMinutes);
        IJwtOptionsBuilder WithLifetimeValidation(bool validateLifetime);
        IJwtOptionsBuilder WithAudienceValidation(bool validateAudience);
        IJwtOptionsBuilder WithValidAudience(string validAudience);
        JwtOptions Build();
    }
}
