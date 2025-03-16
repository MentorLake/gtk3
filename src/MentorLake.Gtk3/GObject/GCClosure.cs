namespace MentorLake.GObject;

public class GCClosureHandle : BaseSafeHandle
{
}


public static class GCClosureExtensions
{

	public static GCClosure Dereference(this GCClosureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCClosure>(x.DangerousGetHandle());
}
internal class GCClosureExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXED([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_BOOLEAN__FLAGS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_BOOLEAN__FLAGSv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTER([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTERv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__BOOLEAN([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__BOOLEANv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__BOXED([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__BOXEDv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__CHAR([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__CHARv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__DOUBLE([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__DOUBLEv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__ENUM([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__ENUMv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__FLAGS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__FLAGSv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__FLOAT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__FLOATv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__INT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__INTv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__LONG([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__LONGv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__OBJECT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__OBJECTv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__PARAM([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__PARAMv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__POINTER([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__POINTERv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__STRING([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__STRINGv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UCHAR([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UCHARv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UINT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UINT_POINTER([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UINT_POINTERv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__UINTv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__ULONG([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__ULONGv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__VARIANT([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__VARIANTv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__VOID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_VOID__VOIDv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_generic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_gvalue, uint n_param_values, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_cclosure_marshal_generic_va([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args_list, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_object(MentorLake.GObject.GCallback callback_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_object_swap(MentorLake.GObject.GCallback callback_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_swap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data);

}

public struct GCClosure
{
	public GClosure closure;
	public IntPtr callback;
	public static void MarshalBooleanBoxedBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalBooleanBoxedBoxeDv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalBooleanFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalBooleanFlagSv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalStringObjectPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalStringObjectPointeRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidBoolean(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOOLEAN(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidBooleaNv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOOLEANv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidBoxeDv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidChar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__CHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidChaRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__CHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidDouble(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__DOUBLE(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidDoublEv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__DOUBLEv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidEnum(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ENUM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidEnuMv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ENUMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidFlagSv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidFloat(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLOAT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidFloaTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLOATv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidInt(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__INT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidInTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__INTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidLong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__LONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidLonGv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__LONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidObject(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__OBJECT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidObjecTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__OBJECTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidParam(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__PARAM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidParaMv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__PARAMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidPointeRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidString(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__STRING(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidStrinGv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__STRINGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidUchar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UCHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidUchaRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UCHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidUint(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidUintPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidUintPointeRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidUinTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidUlong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ULONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidUlonGv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ULONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidVariant(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VARIANT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidVarianTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VARIANTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalVoidVoid(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VOID(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalVoidVoiDv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VOIDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

	public static void MarshalGeneric(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_gvalue, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_generic(closure, return_gvalue, n_param_values, param_values, invocation_hint, marshal_data);
	}

	public static void MarshalGenericVa(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args_list, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_generic_va(closure, return_value, instance, args_list, marshal_data, n_params, param_types);
	}

	public static MentorLake.GObject.GClosureHandle New(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GCClosureExterns.g_cclosure_new(callback_func, user_data, destroy_data);
	}

	public static MentorLake.GObject.GClosureHandle NewObject(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GCClosureExterns.g_cclosure_new_object(callback_func, @object);
	}

	public static MentorLake.GObject.GClosureHandle NewObjectSwap(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GCClosureExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

	public static MentorLake.GObject.GClosureHandle NewSwap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GCClosureExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

}
