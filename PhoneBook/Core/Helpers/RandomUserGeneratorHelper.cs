using PhoneBook.Core.Interfaces;
using System.Net;

namespace PhoneBook.Core
{
    public class RandomUserGeneratorHelper : IHelper
    {
        public const string URL = "https://randomuser.me/api/";
        public static string GetMultiple(int numberOfUsers)
        {
            var client = new WebClient();
            var json = client.DownloadString($@"{URL}?results={numberOfUsers}");

            return json;
        }

    }
}