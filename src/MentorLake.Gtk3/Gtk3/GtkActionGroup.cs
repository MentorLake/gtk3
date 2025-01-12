namespace MentorLake.Gtk3.Gtk3;

public class GtkActionGroupHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkActionGroupHandle New(string name)
	{
		return GtkActionGroupExterns.gtk_action_group_new(name);
	}

}

public static class GtkActionGroupSignalExtensions
{

	public static IObservable<GtkActionGroupSignalStructs.ConnectProxySignal> Signal_ConnectProxy(this GtkActionGroupHandle instance)
	{
		return Observable.Create((IObserver<GtkActionGroupSignalStructs.ConnectProxySignal> obs) =>
		{
			GtkActionGroupSignalDelegates.connect_proxy handler = (GtkActionGroupHandle self, GtkActionHandle action, GtkWidgetHandle proxy, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupSignalStructs.ConnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "connect_proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkActionGroupSignalStructs.DisconnectProxySignal> Signal_DisconnectProxy(this GtkActionGroupHandle instance)
	{
		return Observable.Create((IObserver<GtkActionGroupSignalStructs.DisconnectProxySignal> obs) =>
		{
			GtkActionGroupSignalDelegates.disconnect_proxy handler = (GtkActionGroupHandle self, GtkActionHandle action, GtkWidgetHandle proxy, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupSignalStructs.DisconnectProxySignal()
				{
					Self = self, Action = action, Proxy = proxy, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "disconnect_proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkActionGroupSignalStructs.PostActivateSignal> Signal_PostActivate(this GtkActionGroupHandle instance)
	{
		return Observable.Create((IObserver<GtkActionGroupSignalStructs.PostActivateSignal> obs) =>
		{
			GtkActionGroupSignalDelegates.post_activate handler = (GtkActionGroupHandle self, GtkActionHandle action, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupSignalStructs.PostActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "post_activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkActionGroupSignalStructs.PreActivateSignal> Signal_PreActivate(this GtkActionGroupHandle instance)
	{
		return Observable.Create((IObserver<GtkActionGroupSignalStructs.PreActivateSignal> obs) =>
		{
			GtkActionGroupSignalDelegates.pre_activate handler = (GtkActionGroupHandle self, GtkActionHandle action, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionGroupSignalStructs.PreActivateSignal()
				{
					Self = self, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "pre_activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkActionGroupSignalStructs
{

public struct ConnectProxySignal
{
	public GtkActionGroupHandle Self;
	public GtkActionHandle Action;
	public GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public struct DisconnectProxySignal
{
	public GtkActionGroupHandle Self;
	public GtkActionHandle Action;
	public GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public struct PostActivateSignal
{
	public GtkActionGroupHandle Self;
	public GtkActionHandle Action;
	public IntPtr UserData;
}

public struct PreActivateSignal
{
	public GtkActionGroupHandle Self;
	public GtkActionHandle Action;
	public IntPtr UserData;
}
}

public static class GtkActionGroupSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionGroupHandle>))] GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionGroupHandle>))] GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void post_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionGroupHandle>))] GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pre_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionGroupHandle>))] GtkActionGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, IntPtr user_data);

}


public static class GtkActionGroupHandleExtensions
{
	public static T AddAction<T>(this T action_group, GtkActionHandle action) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_action(action_group, action);
		return action_group;
	}

	public static T AddActionWithAccel<T>(this T action_group, GtkActionHandle action, string accelerator) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_action_with_accel(action_group, action, accelerator);
		return action_group;
	}

	public static T AddActions<T>(this T action_group, GtkActionEntry[] entries, uint n_entries, IntPtr user_data) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_actions(action_group, entries, n_entries, user_data);
		return action_group;
	}

	public static T AddActionsFull<T>(this T action_group, GtkActionEntry[] entries, uint n_entries, IntPtr user_data, GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_actions_full(action_group, entries, n_entries, user_data, destroy);
		return action_group;
	}

	public static T AddRadioActions<T>(this T action_group, GtkRadioActionEntry[] entries, uint n_entries, int value, IntPtr on_change, IntPtr user_data) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_radio_actions(action_group, entries, n_entries, value, on_change, user_data);
		return action_group;
	}

	public static T AddRadioActionsFull<T>(this T action_group, GtkRadioActionEntry[] entries, uint n_entries, int value, IntPtr on_change, IntPtr user_data, GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_radio_actions_full(action_group, entries, n_entries, value, on_change, user_data, destroy);
		return action_group;
	}

	public static T AddToggleActions<T>(this T action_group, GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_toggle_actions(action_group, entries, n_entries, user_data);
		return action_group;
	}

	public static T AddToggleActionsFull<T>(this T action_group, GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data, GDestroyNotify destroy) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_add_toggle_actions_full(action_group, entries, n_entries, user_data, destroy);
		return action_group;
	}

	public static GtkAccelGroupHandle GetAccelGroup(this GtkActionGroupHandle action_group)
	{
		return GtkActionGroupExterns.gtk_action_group_get_accel_group(action_group);
	}

	public static GtkActionHandle GetAction(this GtkActionGroupHandle action_group, string action_name)
	{
		return GtkActionGroupExterns.gtk_action_group_get_action(action_group, action_name);
	}

	public static string GetName(this GtkActionGroupHandle action_group)
	{
		return GtkActionGroupExterns.gtk_action_group_get_name(action_group);
	}

	public static bool GetSensitive(this GtkActionGroupHandle action_group)
	{
		return GtkActionGroupExterns.gtk_action_group_get_sensitive(action_group);
	}

	public static bool GetVisible(this GtkActionGroupHandle action_group)
	{
		return GtkActionGroupExterns.gtk_action_group_get_visible(action_group);
	}

	public static GListHandle ListActions(this GtkActionGroupHandle action_group)
	{
		return GtkActionGroupExterns.gtk_action_group_list_actions(action_group);
	}

	public static T RemoveAction<T>(this T action_group, GtkActionHandle action) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_remove_action(action_group, action);
		return action_group;
	}

	public static T SetAccelGroup<T>(this T action_group, GtkAccelGroupHandle accel_group) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_set_accel_group(action_group, accel_group);
		return action_group;
	}

	public static T SetSensitive<T>(this T action_group, bool sensitive) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_set_sensitive(action_group, sensitive);
		return action_group;
	}

	public static T SetTranslateFunc<T>(this T action_group, GtkTranslateFunc func, IntPtr data, GDestroyNotify notify) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_set_translate_func(action_group, func, data, notify);
		return action_group;
	}

	public static T SetTranslationDomain<T>(this T action_group, string domain) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_set_translation_domain(action_group, domain);
		return action_group;
	}

	public static T SetVisible<T>(this T action_group, bool visible) where T : GtkActionGroupHandle
	{
		GtkActionGroupExterns.gtk_action_group_set_visible(action_group, visible);
		return action_group;
	}

	public static string TranslateString(this GtkActionGroupHandle action_group, string @string)
	{
		return GtkActionGroupExterns.gtk_action_group_translate_string(action_group, @string);
	}

}

internal class GtkActionGroupExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkActionGroupHandle gtk_action_group_new(string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_action(GtkActionGroupHandle action_group, GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_action_with_accel(GtkActionGroupHandle action_group, GtkActionHandle action, string accelerator);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_actions(GtkActionGroupHandle action_group, GtkActionEntry[] entries, uint n_entries, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_actions_full(GtkActionGroupHandle action_group, GtkActionEntry[] entries, uint n_entries, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_radio_actions(GtkActionGroupHandle action_group, GtkRadioActionEntry[] entries, uint n_entries, int value, IntPtr on_change, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_radio_actions_full(GtkActionGroupHandle action_group, GtkRadioActionEntry[] entries, uint n_entries, int value, IntPtr on_change, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_toggle_actions(GtkActionGroupHandle action_group, GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_add_toggle_actions_full(GtkActionGroupHandle action_group, GtkToggleActionEntry[] entries, uint n_entries, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelGroupHandle gtk_action_group_get_accel_group(GtkActionGroupHandle action_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkActionHandle gtk_action_group_get_action(GtkActionGroupHandle action_group, string action_name);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_group_get_name(GtkActionGroupHandle action_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_group_get_sensitive(GtkActionGroupHandle action_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_group_get_visible(GtkActionGroupHandle action_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_action_group_list_actions(GtkActionGroupHandle action_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_remove_action(GtkActionGroupHandle action_group, GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_set_accel_group(GtkActionGroupHandle action_group, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_set_sensitive(GtkActionGroupHandle action_group, bool sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_set_translate_func(GtkActionGroupHandle action_group, GtkTranslateFunc func, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_set_translation_domain(GtkActionGroupHandle action_group, string domain);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_group_set_visible(GtkActionGroupHandle action_group, bool visible);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_group_translate_string(GtkActionGroupHandle action_group, string @string);

}
