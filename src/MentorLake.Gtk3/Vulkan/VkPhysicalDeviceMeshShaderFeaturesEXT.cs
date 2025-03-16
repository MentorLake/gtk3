namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMeshShaderFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMeshShaderFeaturesEXTExtensions
{

	public static VkPhysicalDeviceMeshShaderFeaturesEXT Dereference(this VkPhysicalDeviceMeshShaderFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMeshShaderFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMeshShaderFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceMeshShaderFeaturesEXT
{
}
