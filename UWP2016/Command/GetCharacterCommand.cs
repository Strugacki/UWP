using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UWP2016.ViewModel;

namespace UWP2016.Command
{
    internal class GetCharacterCommand : ICommand
    {

        public GetCharacterCommand(CharactersViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        private CharactersViewModel ViewModel;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                
            }
            remove
            {

            }
        }

        public bool CanExecute(object parameter)
        {
            return ViewModel.CanExecuteRequest;
        }

        public void Execute(object parameter)
        {
            ViewModel.getCharacterFromAPI();
        }
    }
}
