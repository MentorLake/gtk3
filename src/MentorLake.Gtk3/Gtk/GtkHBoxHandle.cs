namespace MentorLake.Gtk;

public class GtkHBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkHBoxHandle New(bool homogeneous, int spacing)
	{
		return GtkHBoxHandleExterns.gtk_hbox_new(homogeneous, spacing);
	}

}

public static class GtkHBoxHandleExtensions
{
}

internal class GtkHBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkHBoxHandle gtk_hbox_new(bool homogeneous, int spacing);

}
