namespace MentorLake.Gtk;

public class GtkPlugAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkPlugAccessiblePrivateExtensions
{

	public static GtkPlugAccessiblePrivate Dereference(this GtkPlugAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPlugAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkPlugAccessiblePrivateExterns
{
}

public struct GtkPlugAccessiblePrivate
{
}
