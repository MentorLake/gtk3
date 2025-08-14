namespace MentorLake.Gtk;


public class GtkStylePropertiesPrivateHandle : BaseSafeHandle
{
}


public static class GtkStylePropertiesPrivateExtensions
{

	public static GtkStylePropertiesPrivate Dereference(this GtkStylePropertiesPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStylePropertiesPrivate>(x.DangerousGetHandle());
}
internal class GtkStylePropertiesPrivateExterns
{
}


public struct GtkStylePropertiesPrivate
{
}
