namespace MentorLake.Gtk;

public class GtkComboBoxPrivateHandle : BaseSafeHandle
{
}


public static class GtkComboBoxPrivateExtensions
{

	public static GtkComboBoxPrivate Dereference(this GtkComboBoxPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkComboBoxPrivate>(x.DangerousGetHandle());
}
internal class GtkComboBoxPrivateExterns
{
}

public struct GtkComboBoxPrivate
{
}
