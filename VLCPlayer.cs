using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PopupPersonalGain
{
    internal class VLCPlayer
    {
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_errmsg();

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_clearerr();

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_new(int argc, [MarshalAs(UnmanagedType.LPArray)] string[] argv);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_new_with_builtins(int argc, [MarshalAs(UnmanagedType.LPArray)] string[] argv, [MarshalAs(UnmanagedType.LPArray)] string[] builtins);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_release(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_retain(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_add_intf(IntPtr p_instance, IntPtr name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_wait(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_set_user_agent(IntPtr p_instance, IntPtr name, IntPtr http);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern string libvlc_get_version();

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_get_compiler();

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_get_changeset();

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_free(IntPtr ptr);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_event_attach(IntPtr p_event_manager, int i_event_type, IntPtr f_callback, IntPtr user_data);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_event_detach(IntPtr p_event_manager, int i_event_type, IntPtr f_callback, IntPtr p_user_data);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_event_type_name(int event_type);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_log_subscribe(IntPtr sub, IntPtr cb, IntPtr data);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_log_unsubscribe(IntPtr sub);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_module_description_list_release(IntPtr p_list);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_audio_filter_list_get(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_filter_list_get(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern long libvlc_clock();

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_new_location(IntPtr p_instance, IntPtr psz_mrl);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_new_path(IntPtr p_instance, IntPtr path);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_new_as_node(IntPtr p_instance, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_add_option(IntPtr p_md, IntPtr ppsz_options);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_add_option_flag(IntPtr p_md, IntPtr ppsz_options, int i_flags);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_retain(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_release(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_get_mrl(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_duplicate(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_get_meta(IntPtr p_md, int e_meta);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_set_meta(IntPtr p_md, int e_meta, IntPtr psz_value);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_save_meta(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_get_state(IntPtr p_meta_desc);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_get_stats(IntPtr p_md, IntPtr p_stats);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_subitems(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_event_manager(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern long libvlc_media_get_duration(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_parse(IntPtr media);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_parse_async(IntPtr media);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_is_parsed(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_set_user_data(IntPtr p_md, IntPtr p_new_user_data);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_get_user_data(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_get_tracks_info(IntPtr p_md, out IntPtr tracks);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_player_new(IntPtr p_libvlc_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_player_new_from_media(IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_release(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_retain(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_media(IntPtr p_mi, IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_player_get_media(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_player_event_manager(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_is_playing(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_play(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_pause(IntPtr mp, int do_pause);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_pause(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_stop_async(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_callbacks(IntPtr mp, IntPtr p_lock, IntPtr unlock, IntPtr display, IntPtr opaque);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_format(IntPtr mp, IntPtr chroma, int width, int height, int pitch);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_format_callbacks(IntPtr mp, IntPtr setup, IntPtr cleanup);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_nsobject(IntPtr p_mi, long drawable);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_player_get_nsobject(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_agl(IntPtr p_mi, int drawable);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_agl(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_xwindow(IntPtr p_mi, int drawable);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_xwindow(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_hwnd(IntPtr p_mi, int drawable);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_hwnd(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_set_callbacks(IntPtr mp, IntPtr play, IntPtr pause, IntPtr resume, IntPtr flush, IntPtr drain, IntPtr opaque);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_set_volume_callback(IntPtr mp, IntPtr set_volume);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_set_format_callbacks(IntPtr mp, IntPtr setup, IntPtr cleanup);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_set_format(IntPtr mp, IntPtr format, int rate, int channels);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern long libvlc_media_player_get_length(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern long libvlc_media_player_get_time(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_time(IntPtr p_mi, long i_time, int bfast);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern float libvlc_media_player_get_position(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_position(IntPtr p_mi, float f_pos);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_chapter(IntPtr p_mi, int i_chapter);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_chapter(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_chapter_count(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_will_play(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_chapter_count_for_title(IntPtr p_mi, int i_title);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_set_title(IntPtr p_mi, int i_title);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_title(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_title_count(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_previous_chapter(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_next_chapter(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern float libvlc_media_player_get_rate(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_set_rate(IntPtr p_mi, float rate);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_get_state(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern float libvlc_media_player_get_fps(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_has_vout(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_is_seekable(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_player_can_pause(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_next_frame(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_player_navigate(IntPtr p_mi, int navigate);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_track_description_release(IntPtr p_track_description);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_track_description_list_release(IntPtr p_track_description);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_toggle_fullscreen(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_set_fullscreen(IntPtr p_mi, int b_fullscreen);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_get_fullscreen(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_key_input(IntPtr p_mi, int on);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_mouse_input(IntPtr p_mi, int on);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_size(IntPtr p_mi, int num, out uint px, out uint py);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_height(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_width(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_cursor(IntPtr p_mi, int num, out int px, out int py);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern float libvlc_video_get_scale(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_scale(IntPtr p_mi, float f_factor);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_aspect_ratio(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_aspect_ratio(IntPtr p_mi, IntPtr psz_aspect);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_spu(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_spu_count(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_spu_description(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_set_spu(IntPtr p_mi, int i_spu);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_set_subtitle_file(IntPtr p_mi, IntPtr psz_subtitle);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern long libvlc_video_get_spu_delay(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_set_spu_delay(IntPtr p_mi, long i_delay);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_title_description(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_chapter_description(IntPtr p_mi, int i_title);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_crop_geometry(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_crop_geometry(IntPtr p_mi, IntPtr psz_geometry);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_teletext(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_teletext(IntPtr p_mi, int i_page);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_toggle_teletext(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_track_count(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_track_description(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_track(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_set_track(IntPtr p_mi, int i_track);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_take_snapshot(IntPtr p_mi, int num, IntPtr psz_filepath, int i_width, int i_height);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_deinterlace(IntPtr p_mi, IntPtr psz_mode);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_marquee_int(IntPtr p_mi, int option);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_video_get_marquee_string(IntPtr p_mi, int option);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_marquee_int(IntPtr p_mi, int option, int i_val);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_marquee_string(IntPtr p_mi, int option, IntPtr psz_text);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_logo_int(IntPtr p_mi, int option);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_logo_int(IntPtr p_mi, int option, int value);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_logo_string(IntPtr p_mi, int option, IntPtr psz_value);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_video_get_adjust_int(IntPtr p_mi, int option);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_adjust_int(IntPtr p_mi, int option, int value);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern float libvlc_video_get_adjust_float(IntPtr p_mi, int option);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_video_set_adjust_float(IntPtr p_mi, int option, float value);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_audio_output_list_get(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_output_list_release(IntPtr p_list);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_output_set(IntPtr p_mi, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_output_device_count(IntPtr p_instance, IntPtr psz_audio_output);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_audio_output_device_longname(IntPtr p_instance, IntPtr psz_audio_output, int i_device);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_audio_output_device_id(IntPtr p_instance, IntPtr psz_audio_output, int i_device);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_output_device_set(IntPtr p_mi, IntPtr psz_audio_output, IntPtr psz_device_id);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_output_get_device_type(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_output_set_device_type(IntPtr p_mi, int device_type);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_toggle_mute(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_get_mute(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_audio_set_mute(IntPtr p_mi, int status);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_get_volume(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_set_volume(IntPtr p_mi, int i_volume);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_get_track_count(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_audio_get_track_description(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_get_track(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_set_track(IntPtr p_mi, int i_track);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_get_channel(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_set_channel(IntPtr p_mi, int channel);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern long libvlc_audio_get_delay(IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_audio_set_delay(IntPtr p_mi, long i_delay);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_list_new(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_release(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_retain(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_set_media(IntPtr p_ml, IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_list_media(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_add_media(IntPtr p_ml, IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_insert_media(IntPtr p_ml, IntPtr p_md, int i_pos);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_remove_index(IntPtr p_ml, int i_pos);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_count(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_list_item_at_index(IntPtr p_ml, int i_pos);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_index_of_item(IntPtr p_ml, IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_is_readonly(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_lock(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_unlock(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_list_event_manager(IntPtr p_ml);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_list_player_new(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_release(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_retain(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_list_player_event_manager(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_set_media_player(IntPtr p_mlp, IntPtr p_mi);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_set_media_list(IntPtr p_mlp, IntPtr p_mlist);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_play(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_pause(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_player_is_playing(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_player_get_state(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_player_play_item_at_index(IntPtr p_mlp, int i_index);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_player_play_item(IntPtr p_mlp, IntPtr p_md);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_stop(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_player_next(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_list_player_previous(IntPtr p_mlp);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_list_player_set_playback_mode(IntPtr p_mlp, int e_mode);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_discoverer_new_from_name(IntPtr p_inst, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_media_discoverer_release(IntPtr p_mdis);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_discoverer_localized_name(IntPtr p_mdis);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_discoverer_media_list(IntPtr p_mdis);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_media_discoverer_event_manager(IntPtr p_mdis);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_media_discoverer_is_running(IntPtr p_mdis);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void libvlc_vlm_release(IntPtr p_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_add_broadcast(IntPtr p_instance, IntPtr psz_name, IntPtr psz_input, IntPtr psz_output, int i_options, IntPtr[] ppsz_options, int b_enabled, int b_loop);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_add_vod(IntPtr p_instance, IntPtr psz_name, IntPtr psz_input, int i_options, IntPtr[] ppsz_options, int b_enabled, IntPtr psz_mux);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_del_media(IntPtr p_instance, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_set_enabled(IntPtr p_instance, IntPtr psz_name, int b_enabled);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_set_output(IntPtr p_instance, IntPtr psz_name, IntPtr psz_output);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_set_input(IntPtr p_instance, IntPtr psz_name, IntPtr psz_input);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_add_input(IntPtr p_instance, IntPtr psz_name, IntPtr psz_input);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_set_loop(IntPtr p_instance, IntPtr psz_name, int b_loop);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_set_mux(IntPtr p_instance, IntPtr psz_name, IntPtr psz_mux);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_change_media(IntPtr p_instance, IntPtr psz_name, IntPtr psz_input, IntPtr psz_output, int i_options, IntPtr[] ppsz_options, int b_enabled, int b_loop);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_play_media(IntPtr p_instance, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_stop_media(IntPtr p_instance, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_pause_media(IntPtr p_instance, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_seek_media(IntPtr p_instance, IntPtr psz_name, float f_percentage);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_vlm_show_media(IntPtr p_instance, IntPtr psz_name);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern float libvlc_vlm_get_media_instance_position(IntPtr p_instance, IntPtr psz_name, int i_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_get_media_instance_time(IntPtr p_instance, IntPtr psz_name, int i_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_get_media_instance_length(IntPtr p_instance, IntPtr psz_name, int i_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int libvlc_vlm_get_media_instance_rate(IntPtr p_instance, IntPtr psz_name, int i_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr libvlc_vlm_get_event_manager(IntPtr p_instance);

        private IntPtr libvlc_instance_;
        private IntPtr libvlc_media_player_;

        private double duration_;

        public VLCPlayer(string pluginPath)
        {
            string plugin_arg = "--plugin-path=" + pluginPath;
            string[] arguments = { "-I", "dummy", "--ignore-config", "--no-video-title", plugin_arg };
            libvlc_instance_ = libvlc_new(3, arguments);

            libvlc_media_player_ = libvlc_media_player_new(libvlc_instance_);
        }

        public void SetRenderWindow(Int32 wndHandle)
        {
            if (libvlc_instance_ != IntPtr.Zero && wndHandle != 0)
            {
                libvlc_media_player_set_hwnd(libvlc_media_player_, wndHandle);
            }
        }

        public void LoadFile(string filePath)
        {
            IntPtr libvlc_media = libvlc_media_new_path(libvlc_instance_, Marshal.StringToHGlobalAnsi(filePath));
            if (libvlc_media != IntPtr.Zero)
            {
                libvlc_media_parse(libvlc_media);
                duration_ = libvlc_media_get_duration(libvlc_media) / 1000.0;

                libvlc_media_player_set_media(libvlc_media_player_, libvlc_media);
                libvlc_media_release(libvlc_media);
            }
        }

        public void Play()
        {
            if (libvlc_media_player_ != IntPtr.Zero)
            {
                libvlc_media_player_play(libvlc_media_player_);
            }
        }

        public void Pause()
        {
            if (libvlc_media_player_ != IntPtr.Zero)
            {
                libvlc_media_player_pause(libvlc_media_player_);
            }
        }

        public void Stop()
        {
            if (libvlc_media_player_ != IntPtr.Zero)
            {
                libvlc_media_player_stop_async(libvlc_media_player_);
            }
        }

        public double GetPlayTime()
        {
            return libvlc_media_player_get_time(libvlc_media_player_) / 1000.0;
        }

        public void SetPlayTime(double seekTime)
        {
            libvlc_media_player_set_time(libvlc_media_player_, (Int64)(seekTime * 1000), 0);
        }

        public int GetVolume()
        {
            return libvlc_audio_get_volume(libvlc_media_player_);
        }

        public void SetVolume(int volume)
        {
            libvlc_audio_set_volume(libvlc_media_player_, volume);
        }

        public void SetFullScreen(bool istrue)
        {
            libvlc_set_fullscreen(libvlc_media_player_, istrue ? 1 : 0);
        }

        public double Duration()
        {
            return duration_;
        }
    }
}
