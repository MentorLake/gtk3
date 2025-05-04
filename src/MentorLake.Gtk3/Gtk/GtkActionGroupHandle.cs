namespace MentorLake.Gtk;

public class GtkActionGroupHandle : GObjectHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkActionGroupHandle New(string name)
	{
		return GtkActionGroupHandleExterns.gtk_action_group_new(name);
	}

}
public static class GtkActionGroupHandleSignalExtensions
{

	public static IObservable<GtkActionGroupHandleSignalStructs.ConnectProxySignal> Signal_ConnectProxy(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.ConnectProxySignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.connect_proxy handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.ConnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "connect-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkActionGroupHandleSignalStructs.DisconnectProxySignal> Signal_DisconnectProxy(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.DisconnectProxySignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.disconnect_proxy handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.DisconnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "disconnect-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkActionGroupHandleSignalStructs.PostActivateSignal> Signal_PostActivate(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.PostActivateSignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.post_activate handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.PostActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "post-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkActionGroupHandleSignalStructs.PreActivateSignal> Signal_PreActivate(this GtkActionGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionGroupHandleSignalStructs.PreActivateSignal> obs) =>
		{
			GtkActionGroupHandleSignalDelegates.pre_activate handler = ( MentorLake.Gtk.GtkActionGroupHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupHandleSignalStructs.PreActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pre-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkActionGroupHandleSignalStructs
{

public class ConnectProxySignal
{
	public MentorLake.Gtk.GtkActionGroupHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public MentorLake.Gtk.GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public class DisconnectProxySignal
{
	public MentorLake.Gtk.GtkActionGroupHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public MentorLake.Gtk.GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public class PostActivateSignal
{
	public MentorLake.Gtk.GtkActionGroupHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public IntPtr UserData;
}

public class PreActivateSignal
{
	public MentorLake.Gtk.GtkActionGroupHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public IntPtr UserData;
}
}

public static class GtkActionGroupHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void post_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pre_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);

}


public static class GtkActionGroupHandleExtensions
{
	public static T AddAction<T>(this T action_group, MentorLake.Gtk.GtkActionHandle action) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_action(action_group, action);
		return action_group;
	}

	public static T AddActionWithAccel<T>(this T action_group, MentorLake.Gtk.GtkActionHandle action, string accelerator) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_action_with_accel(action_group, action, accelerator);
		return action_group;
	}

	public static T AddActions<T>(this T action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_actions(action_group, entries, n_entries, user_data);
		return action_group;
	}

	public static T AddActionsFull<T>(this T action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_actions_full(action_group, entries, n_entries, user_data, destroy);
		return action_group;
	}

	public static T AddRadioActions<T>(this T action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_radio_actions(action_group, entries, n_entries, value, on_change, user_data);
		return action_group;
	}

	public static T AddRadioActionsFull<T>(this T action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_radio_actions_full(action_group, entries, n_entries, value, on_change, user_data, destroy);
		return action_group;
	}

	public static T AddToggleActions<T>(this T action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_toggle_actions(action_group, entries, n_entries, user_data);
		return action_group;
	}

	public static T AddToggleActionsFull<T>(this T action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_add_toggle_actions_full(action_group, entries, n_entries, user_data, destroy);
		return action_group;
	}

	public static MentorLake.Gtk.GtkAccelGroupHandle GetAccelGroup(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_accel_group(action_group);
	}

	public static MentorLake.Gtk.GtkActionHandle GetAction(this MentorLake.Gtk.GtkActionGroupHandle action_group, string action_name)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_action(action_group, action_name);
	}

	public static string GetName(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_name(action_group);
	}

	public static bool GetSensitive(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_sensitive(action_group);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_get_visible(action_group);
	}

	public static MentorLake.GLib.GListHandle ListActions(this MentorLake.Gtk.GtkActionGroupHandle action_group)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_list_actions(action_group);
	}

	public static T RemoveAction<T>(this T action_group, MentorLake.Gtk.GtkActionHandle action) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_remove_action(action_group, action);
		return action_group;
	}

	public static T SetAccelGroup<T>(this T action_group, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_accel_group(action_group, accel_group);
		return action_group;
	}

	public static T SetSensitive<T>(this T action_group, bool sensitive) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_sensitive(action_group, sensitive);
		return action_group;
	}

	public static T SetTranslateFunc<T>(this T action_group, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_translate_func(action_group, func, data, notify);
		return action_group;
	}

	public static T SetTranslationDomain<T>(this T action_group, string domain) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_translation_domain(action_group, domain);
		return action_group;
	}

	public static T SetVisible<T>(this T action_group, bool visible) where T : GtkActionGroupHandle
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		GtkActionGroupHandleExterns.gtk_action_group_set_visible(action_group, visible);
		return action_group;
	}

	public static string TranslateString(this MentorLake.Gtk.GtkActionGroupHandle action_group, string @string)
	{
		if (action_group.IsInvalid || action_group.IsClosed) throw new Exception("Invalid or closed handle (GtkActionGroupHandle)");
		return GtkActionGroupHandleExterns.gtk_action_group_translate_string(action_group, @string);
	}

}

internal class GtkActionGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkActionGroupHandle gtk_action_group_new(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_action_with_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string accelerator);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_actions_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_radio_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_radio_actions_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkRadioActionEntry[] entries, uint n_entries, int value, MentorLake.GObject.GCallback on_change, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_toggle_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_add_toggle_actions_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_action_group_get_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_action_group_get_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, string action_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_group_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_group_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_group_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_action_group_list_actions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_remove_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_translate_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, string domain);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_group_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, bool visible);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_group_translate_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, string @string);

}
