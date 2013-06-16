using GalaSoft.MvvmLight;

namespace ProjectEulerDemo.ViewModel
{
    using System.Collections.Generic;
    using System.Windows.Input;

    using GalaSoft.MvvmLight.Command;

    using ProjectEulerDemo.Problems;

    public class MainViewModel : ViewModelBase
    {
        public string Title { get { return "Project Euler Demo"; } }

        public IEnumerable<IEulerProblem> Problems { get; set; }

        private IEulerProblem _activeProblem;
        public IEulerProblem ActiveProblem 
        { 
            get { return _activeProblem; }
            set
            {
                _activeProblem = value;
                Result = "";
                RaisePropertyChanged(() => ActiveProblem);
                RaisePropertyChanged(() => Result);
            }
        }

        public string Result { get; set; }

        public ICommand Calculate { get; set; }

        public MainViewModel()
        {           
            Problems = new List<IEulerProblem>
                {
                    new P0001MultiplesOf3And5(),
                    new P0002EvenFibonacciNumbers(),
                    new P0020FactorialDigitSum(),
                };

            Calculate = new RelayCommand(CalculateActiveProblem, () => _activeProblem != null);
        }

        private void CalculateActiveProblem()
        {
            Result = ActiveProblem.Calculate();
            RaisePropertyChanged(() => Result);
        } 
    }
}