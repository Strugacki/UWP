using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP2016.Model 
{
    class Characters : INotifyPropertyChanged
    {
        public String name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("name");
            }
        }
        public String culture { get; set; }
        public String born { get; set; }
        public String died { get; set; }
        public String[] titles { get; set; }
        public String[] aliases { get; set; }
        public String father { get; set; }
        public String mother { get; set; }
        public String[] allegiances { get; set; }
        public String[] tvSeries { get; set; }
        public String[] playedBy { get; set; }

        public Characters()
        {

        }

        public Characters(String charName)
        {
            this.name = charName;
        }

        public Characters(string name, string culture, string born, string died, string[] titles, string[] aliases, string father, string mother, string[] allegiances, string[] tvSeries, string[] playedBy)
        {
            this.name = name;
            this.culture = culture;
            this.born = born;
            this.died = died;
            this.titles = titles;
            this.aliases = aliases;
            this.father = father;
            this.mother = mother;
            this.allegiances = allegiances;
            this.tvSeries = tvSeries;
            this.playedBy = playedBy;
        }



        #region INotifyPropertyChanged Members;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
