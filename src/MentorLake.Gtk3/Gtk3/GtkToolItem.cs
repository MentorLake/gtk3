namespace MentorLake.Gtk3.Gtk3;

public class GtkToolItemHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkToolItemHandle New()
	{
		return GtkToolItemExterns.gtk_tool_item_new();
	}

}

public static class GtkToolItemSignalExtensions
{

	public static IObservable<GtkToolItemSignalStructs.CreateMenuProxySignal> Signal_CreateMenuProxy(this GtkToolItemHandle instance)
	{
		return Observable.Create((IObserver<GtkToolItemSignalStructs.CreateMenuProxySignal> obs) =>
		{
			GtkToolItemSignalDelegates.create_menu_proxy handler = (GtkToolItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolItemSignalStructs.CreateMenuProxySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "create_menu_proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkToolItemSignalStructs.ToolbarReconfiguredSignal> Signal_ToolbarReconfigured(this GtkToolItemHandle instance)
	{
		return Observable.Create((IObserver<GtkToolItemSignalStructs.ToolbarReconfiguredSignal> obs) =>
		{
			GtkToolItemSignalDelegates.toolbar_reconfigured handler = (GtkToolItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolItemSignalStructs.ToolbarReconfiguredSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toolbar_reconfigured", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkToolItemSignalStructs
{

public struct CreateMenuProxySignal
{
	public GtkToolItemHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ToolbarReconfiguredSignal
{
	public GtkToolItemHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToolItemSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool create_menu_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolItemHandle>))] GtkToolItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toolbar_reconfigured([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolItemHandle>))] GtkToolItemHandle self, IntPtr user_data);

}


public static class GtkToolItemHandleExtensions
{
	public static PangoEllipsizeMode GetEllipsizeMode(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_ellipsize_mode(tool_item);
	}

	public static bool GetExpand(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_expand(tool_item);
	}

	public static bool GetHomogeneous(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_homogeneous(tool_item);
	}

	public static GtkIconSize GetIconSize(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_icon_size(tool_item);
	}

	public static bool GetIsImportant(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_is_important(tool_item);
	}

	public static GtkOrientation GetOrientation(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_orientation(tool_item);
	}

	public static GtkWidgetHandle GetProxyMenuItem(this GtkToolItemHandle tool_item, string menu_item_id)
	{
		return GtkToolItemExterns.gtk_tool_item_get_proxy_menu_item(tool_item, menu_item_id);
	}

	public static GtkReliefStyle GetReliefStyle(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_relief_style(tool_item);
	}

	public static float GetTextAlignment(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_text_alignment(tool_item);
	}

	public static GtkOrientation GetTextOrientation(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_text_orientation(tool_item);
	}

	public static GtkSizeGroupHandle GetTextSizeGroup(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_text_size_group(tool_item);
	}

	public static GtkToolbarStyle GetToolbarStyle(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_toolbar_style(tool_item);
	}

	public static bool GetUseDragWindow(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_use_drag_window(tool_item);
	}

	public static bool GetVisibleHorizontal(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_visible_horizontal(tool_item);
	}

	public static bool GetVisibleVertical(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_get_visible_vertical(tool_item);
	}

	public static GtkToolItemHandle RebuildMenu(this GtkToolItemHandle tool_item)
	{
		GtkToolItemExterns.gtk_tool_item_rebuild_menu(tool_item);
		return tool_item;
	}

	public static GtkWidgetHandle RetrieveProxyMenuItem(this GtkToolItemHandle tool_item)
	{
		return GtkToolItemExterns.gtk_tool_item_retrieve_proxy_menu_item(tool_item);
	}

	public static GtkToolItemHandle SetExpand(this GtkToolItemHandle tool_item, bool expand)
	{
		GtkToolItemExterns.gtk_tool_item_set_expand(tool_item, expand);
		return tool_item;
	}

	public static GtkToolItemHandle SetHomogeneous(this GtkToolItemHandle tool_item, bool homogeneous)
	{
		GtkToolItemExterns.gtk_tool_item_set_homogeneous(tool_item, homogeneous);
		return tool_item;
	}

	public static GtkToolItemHandle SetIsImportant(this GtkToolItemHandle tool_item, bool is_important)
	{
		GtkToolItemExterns.gtk_tool_item_set_is_important(tool_item, is_important);
		return tool_item;
	}

	public static GtkToolItemHandle SetProxyMenuItem(this GtkToolItemHandle tool_item, string menu_item_id, GtkWidgetHandle menu_item)
	{
		GtkToolItemExterns.gtk_tool_item_set_proxy_menu_item(tool_item, menu_item_id, menu_item);
		return tool_item;
	}

	public static GtkToolItemHandle SetTooltipMarkup(this GtkToolItemHandle tool_item, string markup)
	{
		GtkToolItemExterns.gtk_tool_item_set_tooltip_markup(tool_item, markup);
		return tool_item;
	}

	public static GtkToolItemHandle SetTooltipText(this GtkToolItemHandle tool_item, string text)
	{
		GtkToolItemExterns.gtk_tool_item_set_tooltip_text(tool_item, text);
		return tool_item;
	}

	public static GtkToolItemHandle SetUseDragWindow(this GtkToolItemHandle tool_item, bool use_drag_window)
	{
		GtkToolItemExterns.gtk_tool_item_set_use_drag_window(tool_item, use_drag_window);
		return tool_item;
	}

	public static GtkToolItemHandle SetVisibleHorizontal(this GtkToolItemHandle tool_item, bool visible_horizontal)
	{
		GtkToolItemExterns.gtk_tool_item_set_visible_horizontal(tool_item, visible_horizontal);
		return tool_item;
	}

	public static GtkToolItemHandle SetVisibleVertical(this GtkToolItemHandle tool_item, bool visible_vertical)
	{
		GtkToolItemExterns.gtk_tool_item_set_visible_vertical(tool_item, visible_vertical);
		return tool_item;
	}

	public static GtkToolItemHandle ToolbarReconfigured(this GtkToolItemHandle tool_item)
	{
		GtkToolItemExterns.gtk_tool_item_toolbar_reconfigured(tool_item);
		return tool_item;
	}

}

internal class GtkToolItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolItemHandle gtk_tool_item_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoEllipsizeMode gtk_tool_item_get_ellipsize_mode(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_get_expand(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_get_homogeneous(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconSize gtk_tool_item_get_icon_size(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_get_is_important(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_tool_item_get_orientation(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tool_item_get_proxy_menu_item(GtkToolItemHandle tool_item, string menu_item_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkReliefStyle gtk_tool_item_get_relief_style(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern float gtk_tool_item_get_text_alignment(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_tool_item_get_text_orientation(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeGroupHandle gtk_tool_item_get_text_size_group(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolbarStyle gtk_tool_item_get_toolbar_style(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_get_use_drag_window(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_get_visible_horizontal(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_item_get_visible_vertical(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_rebuild_menu(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tool_item_retrieve_proxy_menu_item(GtkToolItemHandle tool_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_expand(GtkToolItemHandle tool_item, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_homogeneous(GtkToolItemHandle tool_item, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_is_important(GtkToolItemHandle tool_item, bool is_important);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_proxy_menu_item(GtkToolItemHandle tool_item, string menu_item_id, GtkWidgetHandle menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_tooltip_markup(GtkToolItemHandle tool_item, string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_tooltip_text(GtkToolItemHandle tool_item, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_use_drag_window(GtkToolItemHandle tool_item, bool use_drag_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_visible_horizontal(GtkToolItemHandle tool_item, bool visible_horizontal);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_set_visible_vertical(GtkToolItemHandle tool_item, bool visible_vertical);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_item_toolbar_reconfigured(GtkToolItemHandle tool_item);

}
