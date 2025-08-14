namespace MentorLake.Gtk;


public class GtkIMContextSimplePrivateHandle : BaseSafeHandle
{
}


public static class GtkIMContextSimplePrivateExtensions
{

	public static GtkIMContextSimplePrivate Dereference(this GtkIMContextSimplePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMContextSimplePrivate>(x.DangerousGetHandle());
}
internal class GtkIMContextSimplePrivateExterns
{
}


public struct GtkIMContextSimplePrivate
{
}
