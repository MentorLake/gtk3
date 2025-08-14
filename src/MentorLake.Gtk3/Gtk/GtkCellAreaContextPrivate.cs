namespace MentorLake.Gtk;


public class GtkCellAreaContextPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellAreaContextPrivateExtensions
{

	public static GtkCellAreaContextPrivate Dereference(this GtkCellAreaContextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaContextPrivate>(x.DangerousGetHandle());
}
internal class GtkCellAreaContextPrivateExterns
{
}


public struct GtkCellAreaContextPrivate
{
}
