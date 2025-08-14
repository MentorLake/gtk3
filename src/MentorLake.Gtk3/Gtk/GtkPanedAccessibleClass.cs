namespace MentorLake.Gtk;


public class GtkPanedAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkPanedAccessibleClassExtensions
{

	public static GtkPanedAccessibleClass Dereference(this GtkPanedAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPanedAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkPanedAccessibleClassExterns
{
}


public struct GtkPanedAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
