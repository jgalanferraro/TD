using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.Model
{
    public interface ISettings
    {
        string Theme { get; set; }

        T GetValue<T>(string key, T defaultValue);

        void SetValue(string key, object value);
    }
}
