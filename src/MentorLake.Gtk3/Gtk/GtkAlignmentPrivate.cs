namespace MentorLake.Gtk;


public class GtkAlignmentPrivateHandle : BaseSafeHandle
{
}


public static class GtkAlignmentPrivateExtensions
{

	public static GtkAlignmentPrivate Dereference(this GtkAlignmentPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAlignmentPrivate>(x.DangerousGetHandle());
}
internal class GtkAlignmentPrivateExterns
{
}


public struct GtkAlignmentPrivate
{
}
