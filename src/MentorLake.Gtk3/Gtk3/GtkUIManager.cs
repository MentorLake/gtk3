namespace MentorLake.Gtk3.Gtk3;

public class GtkUIManagerHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkUIManagerHandle GtkUiManagerNew()
	{
		return GtkUIManagerExterns.gtk_ui_manager_new();
	}

}

public static class GtkUIManagerSignalExtensions
{

	public static IObservable<GtkUIManagerSignalStructs.ActionsChangedSignal> Signal_ActionsChanged(this GtkUIManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkUIManagerSignalStructs.ActionsChangedSignal> obs) =>
		{
			GtkUIManagerSignalDelegates.actions_changed handler = (GtkUIManagerHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerSignalStructs.ActionsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "actions_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkUIManagerSignalStructs.AddWidgetSignal> Signal_AddWidget(this GtkUIManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkUIManagerSignalStructs.AddWidgetSignal> obs) =>
		{
			GtkUIManagerSignalDelegates.add_widget handler = (GtkUIManagerHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerSignalStructs.AddWidgetSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "add_widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkUIManagerSignalStructs.ConnectProxySignal> Signal_ConnectProxy(this GtkUIManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkUIManagerSignalStructs.ConnectProxySignal> obs) =>
		{
			GtkUIManagerSignalDelegates.connect_proxy handler = (GtkUIManagerHandle self, GtkActionHandle action, GtkWidgetHandle proxy, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerSignalStructs.ConnectProxySignal()
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

	public static IObservable<GtkUIManagerSignalStructs.DisconnectProxySignal> Signal_DisconnectProxy(this GtkUIManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkUIManagerSignalStructs.DisconnectProxySignal> obs) =>
		{
			GtkUIManagerSignalDelegates.disconnect_proxy handler = (GtkUIManagerHandle self, GtkActionHandle action, GtkWidgetHandle proxy, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerSignalStructs.DisconnectProxySignal()
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

	public static IObservable<GtkUIManagerSignalStructs.PostActivateSignal> Signal_PostActivate(this GtkUIManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkUIManagerSignalStructs.PostActivateSignal> obs) =>
		{
			GtkUIManagerSignalDelegates.post_activate handler = (GtkUIManagerHandle self, GtkActionHandle action, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerSignalStructs.PostActivateSignal()
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

	public static IObservable<GtkUIManagerSignalStructs.PreActivateSignal> Signal_PreActivate(this GtkUIManagerHandle instance)
	{
		return Observable.Create((IObserver<GtkUIManagerSignalStructs.PreActivateSignal> obs) =>
		{
			GtkUIManagerSignalDelegates.pre_activate handler = (GtkUIManagerHandle self, GtkActionHandle action, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerSignalStructs.PreActivateSignal()
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

public static class GtkUIManagerSignalStructs
{

public struct ActionsChangedSignal
{
	public GtkUIManagerHandle Self;
	public IntPtr UserData;
}

public struct AddWidgetSignal
{
	public GtkUIManagerHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public struct ConnectProxySignal
{
	public GtkUIManagerHandle Self;
	public GtkActionHandle Action;
	public GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public struct DisconnectProxySignal
{
	public GtkUIManagerHandle Self;
	public GtkActionHandle Action;
	public GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public struct PostActivateSignal
{
	public GtkUIManagerHandle Self;
	public GtkActionHandle Action;
	public IntPtr UserData;
}

public struct PreActivateSignal
{
	public GtkUIManagerHandle Self;
	public GtkActionHandle Action;
	public IntPtr UserData;
}
}

public static class GtkUIManagerSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void actions_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkUIManagerHandle>))] GtkUIManagerHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkUIManagerHandle>))] GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkUIManagerHandle>))] GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkUIManagerHandle>))] GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void post_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkUIManagerHandle>))] GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pre_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkUIManagerHandle>))] GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle action, IntPtr user_data);

}


public static class GtkUIManagerHandleExtensions
{
	public static GtkUIManagerHandle GtkUiManagerAddUi(this GtkUIManagerHandle manager, uint merge_id, string path, string name, string action, GtkUIManagerItemType type, bool top)
	{
		GtkUIManagerExterns.gtk_ui_manager_add_ui(manager, merge_id, path, name, action, type, top);
		return manager;
	}

	public static uint GtkUiManagerAddUiFromFile(this GtkUIManagerHandle manager, string filename, out GErrorHandle error)
	{
		return GtkUIManagerExterns.gtk_ui_manager_add_ui_from_file(manager, filename, out error);
	}

	public static uint GtkUiManagerAddUiFromResource(this GtkUIManagerHandle manager, string resource_path, out GErrorHandle error)
	{
		return GtkUIManagerExterns.gtk_ui_manager_add_ui_from_resource(manager, resource_path, out error);
	}

	public static uint GtkUiManagerAddUiFromString(this GtkUIManagerHandle manager, string buffer, UIntPtr length, out GErrorHandle error)
	{
		return GtkUIManagerExterns.gtk_ui_manager_add_ui_from_string(manager, buffer, length, out error);
	}

	public static GtkUIManagerHandle GtkUiManagerEnsureUpdate(this GtkUIManagerHandle manager)
	{
		GtkUIManagerExterns.gtk_ui_manager_ensure_update(manager);
		return manager;
	}

	public static GtkAccelGroupHandle GtkUiManagerGetAccelGroup(this GtkUIManagerHandle manager)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_accel_group(manager);
	}

	public static GtkActionHandle GtkUiManagerGetAction(this GtkUIManagerHandle manager, string path)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_action(manager, path);
	}

	public static GListHandle GtkUiManagerGetActionGroups(this GtkUIManagerHandle manager)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_action_groups(manager);
	}

	public static bool GtkUiManagerGetAddTearoffs(this GtkUIManagerHandle manager)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_add_tearoffs(manager);
	}

	public static GSListHandle GtkUiManagerGetToplevels(this GtkUIManagerHandle manager, GtkUIManagerItemType types)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_toplevels(manager, types);
	}

	public static string GtkUiManagerGetUi(this GtkUIManagerHandle manager)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_ui(manager);
	}

	public static GtkWidgetHandle GtkUiManagerGetWidget(this GtkUIManagerHandle manager, string path)
	{
		return GtkUIManagerExterns.gtk_ui_manager_get_widget(manager, path);
	}

	public static GtkUIManagerHandle GtkUiManagerInsertActionGroup(this GtkUIManagerHandle manager, GtkActionGroupHandle action_group, int pos)
	{
		GtkUIManagerExterns.gtk_ui_manager_insert_action_group(manager, action_group, pos);
		return manager;
	}

	public static uint GtkUiManagerNewMergeId(this GtkUIManagerHandle manager)
	{
		return GtkUIManagerExterns.gtk_ui_manager_new_merge_id(manager);
	}

	public static GtkUIManagerHandle GtkUiManagerRemoveActionGroup(this GtkUIManagerHandle manager, GtkActionGroupHandle action_group)
	{
		GtkUIManagerExterns.gtk_ui_manager_remove_action_group(manager, action_group);
		return manager;
	}

	public static GtkUIManagerHandle GtkUiManagerRemoveUi(this GtkUIManagerHandle manager, uint merge_id)
	{
		GtkUIManagerExterns.gtk_ui_manager_remove_ui(manager, merge_id);
		return manager;
	}

	public static GtkUIManagerHandle GtkUiManagerSetAddTearoffs(this GtkUIManagerHandle manager, bool add_tearoffs)
	{
		GtkUIManagerExterns.gtk_ui_manager_set_add_tearoffs(manager, add_tearoffs);
		return manager;
	}

}

internal class GtkUIManagerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkUIManagerHandle gtk_ui_manager_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_ui_manager_add_ui(GtkUIManagerHandle manager, uint merge_id, string path, string name, string action, GtkUIManagerItemType type, bool top);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_ui_manager_add_ui_from_file(GtkUIManagerHandle manager, string filename, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_ui_manager_add_ui_from_resource(GtkUIManagerHandle manager, string resource_path, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_ui_manager_add_ui_from_string(GtkUIManagerHandle manager, string buffer, UIntPtr length, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_ui_manager_ensure_update(GtkUIManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelGroupHandle gtk_ui_manager_get_accel_group(GtkUIManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkActionHandle gtk_ui_manager_get_action(GtkUIManagerHandle manager, string path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_ui_manager_get_action_groups(GtkUIManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_ui_manager_get_add_tearoffs(GtkUIManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_ui_manager_get_toplevels(GtkUIManagerHandle manager, GtkUIManagerItemType types);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_ui_manager_get_ui(GtkUIManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_ui_manager_get_widget(GtkUIManagerHandle manager, string path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_ui_manager_insert_action_group(GtkUIManagerHandle manager, GtkActionGroupHandle action_group, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_ui_manager_new_merge_id(GtkUIManagerHandle manager);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_ui_manager_remove_action_group(GtkUIManagerHandle manager, GtkActionGroupHandle action_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_ui_manager_remove_ui(GtkUIManagerHandle manager, uint merge_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_ui_manager_set_add_tearoffs(GtkUIManagerHandle manager, bool add_tearoffs);

}
