namespace MentorLake.Gtk3.Gtk3;

public class GtkRadioToolButtonHandle : GtkToggleToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkRadioToolButtonHandle New(GSListHandle group)
	{
		return GtkRadioToolButtonExterns.gtk_radio_tool_button_new(group);
	}

	public static GtkRadioToolButtonHandle NewFromStock(GSListHandle group, string stock_id)
	{
		return GtkRadioToolButtonExterns.gtk_radio_tool_button_new_from_stock(group, stock_id);
	}

	public static GtkRadioToolButtonHandle NewFromWidget(GtkRadioToolButtonHandle group)
	{
		return GtkRadioToolButtonExterns.gtk_radio_tool_button_new_from_widget(group);
	}

	public static GtkRadioToolButtonHandle NewWithStockFromWidget(GtkRadioToolButtonHandle group, string stock_id)
	{
		return GtkRadioToolButtonExterns.gtk_radio_tool_button_new_with_stock_from_widget(group, stock_id);
	}

}

public static class GtkRadioToolButtonHandleExtensions
{
	public static GSListHandle GetGroup(this GtkRadioToolButtonHandle button)
	{
		return GtkRadioToolButtonExterns.gtk_radio_tool_button_get_group(button);
	}

	public static GtkRadioToolButtonHandle SetGroup(this GtkRadioToolButtonHandle button, GSListHandle group)
	{
		GtkRadioToolButtonExterns.gtk_radio_tool_button_set_group(button, group);
		return button;
	}

}

internal class GtkRadioToolButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioToolButtonHandle gtk_radio_tool_button_new(GSListHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioToolButtonHandle gtk_radio_tool_button_new_from_stock(GSListHandle group, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioToolButtonHandle gtk_radio_tool_button_new_from_widget(GtkRadioToolButtonHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioToolButtonHandle gtk_radio_tool_button_new_with_stock_from_widget(GtkRadioToolButtonHandle group, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_radio_tool_button_get_group(GtkRadioToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_tool_button_set_group(GtkRadioToolButtonHandle button, GSListHandle group);

}
