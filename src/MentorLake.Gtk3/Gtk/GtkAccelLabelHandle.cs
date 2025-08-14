namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkAccelLabel widget is a subclass of #GtkLabel that also displays an
/// accelerator key on the right of the label text, e.g. “Ctrl+S”.
/// It is commonly used in menus to show the keyboard short-cuts for commands.
/// </para>
/// <para>
/// The accelerator key to display is typically not set explicitly (although it
/// can be, with gtk_accel_label_set_accel()). Instead, the #GtkAccelLabel displays
/// the accelerators which have been added to a particular widget. This widget is
/// set by calling gtk_accel_label_set_accel_widget().
/// </para>
/// <para>
/// For example, a #GtkMenuItem widget may have an accelerator added to emit
/// the “activate” signal when the “Ctrl+S” key combination is pressed.
/// A #GtkAccelLabel is created and added to the #GtkMenuItem, and
/// gtk_accel_label_set_accel_widget() is called with the #GtkMenuItem as the
/// second argument. The #GtkAccelLabel will now display “Ctrl+S” after its label.
/// </para>
/// <para>
/// Note that creating a #GtkMenuItem with gtk_menu_item_new_with_label() (or
/// one of the similar functions for #GtkCheckMenuItem and #GtkRadioMenuItem)
/// automatically adds a #GtkAccelLabel to the #GtkMenuItem and calls
/// gtk_accel_label_set_accel_widget() to set it up for you.
/// </para>
/// <para>
/// A #GtkAccelLabel will only display accelerators which have %GTK_ACCEL_VISIBLE
/// set (see #GtkAccelFlags).
/// A #GtkAccelLabel can display multiple accelerators and even signal names,
/// though it is almost always used to display just one accelerator key.
/// </para>
/// <para>
/// ## Creating a simple menu item with an accelerator key.
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   GtkWidget *window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   GtkWidget *menu = gtk_menu_new ();
///   GtkWidget *save_item;
///   GtkAccelGroup *accel_group;
/// </para>
/// <para>
///   // Create a GtkAccelGroup and add it to the window.
///   accel_group = gtk_accel_group_new ();
///   gtk_window_add_accel_group (GTK_WINDOW (window), accel_group);
/// </para>
/// <para>
///   // Create the menu item using the convenience function.
///   save_item = gtk_menu_item_new_with_label ("Save");
///   gtk_widget_show (save_item);
///   gtk_container_add (GTK_CONTAINER (menu), save_item);
/// </para>
/// <para>
///   // Now add the accelerator to the GtkMenuItem. Note that since we
///   // called gtk_menu_item_new_with_label() to create the GtkMenuItem
///   // the GtkAccelLabel is automatically set up to display the
///   // GtkMenuItem accelerators. We just need to make sure we use
///   // GTK_ACCEL_VISIBLE here.
///   gtk_widget_add_accelerator (save_item, "activate", accel_group,
///                               GDK_KEY_s, GDK_CONTROL_MASK, GTK_ACCEL_VISIBLE);
/// ]|
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// label
/// ╰── accelerator
/// ]|
/// </para>
/// <para>
/// Like #GtkLabel, GtkAccelLabel has a main CSS node with the name label.
/// It adds a subnode with name accelerator.
/// </para>
/// </summary>

public class GtkAccelLabelHandle : GtkLabelHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAccelLabel.
/// </para>
/// </summary>

/// <param name="@string">
/// the label string. Must be non-%NULL.
/// </param>
/// <return>
/// a new #GtkAccelLabel.
/// </return>

	public static MentorLake.Gtk.GtkAccelLabelHandle New(string @string)
	{
		return GtkAccelLabelHandleExterns.gtk_accel_label_new(@string);
	}

}

public static class GtkAccelLabelHandleExtensions
{
/// <summary>
/// <para>
/// Gets the keyval and modifier mask set with
/// gtk_accel_label_set_accel().
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel
/// </param>
/// <param name="accelerator_key">
/// return location for the keyval
/// </param>
/// <param name="accelerator_mods">
/// return location for the modifier mask
/// </param>

	public static T GetAccel<T>(this T accel_label, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_get_accel(accel_label, out accelerator_key, out accelerator_mods);
		return accel_label;
	}

/// <summary>
/// <para>
/// Fetches the widget monitored by this accelerator label. See
/// gtk_accel_label_set_accel_widget().
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel
/// </param>
/// <return>
/// the object monitored by the accelerator label, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetAccelWidget(this MentorLake.Gtk.GtkAccelLabelHandle accel_label)
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		return GtkAccelLabelHandleExterns.gtk_accel_label_get_accel_widget(accel_label);
	}

/// <summary>
/// <para>
/// Returns the width needed to display the accelerator key(s).
/// This is used by menus to align all of the #GtkMenuItem widgets, and shouldn't
/// be needed by applications.
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel.
/// </param>
/// <return>
/// the width needed to display the accelerator key(s).
/// </return>

	public static uint GetAccelWidth(this MentorLake.Gtk.GtkAccelLabelHandle accel_label)
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		return GtkAccelLabelHandleExterns.gtk_accel_label_get_accel_width(accel_label);
	}

/// <summary>
/// <para>
/// Recreates the string representing the accelerator keys.
/// This should not be needed since the string is automatically updated whenever
/// accelerators are added or removed from the associated widget.
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel.
/// </param>
/// <return>
/// always returns %FALSE.
/// </return>

	public static bool Refetch(this MentorLake.Gtk.GtkAccelLabelHandle accel_label)
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		return GtkAccelLabelHandleExterns.gtk_accel_label_refetch(accel_label);
	}

/// <summary>
/// <para>
/// Manually sets a keyval and modifier mask as the accelerator rendered
/// by @accel_label.
/// </para>
/// <para>
/// If a keyval and modifier are explicitly set then these values are
/// used regardless of any associated accel closure or widget.
/// </para>
/// <para>
/// Providing an @accelerator_key of 0 removes the manual setting.
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel
/// </param>
/// <param name="accelerator_key">
/// a keyval, or 0
/// </param>
/// <param name="accelerator_mods">
/// the modifier mask for the accel
/// </param>

	public static T SetAccel<T>(this T accel_label, uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_set_accel(accel_label, accelerator_key, accelerator_mods);
		return accel_label;
	}

/// <summary>
/// <para>
/// Sets the closure to be monitored by this accelerator label. The closure
/// must be connected to an accelerator group; see gtk_accel_group_connect().
/// Passing %NULL for @accel_closure will dissociate @accel_label from its
/// current closure, if any.
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel
/// </param>
/// <param name="accel_closure">
/// the closure to monitor for accelerator changes,
/// or %NULL
/// </param>

	public static T SetAccelClosure<T>(this T accel_label, MentorLake.GObject.GClosureHandle accel_closure) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_set_accel_closure(accel_label, accel_closure);
		return accel_label;
	}

/// <summary>
/// <para>
/// Sets the widget to be monitored by this accelerator label. Passing %NULL for
/// @accel_widget will dissociate @accel_label from its current widget, if any.
/// </para>
/// </summary>

/// <param name="accel_label">
/// a #GtkAccelLabel
/// </param>
/// <param name="accel_widget">
/// the widget to be monitored, or %NULL
/// </param>

	public static T SetAccelWidget<T>(this T accel_label, MentorLake.Gtk.GtkWidgetHandle accel_widget) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid) throw new Exception("Invalid handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_set_accel_widget(accel_label, accel_widget);
		return accel_label;
	}

}

internal class GtkAccelLabelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelLabelHandle gtk_accel_label_new(string @string);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_get_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_accel_label_get_accel_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_accel_label_get_accel_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_label_refetch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_set_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_set_accel_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle accel_closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_set_accel_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle accel_widget);

}
