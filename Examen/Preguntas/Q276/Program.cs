using System;
using System.Collections;
namespace Q276
{
    class Program
    {
        static void Main()
        {
            Loan[] loanArray = new Loan[3]
            {
                new Loan("John", "1"), new Loan("Peter", "2"), new Loan("Billy","3"),
            };
            LoanCollection loanList = new LoanCollection(loanArray);
            foreach (var loan in loanList)
            {
                Console.WriteLine($"ID:{loan.Id}, Assigned:{loan.Assigned}");
            }
        }
    }
    // Collection of Loan objects. This class implements IEnumerable so that it can be used with ForEach syntax.
    public class LoanCollection : IEnumerable          //Target 1
    {
        private readonly Loan[] _loanCollection;
        public LoanCollection(Loan[] loanArray)
        {
            _loanCollection = new Loan[loanArray.Length];
            for (int i = 0; i < loanArray.Length; i++)
            {
                _loanCollection[i] = loanArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()       // Target 2  
        {
            return (IEnumerator)GetEnumerator();      // Target 3
        }
        public LoanEnum GetEnumerator()
        {
            return new LoanEnum(_loanCollection);
        }
    }

    public class Loan
    {
        public string Id;
        public string Assigned;
        public Loan(string iD, string assigned)
        {
            this.Id = iD;
            this.Assigned = assigned;
        }

    }
    // When you implement IEnumerable, you must also implement IEnumerator
    public class LoanEnum : IEnumerator
    {
        public Loan[] _loan;
        // Enumerators are positioned before the first element until the first MoveNext() call.
        int position = -1;
        public LoanEnum(Loan[] list)
        {
            _loan = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _loan.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Loan Current
        {
            get
            {
                try
                {
                    return _loan[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}