namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration specifying the weight (boldness) of a font.
/// </para>
/// <para>
/// Weight is specified as a numeric value ranging from 100 to 1000.
/// This enumeration simply provides some common, predefined values.
/// </para>
/// </summary>

[Flags]
public enum PangoWeight
{
/// <summary>
/// <para>
/// the thin weight (= 100) Since: 1.24
/// </para>
/// </summary>

	PANGO_WEIGHT_THIN = 100,
/// <summary>
/// <para>
/// the ultralight weight (= 200)
/// </para>
/// </summary>

	PANGO_WEIGHT_ULTRALIGHT = 200,
/// <summary>
/// <para>
/// the light weight (= 300)
/// </para>
/// </summary>

	PANGO_WEIGHT_LIGHT = 300,
/// <summary>
/// <para>
/// the semilight weight (= 350) Since: 1.36.7
/// </para>
/// </summary>

	PANGO_WEIGHT_SEMILIGHT = 350,
/// <summary>
/// <para>
/// the book weight (= 380) Since: 1.24)
/// </para>
/// </summary>

	PANGO_WEIGHT_BOOK = 380,
/// <summary>
/// <para>
/// the default weight (= 400)
/// </para>
/// </summary>

	PANGO_WEIGHT_NORMAL = 400,
/// <summary>
/// <para>
/// the medium weight (= 500) Since: 1.24
/// </para>
/// </summary>

	PANGO_WEIGHT_MEDIUM = 500,
/// <summary>
/// <para>
/// the semibold weight (= 600)
/// </para>
/// </summary>

	PANGO_WEIGHT_SEMIBOLD = 600,
/// <summary>
/// <para>
/// the bold weight (= 700)
/// </para>
/// </summary>

	PANGO_WEIGHT_BOLD = 700,
/// <summary>
/// <para>
/// the ultrabold weight (= 800)
/// </para>
/// </summary>

	PANGO_WEIGHT_ULTRABOLD = 800,
/// <summary>
/// <para>
/// the heavy weight (= 900)
/// </para>
/// </summary>

	PANGO_WEIGHT_HEAVY = 900,
/// <summary>
/// <para>
/// the ultraheavy weight (= 1000) Since: 1.24
/// </para>
/// </summary>

	PANGO_WEIGHT_ULTRAHEAVY = 1000
}
