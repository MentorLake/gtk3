namespace MentorLake.Gtk;

public class GtkMenuShellHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}
public static class GtkMenuShellHandleSignalExtensions
{

	public static IObservable<GtkMenuShellHandleSignalStructs.ActivateCurrentSignal> Signal_ActivateCurrent(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.ActivateCurrentSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.activate_current handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  bool force_hide,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.ActivateCurrentSignal()
				{
					Self = self, ForceHide = force_hide, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-current", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.CancelSignal> Signal_Cancel(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.CancelSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.cancel handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.CancelSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.CycleFocusSignal> Signal_CycleFocus(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.CycleFocusSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.cycle_focus handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.CycleFocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cycle-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.DeactivateSignal> Signal_Deactivate(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.DeactivateSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.deactivate handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.DeactivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deactivate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.InsertSignal> Signal_Insert(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.InsertSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.insert handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  int position,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.InsertSignal()
				{
					Self = self, Child = child, Position = position, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.MoveCurrentSignal> Signal_MoveCurrent(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.MoveCurrentSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.move_current handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  MentorLake.Gtk.GtkMenuDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.MoveCurrentSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-current", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.MoveSelectedSignal> Signal_MoveSelected(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.MoveSelectedSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.move_selected handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  int distance,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.MoveSelectedSignal()
				{
					Self = self, Distance = distance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuShellHandleSignalStructs.SelectionDoneSignal> Signal_SelectionDone(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.SelectionDoneSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.selection_done handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.SelectionDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuShellHandleSignalStructs
{

public struct ActivateCurrentSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public bool ForceHide;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public IntPtr UserData;
}

public struct CycleFocusSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public MentorLake.Gtk.GtkDirectionType Direction;
	public IntPtr UserData;
}

public struct DeactivateSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public IntPtr UserData;
}

public struct InsertSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Child;
	public int Position;
	public IntPtr UserData;
}

public struct MoveCurrentSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public MentorLake.Gtk.GtkMenuDirectionType Direction;
	public IntPtr UserData;
}

public struct MoveSelectedSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public int Distance;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectionDoneSignal
{
	public MentorLake.Gtk.GtkMenuShellHandle Self;
	public IntPtr UserData;
}
}

public static class GtkMenuShellHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, bool force_hide, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cycle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, MentorLake.Gtk.GtkMenuDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, int distance, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, IntPtr user_data);

}


public static class GtkMenuShellHandleExtensions
{
	public static T ActivateItem<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle menu_item, bool force_deactivate) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_activate_item(menu_shell, menu_item, force_deactivate);
		return menu_shell;
	}

	public static T Append<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_append(menu_shell, child);
		return menu_shell;
	}

	public static T BindModel<T>(this T menu_shell, MentorLake.Gio.GMenuModelHandle model, string action_namespace, bool with_separators) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_bind_model(menu_shell, model, action_namespace, with_separators);
		return menu_shell;
	}

	public static T Cancel<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_cancel(menu_shell);
		return menu_shell;
	}

	public static T Deactivate<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_deactivate(menu_shell);
		return menu_shell;
	}

	public static T Deselect<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_deselect(menu_shell);
		return menu_shell;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetParentShell(this MentorLake.Gtk.GtkMenuShellHandle menu_shell)
	{
		return GtkMenuShellHandleExterns.gtk_menu_shell_get_parent_shell(menu_shell);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetSelectedItem(this MentorLake.Gtk.GtkMenuShellHandle menu_shell)
	{
		return GtkMenuShellHandleExterns.gtk_menu_shell_get_selected_item(menu_shell);
	}

	public static bool GetTakeFocus(this MentorLake.Gtk.GtkMenuShellHandle menu_shell)
	{
		return GtkMenuShellHandleExterns.gtk_menu_shell_get_take_focus(menu_shell);
	}

	public static T Insert<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_insert(menu_shell, child, position);
		return menu_shell;
	}

	public static T Prepend<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_prepend(menu_shell, child);
		return menu_shell;
	}

	public static T SelectFirst<T>(this T menu_shell, bool search_sensitive) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_select_first(menu_shell, search_sensitive);
		return menu_shell;
	}

	public static T SelectItem<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle menu_item) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_select_item(menu_shell, menu_item);
		return menu_shell;
	}

	public static T SetTakeFocus<T>(this T menu_shell, bool take_focus) where T : GtkMenuShellHandle
	{
		GtkMenuShellHandleExterns.gtk_menu_shell_set_take_focus(menu_shell, take_focus);
		return menu_shell;
	}

}

internal class GtkMenuShellHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_activate_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_item, bool force_deactivate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, string action_namespace, bool with_separators);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_shell_get_parent_shell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_shell_get_selected_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_shell_get_take_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_select_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, bool search_sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_select_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_set_take_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, bool take_focus);

}
