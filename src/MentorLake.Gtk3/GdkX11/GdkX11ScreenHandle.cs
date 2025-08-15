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

public class WindowManagerChangedSignal
{

	public MentorLake.GdkX11.GdkX11ScreenHandle Self;

	public IntPtr UserData;
}
}

public static class GdkX11ScreenHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_manager_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle self, IntPtr user_data);

}


public static class GdkX11ScreenHandleExtensions
{
/// <summary>
/// <para>
/// Returns the current workspace for @screen when running under a
/// window manager that supports multiple workspaces, as described
/// in the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec) specification.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the current workspace, or 0 if workspaces are not supported
/// </return>

	public static uint GetCurrentDesktop(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_current_desktop(screen);
	}

/// <summary>
/// <para>
/// Gets the XID of the specified output/monitor.
/// If the X server does not support version 1.2 of the RANDR
/// extension, 0 is returned.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="monitor_num">
/// number of the monitor, between 0 and gdk_screen_get_n_monitors (screen)
/// </param>
/// <return>
/// the XID of the monitor
/// </return>

	public static ulong GetMonitorOutput(this MentorLake.GdkX11.GdkX11ScreenHandle screen, int monitor_num)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_monitor_output(screen, monitor_num);
	}

/// <summary>
/// <para>
/// Returns the number of workspaces for @screen when running under a
/// window manager that supports multiple workspaces, as described
/// in the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec) specification.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the number of workspaces, or 0 if workspaces are not supported
/// </return>

	public static uint GetNumberOfDesktops(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_number_of_desktops(screen);
	}

/// <summary>
/// <para>
/// Returns the index of a #GdkScreen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the position of @screen among the screens
///     of its display
/// </return>

	public static int GetScreenNumber(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_screen_number(screen);
	}

/// <summary>
/// <para>
/// Returns the name of the window manager for @screen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// the name of the window manager screen @screen, or
/// &quot;unknown&quot; if the window manager is unknown. The string is owned by GDK
/// and should not be freed.
/// </return>

	public static string GetWindowManagerName(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_window_manager_name(screen);
	}

/// <summary>
/// <para>
/// Returns the screen of a #GdkScreen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <return>
/// an Xlib Screen*
/// </return>

	public static MentorLake.xlib.ScreenHandle GetXscreen(this MentorLake.GdkX11.GdkX11ScreenHandle screen)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_get_xscreen(screen);
	}

/// <summary>
/// <para>
/// Looks up the #GdkVisual for a particular screen and X Visual ID.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen.
/// </param>
/// <param name="xvisualid">
/// an X Visual ID.
/// </param>
/// <return>
/// the #GdkVisual (owned by the screen
///   object), or %NULL if the visual ID wasn’t found.
/// </return>

	public static MentorLake.GdkX11.GdkX11VisualHandle LookupVisual(this MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.xlib.VisualID xvisualid)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
		return GdkX11ScreenHandleExterns.gdk_x11_screen_lookup_visual(screen, xvisualid);
	}

/// <summary>
/// <para>
/// This function is specific to the X11 backend of GDK, and indicates
/// whether the window manager supports a certain hint from the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec) specification.
/// </para>
/// <para>
/// When using this function, keep in mind that the window manager
/// can change over time; so you shouldn’t use this function in
/// a way that impacts persistent application state. A common bug
/// is that your application can start up before the window manager
/// does when the user logs in, and before the window manager starts
/// gdk_x11_screen_supports_net_wm_hint() will return %FALSE for every property.
/// You can monitor the window_manager_changed signal on #GdkScreen to detect
/// a window manager change.
/// </para>
/// </summary>

/// <param name="screen">
/// the relevant #GdkScreen.
/// </param>
/// <param name="property">
/// a property atom.
/// </param>
/// <return>
/// %TRUE if the window manager supports @property
/// </return>

	public static bool SupportsNetWmHint(this MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.Gdk.GdkAtom property)
	{
		if (screen.IsInvalid) throw new Exception("Invalid handle (GdkX11ScreenHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.ScreenHandle>))]
	internal static extern MentorLake.xlib.ScreenHandle gdk_x11_screen_get_xscreen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11VisualHandle>))]
	internal static extern MentorLake.GdkX11.GdkX11VisualHandle gdk_x11_screen_lookup_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.xlib.VisualID xvisualid);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_screen_supports_net_wm_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11ScreenHandle>))] MentorLake.GdkX11.GdkX11ScreenHandle screen, MentorLake.Gdk.GdkAtom property);

}
