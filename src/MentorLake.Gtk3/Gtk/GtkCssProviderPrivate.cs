namespace MentorLake.Gtk;


public class GtkCssProviderPrivateHandle : BaseSafeHandle
{
}


public static class GtkCssProviderPrivateExtensions
{

	public static GtkCssProviderPrivate Dereference(this GtkCssProviderPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCssProviderPrivate>(x.DangerousGetHandle());
}
internal class GtkCssProviderPrivateExterns
{
}


public struct GtkCssProviderPrivate
{
}
