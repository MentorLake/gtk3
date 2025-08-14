namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDepthClipEnableFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDepthClipEnableFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDepthClipEnableFeaturesEXT Dereference(this VkPhysicalDeviceDepthClipEnableFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDepthClipEnableFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDepthClipEnableFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
{
}
