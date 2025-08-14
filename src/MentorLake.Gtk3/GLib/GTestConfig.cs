namespace MentorLake.GLib;


public class GTestConfigHandle : BaseSafeHandle
{
}


public static class GTestConfigExtensions
{

	public static GTestConfig Dereference(this GTestConfigHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestConfig>(x.DangerousGetHandle());
}
internal class GTestConfigExterns
{
}


public struct GTestConfig
{
	
public bool test_initialized;
	
public bool test_quick;
	
public bool test_perf;
	
public bool test_verbose;
	
public bool test_quiet;
	
public bool test_undefined;
}
