using System.Collections.Generic;

namespace Words.Model.IO
{
    public class XmlWorldSource: IWorldSource
    {
        public IEnumerable<WordsPair> GetWords()
        {
            var result = new List<WordsPair>();

            var xml = new XmlDictionary();
            // todo: какие словари использовать пока зашито в код
            result.AddRange(xml.ReadFromFile("lesson-1.xml"));
            result.AddRange(xml.ReadFromFile("lesson-2.xml"));
            result.AddRange(xml.ReadFromFile("lesson-3. character.xml"));
            result.AddRange(xml.ReadFromFile("lesson-3. jobs.xml"));
            result.AddRange(xml.ReadFromFile("lesson-4.xml"));
            result.AddRange(xml.ReadFromFile("other.xml"));
            result.AddRange(xml.ReadFromFile("present-simple-markers.xml"));
            result.AddRange(xml.ReadFromFile("pronouns.xml"));
            result.AddRange(xml.ReadFromFile("verb.xml"));


            return result;
        }
    }
}
