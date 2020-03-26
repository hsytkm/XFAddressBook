using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFAddressBook.Droid;

// Androidでは使っていないので無効化(定義がなければ何も起きない)

//[assembly: ResolutionGroupName("XFAddressBook")]
//[assembly: ExportEffect(typeof(MyCollectionViewEffect), nameof(MyCollectionViewEffect))]
//namespace XFAddressBook.Droid
//{
//    class MyCollectionViewEffect : PlatformEffect
//    {
//        protected override void OnAttached()
//        {
//            if (!(Element is CollectionView)) return;

//            if (Control is Xamarin.Forms.Platform.Android.CollectionViewRenderer renderer)
//            {
//            }
//        }

//        protected override void OnDetached()
//        {
//        }
//    }
//}