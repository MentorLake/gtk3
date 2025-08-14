namespace MentorLake.Vulkan;


public class VkPhysicalDeviceAmigoProfilingFeaturesSECHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceAmigoProfilingFeaturesSECExtensions
{

	public static VkPhysicalDeviceAmigoProfilingFeaturesSEC Dereference(this VkPhysicalDeviceAmigoProfilingFeaturesSECHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceAmigoProfilingFeaturesSEC>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceAmigoProfilingFeaturesSECExterns
{
}


public struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
{
}
