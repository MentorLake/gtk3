namespace MentorLake.Gtk;

public class GtkRcStyleHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkRcStyleHandle New()
	{
		return GtkRcStyleHandleExterns.gtk_rc_style_new();
	}

}

public static class GtkRcStyleHandleExtensions
{
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
