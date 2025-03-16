namespace MentorLake.Gtk;

public class GtkShortcutLabelClassHandle : BaseSafeHandle
{
}


public static class GtkShortcutLabelClassExtensions
{

	public static GtkShortcutLabelClass Dereference(this GtkShortcutLabelClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkShortcutLabelClass>(x.DangerousGetHandle());
}
internal class GtkShortcutLabelClassExterns
{
}

public struct GtkShortcutLabelClass
{
}
