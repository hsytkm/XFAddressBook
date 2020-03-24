using Xamarin.Forms;

namespace XFAddressBook.Views
{
    interface ISelectableView
    {
        bool IsSelected { get; set; }

        void SwitchIsSelected();
    }

    class SelectableGrid : Grid, ISelectableView
    {
        public static readonly BindableProperty IsSelectedProperty =
            BindableProperty.Create(nameof(IsSelected), typeof(bool), typeof(SelectableGrid), null);

        public bool IsSelected
        {
            set => SetValue(IsSelectedProperty, value);
            get => (bool)GetValue(IsSelectedProperty);
        }

        public void SwitchIsSelected() => IsSelected = !IsSelected;
    }
}
