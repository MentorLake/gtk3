namespace MentorLake.Vulkan;


public class VkVideoCodecOperationFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCodecOperationFlagsKHRExtensions
{

	public static VkVideoCodecOperationFlagsKHR Dereference(this VkVideoCodecOperationFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCodecOperationFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoCodecOperationFlagsKHRExterns
{
}


public struct VkVideoCodecOperationFlagsKHR
{
}
