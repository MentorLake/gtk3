namespace MentorLake.Gtk;


public class GtkListBoxAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkListBoxAccessiblePrivateExtensions
{

	public static GtkListBoxAccessiblePrivate Dereference(this GtkListBoxAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListBoxAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkListBoxAccessiblePrivateExterns
{
}


public struct GtkListBoxAccessiblePrivate
{
}
