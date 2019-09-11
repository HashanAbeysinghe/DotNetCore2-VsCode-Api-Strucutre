namespace ALMaster.Domain.Models.Roles
{
    public static class RoleTypesConstants
    {
        public const string Admin = "Admin";
        public const string Manager = "Manager";
        public const string User = nameof(RoleTypes.User);
        public const string Common = Admin + "," + Manager + "," + User;
        public const string Supervisor = Admin + "," + Manager;
    }
}
