namespace MentorLake.Gtk;

public class GtkImageMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkImageMenuItemHandle New()
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new();
	}

	public static MentorLake.Gtk.GtkImageMenuItemHandle NewFromStock(string stock_id, MentorLake.Gtk.GtkAccelGroupHandle accel_group)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new_from_stock(stock_id, accel_group);
	}

	public static MentorLake.Gtk.GtkImageMenuItemHandle NewWithLabel(string label)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new_with_label(label);
	}

	public static MentorLake.Gtk.GtkImageMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_new_with_mnemonic(label);
	}

}

public static class GtkImageMenuItemHandleExtensions
{
	public static bool GetAlwaysShowImage(this MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_get_always_show_image(image_menu_item);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetImage(this MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_get_image(image_menu_item);
	}

	public static bool GetUseStock(this MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item)
	{
		return GtkImageMenuItemHandleExterns.gtk_image_menu_item_get_use_stock(image_menu_item);
	}

	public static T SetAccelGroup<T>(this T image_menu_item, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkImageMenuItemHandle
	{
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_accel_group(image_menu_item, accel_group);
		return image_menu_item;
	}

	public static T SetAlwaysShowImage<T>(this T image_menu_item, bool always_show) where T : GtkImageMenuItemHandle
	{
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_always_show_image(image_menu_item, always_show);
		return image_menu_item;
	}

	public static T SetImage<T>(this T image_menu_item, MentorLake.Gtk.GtkWidgetHandle image) where T : GtkImageMenuItemHandle
	{
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_image(image_menu_item, image);
		return image_menu_item;
	}

	public static T SetUseStock<T>(this T image_menu_item, bool use_stock) where T : GtkImageMenuItemHandle
	{
		GtkImageMenuItemHandleExterns.gtk_image_menu_item_set_use_stock(image_menu_item, use_stock);
		return image_menu_item;
	}

}

internal class GtkImageMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new_from_stock(string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkImageMenuItemHandle gtk_image_menu_item_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_image_menu_item_get_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_image_menu_item_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_image_menu_item_get_use_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_accel_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, bool always_show);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_image_menu_item_set_use_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkImageMenuItemHandle>))] MentorLake.Gtk.GtkImageMenuItemHandle image_menu_item, bool use_stock);

}
