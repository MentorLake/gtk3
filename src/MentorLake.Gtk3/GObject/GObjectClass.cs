namespace MentorLake.GObject;

public class GObjectClassHandle : BaseSafeHandle
{
}


public static class GObjectClassExtensions
{
	public static MentorLake.GObject.GParamSpecHandle FindProperty(this MentorLake.GObject.GObjectClassHandle oclass, string property_name)
	{
		return GObjectClassExterns.g_object_class_find_property(oclass, property_name);
	}

	public static void InstallProperties(this MentorLake.GObject.GObjectClassHandle oclass, uint n_pspecs, MentorLake.GObject.GParamSpecHandle[] pspecs)
	{
		GObjectClassExterns.g_object_class_install_properties(oclass, n_pspecs, pspecs);
	}

	public static void InstallProperty(this MentorLake.GObject.GObjectClassHandle oclass, uint property_id, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GObjectClassExterns.g_object_class_install_property(oclass, property_id, pspec);
	}

	public static MentorLake.GObject.GParamSpecHandle[] ListProperties(this MentorLake.GObject.GObjectClassHandle oclass, out uint n_properties)
	{
		return GObjectClassExterns.g_object_class_list_properties(oclass, out n_properties);
	}

	public static void OverrideProperty(this MentorLake.GObject.GObjectClassHandle oclass, uint property_id, string name)
	{
		GObjectClassExterns.g_object_class_override_property(oclass, property_id, name);
	}


	public static GObjectClass Dereference(this GObjectClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GObjectClass>(x.DangerousGetHandle());
}
internal class GObjectClassExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_object_class_find_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, string property_name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_class_install_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, uint n_pspecs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle[] pspecs);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_class_install_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, uint property_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] g_object_class_list_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, out uint n_properties);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_class_override_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, uint property_id, string name);

}

public struct GObjectClass
{
	public GTypeClass g_type_class;
	public IntPtr constructor;
	public IntPtr set_property;
	public IntPtr get_property;
	public IntPtr dispose;
	public IntPtr finalize;
	public IntPtr dispatch_properties_changed;
	public IntPtr notify;
	public IntPtr constructed;
}
