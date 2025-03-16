namespace MentorLake.Gtk;

public class GtkPanedAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkPanedAccessiblePrivateExtensions
{

	public static GtkPanedAccessiblePrivate Dereference(this GtkPanedAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPanedAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkPanedAccessiblePrivateExterns
{
}

public struct GtkPanedAccessiblePrivate
{
}
