﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using SMS_PROJECT.Models;

namespace SMS_PROJECT.Authorization
{
    public class ApplicationManagerAuthorizationHandler
        : AuthorizationHandler<OperationAuthorizationRequirement, Applicant>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            OperationAuthorizationRequirement requirement,
            Applicant applicant)
        {

            if (context.User == null || applicant == null)
                return Task.CompletedTask;

            if (requirement.Name != Constants.ApprovedOperationName &&
                requirement.Name != Constants.DeclinedOperationName)
            {
                return Task.CompletedTask;
            }

            if (context.User.IsInRole(Constants.ApplicationManagerRole))
                context.Succeed(requirement);

            return Task.CompletedTask;

        }

        
    }
}
