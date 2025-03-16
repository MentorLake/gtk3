namespace MentorLake.Vulkan;

public class VkVideoReferenceSlotInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoReferenceSlotInfoKHRExtensions
{

	public static VkVideoReferenceSlotInfoKHR Dereference(this VkVideoReferenceSlotInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoReferenceSlotInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoReferenceSlotInfoKHRExterns
{
}

public struct VkVideoReferenceSlotInfoKHR
{
}
