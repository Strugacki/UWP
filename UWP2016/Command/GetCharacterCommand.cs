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

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        private CharactersViewModel ViewModel;

        bool ICommand.CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        void ICommand.Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
