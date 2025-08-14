namespace MentorLake.Gtk;


public class GtkAssistantPrivateHandle : BaseSafeHandle
{
}


public static class GtkAssistantPrivateExtensions
{

	public static GtkAssistantPrivate Dereference(this GtkAssistantPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAssistantPrivate>(x.DangerousGetHandle());
}
internal class GtkAssistantPrivateExterns
{
}


public struct GtkAssistantPrivate
{
}
