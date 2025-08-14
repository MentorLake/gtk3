namespace MentorLake.Gtk;


public class GtkCellRendererPixbufPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererPixbufPrivateExtensions
{

	public static GtkCellRendererPixbufPrivate Dereference(this GtkCellRendererPixbufPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererPixbufPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererPixbufPrivateExterns
{
}


public struct GtkCellRendererPixbufPrivate
{
}
