namespace MentorLake.Gtk;


public class GtkEntryPrivateHandle : BaseSafeHandle
{
}


public static class GtkEntryPrivateExtensions
{

	public static GtkEntryPrivate Dereference(this GtkEntryPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryPrivate>(x.DangerousGetHandle());
}
internal class GtkEntryPrivateExterns
{
}


public struct GtkEntryPrivate
{
}
