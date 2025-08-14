namespace MentorLake.Gtk;


public class GtkVSeparatorClassHandle : BaseSafeHandle
{
}


public static class GtkVSeparatorClassExtensions
{

	public static GtkVSeparatorClass Dereference(this GtkVSeparatorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVSeparatorClass>(x.DangerousGetHandle());
}
internal class GtkVSeparatorClassExterns
{
}


public struct GtkVSeparatorClass
{
	
public GtkSeparatorClass parent_class;
}
