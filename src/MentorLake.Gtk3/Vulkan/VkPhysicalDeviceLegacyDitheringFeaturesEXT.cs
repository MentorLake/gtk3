namespace MentorLake.Vulkan;

public class VkPhysicalDeviceLegacyDitheringFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLegacyDitheringFeaturesEXTExtensions
{

	public static VkPhysicalDeviceLegacyDitheringFeaturesEXT Dereference(this VkPhysicalDeviceLegacyDitheringFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLegacyDitheringFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLegacyDitheringFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
{
}
