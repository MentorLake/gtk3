namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11ScreenHandle : GdkScreenHandle
{
}

public static class GdkX11ScreenSignalExtensions
{

	public static IObservable<GdkX11ScreenSignalStructs.WindowManagerChangedSignal> Signal_WindowManagerChanged(this GdkX11ScreenHandle instance)
	{
		return Observable.Create((IObserver<GdkX11ScreenSignalStructs.WindowManagerChangedSignal> obs) =>
		{
			GdkX11ScreenSignalDelegates.window_manager_changed handler = (GdkX11ScreenHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkX11ScreenSignalStructs.WindowManagerChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "window_manager_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkX11ScreenSignalStructs
{

public struct WindowManagerChangedSignal
{
	public GdkX11ScreenHandle Self;
	public IntPtr UserData;
}
}

public static class GdkX11ScreenSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_manager_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkX11ScreenHandle>))] GdkX11ScreenHandle self, IntPtr user_data);

}


public static class GdkX11ScreenHandleExtensions
{
	public static uint GetCurrentDesktop(GdkScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_current_desktop(screen);
	}

	public static ulong GetMonitorOutput(GdkScreenHandle screen, int monitor_num)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_monitor_output(screen, monitor_num);
	}

	public static uint GetNumberOfDesktops(GdkScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_number_of_desktops(screen);
	}

	public static int GetScreenNumber(GdkScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_screen_number(screen);
	}

	public static string GetWindowManagerName(GdkScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_window_manager_name(screen);
	}

	public static IntPtr GetXscreen(GdkScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_xscreen(screen);
	}

	public static GdkVisualHandle LookupVisual(GdkScreenHandle screen, VisualID xvisualid)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_lookup_visual(screen, xvisualid);
	}

	public static bool SupportsNetWmHint(GdkScreenHandle screen, GdkAtom property)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_supports_net_wm_hint(screen, property);
	}

}

internal class GdkX11ScreenExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern uint gdk_x11_screen_get_current_desktop(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern ulong gdk_x11_screen_get_monitor_output(GdkScreenHandle screen, int monitor_num);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern uint gdk_x11_screen_get_number_of_desktops(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern int gdk_x11_screen_get_screen_number(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_screen_get_window_manager_name(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern IntPtr gdk_x11_screen_get_xscreen(GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern GdkVisualHandle gdk_x11_screen_lookup_visual(GdkScreenHandle screen, VisualID xvisualid);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern bool gdk_x11_screen_supports_net_wm_hint(GdkScreenHandle screen, GdkAtom property);

}
