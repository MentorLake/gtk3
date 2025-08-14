namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkVSeparator widget is a vertical separator, used to group the
/// widgets within a window. It displays a vertical line with a shadow to
/// make it appear sunken into the interface.
/// </para>
/// <para>
/// GtkVSeparator has been deprecated, use #GtkSeparator instead.
/// </para>
/// </summary>

public class GtkVSeparatorHandle : GtkSeparatorHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkVSeparator.
/// </para>
/// </summary>

/// <return>
/// a new #GtkVSeparator.
/// </return>

	public static MentorLake.Gtk.GtkVSeparatorHandle New()
	{
		return GtkVSeparatorHandleExterns.gtk_vseparator_new();
	}

}

public static class GtkVSeparatorHandleExtensions
{
}

internal class GtkVSeparatorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVSeparatorHandle>))]
	internal static extern MentorLake.Gtk.GtkVSeparatorHandle gtk_vseparator_new();

}
