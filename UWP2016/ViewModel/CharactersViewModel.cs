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
        private Characters character_;
        private String nameToSearch;
        private String father;
        private String mother;
        private String culture;
        private String title;

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

        public String Culture
        {
            get
            {
                return culture;
            }
            set
            {
                culture = value;
                OnPropertyChanged("Culture");
            }
        }

        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
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
            List<Characters> listOfCharacters = null;
            var url =String.Format("https://anapioficeandfire.com/api/characters?name={0}", Name);
            Debug.WriteLine(url);
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(result);
            listOfCharacters = JsonConvert.DeserializeObject<List<Characters>>(result);
            character_ = listOfCharacters[0];
            Debug.WriteLine(character_.culture);
            Father = character_.father;
            Mother = character_.mother;
            Culture = character_.culture;
            Title = character_.titles[0];        

        }

    }

}
