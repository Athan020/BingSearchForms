using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Commands;


namespace BingSearchForms.Core.ViewModels
{
    public class MainViewModel:MvxViewModel
    {
        public MainViewModel()
        {

        }
        public override Task Initialize()
        {
            Console.WriteLine("View Model LOADED", this);
            return base.Initialize();
        }

        public IMvxCommand ResetTextCommand() => new MvxCommand(ResetText);

        private void ResetText()
        {
            Greet = "Hello Me";
        }

        private string _greet = "Hello this is me Texting The Waters";
        public string Greet
        {
            get => _greet;
            set => SetProperty(ref _greet, value);
        }

    }
}
