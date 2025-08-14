namespace MentorLake.PangoOT;

/// <summary>
/// <para>
/// The PangoOTTableType enumeration values are used to
/// identify the various OpenType tables in the
/// pango_ot_info_… functions.
/// </para>
/// </summary>

[Flags]
public enum PangoOTTableType
{
/// <summary>
/// <para>
/// The GSUB table.
/// </para>
/// </summary>

	PANGO_OT_TABLE_GSUB = 0,
/// <summary>
/// <para>
/// The GPOS table.
/// </para>
/// </summary>

	PANGO_OT_TABLE_GPOS = 1
}
