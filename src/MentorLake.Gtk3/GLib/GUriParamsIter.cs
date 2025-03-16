namespace MentorLake.GLib;

public class GUriParamsIterHandle : BaseSafeHandle
{
}


public static class GUriParamsIterExtensions
{
	public static void Init(this MentorLake.GLib.GUriParamsIterHandle iter, string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags)
	{
		GUriParamsIterExterns.g_uri_params_iter_init(iter, @params, length, separators, flags);
	}

	public static bool Next(this MentorLake.GLib.GUriParamsIterHandle iter, out string attribute, out string value)
	{
		return GUriParamsIterExterns.g_uri_params_iter_next(iter, out attribute, out value);
	}


	public static GUriParamsIter Dereference(this GUriParamsIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUriParamsIter>(x.DangerousGetHandle());
}
internal class GUriParamsIterExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_uri_params_iter_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriParamsIterHandle>))] MentorLake.GLib.GUriParamsIterHandle iter, string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_params_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriParamsIterHandle>))] MentorLake.GLib.GUriParamsIterHandle iter, out string attribute, out string value);

}

public struct GUriParamsIter
{
}
