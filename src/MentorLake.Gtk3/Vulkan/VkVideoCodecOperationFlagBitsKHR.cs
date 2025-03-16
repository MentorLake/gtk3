namespace MentorLake.Vulkan;

public class VkVideoCodecOperationFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCodecOperationFlagBitsKHRExtensions
{

	public static VkVideoCodecOperationFlagBitsKHR Dereference(this VkVideoCodecOperationFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCodecOperationFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoCodecOperationFlagBitsKHRExterns
{
}

public struct VkVideoCodecOperationFlagBitsKHR
{
}
