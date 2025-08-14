namespace MentorLake.Gtk;


public class GtkHSeparatorClassHandle : BaseSafeHandle
{
}


public static class GtkHSeparatorClassExtensions
{

	public static GtkHSeparatorClass Dereference(this GtkHSeparatorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHSeparatorClass>(x.DangerousGetHandle());
}
internal class GtkHSeparatorClassExterns
{
}


public struct GtkHSeparatorClass
{
	
public GtkSeparatorClass parent_class;
}
