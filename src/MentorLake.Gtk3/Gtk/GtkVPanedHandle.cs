namespace MentorLake.Gtk;

public class GtkVPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkVPanedHandle New()
	{
		return GtkVPanedHandleExterns.gtk_vpaned_new();
	}

}

public static class GtkVPanedHandleExtensions
{
}

internal class GtkVPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVPanedHandle>))]
	internal static extern MentorLake.Gtk.GtkVPanedHandle gtk_vpaned_new();

}
