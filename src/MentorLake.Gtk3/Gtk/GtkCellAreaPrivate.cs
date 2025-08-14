namespace MentorLake.Gtk;


public class GtkCellAreaPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellAreaPrivateExtensions
{

	public static GtkCellAreaPrivate Dereference(this GtkCellAreaPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaPrivate>(x.DangerousGetHandle());
}
internal class GtkCellAreaPrivateExterns
{
}


public struct GtkCellAreaPrivate
{
}
