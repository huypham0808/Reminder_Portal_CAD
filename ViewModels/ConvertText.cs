using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows.Input;

namespace CSS_Palette.ViewModels
{
    public class ConvertText : mainForm2, INotifyPropertyChanged
    {
        private string _inputText;
        public string InputText
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged(nameof(InputText));
            }
        }
        private string _resultText;
        public string ResultText
        {
            get { return _resultText; }
            set
            {
                _resultText = value;
                OnPropertyChanged(nameof(ResultText));
            }
        }
        public ICommand ConvertCommand { get; set; }
        
        public ConvertText()
        {
            ConvertCommand = new RelaysCommand(ConvertToUpper);
        }
        //Method
        private void ConvertToUpper()
        {
            ResultText = InputText.ToUpper();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
