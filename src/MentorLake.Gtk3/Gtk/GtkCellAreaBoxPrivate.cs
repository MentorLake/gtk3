namespace MentorLake.Gtk;


public class GtkCellAreaBoxPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellAreaBoxPrivateExtensions
{

	public static GtkCellAreaBoxPrivate Dereference(this GtkCellAreaBoxPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaBoxPrivate>(x.DangerousGetHandle());
}
internal class GtkCellAreaBoxPrivateExterns
{
}


public struct GtkCellAreaBoxPrivate
{
}
