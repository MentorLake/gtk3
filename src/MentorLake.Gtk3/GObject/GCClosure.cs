namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A #GCClosure is a specialization of #GClosure for C function callbacks.
/// </para>
/// </summary>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_object(MentorLake.GObject.GCallback callback_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_object_swap(MentorLake.GObject.GCallback callback_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_cclosure_new_swap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data);

}

/// <summary>
/// <para>
/// A #GCClosure is a specialization of #GClosure for C function callbacks.
/// </para>
/// </summary>

public struct GCClosure
{
	/// <summary>
/// <para>
/// the #GClosure
/// </para>
/// </summary>

public GClosure closure;
	/// <summary>
/// <para>
/// the callback function
/// </para>
/// </summary>

public IntPtr callback;
/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with handlers that
/// take two boxed pointers as arguments and return a boolean.  If you
/// have such a signal, you will probably also need to use an
/// accumulator, such as g_signal_accumulator_true_handled().
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalBooleanBoxedBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_BOOLEAN__BOXED_BOXED().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalBooleanBoxedBoxeDv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with handlers that
/// take a flags type as an argument and return a boolean.  If you have
/// such a signal, you will probably also need to use an accumulator,
/// such as g_signal_accumulator_true_handled().
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalBooleanFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_BOOLEAN__FLAGS().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalBooleanFlagSv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with handlers that
/// take a #GObject and a pointer and produce a string.  It is highly
/// unlikely that your signal handler fits this description.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalStringObjectPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_STRING__OBJECT_POINTER().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalStringObjectPointeRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// boolean argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidBoolean(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOOLEAN(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__BOOLEAN().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidBooleaNv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOOLEANv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument which is any boxed pointer type.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidBoxed(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__BOXED().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidBoxeDv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// character argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidChar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__CHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__CHAR().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidChaRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__CHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with one
/// double-precision floating point argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidDouble(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__DOUBLE(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__DOUBLE().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidDoublEv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__DOUBLEv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument with an enumerated type.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidEnum(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ENUM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__ENUM().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidEnuMv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ENUMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument with a flags types.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidFlags(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__FLAGS().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidFlagSv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with one
/// single-precision floating point argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidFloat(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLOAT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__FLOAT().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidFloaTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__FLOATv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidInt(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__INT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__INT().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidInTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__INTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with with a single
/// long integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidLong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__LONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__LONG().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidLonGv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__LONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// #GObject argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidObject(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__OBJECT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__OBJECT().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidObjecTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__OBJECTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// argument of type #GParamSpec.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidParam(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__PARAM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__PARAM().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidParaMv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__PARAMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single raw
/// pointer argument type.
/// </para>
/// <para>
/// If it is possible, it is better to use one of the more specific
/// functions such as g_cclosure_marshal_VOID__OBJECT() or
/// g_cclosure_marshal_VOID__OBJECT().
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__POINTER().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidPointeRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single string
/// argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidString(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__STRING(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__STRING().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidStrinGv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__STRINGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// unsigned character argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidUchar(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UCHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__UCHAR().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidUchaRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UCHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with with a single
/// unsigned integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidUint(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with an unsigned int
/// and a pointer as arguments.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidUintPointer(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__UINT_POINTER().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidUintPointeRv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__UINT().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidUinTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__UINTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// unsigned long integer argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidUlong(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ULONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__ULONG().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidUlonGv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__ULONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with a single
/// #GVariant argument.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidVariant(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VARIANT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__VARIANT().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidVarianTv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VARIANTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A #GClosureMarshal function for use with signals with no arguments.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_value">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalVoidVoid(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VOID(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// The #GVaClosureMarshal equivalent to g_cclosure_marshal_VOID__VOID().
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

	public static void MarshalVoidVoiDv(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_VOID__VOIDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// A generic marshaller function implemented via
/// [libffi](http://sourceware.org/libffi/).
/// </para>
/// <para>
/// Normally this function is not passed explicitly to g_signal_new(),
/// but used automatically by GLib when specifying a %NULL marshaller.
/// </para>
/// </summary>

/// <param name="closure">
/// A #GClosure.
/// </param>
/// <param name="return_gvalue">
/// A #GValue to store the return value. May be %NULL
///   if the callback of closure doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// The length of the @param_values array.
/// </param>
/// <param name="param_values">
/// An array of #GValues holding the arguments
///   on which to invoke the callback of closure.
/// </param>
/// <param name="invocation_hint">
/// The invocation hint given as the last argument to
///   g_closure_invoke().
/// </param>
/// <param name="marshal_data">
/// Additional data specified when registering the
///   marshaller, see g_closure_set_marshal() and
///   g_closure_set_meta_marshal()
/// </param>

	public static void MarshalGeneric(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_gvalue, uint n_param_values, MentorLake.GObject.GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GCClosureExterns.g_cclosure_marshal_generic(closure, return_gvalue, n_param_values, param_values, invocation_hint, marshal_data);
	}

/// <summary>
/// <para>
/// A generic #GVaClosureMarshal function implemented via
/// [libffi](http://sourceware.org/libffi/).
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is
///  invoked.
/// </param>
/// <param name="args_list">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args_list.
/// </param>

	public static void MarshalGenericVa(MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GValueHandle return_value, MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args_list, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types)
	{
		GCClosureExterns.g_cclosure_marshal_generic_va(closure, return_value, instance, args_list, marshal_data, n_params, param_types);
	}

/// <summary>
/// <para>
/// Creates a new closure which invokes @callback_func with @user_data as
/// the last parameter.
/// </para>
/// <para>
/// @destroy_data will be called as a finalize notifier on the #GClosure.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="user_data">
/// user data to pass to @callback_func
/// </param>
/// <param name="destroy_data">
/// destroy notify to be called when @user_data is no longer used
/// </param>
/// <return>
/// a floating reference to a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle New(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GCClosureExterns.g_cclosure_new(callback_func, user_data, destroy_data);
	}

/// <summary>
/// <para>
/// A variant of g_cclosure_new() which uses @object as @user_data and
/// calls g_object_watch_closure() on @object and the created
/// closure. This function is useful when you have a callback closely
/// associated with a #GObject, and want the callback to no longer run
/// after the object is is freed.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="@object">
/// a #GObject pointer to pass to @callback_func
/// </param>
/// <return>
/// a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle NewObject(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GCClosureExterns.g_cclosure_new_object(callback_func, @object);
	}

/// <summary>
/// <para>
/// A variant of g_cclosure_new_swap() which uses @object as @user_data
/// and calls g_object_watch_closure() on @object and the created
/// closure. This function is useful when you have a callback closely
/// associated with a #GObject, and want the callback to no longer run
/// after the object is is freed.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="@object">
/// a #GObject pointer to pass to @callback_func
/// </param>
/// <return>
/// a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle NewObjectSwap(MentorLake.GObject.GCallback callback_func, MentorLake.GObject.GObjectHandle @object)
	{
		return GCClosureExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

/// <summary>
/// <para>
/// Creates a new closure which invokes @callback_func with @user_data as
/// the first parameter.
/// </para>
/// <para>
/// @destroy_data will be called as a finalize notifier on the #GClosure.
/// </para>
/// </summary>

/// <param name="callback_func">
/// the function to invoke
/// </param>
/// <param name="user_data">
/// user data to pass to @callback_func
/// </param>
/// <param name="destroy_data">
/// destroy notify to be called when @user_data is no longer used
/// </param>
/// <return>
/// a floating reference to a new #GCClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle NewSwap(MentorLake.GObject.GCallback callback_func, IntPtr user_data, MentorLake.GObject.GClosureNotify destroy_data)
	{
		return GCClosureExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

}
