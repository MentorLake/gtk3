namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkRcStyle-struct is used to represent a set
/// of information about the appearance of a widget.
/// This can later be composited together with other
/// #GtkRcStyle-struct&amp;lt;!-- --&amp;gt;s to form a #GtkStyle.
/// </para>
/// </summary>

public class GtkRcStyleHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRcStyle with no fields set and
/// a reference count of 1.
/// </para>
/// </summary>

/// <return>
/// the newly-created #GtkRcStyle
/// </return>

	public static MentorLake.Gtk.GtkRcStyleHandle New()
	{
		return GtkRcStyleHandleExterns.gtk_rc_style_new();
	}

}

public static class GtkRcStyleHandleExtensions
{
/// <summary>
/// <para>
/// Makes a copy of the specified #GtkRcStyle. This function
/// will correctly copy an RC style that is a member of a class
/// derived from #GtkRcStyle.
/// </para>
/// </summary>

/// <param name="orig">
/// the style to copy
/// </param>
/// <return>
/// the resulting #GtkRcStyle
/// </return>

	public static MentorLake.Gtk.GtkRcStyleHandle Copy(this MentorLake.Gtk.GtkRcStyleHandle orig)
	{
		if (orig.IsInvalid) throw new Exception("Invalid handle (GtkRcStyleHandle)");
		return GtkRcStyleHandleExterns.gtk_rc_style_copy(orig);
	}

}

internal class GtkRcStyleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkRcStyleHandle gtk_rc_style_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkRcStyleHandle gtk_rc_style_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))] MentorLake.Gtk.GtkRcStyleHandle orig);

}
