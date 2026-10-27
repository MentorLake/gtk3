namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Describes a web engine feature that may be toggled at runtime.
/// </para>
/// <para>
/// The WebKit web engine includes a set of features which may be toggled
/// programmatically, each one represented by a #WebKitFeature that provides
/// information about it:
/// </para>
/// <para>
/// - A unique “identifier”: [method@Feature.get_identifier].
/// - A “default value”, which indicates whether the option is enabled
///   automatically: [method@Feature.get_default_value].
/// - Its “status”, which determines whether it should be considered
///   user-settable and its development stage (see [enum@FeatureStatus]
///   for details): [method@Feature.get_status].
/// - A category, which may be used to group features together:
///   [method@Feature.get_category].
/// - An optional short “name” which can be presented to an user:
///   [method@Feature.get_name].
/// - An optional longer “detailed” description:
///   [method@Feature.get_details].
/// </para>
/// <para>
/// The lists of available features can be obtained with
/// [func@Settings.get_all_features], [func@Settings.get_experimental_features],
/// and [func@Settings.get_development_features]). As a rule of thumb,
/// applications which may want to allow users (i.e. web developers) to test
/// WebKit features should use the list of experimental features. Additionally,
/// applications might want to expose development features *when targeting
/// technically inclined users* for early testing of in-development features
/// (i.e. in “technology preview” or “canary” builds).
/// </para>
/// <para>
/// Applications **must not** expose the list of all features to end users
/// because they often lack descriptions and control parts of the web engine
/// which are either intended to be used during development of WebKit itself,
/// or in specific scenarios to tweak how WebKit integrates with the
/// application.
/// </para>
/// </summary>

public class WebKitFeatureHandle : BaseSafeHandle
{
}


public static class WebKitFeatureExtensions
{
/// <summary>
/// <para>
/// Gets the category of the feature.
/// </para>
/// <para>
/// Applications which include user interface to toggle features may want
/// to use the category to group related features together.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// Feature category.
/// </return>

	public static string GetCategory(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_get_category(feature);
	}

/// <summary>
/// <para>
/// Gets whether the feature is enabled by default.
/// </para>
/// <para>
/// The default value may be used by applications which include user interface
/// to toggle features to restore its settings to their defaults. Note that
/// whether a feature is actually enabled must be checked with
/// [method@Settings.get_feature_enabled].
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// Whether the feature is enabled by default.
/// </return>

	public static bool GetDefaultValue(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_get_default_value(feature);
	}

/// <summary>
/// <para>
/// Gets a description for the @feature.
/// </para>
/// <para>
/// The detailed description should be considered an additional clarification
/// on the purpose of the feature, to be used as complementary aid to be
/// displayed along the feature name returned by [method@Feature.get_name].
/// The returned string is suitable to be displayed to end users, but it
/// should not be relied upon being localized.
/// </para>
/// <para>
/// Note that some *features may not* have a detailed description, and @NULL
/// is returned in this case.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// Feature description.
/// </return>

	public static string GetDetails(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_get_details(feature);
	}

/// <summary>
/// <para>
/// Gets a string that uniquely identifies the @feature.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// The identifier string for the feature.
/// </return>

	public static string GetIdentifier(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_get_identifier(feature);
	}

/// <summary>
/// <para>
/// Gets a short name for the @feature.
/// </para>
/// <para>
/// The returned string is suitable to be displayed to end users, but it
/// should not be relied upon being localized.
/// </para>
/// <para>
/// Note that some *features may not* have a short name, and @NULL
/// is returned in this case.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// Short feature name.
/// </return>

	public static string GetName(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_get_name(feature);
	}

/// <summary>
/// <para>
/// Gets the status of the feature.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// Feature status.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureStatus GetStatus(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_get_status(feature);
	}

/// <summary>
/// <para>
/// Atomically acquires a reference on the given @feature.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>
/// <return>
/// The same @feature with an additional reference.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureHandle Ref(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		return WebKitFeatureExterns.webkit_feature_ref(feature);
	}

/// <summary>
/// <para>
/// Atomically releases a reference on the given @feature.
/// </para>
/// <para>
/// If the reference was the last, the resources associated to the
/// @feature are freed. This function is MT-safe and may be called from
/// any thread.
/// </para>
/// </summary>

/// <param name="feature">
/// a #WebKitFeature
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitFeatureHandle feature)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (WebKitFeature)");
		WebKitFeatureExterns.webkit_feature_unref(feature);
	}


	public static WebKitFeature Dereference(this WebKitFeatureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFeature>(x.DangerousGetHandle());
}
internal class WebKitFeatureExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_feature_get_category([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	internal static extern bool webkit_feature_get_default_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_feature_get_details([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_feature_get_identifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_feature_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitFeatureStatus webkit_feature_get_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFeatureHandle webkit_feature_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_feature_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))] MentorLake.WebKit2.WebKitFeatureHandle feature);

}

/// <summary>
/// <para>
/// Describes a web engine feature that may be toggled at runtime.
/// </para>
/// <para>
/// The WebKit web engine includes a set of features which may be toggled
/// programmatically, each one represented by a #WebKitFeature that provides
/// information about it:
/// </para>
/// <para>
/// - A unique “identifier”: [method@Feature.get_identifier].
/// - A “default value”, which indicates whether the option is enabled
///   automatically: [method@Feature.get_default_value].
/// - Its “status”, which determines whether it should be considered
///   user-settable and its development stage (see [enum@FeatureStatus]
///   for details): [method@Feature.get_status].
/// - A category, which may be used to group features together:
///   [method@Feature.get_category].
/// - An optional short “name” which can be presented to an user:
///   [method@Feature.get_name].
/// - An optional longer “detailed” description:
///   [method@Feature.get_details].
/// </para>
/// <para>
/// The lists of available features can be obtained with
/// [func@Settings.get_all_features], [func@Settings.get_experimental_features],
/// and [func@Settings.get_development_features]). As a rule of thumb,
/// applications which may want to allow users (i.e. web developers) to test
/// WebKit features should use the list of experimental features. Additionally,
/// applications might want to expose development features *when targeting
/// technically inclined users* for early testing of in-development features
/// (i.e. in “technology preview” or “canary” builds).
/// </para>
/// <para>
/// Applications **must not** expose the list of all features to end users
/// because they often lack descriptions and control parts of the web engine
/// which are either intended to be used during development of WebKit itself,
/// or in specific scenarios to tweak how WebKit integrates with the
/// application.
/// </para>
/// </summary>

public struct WebKitFeature
{
}
