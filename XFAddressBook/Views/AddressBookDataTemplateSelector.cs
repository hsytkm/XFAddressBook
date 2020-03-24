using Xamarin.Forms;

namespace XFAddressBook.Views
{
    class AddressBookDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TitleTemplate { get; set; }
        public DataTemplate DataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (item is GroupTitleInList) ? TitleTemplate : DataTemplate;
            //return base.SelectTemplate(item, container);
        }
    }

    // リスト内のタイトル識別用クラス
    class GroupTitleInList
    {
        public string Title { get; }
        public GroupTitleInList(string title) => Title = title;
        public override string ToString() => "Title: " + Title;
    }

}
