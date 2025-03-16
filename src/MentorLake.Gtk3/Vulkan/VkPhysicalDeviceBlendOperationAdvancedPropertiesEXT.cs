namespace MentorLake.Vulkan;

public class VkPhysicalDeviceBlendOperationAdvancedPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBlendOperationAdvancedPropertiesEXTExtensions
{

	public static VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT Dereference(this VkPhysicalDeviceBlendOperationAdvancedPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBlendOperationAdvancedPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
}
