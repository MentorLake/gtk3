namespace MentorLake.Vulkan;


public class VkPhysicalDeviceRawAccessChainsFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRawAccessChainsFeaturesNVExtensions
{

	public static VkPhysicalDeviceRawAccessChainsFeaturesNV Dereference(this VkPhysicalDeviceRawAccessChainsFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRawAccessChainsFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRawAccessChainsFeaturesNVExterns
{
}


public struct VkPhysicalDeviceRawAccessChainsFeaturesNV
{
}
