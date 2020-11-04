using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInterface
{
    public interface IFileParser
    {
        void SaveFile(DialogueItem[] item, string filename);

        DialogueItem[] LoadFile(string filename);

        string SupportFormat { get; }

        string Description { get; }
    }

    public abstract class DialogueItem
    {
        public string Dialogue { get; set; }
    }

    public interface IHtmlItemRender
    {
        string GenerateItemHtml(string template, int id, DialogueItem data, DialogueItem trsd);
    }
}
