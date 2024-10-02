using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class DocumentManager
    {
        public Document CreateDocument(Document prototype)
        {
            return prototype.Clone();
        }
        public Document CreateDocumentWithModification(Document prototype, string title, string content)
        {
            return prototype.CloneWithModification(title, content);
        }
    }
}
