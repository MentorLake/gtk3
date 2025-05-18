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

	public static IObservable<GtkApplicationHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionAddedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkApplicationHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionEnabledChangedSignal()
				{
					Self = self, ActionName = action_name, Enabled = enabled, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-enabled-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkApplicationHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionRemovedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkApplicationHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GtkApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GtkApplicationHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationHandleSignalStructs.ActionStateChangedSignal()
				{
					Self = self, ActionName = action_name, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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

public class QueryEndSignal
{
	public MentorLake.Gtk.GtkApplicationHandle Self;
	public IntPtr UserData;
}

public class WindowAddedSignal
{
	public MentorLake.Gtk.GtkApplicationHandle Self;
	public MentorLake.Gtk.GtkWindowHandle Window;
	public IntPtr UserData;
}

public class WindowRemovedSignal
{
	public MentorLake.Gtk.GtkApplicationHandle Self;
	public MentorLake.Gtk.GtkWindowHandle Window;
	public IntPtr UserData;
}

public class ActionAddedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public IntPtr UserData;
}

public class ActionEnabledChangedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public bool Enabled;
	public IntPtr UserData;
}

public class ActionRemovedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public IntPtr UserData;
}

public class ActionStateChangedSignal
{
	public MentorLake.Gio.GActionGroupHandle Self;
	public string ActionName;
	public MentorLake.GLib.GVariantHandle Value;
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


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GtkApplicationHandleExtensions
{
	public static T AddAccelerator<T>(this T application, string accelerator, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_add_accelerator(application, accelerator, action_name, parameter);
		return application;
	}

	public static T AddWindow<T>(this T application, MentorLake.Gtk.GtkWindowHandle window) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_add_window(application, window);
		return application;
	}

	public static string[] GetAccelsForAction(this MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_accels_for_action(application, detailed_action_name);
	}

	public static string[] GetActionsForAccel(this MentorLake.Gtk.GtkApplicationHandle application, string accel)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_actions_for_accel(application, accel);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetActiveWindow(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_active_window(application);
	}

	public static MentorLake.Gio.GMenuModelHandle GetAppMenu(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_app_menu(application);
	}

	public static MentorLake.Gio.GMenuHandle GetMenuById(this MentorLake.Gtk.GtkApplicationHandle application, string id)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_menu_by_id(application, id);
	}

	public static MentorLake.Gio.GMenuModelHandle GetMenubar(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_menubar(application);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetWindowById(this MentorLake.Gtk.GtkApplicationHandle application, uint id)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_window_by_id(application, id);
	}

	public static MentorLake.GLib.GListHandle GetWindows(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_get_windows(application);
	}

	public static uint Inhibit(this MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkApplicationInhibitFlags flags, string reason)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_inhibit(application, window, flags, reason);
	}

	public static bool IsInhibited(this MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkApplicationInhibitFlags flags)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_is_inhibited(application, flags);
	}

	public static string[] ListActionDescriptions(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_list_action_descriptions(application);
	}

	public static bool PrefersAppMenu(this MentorLake.Gtk.GtkApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		return GtkApplicationHandleExterns.gtk_application_prefers_app_menu(application);
	}

	public static T RemoveAccelerator<T>(this T application, string action_name, MentorLake.GLib.GVariantHandle parameter) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_remove_accelerator(application, action_name, parameter);
		return application;
	}

	public static T RemoveWindow<T>(this T application, MentorLake.Gtk.GtkWindowHandle window) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_remove_window(application, window);
		return application;
	}

	public static T SetAccelsForAction<T>(this T application, string detailed_action_name, string[] accels) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_set_accels_for_action(application, detailed_action_name, accels);
		return application;
	}

	public static T SetAppMenu<T>(this T application, MentorLake.Gio.GMenuModelHandle app_menu) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_set_app_menu(application, app_menu);
		return application;
	}

	public static T SetMenubar<T>(this T application, MentorLake.Gio.GMenuModelHandle menubar) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_set_menubar(application, menubar);
		return application;
	}

	public static T Uninhibit<T>(this T application, uint cookie) where T : GtkApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GtkApplicationHandle)");
		GtkApplicationHandleExterns.gtk_application_uninhibit(application, cookie);
		return application;
	}

}

internal class GtkApplicationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))]
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_application_new(string application_id, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_add_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string accelerator, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_add_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_application_get_accels_for_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string detailed_action_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_application_get_actions_for_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string accel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_application_get_active_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_application_get_app_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuHandle>))]
	internal static extern MentorLake.Gio.GMenuHandle gtk_application_get_menu_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, string id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_application_get_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_application_get_window_by_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, uint id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_application_get_windows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_application_inhibit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gtk.GtkApplicationInhibitFlags flags, string reason);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_is_inhibited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application, MentorLake.Gtk.GtkApplicationInhibitFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
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
