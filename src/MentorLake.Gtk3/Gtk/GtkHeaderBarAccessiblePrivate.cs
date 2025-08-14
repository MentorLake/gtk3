namespace MentorLake.Gtk;


public class GtkHeaderBarAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkHeaderBarAccessiblePrivateExtensions
{

	public static GtkHeaderBarAccessiblePrivate Dereference(this GtkHeaderBarAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHeaderBarAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkHeaderBarAccessiblePrivateExterns
{
}


public struct GtkHeaderBarAccessiblePrivate
{
}
