using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Venezia.TagHelpers
{
    public class UserTagHelper : TagHelper
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IActionContextAccessor _accessor;

        public UserTagHelper(UserManager<IdentityUser> userManager, IActionContextAccessor accessor)
        {
            _userManager = userManager;
            _accessor = accessor;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            var user = _accessor.ActionContext.HttpContext.User;
            var uid = _userManager.GetUserId(user);
            var name = _userManager.FindByIdAsync(uid).Result.UserName;
            output.Content.SetContent(name);

        }

        
    }
}
