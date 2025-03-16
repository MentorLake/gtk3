namespace MentorLake.Gtk;

public class GtkListStorePrivateHandle : BaseSafeHandle
{
}


public static class GtkListStorePrivateExtensions
{

	public static GtkListStorePrivate Dereference(this GtkListStorePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListStorePrivate>(x.DangerousGetHandle());
}
internal class GtkListStorePrivateExterns
{
}

public struct GtkListStorePrivate
{
}
