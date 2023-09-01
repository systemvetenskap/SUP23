using SUP23.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SUP23.ViewModels
{
    public class NumberComponentViewModel : BaseViewModel
    {
        public ICommand IncreaseNumberCommand { get;private set; }
        public int Number { get; set; } = 100;
        public int Health { get; set; }
        public bool IsHealthLevelCritical => Health <= 20;
        public NumberComponentViewModel()
        {
            IncreaseNumberCommand = new RelayCommand(x => IncreaseNumber(), x => true);
        }

        private void IncreaseNumber()
        {
            Number += 2;
        }
        private void DecreaseHealth(int value)
        {
            Health -= value;
        }
    }
}
