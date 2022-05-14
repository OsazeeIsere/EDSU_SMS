using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using EDSU_SMS.Models;

namespace EDSU_SMS.Authorization
{
    public class ApplicationCreatorAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Applicant>
    {
        UserManager<IdentityUser> _userManager;
        public ApplicationCreatorAuthorizationHandler(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Applicant application)
        {
            if (context.User == null || application == null)
                return Task.CompletedTask;

            if (requirement.Name != Constants.CreateOperationName &&
                requirement.Name != Constants.ReadOperationName &&
                requirement.Name != Constants.UpdateOperationName ||
                requirement.Name == Constants.DeleteOperationName ||
                requirement.Name ==Constants.DeclinedOperationName ||
                requirement.Name==Constants.ApprovedOperationName)
            {
                return Task.CompletedTask;
            }


            if (application.UserId == _userManager.GetUserId(context.User))
                context.Succeed(requirement);

            return Task.CompletedTask;

        }
    }
}
