namespace MentorLake.Gtk;

public class GtkIconFactoryPrivateHandle : BaseSafeHandle
{
}


public static class GtkIconFactoryPrivateExtensions
{

	public static GtkIconFactoryPrivate Dereference(this GtkIconFactoryPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconFactoryPrivate>(x.DangerousGetHandle());
}
internal class GtkIconFactoryPrivateExterns
{
}

public struct GtkIconFactoryPrivate
{
}
