namespace MentorLake.Gtk;

public class GtkToplevelAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkToplevelAccessibleClassExtensions
{

	public static GtkToplevelAccessibleClass Dereference(this GtkToplevelAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToplevelAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkToplevelAccessibleClassExterns
{
}

public struct GtkToplevelAccessibleClass
{
	public AtkObjectClass parent_class;
}
