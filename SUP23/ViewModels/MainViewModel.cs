﻿using SUP23.Commands;
using SUP23.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SUP23.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Firstname for new wizard
        /// </summary>
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Wizard SelectedWizard { get; set; }
        public ICommand AddWizardCommand { get; private set; }
        /// <summary>
        /// Wizards at Hogwarts
        /// </summary>
        public ObservableCollection<Wizard> Wizards { get; set; }
        // viktigt.
        // Det måste vara properties 
        public MainViewModel()
        {
            AddWizardCommand = new RelayCommand(x => AddWizard(), x => ButtonIsEnabled());

            Wizards = new ObservableCollection<Wizard>()
            {
                new Wizard("Erik", "Öberg"),
                new Wizard("Eva", "Morlind"),
            };
        }
        private bool ButtonIsEnabled()
        {
            return !string.IsNullOrWhiteSpace(Firstname) && !string.IsNullOrWhiteSpace(Lastname);
        }
     private void AddWizard()
        {
            var wizard = new Wizard(firstname: Firstname, lastname: Lastname);
            Wizards.Add(wizard);
        }
    }
}
