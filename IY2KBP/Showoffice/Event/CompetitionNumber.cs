using System.ComponentModel;
using System.Xml.Linq;

using Event.Evaluation;
using Event.ResultSorter;

namespace Event
{
    public class CompetitionNumber
    {
        public string Name;
        public EvaluationType Evaluation;
        public bool IsAgeGroup;
        public BindingList<Competitor> Competitors;
        public double CourseLenght { get; set; } = 420;
        public double BaseTime { get; set; } = 70;
        public double IdealTime
        {
            get {
                return BaseTime - Math.Round(CourseLenght / 100);
            }
        }
        private IResultSorter sorter { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param Name="parent">A verseny amihez a versenyszámot hozzáadjuk</param>
        /// <param Name="name">A versenyszám neve</param>
        /// <param Name="Evaluation">A versenyszám elbírálása</param>
        /// <param Name="AgeGroup">Van e a versenyszámban korcsoportos bontás</param>
        public CompetitionNumber(string name, EvaluationType evaluation, bool isAgeGroup, double baseTime, double courseLenght)
        {
            Name = name;
            Evaluation = evaluation;
            IsAgeGroup = isAgeGroup;
            Competitors = new BindingList<Competitor>();
            sorter = ResultSorterFactory.Create(evaluation);
            BaseTime = baseTime;
            CourseLenght = courseLenght;
        }

        public BindingList<Competitor> Sort()
        {
            return sorter.Sort(Competitors);
        }

        /// <summary>
        /// A versenyzőket tároló listához új versenyzőt ad hozzá.
        /// </summary>
        /// <param Name="c">A hozzáadni kívánt versenyző</param>
        public void addCompetitor(Competitor c)
        {
            Competitors.Add(c);
        }
        /// <summary>
        /// Az így elkészített XDocument direkt menthető XML fájlba, nem szükséges neki egyéb root elem.
        /// </summary>
        /// <returns>Az elkészített XML struktúrát XDocument típusként.</returns>
        public XDocument CreateXmlFromSelf()
        {
            XElement root = new XElement("compNumber",
                new XAttribute(nameof(Name), Name),
                new XAttribute(nameof(Evaluation), Evaluation),
                new XAttribute(nameof(IsAgeGroup), IsAgeGroup),
                new XAttribute(nameof(CourseLenght), CourseLenght),
                new XAttribute(nameof(BaseTime), BaseTime)
            );
            XElement competitors = new XElement("competitors");
            foreach (var competitor in this.Competitors)
            {
                competitors.Add(new XElement("competitor",
                    new XElement(nameof(competitor.VerificationNumber), competitor.VerificationNumber),
                    new XElement(nameof(competitor.Name), competitor.Name),
                    new XElement(nameof(competitor.StartNumber), competitor.StartNumber),
                    new XElement(nameof(competitor.Horse), competitor.Horse),
                    new XElement(nameof(competitor.Association), competitor.Association),
                    new XElement(nameof(competitor.Category), competitor.Category),
                    new XElement(nameof(competitor.AgeGroup), competitor.AgeGroup),
                    new XElement(nameof(competitor.StartFee), competitor.StartFee),
                    new XElement(nameof(competitor.MoneyPaid), competitor.MoneyPaid),
                    new XElement(nameof(competitor.AgeGroup), competitor.AgeGroup),
                    competitor.Result.ExportResult()
                    ));
            }
            root.Add(competitors);
            XDocument self = new XDocument(root);
            return self;
        }
    }
}
