using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get;}
        
        /// <summary>
        /// The description of the entree
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// The special instructions of the entree
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the price, description and special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for event handler
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
