namespace MentorLake.Gtk;


public class GtkEntryAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkEntryAccessiblePrivateExtensions
{

	public static GtkEntryAccessiblePrivate Dereference(this GtkEntryAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkEntryAccessiblePrivateExterns
{
}


public struct GtkEntryAccessiblePrivate
{
}
