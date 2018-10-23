using Newtonsoft.Json;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsJsonAsync<T>(this HttpContent httpContent, JsonSerializerSettings settings = null)
        {
            string content = await httpContent.ReadAsStringAsync();

            if (settings == null) return JsonConvert.DeserializeObject<T>(content);

            return JsonConvert.DeserializeObject<T>(content, settings);
        }
    }
}
