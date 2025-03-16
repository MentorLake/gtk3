namespace MentorLake.Gtk;

public class GtkPlacesSidebarClassHandle : BaseSafeHandle
{
}


public static class GtkPlacesSidebarClassExtensions
{

	public static GtkPlacesSidebarClass Dereference(this GtkPlacesSidebarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPlacesSidebarClass>(x.DangerousGetHandle());
}
internal class GtkPlacesSidebarClassExterns
{
}

public struct GtkPlacesSidebarClass
{
}
