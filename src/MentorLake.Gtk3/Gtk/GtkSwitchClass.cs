namespace MentorLake.Gtk;

public class GtkSwitchClassHandle : BaseSafeHandle
{
}


public static class GtkSwitchClassExtensions
{

	public static GtkSwitchClass Dereference(this GtkSwitchClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSwitchClass>(x.DangerousGetHandle());
}
internal class GtkSwitchClassExterns
{
}

public struct GtkSwitchClass
{
	public GtkWidgetClass parent_class;
	public IntPtr activate;
	public IntPtr state_set;
	public IntPtr _switch_padding_1;
	public IntPtr _switch_padding_2;
	public IntPtr _switch_padding_3;
	public IntPtr _switch_padding_4;
	public IntPtr _switch_padding_5;
}
