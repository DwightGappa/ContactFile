using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SkypeUserName
/// </summary>
public class SkypeOnlineUserName : OnlineUserName
{
    public SkypeOnlineUserName()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public SkypeOnlineUserName(string newUserName)
    {
        UserName = newUserName;
    }

    private int miniumUserNameLength;

    private int maxiumUserNameLength;

    public override string GetServiceName()
    {
        return "Skype";
    }

    public override string GetUserNameRegExString()
    {
        throw new NotImplementedException();
    }

    public override bool IsValid(string userNameToValidte)
    {
        throw new NotImplementedException();
    }
}