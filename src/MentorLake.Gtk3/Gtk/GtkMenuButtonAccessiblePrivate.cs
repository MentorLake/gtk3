namespace MentorLake.Gtk;

public class GtkMenuButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuButtonAccessiblePrivateExtensions
{

	public static GtkMenuButtonAccessiblePrivate Dereference(this GtkMenuButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkMenuButtonAccessiblePrivateExterns
{
}

public struct GtkMenuButtonAccessiblePrivate
{
}
