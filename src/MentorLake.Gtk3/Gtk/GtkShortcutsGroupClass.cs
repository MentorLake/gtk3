namespace MentorLake.Gtk;


public class GtkShortcutsGroupClassHandle : BaseSafeHandle
{
}


public static class GtkShortcutsGroupClassExtensions
{

	public static GtkShortcutsGroupClass Dereference(this GtkShortcutsGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkShortcutsGroupClass>(x.DangerousGetHandle());
}
internal class GtkShortcutsGroupClassExterns
{
}


public struct GtkShortcutsGroupClass
{
}
