namespace MentorLake.Gtk;

public class GtkCellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkCellAccessiblePrivateExtensions
{

	public static GtkCellAccessiblePrivate Dereference(this GtkCellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkCellAccessiblePrivateExterns
{
}

public struct GtkCellAccessiblePrivate
{
}
