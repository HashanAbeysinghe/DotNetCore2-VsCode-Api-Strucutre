using System;

namespace ALMaster.Domain.Models.Roles
{
    [Flags]
    public enum RoleTypes
    {
        User = 2,
        Expert = 4,
        ClientAdmin = 6,
        CIQAccountManager = 8,
        CIQAdmin = 10,
    }
}
