using DynamicToolTipSample.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace DynamicToolTipSample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string enabled = "Enabled ToolTip";
        private string disabled = "Disabled ToolTip";
        private bool isRadioButtonEnabled = true;

        public string Enabled
        {
            get => enabled;
            set
            {
                enabled = value;
                OnPropertyChanged(nameof(Enabled));
            }
        }

        public string Disabled
        {
            get => disabled;
            set
            {
                disabled = value;
                OnPropertyChanged(nameof(Disabled));
            }
        }

        public bool IsRadioButtonEnabled
        {
            get => isRadioButtonEnabled;
            set
            {
                isRadioButtonEnabled = value;
                OnPropertyChanged(nameof(IsRadioButtonEnabled));
            }
        }

        public void Initialize(Button btn)
        {
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            IsRadioButtonEnabled = !IsRadioButtonEnabled;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
