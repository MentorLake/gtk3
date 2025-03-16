namespace MentorLake.Vulkan;

public class VkPhysicalDeviceBorderColorSwizzleFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBorderColorSwizzleFeaturesEXTExtensions
{

	public static VkPhysicalDeviceBorderColorSwizzleFeaturesEXT Dereference(this VkPhysicalDeviceBorderColorSwizzleFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBorderColorSwizzleFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBorderColorSwizzleFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
}
