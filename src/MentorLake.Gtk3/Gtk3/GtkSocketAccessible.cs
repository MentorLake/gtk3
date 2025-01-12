namespace MentorLake.Gtk3.Gtk3;

public class GtkSocketAccessibleHandle : GtkContainerAccessibleHandle, AtkComponentHandle
{
}

public static class GtkSocketAccessibleHandleExtensions
{
	public static GtkSocketAccessibleHandle Embed(this GtkSocketAccessibleHandle socket, string path)
	{
		GtkSocketAccessibleExterns.gtk_socket_accessible_embed(socket, path);
		return socket;
	}

}

internal class GtkSocketAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_socket_accessible_embed(GtkSocketAccessibleHandle socket, string path);

}
