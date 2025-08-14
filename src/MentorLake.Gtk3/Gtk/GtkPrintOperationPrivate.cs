namespace MentorLake.Gtk;


public class GtkPrintOperationPrivateHandle : BaseSafeHandle
{
}


public static class GtkPrintOperationPrivateExtensions
{

	public static GtkPrintOperationPrivate Dereference(this GtkPrintOperationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPrintOperationPrivate>(x.DangerousGetHandle());
}
internal class GtkPrintOperationPrivateExterns
{
}


public struct GtkPrintOperationPrivate
{
}
