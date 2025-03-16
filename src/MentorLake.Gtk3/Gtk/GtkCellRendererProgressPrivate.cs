namespace MentorLake.Gtk;

public class GtkCellRendererProgressPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererProgressPrivateExtensions
{

	public static GtkCellRendererProgressPrivate Dereference(this GtkCellRendererProgressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererProgressPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererProgressPrivateExterns
{
}

public struct GtkCellRendererProgressPrivate
{
}
