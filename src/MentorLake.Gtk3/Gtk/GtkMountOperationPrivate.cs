namespace MentorLake.Gtk;


public class GtkMountOperationPrivateHandle : BaseSafeHandle
{
}


public static class GtkMountOperationPrivateExtensions
{

	public static GtkMountOperationPrivate Dereference(this GtkMountOperationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMountOperationPrivate>(x.DangerousGetHandle());
}
internal class GtkMountOperationPrivateExterns
{
}


public struct GtkMountOperationPrivate
{
}
