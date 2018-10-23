using Newtonsoft.Json;
using System.Text;

namespace System.Net.Http
{
    public class JsonContent : StringContent
    {
        public JsonContent(object o) : this(JsonConvert.SerializeObject(o))
        { }

        public JsonContent(string content) : base(content, Encoding.UTF8, "application/json")
        {
        }
    }
}
