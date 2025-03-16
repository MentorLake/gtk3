namespace MentorLake.Gtk;

public class GtkShortcutsSectionClassHandle : BaseSafeHandle
{
}


public static class GtkShortcutsSectionClassExtensions
{

	public static GtkShortcutsSectionClass Dereference(this GtkShortcutsSectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkShortcutsSectionClass>(x.DangerousGetHandle());
}
internal class GtkShortcutsSectionClassExterns
{
}

public struct GtkShortcutsSectionClass
{
}
