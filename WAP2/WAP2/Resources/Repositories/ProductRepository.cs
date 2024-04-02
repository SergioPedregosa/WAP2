using Firebase.Database;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
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
        
        public async Task<List<Producto>> GetAll()
        {
            return (List<Producto>)(await firebaseClient.Child(nameof(Producto)).OnceAsync<Producto>()).Select(item => new Producto
            {
                ProductId = item.Key,
                Name = item.Object.Name,
                Description = item.Object.Description,
                Price = item.Object.Price,
                Created = item.Object.Created,
                Category = item.Object.Category,
                Subcategory = item.Object.Subcategory,
                Status = item.Object.Status,
                Image = item.Object.Image,
                TempBarValue = item.Object.TempBarValue,
                User_RID = item.Object.User_RID
            }).ToList();
        }
    }
}
