namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMeshShaderFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMeshShaderFeaturesNVExtensions
{

	public static VkPhysicalDeviceMeshShaderFeaturesNV Dereference(this VkPhysicalDeviceMeshShaderFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMeshShaderFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMeshShaderFeaturesNVExterns
{
}


public struct VkPhysicalDeviceMeshShaderFeaturesNV
{
}
