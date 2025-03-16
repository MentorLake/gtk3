namespace MentorLake.Gtk;

public class GtkLinkButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkLinkButtonAccessibleClassExtensions
{

	public static GtkLinkButtonAccessibleClass Dereference(this GtkLinkButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLinkButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkLinkButtonAccessibleClassExterns
{
}

public struct GtkLinkButtonAccessibleClass
{
	public GtkButtonAccessibleClass parent_class;
}
