namespace MentorLake.Gtk;

public class GtkRadioToolButtonHandle : GtkToggleToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkRadioToolButtonHandle New(MentorLake.GLib.GSListHandle group)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new(group);
	}

	public static MentorLake.Gtk.GtkRadioToolButtonHandle NewFromStock(MentorLake.GLib.GSListHandle group, string stock_id)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new_from_stock(group, stock_id);
	}

	public static MentorLake.Gtk.GtkRadioToolButtonHandle NewFromWidget(MentorLake.Gtk.GtkRadioToolButtonHandle group)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new_from_widget(group);
	}

	public static MentorLake.Gtk.GtkRadioToolButtonHandle NewWithStockFromWidget(MentorLake.Gtk.GtkRadioToolButtonHandle group, string stock_id)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new_with_stock_from_widget(group, stock_id);
	}

}

public static class GtkRadioToolButtonHandleExtensions
{
	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioToolButtonHandle button)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_get_group(button);
	}

	public static T SetGroup<T>(this T button, MentorLake.GLib.GSListHandle group) where T : GtkRadioToolButtonHandle
	{
		GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_set_group(button, group);
		return button;
	}

}

internal class GtkRadioToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new_with_stock_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle group, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_tool_button_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_tool_button_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
