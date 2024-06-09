using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EasyMVVM
{
    public class MainWindowVM : DependencyObject, INotifyPropertyChanged
    {
        // Set up a private class variable that holds the value of the _Backing Property
        private ObservableCollection<string> _BackingProperty;

        // This is the publically viewable Property for this class
        public ObservableCollection<string> BoundProperty
        {
            get { return _BackingProperty; }
            set { _BackingProperty = value; PropChanged("BoundProperty"); }
        }

        // This event will be fired to notify any listeners of a change in a property value.
        public event PropertyChangedEventHandler PropertyChanged;

        // Tell WPF Binding that this property value has changed
        public void PropChanged(String propertyName)
        {
            // Did WPF register to listen to this event
            if (PropertyChanged != null)
            {
                // Tell WPF that this property changed
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Constructor
        public MainWindowVM()
        {
            // Create an object of Model
            Model m = new Model();
            // Assign the result of the GetData() method to the BoundProperty property
            BoundProperty = m.GetData();
        }
    }
}

