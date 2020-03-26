using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XFAddressBook.UWP;

[assembly: ResolutionGroupName("XFAddressBook")]
[assembly: ExportEffect(typeof(MyCollectionViewEffect), nameof(MyCollectionViewEffect))]
namespace XFAddressBook.UWP
{
    class MyCollectionViewEffect : PlatformEffect
    {
        //private Thickness _oldPadding;

        protected override void OnAttached()
        {
            if (!(Element is CollectionView)) return;

            if (Control is Windows.UI.Xaml.Controls.ListView listView)
            {
                var style = listView.ItemContainerStyle;
                if (style.TargetType == typeof(Windows.UI.Xaml.Controls.ListViewItem))
                {
                    // 設定前の値を読み出したいけど Exception でちゃう…
                    //var oldPadding = (Windows.UI.Xaml.Thickness)style.GetValue(Windows.UI.Xaml.Controls.ListViewItem.PaddingProperty);

                    // ListViewItem の左右にできる隙間を無くす対応
                    style.Setters.Add(new Windows.UI.Xaml.Setter(
                        Windows.UI.Xaml.Controls.Control.PaddingProperty,
                        new Windows.UI.Xaml.Thickness(0)));

                    listView.ItemContainerStyle = style;
                }
            }
        }

        protected override void OnDetached()
        {
            //if (_oldPadding != default)
            //{
            //  設定上書き前の値に戻したい…
            //}
        }
    }
}