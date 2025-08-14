namespace MentorLake.Gtk;


public class GtkComboBoxTextPrivateHandle : BaseSafeHandle
{
}


public static class GtkComboBoxTextPrivateExtensions
{

	public static GtkComboBoxTextPrivate Dereference(this GtkComboBoxTextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkComboBoxTextPrivate>(x.DangerousGetHandle());
}
internal class GtkComboBoxTextPrivateExterns
{
}


public struct GtkComboBoxTextPrivate
{
}
