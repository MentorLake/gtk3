namespace MentorLake.PangoOT;

/// <summary>
/// <para>
/// The `PangoOTFeatureMap` typedef is used to represent an OpenType
/// feature with the property bit associated with it.  The feature tag is
/// represented as a char array instead of a `PangoOTTag` for convenience.
/// </para>
/// </summary>

public class PangoOTFeatureMapHandle : BaseSafeHandle
{
}


public static class PangoOTFeatureMapExtensions
{

	public static PangoOTFeatureMap Dereference(this PangoOTFeatureMapHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTFeatureMap>(x.DangerousGetHandle());
}
internal class PangoOTFeatureMapExterns
{
}

/// <summary>
/// <para>
/// The `PangoOTFeatureMap` typedef is used to represent an OpenType
/// feature with the property bit associated with it.  The feature tag is
/// represented as a char array instead of a `PangoOTTag` for convenience.
/// </para>
/// </summary>

public struct PangoOTFeatureMap
{
	/// <summary>
/// <para>
/// feature tag in represented as four-letter ASCII string.
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public char[] feature_name;
	/// <summary>
/// <para>
/// the property bit to use for this feature.  See
/// pango_ot_ruleset_add_feature() for details.
/// </para>
/// </summary>

public ulong property_bit;
}
