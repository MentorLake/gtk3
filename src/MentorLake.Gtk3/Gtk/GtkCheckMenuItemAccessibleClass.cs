namespace MentorLake.Gtk;

public class GtkCheckMenuItemAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkCheckMenuItemAccessibleClassExtensions
{

	public static GtkCheckMenuItemAccessibleClass Dereference(this GtkCheckMenuItemAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCheckMenuItemAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkCheckMenuItemAccessibleClassExterns
{
}

public struct GtkCheckMenuItemAccessibleClass
{
	public GtkMenuItemAccessibleClass parent_class;
}
