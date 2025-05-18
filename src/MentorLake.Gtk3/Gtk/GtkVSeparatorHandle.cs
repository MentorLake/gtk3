namespace MentorLake.Gtk;

public class GtkVSeparatorHandle : GtkSeparatorHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
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
