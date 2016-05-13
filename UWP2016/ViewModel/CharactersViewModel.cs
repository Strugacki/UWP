﻿using System;
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
            characters = new Characters();
            //GetCharacterCommand = new GetCharacterCommand(this);
        }

        private Characters characters;

        public Characters Characters
        {
            get
            {
                return characters;
            }

            set
            {
                characters = value;
            }
        }

        public bool CanExecuteRequest
        {
            get
            {
                if (Characters == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Characters.name);
            }
        }

        /*public ICommand GetCharacterCommand
        {
            get;
            private set;
        } */

        public void getCharacterFromAPI(String nameToFind)
        {

        }
    }
}