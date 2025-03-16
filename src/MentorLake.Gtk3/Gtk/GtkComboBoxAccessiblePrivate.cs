namespace MentorLake.Gtk;

public class GtkComboBoxAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkComboBoxAccessiblePrivateExtensions
{

	public static GtkComboBoxAccessiblePrivate Dereference(this GtkComboBoxAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkComboBoxAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkComboBoxAccessiblePrivateExterns
{
}

public struct GtkComboBoxAccessiblePrivate
{
}
