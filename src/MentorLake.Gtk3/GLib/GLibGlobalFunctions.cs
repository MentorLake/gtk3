namespace MentorLake.GLib;

public class GLibGlobalFunctions
{
	public static int Access(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_access(filename, mode);
	}

	public static IntPtr AlignedAlloc(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment)
	{
		return GLibGlobalFunctionsExterns.g_aligned_alloc(n_blocks, n_block_bytes, alignment);
	}

	public static IntPtr AlignedAlloc0(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment)
	{
		return GLibGlobalFunctionsExterns.g_aligned_alloc0(n_blocks, n_block_bytes, alignment);
	}

	public static void AlignedFree(IntPtr mem)
	{
		GLibGlobalFunctionsExterns.g_aligned_free(mem);
	}

	public static void AlignedFreeSized(IntPtr mem, UIntPtr alignment, UIntPtr size)
	{
		GLibGlobalFunctionsExterns.g_aligned_free_sized(mem, alignment, size);
	}

	public static MentorLake.GLib.GArrayHandle ArrayNewTake(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size)
	{
		return GLibGlobalFunctionsExterns.g_array_new_take(data, len, clear, element_size);
	}

	public static MentorLake.GLib.GArrayHandle ArrayNewTakeZeroTerminated(IntPtr[] data, bool clear, UIntPtr element_size)
	{
		return GLibGlobalFunctionsExterns.g_array_new_take_zero_terminated(data, clear, element_size);
	}

	public static int AsciiDigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_digit_value(c);
	}

	public static string AsciiDtostr(string buffer, int buf_len, double d)
	{
		return GLibGlobalFunctionsExterns.g_ascii_dtostr(buffer, buf_len, d);
	}

	public static string AsciiFormatd(string buffer, int buf_len, string format, double d)
	{
		return GLibGlobalFunctionsExterns.g_ascii_formatd(buffer, buf_len, format, d);
	}

	public static int AsciiStrcasecmp(string s1, string s2)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strcasecmp(s1, s2);
	}

	public static string AsciiStrdown(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strdown(str, len);
	}

	public static bool AsciiStringToSigned(string str, uint @base, long min, long max, out long out_num)
	{
		return GLibGlobalFunctionsExterns.g_ascii_string_to_signed(str, @base, min, max, out out_num);
	}

	public static bool AsciiStringToUnsigned(string str, uint @base, ulong min, ulong max, out ulong out_num)
	{
		return GLibGlobalFunctionsExterns.g_ascii_string_to_unsigned(str, @base, min, max, out out_num);
	}

	public static int AsciiStrncasecmp(string s1, string s2, UIntPtr n)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strncasecmp(s1, s2, n);
	}

	public static double AsciiStrtod(string nptr, out string endptr)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strtod(nptr, out endptr);
	}

	public static long AsciiStrtoll(string nptr, out string endptr, uint @base)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strtoll(nptr, out endptr, @base);
	}

	public static ulong AsciiStrtoull(string nptr, out string endptr, uint @base)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strtoull(nptr, out endptr, @base);
	}

	public static string AsciiStrup(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strup(str, len);
	}

	public static char AsciiTolower(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_tolower(c);
	}

	public static char AsciiToupper(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_toupper(c);
	}

	public static int AsciiXdigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_xdigit_value(c);
	}

	public static void AssertWarning(string log_domain, string file, int line, string pretty_function, string expression)
	{
		GLibGlobalFunctionsExterns.g_assert_warning(log_domain, file, line, pretty_function, expression);
	}

	public static void AssertionMessage(string domain, string file, int line, string func, string message)
	{
		GLibGlobalFunctionsExterns.g_assertion_message(domain, file, line, func, message);
	}

	public static void AssertionMessageCmpint(string domain, string file, int line, string func, string expr, ulong arg1, string cmp, ulong arg2, char numtype)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpint(domain, file, line, func, expr, arg1, cmp, arg2, numtype);
	}

	public static void AssertionMessageCmpnum(string domain, string file, int line, string func, string expr, long arg1, string cmp, long arg2, char numtype)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpnum(domain, file, line, func, expr, arg1, cmp, arg2, numtype);
	}

	public static void AssertionMessageCmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpstr(domain, file, line, func, expr, arg1, cmp, arg2);
	}

	public static void AssertionMessageCmpstrv(string domain, string file, int line, string func, string expr, string arg1, string arg2, UIntPtr first_wrong_idx)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpstrv(domain, file, line, func, expr, arg1, arg2, first_wrong_idx);
	}

	public static void AssertionMessageError(string domain, string file, int line, string func, string expr, MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark error_domain, int error_code)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_error(domain, file, line, func, expr, error, error_domain, error_code);
	}

	public static void AssertionMessageExpr(string domain, string file, int line, string func, string expr)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_expr(domain, file, line, func, expr);
	}

	public static MentorLake.GLib.GAsyncQueueHandle AsyncQueueNew()
	{
		return GLibGlobalFunctionsExterns.g_async_queue_new();
	}

	public static MentorLake.GLib.GAsyncQueueHandle AsyncQueueNewFull(MentorLake.GLib.GDestroyNotify item_free_func)
	{
		return GLibGlobalFunctionsExterns.g_async_queue_new_full(item_free_func);
	}

	public static void Atexit(MentorLake.GLib.GVoidFunc func)
	{
		GLibGlobalFunctionsExterns.g_atexit(func);
	}

	public static int AtomicIntAdd(int atomic, int val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_add(atomic, val);
	}

	public static uint AtomicIntAnd(uint atomic, uint val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_and(atomic, val);
	}

	public static bool AtomicIntCompareAndExchange(int atomic, int oldval, int newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_compare_and_exchange(atomic, oldval, newval);
	}

	public static bool AtomicIntCompareAndExchangeFull(int atomic, int oldval, int newval, out int preval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_compare_and_exchange_full(atomic, oldval, newval, out preval);
	}

	public static bool AtomicIntDecAndTest(int atomic)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_dec_and_test(atomic);
	}

	public static int AtomicIntExchange(int atomic, int newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_exchange(atomic, newval);
	}

	public static int AtomicIntExchangeAndAdd(int atomic, int val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_exchange_and_add(atomic, val);
	}

	public static int AtomicIntGet(int atomic)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_get(atomic);
	}

	public static void AtomicIntInc(int atomic)
	{
		GLibGlobalFunctionsExterns.g_atomic_int_inc(atomic);
	}

	public static uint AtomicIntOr(uint atomic, uint val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_or(atomic, val);
	}

	public static void AtomicIntSet(int atomic, int newval)
	{
		GLibGlobalFunctionsExterns.g_atomic_int_set(atomic, newval);
	}

	public static uint AtomicIntXor(uint atomic, uint val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_xor(atomic, val);
	}

	public static int AtomicPointerAdd(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_add(atomic, val);
	}

	public static uint AtomicPointerAnd(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_and(atomic, val);
	}

	public static bool AtomicPointerCompareAndExchange(IntPtr atomic, IntPtr oldval, IntPtr newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_compare_and_exchange(atomic, oldval, newval);
	}

	public static bool AtomicPointerCompareAndExchangeFull(IntPtr atomic, IntPtr oldval, IntPtr newval, out IntPtr preval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_compare_and_exchange_full(atomic, oldval, newval, out preval);
	}

	public static IntPtr AtomicPointerExchange(IntPtr atomic, IntPtr newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_exchange(atomic, newval);
	}

	public static IntPtr AtomicPointerGet(IntPtr atomic)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_get(atomic);
	}

	public static uint AtomicPointerOr(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_or(atomic, val);
	}

	public static void AtomicPointerSet(IntPtr atomic, IntPtr newval)
	{
		GLibGlobalFunctionsExterns.g_atomic_pointer_set(atomic, newval);
	}

	public static uint AtomicPointerXor(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_xor(atomic, val);
	}

	public static IntPtr AtomicRcBoxAcquire(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_acquire(mem_block);
	}

	public static IntPtr AtomicRcBoxAlloc(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_alloc(block_size);
	}

	public static IntPtr AtomicRcBoxAlloc0(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_alloc0(block_size);
	}

	public static IntPtr AtomicRcBoxDup(UIntPtr block_size, IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_dup(block_size, mem_block);
	}

	public static UIntPtr AtomicRcBoxGetSize(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_get_size(mem_block);
	}

	public static void AtomicRcBoxRelease(IntPtr mem_block)
	{
		GLibGlobalFunctionsExterns.g_atomic_rc_box_release(mem_block);
	}

	public static void AtomicRcBoxReleaseFull(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func)
	{
		GLibGlobalFunctionsExterns.g_atomic_rc_box_release_full(mem_block, clear_func);
	}

	public static bool AtomicRefCountCompare(int arc, int val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_ref_count_compare(arc, val);
	}

	public static bool AtomicRefCountDec(int arc)
	{
		return GLibGlobalFunctionsExterns.g_atomic_ref_count_dec(arc);
	}

	public static void AtomicRefCountInc(int arc)
	{
		GLibGlobalFunctionsExterns.g_atomic_ref_count_inc(arc);
	}

	public static void AtomicRefCountInit(int arc)
	{
		GLibGlobalFunctionsExterns.g_atomic_ref_count_init(arc);
	}

	public static byte[] Base64Decode(string text, out UIntPtr out_len)
	{
		return GLibGlobalFunctionsExterns.g_base64_decode(text, out out_len);
	}

	public static char Base64DecodeInplace(ref byte[] text, ref UIntPtr out_len)
	{
		return GLibGlobalFunctionsExterns.g_base64_decode_inplace(ref text, ref out_len);
	}

	public static UIntPtr Base64DecodeStep(byte[] @in, UIntPtr len, out byte[] @out, ref int state, ref uint save)
	{
		return GLibGlobalFunctionsExterns.g_base64_decode_step(@in, len, out @out, ref state, ref save);
	}

	public static string Base64Encode(byte[] data, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_base64_encode(data, len);
	}

	public static UIntPtr Base64EncodeClose(bool break_lines, out byte[] @out, ref int state, ref int save)
	{
		return GLibGlobalFunctionsExterns.g_base64_encode_close(break_lines, out @out, ref state, ref save);
	}

	public static UIntPtr Base64EncodeStep(byte[] @in, UIntPtr len, bool break_lines, out byte[] @out, ref int state, ref int save)
	{
		return GLibGlobalFunctionsExterns.g_base64_encode_step(@in, len, break_lines, out @out, ref state, ref save);
	}

	public static string Basename(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_basename(file_name);
	}

	public static void BitLock(int address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_bit_lock(address, lock_bit);
	}

	public static int BitNthLsf(ulong mask, int nth_bit)
	{
		return GLibGlobalFunctionsExterns.g_bit_nth_lsf(mask, nth_bit);
	}

	public static int BitNthMsf(ulong mask, int nth_bit)
	{
		return GLibGlobalFunctionsExterns.g_bit_nth_msf(mask, nth_bit);
	}

	public static uint BitStorage(ulong number)
	{
		return GLibGlobalFunctionsExterns.g_bit_storage(number);
	}

	public static bool BitTrylock(int address, int lock_bit)
	{
		return GLibGlobalFunctionsExterns.g_bit_trylock(address, lock_bit);
	}

	public static void BitUnlock(int address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_bit_unlock(address, lock_bit);
	}

	public static void BlowChunks()
	{
		GLibGlobalFunctionsExterns.g_blow_chunks();
	}

	public static MentorLake.GLib.GQuark BookmarkFileErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_bookmark_file_error_quark();
	}

	public static string BuildFilename(string first_element, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_build_filename(first_element, @__arglist);
	}

	public static string BuildFilenameValist(string first_element, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_build_filename_valist(first_element, args);
	}

	public static string BuildFilenamev(string[] args)
	{
		return GLibGlobalFunctionsExterns.g_build_filenamev(args);
	}

	public static string BuildPath(string separator, string first_element, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_build_path(separator, first_element, @__arglist);
	}

	public static string BuildPathv(string separator, string[] args)
	{
		return GLibGlobalFunctionsExterns.g_build_pathv(separator, args);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayAppend(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_append(array, data, len);
	}

	public static byte ByteArrayFree(MentorLake.GLib.GByteArrayHandle array, bool free_segment)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_free(array, free_segment);
	}

	public static MentorLake.GLib.GBytesHandle ByteArrayFreeToBytes(MentorLake.GLib.GByteArrayHandle array)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_free_to_bytes(array);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayNew()
	{
		return GLibGlobalFunctionsExterns.g_byte_array_new();
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayNewTake(byte[] data, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_new_take(data, len);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayPrepend(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_prepend(array, data, len);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRef(MentorLake.GLib.GByteArrayHandle array)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_ref(array);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRemoveIndex(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_remove_index(array, index_);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRemoveIndexFast(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_remove_index_fast(array, index_);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRemoveRange(MentorLake.GLib.GByteArrayHandle array, uint index_, uint length)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_remove_range(array, index_, length);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArraySetSize(MentorLake.GLib.GByteArrayHandle array, uint length)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_set_size(array, length);
	}

	public static MentorLake.GLib.GByteArrayHandle ByteArraySizedNew(uint reserved_size)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_sized_new(reserved_size);
	}

	public static void ByteArraySort(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GLibGlobalFunctionsExterns.g_byte_array_sort(array, compare_func);
	}

	public static void ByteArraySortWithData(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_byte_array_sort_with_data(array, compare_func, user_data);
	}

	public static byte ByteArraySteal(MentorLake.GLib.GByteArrayHandle array, out UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_steal(array, out len);
	}

	public static void ByteArrayUnref(MentorLake.GLib.GByteArrayHandle array)
	{
		GLibGlobalFunctionsExterns.g_byte_array_unref(array);
	}

	public static string CanonicalizeFilename(string filename, string relative_to)
	{
		return GLibGlobalFunctionsExterns.g_canonicalize_filename(filename, relative_to);
	}

	public static int Chdir(string path)
	{
		return GLibGlobalFunctionsExterns.g_chdir(path);
	}

	public static string CheckVersion(uint required_major, uint required_minor, uint required_micro)
	{
		return GLibGlobalFunctionsExterns.glib_check_version(required_major, required_minor, required_micro);
	}

	public static UIntPtr ChecksumTypeGetLength(MentorLake.GLib.GChecksumType checksum_type)
	{
		return GLibGlobalFunctionsExterns.g_checksum_type_get_length(checksum_type);
	}

	public static uint ChildWatchAdd(MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_child_watch_add(pid, function, data);
	}

	public static uint ChildWatchAddFull(int priority, MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_child_watch_add_full(priority, pid, function, data, notify);
	}

	public static MentorLake.GLib.GSourceHandle ChildWatchSourceNew(MentorLake.GLib.GPid pid)
	{
		return GLibGlobalFunctionsExterns.g_child_watch_source_new(pid);
	}

	public static int Chmod(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_chmod(filename, mode);
	}

	public static void ClearError()
	{
		GLibGlobalFunctionsExterns.g_clear_error();
	}

	public static void ClearHandleId(uint tag_ptr, MentorLake.GLib.GClearHandleFunc clear_func)
	{
		GLibGlobalFunctionsExterns.g_clear_handle_id(tag_ptr, clear_func);
	}

	public static void ClearList(IntPtr list_ptr, MentorLake.GLib.GDestroyNotify destroy)
	{
		GLibGlobalFunctionsExterns.g_clear_list(list_ptr, destroy);
	}

	public static void ClearPointer(ref IntPtr pp, MentorLake.GLib.GDestroyNotify destroy)
	{
		GLibGlobalFunctionsExterns.g_clear_pointer(ref pp, destroy);
	}

	public static void ClearSlist(IntPtr slist_ptr, MentorLake.GLib.GDestroyNotify destroy)
	{
		GLibGlobalFunctionsExterns.g_clear_slist(slist_ptr, destroy);
	}

	public static bool Close(int fd)
	{
		return GLibGlobalFunctionsExterns.g_close(fd);
	}

	public static int Closefrom(int lowfd)
	{
		return GLibGlobalFunctionsExterns.g_closefrom(lowfd);
	}

	public static string ComputeChecksumForBytes(MentorLake.GLib.GChecksumType checksum_type, MentorLake.GLib.GBytesHandle data)
	{
		return GLibGlobalFunctionsExterns.g_compute_checksum_for_bytes(checksum_type, data);
	}

	public static string ComputeChecksumForData(MentorLake.GLib.GChecksumType checksum_type, byte[] data, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_checksum_for_data(checksum_type, data, length);
	}

	public static string ComputeChecksumForString(MentorLake.GLib.GChecksumType checksum_type, string str, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_checksum_for_string(checksum_type, str, length);
	}

	public static string ComputeHmacForBytes(MentorLake.GLib.GChecksumType digest_type, MentorLake.GLib.GBytesHandle key, MentorLake.GLib.GBytesHandle data)
	{
		return GLibGlobalFunctionsExterns.g_compute_hmac_for_bytes(digest_type, key, data);
	}

	public static string ComputeHmacForData(MentorLake.GLib.GChecksumType digest_type, char[] key, UIntPtr key_len, char[] data, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_hmac_for_data(digest_type, key, key_len, data, length);
	}

	public static string ComputeHmacForString(MentorLake.GLib.GChecksumType digest_type, char[] key, UIntPtr key_len, string str, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_hmac_for_string(digest_type, key, key_len, str, length);
	}

	public static MentorLake.GLib.GCondHandle CondNew()
	{
		return GLibGlobalFunctionsExterns.g_cond_new();
	}

	public static byte[] Convert(byte[] str, UIntPtr len, string to_codeset, string from_codeset, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_convert(str, len, to_codeset, from_codeset, out bytes_read, out bytes_written);
	}

	public static MentorLake.GLib.GQuark ConvertErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_convert_error_quark();
	}

	public static byte[] ConvertWithFallback(byte[] str, UIntPtr len, string to_codeset, string from_codeset, string fallback, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_convert_with_fallback(str, len, to_codeset, from_codeset, fallback, out bytes_read, out bytes_written);
	}

	public static byte[] ConvertWithIconv(byte[] str, UIntPtr len, MentorLake.GLib.GIConv converter, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_convert_with_iconv(str, len, converter, out bytes_read, out bytes_written);
	}

	public static int Creat(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_creat(filename, mode);
	}

	public static void DatalistClear(IntPtr datalist)
	{
		GLibGlobalFunctionsExterns.g_datalist_clear(datalist);
	}

	public static void DatalistForeach(IntPtr datalist, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_datalist_foreach(datalist, func, user_data);
	}

	public static IntPtr DatalistGetData(IntPtr datalist, string key)
	{
		return GLibGlobalFunctionsExterns.g_datalist_get_data(datalist, key);
	}

	public static uint DatalistGetFlags(IntPtr datalist)
	{
		return GLibGlobalFunctionsExterns.g_datalist_get_flags(datalist);
	}

	public static IntPtr DatalistIdDupData(IntPtr datalist, MentorLake.GLib.GQuark key_id, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_dup_data(datalist, key_id, dup_func, user_data);
	}

	public static IntPtr DatalistIdGetData(IntPtr datalist, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_get_data(datalist, key_id);
	}

	public static void DatalistIdRemoveMultiple(IntPtr datalist, MentorLake.GLib.GQuark[] keys, UIntPtr n_keys)
	{
		GLibGlobalFunctionsExterns.g_datalist_id_remove_multiple(datalist, keys, n_keys);
	}

	public static IntPtr DatalistIdRemoveNoNotify(IntPtr datalist, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_remove_no_notify(datalist, key_id);
	}

	public static bool DatalistIdReplaceData(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_replace_data(datalist, key_id, oldval, newval, destroy, out old_destroy);
	}

	public static void DatalistIdSetDataFull(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		GLibGlobalFunctionsExterns.g_datalist_id_set_data_full(datalist, key_id, data, destroy_func);
	}

	public static void DatalistInit(IntPtr datalist)
	{
		GLibGlobalFunctionsExterns.g_datalist_init(datalist);
	}

	public static void DatalistSetFlags(IntPtr datalist, uint flags)
	{
		GLibGlobalFunctionsExterns.g_datalist_set_flags(datalist, flags);
	}

	public static void DatalistUnsetFlags(IntPtr datalist, uint flags)
	{
		GLibGlobalFunctionsExterns.g_datalist_unset_flags(datalist, flags);
	}

	public static void DatasetDestroy(IntPtr dataset_location)
	{
		GLibGlobalFunctionsExterns.g_dataset_destroy(dataset_location);
	}

	public static void DatasetForeach(IntPtr dataset_location, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_dataset_foreach(dataset_location, func, user_data);
	}

	public static IntPtr DatasetIdGetData(IntPtr dataset_location, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_dataset_id_get_data(dataset_location, key_id);
	}

	public static IntPtr DatasetIdRemoveNoNotify(IntPtr dataset_location, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_dataset_id_remove_no_notify(dataset_location, key_id);
	}

	public static void DatasetIdSetDataFull(IntPtr dataset_location, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		GLibGlobalFunctionsExterns.g_dataset_id_set_data_full(dataset_location, key_id, data, destroy_func);
	}

	public static byte DateGetDaysInMonth(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_get_days_in_month(month, year);
	}

	public static byte DateGetMondayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_get_monday_weeks_in_year(year);
	}

	public static byte DateGetSundayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_get_sunday_weeks_in_year(year);
	}

	public static bool DateIsLeapYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_is_leap_year(year);
	}

	public static UIntPtr DateStrftime(string s, UIntPtr slen, string format, MentorLake.GLib.GDateHandle date)
	{
		return GLibGlobalFunctionsExterns.g_date_strftime(s, slen, format, date);
	}

	public static bool DateValidDay(MentorLake.GLib.GDateDay day)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_day(day);
	}

	public static bool DateValidDmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_dmy(day, month, year);
	}

	public static bool DateValidJulian(uint julian_date)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_julian(julian_date);
	}

	public static bool DateValidMonth(MentorLake.GLib.GDateMonth month)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_month(month);
	}

	public static bool DateValidWeekday(MentorLake.GLib.GDateWeekday weekday)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_weekday(weekday);
	}

	public static bool DateValidYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_year(year);
	}

	public static string Dcgettext(string domain, string msgid, int category)
	{
		return GLibGlobalFunctionsExterns.g_dcgettext(domain, msgid, category);
	}

	public static string Dgettext(string domain, string msgid)
	{
		return GLibGlobalFunctionsExterns.g_dgettext(domain, msgid);
	}

	public static string DirMakeTmp(string tmpl)
	{
		return GLibGlobalFunctionsExterns.g_dir_make_tmp(tmpl);
	}

	public static bool DirectEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_direct_equal(v1, v2);
	}

	public static uint DirectHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_direct_hash(v);
	}

	public static string Dngettext(string domain, string msgid, string msgid_plural, ulong n)
	{
		return GLibGlobalFunctionsExterns.g_dngettext(domain, msgid, msgid_plural, n);
	}

	public static bool DoubleEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_double_equal(v1, v2);
	}

	public static uint DoubleHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_double_hash(v);
	}

	public static string Dpgettext(string domain, string msgctxtid, UIntPtr msgidoffset)
	{
		return GLibGlobalFunctionsExterns.g_dpgettext(domain, msgctxtid, msgidoffset);
	}

	public static string Dpgettext2(string domain, string context, string msgid)
	{
		return GLibGlobalFunctionsExterns.g_dpgettext2(domain, context, msgid);
	}

	public static string EnvironGetenv(string[] envp, string variable)
	{
		return GLibGlobalFunctionsExterns.g_environ_getenv(envp, variable);
	}

	public static string[] EnvironSetenv(string[] envp, string variable, string value, bool overwrite)
	{
		return GLibGlobalFunctionsExterns.g_environ_setenv(envp, variable, value, overwrite);
	}

	public static string[] EnvironUnsetenv(string[] envp, string variable)
	{
		return GLibGlobalFunctionsExterns.g_environ_unsetenv(envp, variable);
	}

	public static MentorLake.GLib.GQuark ErrorDomainRegister(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GLibGlobalFunctionsExterns.g_error_domain_register(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

	public static MentorLake.GLib.GQuark ErrorDomainRegisterStatic(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GLibGlobalFunctionsExterns.g_error_domain_register_static(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

	public static int FdwalkSetCloexec(int lowfd)
	{
		return GLibGlobalFunctionsExterns.g_fdwalk_set_cloexec(lowfd);
	}

	public static MentorLake.GLib.GFileError FileErrorFromErrno(int err_no)
	{
		return GLibGlobalFunctionsExterns.g_file_error_from_errno(err_no);
	}

	public static MentorLake.GLib.GQuark FileErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_file_error_quark();
	}

	public static bool FileGetContents(string filename, out byte[] contents, out UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_file_get_contents(filename, out contents, out length);
	}

	public static int FileOpenTmp(string tmpl, out string name_used)
	{
		return GLibGlobalFunctionsExterns.g_file_open_tmp(tmpl, out name_used);
	}

	public static string FileReadLink(string filename)
	{
		return GLibGlobalFunctionsExterns.g_file_read_link(filename);
	}

	public static bool FileSetContents(string filename, byte[] contents, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_file_set_contents(filename, contents, length);
	}

	public static bool FileSetContentsFull(string filename, byte[] contents, UIntPtr length, MentorLake.GLib.GFileSetContentsFlags flags, int mode)
	{
		return GLibGlobalFunctionsExterns.g_file_set_contents_full(filename, contents, length, flags, mode);
	}

	public static bool FileTest(string filename, MentorLake.GLib.GFileTest test)
	{
		return GLibGlobalFunctionsExterns.g_file_test(filename, test);
	}

	public static string FilenameDisplayBasename(string filename)
	{
		return GLibGlobalFunctionsExterns.g_filename_display_basename(filename);
	}

	public static string FilenameDisplayName(string filename)
	{
		return GLibGlobalFunctionsExterns.g_filename_display_name(filename);
	}

	public static string FilenameFromUri(string uri, out string hostname)
	{
		return GLibGlobalFunctionsExterns.g_filename_from_uri(uri, out hostname);
	}

	public static string FilenameFromUtf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_filename_from_utf8(utf8string, len, out bytes_read, out bytes_written);
	}

	public static string FilenameToUri(string filename, string hostname)
	{
		return GLibGlobalFunctionsExterns.g_filename_to_uri(filename, hostname);
	}

	public static string FilenameToUtf8(string opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_filename_to_utf8(opsysstring, len, out bytes_read, out bytes_written);
	}

	public static string FindProgramInPath(string program)
	{
		return GLibGlobalFunctionsExterns.g_find_program_in_path(program);
	}

	public static IntPtr Fopen(string filename, string mode)
	{
		return GLibGlobalFunctionsExterns.g_fopen(filename, mode);
	}

	public static string FormatSize(ulong size)
	{
		return GLibGlobalFunctionsExterns.g_format_size(size);
	}

	public static string FormatSizeForDisplay(int size)
	{
		return GLibGlobalFunctionsExterns.g_format_size_for_display(size);
	}

	public static string FormatSizeFull(ulong size, MentorLake.GLib.GFormatSizeFlags flags)
	{
		return GLibGlobalFunctionsExterns.g_format_size_full(size, flags);
	}

	public static int Fprintf(IntPtr file, string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_fprintf(file, format, @__arglist);
	}

	public static void Free(IntPtr mem)
	{
		GLibGlobalFunctionsExterns.g_free(mem);
	}

	public static void FreeSized(IntPtr mem, UIntPtr size)
	{
		GLibGlobalFunctionsExterns.g_free_sized(mem, size);
	}

	public static IntPtr Freopen(string filename, string mode, IntPtr stream)
	{
		return GLibGlobalFunctionsExterns.g_freopen(filename, mode, stream);
	}

	public static int Fsync(int fd)
	{
		return GLibGlobalFunctionsExterns.g_fsync(fd);
	}

	public static string GetApplicationName()
	{
		return GLibGlobalFunctionsExterns.g_get_application_name();
	}

	public static bool GetCharset(out string charset)
	{
		return GLibGlobalFunctionsExterns.g_get_charset(out charset);
	}

	public static string GetCodeset()
	{
		return GLibGlobalFunctionsExterns.g_get_codeset();
	}

	public static bool GetConsoleCharset(out string charset)
	{
		return GLibGlobalFunctionsExterns.g_get_console_charset(out charset);
	}

	public static string GetCurrentDir()
	{
		return GLibGlobalFunctionsExterns.g_get_current_dir();
	}

	public static void GetCurrentTime(MentorLake.GLib.GTimeValHandle result)
	{
		GLibGlobalFunctionsExterns.g_get_current_time(result);
	}

	public static string[] GetEnviron()
	{
		return GLibGlobalFunctionsExterns.g_get_environ();
	}

	public static bool GetFilenameCharsets(out string[] filename_charsets)
	{
		return GLibGlobalFunctionsExterns.g_get_filename_charsets(out filename_charsets);
	}

	public static string GetHomeDir()
	{
		return GLibGlobalFunctionsExterns.g_get_home_dir();
	}

	public static string GetHostName()
	{
		return GLibGlobalFunctionsExterns.g_get_host_name();
	}

	public static string[] GetLanguageNames()
	{
		return GLibGlobalFunctionsExterns.g_get_language_names();
	}

	public static string[] GetLanguageNamesWithCategory(string category_name)
	{
		return GLibGlobalFunctionsExterns.g_get_language_names_with_category(category_name);
	}

	public static string[] GetLocaleVariants(string locale)
	{
		return GLibGlobalFunctionsExterns.g_get_locale_variants(locale);
	}

	public static long GetMonotonicTime()
	{
		return GLibGlobalFunctionsExterns.g_get_monotonic_time();
	}

	public static uint GetNumProcessors()
	{
		return GLibGlobalFunctionsExterns.g_get_num_processors();
	}

	public static string GetOsInfo(string key_name)
	{
		return GLibGlobalFunctionsExterns.g_get_os_info(key_name);
	}

	public static string GetPrgname()
	{
		return GLibGlobalFunctionsExterns.g_get_prgname();
	}

	public static string GetRealName()
	{
		return GLibGlobalFunctionsExterns.g_get_real_name();
	}

	public static long GetRealTime()
	{
		return GLibGlobalFunctionsExterns.g_get_real_time();
	}

	public static string[] GetSystemConfigDirs()
	{
		return GLibGlobalFunctionsExterns.g_get_system_config_dirs();
	}

	public static string[] GetSystemDataDirs()
	{
		return GLibGlobalFunctionsExterns.g_get_system_data_dirs();
	}

	public static string GetTmpDir()
	{
		return GLibGlobalFunctionsExterns.g_get_tmp_dir();
	}

	public static string GetUserCacheDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_cache_dir();
	}

	public static string GetUserConfigDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_config_dir();
	}

	public static string GetUserDataDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_data_dir();
	}

	public static string GetUserName()
	{
		return GLibGlobalFunctionsExterns.g_get_user_name();
	}

	public static string GetUserRuntimeDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_runtime_dir();
	}

	public static string GetUserSpecialDir(MentorLake.GLib.GUserDirectory directory)
	{
		return GLibGlobalFunctionsExterns.g_get_user_special_dir(directory);
	}

	public static string GetUserStateDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_state_dir();
	}

	public static string Getenv(string variable)
	{
		return GLibGlobalFunctionsExterns.g_getenv(variable);
	}

	public static bool HashTableAdd(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_add(hash_table, key);
	}

	public static bool HashTableContains(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_contains(hash_table, key);
	}

	public static void HashTableDestroy(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_destroy(hash_table);
	}

	public static IntPtr HashTableFind(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_find(hash_table, predicate, user_data);
	}

	public static void HashTableForeach(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_hash_table_foreach(hash_table, func, user_data);
	}

	public static uint HashTableForeachRemove(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_foreach_remove(hash_table, func, user_data);
	}

	public static uint HashTableForeachSteal(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_foreach_steal(hash_table, func, user_data);
	}

	public static MentorLake.GLib.GPtrArrayHandle HashTableGetKeysAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_get_keys_as_ptr_array(hash_table);
	}

	public static MentorLake.GLib.GPtrArrayHandle HashTableGetValuesAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_get_values_as_ptr_array(hash_table);
	}

	public static bool HashTableInsert(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_insert(hash_table, key, value);
	}

	public static IntPtr HashTableLookup(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_lookup(hash_table, key);
	}

	public static bool HashTableLookupExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_lookup_extended(hash_table, lookup_key, out orig_key, out value);
	}

	public static MentorLake.GLib.GHashTableHandle HashTableNewSimilar(MentorLake.GLib.GHashTableHandle other_hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_new_similar(other_hash_table);
	}

	public static MentorLake.GLib.GHashTableHandle HashTableRef(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_ref(hash_table);
	}

	public static bool HashTableRemove(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_remove(hash_table, key);
	}

	public static void HashTableRemoveAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_remove_all(hash_table);
	}

	public static bool HashTableReplace(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_replace(hash_table, key, value);
	}

	public static uint HashTableSize(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_size(hash_table);
	}

	public static bool HashTableSteal(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal(hash_table, key);
	}

	public static void HashTableStealAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_steal_all(hash_table);
	}

	public static MentorLake.GLib.GPtrArrayHandle HashTableStealAllKeys(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal_all_keys(hash_table);
	}

	public static MentorLake.GLib.GPtrArrayHandle HashTableStealAllValues(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal_all_values(hash_table);
	}

	public static bool HashTableStealExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal_extended(hash_table, lookup_key, out stolen_key, out stolen_value);
	}

	public static void HashTableUnref(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_unref(hash_table);
	}

	public static bool HookDestroy(MentorLake.GLib.GHookListHandle hook_list, ulong hook_id)
	{
		return GLibGlobalFunctionsExterns.g_hook_destroy(hook_list, hook_id);
	}

	public static void HookDestroyLink(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_destroy_link(hook_list, hook);
	}

	public static void HookFree(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_free(hook_list, hook);
	}

	public static void HookInsertBefore(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle sibling, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_insert_before(hook_list, sibling, hook);
	}

	public static void HookInsertSorted(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func)
	{
		GLibGlobalFunctionsExterns.g_hook_insert_sorted(hook_list, hook, func);
	}

	public static void HookPrepend(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_prepend(hook_list, hook);
	}

	public static void HookUnref(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_unref(hook_list, hook);
	}

	public static bool HostnameIsAsciiEncoded(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_is_ascii_encoded(hostname);
	}

	public static bool HostnameIsIpAddress(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_is_ip_address(hostname);
	}

	public static bool HostnameIsNonAscii(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_is_non_ascii(hostname);
	}

	public static string HostnameToAscii(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_to_ascii(hostname);
	}

	public static string HostnameToUnicode(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_to_unicode(hostname);
	}

	public static UIntPtr Iconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left)
	{
		return GLibGlobalFunctionsExterns.g_iconv(converter, inbuf, ref inbytes_left, outbuf, ref outbytes_left);
	}

	public static MentorLake.GLib.GIConv IconvOpen(string to_codeset, string from_codeset)
	{
		return GLibGlobalFunctionsExterns.g_iconv_open(to_codeset, from_codeset);
	}

	public static uint IdleAdd(MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_idle_add(function, data);
	}

	public static uint IdleAddFull(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_idle_add_full(priority, function, data, notify);
	}

	public static uint IdleAddOnce(MentorLake.GLib.GSourceOnceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_idle_add_once(function, data);
	}

	public static bool IdleRemoveByData(IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_idle_remove_by_data(data);
	}

	public static MentorLake.GLib.GSourceHandle IdleSourceNew()
	{
		return GLibGlobalFunctionsExterns.g_idle_source_new();
	}

	public static bool Int64Equal(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_int64_equal(v1, v2);
	}

	public static uint Int64Hash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_int64_hash(v);
	}

	public static bool IntEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_int_equal(v1, v2);
	}

	public static uint IntHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_int_hash(v);
	}

	public static string InternStaticString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_intern_static_string(@string);
	}

	public static string InternString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_intern_string(@string);
	}

	public static uint IoAddWatch(MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_io_add_watch(channel, condition, func, user_data);
	}

	public static uint IoAddWatchFull(MentorLake.GLib.GIOChannelHandle channel, int priority, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_io_add_watch_full(channel, priority, condition, func, user_data, notify);
	}

	public static MentorLake.GLib.GIOChannelError IoChannelErrorFromErrno(int en)
	{
		return GLibGlobalFunctionsExterns.g_io_channel_error_from_errno(en);
	}

	public static MentorLake.GLib.GQuark IoChannelErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_io_channel_error_quark();
	}

	public static MentorLake.GLib.GSourceHandle IoCreateWatch(MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition)
	{
		return GLibGlobalFunctionsExterns.g_io_create_watch(channel, condition);
	}

	public static MentorLake.GLib.GQuark KeyFileErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_key_file_error_quark();
	}

	public static void ListPopAllocator()
	{
		GLibGlobalFunctionsExterns.g_list_pop_allocator();
	}

	public static void ListPushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GLibGlobalFunctionsExterns.g_list_push_allocator(allocator);
	}

	public static string[] Listenv()
	{
		return GLibGlobalFunctionsExterns.g_listenv();
	}

	public static byte[] LocaleFromUtf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_locale_from_utf8(utf8string, len, out bytes_read, out bytes_written);
	}

	public static string LocaleToUtf8(byte[] opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		return GLibGlobalFunctionsExterns.g_locale_to_utf8(opsysstring, len, out bytes_read, out bytes_written);
	}

	public static void Log(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_log(log_domain, log_level, format, @__arglist);
	}

	public static void LogDefaultHandler(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr unused_data)
	{
		GLibGlobalFunctionsExterns.g_log_default_handler(log_domain, log_level, message, unused_data);
	}

	public static bool LogGetDebugEnabled()
	{
		return GLibGlobalFunctionsExterns.g_log_get_debug_enabled();
	}

	public static void LogRemoveHandler(string log_domain, uint handler_id)
	{
		GLibGlobalFunctionsExterns.g_log_remove_handler(log_domain, handler_id);
	}

	public static MentorLake.GLib.GLogLevelFlags LogSetAlwaysFatal(MentorLake.GLib.GLogLevelFlags fatal_mask)
	{
		return GLibGlobalFunctionsExterns.g_log_set_always_fatal(fatal_mask);
	}

	public static void LogSetDebugEnabled(bool enabled)
	{
		GLibGlobalFunctionsExterns.g_log_set_debug_enabled(enabled);
	}

	public static MentorLake.GLib.GLogFunc LogSetDefaultHandler(MentorLake.GLib.GLogFunc log_func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_set_default_handler(log_func, user_data);
	}

	public static MentorLake.GLib.GLogLevelFlags LogSetFatalMask(string log_domain, MentorLake.GLib.GLogLevelFlags fatal_mask)
	{
		return GLibGlobalFunctionsExterns.g_log_set_fatal_mask(log_domain, fatal_mask);
	}

	public static uint LogSetHandler(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_set_handler(log_domain, log_levels, log_func, user_data);
	}

	public static uint LogSetHandlerFull(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy)
	{
		return GLibGlobalFunctionsExterns.g_log_set_handler_full(log_domain, log_levels, log_func, user_data, destroy);
	}

	public static void LogSetWriterFunc(MentorLake.GLib.GLogWriterFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free)
	{
		GLibGlobalFunctionsExterns.g_log_set_writer_func(func, user_data, user_data_free);
	}

	public static void LogStructured(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_log_structured(log_domain, log_level, @__arglist);
	}

	public static void LogStructuredArray(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields)
	{
		GLibGlobalFunctionsExterns.g_log_structured_array(log_level, fields, n_fields);
	}

	public static void LogStructuredStandard(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string file, string line, string func, string message_format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_log_structured_standard(log_domain, log_level, file, line, func, message_format, @__arglist);
	}

	public static void LogVariant(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GVariantHandle fields)
	{
		GLibGlobalFunctionsExterns.g_log_variant(log_domain, log_level, fields);
	}

	public static MentorLake.GLib.GLogWriterOutput LogWriterDefault(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_default(log_level, fields, n_fields, user_data);
	}

	public static void LogWriterDefaultSetDebugDomains(string domains)
	{
		GLibGlobalFunctionsExterns.g_log_writer_default_set_debug_domains(domains);
	}

	public static void LogWriterDefaultSetUseStderr(bool use_stderr)
	{
		GLibGlobalFunctionsExterns.g_log_writer_default_set_use_stderr(use_stderr);
	}

	public static bool LogWriterDefaultWouldDrop(MentorLake.GLib.GLogLevelFlags log_level, string log_domain)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_default_would_drop(log_level, log_domain);
	}

	public static string LogWriterFormatFields(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, bool use_color)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_format_fields(log_level, fields, n_fields, use_color);
	}

	public static bool LogWriterIsJournald(int output_fd)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_is_journald(output_fd);
	}

	public static MentorLake.GLib.GLogWriterOutput LogWriterJournald(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_journald(log_level, fields, n_fields, user_data);
	}

	public static MentorLake.GLib.GLogWriterOutput LogWriterStandardStreams(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_standard_streams(log_level, fields, n_fields, user_data);
	}

	public static bool LogWriterSupportsColor(int output_fd)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_supports_color(output_fd);
	}

	public static MentorLake.GLib.GLogWriterOutput LogWriterSyslog(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_syslog(log_level, fields, n_fields, user_data);
	}

	public static void Logv(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr args)
	{
		GLibGlobalFunctionsExterns.g_logv(log_domain, log_level, format, args);
	}

	public static int Lstat(string filename, MentorLake.GLib.GStatBufHandle buf)
	{
		return GLibGlobalFunctionsExterns.g_lstat(filename, buf);
	}

	public static MentorLake.GLib.GMainContextHandle MainContextDefault()
	{
		return GLibGlobalFunctionsExterns.g_main_context_default();
	}

	public static MentorLake.GLib.GMainContextHandle MainContextGetThreadDefault()
	{
		return GLibGlobalFunctionsExterns.g_main_context_get_thread_default();
	}

	public static MentorLake.GLib.GMainContextHandle MainContextRefThreadDefault()
	{
		return GLibGlobalFunctionsExterns.g_main_context_ref_thread_default();
	}

	public static MentorLake.GLib.GSourceHandle MainCurrentSource()
	{
		return GLibGlobalFunctionsExterns.g_main_current_source();
	}

	public static int MainDepth()
	{
		return GLibGlobalFunctionsExterns.g_main_depth();
	}

	public static IntPtr Malloc(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc(n_bytes);
	}

	public static IntPtr Malloc0(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc0(n_bytes);
	}

	public static IntPtr Malloc0N(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc0_n(n_blocks, n_block_bytes);
	}

	public static IntPtr MallocN(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc_n(n_blocks, n_block_bytes);
	}

	public static bool MarkupCollectAttributes(string element_name, string attribute_names, string attribute_values, IntPtr error, MentorLake.GLib.GMarkupCollectType first_type, string first_attr, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_markup_collect_attributes(element_name, attribute_names, attribute_values, error, first_type, first_attr, @__arglist);
	}

	public static MentorLake.GLib.GQuark MarkupErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_markup_error_quark();
	}

	public static string MarkupEscapeText(string text, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_markup_escape_text(text, length);
	}

	public static string MarkupPrintfEscaped(string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_markup_printf_escaped(format, @__arglist);
	}

	public static string MarkupVprintfEscaped(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_markup_vprintf_escaped(format, args);
	}

	public static void MemChunkInfo()
	{
		GLibGlobalFunctionsExterns.g_mem_chunk_info();
	}

	public static bool MemIsSystemMalloc()
	{
		return GLibGlobalFunctionsExterns.g_mem_is_system_malloc();
	}

	public static void MemProfile()
	{
		GLibGlobalFunctionsExterns.g_mem_profile();
	}

	public static void MemSetVtable(MentorLake.GLib.GMemVTableHandle vtable)
	{
		GLibGlobalFunctionsExterns.g_mem_set_vtable(vtable);
	}

	public static IntPtr Memdup(IntPtr mem, uint byte_size)
	{
		return GLibGlobalFunctionsExterns.g_memdup(mem, byte_size);
	}

	public static IntPtr Memdup2(IntPtr mem, UIntPtr byte_size)
	{
		return GLibGlobalFunctionsExterns.g_memdup2(mem, byte_size);
	}

	public static int Mkdir(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkdir(filename, mode);
	}

	public static int MkdirWithParents(string pathname, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkdir_with_parents(pathname, mode);
	}

	public static string Mkdtemp(string tmpl)
	{
		return GLibGlobalFunctionsExterns.g_mkdtemp(tmpl);
	}

	public static string MkdtempFull(string tmpl, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkdtemp_full(tmpl, mode);
	}

	public static int Mkstemp(string tmpl)
	{
		return GLibGlobalFunctionsExterns.g_mkstemp(tmpl);
	}

	public static int MkstempFull(string tmpl, int flags, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkstemp_full(tmpl, flags, mode);
	}

	public static MentorLake.GLib.GMutexHandle MutexNew()
	{
		return GLibGlobalFunctionsExterns.g_mutex_new();
	}

	public static void NodePopAllocator()
	{
		GLibGlobalFunctionsExterns.g_node_pop_allocator();
	}

	public static void NodePushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GLibGlobalFunctionsExterns.g_node_push_allocator(allocator);
	}

	public static void NullifyPointer(IntPtr nullify_location)
	{
		GLibGlobalFunctionsExterns.g_nullify_pointer(nullify_location);
	}

	public static MentorLake.GLib.GQuark NumberParserErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_number_parser_error_quark();
	}

	public static void OnErrorQuery(string prg_name)
	{
		GLibGlobalFunctionsExterns.g_on_error_query(prg_name);
	}

	public static void OnErrorStackTrace(string prg_name)
	{
		GLibGlobalFunctionsExterns.g_on_error_stack_trace(prg_name);
	}

	public static bool OnceInitEnter(ref IntPtr location)
	{
		return GLibGlobalFunctionsExterns.g_once_init_enter(ref location);
	}

	public static bool OnceInitEnterImpl(UIntPtr location)
	{
		return GLibGlobalFunctionsExterns.g_once_init_enter_impl(location);
	}

	public static bool OnceInitEnterPointer(IntPtr location)
	{
		return GLibGlobalFunctionsExterns.g_once_init_enter_pointer(location);
	}

	public static void OnceInitLeave(ref IntPtr location, UIntPtr result)
	{
		GLibGlobalFunctionsExterns.g_once_init_leave(ref location, result);
	}

	public static void OnceInitLeavePointer(IntPtr location, IntPtr result)
	{
		GLibGlobalFunctionsExterns.g_once_init_leave_pointer(location, result);
	}

	public static int Open(string filename, int flags, int mode)
	{
		return GLibGlobalFunctionsExterns.g_open(filename, flags, mode);
	}

	public static MentorLake.GLib.GQuark OptionErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_option_error_quark();
	}

	public static uint ParseDebugString(string @string, MentorLake.GLib.GDebugKey[] keys, uint nkeys)
	{
		return GLibGlobalFunctionsExterns.g_parse_debug_string(@string, keys, nkeys);
	}

	public static bool PathBufEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_path_buf_equal(v1, v2);
	}

	public static string PathGetBasename(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_get_basename(file_name);
	}

	public static string PathGetDirname(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_get_dirname(file_name);
	}

	public static bool PathIsAbsolute(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_is_absolute(file_name);
	}

	public static string PathSkipRoot(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_skip_root(file_name);
	}

	public static bool PatternMatch(MentorLake.GLib.GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed)
	{
		return GLibGlobalFunctionsExterns.g_pattern_match(pspec, string_length, @string, string_reversed);
	}

	public static bool PatternMatchSimple(string pattern, string @string)
	{
		return GLibGlobalFunctionsExterns.g_pattern_match_simple(pattern, @string);
	}

	public static bool PatternMatchString(MentorLake.GLib.GPatternSpecHandle pspec, string @string)
	{
		return GLibGlobalFunctionsExterns.g_pattern_match_string(pspec, @string);
	}

	public static void PointerBitLock(IntPtr address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_lock(address, lock_bit);
	}

	public static void PointerBitLockAndGet(IntPtr address, uint lock_bit, out uint out_ptr)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_lock_and_get(address, lock_bit, out out_ptr);
	}

	public static IntPtr PointerBitLockMaskPtr(IntPtr ptr, uint lock_bit, bool set, uint preserve_mask, IntPtr preserve_ptr)
	{
		return GLibGlobalFunctionsExterns.g_pointer_bit_lock_mask_ptr(ptr, lock_bit, set, preserve_mask, preserve_ptr);
	}

	public static bool PointerBitTrylock(IntPtr address, int lock_bit)
	{
		return GLibGlobalFunctionsExterns.g_pointer_bit_trylock(address, lock_bit);
	}

	public static void PointerBitUnlock(IntPtr address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_unlock(address, lock_bit);
	}

	public static void PointerBitUnlockAndSet(IntPtr address, uint lock_bit, IntPtr ptr, uint preserve_mask)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_unlock_and_set(address, lock_bit, ptr, preserve_mask);
	}

	public static int Poll(MentorLake.GLib.GPollFDHandle fds, uint nfds, int timeout)
	{
		return GLibGlobalFunctionsExterns.g_poll(fds, nfds, timeout);
	}

	public static void PrefixError(ref MentorLake.GLib.GErrorHandle err, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_prefix_error(ref err, format, @__arglist);
	}

	public static void PrefixErrorLiteral(ref MentorLake.GLib.GErrorHandle err, string prefix)
	{
		GLibGlobalFunctionsExterns.g_prefix_error_literal(ref err, prefix);
	}

	public static void Print(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_print(format, @__arglist);
	}

	public static void Printerr(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_printerr(format, @__arglist);
	}

	public static int Printf(string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_printf(format, @__arglist);
	}

	public static UIntPtr PrintfStringUpperBound(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_printf_string_upper_bound(format, args);
	}

	public static MentorLake.GLib.GPrivateHandle PrivateNew(MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_private_new(notify);
	}

	public static void PropagateError(out MentorLake.GLib.GErrorHandle dest, MentorLake.GLib.GErrorHandle src)
	{
		GLibGlobalFunctionsExterns.g_propagate_error(out dest, src);
	}

	public static void PropagatePrefixedError(IntPtr dest, MentorLake.GLib.GErrorHandle src, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_propagate_prefixed_error(dest, src, format, @__arglist);
	}

	public static bool PtrArrayFind(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_find(haystack, needle, out index_);
	}

	public static bool PtrArrayFindWithEqualFunc(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_find_with_equal_func(haystack, needle, equal_func, out index_);
	}

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewFromArray(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_from_array(data, len, copy_func, copy_func_user_data, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewFromNullTerminatedArray(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_from_null_terminated_array(data, copy_func, copy_func_user_data, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewTake(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_take(data, len, element_free_func);
	}

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewTakeNullTerminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_take_null_terminated(data, element_free_func);
	}

	public static void QsortWithData(IntPtr pbase, int total_elems, UIntPtr size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_qsort_with_data(pbase, total_elems, size, compare_func, user_data);
	}

	public static MentorLake.GLib.GQuark QuarkFromStaticString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_quark_from_static_string(@string);
	}

	public static MentorLake.GLib.GQuark QuarkFromString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_quark_from_string(@string);
	}

	public static string QuarkToString(MentorLake.GLib.GQuark quark)
	{
		return GLibGlobalFunctionsExterns.g_quark_to_string(quark);
	}

	public static MentorLake.GLib.GQuark QuarkTryString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_quark_try_string(@string);
	}

	public static double RandomDouble()
	{
		return GLibGlobalFunctionsExterns.g_random_double();
	}

	public static double RandomDoubleRange(double begin, double end)
	{
		return GLibGlobalFunctionsExterns.g_random_double_range(begin, end);
	}

	public static uint RandomInt()
	{
		return GLibGlobalFunctionsExterns.g_random_int();
	}

	public static int RandomIntRange(int begin, int end)
	{
		return GLibGlobalFunctionsExterns.g_random_int_range(begin, end);
	}

	public static void RandomSetSeed(uint seed)
	{
		GLibGlobalFunctionsExterns.g_random_set_seed(seed);
	}

	public static IntPtr RcBoxAcquire(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_acquire(mem_block);
	}

	public static IntPtr RcBoxAlloc(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_alloc(block_size);
	}

	public static IntPtr RcBoxAlloc0(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_alloc0(block_size);
	}

	public static IntPtr RcBoxDup(UIntPtr block_size, IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_dup(block_size, mem_block);
	}

	public static UIntPtr RcBoxGetSize(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_get_size(mem_block);
	}

	public static void RcBoxRelease(IntPtr mem_block)
	{
		GLibGlobalFunctionsExterns.g_rc_box_release(mem_block);
	}

	public static void RcBoxReleaseFull(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func)
	{
		GLibGlobalFunctionsExterns.g_rc_box_release_full(mem_block, clear_func);
	}

	public static IntPtr Realloc(IntPtr mem, UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_realloc(mem, n_bytes);
	}

	public static IntPtr ReallocN(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_realloc_n(mem, n_blocks, n_block_bytes);
	}

	public static bool RefCountCompare(int rc, int val)
	{
		return GLibGlobalFunctionsExterns.g_ref_count_compare(rc, val);
	}

	public static bool RefCountDec(int rc)
	{
		return GLibGlobalFunctionsExterns.g_ref_count_dec(rc);
	}

	public static void RefCountInc(int rc)
	{
		GLibGlobalFunctionsExterns.g_ref_count_inc(rc);
	}

	public static void RefCountInit(int rc)
	{
		GLibGlobalFunctionsExterns.g_ref_count_init(rc);
	}

	public static string RefStringAcquire(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_acquire(str);
	}

	public static bool RefStringEqual(string str1, string str2)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_equal(str1, str2);
	}

	public static UIntPtr RefStringLength(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_length(str);
	}

	public static string RefStringNew(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_new(str);
	}

	public static string RefStringNewIntern(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_new_intern(str);
	}

	public static string RefStringNewLen(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_new_len(str, len);
	}

	public static void RefStringRelease(string str)
	{
		GLibGlobalFunctionsExterns.g_ref_string_release(str);
	}

	public static bool RegexCheckReplacement(string replacement, out bool has_references)
	{
		return GLibGlobalFunctionsExterns.g_regex_check_replacement(replacement, out has_references);
	}

	public static MentorLake.GLib.GQuark RegexErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_regex_error_quark();
	}

	public static string RegexEscapeNul(string @string, int length)
	{
		return GLibGlobalFunctionsExterns.g_regex_escape_nul(@string, length);
	}

	public static string RegexEscapeString(string @string, int length)
	{
		return GLibGlobalFunctionsExterns.g_regex_escape_string(@string, length);
	}

	public static bool RegexMatchSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GLibGlobalFunctionsExterns.g_regex_match_simple(pattern, @string, compile_options, match_options);
	}

	public static string[] RegexSplitSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GLibGlobalFunctionsExterns.g_regex_split_simple(pattern, @string, compile_options, match_options);
	}

	public static void ReloadUserSpecialDirsCache()
	{
		GLibGlobalFunctionsExterns.g_reload_user_special_dirs_cache();
	}

	public static int Remove(string filename)
	{
		return GLibGlobalFunctionsExterns.g_remove(filename);
	}

	public static int Rename(string oldfilename, string newfilename)
	{
		return GLibGlobalFunctionsExterns.g_rename(oldfilename, newfilename);
	}

	public static void ReturnIfFailWarning(string log_domain, string pretty_function, string expression)
	{
		GLibGlobalFunctionsExterns.g_return_if_fail_warning(log_domain, pretty_function, expression);
	}

	public static int Rmdir(string filename)
	{
		return GLibGlobalFunctionsExterns.g_rmdir(filename);
	}

	public static void SequenceForeachRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_sequence_foreach_range(begin, end, func, user_data);
	}

	public static IntPtr SequenceGet(MentorLake.GLib.GSequenceIterHandle iter)
	{
		return GLibGlobalFunctionsExterns.g_sequence_get(iter);
	}

	public static MentorLake.GLib.GSequenceIterHandle SequenceInsertBefore(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_sequence_insert_before(iter, data);
	}

	public static void SequenceMove(MentorLake.GLib.GSequenceIterHandle src, MentorLake.GLib.GSequenceIterHandle dest)
	{
		GLibGlobalFunctionsExterns.g_sequence_move(src, dest);
	}

	public static void SequenceMoveRange(MentorLake.GLib.GSequenceIterHandle dest, MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GLibGlobalFunctionsExterns.g_sequence_move_range(dest, begin, end);
	}

	public static MentorLake.GLib.GSequenceIterHandle SequenceRangeGetMidpoint(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		return GLibGlobalFunctionsExterns.g_sequence_range_get_midpoint(begin, end);
	}

	public static void SequenceRemove(MentorLake.GLib.GSequenceIterHandle iter)
	{
		GLibGlobalFunctionsExterns.g_sequence_remove(iter);
	}

	public static void SequenceRemoveRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GLibGlobalFunctionsExterns.g_sequence_remove_range(begin, end);
	}

	public static void SequenceSet(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		GLibGlobalFunctionsExterns.g_sequence_set(iter, data);
	}

	public static void SequenceSortChanged(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		GLibGlobalFunctionsExterns.g_sequence_sort_changed(iter, cmp_func, cmp_data);
	}

	public static void SequenceSortChangedIter(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		GLibGlobalFunctionsExterns.g_sequence_sort_changed_iter(iter, iter_cmp, cmp_data);
	}

	public static void SequenceSwap(MentorLake.GLib.GSequenceIterHandle a, MentorLake.GLib.GSequenceIterHandle b)
	{
		GLibGlobalFunctionsExterns.g_sequence_swap(a, b);
	}

	public static void SetApplicationName(string application_name)
	{
		GLibGlobalFunctionsExterns.g_set_application_name(application_name);
	}

	public static void SetError(out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_set_error(out err, domain, code, format, @__arglist);
	}

	public static void SetErrorLiteral(out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string message)
	{
		GLibGlobalFunctionsExterns.g_set_error_literal(out err, domain, code, message);
	}

	public static void SetPrgname(string prgname)
	{
		GLibGlobalFunctionsExterns.g_set_prgname(prgname);
	}

	public static MentorLake.GLib.GPrintFunc SetPrintHandler(MentorLake.GLib.GPrintFunc func)
	{
		return GLibGlobalFunctionsExterns.g_set_print_handler(func);
	}

	public static MentorLake.GLib.GPrintFunc SetPrinterrHandler(MentorLake.GLib.GPrintFunc func)
	{
		return GLibGlobalFunctionsExterns.g_set_printerr_handler(func);
	}

	public static bool Setenv(string variable, string value, bool overwrite)
	{
		return GLibGlobalFunctionsExterns.g_setenv(variable, value, overwrite);
	}

	public static MentorLake.GLib.GQuark ShellErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_shell_error_quark();
	}

	public static bool ShellParseArgv(string command_line, out int argcp, out string[] argvp)
	{
		return GLibGlobalFunctionsExterns.g_shell_parse_argv(command_line, out argcp, out argvp);
	}

	public static string ShellQuote(string unquoted_string)
	{
		return GLibGlobalFunctionsExterns.g_shell_quote(unquoted_string);
	}

	public static string ShellUnquote(string quoted_string)
	{
		return GLibGlobalFunctionsExterns.g_shell_unquote(quoted_string);
	}

	public static IntPtr SliceAlloc(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_slice_alloc(block_size);
	}

	public static IntPtr SliceAlloc0(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_slice_alloc0(block_size);
	}

	public static IntPtr SliceCopy(UIntPtr block_size, IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_slice_copy(block_size, mem_block);
	}

	public static void SliceFree1(UIntPtr block_size, IntPtr mem_block)
	{
		GLibGlobalFunctionsExterns.g_slice_free1(block_size, mem_block);
	}

	public static void SliceFreeChainWithOffset(UIntPtr block_size, IntPtr mem_chain, UIntPtr next_offset)
	{
		GLibGlobalFunctionsExterns.g_slice_free_chain_with_offset(block_size, mem_chain, next_offset);
	}

	public static long SliceGetConfig(MentorLake.GLib.GSliceConfig ckey)
	{
		return GLibGlobalFunctionsExterns.g_slice_get_config(ckey);
	}

	public static long SliceGetConfigState(MentorLake.GLib.GSliceConfig ckey, long address, uint n_values)
	{
		return GLibGlobalFunctionsExterns.g_slice_get_config_state(ckey, address, n_values);
	}

	public static void SliceSetConfig(MentorLake.GLib.GSliceConfig ckey, long value)
	{
		GLibGlobalFunctionsExterns.g_slice_set_config(ckey, value);
	}

	public static void SlistPopAllocator()
	{
		GLibGlobalFunctionsExterns.g_slist_pop_allocator();
	}

	public static void SlistPushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GLibGlobalFunctionsExterns.g_slist_push_allocator(allocator);
	}

	public static int Snprintf(string @string, ulong n, string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_snprintf(@string, n, format, @__arglist);
	}

	public static void SortArray(IntPtr[] array, UIntPtr n_elements, UIntPtr element_size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_sort_array(array, n_elements, element_size, compare_func, user_data);
	}

	public static bool SourceRemove(uint tag)
	{
		return GLibGlobalFunctionsExterns.g_source_remove(tag);
	}

	public static bool SourceRemoveByFuncsUserData(MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_source_remove_by_funcs_user_data(funcs, user_data);
	}

	public static bool SourceRemoveByUserData(IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_source_remove_by_user_data(user_data);
	}

	public static void SourceSetNameById(uint tag, string name)
	{
		GLibGlobalFunctionsExterns.g_source_set_name_by_id(tag, name);
	}

	public static uint SpacedPrimesClosest(uint num)
	{
		return GLibGlobalFunctionsExterns.g_spaced_primes_closest(num);
	}

	public static bool SpawnAsync(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid)
	{
		return GLibGlobalFunctionsExterns.g_spawn_async(working_directory, argv, envp, flags, child_setup, user_data, out child_pid);
	}

	public static bool SpawnAsyncWithFds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, int stdin_fd, int stdout_fd, int stderr_fd)
	{
		return GLibGlobalFunctionsExterns.g_spawn_async_with_fds(working_directory, argv, envp, flags, child_setup, user_data, out child_pid, stdin_fd, stdout_fd, stderr_fd);
	}

	public static bool SpawnAsyncWithPipes(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, out int standard_input, out int standard_output, out int standard_error)
	{
		return GLibGlobalFunctionsExterns.g_spawn_async_with_pipes(working_directory, argv, envp, flags, child_setup, user_data, out child_pid, out standard_input, out standard_output, out standard_error);
	}

	public static bool SpawnAsyncWithPipesAndFds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, int stdin_fd, int stdout_fd, int stderr_fd, int[] source_fds, int[] target_fds, UIntPtr n_fds, out MentorLake.GLib.GPid child_pid_out, out int stdin_pipe_out, out int stdout_pipe_out, out int stderr_pipe_out)
	{
		return GLibGlobalFunctionsExterns.g_spawn_async_with_pipes_and_fds(working_directory, argv, envp, flags, child_setup, user_data, stdin_fd, stdout_fd, stderr_fd, source_fds, target_fds, n_fds, out child_pid_out, out stdin_pipe_out, out stdout_pipe_out, out stderr_pipe_out);
	}

	public static bool SpawnCheckExitStatus(int wait_status)
	{
		return GLibGlobalFunctionsExterns.g_spawn_check_exit_status(wait_status);
	}

	public static bool SpawnCheckWaitStatus(int wait_status)
	{
		return GLibGlobalFunctionsExterns.g_spawn_check_wait_status(wait_status);
	}

	public static void SpawnClosePid(MentorLake.GLib.GPid pid)
	{
		GLibGlobalFunctionsExterns.g_spawn_close_pid(pid);
	}

	public static bool SpawnCommandLineAsync(string command_line)
	{
		return GLibGlobalFunctionsExterns.g_spawn_command_line_async(command_line);
	}

	public static bool SpawnCommandLineSync(string command_line, out byte[] standard_output, out byte[] standard_error, out int wait_status)
	{
		return GLibGlobalFunctionsExterns.g_spawn_command_line_sync(command_line, out standard_output, out standard_error, out wait_status);
	}

	public static MentorLake.GLib.GQuark SpawnErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_spawn_error_quark();
	}

	public static MentorLake.GLib.GQuark SpawnExitErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_spawn_exit_error_quark();
	}

	public static bool SpawnSync(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out byte[] standard_output, out byte[] standard_error, out int wait_status)
	{
		return GLibGlobalFunctionsExterns.g_spawn_sync(working_directory, argv, envp, flags, child_setup, user_data, out standard_output, out standard_error, out wait_status);
	}

	public static int Sprintf(string @string, string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_sprintf(@string, format, @__arglist);
	}

	public static int Stat(string filename, MentorLake.GLib.GStatBufHandle buf)
	{
		return GLibGlobalFunctionsExterns.g_stat(filename, buf);
	}

	public static string Stpcpy(string dest, string src)
	{
		return GLibGlobalFunctionsExterns.g_stpcpy(dest, src);
	}

	public static bool StrEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_str_equal(v1, v2);
	}

	public static bool StrHasPrefix(string str, string prefix)
	{
		return GLibGlobalFunctionsExterns.g_str_has_prefix(str, prefix);
	}

	public static bool StrHasSuffix(string str, string suffix)
	{
		return GLibGlobalFunctionsExterns.g_str_has_suffix(str, suffix);
	}

	public static uint StrHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_str_hash(v);
	}

	public static bool StrIsAscii(string str)
	{
		return GLibGlobalFunctionsExterns.g_str_is_ascii(str);
	}

	public static bool StrMatchString(string search_term, string potential_hit, bool accept_alternates)
	{
		return GLibGlobalFunctionsExterns.g_str_match_string(search_term, potential_hit, accept_alternates);
	}

	public static string StrToAscii(string str, string from_locale)
	{
		return GLibGlobalFunctionsExterns.g_str_to_ascii(str, from_locale);
	}

	public static string[] StrTokenizeAndFold(string @string, string translit_locale, out string[] ascii_alternates)
	{
		return GLibGlobalFunctionsExterns.g_str_tokenize_and_fold(@string, translit_locale, out ascii_alternates);
	}

	public static string Strcanon(string @string, string valid_chars, char substitutor)
	{
		return GLibGlobalFunctionsExterns.g_strcanon(@string, valid_chars, substitutor);
	}

	public static int Strcasecmp(string s1, string s2)
	{
		return GLibGlobalFunctionsExterns.g_strcasecmp(s1, s2);
	}

	public static string Strchomp(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strchomp(@string);
	}

	public static string Strchug(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strchug(@string);
	}

	public static int Strcmp0(string str1, string str2)
	{
		return GLibGlobalFunctionsExterns.g_strcmp0(str1, str2);
	}

	public static string Strcompress(string source)
	{
		return GLibGlobalFunctionsExterns.g_strcompress(source);
	}

	public static string Strconcat(string string1, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_strconcat(string1, @__arglist);
	}

	public static string Strdelimit(string @string, string delimiters, char new_delimiter)
	{
		return GLibGlobalFunctionsExterns.g_strdelimit(@string, delimiters, new_delimiter);
	}

	public static string Strdown(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strdown(@string);
	}

	public static string Strdup(string str)
	{
		return GLibGlobalFunctionsExterns.g_strdup(str);
	}

	public static string StrdupPrintf(string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_strdup_printf(format, @__arglist);
	}

	public static string StrdupVprintf(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_strdup_vprintf(format, args);
	}

	public static string[] Strdupv(string[] str_array)
	{
		return GLibGlobalFunctionsExterns.g_strdupv(str_array);
	}

	public static string Strerror(int errnum)
	{
		return GLibGlobalFunctionsExterns.g_strerror(errnum);
	}

	public static string Strescape(string source, string exceptions)
	{
		return GLibGlobalFunctionsExterns.g_strescape(source, exceptions);
	}

	public static void Strfreev(string[] str_array)
	{
		GLibGlobalFunctionsExterns.g_strfreev(str_array);
	}

	public static string StripContext(string msgid, string msgval)
	{
		return GLibGlobalFunctionsExterns.g_strip_context(msgid, msgval);
	}

	public static string Strjoin(string separator, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_strjoin(separator, @__arglist);
	}

	public static string Strjoinv(string separator, string[] str_array)
	{
		return GLibGlobalFunctionsExterns.g_strjoinv(separator, str_array);
	}

	public static UIntPtr Strlcat(string dest, string src, UIntPtr dest_size)
	{
		return GLibGlobalFunctionsExterns.g_strlcat(dest, src, dest_size);
	}

	public static UIntPtr Strlcpy(string dest, string src, UIntPtr dest_size)
	{
		return GLibGlobalFunctionsExterns.g_strlcpy(dest, src, dest_size);
	}

	public static int Strncasecmp(string s1, string s2, uint n)
	{
		return GLibGlobalFunctionsExterns.g_strncasecmp(s1, s2, n);
	}

	public static string Strndup(string str, UIntPtr n)
	{
		return GLibGlobalFunctionsExterns.g_strndup(str, n);
	}

	public static string Strnfill(UIntPtr length, char fill_char)
	{
		return GLibGlobalFunctionsExterns.g_strnfill(length, fill_char);
	}

	public static string Strreverse(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strreverse(@string);
	}

	public static string Strrstr(string haystack, string needle)
	{
		return GLibGlobalFunctionsExterns.g_strrstr(haystack, needle);
	}

	public static string StrrstrLen(string haystack, UIntPtr haystack_len, string needle)
	{
		return GLibGlobalFunctionsExterns.g_strrstr_len(haystack, haystack_len, needle);
	}

	public static string Strsignal(int signum)
	{
		return GLibGlobalFunctionsExterns.g_strsignal(signum);
	}

	public static string[] Strsplit(string @string, string delimiter, int max_tokens)
	{
		return GLibGlobalFunctionsExterns.g_strsplit(@string, delimiter, max_tokens);
	}

	public static string[] StrsplitSet(string @string, string delimiters, int max_tokens)
	{
		return GLibGlobalFunctionsExterns.g_strsplit_set(@string, delimiters, max_tokens);
	}

	public static string StrstrLen(string haystack, UIntPtr haystack_len, string needle)
	{
		return GLibGlobalFunctionsExterns.g_strstr_len(haystack, haystack_len, needle);
	}

	public static double Strtod(string nptr, out string endptr)
	{
		return GLibGlobalFunctionsExterns.g_strtod(nptr, out endptr);
	}

	public static string Strup(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strup(@string);
	}

	public static bool StrvContains(string[] strv, string str)
	{
		return GLibGlobalFunctionsExterns.g_strv_contains(strv, str);
	}

	public static bool StrvEqual(string[] strv1, string[] strv2)
	{
		return GLibGlobalFunctionsExterns.g_strv_equal(strv1, strv2);
	}

	public static MentorLake.GObject.GType StrvGetType()
	{
		return GLibGlobalFunctionsExterns.g_strv_get_type();
	}

	public static uint StrvLength(string[] str_array)
	{
		return GLibGlobalFunctionsExterns.g_strv_length(str_array);
	}

	public static void TestAddDataFunc(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func)
	{
		GLibGlobalFunctionsExterns.g_test_add_data_func(testpath, test_data, test_func);
	}

	public static void TestAddDataFuncFull(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func, MentorLake.GLib.GDestroyNotify data_free_func)
	{
		GLibGlobalFunctionsExterns.g_test_add_data_func_full(testpath, test_data, test_func, data_free_func);
	}

	public static void TestAddFunc(string testpath, MentorLake.GLib.GTestFunc test_func)
	{
		GLibGlobalFunctionsExterns.g_test_add_func(testpath, test_func);
	}

	public static void TestAddVtable(string testpath, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown)
	{
		GLibGlobalFunctionsExterns.g_test_add_vtable(testpath, data_size, test_data, data_setup, data_test, data_teardown);
	}

	public static void TestAssertExpectedMessagesInternal(string domain, string file, int line, string func)
	{
		GLibGlobalFunctionsExterns.g_test_assert_expected_messages_internal(domain, file, line, func);
	}

	public static void TestBug(string bug_uri_snippet)
	{
		GLibGlobalFunctionsExterns.g_test_bug(bug_uri_snippet);
	}

	public static void TestBugBase(string uri_pattern)
	{
		GLibGlobalFunctionsExterns.g_test_bug_base(uri_pattern);
	}

	public static string TestBuildFilename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_test_build_filename(file_type, first_path, @__arglist);
	}

	public static MentorLake.GLib.GTestCaseHandle TestCreateCase(string test_name, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown)
	{
		return GLibGlobalFunctionsExterns.g_test_create_case(test_name, data_size, test_data, data_setup, data_test, data_teardown);
	}

	public static MentorLake.GLib.GTestSuiteHandle TestCreateSuite(string suite_name)
	{
		return GLibGlobalFunctionsExterns.g_test_create_suite(suite_name);
	}

	public static void TestDisableCrashReporting()
	{
		GLibGlobalFunctionsExterns.g_test_disable_crash_reporting();
	}

	public static void TestExpectMessage(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string pattern)
	{
		GLibGlobalFunctionsExterns.g_test_expect_message(log_domain, log_level, pattern);
	}

	public static void TestFail()
	{
		GLibGlobalFunctionsExterns.g_test_fail();
	}

	public static void TestFailPrintf(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_fail_printf(format, @__arglist);
	}

	public static bool TestFailed()
	{
		return GLibGlobalFunctionsExterns.g_test_failed();
	}

	public static string TestGetDir(MentorLake.GLib.GTestFileType file_type)
	{
		return GLibGlobalFunctionsExterns.g_test_get_dir(file_type);
	}

	public static string TestGetFilename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_test_get_filename(file_type, first_path, @__arglist);
	}

	public static string TestGetPath()
	{
		return GLibGlobalFunctionsExterns.g_test_get_path();
	}

	public static MentorLake.GLib.GTestSuiteHandle TestGetRoot()
	{
		return GLibGlobalFunctionsExterns.g_test_get_root();
	}

	public static void TestIncomplete(string msg)
	{
		GLibGlobalFunctionsExterns.g_test_incomplete(msg);
	}

	public static void TestIncompletePrintf(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_incomplete_printf(format, @__arglist);
	}

	public static void TestInit(int argc, string argv, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_init(argc, argv, @__arglist);
	}

	public static void TestLogSetFatalHandler(MentorLake.GLib.GTestLogFatalFunc log_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_test_log_set_fatal_handler(log_func, user_data);
	}

	public static string TestLogTypeName(MentorLake.GLib.GTestLogType log_type)
	{
		return GLibGlobalFunctionsExterns.g_test_log_type_name(log_type);
	}

	public static void TestMaximizedResult(double maximized_quantity, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_maximized_result(maximized_quantity, format, @__arglist);
	}

	public static void TestMessage(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_message(format, @__arglist);
	}

	public static void TestMinimizedResult(double minimized_quantity, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_minimized_result(minimized_quantity, format, @__arglist);
	}

	public static void TestQueueDestroy(MentorLake.GLib.GDestroyNotify destroy_func, IntPtr destroy_data)
	{
		GLibGlobalFunctionsExterns.g_test_queue_destroy(destroy_func, destroy_data);
	}

	public static void TestQueueFree(IntPtr gfree_pointer)
	{
		GLibGlobalFunctionsExterns.g_test_queue_free(gfree_pointer);
	}

	public static double TestRandDouble()
	{
		return GLibGlobalFunctionsExterns.g_test_rand_double();
	}

	public static double TestRandDoubleRange(double range_start, double range_end)
	{
		return GLibGlobalFunctionsExterns.g_test_rand_double_range(range_start, range_end);
	}

	public static int TestRandInt()
	{
		return GLibGlobalFunctionsExterns.g_test_rand_int();
	}

	public static int TestRandIntRange(int begin, int end)
	{
		return GLibGlobalFunctionsExterns.g_test_rand_int_range(begin, end);
	}

	public static int TestRun()
	{
		return GLibGlobalFunctionsExterns.g_test_run();
	}

	public static int TestRunSuite(MentorLake.GLib.GTestSuiteHandle suite)
	{
		return GLibGlobalFunctionsExterns.g_test_run_suite(suite);
	}

	public static void TestSetNonfatalAssertions()
	{
		GLibGlobalFunctionsExterns.g_test_set_nonfatal_assertions();
	}

	public static void TestSkip(string msg)
	{
		GLibGlobalFunctionsExterns.g_test_skip(msg);
	}

	public static void TestSkipPrintf(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_skip_printf(format, @__arglist);
	}

	public static bool TestSubprocess()
	{
		return GLibGlobalFunctionsExterns.g_test_subprocess();
	}

	public static void TestSummary(string summary)
	{
		GLibGlobalFunctionsExterns.g_test_summary(summary);
	}

	public static double TestTimerElapsed()
	{
		return GLibGlobalFunctionsExterns.g_test_timer_elapsed();
	}

	public static double TestTimerLast()
	{
		return GLibGlobalFunctionsExterns.g_test_timer_last();
	}

	public static void TestTimerStart()
	{
		GLibGlobalFunctionsExterns.g_test_timer_start();
	}

	public static void TestTrapAssertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern)
	{
		GLibGlobalFunctionsExterns.g_test_trap_assertions(domain, file, line, func, assertion_flags, pattern);
	}

	public static bool TestTrapFork(ulong usec_timeout, MentorLake.GLib.GTestTrapFlags test_trap_flags)
	{
		return GLibGlobalFunctionsExterns.g_test_trap_fork(usec_timeout, test_trap_flags);
	}

	public static bool TestTrapHasPassed()
	{
		return GLibGlobalFunctionsExterns.g_test_trap_has_passed();
	}

	public static bool TestTrapReachedTimeout()
	{
		return GLibGlobalFunctionsExterns.g_test_trap_reached_timeout();
	}

	public static void TestTrapSubprocess(string test_path, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags)
	{
		GLibGlobalFunctionsExterns.g_test_trap_subprocess(test_path, usec_timeout, test_flags);
	}

	public static void TestTrapSubprocessWithEnvp(string test_path, string[] envp, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags)
	{
		GLibGlobalFunctionsExterns.g_test_trap_subprocess_with_envp(test_path, envp, usec_timeout, test_flags);
	}

	public static MentorLake.GLib.GThreadHandle ThreadCreate(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable)
	{
		return GLibGlobalFunctionsExterns.g_thread_create(func, data, joinable);
	}

	public static MentorLake.GLib.GThreadHandle ThreadCreateFull(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority)
	{
		return GLibGlobalFunctionsExterns.g_thread_create_full(func, data, stack_size, joinable, bound, priority);
	}

	public static MentorLake.GLib.GQuark ThreadErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_thread_error_quark();
	}

	public static void ThreadExit(IntPtr retval)
	{
		GLibGlobalFunctionsExterns.g_thread_exit(retval);
	}

	public static void ThreadForeach(MentorLake.GLib.GFunc thread_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_thread_foreach(thread_func, user_data);
	}

	public static bool ThreadGetInitialized()
	{
		return GLibGlobalFunctionsExterns.g_thread_get_initialized();
	}

	public static void ThreadInit(IntPtr vtable)
	{
		GLibGlobalFunctionsExterns.g_thread_init(vtable);
	}

	public static void ThreadInitWithErrorcheckMutexes(IntPtr vtable)
	{
		GLibGlobalFunctionsExterns.g_thread_init_with_errorcheck_mutexes(vtable);
	}

	public static uint ThreadPoolGetMaxIdleTime()
	{
		return GLibGlobalFunctionsExterns.g_thread_pool_get_max_idle_time();
	}

	public static int ThreadPoolGetMaxUnusedThreads()
	{
		return GLibGlobalFunctionsExterns.g_thread_pool_get_max_unused_threads();
	}

	public static uint ThreadPoolGetNumUnusedThreads()
	{
		return GLibGlobalFunctionsExterns.g_thread_pool_get_num_unused_threads();
	}

	public static void ThreadPoolSetMaxIdleTime(uint interval)
	{
		GLibGlobalFunctionsExterns.g_thread_pool_set_max_idle_time(interval);
	}

	public static void ThreadPoolSetMaxUnusedThreads(int max_threads)
	{
		GLibGlobalFunctionsExterns.g_thread_pool_set_max_unused_threads(max_threads);
	}

	public static void ThreadPoolStopUnusedThreads()
	{
		GLibGlobalFunctionsExterns.g_thread_pool_stop_unused_threads();
	}

	public static MentorLake.GLib.GThreadHandle ThreadSelf()
	{
		return GLibGlobalFunctionsExterns.g_thread_self();
	}

	public static void ThreadYield()
	{
		GLibGlobalFunctionsExterns.g_thread_yield();
	}

	public static bool TimeValFromIso8601(string iso_date, out MentorLake.GLib.GTimeVal time_)
	{
		return GLibGlobalFunctionsExterns.g_time_val_from_iso8601(iso_date, out time_);
	}

	public static uint TimeoutAdd(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add(interval, function, data);
	}

	public static uint TimeoutAddFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_full(priority, interval, function, data, notify);
	}

	public static uint TimeoutAddOnce(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_once(interval, function, data);
	}

	public static uint TimeoutAddSeconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_seconds(interval, function, data);
	}

	public static uint TimeoutAddSecondsFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_seconds_full(priority, interval, function, data, notify);
	}

	public static uint TimeoutAddSecondsOnce(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_seconds_once(interval, function, data);
	}

	public static MentorLake.GLib.GSourceHandle TimeoutSourceNew(uint interval)
	{
		return GLibGlobalFunctionsExterns.g_timeout_source_new(interval);
	}

	public static MentorLake.GLib.GSourceHandle TimeoutSourceNewSeconds(uint interval)
	{
		return GLibGlobalFunctionsExterns.g_timeout_source_new_seconds(interval);
	}

	public static uint TrashStackHeight(IntPtr stack_p)
	{
		return GLibGlobalFunctionsExterns.g_trash_stack_height(stack_p);
	}

	public static IntPtr TrashStackPeek(IntPtr stack_p)
	{
		return GLibGlobalFunctionsExterns.g_trash_stack_peek(stack_p);
	}

	public static IntPtr TrashStackPop(IntPtr stack_p)
	{
		return GLibGlobalFunctionsExterns.g_trash_stack_pop(stack_p);
	}

	public static void TrashStackPush(IntPtr stack_p, IntPtr data_p)
	{
		GLibGlobalFunctionsExterns.g_trash_stack_push(stack_p, data_p);
	}

	public static IntPtr TryMalloc(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc(n_bytes);
	}

	public static IntPtr TryMalloc0(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc0(n_bytes);
	}

	public static IntPtr TryMalloc0N(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc0_n(n_blocks, n_block_bytes);
	}

	public static IntPtr TryMallocN(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc_n(n_blocks, n_block_bytes);
	}

	public static IntPtr TryRealloc(IntPtr mem, UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_realloc(mem, n_bytes);
	}

	public static IntPtr TryReallocN(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_realloc_n(mem, n_blocks, n_block_bytes);
	}

	public static char Ucs4ToUtf16(char[] str, long len, out long items_read, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_ucs4_to_utf16(str, len, out items_read, out items_written);
	}

	public static string Ucs4ToUtf8(char[] str, long len, out long items_read, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_ucs4_to_utf8(str, len, out items_read, out items_written);
	}

	public static MentorLake.GLib.GUnicodeBreakType UnicharBreakType(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_break_type(c);
	}

	public static int UnicharCombiningClass(char uc)
	{
		return GLibGlobalFunctionsExterns.g_unichar_combining_class(uc);
	}

	public static bool UnicharCompose(char a, char b, out char ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_compose(a, b, out ch);
	}

	public static bool UnicharDecompose(char ch, out char a, out char b)
	{
		return GLibGlobalFunctionsExterns.g_unichar_decompose(ch, out a, out b);
	}

	public static int UnicharDigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_digit_value(c);
	}

	public static UIntPtr UnicharFullyDecompose(char ch, bool compat, out char result, UIntPtr result_len)
	{
		return GLibGlobalFunctionsExterns.g_unichar_fully_decompose(ch, compat, out result, result_len);
	}

	public static bool UnicharGetMirrorChar(char ch, out char mirrored_ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_get_mirror_char(ch, out mirrored_ch);
	}

	public static MentorLake.GLib.GUnicodeScript UnicharGetScript(char ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_get_script(ch);
	}

	public static bool UnicharIsalnum(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isalnum(c);
	}

	public static bool UnicharIsalpha(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isalpha(c);
	}

	public static bool UnicharIscntrl(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iscntrl(c);
	}

	public static bool UnicharIsdefined(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isdefined(c);
	}

	public static bool UnicharIsdigit(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isdigit(c);
	}

	public static bool UnicharIsgraph(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isgraph(c);
	}

	public static bool UnicharIslower(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_islower(c);
	}

	public static bool UnicharIsmark(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_ismark(c);
	}

	public static bool UnicharIsprint(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isprint(c);
	}

	public static bool UnicharIspunct(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_ispunct(c);
	}

	public static bool UnicharIsspace(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isspace(c);
	}

	public static bool UnicharIstitle(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_istitle(c);
	}

	public static bool UnicharIsupper(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isupper(c);
	}

	public static bool UnicharIswide(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iswide(c);
	}

	public static bool UnicharIswideCjk(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iswide_cjk(c);
	}

	public static bool UnicharIsxdigit(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isxdigit(c);
	}

	public static bool UnicharIszerowidth(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iszerowidth(c);
	}

	public static int UnicharToUtf8(char c, out string outbuf)
	{
		return GLibGlobalFunctionsExterns.g_unichar_to_utf8(c, out outbuf);
	}

	public static char UnicharTolower(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_tolower(c);
	}

	public static char UnicharTotitle(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_totitle(c);
	}

	public static char UnicharToupper(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_toupper(c);
	}

	public static MentorLake.GLib.GUnicodeType UnicharType(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_type(c);
	}

	public static bool UnicharValidate(char ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_validate(ch);
	}

	public static int UnicharXdigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_xdigit_value(c);
	}

	public static char UnicodeCanonicalDecomposition(char ch, UIntPtr result_len)
	{
		return GLibGlobalFunctionsExterns.g_unicode_canonical_decomposition(ch, result_len);
	}

	public static void UnicodeCanonicalOrdering(char[] @string, UIntPtr len)
	{
		GLibGlobalFunctionsExterns.g_unicode_canonical_ordering(@string, len);
	}

	public static MentorLake.GLib.GUnicodeScript UnicodeScriptFromIso15924(uint iso15924)
	{
		return GLibGlobalFunctionsExterns.g_unicode_script_from_iso15924(iso15924);
	}

	public static uint UnicodeScriptToIso15924(MentorLake.GLib.GUnicodeScript script)
	{
		return GLibGlobalFunctionsExterns.g_unicode_script_to_iso15924(script);
	}

	public static MentorLake.GLib.GQuark UnixErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_unix_error_quark();
	}

	public static uint UnixFdAdd(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_unix_fd_add(fd, condition, function, user_data);
	}

	public static uint UnixFdAddFull(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_unix_fd_add_full(priority, fd, condition, function, user_data, notify);
	}

	public static MentorLake.GLib.GSourceHandle UnixFdSourceNew(int fd, MentorLake.GLib.GIOCondition condition)
	{
		return GLibGlobalFunctionsExterns.g_unix_fd_source_new(fd, condition);
	}

	public static IntPtr UnixGetPasswdEntry(string user_name)
	{
		return GLibGlobalFunctionsExterns.g_unix_get_passwd_entry(user_name);
	}

	public static bool UnixOpenPipe(int[] fds, int flags)
	{
		return GLibGlobalFunctionsExterns.g_unix_open_pipe(fds, flags);
	}

	public static bool UnixSetFdNonblocking(int fd, bool nonblock)
	{
		return GLibGlobalFunctionsExterns.g_unix_set_fd_nonblocking(fd, nonblock);
	}

	public static uint UnixSignalAdd(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_unix_signal_add(signum, handler, user_data);
	}

	public static uint UnixSignalAddFull(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_unix_signal_add_full(priority, signum, handler, user_data, notify);
	}

	public static MentorLake.GLib.GSourceHandle UnixSignalSourceNew(int signum)
	{
		return GLibGlobalFunctionsExterns.g_unix_signal_source_new(signum);
	}

	public static int Unlink(string filename)
	{
		return GLibGlobalFunctionsExterns.g_unlink(filename);
	}

	public static void Unsetenv(string variable)
	{
		GLibGlobalFunctionsExterns.g_unsetenv(variable);
	}

	public static MentorLake.GLib.GUriHandle UriBuild(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_build(flags, scheme, userinfo, host, port, path, query, fragment);
	}

	public static MentorLake.GLib.GUriHandle UriBuildWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_build_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

	public static MentorLake.GLib.GQuark UriErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_uri_error_quark();
	}

	public static string UriEscapeBytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed)
	{
		return GLibGlobalFunctionsExterns.g_uri_escape_bytes(unescaped, length, reserved_chars_allowed);
	}

	public static string UriEscapeString(string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		return GLibGlobalFunctionsExterns.g_uri_escape_string(unescaped, reserved_chars_allowed, allow_utf8);
	}

	public static bool UriIsValid(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		return GLibGlobalFunctionsExterns.g_uri_is_valid(uri_string, flags);
	}

	public static string UriJoin(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_join(flags, scheme, userinfo, host, port, path, query, fragment);
	}

	public static string UriJoinWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_join_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

	public static string[] UriListExtractUris(string uri_list)
	{
		return GLibGlobalFunctionsExterns.g_uri_list_extract_uris(uri_list);
	}

	public static MentorLake.GLib.GUriHandle UriParse(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		return GLibGlobalFunctionsExterns.g_uri_parse(uri_string, flags);
	}

	public static MentorLake.GLib.GHashTableHandle UriParseParams(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags)
	{
		return GLibGlobalFunctionsExterns.g_uri_parse_params(@params, length, separators, flags);
	}

	public static string UriParseScheme(string uri)
	{
		return GLibGlobalFunctionsExterns.g_uri_parse_scheme(uri);
	}

	public static string UriPeekScheme(string uri)
	{
		return GLibGlobalFunctionsExterns.g_uri_peek_scheme(uri);
	}

	public static string UriResolveRelative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags)
	{
		return GLibGlobalFunctionsExterns.g_uri_resolve_relative(base_uri_string, uri_ref, flags);
	}

	public static bool UriSplit(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_split(uri_ref, flags, out scheme, out userinfo, out host, out port, out path, out query, out fragment);
	}

	public static bool UriSplitNetwork(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port)
	{
		return GLibGlobalFunctionsExterns.g_uri_split_network(uri_string, flags, out scheme, out host, out port);
	}

	public static bool UriSplitWithUser(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_split_with_user(uri_ref, flags, out scheme, out user, out password, out auth_params, out host, out port, out path, out query, out fragment);
	}

	public static MentorLake.GLib.GBytesHandle UriUnescapeBytes(string escaped_string, UIntPtr length, string illegal_characters)
	{
		return GLibGlobalFunctionsExterns.g_uri_unescape_bytes(escaped_string, length, illegal_characters);
	}

	public static string UriUnescapeSegment(string escaped_string, string escaped_string_end, string illegal_characters)
	{
		return GLibGlobalFunctionsExterns.g_uri_unescape_segment(escaped_string, escaped_string_end, illegal_characters);
	}

	public static string UriUnescapeString(string escaped_string, string illegal_characters)
	{
		return GLibGlobalFunctionsExterns.g_uri_unescape_string(escaped_string, illegal_characters);
	}

	public static void Usleep(ulong microseconds)
	{
		GLibGlobalFunctionsExterns.g_usleep(microseconds);
	}

	public static char Utf16ToUcs4(ushort[] str, long len, out long items_read, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_utf16_to_ucs4(str, len, out items_read, out items_written);
	}

	public static string Utf16ToUtf8(ushort[] str, long len, out long items_read, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_utf16_to_utf8(str, len, out items_read, out items_written);
	}

	public static string Utf8Casefold(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_casefold(str, len);
	}

	public static int Utf8Collate(string str1, string str2)
	{
		return GLibGlobalFunctionsExterns.g_utf8_collate(str1, str2);
	}

	public static string Utf8CollateKey(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_collate_key(str, len);
	}

	public static string Utf8CollateKeyForFilename(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_collate_key_for_filename(str, len);
	}

	public static string Utf8FindNextChar(string p, string end)
	{
		return GLibGlobalFunctionsExterns.g_utf8_find_next_char(p, end);
	}

	public static string Utf8FindPrevChar(string str, string p)
	{
		return GLibGlobalFunctionsExterns.g_utf8_find_prev_char(str, p);
	}

	public static char Utf8GetChar(string p)
	{
		return GLibGlobalFunctionsExterns.g_utf8_get_char(p);
	}

	public static char Utf8GetCharValidated(string p, UIntPtr max_len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_get_char_validated(p, max_len);
	}

	public static string Utf8MakeValid(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_make_valid(str, len);
	}

	public static string Utf8Normalize(string str, UIntPtr len, MentorLake.GLib.GNormalizeMode mode)
	{
		return GLibGlobalFunctionsExterns.g_utf8_normalize(str, len, mode);
	}

	public static string Utf8OffsetToPointer(string str, long offset)
	{
		return GLibGlobalFunctionsExterns.g_utf8_offset_to_pointer(str, offset);
	}

	public static long Utf8PointerToOffset(string str, string pos)
	{
		return GLibGlobalFunctionsExterns.g_utf8_pointer_to_offset(str, pos);
	}

	public static string Utf8PrevChar(string p)
	{
		return GLibGlobalFunctionsExterns.g_utf8_prev_char(p);
	}

	public static string Utf8Strchr(string p, UIntPtr len, char c)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strchr(p, len, c);
	}

	public static string Utf8Strdown(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strdown(str, len);
	}

	public static long Utf8Strlen(string p, UIntPtr max)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strlen(p, max);
	}

	public static string Utf8Strncpy(string dest, string src, UIntPtr n)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strncpy(dest, src, n);
	}

	public static string Utf8Strrchr(string p, UIntPtr len, char c)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strrchr(p, len, c);
	}

	public static string Utf8Strreverse(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strreverse(str, len);
	}

	public static string Utf8Strup(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strup(str, len);
	}

	public static string Utf8Substring(string str, long start_pos, long end_pos)
	{
		return GLibGlobalFunctionsExterns.g_utf8_substring(str, start_pos, end_pos);
	}

	public static char Utf8ToUcs4(string str, long len, out long items_read, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_utf8_to_ucs4(str, len, out items_read, out items_written);
	}

	public static char Utf8ToUcs4Fast(string str, long len, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_utf8_to_ucs4_fast(str, len, out items_written);
	}

	public static char Utf8ToUtf16(string str, long len, out long items_read, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_utf8_to_utf16(str, len, out items_read, out items_written);
	}

	public static string Utf8TruncateMiddle(string @string, UIntPtr truncate_length)
	{
		return GLibGlobalFunctionsExterns.g_utf8_truncate_middle(@string, truncate_length);
	}

	public static bool Utf8Validate(byte[] str, UIntPtr max_len, out string end)
	{
		return GLibGlobalFunctionsExterns.g_utf8_validate(str, max_len, out end);
	}

	public static bool Utf8ValidateLen(byte[] str, UIntPtr max_len, out string end)
	{
		return GLibGlobalFunctionsExterns.g_utf8_validate_len(str, max_len, out end);
	}

	public static int Utime(string filename, IntPtr utb)
	{
		return GLibGlobalFunctionsExterns.g_utime(filename, utb);
	}

	public static bool UuidStringIsValid(string str)
	{
		return GLibGlobalFunctionsExterns.g_uuid_string_is_valid(str);
	}

	public static string UuidStringRandom()
	{
		return GLibGlobalFunctionsExterns.g_uuid_string_random();
	}

	public static MentorLake.GObject.GType VariantGetGtype()
	{
		return GLibGlobalFunctionsExterns.g_variant_get_gtype();
	}

	public static bool VariantIsObjectPath(string @string)
	{
		return GLibGlobalFunctionsExterns.g_variant_is_object_path(@string);
	}

	public static bool VariantIsSignature(string @string)
	{
		return GLibGlobalFunctionsExterns.g_variant_is_signature(@string);
	}

	public static MentorLake.GLib.GVariantHandle VariantParse(MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr)
	{
		return GLibGlobalFunctionsExterns.g_variant_parse(type, text, limit, endptr);
	}

	public static string VariantParseErrorPrintContext(MentorLake.GLib.GErrorHandle error, string source_str)
	{
		return GLibGlobalFunctionsExterns.g_variant_parse_error_print_context(error, source_str);
	}

	public static MentorLake.GLib.GQuark VariantParseErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_variant_parse_error_quark();
	}

	public static MentorLake.GLib.GQuark VariantParserGetErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_variant_parser_get_error_quark();
	}

	public static MentorLake.GLib.GVariantTypeHandle VariantTypeChecked(string type_string)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_checked_(type_string);
	}

	public static UIntPtr VariantTypeStringGetDepth(string type_string)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_string_get_depth_(type_string);
	}

	public static bool VariantTypeStringIsValid(string type_string)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_string_is_valid(type_string);
	}

	public static bool VariantTypeStringScan(string @string, string limit, out string endptr)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_string_scan(@string, limit, out endptr);
	}

	public static int Vasprintf(out string @string, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vasprintf(out @string, format, args);
	}

	public static int Vfprintf(IntPtr file, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vfprintf(file, format, args);
	}

	public static int Vprintf(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vprintf(format, args);
	}

	public static int Vsnprintf(string @string, ulong n, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vsnprintf(@string, n, format, args);
	}

	public static int Vsprintf(string @string, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vsprintf(@string, format, args);
	}

	public static void WarnMessage(string domain, string file, int line, string func, string warnexpr)
	{
		GLibGlobalFunctionsExterns.g_warn_message(domain, file, line, func, warnexpr);
	}

}

internal class GLibGlobalFunctionsExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_access(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_aligned_alloc(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_aligned_alloc0(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_aligned_free(IntPtr mem);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_aligned_free_sized(IntPtr mem, UIntPtr alignment, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new_take(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new_take_zero_terminated(IntPtr[] data, bool clear, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_digit_value(char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_dtostr(string buffer, int buf_len, double d);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_formatd(string buffer, int buf_len, string format, double d);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_strcasecmp(string s1, string s2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_strdown(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ascii_string_to_signed(string str, uint @base, long min, long max, out long out_num);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ascii_string_to_unsigned(string str, uint @base, ulong min, ulong max, out ulong out_num);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_strncasecmp(string s1, string s2, UIntPtr n);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_ascii_strtod(string nptr, out string endptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_ascii_strtoll(string nptr, out string endptr, uint @base);

	[DllImport(GLibLibrary.Name)]
	internal static extern ulong g_ascii_strtoull(string nptr, out string endptr, uint @base);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_strup(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_ascii_tolower(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_ascii_toupper(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_xdigit_value(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assert_warning(string log_domain, string file, int line, string pretty_function, string expression);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message(string domain, string file, int line, string func, string message);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpint(string domain, string file, int line, string func, string expr, ulong arg1, string cmp, ulong arg2, char numtype);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpnum(string domain, string file, int line, string func, string expr, long arg1, string cmp, long arg2, char numtype);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpstrv(string domain, string file, int line, string func, string expr, string arg1, string arg2, UIntPtr first_wrong_idx);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_error(string domain, string file, int line, string func, string expr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark error_domain, int error_code);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_expr(string domain, string file, int line, string func, string expr);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new_full(MentorLake.GLib.GDestroyNotify item_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atexit(MentorLake.GLib.GVoidFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_add(int atomic, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_int_and(uint atomic, uint val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_int_compare_and_exchange(int atomic, int oldval, int newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_int_compare_and_exchange_full(int atomic, int oldval, int newval, out int preval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_int_dec_and_test(int atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_exchange(int atomic, int newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_exchange_and_add(int atomic, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_get(int atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_int_inc(int atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_int_or(uint atomic, uint val);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_int_set(int atomic, int newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_int_xor(uint atomic, uint val);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_pointer_add(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_pointer_and(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_pointer_compare_and_exchange(IntPtr atomic, IntPtr oldval, IntPtr newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_pointer_compare_and_exchange_full(IntPtr atomic, IntPtr oldval, IntPtr newval, out IntPtr preval);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_pointer_exchange(IntPtr atomic, IntPtr newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_pointer_get(IntPtr atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_pointer_or(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_pointer_set(IntPtr atomic, IntPtr newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_pointer_xor(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_acquire(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_alloc(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_alloc0(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_dup(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_atomic_rc_box_get_size(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_rc_box_release(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_rc_box_release_full(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_ref_count_compare(int arc, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_ref_count_dec(int arc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_ref_count_inc(int arc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_ref_count_init(int arc);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_base64_decode(string text, out UIntPtr out_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_base64_decode_inplace(ref byte[] text, ref UIntPtr out_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_base64_decode_step(byte[] @in, UIntPtr len, out byte[] @out, ref int state, ref uint save);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_base64_encode(byte[] data, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_base64_encode_close(bool break_lines, out byte[] @out, ref int state, ref int save);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_base64_encode_step(byte[] @in, UIntPtr len, bool break_lines, out byte[] @out, ref int state, ref int save);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_basename(string file_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bit_lock(int address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bit_nth_lsf(ulong mask, int nth_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bit_nth_msf(ulong mask, int nth_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_bit_storage(ulong number);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bit_trylock(int address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bit_unlock(int address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_blow_chunks();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_bookmark_file_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_filename(string first_element, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_filename_valist(string first_element, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_filenamev(string[] args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_path(string separator, string first_element, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_pathv(string separator, string[] args);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, byte data, uint len);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_byte_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_byte_array_free_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_new_take(byte[] data, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, byte data, uint len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_index_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_, uint length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_sized_new(uint reserved_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_byte_array_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, out UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_canonicalize_filename(string filename, string relative_to);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_chdir(string path);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string glib_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_checksum_type_get_length(MentorLake.GLib.GChecksumType checksum_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_child_watch_add(MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_child_watch_add_full(int priority, MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_child_watch_source_new(MentorLake.GLib.GPid pid);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_chmod(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_error();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_handle_id(uint tag_ptr, MentorLake.GLib.GClearHandleFunc clear_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_list(IntPtr list_ptr, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_pointer(ref IntPtr pp, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_slist(IntPtr slist_ptr, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_close(int fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_closefrom(int lowfd);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_checksum_for_bytes(MentorLake.GLib.GChecksumType checksum_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_checksum_for_data(MentorLake.GLib.GChecksumType checksum_type, byte[] data, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_checksum_for_string(MentorLake.GLib.GChecksumType checksum_type, string str, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_hmac_for_bytes(MentorLake.GLib.GChecksumType digest_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_hmac_for_data(MentorLake.GLib.GChecksumType digest_type, char[] key, UIntPtr key_len, char[] data, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_hmac_for_string(MentorLake.GLib.GChecksumType digest_type, char[] key, UIntPtr key_len, string str, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GCondHandle g_cond_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_convert(byte[] str, UIntPtr len, string to_codeset, string from_codeset, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_convert_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_convert_with_fallback(byte[] str, UIntPtr len, string to_codeset, string from_codeset, string fallback, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_convert_with_iconv(byte[] str, UIntPtr len, MentorLake.GLib.GIConv converter, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_creat(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_clear(IntPtr datalist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_foreach(IntPtr datalist, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_get_data(IntPtr datalist, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_datalist_get_flags(IntPtr datalist);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_id_dup_data(IntPtr datalist, MentorLake.GLib.GQuark key_id, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_id_get_data(IntPtr datalist, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_id_remove_multiple(IntPtr datalist, MentorLake.GLib.GQuark[] keys, UIntPtr n_keys);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_id_remove_no_notify(IntPtr datalist, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_datalist_id_replace_data(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_id_set_data_full(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_init(IntPtr datalist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_set_flags(IntPtr datalist, uint flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_unset_flags(IntPtr datalist, uint flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dataset_destroy(IntPtr dataset_location);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dataset_foreach(IntPtr dataset_location, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_dataset_id_get_data(IntPtr dataset_location, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_dataset_id_remove_no_notify(IntPtr dataset_location, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dataset_id_set_data_full(IntPtr dataset_location, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_days_in_month(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_monday_weeks_in_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_sunday_weeks_in_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_is_leap_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_date_strftime(string s, UIntPtr slen, string format, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_day(MentorLake.GLib.GDateDay day);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_dmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_julian(uint julian_date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_month(MentorLake.GLib.GDateMonth month);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_weekday(MentorLake.GLib.GDateWeekday weekday);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dcgettext(string domain, string msgid, int category);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dgettext(string domain, string msgid);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dir_make_tmp(string tmpl);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_direct_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_direct_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dngettext(string domain, string msgid, string msgid_plural, ulong n);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_double_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_double_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dpgettext(string domain, string msgctxtid, UIntPtr msgidoffset);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dpgettext2(string domain, string context, string msgid);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_environ_getenv(string[] envp, string variable);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_environ_setenv(string[] envp, string variable, string value, bool overwrite);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_environ_unsetenv(string[] envp, string variable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_error_domain_register(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_error_domain_register_static(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_fdwalk_set_cloexec(int lowfd);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GFileError g_file_error_from_errno(int err_no);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_file_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_get_contents(string filename, out byte[] contents, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_file_open_tmp(string tmpl, out string name_used);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_read_link(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_set_contents(string filename, byte[] contents, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_set_contents_full(string filename, byte[] contents, UIntPtr length, MentorLake.GLib.GFileSetContentsFlags flags, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_test(string filename, MentorLake.GLib.GFileTest test);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_display_basename(string filename);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_display_name(string filename);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_from_uri(string uri, out string hostname);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_from_utf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_to_uri(string filename, string hostname);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_to_utf8(string opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_find_program_in_path(string program);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_fopen(string filename, string mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_format_size(ulong size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_format_size_for_display(int size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_format_size_full(ulong size, MentorLake.GLib.GFormatSizeFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_fprintf(IntPtr file, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_free(IntPtr mem);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_free_sized(IntPtr mem, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_freopen(string filename, string mode, IntPtr stream);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_fsync(int fd);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_application_name();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_get_charset(out string charset);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_codeset();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_get_console_charset(out string charset);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_current_dir();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_get_current_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle result);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_environ();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_get_filename_charsets(out string[] filename_charsets);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_home_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_host_name();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_language_names();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_language_names_with_category(string category_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_locale_variants(string locale);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_get_monotonic_time();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_get_num_processors();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_os_info(string key_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_prgname();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_real_name();

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_get_real_time();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_system_config_dirs();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_system_data_dirs();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_tmp_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_cache_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_config_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_data_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_name();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_runtime_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_special_dir(MentorLake.GLib.GUserDirectory directory);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_state_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_getenv(string variable);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_foreach_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_foreach_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_keys_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_values_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_lookup_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new_similar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle other_hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_steal_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hook_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, ulong hook_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_destroy_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hostname_is_ascii_encoded(string hostname);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hostname_is_ip_address(string hostname);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hostname_is_non_ascii(string hostname);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_hostname_to_ascii(string hostname);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_hostname_to_unicode(string hostname);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_iconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIConv g_iconv_open(string to_codeset, string from_codeset);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_idle_add(MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_idle_add_full(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_idle_add_once(MentorLake.GLib.GSourceOnceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_idle_remove_by_data(IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_idle_source_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_int64_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_int64_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_int_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_int_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_intern_static_string(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_intern_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_io_add_watch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_io_add_watch_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, int priority, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOChannelError g_io_channel_error_from_errno(int en);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_io_channel_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_io_create_watch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_key_file_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_listenv();

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_locale_from_utf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_locale_to_utf8(byte[] opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_default_handler(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr unused_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_get_debug_enabled();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_remove_handler(string log_domain, uint handler_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogLevelFlags g_log_set_always_fatal(MentorLake.GLib.GLogLevelFlags fatal_mask);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_set_debug_enabled(bool enabled);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogFunc g_log_set_default_handler(MentorLake.GLib.GLogFunc log_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogLevelFlags g_log_set_fatal_mask(string log_domain, MentorLake.GLib.GLogLevelFlags fatal_mask);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_log_set_handler(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_log_set_handler_full(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_set_writer_func(MentorLake.GLib.GLogWriterFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_structured(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_structured_array(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_structured_standard(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string file, string line, string func, string message_format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_variant(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle fields);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_default(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_writer_default_set_debug_domains(string domains);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_writer_default_set_use_stderr(bool use_stderr);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_writer_default_would_drop(MentorLake.GLib.GLogLevelFlags log_level, string log_domain);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_log_writer_format_fields(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, bool use_color);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_writer_is_journald(int output_fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_journald(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_standard_streams(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_writer_supports_color(int output_fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_syslog(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_logv(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_lstat(string filename, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStatBufHandle>))] MentorLake.GLib.GStatBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_default();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_get_thread_default();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_ref_thread_default();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_main_current_source();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_main_depth();

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc0(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc0_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_markup_collect_attributes(string element_name, string attribute_names, string attribute_values, IntPtr error, MentorLake.GLib.GMarkupCollectType first_type, string first_attr, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_markup_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_escape_text(string text, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_printf_escaped(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_vprintf_escaped(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_info();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_mem_is_system_malloc();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_profile();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_set_vtable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemVTableHandle>))] MentorLake.GLib.GMemVTableHandle vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_memdup(IntPtr mem, uint byte_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_memdup2(IntPtr mem, UIntPtr byte_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkdir(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkdir_with_parents(string pathname, int mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mkdtemp(string tmpl);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mkdtemp_full(string tmpl, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkstemp(string tmpl);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkstemp_full(string tmpl, int flags, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMutexHandle g_mutex_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_nullify_pointer(IntPtr nullify_location);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_number_parser_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_on_error_query(string prg_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_on_error_stack_trace(string prg_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter(ref IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_impl(UIntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_pointer(IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave(ref IntPtr location, UIntPtr result);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave_pointer(IntPtr location, IntPtr result);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_open(string filename, int flags, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_option_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_parse_debug_string(string @string, MentorLake.GLib.GDebugKey[] keys, uint nkeys);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_get_basename(string file_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_get_dirname(string file_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_is_absolute(string file_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_skip_root(string file_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_match_simple(string pattern, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_match_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_lock(IntPtr address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_lock_and_get(IntPtr address, uint lock_bit, out uint out_ptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_pointer_bit_lock_mask_ptr(IntPtr ptr, uint lock_bit, bool set, uint preserve_mask, IntPtr preserve_ptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pointer_bit_trylock(IntPtr address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_unlock(IntPtr address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_unlock_and_set(IntPtr address, uint lock_bit, IntPtr ptr, uint preserve_mask);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fds, uint nfds, int timeout);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_prefix_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] ref MentorLake.GLib.GErrorHandle err, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_prefix_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] ref MentorLake.GLib.GErrorHandle err, string prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_print(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_printerr(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_printf_string_upper_bound(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPrivateHandle g_private_new(MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle src);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_propagate_prefixed_error(IntPtr dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle src, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_find_with_equal_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_array(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_null_terminated_array(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take_null_terminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_qsort_with_data(IntPtr pbase, int total_elems, UIntPtr size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_quark_from_static_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_quark_from_string(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_quark_to_string(MentorLake.GLib.GQuark quark);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_quark_try_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_random_double();

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_random_double_range(double begin, double end);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_random_int();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_random_int_range(int begin, int end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_random_set_seed(uint seed);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_acquire(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_alloc(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_alloc0(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_dup(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_rc_box_get_size(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rc_box_release(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rc_box_release_full(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_realloc(IntPtr mem, UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_realloc_n(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ref_count_compare(int rc, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ref_count_dec(int rc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ref_count_inc(int rc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ref_count_init(int rc);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_acquire(string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ref_string_equal(string str1, string str2);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_ref_string_length(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_new(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_new_intern(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_new_len(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ref_string_release(string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_check_replacement(string replacement, out bool has_references);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_regex_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_nul(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_string(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_reload_user_special_dirs_cache();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_remove(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_rename(string oldfilename, string newfilename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_return_if_fail_warning(string log_domain, string pretty_function, string expression);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_rmdir(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_foreach_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_sequence_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_range_get_midpoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_application_name(string application_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_prgname(string prgname);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPrintFunc g_set_print_handler(MentorLake.GLib.GPrintFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPrintFunc g_set_printerr_handler(MentorLake.GLib.GPrintFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_setenv(string variable, string value, bool overwrite);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_shell_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_shell_parse_argv(string command_line, out int argcp, out string[] argvp);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_shell_quote(string unquoted_string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_shell_unquote(string quoted_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slice_alloc(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slice_alloc0(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slice_copy(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slice_free1(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slice_free_chain_with_offset(UIntPtr block_size, IntPtr mem_chain, UIntPtr next_offset);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_slice_get_config(MentorLake.GLib.GSliceConfig ckey);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_slice_get_config_state(MentorLake.GLib.GSliceConfig ckey, long address, uint n_values);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slice_set_config(MentorLake.GLib.GSliceConfig ckey, long value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_snprintf(string @string, ulong n, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sort_array(IntPtr[] array, UIntPtr n_elements, UIntPtr element_size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove(uint tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_funcs_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_user_data(IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_name_by_id(uint tag, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_spaced_primes_closest(uint num);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async_with_fds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, int stdin_fd, int stdout_fd, int stderr_fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async_with_pipes(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, out int standard_input, out int standard_output, out int standard_error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async_with_pipes_and_fds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, int stdin_fd, int stdout_fd, int stderr_fd, int[] source_fds, int[] target_fds, UIntPtr n_fds, out MentorLake.GLib.GPid child_pid_out, out int stdin_pipe_out, out int stdout_pipe_out, out int stderr_pipe_out);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_check_exit_status(int wait_status);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_check_wait_status(int wait_status);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_spawn_close_pid(MentorLake.GLib.GPid pid);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_command_line_async(string command_line);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_command_line_sync(string command_line, out byte[] standard_output, out byte[] standard_error, out int wait_status);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_spawn_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_spawn_exit_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_sync(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out byte[] standard_output, out byte[] standard_error, out int wait_status);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sprintf(string @string, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_stat(string filename, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStatBufHandle>))] MentorLake.GLib.GStatBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_stpcpy(string dest, string src);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_has_prefix(string str, string prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_has_suffix(string str, string suffix);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_str_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_is_ascii(string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_match_string(string search_term, string potential_hit, bool accept_alternates);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_str_to_ascii(string str, string from_locale);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_str_tokenize_and_fold(string @string, string translit_locale, out string[] ascii_alternates);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strcanon(string @string, string valid_chars, char substitutor);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_strcasecmp(string s1, string s2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strchomp(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strchug(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_strcmp0(string str1, string str2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strcompress(string source);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strconcat(string string1, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdelimit(string @string, string delimiters, char new_delimiter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdown(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup_vprintf(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strdupv(string[] str_array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strerror(int errnum);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strescape(string source, string exceptions);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strfreev(string[] str_array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strip_context(string msgid, string msgval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strjoin(string separator, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strjoinv(string separator, string[] str_array);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_strlcat(string dest, string src, UIntPtr dest_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_strlcpy(string dest, string src, UIntPtr dest_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_strncasecmp(string s1, string s2, uint n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strndup(string str, UIntPtr n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strnfill(UIntPtr length, char fill_char);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strreverse(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strrstr(string haystack, string needle);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strrstr_len(string haystack, UIntPtr haystack_len, string needle);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strsignal(int signum);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strsplit(string @string, string delimiter, int max_tokens);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strsplit_set(string @string, string delimiters, int max_tokens);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strstr_len(string haystack, UIntPtr haystack_len, string needle);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_strtod(string nptr, out string endptr);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strup(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_strv_contains(string[] strv, string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_strv_equal(string[] strv1, string[] strv2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_strv_get_type();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_strv_length(string[] str_array);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_data_func(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_data_func_full(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func, MentorLake.GLib.GDestroyNotify data_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_func(string testpath, MentorLake.GLib.GTestFunc test_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_vtable(string testpath, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_assert_expected_messages_internal(string domain, string file, int line, string func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_bug(string bug_uri_snippet);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_bug_base(string uri_pattern);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_build_filename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTestCaseHandle g_test_create_case(string test_name, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTestSuiteHandle g_test_create_suite(string suite_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_disable_crash_reporting();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_expect_message(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string pattern);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_fail();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_fail_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_failed();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_get_dir(MentorLake.GLib.GTestFileType file_type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_get_filename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_get_path();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTestSuiteHandle g_test_get_root();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_incomplete(string msg);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_incomplete_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_init(int argc, string argv, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_set_fatal_handler(MentorLake.GLib.GTestLogFatalFunc log_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_log_type_name(MentorLake.GLib.GTestLogType log_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_maximized_result(double maximized_quantity, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_message(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_minimized_result(double minimized_quantity, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_queue_destroy(MentorLake.GLib.GDestroyNotify destroy_func, IntPtr destroy_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_queue_free(IntPtr gfree_pointer);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_rand_double();

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_rand_double_range(double range_start, double range_end);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_rand_int();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_rand_int_range(int begin, int end);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_run();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_run_suite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))] MentorLake.GLib.GTestSuiteHandle suite);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_set_nonfatal_assertions();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_skip(string msg);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_skip_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_subprocess();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_summary(string summary);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_timer_elapsed();

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_timer_last();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_timer_start();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_trap_assertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_trap_fork(ulong usec_timeout, MentorLake.GLib.GTestTrapFlags test_trap_flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_trap_has_passed();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_trap_reached_timeout();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_trap_subprocess(string test_path, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_trap_subprocess_with_envp(string test_path, string[] envp, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create_full(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_thread_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_exit(IntPtr retval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_foreach(MentorLake.GLib.GFunc thread_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_get_initialized();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init_with_errorcheck_mutexes(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_max_idle_time();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_thread_pool_get_max_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_num_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_idle_time(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_unused_threads(int max_threads);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_stop_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_self();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_yield();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_time_val_from_iso8601(string iso_date, out MentorLake.GLib.GTimeVal time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_full(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_once(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_seconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_seconds_full(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_seconds_once(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_timeout_source_new(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_timeout_source_new_seconds(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_trash_stack_height(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_trash_stack_peek(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_trash_stack_pop(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_trash_stack_push(IntPtr stack_p, IntPtr data_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc0(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc0_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_realloc(IntPtr mem, UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_realloc_n(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_ucs4_to_utf16(char[] str, long len, out long items_read, out long items_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ucs4_to_utf8(char[] str, long len, out long items_read, out long items_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeBreakType g_unichar_break_type(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_combining_class(char uc);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_compose(char a, char b, out char ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_decompose(char ch, out char a, out char b);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_digit_value(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_unichar_fully_decompose(char ch, bool compat, out char result, UIntPtr result_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_get_mirror_char(char ch, out char mirrored_ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeScript g_unichar_get_script(char ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isalnum(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isalpha(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iscntrl(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isdefined(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isdigit(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isgraph(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_islower(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_ismark(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isprint(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_ispunct(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isspace(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_istitle(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isupper(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iswide(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iswide_cjk(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isxdigit(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iszerowidth(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_to_utf8(char c, out string outbuf);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unichar_tolower(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unichar_totitle(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unichar_toupper(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeType g_unichar_type(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_validate(char ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_xdigit_value(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unicode_canonical_decomposition(char ch, UIntPtr result_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_unicode_canonical_ordering(char[] @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeScript g_unicode_script_from_iso15924(uint iso15924);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unicode_script_to_iso15924(MentorLake.GLib.GUnicodeScript script);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_unix_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_fd_add(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_fd_add_full(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_fd_source_new(int fd, MentorLake.GLib.GIOCondition condition);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_unix_get_passwd_entry(string user_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unix_open_pipe(int[] fds, int flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unix_set_fd_nonblocking(int fd, bool nonblock);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_signal_add(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_signal_add_full(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_signal_source_new(int signum);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unlink(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_unsetenv(string variable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUriHandle g_uri_build(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUriHandle g_uri_build_with_user(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_uri_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_escape_bytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_is_valid(string uri_string, MentorLake.GLib.GUriFlags flags);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_join(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_join_with_user(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_uri_list_extract_uris(string uri_list);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUriHandle g_uri_parse(string uri_string, MentorLake.GLib.GUriFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GHashTableHandle g_uri_parse_params(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_parse_scheme(string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_peek_scheme(string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_resolve_relative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split_network(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split_with_user(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_uri_unescape_bytes(string escaped_string, UIntPtr length, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_usleep(ulong microseconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf16_to_ucs4(ushort[] str, long len, out long items_read, out long items_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf16_to_utf8(ushort[] str, long len, out long items_read, out long items_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_casefold(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_utf8_collate(string str1, string str2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_collate_key(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_collate_key_for_filename(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_find_next_char(string p, string end);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_find_prev_char(string str, string p);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_get_char(string p);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_get_char_validated(string p, UIntPtr max_len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_make_valid(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_normalize(string str, UIntPtr len, MentorLake.GLib.GNormalizeMode mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_offset_to_pointer(string str, long offset);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_utf8_pointer_to_offset(string str, string pos);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_prev_char(string p);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strchr(string p, UIntPtr len, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strdown(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_utf8_strlen(string p, UIntPtr max);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strncpy(string dest, string src, UIntPtr n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strrchr(string p, UIntPtr len, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strreverse(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strup(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_substring(string str, long start_pos, long end_pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_to_ucs4(string str, long len, out long items_read, out long items_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_to_ucs4_fast(string str, long len, out long items_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_to_utf16(string str, long len, out long items_read, out long items_written);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_truncate_middle(string @string, UIntPtr truncate_length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_utf8_validate(byte[] str, UIntPtr max_len, out string end);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_utf8_validate_len(byte[] str, UIntPtr max_len, out string end);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_utime(string filename, IntPtr utb);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uuid_string_is_valid(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uuid_string_random();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_variant_get_gtype();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_object_path(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_signature(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_parse_error_print_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, string source_str);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_variant_parse_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_variant_parser_get_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_checked_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_string_get_depth_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_is_valid(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_scan(string @string, string limit, out string endptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vasprintf(out string @string, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vfprintf(IntPtr file, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vprintf(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vsnprintf(string @string, ulong n, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vsprintf(string @string, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_warn_message(string domain, string file, int line, string func, string warnexpr);

}
