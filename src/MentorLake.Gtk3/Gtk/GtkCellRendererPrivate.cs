namespace MentorLake.Gtk;

public class GtkCellRendererPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererPrivateExtensions
{

	public static GtkCellRendererPrivate Dereference(this GtkCellRendererPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererPrivateExterns
{
}

public struct GtkCellRendererPrivate
{
}
