namespace MentorLake.Gtk;


public class GtkBuilderPrivateHandle : BaseSafeHandle
{
}


public static class GtkBuilderPrivateExtensions
{

	public static GtkBuilderPrivate Dereference(this GtkBuilderPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBuilderPrivate>(x.DangerousGetHandle());
}
internal class GtkBuilderPrivateExterns
{
}


public struct GtkBuilderPrivate
{
}
