namespace MentorLake.Gtk;

public class GtkMenuPrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuPrivateExtensions
{

	public static GtkMenuPrivate Dereference(this GtkMenuPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuPrivate>(x.DangerousGetHandle());
}
internal class GtkMenuPrivateExterns
{
}

public struct GtkMenuPrivate
{
}
