using Xamarin.Forms;

namespace XFAddressBook.Views
{
    //class NotSelectableItemsViewBehavior : Behavior<SelectableItemsView>
    //{
    //    protected override void OnAttachedTo(SelectableItemsView bindable)
    //    {
    //        base.OnAttachedTo(bindable);
    //        bindable.SelectionChanged += SelectableItemsView_SelectionChanged;
    //    }

    //    protected override void OnDetachingFrom(SelectableItemsView bindable)
    //    {
    //        bindable.SelectionChanged -= SelectableItemsView_SelectionChanged;
    //        base.OnDetachingFrom(bindable);
    //    }

    //    private static void SelectableItemsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //    {
    //        if (!(sender is SelectableItemsView view)) return;

    //        // 期待通りの動作にならない(選択項目が解除されない)
    //        // 代入しているのに値が書き換わらない… なぜ
    //        view.SelectedItem = null;
    //    }
    //}
}
