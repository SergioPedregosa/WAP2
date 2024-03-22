using Firebase.Database;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WAP2.Models;

namespace WAP2.Resources.Repositories
{
    public class ProductRepository
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://wapddbb-default-rtdb.europe-west1.firebasedatabase.app/");

        public async Task<bool> Save(Producto product)
        {
            var data = await firebaseClient.Child(nameof(Producto)).PostAsync(JsonConvert.SerializeObject(product));

            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            return false;
        }
    }
}
