namespace MentorLake.Gio;

public class GApplicationClassHandle : BaseSafeHandle
{
}


public static class GApplicationClassExtensions
{

	public static GApplicationClass Dereference(this GApplicationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GApplicationClass>(x.DangerousGetHandle());
}
internal class GApplicationClassExterns
{
}

public struct GApplicationClass
{
	public IntPtr startup;
	public IntPtr activate;
	public IntPtr open;
	public IntPtr command_line;
	public IntPtr local_command_line;
	public IntPtr before_emit;
	public IntPtr after_emit;
	public IntPtr add_platform_data;
	public IntPtr quit_mainloop;
	public IntPtr run_mainloop;
	public IntPtr shutdown;
	public IntPtr dbus_register;
	public IntPtr dbus_unregister;
	public IntPtr handle_local_options;
	public IntPtr name_lost;
}
