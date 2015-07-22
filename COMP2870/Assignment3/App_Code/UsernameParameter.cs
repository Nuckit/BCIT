using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomParameters
{
    public class UsernameParameter : Parameter
    {
        public UsernameParameter()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        protected override object Evaluate(HttpContext context, Control control)
        {
            return context.User.Identity.Name;
        }
    }
}
