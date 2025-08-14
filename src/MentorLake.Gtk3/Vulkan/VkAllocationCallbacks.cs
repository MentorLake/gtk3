namespace MentorLake.Vulkan;


public class VkAllocationCallbacksHandle : BaseSafeHandle
{
}


public static class VkAllocationCallbacksExtensions
{

	public static VkAllocationCallbacks Dereference(this VkAllocationCallbacksHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAllocationCallbacks>(x.DangerousGetHandle());
}
internal class VkAllocationCallbacksExterns
{
}


public struct VkAllocationCallbacks
{
}
