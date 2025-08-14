namespace MentorLake.Gtk;


public class GtkLabelAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkLabelAccessiblePrivateExtensions
{

	public static GtkLabelAccessiblePrivate Dereference(this GtkLabelAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLabelAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkLabelAccessiblePrivateExterns
{
}


public struct GtkLabelAccessiblePrivate
{
}
