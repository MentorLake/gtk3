namespace MentorLake.Gtk;


public class GtkInvisiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkInvisiblePrivateExtensions
{

	public static GtkInvisiblePrivate Dereference(this GtkInvisiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkInvisiblePrivate>(x.DangerousGetHandle());
}
internal class GtkInvisiblePrivateExterns
{
}


public struct GtkInvisiblePrivate
{
}
