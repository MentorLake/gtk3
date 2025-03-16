namespace MentorLake.Gtk;

public class GtkIMContextSimpleClassHandle : BaseSafeHandle
{
}


public static class GtkIMContextSimpleClassExtensions
{

	public static GtkIMContextSimpleClass Dereference(this GtkIMContextSimpleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMContextSimpleClass>(x.DangerousGetHandle());
}
internal class GtkIMContextSimpleClassExterns
{
}

public struct GtkIMContextSimpleClass
{
	public GtkIMContextClass parent_class;
}
