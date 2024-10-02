using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class Table : NestedElement
    {
        public string Title { get; set; }
        public List<List<string>> Data { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Table() { }
        public Table(string title, int rows, int columns, List<List<string>> data)
        {
            Title = title;
            Rows = rows;
            Columns = columns;
            Data = data;
        }
        public override Table Clone()
        {
            List<List<string>> clonedData = new List<List<string>>();
            foreach (var row in Data)
            {
                clonedData.Add(new List<string>(row));
            }
            return new Table(Title, Rows, Columns, clonedData);
        }
        public override string ToString()
        {
            string result = $"\n----------Table\nTitle: {Title}\nCount of rows: {Rows}\nCount of columns: {Columns}\nData:\n";
            foreach (List<string> row in Data)
            {
                string row_data = "| ";
                foreach (string cell in row)
                {
                    row_data += cell + " | ";
                }
                result += row_data + "\n";
            }
            return result;
        }
    }
}
