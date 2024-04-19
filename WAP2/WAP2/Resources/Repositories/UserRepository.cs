using Firebase.Auth;
using FirebaseAdmin.Auth;
using System.Threading.Tasks;
using WAP2.Services;
using Xamarin.Essentials;


namespace WAP2.Resources.Repositories
{
    public class UserRepository
    {
        string webApiKey = "AIzaSyDPMUpdFB2Fio2DlHcIqZUVmPdD9Yn--Aw";
        FirebaseAuthProvider firebaseAuthProvider;

        public UserRepository()
        {
            firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
        }
        //Registro
        public async Task<bool> Register(string name, string email, string password)
        {
            var token = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password, name);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return true;
            }
            return false;
        }
        //Login
        public async Task<string> Login(string email, string password)
        {
            var token = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync(email, password);
            Preferences.Set("Name", token.User.DisplayName);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return token.FirebaseToken;
            }
            return "";
        }
        
    }
}
