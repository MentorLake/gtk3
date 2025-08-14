namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkActionBar is designed to present contextual actions. It is
/// expected to be displayed below the content and expand horizontally
/// to fill the area.
/// </para>
/// <para>
/// It allows placing children at the start or the end. In addition, it
/// contains an internal centered box which is centered with respect to
/// the full width of the box, even if the children at either side take
/// up different amounts of space.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkActionBar has a single CSS node with name actionbar.
/// </para>
/// </summary>

public class GtkActionBarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkActionBar widget.
/// </para>
/// </summary>

/// <return>
/// a new #GtkActionBar
/// </return>

	public static MentorLake.Gtk.GtkActionBarHandle New()
	{
		return GtkActionBarHandleExterns.gtk_action_bar_new();
	}

}

public static class GtkActionBarHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the center bar widget of the bar.
/// </para>
/// </summary>

/// <param name="action_bar">
/// a #GtkActionBar
/// </param>
/// <return>
/// the center #GtkWidget or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetCenterWidget(this MentorLake.Gtk.GtkActionBarHandle action_bar)
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		return GtkActionBarHandleExterns.gtk_action_bar_get_center_widget(action_bar);
	}

/// <summary>
/// <para>
/// Adds @child to @action_bar, packed with reference to the
/// end of the @action_bar.
/// </para>
/// </summary>

/// <param name="action_bar">
/// A #GtkActionBar
/// </param>
/// <param name="child">
/// the #GtkWidget to be added to @action_bar
/// </param>

	public static T PackEnd<T>(this T action_bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkActionBarHandle
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		GtkActionBarHandleExterns.gtk_action_bar_pack_end(action_bar, child);
		return action_bar;
	}

/// <summary>
/// <para>
/// Adds @child to @action_bar, packed with reference to the
/// start of the @action_bar.
/// </para>
/// </summary>

/// <param name="action_bar">
/// A #GtkActionBar
/// </param>
/// <param name="child">
/// the #GtkWidget to be added to @action_bar
/// </param>

	public static T PackStart<T>(this T action_bar, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkActionBarHandle
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		GtkActionBarHandleExterns.gtk_action_bar_pack_start(action_bar, child);
		return action_bar;
	}

/// <summary>
/// <para>
/// Sets the center widget for the #GtkActionBar.
/// </para>
/// </summary>

/// <param name="action_bar">
/// a #GtkActionBar
/// </param>
/// <param name="center_widget">
/// a widget to use for the center
/// </param>

	public static T SetCenterWidget<T>(this T action_bar, MentorLake.Gtk.GtkWidgetHandle center_widget) where T : GtkActionBarHandle
	{
		if (action_bar.IsInvalid) throw new Exception("Invalid handle (GtkActionBarHandle)");
		GtkActionBarHandleExterns.gtk_action_bar_set_center_widget(action_bar, center_widget);
		return action_bar;
	}

}

internal class GtkActionBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))]
	internal static extern MentorLake.Gtk.GtkActionBarHandle gtk_action_bar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_action_bar_get_center_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_bar_pack_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_bar_pack_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_action_bar_set_center_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkActionBarHandle>))] MentorLake.Gtk.GtkActionBarHandle action_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle center_widget);

}
