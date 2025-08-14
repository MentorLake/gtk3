namespace MentorLake.Gtk;


public class GtkHButtonBoxClassHandle : BaseSafeHandle
{
}


public static class GtkHButtonBoxClassExtensions
{

	public static GtkHButtonBoxClass Dereference(this GtkHButtonBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHButtonBoxClass>(x.DangerousGetHandle());
}
internal class GtkHButtonBoxClassExterns
{
}


public struct GtkHButtonBoxClass
{
	
public GtkButtonBoxClass parent_class;
}
