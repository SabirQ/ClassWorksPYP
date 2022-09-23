using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClassWork09_23.Filters
{
    public class RoleManagerAttribute: ActionFilterAttribute
    {
        private readonly string _role;

        public RoleManagerAttribute(string role)
        {
            _role = role;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Request.QueryString.ToString().ToLower() == $"?role={_role}"|| context.HttpContext.Request.QueryString.ToString().ToLower() == $"?role=admin")
            { 
                base.OnActionExecuted(context);
            }
            else
            {
                //context.Result = new RedirectToRouteResult(new RouteValueDictionary{{ "controller", "home" },
                //                          { "action", "error" }

                //                         });
                context.Result = new RedirectToRouteResult(new RouteValueDictionary{{"area",null },{ "controller", "home" },
                                          { "action", "error" }

                                         });
            }

        }
    }
}
