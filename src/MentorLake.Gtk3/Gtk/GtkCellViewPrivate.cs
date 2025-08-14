namespace MentorLake.Gtk;


public class GtkCellViewPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellViewPrivateExtensions
{

	public static GtkCellViewPrivate Dereference(this GtkCellViewPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellViewPrivate>(x.DangerousGetHandle());
}
internal class GtkCellViewPrivateExterns
{
}


public struct GtkCellViewPrivate
{
}
