using System.ComponentModel;
using Event.Evaluation;

namespace Event
{
    public class Competitor : INotifyPropertyChanged, IEquatable<Competitor>
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int VerificationNumber{
            get;
            set {
                field = value;
                OnPropertyChanged(nameof(VerificationNumber));
            }
        }
        public string Name{
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int StartNumber
        {
            get;
            set {
                field = value;
                OnPropertyChanged(nameof(StartNumber));
            }
        }
        public string Horse {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(Horse));
            }
        }
        public string Association{
            get;
            set {
                field = value;
                OnPropertyChanged(nameof(Association));
            }
        }
        public string Category {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(Category));
            }
        }
        public string Info
        {
            get;
            set
            {
                field = value;
                OnPropertyChanged(nameof(Info));
            }
        } = String.Empty;
        public string? AgeGroup
        {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(AgeGroup));
            }
        }
        public int StartFee {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(StartFee));
            }
        }
        public int MoneyPaid
        {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(MoneyPaid));
            }
        }
        public EvaluationResult Result { get; set; }
        public int Placement {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(Placement));
            }
        }

        //Eredmény nélkül és korcsoport nélkül
        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid, string info)
        {
            this.VerificationNumber = verificationNumber;
            this.Name = name;
            this.StartNumber = startNumber;
            this.Horse = horse;
            this.Association = association;
            Result = result;
            this.Category = category;
            this.StartFee = startFee;
            this.AgeGroup = null;
            this.MoneyPaid = moneyPaid;
            this.Info = info;
        }

        //Eredmény nélkül és korcsoport nélkül, checkouthoz
        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid)
        {
            this.VerificationNumber = verificationNumber;
            this.Name = name;
            this.StartNumber = startNumber;
            this.Horse = horse;
            this.Association = association;
            this.Category = category;
            Result = result;
            this.StartFee = startFee;
            this.AgeGroup = null;
            this.MoneyPaid = moneyPaid;
        }

        //Eredmény nélkül, de korcsoprttal
        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid, string ageGroup, string info)
        {
            this.VerificationNumber = verificationNumber;
            this.Name = name;
            this.StartNumber = startNumber;
            this.Horse = horse;
            this.Association = association;
            this.Category = category;
            Result = result;
            this.StartFee = startFee;
            this.AgeGroup = ageGroup;
            this.MoneyPaid = moneyPaid;
            this.Info = info;
        }

        //Eredménnyel
        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid, string? ageGroup, double timeResult, double pointResult, string info, int placement)
        {
            this.VerificationNumber = verificationNumber;
            this.Name = name;
            this.StartNumber = startNumber;
            this.Horse = horse;
            this.Association = association;
            this.Category = category;
            this.StartFee = startFee;
            this.AgeGroup = ageGroup;
            Result = result;
            this.MoneyPaid = moneyPaid;
            this.Info = info;
            this.Placement = placement;
        }

        //Eredménnyel, Info nélkül checkouthoz
        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid, string? ageGroup, double timeResult, double pointResult)
        {
            this.VerificationNumber = verificationNumber;
            this.Name = name;
            this.StartNumber = startNumber;
            this.Horse = horse;
            this.Association = association;
            this.Category = category;
            this.StartFee = startFee;
            this.AgeGroup = ageGroup;
            Result = result;
            this.MoneyPaid = moneyPaid;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Competitor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(VerificationNumber, StartNumber);
        }

        public bool Equals(Competitor? other)
        {
            if (other is null) return false;
            return VerificationNumber == other.VerificationNumber &&
                   StartNumber == other.StartNumber;
        }

    }
}
