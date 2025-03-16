namespace MentorLake.Gtk;

public class GtkExpanderAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkExpanderAccessibleClassExtensions
{

	public static GtkExpanderAccessibleClass Dereference(this GtkExpanderAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkExpanderAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkExpanderAccessibleClassExterns
{
}

public struct GtkExpanderAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
