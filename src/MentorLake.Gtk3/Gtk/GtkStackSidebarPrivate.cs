namespace MentorLake.Gtk;

public class GtkStackSidebarPrivateHandle : BaseSafeHandle
{
}


public static class GtkStackSidebarPrivateExtensions
{

	public static GtkStackSidebarPrivate Dereference(this GtkStackSidebarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStackSidebarPrivate>(x.DangerousGetHandle());
}
internal class GtkStackSidebarPrivateExterns
{
}

public struct GtkStackSidebarPrivate
{
}
