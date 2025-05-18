namespace MentorLake.Gtk;

public class GtkBinHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkBinHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetChild(this MentorLake.Gtk.GtkBinHandle bin)
	{
		if (bin.IsInvalid) throw new Exception("Invalid handle (GtkBinHandle)");
		return GtkBinHandleExterns.gtk_bin_get_child(bin);
	}

}

internal class GtkBinHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_bin_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBinHandle>))] MentorLake.Gtk.GtkBinHandle bin);

}
