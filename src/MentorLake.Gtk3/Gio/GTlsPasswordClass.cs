namespace MentorLake.Gio;

public class GTlsPasswordClassHandle : BaseSafeHandle
{
}


public static class GTlsPasswordClassExtensions
{

	public static GTlsPasswordClass Dereference(this GTlsPasswordClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsPasswordClass>(x.DangerousGetHandle());
}
internal class GTlsPasswordClassExterns
{
}

public struct GTlsPasswordClass
{
	public GObjectClass parent_class;
	public IntPtr get_value;
	public IntPtr set_value;
	public IntPtr get_default_warning;
}
