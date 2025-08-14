namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkSeparator is a horizontal or vertical separator widget, depending on the
/// value of the #GtkOrientable:orientation property, used to group the widgets
/// within a window. It displays a line with a shadow to make it appear sunken
/// into the interface.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkSeparator has a single CSS node with name separator. The node
/// gets one of the .horizontal or .vertical style classes.
/// </para>
/// </summary>

public class GtkSeparatorHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkSeparator with the given orientation.
/// </para>
/// </summary>

/// <param name="orientation">
/// the separator’s orientation.
/// </param>
/// <return>
/// a new #GtkSeparator.
/// </return>

	public static MentorLake.Gtk.GtkSeparatorHandle New(MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkSeparatorHandleExterns.gtk_separator_new(orientation);
	}

}

public static class GtkSeparatorHandleExtensions
{
}

internal class GtkSeparatorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSeparatorHandle>))]
	internal static extern MentorLake.Gtk.GtkSeparatorHandle gtk_separator_new(MentorLake.Gtk.GtkOrientation orientation);

}
