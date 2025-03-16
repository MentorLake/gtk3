namespace MentorLake.Gtk;

public class GtkApplicationHandle : GApplicationHandle, GActionGroupHandle, GActionMapHandle
{
	public static MentorLake.Gtk.GtkApplicationHandle New(string application_id, MentorLake.Gio.GApplicationFlags flags)
	{
		return GtkApplicationHandleExterns.gtk_application_new(application_id, flags);
	}

}
public static class GtkApplicationHandleSignalExtensions
{

	public static IObservable<GtkApplicationHandleSignalStructs.QueryEndSignal> Signal_QueryEnd(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.QueryEndSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.query_end handler = ( MentorLake.Gtk.GtkApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.QueryEndSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkApplicationHandleSignalStructs.WindowAddedSignal> Signal_WindowAdded(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.WindowAddedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.window_added handler = ( MentorLake.Gtk.GtkApplicationHandle self,  MentorLake.Gtk.GtkWindowHandle window,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.WindowAddedSignal()
				{
					Self = self, Window = window, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkApplicationHandleSignalStructs.WindowRemovedSignal> Signal_WindowRemoved(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.WindowRemovedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.window_removed handler = ( MentorLake.Gtk.GtkApplicationHandle self,  MentorLake.Gtk.GtkWindowHandle window,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.WindowRemovedSignal()
				{
					Self = self, Window = window, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkApplicationHandleSignalStructs
{

public struct QueryEndSignal
{
	public MentorLake.Gtk.GtkApplicationHandle Self;
	public IntPtr UserData;
}

public struct WindowAddedSignal
{
	public MentorLake.Gtk.GtkApplicationHandle Self;
	public MentorLake.Gtk.GtkWindowHandle Window;
	public IntPtr UserData;
}

public struct WindowRemovedSignal
{
	public MentorLake.Gtk.GtkApplicationHandle Self;
	public MentorLake.Gtk.GtkWindowHandle Window;
	public IntPtr UserData;
}
}

public static class GtkApplicationHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void query_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, IntPtr user_data);

}


public static class GtkApplicationHandleExtensions
{
	public static T AddAccelerator<T>(this T application, string accelerator, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_add_accelerator(application, accelerator, action_name, parameter);
		return application;
	}

	public static T AddWindow<T>(this T application, MentorLake.Gtk.GtkWindowHandle window) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_add_window(application, window);
		return application;
	}

	public static string[] GetAccelsForAction(this MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name)
	{
		return GtkApplicationHandleExterns.gtk_application_get_accels_for_action(application, detailed_action_name);
	}

	public static string[] GetActionsForAccel(this MentorLake.Gtk.GtkApplicationHandle application, string accel)
	{
		return GtkApplicationHandleExterns.gtk_application_get_actions_for_accel(application, accel);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetActiveWindow(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationHandleExterns.gtk_application_get_active_window(application);
	}

	public static MentorLake.Gio.GMenuModelHandle GetAppMenu(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationHandleExterns.gtk_application_get_app_menu(application);
	}

	public static MentorLake.Gio.GMenuHandle GetMenuById(this MentorLake.Gtk.GtkApplicationHandle application, string id)
	{
		return GtkApplicationHandleExterns.gtk_application_get_menu_by_id(application, id);
	}

	public static MentorLake.Gio.GMenuModelHandle GetMenubar(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationHandleExterns.gtk_application_get_menubar(application);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetWindowById(this MentorLake.Gtk.GtkApplicationHandle application, uint id)
	{
		return GtkApplicationHandleExterns.gtk_application_get_window_by_id(application, id);
	}

	public static MentorLake.GLib.GListHandle GetWindows(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationHandleExterns.gtk_application_get_windows(application);
	}

	public static uint Inhibit(this MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkApplicationInhibitFlags flags, string reason)
	{
		return GtkApplicationHandleExterns.gtk_application_inhibit(application, window, flags, reason);
	}

	public static bool IsInhibited(this MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkApplicationInhibitFlags flags)
	{
		return GtkApplicationHandleExterns.gtk_application_is_inhibited(application, flags);
	}

	public static string[] ListActionDescriptions(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationHandleExterns.gtk_application_list_action_descriptions(application);
	}

	public static bool PrefersAppMenu(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationHandleExterns.gtk_application_prefers_app_menu(application);
	}

	public static T RemoveAccelerator<T>(this T application, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_remove_accelerator(application, action_name, parameter);
		return application;
	}

	public static T RemoveWindow<T>(this T application, MentorLake.Gtk.GtkWindowHandle window) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_remove_window(application, window);
		return application;
	}

	public static T SetAccelsForAction<T>(this T application, string detailed_action_name, string[] accels) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_set_accels_for_action(application, detailed_action_name, accels);
		return application;
	}

	public static T SetAppMenu<T>(this T application, MentorLake.Gio.GMenuModelHandle app_menu) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_set_app_menu(application, app_menu);
		return application;
	}

	public static T SetMenubar<T>(this T application, MentorLake.Gio.GMenuModelHandle menubar) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_set_menubar(application, menubar);
		return application;
	}

	public static T Uninhibit<T>(this T application, uint cookie) where T : GtkApplicationHandle
	{
		GtkApplicationHandleExterns.gtk_application_uninhibit(application, cookie);
		return application;
	}

}

internal class GtkApplicationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_application_new(string application_id, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_add_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string accelerator, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_add_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern string[] gtk_application_get_accels_for_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern string[] gtk_application_get_actions_for_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string accel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_application_get_active_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_application_get_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuHandle gtk_application_get_menu_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_application_get_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_application_get_window_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, uint id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_application_get_windows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_application_inhibit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkApplicationInhibitFlags flags, string reason);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_is_inhibited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkApplicationInhibitFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern string[] gtk_application_list_action_descriptions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_prefers_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_remove_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_remove_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_set_accels_for_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name, string[] accels);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_set_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle app_menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_set_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle menubar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_uninhibit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, uint cookie);

}
