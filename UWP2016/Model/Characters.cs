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



        private String _Name;
        private String _Culture;
        private String _Born;
        private String _Died;
        private String[] _Titles;
        private String[] _Aliases;
        private String _Father;
        private String _Mother;
        private String[] _Allegiances;
        private String[] _TvSeries;
        private String[] _PlayedBy;

        public Characters(string _Name)
        {
            this._Name = _Name;
        }

        public Characters(string _Name, string _Culture, string _Born, string _Died, string[] _Titles, string[] _Aliases, string _Father, string _Mother, string[] _Allegiances, string[] _TvSeries, string[] _PlayedBy)
        {
            this._Name = _Name;
            this._Culture = _Culture;
            this._Born = _Born;
            this._Died = _Died;
            this._Titles = _Titles;
            this._Aliases = _Aliases;
            this._Father = _Father;
            this._Mother = _Mother;
            this._Allegiances = _Allegiances;
            this._TvSeries = _TvSeries;
            this._PlayedBy = _PlayedBy;
        }

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Culture
        {
            get
            {
                return _Culture;
            }

            set
            {
                _Culture = value;
            }
        }

        public string Born
        {
            get
            {
                return _Born;
            }

            set
            {
                _Born = value;
            }
        }

        public string Died
        {
            get
            {
                return _Died;
            }

            set
            {
                _Died = value;
            }
        }

        public string[] Titles
        {
            get
            {
                return _Titles;
            }

            set
            {
                _Titles = value;
            }
        }

        public string[] Aliases
        {
            get
            {
                return _Aliases;
            }

            set
            {
                _Aliases = value;
            }
        }

        public string Father
        {
            get
            {
                return _Father;
            }

            set
            {
                _Father = value;
            }
        }

        public string Mother
        {
            get
            {
                return _Mother;
            }

            set
            {
                _Mother = value;
            }
        }

        public string[] Allegiances
        {
            get
            {
                return _Allegiances;
            }

            set
            {
                _Allegiances = value;
            }
        }

        public string[] TvSeries
        {
            get
            {
                return _TvSeries;
            }

            set
            {
                _TvSeries = value;
            }
        }

        public string[] PlayedBy
        {
            get
            {
                return _PlayedBy;
            }

            set
            {
                _PlayedBy = value;
            }
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
