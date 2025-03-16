namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImage2DViewOf3DFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImage2DViewOf3DFeaturesEXTExtensions
{

	public static VkPhysicalDeviceImage2DViewOf3DFeaturesEXT Dereference(this VkPhysicalDeviceImage2DViewOf3DFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImage2DViewOf3DFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImage2DViewOf3DFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
}
