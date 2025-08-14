namespace MentorLake.Gtk;


public class GtkToggleButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkToggleButtonAccessibleClassExtensions
{

	public static GtkToggleButtonAccessibleClass Dereference(this GtkToggleButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkToggleButtonAccessibleClassExterns
{
}


public struct GtkToggleButtonAccessibleClass
{
	
public GtkButtonAccessibleClass parent_class;
}
