namespace MentorLake.Gtk;


public class GtkCellRendererTogglePrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererTogglePrivateExtensions
{

	public static GtkCellRendererTogglePrivate Dereference(this GtkCellRendererTogglePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererTogglePrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererTogglePrivateExterns
{
}


public struct GtkCellRendererTogglePrivate
{
}
