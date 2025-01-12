namespace MentorLake.Gtk3.Gtk3;

public class GtkMenuButtonHandle : GtkToggleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkMenuButtonHandle New()
	{
		return GtkMenuButtonExterns.gtk_menu_button_new();
	}

}

public static class GtkMenuButtonHandleExtensions
{
	public static GtkWidgetHandle GetAlignWidget(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_align_widget(menu_button);
	}

	public static GtkArrowType GetDirection(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_direction(menu_button);
	}

	public static GMenuModelHandle GetMenuModel(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_menu_model(menu_button);
	}

	public static GtkPopoverHandle GetPopover(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_popover(menu_button);
	}

	public static GtkMenuHandle GetPopup(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_popup(menu_button);
	}

	public static bool GetUsePopover(this GtkMenuButtonHandle menu_button)
	{
		return GtkMenuButtonExterns.gtk_menu_button_get_use_popover(menu_button);
	}

	public static GtkMenuButtonHandle SetAlignWidget(this GtkMenuButtonHandle menu_button, GtkWidgetHandle align_widget)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_align_widget(menu_button, align_widget);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetDirection(this GtkMenuButtonHandle menu_button, GtkArrowType direction)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_direction(menu_button, direction);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetMenuModel(this GtkMenuButtonHandle menu_button, GMenuModelHandle menu_model)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_menu_model(menu_button, menu_model);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetPopover(this GtkMenuButtonHandle menu_button, GtkWidgetHandle popover)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_popover(menu_button, popover);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetPopup(this GtkMenuButtonHandle menu_button, GtkWidgetHandle menu)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_popup(menu_button, menu);
		return menu_button;
	}

	public static GtkMenuButtonHandle SetUsePopover(this GtkMenuButtonHandle menu_button, bool use_popover)
	{
		GtkMenuButtonExterns.gtk_menu_button_set_use_popover(menu_button, use_popover);
		return menu_button;
	}

}

internal class GtkMenuButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuButtonHandle gtk_menu_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_button_get_align_widget(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkArrowType gtk_menu_button_get_direction(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GMenuModelHandle gtk_menu_button_get_menu_model(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPopoverHandle gtk_menu_button_get_popover(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuHandle gtk_menu_button_get_popup(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_menu_button_get_use_popover(GtkMenuButtonHandle menu_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_button_set_align_widget(GtkMenuButtonHandle menu_button, GtkWidgetHandle align_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_button_set_direction(GtkMenuButtonHandle menu_button, GtkArrowType direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_button_set_menu_model(GtkMenuButtonHandle menu_button, GMenuModelHandle menu_model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_button_set_popover(GtkMenuButtonHandle menu_button, GtkWidgetHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_button_set_popup(GtkMenuButtonHandle menu_button, GtkWidgetHandle menu);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_button_set_use_popover(GtkMenuButtonHandle menu_button, bool use_popover);

}
