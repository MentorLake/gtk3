namespace MentorLake.Vulkan;


public class VkShadingRatePaletteNVHandle : BaseSafeHandle
{
}


public static class VkShadingRatePaletteNVExtensions
{

	public static VkShadingRatePaletteNV Dereference(this VkShadingRatePaletteNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShadingRatePaletteNV>(x.DangerousGetHandle());
}
internal class VkShadingRatePaletteNVExterns
{
}


public struct VkShadingRatePaletteNV
{
}
