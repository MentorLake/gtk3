namespace MentorLake.Vulkan;

public class VkFragmentShadingRateTypeNVHandle : BaseSafeHandle
{
}


public static class VkFragmentShadingRateTypeNVExtensions
{

	public static VkFragmentShadingRateTypeNV Dereference(this VkFragmentShadingRateTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFragmentShadingRateTypeNV>(x.DangerousGetHandle());
}
internal class VkFragmentShadingRateTypeNVExterns
{
}

public struct VkFragmentShadingRateTypeNV
{
}
