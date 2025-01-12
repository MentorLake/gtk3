namespace MentorLake.Gtk3.Gtk3;

public class GtkActionHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkActionExterns.gtk_action_new(name, label, tooltip, stock_id);
	}

}

public static class GtkActionSignalExtensions
{

	public static IObservable<GtkActionSignalStructs.ActivateSignal> Signal_Activate(this GtkActionHandle instance)
	{
		return Observable.Create((IObserver<GtkActionSignalStructs.ActivateSignal> obs) =>
		{
			GtkActionSignalDelegates.activate handler = (GtkActionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionSignalStructs.ActivateSignal()
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
}

public static class GtkActionSignalStructs
{

public struct ActivateSignal
{
	public GtkActionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkActionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkActionHandle>))] GtkActionHandle self, IntPtr user_data);

}


public static class GtkActionHandleExtensions
{
	public static GtkActionHandle Activate(this GtkActionHandle action)
	{
		GtkActionExterns.gtk_action_activate(action);
		return action;
	}

	public static GtkActionHandle BlockActivate(this GtkActionHandle action)
	{
		GtkActionExterns.gtk_action_block_activate(action);
		return action;
	}

	public static GtkActionHandle ConnectAccelerator(this GtkActionHandle action)
	{
		GtkActionExterns.gtk_action_connect_accelerator(action);
		return action;
	}

	public static GtkWidgetHandle CreateIcon(this GtkActionHandle action, GtkIconSize icon_size)
	{
		return GtkActionExterns.gtk_action_create_icon(action, icon_size);
	}

	public static GtkWidgetHandle CreateMenu(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_create_menu(action);
	}

	public static GtkWidgetHandle CreateMenuItem(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_create_menu_item(action);
	}

	public static GtkWidgetHandle CreateToolItem(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_create_tool_item(action);
	}

	public static GtkActionHandle DisconnectAccelerator(this GtkActionHandle action)
	{
		GtkActionExterns.gtk_action_disconnect_accelerator(action);
		return action;
	}

	public static GClosureHandle GetAccelClosure(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_accel_closure(action);
	}

	public static string GetAccelPath(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_accel_path(action);
	}

	public static bool GetAlwaysShowImage(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_always_show_image(action);
	}

	public static GIconHandle GetGicon(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_gicon(action);
	}

	public static string GetIconName(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_icon_name(action);
	}

	public static bool GetIsImportant(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_is_important(action);
	}

	public static string GetLabel(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_label(action);
	}

	public static string GetName(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_name(action);
	}

	public static GSListHandle GetProxies(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_proxies(action);
	}

	public static bool GetSensitive(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_sensitive(action);
	}

	public static string GetShortLabel(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_short_label(action);
	}

	public static string GetStockId(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_stock_id(action);
	}

	public static string GetTooltip(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_tooltip(action);
	}

	public static bool GetVisible(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_visible(action);
	}

	public static bool GetVisibleHorizontal(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_visible_horizontal(action);
	}

	public static bool GetVisibleVertical(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_get_visible_vertical(action);
	}

	public static bool IsSensitive(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_is_sensitive(action);
	}

	public static bool IsVisible(this GtkActionHandle action)
	{
		return GtkActionExterns.gtk_action_is_visible(action);
	}

	public static GtkActionHandle SetAccelGroup(this GtkActionHandle action, GtkAccelGroupHandle accel_group)
	{
		GtkActionExterns.gtk_action_set_accel_group(action, accel_group);
		return action;
	}

	public static GtkActionHandle SetAccelPath(this GtkActionHandle action, string accel_path)
	{
		GtkActionExterns.gtk_action_set_accel_path(action, accel_path);
		return action;
	}

	public static GtkActionHandle SetAlwaysShowImage(this GtkActionHandle action, bool always_show)
	{
		GtkActionExterns.gtk_action_set_always_show_image(action, always_show);
		return action;
	}

	public static GtkActionHandle SetGicon(this GtkActionHandle action, GIconHandle icon)
	{
		GtkActionExterns.gtk_action_set_gicon(action, icon);
		return action;
	}

	public static GtkActionHandle SetIconName(this GtkActionHandle action, string icon_name)
	{
		GtkActionExterns.gtk_action_set_icon_name(action, icon_name);
		return action;
	}

	public static GtkActionHandle SetIsImportant(this GtkActionHandle action, bool is_important)
	{
		GtkActionExterns.gtk_action_set_is_important(action, is_important);
		return action;
	}

	public static GtkActionHandle SetLabel(this GtkActionHandle action, string label)
	{
		GtkActionExterns.gtk_action_set_label(action, label);
		return action;
	}

	public static GtkActionHandle SetSensitive(this GtkActionHandle action, bool sensitive)
	{
		GtkActionExterns.gtk_action_set_sensitive(action, sensitive);
		return action;
	}

	public static GtkActionHandle SetShortLabel(this GtkActionHandle action, string short_label)
	{
		GtkActionExterns.gtk_action_set_short_label(action, short_label);
		return action;
	}

	public static GtkActionHandle SetStockId(this GtkActionHandle action, string stock_id)
	{
		GtkActionExterns.gtk_action_set_stock_id(action, stock_id);
		return action;
	}

	public static GtkActionHandle SetTooltip(this GtkActionHandle action, string tooltip)
	{
		GtkActionExterns.gtk_action_set_tooltip(action, tooltip);
		return action;
	}

	public static GtkActionHandle SetVisible(this GtkActionHandle action, bool visible)
	{
		GtkActionExterns.gtk_action_set_visible(action, visible);
		return action;
	}

	public static GtkActionHandle SetVisibleHorizontal(this GtkActionHandle action, bool visible_horizontal)
	{
		GtkActionExterns.gtk_action_set_visible_horizontal(action, visible_horizontal);
		return action;
	}

	public static GtkActionHandle SetVisibleVertical(this GtkActionHandle action, bool visible_vertical)
	{
		GtkActionExterns.gtk_action_set_visible_vertical(action, visible_vertical);
		return action;
	}

	public static GtkActionHandle UnblockActivate(this GtkActionHandle action)
	{
		GtkActionExterns.gtk_action_unblock_activate(action);
		return action;
	}

}

internal class GtkActionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkActionHandle gtk_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_activate(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_block_activate(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_connect_accelerator(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_action_create_icon(GtkActionHandle action, GtkIconSize icon_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_action_create_menu(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_action_create_menu_item(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_action_create_tool_item(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_disconnect_accelerator(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GClosureHandle gtk_action_get_accel_closure(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_accel_path(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_get_always_show_image(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GIconHandle gtk_action_get_gicon(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_icon_name(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_get_is_important(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_label(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_name(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_action_get_proxies(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_get_sensitive(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_short_label(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_stock_id(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_tooltip(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_get_visible(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_get_visible_horizontal(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_get_visible_vertical(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_is_sensitive(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_action_is_visible(GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_accel_group(GtkActionHandle action, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_accel_path(GtkActionHandle action, string accel_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_always_show_image(GtkActionHandle action, bool always_show);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_gicon(GtkActionHandle action, GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_icon_name(GtkActionHandle action, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_is_important(GtkActionHandle action, bool is_important);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_label(GtkActionHandle action, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_sensitive(GtkActionHandle action, bool sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_short_label(GtkActionHandle action, string short_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_stock_id(GtkActionHandle action, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_tooltip(GtkActionHandle action, string tooltip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_visible(GtkActionHandle action, bool visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_visible_horizontal(GtkActionHandle action, bool visible_horizontal);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_set_visible_vertical(GtkActionHandle action, bool visible_vertical);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_unblock_activate(GtkActionHandle action);

}
