namespace MentorLake.Gtk;

public class GtkSocketAccessibleHandle : GtkContainerAccessibleHandle, AtkComponentHandle
{
}

public static class GtkSocketAccessibleHandleExtensions
{
	public static T Embed<T>(this T socket, string path) where T : GtkSocketAccessibleHandle
	{
		GtkSocketAccessibleHandleExterns.gtk_socket_accessible_embed(socket, path);
		return socket;
	}

}

internal class GtkSocketAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_socket_accessible_embed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSocketAccessibleHandle>))] MentorLake.Gtk.GtkSocketAccessibleHandle socket, string path);

}
