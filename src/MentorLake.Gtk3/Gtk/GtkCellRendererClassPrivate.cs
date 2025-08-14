namespace MentorLake.Gtk;


public class GtkCellRendererClassPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererClassPrivateExtensions
{

	public static GtkCellRendererClassPrivate Dereference(this GtkCellRendererClassPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererClassPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererClassPrivateExterns
{
}


public struct GtkCellRendererClassPrivate
{
}
