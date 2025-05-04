namespace MentorLake.Gtk;

public class GtkApplicationWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GActionGroupHandle, GActionMapHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkApplicationWindowHandle New(MentorLake.Gtk.GtkApplicationHandle application)
	{
		return GtkApplicationWindowHandleExterns.gtk_application_window_new(application);
	}

}
public static class GtkApplicationWindowHandleSignalExtensions
{

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionAddedSignal()
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

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionEnabledChangedSignal()
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

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionRemovedSignal()
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

	public static IObservable<GtkApplicationWindowHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GtkApplicationWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkApplicationWindowHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GtkApplicationWindowHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkApplicationWindowHandleSignalStructs.ActionStateChangedSignal()
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

public static class GtkApplicationWindowHandleSignalStructs
{

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

public static class GtkApplicationWindowHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GtkApplicationWindowHandleExtensions
{
	public static MentorLake.Gtk.GtkShortcutsWindowHandle GetHelpOverlay(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkApplicationWindowHandle)");
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_help_overlay(window);
	}

	public static uint GetId(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkApplicationWindowHandle)");
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_id(window);
	}

	public static bool GetShowMenubar(this MentorLake.Gtk.GtkApplicationWindowHandle window)
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkApplicationWindowHandle)");
		return GtkApplicationWindowHandleExterns.gtk_application_window_get_show_menubar(window);
	}

	public static T SetHelpOverlay<T>(this T window, MentorLake.Gtk.GtkShortcutsWindowHandle help_overlay) where T : GtkApplicationWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkApplicationWindowHandle)");
		GtkApplicationWindowHandleExterns.gtk_application_window_set_help_overlay(window, help_overlay);
		return window;
	}

	public static T SetShowMenubar<T>(this T window, bool show_menubar) where T : GtkApplicationWindowHandle
	{
		if (window.IsInvalid || window.IsClosed) throw new Exception("Invalid or closed handle (GtkApplicationWindowHandle)");
		GtkApplicationWindowHandleExterns.gtk_application_window_set_show_menubar(window, show_menubar);
		return window;
	}

}

internal class GtkApplicationWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkApplicationWindowHandle gtk_application_window_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShortcutsWindowHandle gtk_application_window_get_help_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_application_window_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_application_window_get_show_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_window_set_help_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle help_overlay);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_application_window_set_show_menubar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationWindowHandle>))] MentorLake.Gtk.GtkApplicationWindowHandle window, bool show_menubar);

}
