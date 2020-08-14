using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Utilities.Exceptions
{
    public class WebShopException:Exception
    {
        public WebShopException()
        {
        }

        public WebShopException(string message)
            : base(message)
        {
        }

        public WebShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
