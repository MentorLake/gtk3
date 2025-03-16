namespace MentorLake.Gtk;

public class GtkStyleContextPrivateHandle : BaseSafeHandle
{
}


public static class GtkStyleContextPrivateExtensions
{

	public static GtkStyleContextPrivate Dereference(this GtkStyleContextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStyleContextPrivate>(x.DangerousGetHandle());
}
internal class GtkStyleContextPrivateExterns
{
}

public struct GtkStyleContextPrivate
{
}
