namespace Configuration
{
    public class Configurator : IConfigurator
    {
        private readonly Dictionary<string, object> _items;

        public Configurator()
        {
            _items = new Dictionary<string, object>();
        }

        public void SetValue(string key, object value)
        {
            _items[key] = value;
        }

        public T GetValue<T>(string key)
        {
            return (T)_items[key];
        }
    }
}
