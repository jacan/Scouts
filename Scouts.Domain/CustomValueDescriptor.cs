using System.Collections.Generic;

namespace Scouts.Domain
{
    public class CustomValueDescriptor
    {
        KeyValuePair<string, string> _valueDescriptor;

        public CustomValueDescriptor(string key, string value)
        {
            _valueDescriptor = new KeyValuePair<string, string>(key, value);
        }

        public string Key => _valueDescriptor.Key;
        public string Value => _valueDescriptor.Value;
    }
}
