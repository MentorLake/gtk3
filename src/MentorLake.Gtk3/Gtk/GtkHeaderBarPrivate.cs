namespace MentorLake.Gtk;

public class GtkHeaderBarPrivateHandle : BaseSafeHandle
{
}


public static class GtkHeaderBarPrivateExtensions
{

	public static GtkHeaderBarPrivate Dereference(this GtkHeaderBarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHeaderBarPrivate>(x.DangerousGetHandle());
}
internal class GtkHeaderBarPrivateExterns
{
}

public struct GtkHeaderBarPrivate
{
}
