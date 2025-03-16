namespace MentorLake.Gtk;

public class GtkMenuShellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkMenuShellAccessibleClassExtensions
{

	public static GtkMenuShellAccessibleClass Dereference(this GtkMenuShellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuShellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkMenuShellAccessibleClassExterns
{
}

public struct GtkMenuShellAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
