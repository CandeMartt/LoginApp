using AppTest.Handlers;
using AppTest.Models;
using Microsoft.Maui.Platform;

namespace AppTest;

public partial class App : Application
{
	public static UserBasicInfo UserDetails;
		public App()
		{
			InitializeComponent();
			Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
				{
					if (view is BorderlessEntry)
					{
						#if __ANDROID__
                        handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
						#endif
                    }
                });
			MainPage = new AppShell();
		}
}
