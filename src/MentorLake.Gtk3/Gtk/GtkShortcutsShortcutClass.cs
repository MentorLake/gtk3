namespace MentorLake.Gtk;


public class GtkShortcutsShortcutClassHandle : BaseSafeHandle
{
}


public static class GtkShortcutsShortcutClassExtensions
{

	public static GtkShortcutsShortcutClass Dereference(this GtkShortcutsShortcutClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkShortcutsShortcutClass>(x.DangerousGetHandle());
}
internal class GtkShortcutsShortcutClassExterns
{
}


public struct GtkShortcutsShortcutClass
{
}
