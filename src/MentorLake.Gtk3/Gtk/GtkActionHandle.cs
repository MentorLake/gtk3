namespace MentorLake.Gtk;

public class GtkActionHandle : GObjectHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkActionHandleExterns.gtk_action_new(name, label, tooltip, stock_id);
	}

}
public static class GtkActionHandleSignalExtensions
{

	public static IObservable<GtkActionHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkActionHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkActionHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkActionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkActionHandleSignalStructs.ActivateSignal()
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
}

public static class GtkActionHandleSignalStructs
{

public struct ActivateSignal
{
	public MentorLake.Gtk.GtkActionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkActionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle self, IntPtr user_data);

}


public static class GtkActionHandleExtensions
{
	public static T Activate<T>(this T action) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_activate(action);
		return action;
	}

	public static T BlockActivate<T>(this T action) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_block_activate(action);
		return action;
	}

	public static T ConnectAccelerator<T>(this T action) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_connect_accelerator(action);
		return action;
	}

	public static MentorLake.Gtk.GtkWidgetHandle CreateIcon(this MentorLake.Gtk.GtkActionHandle action, MentorLake.Gtk.GtkIconSize icon_size)
	{
		return GtkActionHandleExterns.gtk_action_create_icon(action, icon_size);
	}

	public static MentorLake.Gtk.GtkWidgetHandle CreateMenu(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_create_menu(action);
	}

	public static MentorLake.Gtk.GtkWidgetHandle CreateMenuItem(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_create_menu_item(action);
	}

	public static MentorLake.Gtk.GtkWidgetHandle CreateToolItem(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_create_tool_item(action);
	}

	public static T DisconnectAccelerator<T>(this T action) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_disconnect_accelerator(action);
		return action;
	}

	public static MentorLake.GObject.GClosureHandle GetAccelClosure(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_accel_closure(action);
	}

	public static string GetAccelPath(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_accel_path(action);
	}

	public static bool GetAlwaysShowImage(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_always_show_image(action);
	}

	public static MentorLake.Gio.GIconHandle GetGicon(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_gicon(action);
	}

	public static string GetIconName(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_icon_name(action);
	}

	public static bool GetIsImportant(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_is_important(action);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_label(action);
	}

	public static string GetName(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_name(action);
	}

	public static MentorLake.GLib.GSListHandle GetProxies(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_proxies(action);
	}

	public static bool GetSensitive(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_sensitive(action);
	}

	public static string GetShortLabel(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_short_label(action);
	}

	public static string GetStockId(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_stock_id(action);
	}

	public static string GetTooltip(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_tooltip(action);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_visible(action);
	}

	public static bool GetVisibleHorizontal(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_visible_horizontal(action);
	}

	public static bool GetVisibleVertical(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_get_visible_vertical(action);
	}

	public static bool IsSensitive(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_is_sensitive(action);
	}

	public static bool IsVisible(this MentorLake.Gtk.GtkActionHandle action)
	{
		return GtkActionHandleExterns.gtk_action_is_visible(action);
	}

	public static T SetAccelGroup<T>(this T action, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_accel_group(action, accel_group);
		return action;
	}

	public static T SetAccelPath<T>(this T action, string accel_path) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_accel_path(action, accel_path);
		return action;
	}

	public static T SetAlwaysShowImage<T>(this T action, bool always_show) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_always_show_image(action, always_show);
		return action;
	}

	public static T SetGicon<T>(this T action, MentorLake.Gio.GIconHandle icon) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_gicon(action, icon);
		return action;
	}

	public static T SetIconName<T>(this T action, string icon_name) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_icon_name(action, icon_name);
		return action;
	}

	public static T SetIsImportant<T>(this T action, bool is_important) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_is_important(action, is_important);
		return action;
	}

	public static T SetLabel<T>(this T action, string label) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_label(action, label);
		return action;
	}

	public static T SetSensitive<T>(this T action, bool sensitive) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_sensitive(action, sensitive);
		return action;
	}

	public static T SetShortLabel<T>(this T action, string short_label) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_short_label(action, short_label);
		return action;
	}

	public static T SetStockId<T>(this T action, string stock_id) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_stock_id(action, stock_id);
		return action;
	}

	public static T SetTooltip<T>(this T action, string tooltip) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_tooltip(action, tooltip);
		return action;
	}

	public static T SetVisible<T>(this T action, bool visible) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_visible(action, visible);
		return action;
	}

	public static T SetVisibleHorizontal<T>(this T action, bool visible_horizontal) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_visible_horizontal(action, visible_horizontal);
		return action;
	}

	public static T SetVisibleVertical<T>(this T action, bool visible_vertical) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_set_visible_vertical(action, visible_vertical);
		return action;
	}

	public static T UnblockActivate<T>(this T action) where T : GtkActionHandle
	{
		GtkActionHandleExterns.gtk_action_unblock_activate(action);
		return action;
	}

}

internal class GtkActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkActionHandle gtk_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_block_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_connect_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, MentorLake.Gtk.GtkIconSize icon_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_create_tool_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_disconnect_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle gtk_action_get_accel_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_action_get_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_action_get_proxies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_short_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_action_get_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_get_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_is_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_action_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool always_show);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool is_important);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_short_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string short_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, string tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool visible_horizontal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_set_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action, bool visible_vertical);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_unblock_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionHandle>))] MentorLake.Gtk.GtkActionHandle action);

}
