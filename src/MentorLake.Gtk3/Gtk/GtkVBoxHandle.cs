namespace MentorLake.Gtk;

public class GtkVBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkVBoxHandle New(bool homogeneous, int spacing)
	{
		return GtkVBoxHandleExterns.gtk_vbox_new(homogeneous, spacing);
	}

}

public static class GtkVBoxHandleExtensions
{
}

internal class GtkVBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkVBoxHandle gtk_vbox_new(bool homogeneous, int spacing);

}
