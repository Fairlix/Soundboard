using Soundboard.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Model
{
    public class ModelItems : CommonBase
    {
        private string _btnLeft1;
        private string _btnRight1;

        private string _btnLeft2;
        private string _btnRight2;

        private string _btnLeft3;
        private string _btnRight3;

        private string _btnLeft4;
        private string _btnRight4;

        private string _btnLeft5;
        private string _btnRight5;

        private string _btnLeft6;
        private string _btnRight6;

        private string _btnLeft7;
        private string _btnRight7;

        private string _btnLeft8;
        private string _btnRight8;

        private string _btnLeft9;
        private string _btnRight9;

        private string _btnLeft10;
        private string _btnRight10;

        private string _pathToMp3;

        public string PathToMp3
        {
            get { return _pathToMp3; }
            set
            {
                if (_pathToMp3 != value)
                {
                    _pathToMp3 = value;
                    RaisePropertyChanged("PathToMp3");
                }
            }
        }

        public string BtnLeft1
        {
            get { return _btnLeft1; }

            set
            {
                if (_btnLeft1 != value)
                {
                    _btnLeft1 = value;
                    RaisePropertyChanged("BtnLeft1");
                }
            }
        }

        public string BtnRight1
        {
            get { return _btnRight1; }

            set
            {
                if (_btnRight1 != value)
                {
                    _btnRight1 = value;
                    RaisePropertyChanged("BtnRight1");
                }
            }
        }

        public string BtnLeft2
        {
            get { return _btnLeft2; }

            set
            {
                if (_btnLeft2 != value)
                {
                    _btnLeft2 = value;
                    RaisePropertyChanged("BtnLeft2");
                }
            }
        }

        public string BtnRight2
        {
            get { return _btnRight2; }

            set
            {
                if (_btnRight2 != value)
                {
                    _btnRight2 = value;
                    RaisePropertyChanged("BtnRight2");
                }
            }
        }

        public string BtnLeft3
        {
            get { return _btnLeft3; }

            set
            {
                if (_btnLeft3 != value)
                {
                    _btnLeft3 = value;
                    RaisePropertyChanged("BtnLeft3");
                }
            }
        }

        public string BtnRight3
        {
            get { return _btnRight3; }

            set
            {
                if (_btnRight3 != value)
                {
                    _btnRight3 = value;
                    RaisePropertyChanged("BtnRight3");
                }
            }
        }

        public string BtnLeft4
        {
            get { return _btnLeft4; }

            set
            {
                if (_btnLeft4 != value)
                {
                    _btnLeft4 = value;
                    RaisePropertyChanged("BtnLeft4");
                }
            }
        }

        public string BtnRight4
        {
            get { return _btnRight4; }

            set
            {
                if (_btnRight4 != value)
                {
                    _btnRight4 = value;
                    RaisePropertyChanged("BtnRight4");
                }
            }
        }

        public string BtnLeft5
        {
            get { return _btnLeft5; }

            set
            {
                if (_btnLeft5 != value)
                {
                    _btnLeft5 = value;
                    RaisePropertyChanged("BtnLeft5");
                }
            }
        }

        public string BtnRight5
        {
            get { return _btnRight5; }

            set
            {
                if (_btnRight5 != value)
                {
                    _btnRight5 = value;
                    RaisePropertyChanged("BtnRight5");
                }
            }
        }

        public string BtnLeft6
        {
            get { return _btnLeft6; }

            set
            {
                if (_btnLeft6 != value)
                {
                    _btnLeft6 = value;
                    RaisePropertyChanged("BtnLeft6");
                }
            }
        }

        public string BtnRight6
        {
            get { return _btnRight6; }

            set
            {
                if (_btnRight6 != value)
                {
                    _btnRight6 = value;
                    RaisePropertyChanged("BtnRight6");
                }
            }
        }

        public string BtnLeft7
        {
            get { return _btnLeft7; }

            set
            {
                if (_btnLeft7 != value)
                {
                    _btnLeft7 = value;
                    RaisePropertyChanged("BtnLeft7");
                }
            }
        }

        public string BtnRight7
        {
            get { return _btnRight7; }

            set
            {
                if (_btnRight7 != value)
                {
                    _btnRight7 = value;
                    RaisePropertyChanged("BtnRight7");
                }
            }
        }

        public string BtnLeft8
        {
            get { return _btnLeft8; }

            set
            {
                if (_btnLeft8 != value)
                {
                    _btnLeft8 = value;
                    RaisePropertyChanged("BtnLeft8");
                }
            }
        }

        public string BtnRight8
        {
            get { return _btnRight8; }

            set
            {
                if (_btnRight8 != value)
                {
                    _btnRight8 = value;
                    RaisePropertyChanged("BtnRight8");
                }
            }
        }

        public string BtnLeft9
        {
            get { return _btnLeft9; }

            set
            {
                if (_btnLeft9 != value)
                {
                    _btnLeft9 = value;
                    RaisePropertyChanged("BtnLeft9");
                }
            }
        }

        public string BtnRight9
        {
            get { return _btnRight9; }

            set
            {
                if (_btnRight9 != value)
                {
                    _btnRight9 = value;
                    RaisePropertyChanged("BtnRight9");
                }
            }
        }

        public string BtnLeft10
        {
            get { return _btnLeft10; }

            set
            {
                if (_btnLeft10 != value)
                {
                    _btnLeft10 = value;
                    RaisePropertyChanged("BtnLeft10");
                }
            }
        }

        public string BtnRight10
        {
            get { return _btnRight10; }

            set
            {
                if (_btnRight10 != value)
                {
                    _btnRight10 = value;
                    RaisePropertyChanged("BtnRight10");
                }
            }
        }
    }
}