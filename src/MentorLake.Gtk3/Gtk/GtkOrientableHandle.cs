namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkOrientable interface is implemented by all widgets that can be
/// oriented horizontally or vertically. Historically, such widgets have been
/// realized as subclasses of a common base class (e.g #GtkBox/#GtkHBox/#GtkVBox
/// or #GtkScale/#GtkHScale/#GtkVScale). #GtkOrientable is more flexible in that
/// it allows the orientation to be changed at runtime, allowing the widgets
/// to “flip”.
/// </para>
/// <para>
/// #GtkOrientable was introduced in GTK+ 2.16.
/// </para>
/// </summary>

public interface GtkOrientableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkOrientableHandleImpl : BaseSafeHandle, GtkOrientableHandle
{
}

public static class GtkOrientableHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the orientation of the @orientable.
/// </para>
/// </summary>

/// <param name="orientable">
/// a #GtkOrientable
/// </param>
/// <return>
/// the orientation of the @orientable.
/// </return>

	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkOrientableHandle orientable)
	{
		if (orientable.IsInvalid) throw new Exception("Invalid handle (GtkOrientableHandle)");
		return GtkOrientableHandleExterns.gtk_orientable_get_orientation(orientable);
	}

/// <summary>
/// <para>
/// Sets the orientation of the @orientable.
/// </para>
/// </summary>

/// <param name="orientable">
/// a #GtkOrientable
/// </param>
/// <param name="orientation">
/// the orientable’s new orientation.
/// </param>

	public static T SetOrientation<T>(this T orientable, MentorLake.Gtk.GtkOrientation orientation) where T : GtkOrientableHandle
	{
		if (orientable.IsInvalid) throw new Exception("Invalid handle (GtkOrientableHandle)");
		GtkOrientableHandleExterns.gtk_orientable_set_orientation(orientable, orientation);
		return orientable;
	}

}

internal class GtkOrientableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkOrientation gtk_orientable_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOrientableHandleImpl>))] MentorLake.Gtk.GtkOrientableHandle orientable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_orientable_set_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOrientableHandleImpl>))] MentorLake.Gtk.GtkOrientableHandle orientable, MentorLake.Gtk.GtkOrientation orientation);

}
