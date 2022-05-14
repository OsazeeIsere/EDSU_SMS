using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace EDSU_SMS.Authorization
{
    public class ApplicationOperations
    {
        public static OperationAuthorizationRequirement Create =
            new OperationAuthorizationRequirement { Name = Constants.CreateOperationName };
        public static OperationAuthorizationRequirement Read =
            new OperationAuthorizationRequirement { Name = Constants.ReadOperationName };
        public static OperationAuthorizationRequirement Update =
            new OperationAuthorizationRequirement { Name = Constants.UpdateOperationName };
        public static OperationAuthorizationRequirement Delete =
            new OperationAuthorizationRequirement { Name = Constants.DeleteOperationName };
        public static OperationAuthorizationRequirement Approved =
            new OperationAuthorizationRequirement { Name = Constants.ApprovedOperationName };
        public static OperationAuthorizationRequirement Declined =
            new OperationAuthorizationRequirement { Name = Constants.DeclinedOperationName };

    }

    public class Constants
    {
        public static readonly string CreateOperationName = "Create";
        public static readonly string ReadOperationName = "Read";
        public static readonly string UpdateOperationName = "Update";
        public static readonly string DeleteOperationName = "Delete";

        public static readonly string ApprovedOperationName = "Approved";
        public static readonly string DeclinedOperationName = "Declined";

         public static readonly string ApplicationManagerRole="ApplicationManager";
         public static readonly string ApplicationSuperAdminRole = "ApplicationSuperAdmin";

    }
}
