using System.Text.Json;

namespace WiredBrainCoffeeCompany.Entites
{
    public static class EntityExtensions
    {
        public static T? Copy<T>(this T itemToCopy)
            where T : IEntityBase
        {
            var json = JsonSerializer.Serialize<T>(itemToCopy);
            return JsonSerializer.Deserialize<T>(json);

        }
    }
}