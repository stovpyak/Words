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
            //result.AddRange(xml.ReadFromFile("lesson-1.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-2.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-3. character.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-3. jobs.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-4.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-5.xml"));

            //result.AddRange(xml.ReadFromFile("lesson-5-PS-markers.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-6.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-6-numerics.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-7.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-8.xml"));
            //result.AddRange(xml.ReadFromFile("lesson-9.xml"));
            //result.AddRange(xml.ReadFromFile("other.xml"));
            //result.AddRange(xml.ReadFromFile("pronouns.xml"));
            //result.AddRange(xml.ReadFromFile("verb.xml"));

            result.AddRange(xml.ReadFromFile("level-2.xml"));

            return result;
        }
    }
}
