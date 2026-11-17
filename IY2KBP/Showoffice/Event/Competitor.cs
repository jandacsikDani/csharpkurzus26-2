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
        public AgeGroup AgeGroup
        {
            get;
            set
            {
                field = value;
                OnPropertyChanged(nameof(AgeGroup));
            }
        } = AgeGroup.None;
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

        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid)
        {
            VerificationNumber = verificationNumber;
            Name = name;
            StartNumber = startNumber;
            Horse = horse;
            Association = association;
            Result = result;
            Category = category;
            StartFee = startFee;
            MoneyPaid = moneyPaid;
        }

        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            EvaluationResult result, string category, int startFee, int moneyPaid, AgeGroup ageGroup)
        {
            VerificationNumber = verificationNumber;
            Name = name;
            StartNumber = startNumber;
            Horse = horse;
            Association = association;
            Category = category;
            Result = result;
            StartFee = startFee;
            AgeGroup = ageGroup;
            MoneyPaid = moneyPaid;
        }
        public bool Equals(Competitor? other)
        {
            if (other is null) return false;
            return VerificationNumber == other.VerificationNumber &&
                   StartNumber == other.StartNumber;
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Competitor);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(VerificationNumber, StartNumber);
        }
    }
}
