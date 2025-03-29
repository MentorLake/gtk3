namespace MentorLake.GdkX11;

public class GdkX11ScreenHandle : GdkScreenHandle
{
}
public static class GdkX11ScreenHandleSignalExtensions
{

	public static IObservable<GdkX11ScreenHandleSignalStructs.WindowManagerChangedSignal> Signal_WindowManagerChanged(this GdkX11ScreenHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkX11ScreenHandleSignalStructs.WindowManagerChangedSignal> obs) =>
		{
			GdkX11ScreenHandleSignalDelegates.window_manager_changed handler = ( MentorLake.GdkX11.GdkX11ScreenHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkX11ScreenHandleSignalStructs.WindowManagerChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-manager-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkX11ScreenHandleSignalStructs
{

public struct WindowManagerChangedSignal
{
	public MentorLake.GdkX11.GdkX11ScreenHandle Self;
	public IntPtr UserData;
}
}

public static class GdkX11ScreenHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_manager_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle self, IntPtr user_data);

}


public static class GdkX11ScreenHandleExtensions
{
	public static uint GetCurrentDesktop(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_current_desktop(screen);
	}

	public static ulong GetMonitorOutput(this MentorLake.GdkX11.GdkX11ScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_monitor_output(screen, monitor_num);
	}

	public static uint GetNumberOfDesktops(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_number_of_desktops(screen);
	}

	public static int GetScreenNumber(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_screen_number(screen);
	}

	public static string GetWindowManagerName(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_window_manager_name(screen);
	}

	public static MentorLake.xlib.ScreenHandle GetXscreen(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_xscreen(screen);
	}

	public static MentorLake.GdkX11.GdkX11VisualHandle LookupVisual(this MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.xlib.VisualID xvisualid)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_lookup_visual(screen, xvisualid);
	}

	public static bool SupportsNetWmHint(this MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.Gdk.GdkAtom property)
	{
		if (screen.IsInvalid || screen.IsClosed) throw new Exception("Invalid or closed handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_supports_net_wm_hint(screen, property);
	}

}

internal class GdkX11ScreenHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern uint gdk_x11_screen_get_current_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen);

	[DllImport(GdkX11Library.Name)]
	internal static extern ulong gdk_x11_screen_get_monitor_output([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen, int monitor_num);

	[DllImport(GdkX11Library.Name)]
	internal static extern uint gdk_x11_screen_get_number_of_desktops([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen);

	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_screen_get_screen_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_screen_get_window_manager_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.ScreenHandle gdk_x11_screen_get_xscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.GdkX11.GdkX11VisualHandle gdk_x11_screen_lookup_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.xlib.VisualID xvisualid);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_screen_supports_net_wm_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.Gdk.GdkAtom property);

}
