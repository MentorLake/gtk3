namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXTExtensions
{

	public static VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT Dereference(this VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
{
}
