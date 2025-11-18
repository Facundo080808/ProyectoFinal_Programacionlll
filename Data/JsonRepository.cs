using System.Text.Json;

namespace ProyectoFinal_Programacionlll.Storage
{
    public class JsonStorage<T> where T : class
    {
        private readonly string _filePath;

        public JsonStorage(string filePath)
        {
            _filePath = filePath;

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
        }

        public List<T> Load()
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new();
        }

        public void Save(List<T> data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
