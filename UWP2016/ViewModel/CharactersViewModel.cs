using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;
using UWP2016.Model;
using UWP2016.Command;
using System.Net.Http;

namespace UWP2016.ViewModel
{
    class CharactersViewModel : MainViewModel
    {
        private Characters character_ = null;
        private String nameToSearch;
        private String father = " ";
        private String mother = " ";

        public String Name
        {
            get
            {
                return nameToSearch;
            }
            set
            {
                nameToSearch = value;
                OnPropertyChanged("Name");
            }
        }

        public String Father
        {
            get
            {
                return father;
            }
            set
            {
                father = value;
                OnPropertyChanged("Father");
            }
        }

        public String Mother
        {
            get
            {
                return mother;
            }
            set
            {
                mother = value;
                OnPropertyChanged("Mother");
            }
        }


        public ICommand GetCharacterCommand
        {
            get
            {
                return new GetCharacterCommand(FindCharacter);
            }
        }
        public async void FindCharacter()
        {
            var http = new HttpClient();
            String url = String.Format("https://anapioficeandfire.com/api/characters?name=Jon Snow");
            Debug.WriteLine(url);
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(result);
            Characters character = JsonConvert.DeserializeObject<Characters>(result);
            Father = character.born;
            Mother = character.culture;

        }

    }

}
