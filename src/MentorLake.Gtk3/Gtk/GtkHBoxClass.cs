namespace MentorLake.Gtk;


public class GtkHBoxClassHandle : BaseSafeHandle
{
}


public static class GtkHBoxClassExtensions
{

	public static GtkHBoxClass Dereference(this GtkHBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHBoxClass>(x.DangerousGetHandle());
}
internal class GtkHBoxClassExterns
{
}


public struct GtkHBoxClass
{
	
public GtkBoxClass parent_class;
}
