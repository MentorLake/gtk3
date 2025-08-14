namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSynchronization2FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSynchronization2FeaturesExtensions
{

	public static VkPhysicalDeviceSynchronization2Features Dereference(this VkPhysicalDeviceSynchronization2FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSynchronization2Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSynchronization2FeaturesExterns
{
}


public struct VkPhysicalDeviceSynchronization2Features
{
}
