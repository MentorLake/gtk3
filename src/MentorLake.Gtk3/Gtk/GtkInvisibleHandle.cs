namespace MentorLake.Gtk;

public class GtkInvisibleHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkInvisibleHandle New()
	{
		return GtkInvisibleHandleExterns.gtk_invisible_new();
	}

	public static MentorLake.Gtk.GtkInvisibleHandle NewForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkInvisibleHandleExterns.gtk_invisible_new_for_screen(screen);
	}

}

public static class GtkInvisibleHandleExtensions
{
	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkInvisibleHandle invisible)
	{
		if (invisible.IsInvalid) throw new Exception("Invalid handle (GtkInvisibleHandle)");
		return GtkInvisibleHandleExterns.gtk_invisible_get_screen(invisible);
	}

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
