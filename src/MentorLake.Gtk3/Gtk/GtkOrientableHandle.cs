namespace MentorLake.Gtk;

public interface GtkOrientableHandle
{
}

internal class GtkOrientableHandleImpl : BaseSafeHandle, GtkOrientableHandle
{
}

public static class GtkOrientableHandleExtensions
{
	public static MentorLake.Gtk.GtkOrientation GetOrientation(this MentorLake.Gtk.GtkOrientableHandle orientable)
	{
		return GtkOrientableHandleExterns.gtk_orientable_get_orientation(orientable);
	}

	public static T SetOrientation<T>(this T orientable, MentorLake.Gtk.GtkOrientation orientation) where T : GtkOrientableHandle
	{
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
