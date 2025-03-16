namespace MentorLake.Gtk;

public class GtkSpinButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkSpinButtonAccessibleClassExtensions
{

	public static GtkSpinButtonAccessibleClass Dereference(this GtkSpinButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkSpinButtonAccessibleClassExterns
{
}

public struct GtkSpinButtonAccessibleClass
{
	public GtkEntryAccessibleClass parent_class;
}
