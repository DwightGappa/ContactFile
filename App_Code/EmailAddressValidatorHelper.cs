using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmailValidatorHelper
/// </summary>
public class EmailValidatorHelper
{
    public static bool IsValidEmail(string email)
    //Taken from https://stackoverflow.com/a/1374644/9543025
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
    public EmailValidatorHelper()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}