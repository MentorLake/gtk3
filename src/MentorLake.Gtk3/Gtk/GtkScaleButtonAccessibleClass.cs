namespace MentorLake.Gtk;

public class GtkScaleButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkScaleButtonAccessibleClassExtensions
{

	public static GtkScaleButtonAccessibleClass Dereference(this GtkScaleButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkScaleButtonAccessibleClassExterns
{
}

public struct GtkScaleButtonAccessibleClass
{
	public GtkButtonAccessibleClass parent_class;
}
