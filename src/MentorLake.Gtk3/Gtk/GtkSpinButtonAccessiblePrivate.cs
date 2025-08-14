namespace MentorLake.Gtk;


public class GtkSpinButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkSpinButtonAccessiblePrivateExtensions
{

	public static GtkSpinButtonAccessiblePrivate Dereference(this GtkSpinButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkSpinButtonAccessiblePrivateExterns
{
}


public struct GtkSpinButtonAccessiblePrivate
{
}
