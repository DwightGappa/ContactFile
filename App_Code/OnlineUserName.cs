using System;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for UserName
/// </summary>
public abstract class OnlineUserName : IUserName
{
    
    private int miniumUserNameLength;

    private int maxiumUserNameLength;

    private string userName;

    public abstract string GetUserNameRegExString();

    public int MaxiumUserNameLength
    {
        get
        {
            return this.maxiumUserNameLength;
        }
    }

    public int MiniumUserNameLength
    {
        get
        {
            return this.miniumUserNameLength;
        }
    }
   
    public abstract bool IsValid(string userNameToValidte);

    public string UserName
    {
        get { return this.userName; }
        set
        {
            this.userName = value;
            //if (IsValid(value))
            //{
            //    this.userName = value;
            // }
            //else
            //{
            //    throw new FormatException(String.Format("{0} is not a valid {1} username", value, this.GetServiceName()));
            //}
        }

    }

    public abstract string GetServiceName();

    public override string ToString()
    {
        return this.userName;
    }

   
    


}