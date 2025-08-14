namespace MentorLake.Vulkan;


public class VkSemaphoreSignalInfoHandle : BaseSafeHandle
{
}


public static class VkSemaphoreSignalInfoExtensions
{

	public static VkSemaphoreSignalInfo Dereference(this VkSemaphoreSignalInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreSignalInfo>(x.DangerousGetHandle());
}
internal class VkSemaphoreSignalInfoExterns
{
}


public struct VkSemaphoreSignalInfo
{
}
