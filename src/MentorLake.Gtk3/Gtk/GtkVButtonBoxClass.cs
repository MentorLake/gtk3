namespace MentorLake.Gtk;


public class GtkVButtonBoxClassHandle : BaseSafeHandle
{
}


public static class GtkVButtonBoxClassExtensions
{

	public static GtkVButtonBoxClass Dereference(this GtkVButtonBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVButtonBoxClass>(x.DangerousGetHandle());
}
internal class GtkVButtonBoxClassExterns
{
}


public struct GtkVButtonBoxClass
{
	
public GtkButtonBoxClass parent_class;
}
