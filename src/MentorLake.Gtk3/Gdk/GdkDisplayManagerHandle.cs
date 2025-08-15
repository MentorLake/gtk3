namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// The purpose of the #GdkDisplayManager singleton object is to offer
/// notification when displays appear or disappear or the default display
/// changes.
/// </para>
/// <para>
/// You can use gdk_display_manager_get() to obtain the #GdkDisplayManager
/// singleton, but that should be rarely necessary. Typically, initializing
/// GTK+ opens a display that you can work with without ever accessing the
/// #GdkDisplayManager.
/// </para>
/// <para>
/// The GDK library can be built with support for multiple backends.
/// The #GdkDisplayManager object determines which backend is used
/// at runtime.
/// </para>
/// <para>
/// When writing backend-specific code that is supposed to work with
/// multiple GDK backends, you have to consider both compile time and
/// runtime. At compile time, use the #GDK_WINDOWING_X11, #GDK_WINDOWING_WIN32
/// macros, etc. to find out which backends are present in the GDK library
/// you are building your application against. At runtime, use type-check
/// macros like GDK_IS_X11_DISPLAY() to find out which backend is in use:
/// </para>
/// <para>
/// ## Backend-specific code ## {#backend-specific}
/// </para>
/// <code>
/// #ifdef GDK_WINDOWING_X11
/// #ifdef GDK_WINDOWING_X11
///   if (GDK_IS_X11_DISPLAY (display))
///     {
///       // make X11-specific calls here
///     }
///   else
/// #endif
/// #ifdef GDK_WINDOWING_QUARTZ
///   if (GDK_IS_QUARTZ_DISPLAY (display))
///     {
///       // make Quartz-specific calls here
///     }
///   else
/// #endif
///   g_error (&quot;Unsupported GDK backend&quot;);
/// </code>
/// </summary>

public class GdkDisplayManagerHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Gets the singleton #GdkDisplayManager object.
/// </para>
/// <para>
/// When called for the first time, this function consults the
/// `GDK_BACKEND` environment variable to find out which
/// of the supported GDK backends to use (in case GDK has been compiled
/// with multiple backends). Applications can use gdk_set_allowed_backends()
/// to limit what backends can be used.
/// </para>
/// </summary>

/// <return>
/// The global #GdkDisplayManager singleton;
///     gdk_parse_args(), gdk_init(), or gdk_init_check() must have
///     been called first.
/// </return>

	public static MentorLake.Gdk.GdkDisplayManagerHandle Get()
	{
		return GdkDisplayManagerHandleExterns.gdk_display_manager_get();
	}

}
public static class GdkDisplayManagerHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::display-opened signal is emitted when a display is opened.
/// </para>
/// </summary>

	public static IObservable<GdkDisplayManagerHandleSignalStructs.DisplayOpenedSignal> Signal_DisplayOpened(this GdkDisplayManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkDisplayManagerHandleSignalStructs.DisplayOpenedSignal> obs) =>
		{
			GdkDisplayManagerHandleSignalDelegates.display_opened handler = ( MentorLake.Gdk.GdkDisplayManagerHandle self,  MentorLake.Gdk.GdkDisplayHandle display,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayManagerHandleSignalStructs.DisplayOpenedSignal()
				{
					Self = self, Display = display, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "display-opened", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkDisplayManagerHandleSignalStructs
{

public class DisplayOpenedSignal
{

	public MentorLake.Gdk.GdkDisplayManagerHandle Self;
/// <summary>
/// <para>
/// the opened display
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDisplayHandle Display;

	public IntPtr UserData;
}
}

public static class GdkDisplayManagerHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::display-opened signal is emitted when a display is opened.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="display">
/// the opened display
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void display_opened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, IntPtr user_data);

}


public static class GdkDisplayManagerHandleExtensions
{
/// <summary>
/// <para>
/// Gets the default #GdkDisplay.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GdkDisplayManager
/// </param>
/// <return>
/// a #GdkDisplay, or %NULL if
///     there is no default display.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDefaultDisplay(this MentorLake.Gdk.GdkDisplayManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GdkDisplayManagerHandle)");
		return GdkDisplayManagerHandleExterns.gdk_display_manager_get_default_display(manager);
	}

/// <summary>
/// <para>
/// List all currently open displays.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GdkDisplayManager
/// </param>
/// <return>
/// a newly
///     allocated #GSList of #GdkDisplay objects. Free with g_slist_free()
///     when you are done with it.
/// </return>

	public static MentorLake.GLib.GSListHandle ListDisplays(this MentorLake.Gdk.GdkDisplayManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GdkDisplayManagerHandle)");
		return GdkDisplayManagerHandleExterns.gdk_display_manager_list_displays(manager);
	}

/// <summary>
/// <para>
/// Opens a display.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GdkDisplayManager
/// </param>
/// <param name="name">
/// the name of the display to open
/// </param>
/// <return>
/// a #GdkDisplay, or %NULL if the
///     display could not be opened
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle OpenDisplay(this MentorLake.Gdk.GdkDisplayManagerHandle manager, string name)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GdkDisplayManagerHandle)");
		return GdkDisplayManagerHandleExterns.gdk_display_manager_open_display(manager, name);
	}

/// <summary>
/// <para>
/// Sets @display as the default display.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GdkDisplayManager
/// </param>
/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T SetDefaultDisplay<T>(this T manager, MentorLake.Gdk.GdkDisplayHandle display) where T : GdkDisplayManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GdkDisplayManagerHandle)");
		GdkDisplayManagerHandleExterns.gdk_display_manager_set_default_display(manager, display);
		return manager;
	}

}

internal class GdkDisplayManagerHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_manager_get_default_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gdk_display_manager_list_displays([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gdk_display_manager_open_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager, string name);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_display_manager_set_default_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))] MentorLake.Gdk.GdkDisplayManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayManagerHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayManagerHandle gdk_display_manager_get();

}
