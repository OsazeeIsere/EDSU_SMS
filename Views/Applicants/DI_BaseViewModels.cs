using EDSU_SMS.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EDSU_SMS.Data;

namespace EDSU_SMS.Views.Applicants
{
    public class DI_BaseViewModel : Controller
    {
        protected ApplicationDbContext Context { get; set; }
        protected IAuthorizationService AuthorizationService { get; }
        protected UserManager<IdentityUser> UserManager { get; }

        public DI_BaseViewModel(ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager)
        {
            Context = context;
            AuthorizationService = authorizationService;
            UserManager = userManager;

        }
    }
}
