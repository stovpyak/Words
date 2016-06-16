using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Model.IO
{
    public class XmlDictionary
    {
        private static readonly Encoding Encoding = Encoding.GetEncoding(1251);

        public void SaveToFile(IEnumerable<WordsPair> pairs, string fileName)
        {
            using (var tmpFile = new FileStream(fileName, FileMode.Create))
            {
                using (var writer = new XmlTextWriter(tmpFile, Encoding))
                {
                    WritePairs(pairs, writer);
                }
            }

        }

        public IEnumerable<WordsPair> ReadFromFile(string fileName)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                return ReadPairs(fileStream);
            }
        }

        private IEnumerable<WordsPair> ReadPairs(Stream stream)
        {
            var doc = new XmlDocument();
            doc.Load(stream);

            var wordsNode = FindWordsNode(doc);
            var pairs = new List<WordsPair>();
            foreach (XmlNode node in wordsNode.ChildNodes)
            {
                if (node.Name == "word")
                {
                    var pair = ReadPair(node);
                    pairs.Add(pair);
                }
            }
            return pairs;
        }

        private WordsPair ReadPair(XmlNode node)
        {
            var first = node.Attributes["first"].Value;
            var second = node.Attributes["second"].Value;
            return new WordsPair(first, second);
        }

        private XmlNode FindWordsNode(XmlDocument doc)
        {
            var node = doc["Words"];
            return node;
        }

        private void WritePairs(IEnumerable<WordsPair> pairs, XmlWriter w)
        {
            w.WriteStartDocument();
            w.WriteStartElement("Words");
            foreach (var pair in pairs)
            {
                WritePair(pair, w);
            }
            w.WriteEndDocument();
            w.Flush();
        }

        private void WritePair(WordsPair pair, XmlWriter w)
        {
            w.WriteStartElement("word");
            w.WriteAttributeString("first", pair.First);
            w.WriteAttributeString("second", pair.Second);
            w.WriteEndElement();
        }
    }
}
