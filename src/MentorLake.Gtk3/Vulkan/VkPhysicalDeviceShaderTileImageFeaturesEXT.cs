namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderTileImageFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderTileImageFeaturesEXTExtensions
{

	public static VkPhysicalDeviceShaderTileImageFeaturesEXT Dereference(this VkPhysicalDeviceShaderTileImageFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderTileImageFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderTileImageFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceShaderTileImageFeaturesEXT
{
}
