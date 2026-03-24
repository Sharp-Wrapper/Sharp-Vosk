using System.Runtime.InteropServices;

namespace Sharp_Vosk
{
    public partial struct VoskModel
    {
    }

    public partial struct VoskSpkModel
    {
    }

    public partial struct VoskRecognizer
    {
    }

    public partial struct VoskTextProcessor
    {
    }

    public partial struct VoskBatchModel
    {
    }

    public partial struct VoskBatchRecognizer
    {
    }

    public enum VoskEpMode
    {
        VOSK_EP_ANSWER_DEFAULT = 0,
        VOSK_EP_ANSWER_SHORT = 1,
        VOSK_EP_ANSWER_LONG = 2,
        VOSK_EP_ANSWER_VERY_LONG = 3,
    }

    public static unsafe partial class VoskApi
    {
        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskModel* vosk_model_new([NativeTypeName("const char *")] sbyte* model_path);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_model_free(VoskModel* model);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vosk_model_find_word(VoskModel* model, [NativeTypeName("const char *")] sbyte* word);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskSpkModel* vosk_spk_model_new([NativeTypeName("const char *")] sbyte* model_path);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_spk_model_free(VoskSpkModel* model);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskRecognizer* vosk_recognizer_new(VoskModel* model, float sample_rate);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskRecognizer* vosk_recognizer_new_spk(VoskModel* model, float sample_rate, VoskSpkModel* spk_model);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskRecognizer* vosk_recognizer_new_grm(VoskModel* model, float sample_rate, [NativeTypeName("const char *")] sbyte* grammar);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_spk_model(VoskRecognizer* recognizer, VoskSpkModel* spk_model);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_grm(VoskRecognizer* recognizer, [NativeTypeName("const char *")] sbyte* grammar);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_max_alternatives(VoskRecognizer* recognizer, int max_alternatives);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_words(VoskRecognizer* recognizer, int words);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_partial_words(VoskRecognizer* recognizer, int partial_words);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_nlsml(VoskRecognizer* recognizer, int nlsml);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_endpointer_mode(VoskRecognizer* recognizer, [NativeTypeName("VoskEndpointerMode")] VoskEpMode mode);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_set_endpointer_delays(VoskRecognizer* recognizer, float t_start_max, float t_end, float t_max);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vosk_recognizer_accept_waveform(VoskRecognizer* recognizer, [NativeTypeName("const char *")] sbyte* data, int length);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vosk_recognizer_accept_waveform_s(VoskRecognizer* recognizer, [NativeTypeName("const short *")] short* data, int length);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vosk_recognizer_accept_waveform_f(VoskRecognizer* recognizer, [NativeTypeName("const float *")] float* data, int length);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* vosk_recognizer_result(VoskRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* vosk_recognizer_partial_result(VoskRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* vosk_recognizer_final_result(VoskRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_reset(VoskRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_recognizer_free(VoskRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_set_log_level(int log_level);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_gpu_init();

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_gpu_thread_init();

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskBatchModel* vosk_batch_model_new([NativeTypeName("const char *")] sbyte* model_path);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_model_free(VoskBatchModel* model);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_model_wait(VoskBatchModel* model);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskBatchRecognizer* vosk_batch_recognizer_new(VoskBatchModel* model, float sample_rate);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_recognizer_free(VoskBatchRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_recognizer_accept_waveform(VoskBatchRecognizer* recognizer, [NativeTypeName("const char *")] sbyte* data, int length);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_recognizer_set_nlsml(VoskBatchRecognizer* recognizer, int nlsml);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_recognizer_finish_stream(VoskBatchRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* vosk_batch_recognizer_front_result(VoskBatchRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_batch_recognizer_pop(VoskBatchRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int vosk_batch_recognizer_get_pending_chunks(VoskBatchRecognizer* recognizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VoskTextProcessor* vosk_text_processor_new([NativeTypeName("const char *")] sbyte* tagger, [NativeTypeName("const char *")] sbyte* verbalizer);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void vosk_text_processor_free(VoskTextProcessor* processor);

        [DllImport("libvosk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* vosk_text_processor_itn(VoskTextProcessor* processor, [NativeTypeName("const char *")] sbyte* input);
    }
}
