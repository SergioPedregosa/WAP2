namespace WAP2.Models
{
    public static class Constants
    {
        public static readonly string TenantName = "WAPB2C";
        public static readonly string TenantId = "WAPB2C.onmicrosoft.com";
        public static readonly string ClientId = "1b83d6ba-3f13-4465-a19d-50c4e5b70739";
        public static readonly string ClientSecret = "03e68017-0277-4a00-8bf4-4231457aaddc";
        public static readonly string PolicySignin = "B2C_1_singupsingin";
        public static readonly string PolicyRegister = "B2C_1_register";
        public static readonly string PolicyLogin = "B2C_1_login";
        public static readonly string PolicyPassword = "B2C_1_resetpassword";
        public static readonly string IosKeychainSecurityGroups = "com.xamarin.adb2cauthorization";
        public static readonly string[] Scopes = new string[] { "openid", "offline_access" };
        public static readonly string AuthorityBase = $"https://{TenantName}.b2clogin.com/tfp/{TenantId}/";
        public static readonly string AuthoritySignIn = $"{AuthorityBase}{PolicySignin}";
        public static readonly string AuthorityLogin = $"{AuthorityBase}{PolicyLogin}";
        public static readonly string AuthorityRegister = $"{AuthorityBase}{PolicyRegister}";
        public static readonly string aadGraphVersion = "api-version=1.6";

        public static readonly string RedirectUri = "msal8bec3a58-8e00-4957-a8d8-ed6bf6910f2a://auth";

        /*public static readonly string ClientId = "8bec3a58-8e00-4957-a8d8-ed6bf6910f2a";
        public static string[] Scopes = new string[] { "User.Read" };
        public static string RedirectUri = "msal8bec3a58-8e00-4957-a8d8-ed6bf6910f2a://auth";
        public static string TenantId = "5c05d356-76b2-4c0b-a012-2794f16442a0";
        public static readonly string IosKeychainSecurityGroups = "com.xamarin.adb2cauthorization";*/
    }
}
