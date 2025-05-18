namespace MentorLake.Gtk;

public class GtkUIManagerHandle : GObjectHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkUIManagerHandle New()
	{
		return GtkUIManagerHandleExterns.gtk_ui_manager_new();
	}

}
public static class GtkUIManagerHandleSignalExtensions
{

	public static IObservable<GtkUIManagerHandleSignalStructs.ActionsChangedSignal> Signal_ActionsChanged(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.ActionsChangedSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.actions_changed handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.ActionsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "actions-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkUIManagerHandleSignalStructs.AddWidgetSignal> Signal_AddWidget(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.AddWidgetSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.add_widget handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.AddWidgetSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "add-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkUIManagerHandleSignalStructs.ConnectProxySignal> Signal_ConnectProxy(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.ConnectProxySignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.connect_proxy handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.ConnectProxySignal()
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

	public static IObservable<GtkUIManagerHandleSignalStructs.DisconnectProxySignal> Signal_DisconnectProxy(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.DisconnectProxySignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.disconnect_proxy handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  MentorLake.Gtk.GtkWidgetHandle proxy,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.DisconnectProxySignal()
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

	public static IObservable<GtkUIManagerHandleSignalStructs.PostActivateSignal> Signal_PostActivate(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.PostActivateSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.post_activate handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.PostActivateSignal()
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

	public static IObservable<GtkUIManagerHandleSignalStructs.PreActivateSignal> Signal_PreActivate(this GtkUIManagerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkUIManagerHandleSignalStructs.PreActivateSignal> obs) =>
		{
			GtkUIManagerHandleSignalDelegates.pre_activate handler = ( MentorLake.Gtk.GtkUIManagerHandle self,  MentorLake.Gtk.GtkActionHandle action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkUIManagerHandleSignalStructs.PreActivateSignal()
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

public static class GtkUIManagerHandleSignalStructs
{

public class ActionsChangedSignal
{
	public MentorLake.Gtk.GtkUIManagerHandle Self;
	public IntPtr UserData;
}

public class AddWidgetSignal
{
	public MentorLake.Gtk.GtkUIManagerHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public class ConnectProxySignal
{
	public MentorLake.Gtk.GtkUIManagerHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public MentorLake.Gtk.GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public class DisconnectProxySignal
{
	public MentorLake.Gtk.GtkUIManagerHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public MentorLake.Gtk.GtkWidgetHandle Proxy;
	public IntPtr UserData;
}

public class PostActivateSignal
{
	public MentorLake.Gtk.GtkUIManagerHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public IntPtr UserData;
}

public class PreActivateSignal
{
	public MentorLake.Gtk.GtkUIManagerHandle Self;
	public MentorLake.Gtk.GtkActionHandle Action;
	public IntPtr UserData;
}
}

public static class GtkUIManagerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void actions_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void add_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnect_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle proxy, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void post_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pre_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, IntPtr user_data);

}


public static class GtkUIManagerHandleExtensions
{
	public static T AddUi<T>(this T manager, uint merge_id, string path, string name, string action, MentorLake.Gtk.GtkUIManagerItemType type, bool top) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_add_ui(manager, merge_id, path, name, action, type, top);
		return manager;
	}

	public static uint AddUiFromFile(this MentorLake.Gtk.GtkUIManagerHandle manager, string filename)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		var externCallResult = GtkUIManagerHandleExterns.gtk_ui_manager_add_ui_from_file(manager, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddUiFromResource(this MentorLake.Gtk.GtkUIManagerHandle manager, string resource_path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		var externCallResult = GtkUIManagerHandleExterns.gtk_ui_manager_add_ui_from_resource(manager, resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint AddUiFromString(this MentorLake.Gtk.GtkUIManagerHandle manager, string buffer, UIntPtr length)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		var externCallResult = GtkUIManagerHandleExterns.gtk_ui_manager_add_ui_from_string(manager, buffer, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T EnsureUpdate<T>(this T manager) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_ensure_update(manager);
		return manager;
	}

	public static MentorLake.Gtk.GtkAccelGroupHandle GetAccelGroup(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_accel_group(manager);
	}

	public static MentorLake.Gtk.GtkActionHandle GetAction(this MentorLake.Gtk.GtkUIManagerHandle manager, string path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_action(manager, path);
	}

	public static MentorLake.GLib.GListHandle GetActionGroups(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_action_groups(manager);
	}

	public static bool GetAddTearoffs(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_add_tearoffs(manager);
	}

	public static MentorLake.GLib.GSListHandle GetToplevels(this MentorLake.Gtk.GtkUIManagerHandle manager, MentorLake.Gtk.GtkUIManagerItemType types)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_toplevels(manager, types);
	}

	public static string GetUi(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_ui(manager);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkUIManagerHandle manager, string path)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_get_widget(manager, path);
	}

	public static T InsertActionGroup<T>(this T manager, MentorLake.Gtk.GtkActionGroupHandle action_group, int pos) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_insert_action_group(manager, action_group, pos);
		return manager;
	}

	public static uint NewMergeId(this MentorLake.Gtk.GtkUIManagerHandle manager)
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		return GtkUIManagerHandleExterns.gtk_ui_manager_new_merge_id(manager);
	}

	public static T RemoveActionGroup<T>(this T manager, MentorLake.Gtk.GtkActionGroupHandle action_group) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_remove_action_group(manager, action_group);
		return manager;
	}

	public static T RemoveUi<T>(this T manager, uint merge_id) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_remove_ui(manager, merge_id);
		return manager;
	}

	public static T SetAddTearoffs<T>(this T manager, bool add_tearoffs) where T : GtkUIManagerHandle
	{
		if (manager.IsInvalid) throw new Exception("Invalid handle (GtkUIManagerHandle)");
		GtkUIManagerHandleExterns.gtk_ui_manager_set_add_tearoffs(manager, add_tearoffs);
		return manager;
	}

}

internal class GtkUIManagerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))]
	internal static extern MentorLake.Gtk.GtkUIManagerHandle gtk_ui_manager_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_add_ui([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, uint merge_id, string path, string name, string action, MentorLake.Gtk.GtkUIManagerItemType type, bool top);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_add_ui_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_add_ui_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string resource_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_add_ui_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string buffer, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_ensure_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_ui_manager_get_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_ui_manager_get_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_ui_manager_get_action_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_ui_manager_get_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_ui_manager_get_toplevels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, MentorLake.Gtk.GtkUIManagerItemType types);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_ui_manager_get_ui([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_ui_manager_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_insert_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_ui_manager_new_merge_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_remove_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionGroupHandle>))] MentorLake.Gtk.GtkActionGroupHandle action_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_remove_ui([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, uint merge_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_ui_manager_set_add_tearoffs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkUIManagerHandle>))] MentorLake.Gtk.GtkUIManagerHandle manager, bool add_tearoffs);

}
