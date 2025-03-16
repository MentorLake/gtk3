namespace MentorLake.Gtk;

public class GtkToolItemHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkToolItemHandle New()
	{
		return GtkToolItemHandleExterns.gtk_tool_item_new();
	}

}
public static class GtkToolItemHandleSignalExtensions
{

	public static IObservable<GtkToolItemHandleSignalStructs.CreateMenuProxySignal> Signal_CreateMenuProxy(this GtkToolItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolItemHandleSignalStructs.CreateMenuProxySignal> obs) =>
		{
			GtkToolItemHandleSignalDelegates.create_menu_proxy handler = ( MentorLake.Gtk.GtkToolItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolItemHandleSignalStructs.CreateMenuProxySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-menu-proxy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkToolItemHandleSignalStructs.ToolbarReconfiguredSignal> Signal_ToolbarReconfigured(this GtkToolItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolItemHandleSignalStructs.ToolbarReconfiguredSignal> obs) =>
		{
			GtkToolItemHandleSignalDelegates.toolbar_reconfigured handler = ( MentorLake.Gtk.GtkToolItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolItemHandleSignalStructs.ToolbarReconfiguredSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toolbar-reconfigured", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkToolItemHandleSignalStructs
{

public struct CreateMenuProxySignal
{
	public MentorLake.Gtk.GtkToolItemHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ToolbarReconfiguredSignal
{
	public MentorLake.Gtk.GtkToolItemHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToolItemHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool create_menu_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toolbar_reconfigured([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle self, IntPtr user_data);

}


public static class GtkToolItemHandleExtensions
{
	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsizeMode(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_ellipsize_mode(tool_item);
	}

	public static bool GetExpand(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_expand(tool_item);
	}

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_homogeneous(tool_item);
	}

	public static MentorLake.Gtk.GtkIconSize GetIconSize(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_icon_size(tool_item);
	}

	public static bool GetIsImportant(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_is_important(tool_item);
	}

	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_orientation(tool_item);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetProxyMenuItem(this MentorLake.Gtk.GtkToolItemHandle tool_item, string menu_item_id)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_proxy_menu_item(tool_item, menu_item_id);
	}

	public static MentorLake.Gtk.GtkReliefStyle GetReliefStyle(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_relief_style(tool_item);
	}

	public static float GetTextAlignment(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_text_alignment(tool_item);
	}

	public static MentorLake.Gtk.GtkOrientation GetTextOrientation(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_text_orientation(tool_item);
	}

	public static MentorLake.Gtk.GtkSizeGroupHandle GetTextSizeGroup(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_text_size_group(tool_item);
	}

	public static MentorLake.Gtk.GtkToolbarStyle GetToolbarStyle(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_toolbar_style(tool_item);
	}

	public static bool GetUseDragWindow(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_use_drag_window(tool_item);
	}

	public static bool GetVisibleHorizontal(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_visible_horizontal(tool_item);
	}

	public static bool GetVisibleVertical(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_get_visible_vertical(tool_item);
	}

	public static T RebuildMenu<T>(this T tool_item) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_rebuild_menu(tool_item);
		return tool_item;
	}

	public static MentorLake.Gtk.GtkWidgetHandle RetrieveProxyMenuItem(this MentorLake.Gtk.GtkToolItemHandle tool_item)
	{
		return GtkToolItemHandleExterns.gtk_tool_item_retrieve_proxy_menu_item(tool_item);
	}

	public static T SetExpand<T>(this T tool_item, bool expand) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_expand(tool_item, expand);
		return tool_item;
	}

	public static T SetHomogeneous<T>(this T tool_item, bool homogeneous) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_homogeneous(tool_item, homogeneous);
		return tool_item;
	}

	public static T SetIsImportant<T>(this T tool_item, bool is_important) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_is_important(tool_item, is_important);
		return tool_item;
	}

	public static T SetProxyMenuItem<T>(this T tool_item, string menu_item_id, MentorLake.Gtk.GtkWidgetHandle menu_item) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_proxy_menu_item(tool_item, menu_item_id, menu_item);
		return tool_item;
	}

	public static T SetTooltipMarkup<T>(this T tool_item, string markup) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_tooltip_markup(tool_item, markup);
		return tool_item;
	}

	public static T SetTooltipText<T>(this T tool_item, string text) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_tooltip_text(tool_item, text);
		return tool_item;
	}

	public static T SetUseDragWindow<T>(this T tool_item, bool use_drag_window) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_use_drag_window(tool_item, use_drag_window);
		return tool_item;
	}

	public static T SetVisibleHorizontal<T>(this T tool_item, bool visible_horizontal) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_visible_horizontal(tool_item, visible_horizontal);
		return tool_item;
	}

	public static T SetVisibleVertical<T>(this T tool_item, bool visible_vertical) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_set_visible_vertical(tool_item, visible_vertical);
		return tool_item;
	}

	public static T ToolbarReconfigured<T>(this T tool_item) where T : GtkToolItemHandle
	{
		GtkToolItemHandleExterns.gtk_tool_item_toolbar_reconfigured(tool_item);
		return tool_item;
	}

}

internal class GtkToolItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolItemHandle gtk_tool_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_tool_item_get_ellipsize_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_tool_item_get_icon_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_tool_item_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_item_get_proxy_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string menu_item_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_tool_item_get_relief_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern float gtk_tool_item_get_text_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_tool_item_get_text_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSizeGroupHandle gtk_tool_item_get_text_size_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToolbarStyle gtk_tool_item_get_toolbar_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_use_drag_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_item_get_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_rebuild_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_item_retrieve_proxy_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_is_important([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool is_important);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_proxy_menu_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string menu_item_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_use_drag_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool use_drag_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_visible_horizontal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool visible_horizontal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_set_visible_vertical([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item, bool visible_vertical);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_item_toolbar_reconfigured([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolItemHandle>))] MentorLake.Gtk.GtkToolItemHandle tool_item);

}
