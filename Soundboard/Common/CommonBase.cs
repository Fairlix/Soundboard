﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Common
{
    public class CommonBase : INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged Event to raise to any UI object
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The PropertChangedEvent to rause to any UI object
        ///The Event is only invoked if data binding is used
        /// </summary>
        /// <param name="propertyName">The property name this is changing</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            // Grab a handler
            PropertyChangedEventHandler handler = this.PropertyChanged;

            // Only raise event if handler is connected
            if (handler != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                // Raise the PropertyChanged event.
                handler(this, args);
            }
        }
    }
}