namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkInvisible widget is used internally in GTK+, and is probably not
/// very useful for application developers.
/// </para>
/// <para>
/// It is used for reliable pointer grabs and selection handling in the code
/// for drag-and-drop.
/// </para>
/// </summary>

public class GtkInvisibleHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkInvisible.
/// </para>
/// </summary>

/// <return>
/// a new #GtkInvisible.
/// </return>

	public static MentorLake.Gtk.GtkInvisibleHandle New()
	{
		return GtkInvisibleHandleExterns.gtk_invisible_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkInvisible object for a specified screen
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen which identifies on which
///     the new #GtkInvisible will be created.
/// </param>
/// <return>
/// a newly created #GtkInvisible object
/// </return>

	public static MentorLake.Gtk.GtkInvisibleHandle NewForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkInvisibleHandleExterns.gtk_invisible_new_for_screen(screen);
	}

}

public static class GtkInvisibleHandleExtensions
{
/// <summary>
/// <para>
/// Returns the #GdkScreen object associated with @invisible
/// </para>
/// </summary>

/// <param name="invisible">
/// a #GtkInvisible.
/// </param>
/// <return>
/// the associated #GdkScreen.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkInvisibleHandle invisible)
	{
		if (invisible.IsInvalid) throw new Exception("Invalid handle (GtkInvisibleHandle)");
		return GtkInvisibleHandleExterns.gtk_invisible_get_screen(invisible);
	}

/// <summary>
/// <para>
/// Sets the #GdkScreen where the #GtkInvisible object will be displayed.
/// </para>
/// </summary>

/// <param name="invisible">
/// a #GtkInvisible.
/// </param>
/// <param name="screen">
/// a #GdkScreen.
/// </param>

	public static T SetScreen<T>(this T invisible, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkInvisibleHandle
	{
		if (invisible.IsInvalid) throw new Exception("Invalid handle (GtkInvisibleHandle)");
		GtkInvisibleHandleExterns.gtk_invisible_set_screen(invisible, screen);
		return invisible;
	}

}

internal class GtkInvisibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkInvisibleHandle>))]
	internal static extern MentorLake.Gtk.GtkInvisibleHandle gtk_invisible_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkInvisibleHandle>))]
	internal static extern MentorLake.Gtk.GtkInvisibleHandle gtk_invisible_new_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_invisible_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInvisibleHandle>))] MentorLake.Gtk.GtkInvisibleHandle invisible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_invisible_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInvisibleHandle>))] MentorLake.Gtk.GtkInvisibleHandle invisible, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}
