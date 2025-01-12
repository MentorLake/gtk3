namespace MentorLake.Gtk3.Gtk3;

public class GtkToolbarHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkToolShellHandle
{
	public static GtkToolbarHandle New()
	{
		return GtkToolbarExterns.gtk_toolbar_new();
	}

}

public static class GtkToolbarSignalExtensions
{

	public static IObservable<GtkToolbarSignalStructs.FocusHomeOrEndSignal> Signal_FocusHomeOrEnd(this GtkToolbarHandle instance)
	{
		return Observable.Create((IObserver<GtkToolbarSignalStructs.FocusHomeOrEndSignal> obs) =>
		{
			GtkToolbarSignalDelegates.focus_home_or_end handler = (GtkToolbarHandle self, bool focus_home, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarSignalStructs.FocusHomeOrEndSignal()
				{
					Self = self, FocusHome = focus_home, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_home_or_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkToolbarSignalStructs.OrientationChangedSignal> Signal_OrientationChanged(this GtkToolbarHandle instance)
	{
		return Observable.Create((IObserver<GtkToolbarSignalStructs.OrientationChangedSignal> obs) =>
		{
			GtkToolbarSignalDelegates.orientation_changed handler = (GtkToolbarHandle self, GtkOrientation orientation, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarSignalStructs.OrientationChangedSignal()
				{
					Self = self, Orientation = orientation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "orientation_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkToolbarSignalStructs.PopupContextMenuSignal> Signal_PopupContextMenu(this GtkToolbarHandle instance)
	{
		return Observable.Create((IObserver<GtkToolbarSignalStructs.PopupContextMenuSignal> obs) =>
		{
			GtkToolbarSignalDelegates.popup_context_menu handler = (GtkToolbarHandle self, int x, int y, int button, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarSignalStructs.PopupContextMenuSignal()
				{
					Self = self, X = x, Y = y, Button = button, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup_context_menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkToolbarSignalStructs.StyleChangedSignal> Signal_StyleChanged(this GtkToolbarHandle instance)
	{
		return Observable.Create((IObserver<GtkToolbarSignalStructs.StyleChangedSignal> obs) =>
		{
			GtkToolbarSignalDelegates.style_changed handler = (GtkToolbarHandle self, ref GtkToolbarStyle style, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarSignalStructs.StyleChangedSignal()
				{
					Self = self, Style = style, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "style_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkToolbarSignalStructs
{

public struct FocusHomeOrEndSignal
{
	public GtkToolbarHandle Self;
	public bool FocusHome;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct OrientationChangedSignal
{
	public GtkToolbarHandle Self;
	public GtkOrientation Orientation;
	public IntPtr UserData;
}

public struct PopupContextMenuSignal
{
	public GtkToolbarHandle Self;
	public int X;
	public int Y;
	public int Button;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct StyleChangedSignal
{
	public GtkToolbarHandle Self;
	public GtkToolbarStyle Style;
	public IntPtr UserData;
}
}

public static class GtkToolbarSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_home_or_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolbarHandle>))] GtkToolbarHandle self, bool focus_home, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void orientation_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolbarHandle>))] GtkToolbarHandle self, GtkOrientation orientation, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popup_context_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolbarHandle>))] GtkToolbarHandle self, int x, int y, int button, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolbarHandle>))] GtkToolbarHandle self, ref GtkToolbarStyle style, IntPtr user_data);

}


public static class GtkToolbarHandleExtensions
{
	public static int GetDropIndex(this GtkToolbarHandle toolbar, int x, int y)
	{
		return GtkToolbarExterns.gtk_toolbar_get_drop_index(toolbar, x, y);
	}

	public static GtkIconSize GetIconSize(this GtkToolbarHandle toolbar)
	{
		return GtkToolbarExterns.gtk_toolbar_get_icon_size(toolbar);
	}

	public static int GetItemIndex(this GtkToolbarHandle toolbar, GtkToolItemHandle item)
	{
		return GtkToolbarExterns.gtk_toolbar_get_item_index(toolbar, item);
	}

	public static int GetNItems(this GtkToolbarHandle toolbar)
	{
		return GtkToolbarExterns.gtk_toolbar_get_n_items(toolbar);
	}

	public static GtkToolItemHandle GetNthItem(this GtkToolbarHandle toolbar, int n)
	{
		return GtkToolbarExterns.gtk_toolbar_get_nth_item(toolbar, n);
	}

	public static GtkReliefStyle GetReliefStyle(this GtkToolbarHandle toolbar)
	{
		return GtkToolbarExterns.gtk_toolbar_get_relief_style(toolbar);
	}

	public static bool GetShowArrow(this GtkToolbarHandle toolbar)
	{
		return GtkToolbarExterns.gtk_toolbar_get_show_arrow(toolbar);
	}

	public static GtkToolbarStyle GetStyle(this GtkToolbarHandle toolbar)
	{
		return GtkToolbarExterns.gtk_toolbar_get_style(toolbar);
	}

	public static GtkToolbarHandle Insert(this GtkToolbarHandle toolbar, GtkToolItemHandle item, int pos)
	{
		GtkToolbarExterns.gtk_toolbar_insert(toolbar, item, pos);
		return toolbar;
	}

	public static GtkToolbarHandle SetDropHighlightItem(this GtkToolbarHandle toolbar, GtkToolItemHandle tool_item, int index_)
	{
		GtkToolbarExterns.gtk_toolbar_set_drop_highlight_item(toolbar, tool_item, index_);
		return toolbar;
	}

	public static GtkToolbarHandle SetIconSize(this GtkToolbarHandle toolbar, GtkIconSize icon_size)
	{
		GtkToolbarExterns.gtk_toolbar_set_icon_size(toolbar, icon_size);
		return toolbar;
	}

	public static GtkToolbarHandle SetShowArrow(this GtkToolbarHandle toolbar, bool show_arrow)
	{
		GtkToolbarExterns.gtk_toolbar_set_show_arrow(toolbar, show_arrow);
		return toolbar;
	}

	public static GtkToolbarHandle SetStyle(this GtkToolbarHandle toolbar, GtkToolbarStyle style)
	{
		GtkToolbarExterns.gtk_toolbar_set_style(toolbar, style);
		return toolbar;
	}

	public static GtkToolbarHandle UnsetIconSize(this GtkToolbarHandle toolbar)
	{
		GtkToolbarExterns.gtk_toolbar_unset_icon_size(toolbar);
		return toolbar;
	}

	public static GtkToolbarHandle UnsetStyle(this GtkToolbarHandle toolbar)
	{
		GtkToolbarExterns.gtk_toolbar_unset_style(toolbar);
		return toolbar;
	}

}

internal class GtkToolbarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolbarHandle gtk_toolbar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_toolbar_get_drop_index(GtkToolbarHandle toolbar, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSize gtk_toolbar_get_icon_size(GtkToolbarHandle toolbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_toolbar_get_item_index(GtkToolbarHandle toolbar, GtkToolItemHandle item);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_toolbar_get_n_items(GtkToolbarHandle toolbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemHandle gtk_toolbar_get_nth_item(GtkToolbarHandle toolbar, int n);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkReliefStyle gtk_toolbar_get_relief_style(GtkToolbarHandle toolbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toolbar_get_show_arrow(GtkToolbarHandle toolbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolbarStyle gtk_toolbar_get_style(GtkToolbarHandle toolbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_insert(GtkToolbarHandle toolbar, GtkToolItemHandle item, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_set_drop_highlight_item(GtkToolbarHandle toolbar, GtkToolItemHandle tool_item, int index_);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_set_icon_size(GtkToolbarHandle toolbar, GtkIconSize icon_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_set_show_arrow(GtkToolbarHandle toolbar, bool show_arrow);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_set_style(GtkToolbarHandle toolbar, GtkToolbarStyle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_unset_icon_size(GtkToolbarHandle toolbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toolbar_unset_style(GtkToolbarHandle toolbar);

}
