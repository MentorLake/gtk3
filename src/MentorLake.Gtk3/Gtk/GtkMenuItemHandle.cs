namespace MentorLake.Gtk;

public class GtkMenuItemHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkMenuItemHandle New()
	{
		return GtkMenuItemHandleExterns.gtk_menu_item_new();
	}

	public static MentorLake.Gtk.GtkMenuItemHandle NewWithLabel(string label)
	{
		return GtkMenuItemHandleExterns.gtk_menu_item_new_with_label(label);
	}

	public static MentorLake.Gtk.GtkMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkMenuItemHandleExterns.gtk_menu_item_new_with_mnemonic(label);
	}

}
public static class GtkMenuItemHandleSignalExtensions
{

	public static IObservable<GtkMenuItemHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.ActivateItemSignal> Signal_ActivateItem(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ActivateItemSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.activate_item handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ActivateItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.DeselectSignal> Signal_Deselect(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.DeselectSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.deselect handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.DeselectSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deselect", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.SelectSignal> Signal_Select(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.SelectSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.select handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.SelectSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.ToggleSizeAllocateSignal> Signal_ToggleSizeAllocate(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ToggleSizeAllocateSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.toggle_size_allocate handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  int @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ToggleSizeAllocateSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-size-allocate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.ToggleSizeRequestSignal> Signal_ToggleSizeRequest(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ToggleSizeRequestSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.toggle_size_request handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ToggleSizeRequestSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-size-request", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuItemHandleSignalStructs
{

public struct ActivateSignal
{
	public MentorLake.Gtk.GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct ActivateItemSignal
{
	public MentorLake.Gtk.GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct DeselectSignal
{
	public MentorLake.Gtk.GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct SelectSignal
{
	public MentorLake.Gtk.GtkMenuItemHandle Self;
	public IntPtr UserData;
}

public struct ToggleSizeAllocateSignal
{
	public MentorLake.Gtk.GtkMenuItemHandle Self;
	public int Object;
	public IntPtr UserData;
}

public struct ToggleSizeRequestSignal
{
	public MentorLake.Gtk.GtkMenuItemHandle Self;
	public IntPtr Object;
	public IntPtr UserData;
}
}

public static class GtkMenuItemHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, int @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr @object, IntPtr user_data);

}


public static class GtkMenuItemHandleExtensions
{
	public static T Activate<T>(this T menu_item) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_activate(menu_item);
		return menu_item;
	}

	public static T Deselect<T>(this T menu_item) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_deselect(menu_item);
		return menu_item;
	}

	public static string GetAccelPath(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_accel_path(menu_item);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_label(menu_item);
	}

	public static bool GetReserveIndicator(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_reserve_indicator(menu_item);
	}

	public static bool GetRightJustified(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_right_justified(menu_item);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetSubmenu(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_submenu(menu_item);
	}

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_use_underline(menu_item);
	}

	public static T Select<T>(this T menu_item) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_select(menu_item);
		return menu_item;
	}

	public static T SetAccelPath<T>(this T menu_item, string accel_path) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_accel_path(menu_item, accel_path);
		return menu_item;
	}

	public static T SetLabel<T>(this T menu_item, string label) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_label(menu_item, label);
		return menu_item;
	}

	public static T SetReserveIndicator<T>(this T menu_item, bool reserve) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_reserve_indicator(menu_item, reserve);
		return menu_item;
	}

	public static T SetRightJustified<T>(this T menu_item, bool right_justified) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_right_justified(menu_item, right_justified);
		return menu_item;
	}

	public static T SetSubmenu<T>(this T menu_item, MentorLake.Gtk.GtkWidgetHandle submenu) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_submenu(menu_item, submenu);
		return menu_item;
	}

	public static T SetUseUnderline<T>(this T menu_item, bool setting) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_use_underline(menu_item, setting);
		return menu_item;
	}

	public static T ToggleSizeAllocate<T>(this T menu_item, int allocation) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_toggle_size_allocate(menu_item, allocation);
		return menu_item;
	}

	public static T ToggleSizeRequest<T>(this T menu_item, ref int requisition) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid || menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_toggle_size_request(menu_item, ref requisition);
		return menu_item;
	}

}

internal class GtkMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuItemHandle gtk_menu_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuItemHandle gtk_menu_item_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuItemHandle gtk_menu_item_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_item_get_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_item_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_item_get_reserve_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_item_get_right_justified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_item_get_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_item_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_reserve_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, bool reserve);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_right_justified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, bool right_justified);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle submenu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_toggle_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, int allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_toggle_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, ref int requisition);

}
