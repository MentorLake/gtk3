namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDepthClampZeroOneFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDepthClampZeroOneFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDepthClampZeroOneFeaturesEXT Dereference(this VkPhysicalDeviceDepthClampZeroOneFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDepthClampZeroOneFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDepthClampZeroOneFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
{
}
