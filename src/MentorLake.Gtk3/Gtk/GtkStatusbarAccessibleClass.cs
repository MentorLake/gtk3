namespace MentorLake.Gtk;


public class GtkStatusbarAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkStatusbarAccessibleClassExtensions
{

	public static GtkStatusbarAccessibleClass Dereference(this GtkStatusbarAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStatusbarAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkStatusbarAccessibleClassExterns
{
}


public struct GtkStatusbarAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
