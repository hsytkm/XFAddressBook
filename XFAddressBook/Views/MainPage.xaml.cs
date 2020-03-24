using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFAddressBook.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 複数の選択対象から1項目だけを選択する
        /// </summary>
        private void SelectSingleItem(object sender, EventArgs e)
        {
            var prevSelected = _lastSelectedView;
            var newSelected = (ISelectableView)sender;

            if (prevSelected == newSelected)
            {
                newSelected.SwitchIsSelected();
            }
            else
            {
                if (prevSelected != null)
                {
                    prevSelected.IsSelected = false;
                }
                newSelected.IsSelected = true;
                _lastSelectedView = newSelected;
            }
        }
        private ISelectableView _lastSelectedView;

        /// <summary>
        /// 複数の選択対象から複数項目を選択する
        /// </summary>
        private void SelectMultiItem(object sender, EventArgs e)
        {
            ((ISelectableView)sender).SwitchIsSelected();
        }

    }
}
