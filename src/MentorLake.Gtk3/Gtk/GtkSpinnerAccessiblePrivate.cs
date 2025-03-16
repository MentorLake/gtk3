namespace MentorLake.Gtk;

public class GtkSpinnerAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkSpinnerAccessiblePrivateExtensions
{

	public static GtkSpinnerAccessiblePrivate Dereference(this GtkSpinnerAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinnerAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkSpinnerAccessiblePrivateExterns
{
}

public struct GtkSpinnerAccessiblePrivate
{
}
