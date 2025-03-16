namespace MentorLake.Gtk;

public class GtkMenuItemAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuItemAccessiblePrivateExtensions
{

	public static GtkMenuItemAccessiblePrivate Dereference(this GtkMenuItemAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuItemAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkMenuItemAccessiblePrivateExterns
{
}

public struct GtkMenuItemAccessiblePrivate
{
}
