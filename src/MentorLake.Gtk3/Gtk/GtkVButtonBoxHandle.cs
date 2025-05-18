namespace MentorLake.Gtk;

public class GtkVButtonBoxHandle : GtkButtonBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkVButtonBoxHandle New()
	{
		return GtkVButtonBoxHandleExterns.gtk_vbutton_box_new();
	}

}

public static class GtkVButtonBoxHandleExtensions
{
}

internal class GtkVButtonBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVButtonBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkVButtonBoxHandle gtk_vbutton_box_new();

}
