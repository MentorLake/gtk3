namespace MentorLake.Vulkan;


public class VkPhysicalDeviceBlendOperationAdvancedFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBlendOperationAdvancedFeaturesEXTExtensions
{

	public static VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT Dereference(this VkPhysicalDeviceBlendOperationAdvancedFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBlendOperationAdvancedFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
}
