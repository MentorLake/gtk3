namespace MentorLake.Gtk3.Gtk3;

public class GtkMenuShellHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkMenuShellSignalExtensions
{

	public static IObservable<GtkMenuShellSignalStructs.ActivateCurrentSignal> Signal_ActivateCurrent(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.ActivateCurrentSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.activate_current handler = (GtkMenuShellHandle self, bool force_hide, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.ActivateCurrentSignal()
				{
					Self = self, ForceHide = force_hide, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_current", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.CancelSignal> Signal_Cancel(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.CancelSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.cancel handler = (GtkMenuShellHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.CancelSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.CycleFocusSignal> Signal_CycleFocus(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.CycleFocusSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.cycle_focus handler = (GtkMenuShellHandle self, GtkDirectionType direction, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.CycleFocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cycle_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.DeactivateSignal> Signal_Deactivate(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.DeactivateSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.deactivate handler = (GtkMenuShellHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.DeactivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "deactivate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.InsertSignal> Signal_Insert(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.InsertSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.insert handler = (GtkMenuShellHandle self, GtkWidgetHandle child, int position, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.InsertSignal()
				{
					Self = self, Child = child, Position = position, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.MoveCurrentSignal> Signal_MoveCurrent(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.MoveCurrentSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.move_current handler = (GtkMenuShellHandle self, GtkMenuDirectionType direction, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.MoveCurrentSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_current", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.MoveSelectedSignal> Signal_MoveSelected(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.MoveSelectedSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.move_selected handler = (GtkMenuShellHandle self, int distance, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.MoveSelectedSignal()
				{
					Self = self, Distance = distance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkMenuShellSignalStructs.SelectionDoneSignal> Signal_SelectionDone(this GtkMenuShellHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuShellSignalStructs.SelectionDoneSignal> obs) =>
		{
			GtkMenuShellSignalDelegates.selection_done handler = (GtkMenuShellHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellSignalStructs.SelectionDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkMenuShellSignalStructs
{

public struct ActivateCurrentSignal
{
	public GtkMenuShellHandle Self;
	public bool ForceHide;
	public IntPtr UserData;
}

public struct CancelSignal
{
	public GtkMenuShellHandle Self;
	public IntPtr UserData;
}

public struct CycleFocusSignal
{
	public GtkMenuShellHandle Self;
	public GtkDirectionType Direction;
	public IntPtr UserData;
}

public struct DeactivateSignal
{
	public GtkMenuShellHandle Self;
	public IntPtr UserData;
}

public struct InsertSignal
{
	public GtkMenuShellHandle Self;
	public GtkWidgetHandle Child;
	public int Position;
	public IntPtr UserData;
}

public struct MoveCurrentSignal
{
	public GtkMenuShellHandle Self;
	public GtkMenuDirectionType Direction;
	public IntPtr UserData;
}

public struct MoveSelectedSignal
{
	public GtkMenuShellHandle Self;
	public int Distance;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectionDoneSignal
{
	public GtkMenuShellHandle Self;
	public IntPtr UserData;
}
}

public static class GtkMenuShellSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, bool force_hide, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cycle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle child, int position, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, GtkMenuDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, int distance, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuShellHandle>))] GtkMenuShellHandle self, IntPtr user_data);

}


public static class GtkMenuShellHandleExtensions
{
	public static T ActivateItem<T>(this T menu_shell, GtkWidgetHandle menu_item, bool force_deactivate) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_activate_item(menu_shell, menu_item, force_deactivate);
		return menu_shell;
	}

	public static T Append<T>(this T menu_shell, GtkWidgetHandle child) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_append(menu_shell, child);
		return menu_shell;
	}

	public static T BindModel<T>(this T menu_shell, GMenuModelHandle model, string action_namespace, bool with_separators) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_bind_model(menu_shell, model, action_namespace, with_separators);
		return menu_shell;
	}

	public static T Cancel<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_cancel(menu_shell);
		return menu_shell;
	}

	public static T Deactivate<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_deactivate(menu_shell);
		return menu_shell;
	}

	public static T Deselect<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_deselect(menu_shell);
		return menu_shell;
	}

	public static GtkWidgetHandle GetParentShell(this GtkMenuShellHandle menu_shell)
	{
		return GtkMenuShellExterns.gtk_menu_shell_get_parent_shell(menu_shell);
	}

	public static GtkWidgetHandle GetSelectedItem(this GtkMenuShellHandle menu_shell)
	{
		return GtkMenuShellExterns.gtk_menu_shell_get_selected_item(menu_shell);
	}

	public static bool GetTakeFocus(this GtkMenuShellHandle menu_shell)
	{
		return GtkMenuShellExterns.gtk_menu_shell_get_take_focus(menu_shell);
	}

	public static T Insert<T>(this T menu_shell, GtkWidgetHandle child, int position) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_insert(menu_shell, child, position);
		return menu_shell;
	}

	public static T Prepend<T>(this T menu_shell, GtkWidgetHandle child) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_prepend(menu_shell, child);
		return menu_shell;
	}

	public static T SelectFirst<T>(this T menu_shell, bool search_sensitive) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_select_first(menu_shell, search_sensitive);
		return menu_shell;
	}

	public static T SelectItem<T>(this T menu_shell, GtkWidgetHandle menu_item) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_select_item(menu_shell, menu_item);
		return menu_shell;
	}

	public static T SetTakeFocus<T>(this T menu_shell, bool take_focus) where T : GtkMenuShellHandle
	{
		GtkMenuShellExterns.gtk_menu_shell_set_take_focus(menu_shell, take_focus);
		return menu_shell;
	}

}

internal class GtkMenuShellExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_activate_item(GtkMenuShellHandle menu_shell, GtkWidgetHandle menu_item, bool force_deactivate);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_append(GtkMenuShellHandle menu_shell, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_bind_model(GtkMenuShellHandle menu_shell, GMenuModelHandle model, string action_namespace, bool with_separators);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_cancel(GtkMenuShellHandle menu_shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_deactivate(GtkMenuShellHandle menu_shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_deselect(GtkMenuShellHandle menu_shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_shell_get_parent_shell(GtkMenuShellHandle menu_shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_shell_get_selected_item(GtkMenuShellHandle menu_shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_shell_get_take_focus(GtkMenuShellHandle menu_shell);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_insert(GtkMenuShellHandle menu_shell, GtkWidgetHandle child, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_prepend(GtkMenuShellHandle menu_shell, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_select_first(GtkMenuShellHandle menu_shell, bool search_sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_select_item(GtkMenuShellHandle menu_shell, GtkWidgetHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_shell_set_take_focus(GtkMenuShellHandle menu_shell, bool take_focus);

}
