namespace MentorLake.Gtk;


public class GtkMenuItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuItemPrivateExtensions
{

	public static GtkMenuItemPrivate Dereference(this GtkMenuItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuItemPrivate>(x.DangerousGetHandle());
}
internal class GtkMenuItemPrivateExterns
{
}


public struct GtkMenuItemPrivate
{
}
