namespace MentorLake.Gtk;

public class GtkMenuButtonHandle : GtkToggleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkMenuButtonHandle New()
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_new();
	}

}

public static class GtkMenuButtonHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetAlignWidget(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_align_widget(menu_button);
	}

	public static MentorLake.Gtk.GtkArrowType GetDirection(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_direction(menu_button);
	}

	public static MentorLake.Gio.GMenuModelHandle GetMenuModel(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_menu_model(menu_button);
	}

	public static MentorLake.Gtk.GtkPopoverHandle GetPopover(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_popover(menu_button);
	}

	public static MentorLake.Gtk.GtkMenuHandle GetPopup(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_popup(menu_button);
	}

	public static bool GetUsePopover(this MentorLake.Gtk.GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonHandleExterns.gtk_menu_button_get_use_popover(menu_button);
	}

	public static T SetAlignWidget<T>(this T menu_button, MentorLake.Gtk.GtkWidgetHandle align_widget) where T : GtkMenuButtonHandle
	{
		GtkMenuButtonHandleExterns.gtk_menu_button_set_align_widget(menu_button, align_widget);
		return menu_button;
	}

	public static T SetDirection<T>(this T menu_button, MentorLake.Gtk.GtkArrowType direction) where T : GtkMenuButtonHandle
	{
		GtkMenuButtonHandleExterns.gtk_menu_button_set_direction(menu_button, direction);
		return menu_button;
	}

	public static T SetMenuModel<T>(this T menu_button, MentorLake.Gio.GMenuModelHandle menu_model) where T : GtkMenuButtonHandle
	{
		GtkMenuButtonHandleExterns.gtk_menu_button_set_menu_model(menu_button, menu_model);
		return menu_button;
	}

	public static T SetPopover<T>(this T menu_button, MentorLake.Gtk.GtkWidgetHandle popover) where T : GtkMenuButtonHandle
	{
		GtkMenuButtonHandleExterns.gtk_menu_button_set_popover(menu_button, popover);
		return menu_button;
	}

	public static T SetPopup<T>(this T menu_button, MentorLake.Gtk.GtkWidgetHandle menu) where T : GtkMenuButtonHandle
	{
		GtkMenuButtonHandleExterns.gtk_menu_button_set_popup(menu_button, menu);
		return menu_button;
	}

	public static T SetUsePopover<T>(this T menu_button, bool use_popover) where T : GtkMenuButtonHandle
	{
		GtkMenuButtonHandleExterns.gtk_menu_button_set_use_popover(menu_button, use_popover);
		return menu_button;
	}

}

internal class GtkMenuButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuButtonHandle gtk_menu_button_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_button_get_align_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkArrowType gtk_menu_button_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuModelHandle gtk_menu_button_get_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPopoverHandle gtk_menu_button_get_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuHandle gtk_menu_button_get_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_button_get_use_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_align_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle align_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, MentorLake.Gtk.GtkArrowType direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle menu_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_button_set_use_popover([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuButtonHandle>))] MentorLake.Gtk.GtkMenuButtonHandle menu_button, bool use_popover);

}
