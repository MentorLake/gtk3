namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderFloat16Int8FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderFloat16Int8FeaturesExtensions
{

	public static VkPhysicalDeviceShaderFloat16Int8Features Dereference(this VkPhysicalDeviceShaderFloat16Int8FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderFloat16Int8Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderFloat16Int8FeaturesExterns
{
}


public struct VkPhysicalDeviceShaderFloat16Int8Features
{
}
