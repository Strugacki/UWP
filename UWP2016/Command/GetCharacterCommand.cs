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
        private SimpleEventHandler handler;
        private bool isEnabled = true;
        public event EventHandler CanExecuteChanged;
        public delegate void SimpleEventHandler();
        public GetCharacterCommand(SimpleEventHandler handler)
        {
            this.handler = handler;
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
        }
        void ICommand.Execute(object arg)
        {
            this.handler();
        }
        bool ICommand.CanExecute(object arg)
        {
            return this.IsEnabled;
        }
        private void OnCanExecuteChanged()
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
