namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkRadioToolButton is a #GtkToolItem that contains a radio button,
/// that is, a button that is part of a group of toggle buttons where only
/// one button can be active at a time.
/// </para>
/// <para>
/// Use gtk_radio_tool_button_new() to create a new GtkRadioToolButton. Use
/// gtk_radio_tool_button_new_from_widget() to create a new GtkRadioToolButton
/// that is part of the same group as an existing GtkRadioToolButton.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkRadioToolButton has a single CSS node with name toolbutton.
/// </para>
/// </summary>

public class GtkRadioToolButtonHandle : GtkToggleToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRadioToolButton, adding it to @group.
/// </para>
/// </summary>

/// <param name="group">
/// An
///   existing radio button group, or %NULL if you are creating a new group
/// </param>
/// <return>
/// The new #GtkRadioToolButton
/// </return>

	public static MentorLake.Gtk.GtkRadioToolButtonHandle New(MentorLake.GLib.GSListHandle group)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new(group);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioToolButton, adding it to @group.
/// The new #GtkRadioToolButton will contain an icon and label from the
/// stock item indicated by @stock_id.
/// </para>
/// </summary>

/// <param name="group">
/// an existing radio button
///   group, or %NULL if you are creating a new group
/// </param>
/// <param name="stock_id">
/// the name of a stock item
/// </param>
/// <return>
/// The new #GtkRadioToolButton
/// </return>

	public static MentorLake.Gtk.GtkRadioToolButtonHandle NewFromStock(MentorLake.GLib.GSListHandle group, string stock_id)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new_from_stock(group, stock_id);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioToolButton adding it to the same group as @gruup
/// </para>
/// </summary>

/// <param name="group">
/// An existing #GtkRadioToolButton, or %NULL
/// </param>
/// <return>
/// The new #GtkRadioToolButton
/// </return>

	public static MentorLake.Gtk.GtkRadioToolButtonHandle NewFromWidget(MentorLake.Gtk.GtkRadioToolButtonHandle group)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new_from_widget(group);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioToolButton adding it to the same group as @group.
/// The new #GtkRadioToolButton will contain an icon and label from the
/// stock item indicated by @stock_id.
/// </para>
/// </summary>

/// <param name="group">
/// An existing #GtkRadioToolButton.
/// </param>
/// <param name="stock_id">
/// the name of a stock item
/// </param>
/// <return>
/// A new #GtkRadioToolButton
/// </return>

	public static MentorLake.Gtk.GtkRadioToolButtonHandle NewWithStockFromWidget(MentorLake.Gtk.GtkRadioToolButtonHandle group, string stock_id)
	{
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_new_with_stock_from_widget(group, stock_id);
	}

}

public static class GtkRadioToolButtonHandleExtensions
{
/// <summary>
/// <para>
/// Returns the radio button group @button belongs to.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkRadioToolButton
/// </param>
/// <return>
/// The group @button belongs to.
/// </return>

	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkRadioToolButtonHandle)");
		return GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_get_group(button);
	}

/// <summary>
/// <para>
/// Adds @button to @group, removing it from the group it belonged to before.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkRadioToolButton
/// </param>
/// <param name="group">
/// an existing radio button group, or %NULL
/// </param>

	public static T SetGroup<T>(this T button, MentorLake.GLib.GSListHandle group) where T : GtkRadioToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkRadioToolButtonHandle)");
		GtkRadioToolButtonHandleExterns.gtk_radio_tool_button_set_group(button, group);
		return button;
	}

}

internal class GtkRadioToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new_from_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioToolButtonHandle gtk_radio_tool_button_new_with_stock_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle group, string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_tool_button_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_tool_button_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioToolButtonHandle>))] MentorLake.Gtk.GtkRadioToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
