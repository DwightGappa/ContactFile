using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


interface IUserName
{
    string UserName
    {
        get;
        set;
    }

    bool IsValid(string userNameToValidte);
}