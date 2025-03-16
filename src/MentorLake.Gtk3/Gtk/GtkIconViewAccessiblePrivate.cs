namespace MentorLake.Gtk;

public class GtkIconViewAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkIconViewAccessiblePrivateExtensions
{

	public static GtkIconViewAccessiblePrivate Dereference(this GtkIconViewAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconViewAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkIconViewAccessiblePrivateExterns
{
}

public struct GtkIconViewAccessiblePrivate
{
}
