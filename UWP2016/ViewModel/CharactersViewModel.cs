using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP2016.Model;
namespace UWP2016.ViewModel
{
   internal class CharactersViewModel
    {
        public CharactersViewModel()
        {
            _Characters = new Characters("Jon");
        }

        private Characters _Characters;

        public Characters Characters
        {
            get
            {
                return _Characters;
            }
        }

        public void SaveResponse()
        {

        }
    }
}
