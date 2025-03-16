namespace MentorLake.Gio;

public class GResolverClassHandle : BaseSafeHandle
{
}


public static class GResolverClassExtensions
{

	public static GResolverClass Dereference(this GResolverClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GResolverClass>(x.DangerousGetHandle());
}
internal class GResolverClassExterns
{
}

public struct GResolverClass
{
	public GObjectClass parent_class;
	public IntPtr reload;
	public IntPtr lookup_by_name;
	public IntPtr lookup_by_name_async;
	public IntPtr lookup_by_name_finish;
	public IntPtr lookup_by_address;
	public IntPtr lookup_by_address_async;
	public IntPtr lookup_by_address_finish;
	public IntPtr lookup_service;
	public IntPtr lookup_service_async;
	public IntPtr lookup_service_finish;
	public IntPtr lookup_records;
	public IntPtr lookup_records_async;
	public IntPtr lookup_records_finish;
	public IntPtr lookup_by_name_with_flags_async;
	public IntPtr lookup_by_name_with_flags_finish;
	public IntPtr lookup_by_name_with_flags;
}
