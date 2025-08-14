namespace MentorLake.Gtk;


public class GtkContainerPrivateHandle : BaseSafeHandle
{
}


public static class GtkContainerPrivateExtensions
{

	public static GtkContainerPrivate Dereference(this GtkContainerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerPrivate>(x.DangerousGetHandle());
}
internal class GtkContainerPrivateExterns
{
}


public struct GtkContainerPrivate
{
}
