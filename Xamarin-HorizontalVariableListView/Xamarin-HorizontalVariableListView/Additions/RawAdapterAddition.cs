using Android.Runtime;
using Android.Widget;

namespace Com.Devsmart.Android.UI {

  public partial class HorizontalListView : AdapterView {

    protected override Java.Lang.Object RawAdapter {
      get {return Adapter.JavaCast<Java.Lang.Object>();}
      set {Adapter = value.JavaCast<global::Android.Widget.IListAdapter>();}
    }
  }
}