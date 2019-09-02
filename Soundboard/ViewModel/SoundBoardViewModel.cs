using Soundboard.Common;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using Soundboard.Model;
using System.Runtime.InteropServices;

namespace Soundboard.ViewModel
{
    public class SoundBoardViewModel : ViewModelBase
    {
        private ModelItems modelItems = new ModelItems();

        //commands for stand alone buttons
        public ICommand BtnStop { get; set; }

        public ICommand BtnHelp { get; set; }

        #region commands for buttons

        public ICommand BtnLeft1PlaySoundCommand { get; set; }
        public ICommand BtnLeft1ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight1PlaySoundCommand { get; set; }
        public ICommand BtnRight1ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft2PlaySoundCommand { get; set; }
        public ICommand BtnLeft2ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight2PlaySoundCommand { get; set; }
        public ICommand BtnRight2ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft3PlaySoundCommand { get; set; }
        public ICommand BtnLeft3ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight3PlaySoundCommand { get; set; }
        public ICommand BtnRight3ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft4PlaySoundCommand { get; set; }
        public ICommand BtnLeft4ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight4PlaySoundCommand { get; set; }
        public ICommand BtnRight4ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft5PlaySoundCommand { get; set; }
        public ICommand BtnLeft5ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight5PlaySoundCommand { get; set; }
        public ICommand BtnRight5ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft6PlaySoundCommand { get; set; }
        public ICommand BtnLeft6ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight6PlaySoundCommand { get; set; }
        public ICommand BtnRight6ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft7PlaySoundCommand { get; set; }
        public ICommand BtnLeft7ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight7PlaySoundCommand { get; set; }
        public ICommand BtnRight7ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft8PlaySoundCommand { get; set; }
        public ICommand BtnLeft8ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight8PlaySoundCommand { get; set; }
        public ICommand BtnRight8ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft9PlaySoundCommand { get; set; }
        public ICommand BtnLeft9ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight9PlaySoundCommand { get; set; }
        public ICommand BtnRight9ChooseDirectoryCommand { get; set; }

        public ICommand BtnLeft10PlaySoundCommand { get; set; }
        public ICommand BtnLeft10ChooseDirectoryCommand { get; set; }
        public ICommand BtnRight10PlaySoundCommand { get; set; }
        public ICommand BtnRight10ChooseDirectoryCommand { get; set; }

        #endregion commands for buttons

        // create new instance of MP3Player
        private MP3Player mp3Player = new MP3Player();

        public string PathToMp3
        {
            get { return modelItems.PathToMp3; }
            set
            {
                if (modelItems.PathToMp3 != value)
                {
                    modelItems.PathToMp3 = value;
                    RaisePropertyChanged("PathToMp3");
                }
            }
        }

        #region Properties for buttons

        public string BtnLeft1
        {
            get { return modelItems.BtnLeft1; }

            set
            {
                if (modelItems.BtnLeft1 != value)
                {
                    modelItems.BtnLeft1 = value;
                    RaisePropertyChanged("BtnLeft1");
                }
            }
        }

        public string BtnRight1
        {
            get { return modelItems.BtnRight1; }

            set
            {
                if (modelItems.BtnRight1 != value)
                {
                    modelItems.BtnRight1 = value;
                    RaisePropertyChanged("BtnRight1");
                }
            }
        }

        public string BtnLeft2
        {
            get { return modelItems.BtnLeft2; }

            set
            {
                if (modelItems.BtnLeft2 != value)
                {
                    modelItems.BtnLeft2 = value;
                    RaisePropertyChanged("BtnLeft2");
                }
            }
        }

        public string BtnRight2
        {
            get { return modelItems.BtnRight2; }

            set
            {
                if (modelItems.BtnRight2 != value)
                {
                    modelItems.BtnRight2 = value;
                    RaisePropertyChanged("BtnRight2");
                }
            }
        }

        public string BtnLeft3
        {
            get { return modelItems.BtnLeft3; }

            set
            {
                if (modelItems.BtnLeft3 != value)
                {
                    modelItems.BtnLeft3 = value;
                    RaisePropertyChanged("BtnLeft3");
                }
            }
        }

        public string BtnRight3
        {
            get { return modelItems.BtnRight3; }

            set
            {
                if (modelItems.BtnRight3 != value)
                {
                    modelItems.BtnRight3 = value;
                    RaisePropertyChanged("BtnRight3");
                }
            }
        }

        public string BtnLeft4
        {
            get { return modelItems.BtnLeft4; }

            set
            {
                if (modelItems.BtnLeft4 != value)
                {
                    modelItems.BtnLeft4 = value;
                    RaisePropertyChanged("BtnLeft4");
                }
            }
        }

        public string BtnRight4
        {
            get { return modelItems.BtnRight4; }

            set
            {
                if (modelItems.BtnRight4 != value)
                {
                    modelItems.BtnRight4 = value;
                    RaisePropertyChanged("BtnRight4");
                }
            }
        }

        public string BtnLeft5
        {
            get { return modelItems.BtnLeft5; }

            set
            {
                if (modelItems.BtnLeft5 != value)
                {
                    modelItems.BtnLeft5 = value;
                    RaisePropertyChanged("BtnLeft5");
                }
            }
        }

        public string BtnRight5
        {
            get { return modelItems.BtnRight5; }

            set
            {
                if (modelItems.BtnRight5 != value)
                {
                    modelItems.BtnRight5 = value;
                    RaisePropertyChanged("BtnRight5");
                }
            }
        }

        public string BtnLeft6
        {
            get { return modelItems.BtnLeft6; }

            set
            {
                if (modelItems.BtnLeft6 != value)
                {
                    modelItems.BtnLeft6 = value;
                    RaisePropertyChanged("BtnLeft6");
                }
            }
        }

        public string BtnRight6
        {
            get { return modelItems.BtnRight6; }

            set
            {
                if (modelItems.BtnRight6 != value)
                {
                    modelItems.BtnRight6 = value;
                    RaisePropertyChanged("BtnRight6");
                }
            }
        }

        public string BtnLeft7
        {
            get { return modelItems.BtnLeft7; }

            set
            {
                if (modelItems.BtnLeft7 != value)
                {
                    modelItems.BtnLeft7 = value;
                    RaisePropertyChanged("BtnLeft7");
                }
            }
        }

        public string BtnRight7
        {
            get { return modelItems.BtnRight7; }

            set
            {
                if (modelItems.BtnRight7 != value)
                {
                    modelItems.BtnRight7 = value;
                    RaisePropertyChanged("BtnRight7");
                }
            }
        }

        public string BtnLeft8
        {
            get { return modelItems.BtnLeft8; }

            set
            {
                if (modelItems.BtnLeft8 != value)
                {
                    modelItems.BtnLeft8 = value;
                    RaisePropertyChanged("BtnLeft8");
                }
            }
        }

        public string BtnRight8
        {
            get { return modelItems.BtnRight8; }

            set
            {
                if (modelItems.BtnRight8 != value)
                {
                    modelItems.BtnRight8 = value;
                    RaisePropertyChanged("BtnRight8");
                }
            }
        }

        public string BtnLeft9
        {
            get { return modelItems.BtnLeft9; }

            set
            {
                if (modelItems.BtnLeft9 != value)
                {
                    modelItems.BtnLeft9 = value;
                    RaisePropertyChanged("BtnLeft9");
                }
            }
        }

        public string BtnRight9
        {
            get { return modelItems.BtnRight9; }

            set
            {
                if (modelItems.BtnRight9 != value)
                {
                    modelItems.BtnRight9 = value;
                    RaisePropertyChanged("BtnRight9");
                }
            }
        }

        public string BtnLeft10
        {
            get { return modelItems.BtnLeft10; }

            set
            {
                if (modelItems.BtnLeft10 != value)
                {
                    modelItems.BtnLeft10 = value;
                    RaisePropertyChanged("BtnLeft10");
                }
            }
        }

        public string BtnRight10
        {
            get { return modelItems.BtnRight10; }

            set
            {
                if (modelItems.BtnRight10 != value)
                {
                    modelItems.BtnRight10 = value;
                    RaisePropertyChanged("BtnRight10");
                }
            }
        }

        #endregion Properties for buttons

        /// <summary>
        /// Constructor for SoundBoardViewModel initializing commands for buttons in View
        /// </summary>
        public SoundBoardViewModel()
        {
            BtnLeft1PlaySoundCommand = new RelayCommand(o => BtnLeft1PlaySound("Play Sound"));
            BtnLeft1ChooseDirectoryCommand = new RelayCommand(o => BtnLeft1ChooseDirectory("Choose Directory"));
            BtnRight1PlaySoundCommand = new RelayCommand(o => BtnRight1PlaySound("Play Sound"));
            BtnRight1ChooseDirectoryCommand = new RelayCommand(o => BtnRight1ChooseDirectory("Choose Directory"));

            BtnLeft2PlaySoundCommand = new RelayCommand(o => BtnLeft2PlaySound("Play Sound"));
            BtnLeft2ChooseDirectoryCommand = new RelayCommand(o => BtnLeft2ChooseDirectory("Choose Directory"));
            BtnRight2PlaySoundCommand = new RelayCommand(o => BtnRight2PlaySound("Play Sound"));
            BtnRight2ChooseDirectoryCommand = new RelayCommand(o => BtnRight2ChooseDirectory("Choose Directory"));

            BtnLeft3PlaySoundCommand = new RelayCommand(o => BtnLeft3PlaySound("Play Sound"));
            BtnLeft3ChooseDirectoryCommand = new RelayCommand(o => BtnLeft3ChooseDirectory("Choose Directory"));
            BtnRight3PlaySoundCommand = new RelayCommand(o => BtnRight3PlaySound("Play Sound"));
            BtnRight3ChooseDirectoryCommand = new RelayCommand(o => BtnRight3ChooseDirectory("Choose Directory"));

            BtnLeft4PlaySoundCommand = new RelayCommand(o => BtnLeft4PlaySound("Play Sound"));
            BtnLeft4ChooseDirectoryCommand = new RelayCommand(o => BtnLeft4ChooseDirectory("Choose Directory"));
            BtnRight4PlaySoundCommand = new RelayCommand(o => BtnRight4PlaySound("Play Sound"));
            BtnRight4ChooseDirectoryCommand = new RelayCommand(o => BtnRight4ChooseDirectory("Choose Directory"));

            BtnLeft5PlaySoundCommand = new RelayCommand(o => BtnLeft5PlaySound("Play Sound"));
            BtnLeft5ChooseDirectoryCommand = new RelayCommand(o => BtnLeft5ChooseDirectory("Choose Directory"));
            BtnRight5PlaySoundCommand = new RelayCommand(o => BtnRight5PlaySound("Play Sound"));
            BtnRight5ChooseDirectoryCommand = new RelayCommand(o => BtnRight5ChooseDirectory("Choose Directory"));

            BtnLeft6PlaySoundCommand = new RelayCommand(o => BtnLeft6PlaySound("Play Sound"));
            BtnLeft6ChooseDirectoryCommand = new RelayCommand(o => BtnLeft6ChooseDirectory("Choose Directory"));
            BtnRight6PlaySoundCommand = new RelayCommand(o => BtnRight6PlaySound("Play Sound"));
            BtnRight6ChooseDirectoryCommand = new RelayCommand(o => BtnRight6ChooseDirectory("Choose Directory"));

            BtnLeft7PlaySoundCommand = new RelayCommand(o => BtnLeft7PlaySound("Play Sound"));
            BtnLeft7ChooseDirectoryCommand = new RelayCommand(o => BtnLeft7ChooseDirectory("Choose Directory"));
            BtnRight7PlaySoundCommand = new RelayCommand(o => BtnRight7PlaySound("Play Sound"));
            BtnRight7ChooseDirectoryCommand = new RelayCommand(o => BtnRight7ChooseDirectory("Choose Directory"));

            BtnLeft8PlaySoundCommand = new RelayCommand(o => BtnLeft8PlaySound("Play Sound"));
            BtnLeft8ChooseDirectoryCommand = new RelayCommand(o => BtnLeft8ChooseDirectory("Choose Directory"));
            BtnRight8PlaySoundCommand = new RelayCommand(o => BtnRight8PlaySound("Play Sound"));
            BtnRight8ChooseDirectoryCommand = new RelayCommand(o => BtnRight8ChooseDirectory("Choose Directory"));

            BtnLeft9PlaySoundCommand = new RelayCommand(o => BtnLeft9PlaySound("Play Sound"));
            BtnLeft9ChooseDirectoryCommand = new RelayCommand(o => BtnLeft9ChooseDirectory("Choose Directory"));
            BtnRight9PlaySoundCommand = new RelayCommand(o => BtnRight9PlaySound("Play Sound"));
            BtnRight9ChooseDirectoryCommand = new RelayCommand(o => BtnRight9ChooseDirectory("Choose Directory"));

            BtnLeft10PlaySoundCommand = new RelayCommand(o => BtnLeft10PlaySound("Play Sound"));
            BtnLeft10ChooseDirectoryCommand = new RelayCommand(o => BtnLeft10ChooseDirectory("Choose Directory"));
            BtnRight10PlaySoundCommand = new RelayCommand(o => BtnRight10PlaySound("Play Sound"));
            BtnRight10ChooseDirectoryCommand = new RelayCommand(o => BtnRight10ChooseDirectory("Choose Directory"));

            BtnStop = new RelayCommand(o => BtnStopSounds("Stop Sounds"));
            BtnHelp = new RelayCommand(o => BtnHelpClick("Button Help"));
        }

        /// <summary>
        /// Stops every sound from the program
        /// </summary>
        /// <param name="sender"></param>
        private void BtnStopSounds(object sender)
        {
            mp3Player.Close();
        }

        /// <summary>
        /// Displays basic information on how to use the program
        /// </summary>
        /// <param name="sender"></param>
        private void BtnHelpClick(object sender)
        {
            MessageBox.Show("Click \"...\" to load an audio file into the corresponding button.\n" +
                "Press the button, with the loaded file, to play the audio file.\n" +
                "Click \"Stop\" to stop the audio playback.\n" +
                "To adjust the volume open the soundmixer from the taskbar.");
        }

        #region Button Row 1

        private void BtnLeft1PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft1ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft1 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight1PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight1ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight1 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 1

        #region Button Row 2

        private void BtnLeft2PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft2ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft2 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight2PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight2ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight2 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 2

        #region Button Row 3

        private void BtnLeft3PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft3ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft3 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight3PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight3ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight3 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 3

        #region Button Row 4

        private void BtnLeft4PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft4ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft4 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight4PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight4ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight4 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 4

        #region Button Row 5

        private void BtnLeft5PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft5ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft5 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight5PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight5ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight5 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 5

        #region Button Row 6

        private void BtnLeft6PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft6ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft6 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight6PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight6ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight6 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 6

        #region Button Row 7

        private void BtnLeft7PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft7ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft7 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight7PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight7ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight7 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 7

        #region Button Row 8

        private void BtnLeft8PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft8ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft8 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight8PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight8ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight8 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 8

        #region Button Row 9

        private void BtnLeft9PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft9ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft9 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight9PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight9ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight9 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 9

        #region Button Row 10

        private void BtnLeft10PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnLeft10ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnLeft10 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        private void BtnRight10PlaySound(object sender)
        {
            mp3Player.Close();
            mp3Player.Open(PathToMp3);
            mp3Player.PlayMedia();
        }

        private void BtnRight10ChooseDirectory(object sender)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Assigning the button name from the file name
                BtnRight10 = openFileDialog.SafeFileName;
                // Opening the path selected by user
                PathToMp3 = openFileDialog.FileName;
            }
        }

        #endregion Button Row 10
    }
}