using Xamarin.Forms;

namespace XFAddressBook.Views
{
    class MyCollectionViewEffect : RoutingEffect
    {
        public const string CompanyName = "XFAddressBook";
        public const string EffectName = "MyCollectionViewEffect";

        public MyCollectionViewEffect() : base(CompanyName + "." + EffectName)
        {
        }
    }
}
