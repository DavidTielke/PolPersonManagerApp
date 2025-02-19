namespace Configuration;

public interface IConfigurator
{
    void SetValue(string key, object value);
    T GetValue<T>(string key);
}