namespace MentorLake.Gtk;

public class GtkTreeStorePrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeStorePrivateExtensions
{

	public static GtkTreeStorePrivate Dereference(this GtkTreeStorePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeStorePrivate>(x.DangerousGetHandle());
}
internal class GtkTreeStorePrivateExterns
{
}

public struct GtkTreeStorePrivate
{
}
