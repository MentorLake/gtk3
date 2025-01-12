namespace MentorLake.Gtk3.Gtk3;

public class GtkImageMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkImageMenuItemHandle New()
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_new();
	}

	public static GtkImageMenuItemHandle NewFromStock(string stock_id, GtkAccelGroupHandle accel_group)
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_new_from_stock(stock_id, accel_group);
	}

	public static GtkImageMenuItemHandle NewWithLabel(string label)
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_new_with_label(label);
	}

	public static GtkImageMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_new_with_mnemonic(label);
	}

}

public static class GtkImageMenuItemHandleExtensions
{
	public static bool GetAlwaysShowImage(this GtkImageMenuItemHandle image_menu_item)
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_get_always_show_image(image_menu_item);
	}

	public static GtkWidgetHandle GetImage(this GtkImageMenuItemHandle image_menu_item)
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_get_image(image_menu_item);
	}

	public static bool GetUseStock(this GtkImageMenuItemHandle image_menu_item)
	{
		return GtkImageMenuItemExterns.gtk_image_menu_item_get_use_stock(image_menu_item);
	}

	public static GtkImageMenuItemHandle SetAccelGroup(this GtkImageMenuItemHandle image_menu_item, GtkAccelGroupHandle accel_group)
	{
		GtkImageMenuItemExterns.gtk_image_menu_item_set_accel_group(image_menu_item, accel_group);
		return image_menu_item;
	}

	public static GtkImageMenuItemHandle SetAlwaysShowImage(this GtkImageMenuItemHandle image_menu_item, bool always_show)
	{
		GtkImageMenuItemExterns.gtk_image_menu_item_set_always_show_image(image_menu_item, always_show);
		return image_menu_item;
	}

	public static GtkImageMenuItemHandle SetImage(this GtkImageMenuItemHandle image_menu_item, GtkWidgetHandle image)
	{
		GtkImageMenuItemExterns.gtk_image_menu_item_set_image(image_menu_item, image);
		return image_menu_item;
	}

	public static GtkImageMenuItemHandle SetUseStock(this GtkImageMenuItemHandle image_menu_item, bool use_stock)
	{
		GtkImageMenuItemExterns.gtk_image_menu_item_set_use_stock(image_menu_item, use_stock);
		return image_menu_item;
	}

}

internal class GtkImageMenuItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageMenuItemHandle gtk_image_menu_item_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageMenuItemHandle gtk_image_menu_item_new_from_stock(string stock_id, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageMenuItemHandle gtk_image_menu_item_new_with_label(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkImageMenuItemHandle gtk_image_menu_item_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_image_menu_item_get_always_show_image(GtkImageMenuItemHandle image_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_image_menu_item_get_image(GtkImageMenuItemHandle image_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_image_menu_item_get_use_stock(GtkImageMenuItemHandle image_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_menu_item_set_accel_group(GtkImageMenuItemHandle image_menu_item, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_menu_item_set_always_show_image(GtkImageMenuItemHandle image_menu_item, bool always_show);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_menu_item_set_image(GtkImageMenuItemHandle image_menu_item, GtkWidgetHandle image);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_image_menu_item_set_use_stock(GtkImageMenuItemHandle image_menu_item, bool use_stock);

}
