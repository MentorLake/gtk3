namespace MentorLake.Gtk;


public class GtkButtonBoxPrivateHandle : BaseSafeHandle
{
}


public static class GtkButtonBoxPrivateExtensions
{

	public static GtkButtonBoxPrivate Dereference(this GtkButtonBoxPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonBoxPrivate>(x.DangerousGetHandle());
}
internal class GtkButtonBoxPrivateExterns
{
}


public struct GtkButtonBoxPrivate
{
}
