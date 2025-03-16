namespace MentorLake.Gtk;

public class GtkGestureLongPressClassHandle : BaseSafeHandle
{
}


public static class GtkGestureLongPressClassExtensions
{

	public static GtkGestureLongPressClass Dereference(this GtkGestureLongPressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGestureLongPressClass>(x.DangerousGetHandle());
}
internal class GtkGestureLongPressClassExterns
{
}

public struct GtkGestureLongPressClass
{
}
