using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Document : IPrototype<Document>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<NestedElement> Elements { get; set; }
        public Document()
        {
            Elements = new List<NestedElement>();
        }
        public Document(string title, string content)
        {
            Title = title;
            Content = content;
            Elements = new List<NestedElement>();
        }
        public Document(string title, string content, List<NestedElement> elements)
        {
            Title = title;
            Content = content;
            Elements = elements;
        }
        public override string ToString()
        {
            string result = $"\n----------Document\nTitle: {Title}\nContent: {Content}\nElements:\n";
            foreach (NestedElement element in Elements)
            {
                result += element.ToString();
            }
            return result;
        }
        public Document Clone()
        {
            Document clone = new Document(Title, Content);
            foreach (NestedElement nestedElement in Elements)
            {
                clone.Elements.Add(nestedElement.Clone());
            }
            return clone;
        }
        public Document CloneWithModification(string newTitle, string newContent)
        {
            Document clone = this.Clone();
            clone.Title = newTitle;
            clone.Content = newContent;
            return clone;
        }
        public void SaveToFile(string filePath)
        {
            Document clone = this.Clone();
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<Document>(fileStream, clone);
            }
        }
        public static Document LoadFromFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                Document? document = JsonSerializer.Deserialize<Document>(fileStream);
                return document?.Clone() ?? throw new InvalidOperationException("Failed to load document from file.");
            }
        }
    }
}
