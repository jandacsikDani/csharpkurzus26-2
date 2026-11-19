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
        public EvaluationResult? Result { get; set; }
        public int Placement {
            get;
            set { 
                field = value;
                OnPropertyChanged(nameof(Placement));
            }
        }

        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            string category, AgeGroup ageGroup, EvaluationResult result)
        {
            VerificationNumber = verificationNumber;
            Name = name;
            StartNumber = startNumber;
            Horse = horse;
            Association = association;
            Category = category;
            AgeGroup = ageGroup;
            Result = result;
        }
            

        public Competitor(int verificationNumber, string name, int startNumber, string horse, string association,
            string category, AgeGroup ageGroup)
        {
            VerificationNumber = verificationNumber;
            Name = name;
            StartNumber = startNumber;
            Horse = horse;
            Association = association;
            Category = category;
            AgeGroup = ageGroup;
            Result = null;
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
