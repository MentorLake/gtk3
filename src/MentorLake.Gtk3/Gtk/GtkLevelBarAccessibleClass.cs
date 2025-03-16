namespace MentorLake.Gtk;

public class GtkLevelBarAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkLevelBarAccessibleClassExtensions
{

	public static GtkLevelBarAccessibleClass Dereference(this GtkLevelBarAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLevelBarAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkLevelBarAccessibleClassExterns
{
}

public struct GtkLevelBarAccessibleClass
{
	public GtkWidgetAccessibleClass parent_class;
}
