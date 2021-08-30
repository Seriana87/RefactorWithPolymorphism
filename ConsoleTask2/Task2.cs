using System;

namespace BackendDeveloper.Assignment3
{
    public class PersonParser
    {
        public enum SourceType
        {
            Bin,
            Xml,
            Http
        }

        public SourceType sourceType;
        private IPerson person;
        public PersonParser(SourceType sourceType)
        {
            this.SetSourceTypeForParse(sourceType);
        }
        public void SetSourceTypeForParse(SourceType sourceType)
        {
            this.sourceType = sourceType;
            switch (sourceType)
            {
                case SourceType.Bin:
                    {
                        this.person = new PersonBinaryParser();
                    }
                    break;

                case SourceType.Xml:
                    {
                       this.person = new PersonFileParser();
                    }
                    break;

                case SourceType.Http:
                    {
                        this.person = new PersonApiParser();
                    }
                    break;
            }
        }
        public SourceType GetSourceType()
        {
            return sourceType;
        }

        public void Parse(string file)
        {
            this.person.Parse(file);
        }

    }
}

public interface IPerson
{
    public void Parse(string file);
}

public class PersonBinaryParser : IPerson
{
    public void Parse(string file)
    {
        //var persons = new PersonList();
        //var parser = new BinaryParser(ServiceLocator.Current.GetInstance<BinaryReader>());
        //parser.Open(file);

        //while (!parser.HasReachedEnd)
        //{
        //    persons.Add(parser.GetPerson());
        //}

        //parser.Close();
    }
}

public class PersonApiParser : IPerson
{
    public void Parse(string file)
    {
        //var persons = new PersonList();
        //var parser = new XmlParser(file);
        //parser.StartParse();

        //Person parsedPerson;
        //while ((parsedPerson = parser.GetNextPerson()) != null)
        //{
        //    persons.Add(parsedPerson);
        //}

        //parser.FinishParse();
    }
}

public class PersonFileParser : IPerson
{
    public void Parse(string file)
    {
        //var persons = new PersonList();
        //var parser = new SomeApiClient("https://someserver/api/endpoint");
        //parser.Connect();

        //Person parsedPerson;
        //while ((parsedPerson = parser.GetNextPersonAsync().Result) != null)
        //{
        //    persons.Add(parsedPerson);
        //}

        //parser.FinishParse();
    }
}