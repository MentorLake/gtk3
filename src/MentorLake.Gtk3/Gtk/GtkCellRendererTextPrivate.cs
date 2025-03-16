namespace MentorLake.Gtk;

public class GtkCellRendererTextPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererTextPrivateExtensions
{

	public static GtkCellRendererTextPrivate Dereference(this GtkCellRendererTextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererTextPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererTextPrivateExterns
{
}

public struct GtkCellRendererTextPrivate
{
}
