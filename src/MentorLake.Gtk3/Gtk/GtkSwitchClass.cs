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
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkWidgetClass parent_class;
	/// <summary>
/// <para>
/// An action signal and emitting it causes the switch to animate.
/// </para>
/// </summary>

public IntPtr activate;
	/// <summary>
/// <para>
/// Class handler for the ::state-set signal.
/// </para>
/// </summary>

public IntPtr state_set;
	
public IntPtr _switch_padding_1;
	
public IntPtr _switch_padding_2;
	
public IntPtr _switch_padding_3;
	
public IntPtr _switch_padding_4;
	
public IntPtr _switch_padding_5;
}
