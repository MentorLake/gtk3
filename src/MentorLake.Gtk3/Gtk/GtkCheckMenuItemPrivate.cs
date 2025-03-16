namespace MentorLake.Gtk;

public class GtkCheckMenuItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkCheckMenuItemPrivateExtensions
{

	public static GtkCheckMenuItemPrivate Dereference(this GtkCheckMenuItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCheckMenuItemPrivate>(x.DangerousGetHandle());
}
internal class GtkCheckMenuItemPrivateExterns
{
}

public struct GtkCheckMenuItemPrivate
{
}
