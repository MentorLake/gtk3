namespace MentorLake.Gtk;

public class GtkWindowAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkWindowAccessibleClassExtensions
{

	public static GtkWindowAccessibleClass Dereference(this GtkWindowAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkWindowAccessibleClassExterns
{
}

public struct GtkWindowAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
