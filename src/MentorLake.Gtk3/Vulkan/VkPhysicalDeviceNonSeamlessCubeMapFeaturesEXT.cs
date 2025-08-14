namespace MentorLake.Vulkan;


public class VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXTExtensions
{

	public static VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT Dereference(this VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
{
}
