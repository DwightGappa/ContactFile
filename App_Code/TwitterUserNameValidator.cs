using System.Text.RegularExpressions;

/// <summary>
/// Helper class to validates Twitter username
/// </summary>
/// 
namespace ContactFile
{
    public class TwitterUserNameValidator
    {
        public const string TwitterUserNameRegEx = @"^[a-zA-Z0-9_-]{3,15}$";

        public static bool IsValid(string nameToValidte)
        {
            Regex regex = new Regex(TwitterUserNameRegEx);
            return regex.IsMatch(nameToValidte);
        }

        public TwitterUserNameValidator()
        {
            //
            // TODO: Add constructor logic here
            //
        }

       



    }
}
