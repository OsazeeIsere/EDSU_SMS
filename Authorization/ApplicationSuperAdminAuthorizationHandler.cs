﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using EDSU_SMS.Models;

namespace EDSU_SMS.Authorization
{
    public class ApplicationSuperAdminAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Applicant>
    {
        protected override Task HandleRequirementAsync(
           AuthorizationHandlerContext context,
           OperationAuthorizationRequirement requirement,
           Applicant applicant)
        {

            if (context.User == null || applicant == null)
                return Task.CompletedTask;

            if (requirement.Name != Constants.ApprovedOperationName &&
                requirement.Name != Constants.DeclinedOperationName &&
                requirement.Name!=Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            if (context.User.IsInRole(Constants.ApplicationSuperAdminRole))
                context.Succeed(requirement);

            return Task.CompletedTask;

        }
    }
}
