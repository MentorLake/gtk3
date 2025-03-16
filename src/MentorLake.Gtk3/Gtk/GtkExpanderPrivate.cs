namespace MentorLake.Gtk;

public class GtkExpanderPrivateHandle : BaseSafeHandle
{
}


public static class GtkExpanderPrivateExtensions
{

	public static GtkExpanderPrivate Dereference(this GtkExpanderPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkExpanderPrivate>(x.DangerousGetHandle());
}
internal class GtkExpanderPrivateExterns
{
}

public struct GtkExpanderPrivate
{
}
