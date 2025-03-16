namespace MentorLake.Gtk;

public class GtkWindowAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkWindowAccessiblePrivateExtensions
{

	public static GtkWindowAccessiblePrivate Dereference(this GtkWindowAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkWindowAccessiblePrivateExterns
{
}

public struct GtkWindowAccessiblePrivate
{
}
