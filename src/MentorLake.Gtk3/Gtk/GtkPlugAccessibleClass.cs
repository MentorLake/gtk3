namespace MentorLake.Gtk;

public class GtkPlugAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkPlugAccessibleClassExtensions
{

	public static GtkPlugAccessibleClass Dereference(this GtkPlugAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPlugAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkPlugAccessibleClassExterns
{
}

public struct GtkPlugAccessibleClass
{
	public GtkWindowAccessibleClass parent_class;
}
