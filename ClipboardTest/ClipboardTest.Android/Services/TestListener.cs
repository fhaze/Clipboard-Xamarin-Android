using Android.App;
using Android.Content;
using Android.Widget;

namespace ClipboardTest.Droid.Services
{
    public class TestListener : Java.Lang.Object, ClipboardManager.IOnPrimaryClipChangedListener
    {
        private readonly Service          _service;
        private readonly ClipboardManager _clipboardManager;

        public TestListener(Service service, ClipboardManager clipboardManager)
        {
            _service          = service;
            _clipboardManager = clipboardManager;
        }

        public void OnPrimaryClipChanged()
        {
            var clipData = _clipboardManager.PrimaryClip;
            Toast.MakeText(_service, clipData.GetItemAt(0).Text, ToastLength.Long).Show();
        }
    }
}