namespace MentorLake.GObject;

public class GParamSpecHandle : BaseSafeHandle
{
	public static MentorLake.GObject.GParamSpecHandle Internal(MentorLake.GObject.GType param_type, string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags)
	{
		return GParamSpecHandleExterns.g_param_spec_internal(param_type, name, nick, blurb, flags);
	}

	public static bool IsValidName(string name)
	{
		return GParamSpecHandleExterns.g_param_spec_is_valid_name(name);
	}

}

public static class GParamSpecHandleExtensions
{
	public static string GetBlurb(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_get_blurb(pspec);
	}

	public static MentorLake.GObject.GValueHandle GetDefaultValue(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_get_default_value(pspec);
	}

	public static string GetName(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_get_name(pspec);
	}

	public static MentorLake.GLib.GQuark GetNameQuark(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_get_name_quark(pspec);
	}

	public static string GetNick(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_get_nick(pspec);
	}

	public static IntPtr GetQdata(this MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark)
	{
		return GParamSpecHandleExterns.g_param_spec_get_qdata(pspec, quark);
	}

	public static MentorLake.GObject.GParamSpecHandle GetRedirectTarget(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_get_redirect_target(pspec);
	}

	public static MentorLake.GObject.GParamSpecHandle Ref(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_ref(pspec);
	}

	public static MentorLake.GObject.GParamSpecHandle RefSink(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GParamSpecHandleExterns.g_param_spec_ref_sink(pspec);
	}

	public static T SetQdata<T>(this T pspec, MentorLake.GLib.GQuark quark, IntPtr data) where T : GParamSpecHandle
	{
		GParamSpecHandleExterns.g_param_spec_set_qdata(pspec, quark, data);
		return pspec;
	}

	public static T SetQdataFull<T>(this T pspec, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GParamSpecHandle
	{
		GParamSpecHandleExterns.g_param_spec_set_qdata_full(pspec, quark, data, destroy);
		return pspec;
	}

	public static T Sink<T>(this T pspec) where T : GParamSpecHandle
	{
		GParamSpecHandleExterns.g_param_spec_sink(pspec);
		return pspec;
	}

	public static IntPtr StealQdata(this MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark)
	{
		return GParamSpecHandleExterns.g_param_spec_steal_qdata(pspec, quark);
	}

	public static T Unref<T>(this T pspec) where T : GParamSpecHandle
	{
		GParamSpecHandleExterns.g_param_spec_unref(pspec);
		return pspec;
	}

}

internal class GParamSpecHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_param_spec_get_blurb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GValueHandle g_param_spec_get_default_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_param_spec_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_param_spec_get_name_quark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_param_spec_get_nick([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_param_spec_get_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_get_redirect_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_ref_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_set_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_set_qdata_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_param_spec_steal_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_internal(MentorLake.GObject.GType param_type, string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_param_spec_is_valid_name(string name);

}
