namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A #GParamSpec derived structure that contains the meta data for #GVariant properties.
/// </para>
/// <para>
/// When comparing values with g_param_values_cmp(), scalar values with the same
/// type will be compared with g_variant_compare(). Other non-%NULL variants will
/// be checked for equality with g_variant_equal(), and their sort order is
/// otherwise undefined. %NULL is ordered before non-%NULL variants. Two %NULL
/// values compare equal.
/// </para>
/// </summary>

public class GParamSpecVariantHandle : GParamSpecHandle
{
}

public static class GParamSpecVariantHandleExtensions
{
}

internal class GParamSpecVariantHandleExterns
{
}
