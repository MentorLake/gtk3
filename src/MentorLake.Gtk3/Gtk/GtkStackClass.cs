namespace MentorLake.Gtk;


public class GtkStackClassHandle : BaseSafeHandle
{
}


public static class GtkStackClassExtensions
{

	public static GtkStackClass Dereference(this GtkStackClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStackClass>(x.DangerousGetHandle());
}
internal class GtkStackClassExterns
{
}


public struct GtkStackClass
{
	
public GtkContainerClass parent_class;
}
