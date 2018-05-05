using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class PostData
    {
        private readonly Dictionary<string, string> parametrs;

        public PostData()
        {
            parametrs = new Dictionary<string, string>();
        }

        public PostData AddParam(string key, string value)
        {
            if (parametrs.ContainsKey(key))
            {
                parametrs[key] = value;
            }
            else
            {
                parametrs.Add(key, value);
            }
            
            return this;
        }

        public string GetParams()
        {
            return string.Join("&", parametrs.Select((e, i) => $"{e.Key}={e.Value}"));
        }
    }
}
