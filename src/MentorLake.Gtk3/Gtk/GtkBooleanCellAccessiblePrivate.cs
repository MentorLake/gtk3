namespace MentorLake.Gtk;


public class GtkBooleanCellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkBooleanCellAccessiblePrivateExtensions
{

	public static GtkBooleanCellAccessiblePrivate Dereference(this GtkBooleanCellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBooleanCellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkBooleanCellAccessiblePrivateExterns
{
}


public struct GtkBooleanCellAccessiblePrivate
{
}
