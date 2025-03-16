namespace MentorLake.Gtk;

public class GtkCheckMenuItemAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkCheckMenuItemAccessiblePrivateExtensions
{

	public static GtkCheckMenuItemAccessiblePrivate Dereference(this GtkCheckMenuItemAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCheckMenuItemAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkCheckMenuItemAccessiblePrivateExterns
{
}

public struct GtkCheckMenuItemAccessiblePrivate
{
}
