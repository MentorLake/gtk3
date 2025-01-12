namespace MentorLake.Gtk3.Gtk3;

public class GtkMenuItemHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkMenuItemHandle New()
	{
		return GtkMenuItemExterns.gtk_menu_item_new();
	}

	public static GtkMenuItemHandle NewWithLabel(string label)
	{
		return GtkMenuItemExterns.gtk_menu_item_new_with_label(label);
	}

	public static GtkMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkMenuItemExterns.gtk_menu_item_new_with_mnemonic(label);
	}

}

public static class GtkMenuItemSignalExtensions
{

	public static IObservable<GtkMenuItemSignalStructs.ActivateSignal> Signal_Activate(this GtkMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuItemSignalStructs.ActivateSignal> obs) =>
		{
			GtkMenuItemSignalDelegates.activate handler = (GtkMenuItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuItemSignalStructs.ActivateItemSignal> Signal_ActivateItem(this GtkMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuItemSignalStructs.ActivateItemSignal> obs) =>
		{
			GtkMenuItemSignalDelegates.activate_item handler = (GtkMenuItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemSignalStructs.ActivateItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuItemSignalStructs.DeselectSignal> Signal_Deselect(this GtkMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuItemSignalStructs.DeselectSignal> obs) =>
		{
			GtkMenuItemSignalDelegates.deselect handler = (GtkMenuItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemSignalStructs.DeselectSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "deselect", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuItemSignalStructs.SelectSignal> Signal_Select(this GtkMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuItemSignalStructs.SelectSignal> obs) =>
		{
			GtkMenuItemSignalDelegates.select handler = (GtkMenuItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemSignalStructs.SelectSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuItemSignalStructs.ToggleSizeAllocateSignal> Signal_ToggleSizeAllocate(this GtkMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuItemSignalStructs.ToggleSizeAllocateSignal> obs) =>
		{
			GtkMenuItemSignalDelegates.toggle_size_allocate handler = (GtkMenuItemHandle self, int @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemSignalStructs.ToggleSizeAllocateSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_size_allocate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuItemSignalStructs.ToggleSizeRequestSignal> Signal_ToggleSizeRequest(this GtkMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuItemSignalStructs.ToggleSizeRequestSignal> obs) =>
		{
			GtkMenuItemSignalDelegates.toggle_size_request handler = (GtkMenuItemHandle self, IntPtr @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemSignalStructs.ToggleSizeRequestSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_size_request", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkMenuItemSignalStructs
{

public struct ActivateSignal
{
	public GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct ActivateItemSignal
{
	public GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct DeselectSignal
{
	public GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct SelectSignal
{
	public GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct ToggleSizeAllocateSignal
{
	public GtkMenuItemHandle Self;
	public int Object;
	public IntPtr UserData;
}

public struct ToggleSizeRequestSignal
{
	public GtkMenuItemHandle Self;
	public IntPtr Object;
	public IntPtr UserData;
}
}

public static class GtkMenuItemSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuItemHandle>))] GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuItemHandle>))] GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuItemHandle>))] GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuItemHandle>))] GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuItemHandle>))] GtkMenuItemHandle self, int @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuItemHandle>))] GtkMenuItemHandle self, IntPtr @object, IntPtr user_data);

}


public static class GtkMenuItemHandleExtensions
{
	public static GtkMenuItemHandle Activate(this GtkMenuItemHandle menu_item)
	{
		GtkMenuItemExterns.gtk_menu_item_activate(menu_item);
		return menu_item;
	}

	public static GtkMenuItemHandle Deselect(this GtkMenuItemHandle menu_item)
	{
		GtkMenuItemExterns.gtk_menu_item_deselect(menu_item);
		return menu_item;
	}

	public static string GetAccelPath(this GtkMenuItemHandle menu_item)
	{
		return GtkMenuItemExterns.gtk_menu_item_get_accel_path(menu_item);
	}

	public static string GetLabel(this GtkMenuItemHandle menu_item)
	{
		return GtkMenuItemExterns.gtk_menu_item_get_label(menu_item);
	}

	public static bool GetReserveIndicator(this GtkMenuItemHandle menu_item)
	{
		return GtkMenuItemExterns.gtk_menu_item_get_reserve_indicator(menu_item);
	}

	public static bool GetRightJustified(this GtkMenuItemHandle menu_item)
	{
		return GtkMenuItemExterns.gtk_menu_item_get_right_justified(menu_item);
	}

	public static GtkWidgetHandle GetSubmenu(this GtkMenuItemHandle menu_item)
	{
		return GtkMenuItemExterns.gtk_menu_item_get_submenu(menu_item);
	}

	public static bool GetUseUnderline(this GtkMenuItemHandle menu_item)
	{
		return GtkMenuItemExterns.gtk_menu_item_get_use_underline(menu_item);
	}

	public static GtkMenuItemHandle Select(this GtkMenuItemHandle menu_item)
	{
		GtkMenuItemExterns.gtk_menu_item_select(menu_item);
		return menu_item;
	}

	public static GtkMenuItemHandle SetAccelPath(this GtkMenuItemHandle menu_item, string accel_path)
	{
		GtkMenuItemExterns.gtk_menu_item_set_accel_path(menu_item, accel_path);
		return menu_item;
	}

	public static GtkMenuItemHandle SetLabel(this GtkMenuItemHandle menu_item, string label)
	{
		GtkMenuItemExterns.gtk_menu_item_set_label(menu_item, label);
		return menu_item;
	}

	public static GtkMenuItemHandle SetReserveIndicator(this GtkMenuItemHandle menu_item, bool reserve)
	{
		GtkMenuItemExterns.gtk_menu_item_set_reserve_indicator(menu_item, reserve);
		return menu_item;
	}

	public static GtkMenuItemHandle SetRightJustified(this GtkMenuItemHandle menu_item, bool right_justified)
	{
		GtkMenuItemExterns.gtk_menu_item_set_right_justified(menu_item, right_justified);
		return menu_item;
	}

	public static GtkMenuItemHandle SetSubmenu(this GtkMenuItemHandle menu_item, GtkWidgetHandle submenu)
	{
		GtkMenuItemExterns.gtk_menu_item_set_submenu(menu_item, submenu);
		return menu_item;
	}

	public static GtkMenuItemHandle SetUseUnderline(this GtkMenuItemHandle menu_item, bool setting)
	{
		GtkMenuItemExterns.gtk_menu_item_set_use_underline(menu_item, setting);
		return menu_item;
	}

	public static GtkMenuItemHandle ToggleSizeAllocate(this GtkMenuItemHandle menu_item, int allocation)
	{
		GtkMenuItemExterns.gtk_menu_item_toggle_size_allocate(menu_item, allocation);
		return menu_item;
	}

	public static GtkMenuItemHandle ToggleSizeRequest(this GtkMenuItemHandle menu_item, ref int requisition)
	{
		GtkMenuItemExterns.gtk_menu_item_toggle_size_request(menu_item, ref requisition);
		return menu_item;
	}

}

internal class GtkMenuItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuItemHandle gtk_menu_item_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuItemHandle gtk_menu_item_new_with_label(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuItemHandle gtk_menu_item_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_activate(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_deselect(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_item_get_accel_path(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_item_get_label(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_item_get_reserve_indicator(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_item_get_right_justified(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_item_get_submenu(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_item_get_use_underline(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_select(GtkMenuItemHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_set_accel_path(GtkMenuItemHandle menu_item, string accel_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_set_label(GtkMenuItemHandle menu_item, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_set_reserve_indicator(GtkMenuItemHandle menu_item, bool reserve);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_set_right_justified(GtkMenuItemHandle menu_item, bool right_justified);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_set_submenu(GtkMenuItemHandle menu_item, GtkWidgetHandle submenu);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_set_use_underline(GtkMenuItemHandle menu_item, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_toggle_size_allocate(GtkMenuItemHandle menu_item, int allocation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_item_toggle_size_request(GtkMenuItemHandle menu_item, ref int requisition);

}
