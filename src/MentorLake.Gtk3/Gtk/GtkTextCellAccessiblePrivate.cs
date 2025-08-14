namespace MentorLake.Gtk;


public class GtkTextCellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkTextCellAccessiblePrivateExtensions
{

	public static GtkTextCellAccessiblePrivate Dereference(this GtkTextCellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextCellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkTextCellAccessiblePrivateExterns
{
}


public struct GtkTextCellAccessiblePrivate
{
}
