using Soundboard.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Soundboard.Model
{
    public class MP3Player : CommonBase
    {
        private string _command;
        private bool isOpen;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        // Stops playback
        public void Close()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        // Opens file to play later
        public void Open(string sFileName)
        {
            _command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }

        // Plays the media
        public void PlayMedia()
        {
            _command = "play MediaFile from 0";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        //public void Play(bool loop)
        //{
        //    if (isOpen)
        //    {
        //        _command = "play MediaFile";
        //        if (loop)
        //            _command += "REPEAT";
        //        mciSendString(_command, null, 0, IntPtr.Zero);
        //    }
        //}
    }
}