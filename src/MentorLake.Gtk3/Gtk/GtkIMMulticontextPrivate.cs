namespace MentorLake.Gtk;


public class GtkIMMulticontextPrivateHandle : BaseSafeHandle
{
}


public static class GtkIMMulticontextPrivateExtensions
{

	public static GtkIMMulticontextPrivate Dereference(this GtkIMMulticontextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMMulticontextPrivate>(x.DangerousGetHandle());
}
internal class GtkIMMulticontextPrivateExterns
{
}


public struct GtkIMMulticontextPrivate
{
}
