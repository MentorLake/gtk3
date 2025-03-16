namespace MentorLake.Gtk;

public class GtkAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkAccessiblePrivateExtensions
{

	public static GtkAccessiblePrivate Dereference(this GtkAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkAccessiblePrivateExterns
{
}

public struct GtkAccessiblePrivate
{
}
