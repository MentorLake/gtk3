namespace MentorLake.Gtk;


public class GtkToplevelAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkToplevelAccessiblePrivateExtensions
{

	public static GtkToplevelAccessiblePrivate Dereference(this GtkToplevelAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToplevelAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkToplevelAccessiblePrivateExterns
{
}


public struct GtkToplevelAccessiblePrivate
{
}
