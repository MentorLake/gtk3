namespace MentorLake.Vulkan;


public class VkExternalMemoryAcquireUnmodifiedEXTHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryAcquireUnmodifiedEXTExtensions
{

	public static VkExternalMemoryAcquireUnmodifiedEXT Dereference(this VkExternalMemoryAcquireUnmodifiedEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryAcquireUnmodifiedEXT>(x.DangerousGetHandle());
}
internal class VkExternalMemoryAcquireUnmodifiedEXTExterns
{
}


public struct VkExternalMemoryAcquireUnmodifiedEXT
{
}
