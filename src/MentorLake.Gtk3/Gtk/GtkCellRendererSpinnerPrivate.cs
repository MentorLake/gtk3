namespace MentorLake.Gtk;

public class GtkCellRendererSpinnerPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererSpinnerPrivateExtensions
{

	public static GtkCellRendererSpinnerPrivate Dereference(this GtkCellRendererSpinnerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererSpinnerPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererSpinnerPrivateExterns
{
}

public struct GtkCellRendererSpinnerPrivate
{
}
