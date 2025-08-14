namespace MentorLake.Gtk;


public class GtkToggleButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkToggleButtonAccessiblePrivateExtensions
{

	public static GtkToggleButtonAccessiblePrivate Dereference(this GtkToggleButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkToggleButtonAccessiblePrivateExterns
{
}


public struct GtkToggleButtonAccessiblePrivate
{
}
