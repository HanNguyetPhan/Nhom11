using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineToyStore
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "AZ7U_tqVeK5-GsDRzPxbaGvBhfpAgyYVKpShLxMPedL4VRT8ZTC_5Z9ZLWjYH3zteugp-Z-ce3WXtU73";
            clientSecret = "EPkY9c_xYC9AIuTzLe8fWdo_AzrpSw7Jd8TBodnk832fIc0-xndlbtvkNQjTdHAJemFmpAuaYh_vsfn7";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}