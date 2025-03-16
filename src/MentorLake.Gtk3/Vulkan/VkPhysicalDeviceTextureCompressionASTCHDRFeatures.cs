namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTextureCompressionASTCHDRFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTextureCompressionASTCHDRFeaturesExtensions
{

	public static VkPhysicalDeviceTextureCompressionASTCHDRFeatures Dereference(this VkPhysicalDeviceTextureCompressionASTCHDRFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTextureCompressionASTCHDRFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTextureCompressionASTCHDRFeaturesExterns
{
}

public struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
{
}
