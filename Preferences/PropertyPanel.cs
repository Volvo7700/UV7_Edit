using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public class PropertyPanel : Panel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void RaisePropertyChanged(string name)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(name));
        }
    }
}
