namespace MentorLake.Gtk;

public class GtkTearoffMenuItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkTearoffMenuItemPrivateExtensions
{

	public static GtkTearoffMenuItemPrivate Dereference(this GtkTearoffMenuItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTearoffMenuItemPrivate>(x.DangerousGetHandle());
}
internal class GtkTearoffMenuItemPrivateExterns
{
}

public struct GtkTearoffMenuItemPrivate
{
}
