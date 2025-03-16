namespace MentorLake.Gtk;

public class GtkTextViewAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkTextViewAccessibleClassExtensions
{

	public static GtkTextViewAccessibleClass Dereference(this GtkTextViewAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextViewAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkTextViewAccessibleClassExterns
{
}

public struct GtkTextViewAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
