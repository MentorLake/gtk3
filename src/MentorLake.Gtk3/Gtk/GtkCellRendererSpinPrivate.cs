namespace MentorLake.Gtk;


public class GtkCellRendererSpinPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererSpinPrivateExtensions
{

	public static GtkCellRendererSpinPrivate Dereference(this GtkCellRendererSpinPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererSpinPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererSpinPrivateExterns
{
}


public struct GtkCellRendererSpinPrivate
{
}
