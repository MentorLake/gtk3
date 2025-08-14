namespace MentorLake.Vulkan;


public class VkDeviceAddressHandle : BaseSafeHandle
{
}


public static class VkDeviceAddressExtensions
{

	public static VkDeviceAddress Dereference(this VkDeviceAddressHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceAddress>(x.DangerousGetHandle());
}
internal class VkDeviceAddressExterns
{
}


public struct VkDeviceAddress
{
}
