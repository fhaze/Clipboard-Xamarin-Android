using Android.App;
using Android.Content;
using Android.OS;

namespace ClipboardTest.Droid.Services
{
    [Service]
    public class ClipboardCaptureService : Service
    {
        private ClipboardManager _clipboardManager;

        public override IBinder OnBind(Intent intent)
        {
            throw new System.NotImplementedException();
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            _clipboardManager = GetSystemService(ClipboardService) as ClipboardManager;
            _clipboardManager.AddPrimaryClipChangedListener(new TestListener(this, _clipboardManager));

            return base.OnStartCommand(intent, flags, startId);
        }
    }
}