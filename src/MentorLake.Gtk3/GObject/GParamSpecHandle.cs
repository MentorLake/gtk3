namespace MentorLake.GObject;

/// <summary>
/// <para>
/// `GParamSpec` encapsulates the metadata required to specify parameters, such as `GObject` properties.
/// </para>
/// <para>
/// ## Parameter names
/// </para>
/// <para>
/// A property name consists of one or more segments consisting of ASCII letters
/// and digits, separated by either the `-` or `_` character. The first
/// character of a property name must be a letter. These are the same rules as
/// for signal naming (see [func@GObject.signal_new]).
/// </para>
/// <para>
/// When creating and looking up a `GParamSpec`, either separator can be
/// used, but they cannot be mixed. Using `-` is considerably more
/// efficient, and is the ‘canonical form’. Using `_` is discouraged.
/// </para>
/// </summary>

public class GParamSpecHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GParamSpec instance.
/// </para>
/// <para>
/// See [canonical parameter names][class@GObject.ParamSpec#parameter-names]
/// for details of the rules for @name. Names which violate these rules lead
/// to undefined behaviour.
/// </para>
/// <para>
/// Beyond the name, #GParamSpecs have two more descriptive strings, the
/// @nick and @blurb, which may be used as a localized label and description.
/// For GTK and related libraries these are considered deprecated and may be
/// omitted, while for other libraries such as GStreamer and its plugins they
/// are essential. When in doubt, follow the conventions used in the
/// surrounding code and supporting libraries.
/// </para>
/// </summary>

/// <param name="param_type">
/// the #GType for the property; must be derived from %G_TYPE_PARAM
/// </param>
/// <param name="name">
/// the canonical name of the property
/// </param>
/// <param name="nick">
/// the nickname of the property
/// </param>
/// <param name="blurb">
/// a short description of the property
/// </param>
/// <param name="flags">
/// a combination of #GParamFlags
/// </param>
/// <return>
/// (transfer floating): a newly allocated
///     #GParamSpec instance, which is initially floating
/// </return>

	public static MentorLake.GObject.GParamSpecHandle Internal(MentorLake.GObject.GType param_type, string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags)
	{
		return GParamSpecHandleExterns.g_param_spec_internal(param_type, name, nick, blurb, flags);
	}

/// <summary>
/// <para>
/// Validate a property name for a #GParamSpec. This can be useful for
/// dynamically-generated properties which need to be validated at run-time
/// before actually trying to create them.
/// </para>
/// <para>
/// See [canonical parameter names][class@GObject.ParamSpec#parameter-names]
/// for details of the rules for valid names.
/// </para>
/// </summary>

/// <param name="name">
/// the canonical name of the property
/// </param>
/// <return>
/// %TRUE if @name is a valid property name, %FALSE otherwise.
/// </return>

	public static bool IsValidName(string name)
	{
		return GParamSpecHandleExterns.g_param_spec_is_valid_name(name);
	}

}

public static class GParamSpecHandleExtensions
{
/// <summary>
/// <para>
/// Get the short description of a #GParamSpec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <return>
/// the short description of @pspec.
/// </return>

	public static string GetBlurb(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_blurb(pspec);
	}

/// <summary>
/// <para>
/// Gets the default value of @pspec as a pointer to a #GValue.
/// </para>
/// <para>
/// The #GValue will remain valid for the life of @pspec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <return>
/// a pointer to a #GValue which must not be modified
/// </return>

	public static MentorLake.GObject.GValueHandle GetDefaultValue(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_default_value(pspec);
	}

/// <summary>
/// <para>
/// Get the name of a #GParamSpec.
/// </para>
/// <para>
/// The name is always an "interned" string (as per g_intern_string()).
/// This allows for pointer-value comparisons.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <return>
/// the name of @pspec.
/// </return>

	public static string GetName(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_name(pspec);
	}

/// <summary>
/// <para>
/// Gets the GQuark for the name.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <return>
/// the GQuark for @pspec->name.
/// </return>

	public static MentorLake.GLib.GQuark GetNameQuark(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_name_quark(pspec);
	}

/// <summary>
/// <para>
/// Get the nickname of a #GParamSpec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <return>
/// the nickname of @pspec.
/// </return>

	public static string GetNick(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_nick(pspec);
	}

/// <summary>
/// <para>
/// Gets back user data pointers stored via g_param_spec_set_qdata().
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <param name="quark">
/// a #GQuark, naming the user data pointer
/// </param>
/// <return>
/// the user data pointer set, or %NULL
/// </return>

	public static IntPtr GetQdata(this MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_qdata(pspec, quark);
	}

/// <summary>
/// <para>
/// If the paramspec redirects operations to another paramspec,
/// returns that paramspec. Redirect is used typically for
/// providing a new implementation of a property in a derived
/// type while preserving all the properties from the parent
/// type. Redirection is established by creating a property
/// of type #GParamSpecOverride. See g_object_class_override_property()
/// for an example of the use of this capability.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <return>
/// paramspec to which requests on this
///          paramspec should be redirected, or %NULL if none.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle GetRedirectTarget(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_get_redirect_target(pspec);
	}

/// <summary>
/// <para>
/// Increments the reference count of @pspec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <return>
/// the #GParamSpec that was passed into this function
/// </return>

	public static MentorLake.GObject.GParamSpecHandle Ref(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_ref(pspec);
	}

/// <summary>
/// <para>
/// Convenience function to ref and sink a #GParamSpec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>
/// <return>
/// the #GParamSpec that was passed into this function
/// </return>

	public static MentorLake.GObject.GParamSpecHandle RefSink(this MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_ref_sink(pspec);
	}

/// <summary>
/// <para>
/// Sets an opaque, named pointer on a #GParamSpec. The name is
/// specified through a #GQuark (retrieved e.g. via
/// g_quark_from_static_string()), and the pointer can be gotten back
/// from the @pspec with g_param_spec_get_qdata().  Setting a
/// previously set user data pointer, overrides (frees) the old pointer
/// set, using %NULL as pointer essentially removes the data stored.
/// </para>
/// </summary>

/// <param name="pspec">
/// the #GParamSpec to set store a user data pointer
/// </param>
/// <param name="quark">
/// a #GQuark, naming the user data pointer
/// </param>
/// <param name="data">
/// an opaque user data pointer
/// </param>

	public static T SetQdata<T>(this T pspec, MentorLake.GLib.GQuark quark, IntPtr data) where T : GParamSpecHandle
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		GParamSpecHandleExterns.g_param_spec_set_qdata(pspec, quark, data);
		return pspec;
	}

/// <summary>
/// <para>
/// This function works like g_param_spec_set_qdata(), but in addition,
/// a `void (*destroy) (gpointer)` function may be
/// specified which is called with @data as argument when the @pspec is
/// finalized, or the data is being overwritten by a call to
/// g_param_spec_set_qdata() with the same @quark.
/// </para>
/// </summary>

/// <param name="pspec">
/// the #GParamSpec to set store a user data pointer
/// </param>
/// <param name="quark">
/// a #GQuark, naming the user data pointer
/// </param>
/// <param name="data">
/// an opaque user data pointer
/// </param>
/// <param name="destroy">
/// function to invoke with @data as argument, when @data needs to
///  be freed
/// </param>

	public static T SetQdataFull<T>(this T pspec, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GParamSpecHandle
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		GParamSpecHandleExterns.g_param_spec_set_qdata_full(pspec, quark, data, destroy);
		return pspec;
	}

/// <summary>
/// <para>
/// The initial reference count of a newly created #GParamSpec is 1,
/// even though no one has explicitly called g_param_spec_ref() on it
/// yet. So the initial reference count is flagged as "floating", until
/// someone calls `g_param_spec_ref (pspec); g_param_spec_sink
/// (pspec);` in sequence on it, taking over the initial
/// reference count (thus ending up with a @pspec that has a reference
/// count of 1 still, but is not flagged "floating" anymore).
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>

	public static T Sink<T>(this T pspec) where T : GParamSpecHandle
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		GParamSpecHandleExterns.g_param_spec_sink(pspec);
		return pspec;
	}

/// <summary>
/// <para>
/// Gets back user data pointers stored via g_param_spec_set_qdata()
/// and removes the @data from @pspec without invoking its destroy()
/// function (if any was set).  Usually, calling this function is only
/// required to update user data pointers with a destroy notifier.
/// </para>
/// </summary>

/// <param name="pspec">
/// the #GParamSpec to get a stored user data pointer from
/// </param>
/// <param name="quark">
/// a #GQuark, naming the user data pointer
/// </param>
/// <return>
/// the user data pointer set, or %NULL
/// </return>

	public static IntPtr StealQdata(this MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GQuark quark)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
		return GParamSpecHandleExterns.g_param_spec_steal_qdata(pspec, quark);
	}

/// <summary>
/// <para>
/// Decrements the reference count of a @pspec.
/// </para>
/// </summary>

/// <param name="pspec">
/// a valid #GParamSpec
/// </param>

	public static T Unref<T>(this T pspec) where T : GParamSpecHandle
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GParamSpecHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_get_redirect_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_internal(MentorLake.GObject.GType param_type, string name, string nick, string blurb, MentorLake.GObject.GParamFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_param_spec_is_valid_name(string name);

}
