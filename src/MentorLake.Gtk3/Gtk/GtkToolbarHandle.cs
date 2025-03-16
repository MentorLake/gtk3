namespace MentorLake.Gtk;

public class GtkToolbarHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkToolShellHandle
{
	public static MentorLake.Gtk.GtkToolbarHandle New()
	{
		return GtkToolbarHandleExterns.gtk_toolbar_new();
	}

}
public static class GtkToolbarHandleSignalExtensions
{

	public static IObservable<GtkToolbarHandleSignalStructs.FocusHomeOrEndSignal> Signal_FocusHomeOrEnd(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.FocusHomeOrEndSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.focus_home_or_end handler = ( MentorLake.Gtk.GtkToolbarHandle self,  bool focus_home,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.FocusHomeOrEndSignal()
				{
					Self = self, FocusHome = focus_home, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-home-or-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkToolbarHandleSignalStructs.OrientationChangedSignal> Signal_OrientationChanged(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.OrientationChangedSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.orientation_changed handler = ( MentorLake.Gtk.GtkToolbarHandle self,  MentorLake.Gtk.GtkOrientation orientation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.OrientationChangedSignal()
				{
					Self = self, Orientation = orientation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "orientation-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkToolbarHandleSignalStructs.PopupContextMenuSignal> Signal_PopupContextMenu(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.PopupContextMenuSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.popup_context_menu handler = ( MentorLake.Gtk.GtkToolbarHandle self,  int x,  int y,  int button,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.PopupContextMenuSignal()
				{
					Self = self, X = x, Y = y, Button = button, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup-context-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkToolbarHandleSignalStructs.StyleChangedSignal> Signal_StyleChanged(this GtkToolbarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolbarHandleSignalStructs.StyleChangedSignal> obs) =>
		{
			GtkToolbarHandleSignalDelegates.style_changed handler = ( MentorLake.Gtk.GtkToolbarHandle self,  MentorLake.Gtk.GtkToolbarStyle style,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolbarHandleSignalStructs.StyleChangedSignal()
				{
					Self = self, Style = style, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "style-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkToolbarHandleSignalStructs
{

public struct FocusHomeOrEndSignal
{
	public MentorLake.Gtk.GtkToolbarHandle Self;
	public bool FocusHome;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct OrientationChangedSignal
{
	public MentorLake.Gtk.GtkToolbarHandle Self;
	public MentorLake.Gtk.GtkOrientation Orientation;
	public IntPtr UserData;
}

public struct PopupContextMenuSignal
{
	public MentorLake.Gtk.GtkToolbarHandle Self;
	public int X;
	public int Y;
	public int Button;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct StyleChangedSignal
{
	public MentorLake.Gtk.GtkToolbarHandle Self;
	public MentorLake.Gtk.GtkToolbarStyle Style;
	public IntPtr UserData;
}
}

public static class GtkToolbarHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_home_or_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, bool focus_home, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void orientation_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, MentorLake.Gtk.GtkOrientation orientation, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popup_context_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, int x, int y, int button, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle self, MentorLake.Gtk.GtkToolbarStyle style, IntPtr user_data);

}


public static class GtkToolbarHandleExtensions
{
	public static int GetDropIndex(this MentorLake.Gtk.GtkToolbarHandle toolbar, int x, int y)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_drop_index(toolbar, x, y);
	}

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_icon_size(toolbar);
	}

	public static int GetItemIndex(this MentorLake.Gtk.GtkToolbarHandle toolbar, MentorLake.Gtk.GtkToolItemHandle item)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_item_index(toolbar, item);
	}

	public static int GetNItems(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_n_items(toolbar);
	}

	public static MentorLake.Gtk.GtkToolItemHandle GetNthItem(this MentorLake.Gtk.GtkToolbarHandle toolbar, int n)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_nth_item(toolbar, n);
	}

	public static MentorLake.Gtk.GtkReliefStyle GetReliefStyle(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_relief_style(toolbar);
	}

	public static bool GetShowArrow(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_show_arrow(toolbar);
	}

	public static MentorLake.Gtk.GtkToolbarStyle GetStyle(this MentorLake.Gtk.GtkToolbarHandle toolbar)
	{
		return GtkToolbarHandleExterns.gtk_toolbar_get_style(toolbar);
	}

	public static T Insert<T>(this T toolbar, MentorLake.Gtk.GtkToolItemHandle item, int pos) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_insert(toolbar, item, pos);
		return toolbar;
	}

	public static T SetDropHighlightItem<T>(this T toolbar, MentorLake.Gtk.GtkToolItemHandle tool_item, int index_) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_set_drop_highlight_item(toolbar, tool_item, index_);
		return toolbar;
	}

	public static T SetIconSize<T>(this T toolbar, MentorLake.Gtk.GtkIconSize icon_size) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_set_icon_size(toolbar, icon_size);
		return toolbar;
	}

	public static T SetShowArrow<T>(this T toolbar, bool show_arrow) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_set_show_arrow(toolbar, show_arrow);
		return toolbar;
	}

	public static T SetStyle<T>(this T toolbar, MentorLake.Gtk.GtkToolbarStyle style) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_set_style(toolbar, style);
		return toolbar;
	}

	public static T UnsetIconSize<T>(this T toolbar) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_unset_icon_size(toolbar);
		return toolbar;
	}

	public static T UnsetStyle<T>(this T toolbar) where T : GtkToolbarHandle
	{
		GtkToolbarHandleExterns.gtk_toolbar_unset_style(toolbar);
		return toolbar;
	}

}

internal class GtkToolbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarHandle gtk_toolbar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_toolbar_get_drop_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_toolbar_get_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_toolbar_get_item_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_toolbar_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_toolbar_get_nth_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, int n);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_toolbar_get_relief_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toolbar_get_show_arrow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarStyle gtk_toolbar_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle item, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_drop_highlight_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, MentorLake.Gtk.GtkIconSize icon_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_show_arrow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, bool show_arrow);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar, MentorLake.Gtk.GtkToolbarStyle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_unset_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toolbar_unset_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolbarHandle>))] MentorLake.Gtk.GtkToolbarHandle toolbar);

}
